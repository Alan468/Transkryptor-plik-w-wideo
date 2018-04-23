using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transcoder;

namespace ObslugaVLC
{
    public partial class MainWindow : Form
    {
        TranscodeData originalFileData;
        private string vlcPath = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe";

        public MainWindow()
        {
            InitializeComponent();

            SetSizeRadio.Select();
            Scale.Enabled = false;
            VideoHeight.Enabled = true;
            VideoWidth.Enabled = true;

            Scale.DecimalPlaces = 2;
            FPS.Maximum = 1;
            FPS.Maximum = 255;
            SaveFilePathName.Text = "";
            VLCPath.Text = vlcPath;

            foreach (VideoCodec item in Enum.GetValues(typeof(VideoCodec)))
            {
                VideoCodecList.Items.Add(item.ToString());
            }
            VideoCodecList.SelectedIndex = 0;

            foreach (AudioCodec item in Enum.GetValues(typeof(AudioCodec)))
            {
                AudioCodecList.Items.Add(item.ToString());
            }
            AudioCodecList.SelectedIndex = 0;

            foreach (Containers item in Enum.GetValues(typeof(Containers)))
            {
                ContainerList.Items.Add(item.ToString());
            }
            ContainerList.SelectedIndex = 0;

        }

        private void SelectVideoFile_Click(object sender, EventArgs e)
        {
            var formats = "*.mp4; *.avi; *.mpg; *.mpeg; *.3gp; *.ts; *.ogg; *.asf; *.mov; *.mpmjpeg; *.rtp; *.raw";
            var dialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Video files (" + formats.Replace(';', ',') + ") | " + formats
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                FilePathAndName.Text = dialog.FileName;

                var file = new FileInfo(dialog.FileName);

                originalFileData = new TranscodeData
                {
                    FullPath = dialog.FileName,
                    CreationDate = file.CreationTime,
                    Type = file.Extension.ToLower(),
                    Name = file.Name,
                    ModifyDate = file.LastWriteTime,
                    Path = file.Directory?.FullName ?? "Brak ścieżki (DeepWeb?)",
                    Size = file.Length / 1024D,
                    //Width = 0, Wypełnione w GetFileInfo()
                    Length = 0,
                    VideoChanels = 0,
                    VideoBiterate = 0,
                    //AudioBiterate = 0, Wypełnione w GetFileInfo()
                    AudioChanels = 0,
                    //Fps = 0, Wypełnione w GetFileInfo()
                    //Height = 0, Wypełnione w GetFileInfo()
                };

                FileSummary.Text = GetFileInfo(dialog.FileName);
                try
                {
                    VideoHeight.Value = originalFileData.Height;
                    VideoWidth.Value = originalFileData.Width;
                    FPS.Value = (int)originalFileData.Fps;
                    VideoBitrate.Value = originalFileData.VideoBiterate;
                    AudioBitrate.Value = originalFileData.AudioBiterate;
                }
                catch
                {
                    MessageBox.Show("Nie można było załadować danych pliku.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string GetFileInfo(string filePathAndName)
        {
            var summary = "";
            var shell = new Shell32.Shell();
            var objFolder = shell.NameSpace(Path.GetDirectoryName(filePathAndName));
            var folderItem = objFolder.ParseName(Path.GetFileName(filePathAndName));

            for (var i = 0; i < 500; i++)
            {
                var header = objFolder.GetDetailsOf(null, i);
                var value = objFolder.GetDetailsOf(folderItem, i);
                var val = "";

                if (!string.IsNullOrEmpty(header) && !string.IsNullOrEmpty(value))
                {
                    summary += header + ": " + value + "\r\n";

                    switch (header)
                    {
                        case "Wysokość klatki":
                            val = Regex.Replace(value, @"[^\d]", "");
                            originalFileData.Height = int.Parse(val);
                            break;
                        case "Szerokość klatki":
                            val = Regex.Replace(value, @"[^\d]", "");
                            originalFileData.Width = int.Parse(val);
                            break;
                        case "Liczba klatek na sekundę":
                            val = Regex.Replace(value.Split('.')[0], @"[^\d]", "");
                            originalFileData.Fps = float.Parse(val);
                            break;
                        case "Szybkość transmisji bitów":
                            val = Regex.Replace(value, @"[^\d]", "");
                            originalFileData.AudioBiterate = int.Parse(val);
                            break;
                        case "Całkowita szybkość transmisji bitów":
                            val = Regex.Replace(value, @"[^\d]", "");
                            originalFileData.VideoBiterate = int.Parse(val);
                            break;
                        case "Kanały":
                            val = Regex.Replace(value, @"[^\d]", "");
                            originalFileData.Chanels = int.Parse(val);
                            break;
                    }
                }
            }
            return summary;
        }

        private void SaveFilePath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveFilePathName.Text = dialog.SelectedPath + "\\" +
                    (string.IsNullOrEmpty(originalFileData?.Name) ? "NoweWideo" : originalFileData.Name.Split('.')[0]);
            }
        }

        private void StartTranscoding_Click(object sender, EventArgs e)
        {
            if (originalFileData == null || string.IsNullOrEmpty(FilePathAndName.Text) || string.IsNullOrEmpty(SaveFilePathName.Text))
            {
                MessageBox.Show("Nie wybrano pliku wideo lub nie podano ścieżki zapisu (lub jest nie poprawna), albo parametry są nieprawidłowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var param = new TranscodeParams()
            {
                Path = SaveFilePathName.Text,
                Format = ".avi",
                Name = (string.IsNullOrEmpty(originalFileData?.Name) ? "NoweWideo" : originalFileData.Name.Split('.')[0]),
                AudioCodec = (AudioCodec)Enum.Parse(typeof(AudioCodec), AudioCodecList.SelectedItem.ToString()),
                VideoCodec = (VideoCodec)Enum.Parse(typeof(VideoCodec), VideoCodecList.SelectedItem.ToString()),
                FPS = (int)FPS.Value,
                Width = (int)VideoWidth.Value,
                Height = (int)VideoHeight.Value,
                SetSize = SetSizeRadio.Checked,
                VideoBitrate = (int)VideoBitrate.Value,
                AudioBitrate = (int)AudioBitrate.Value,
                Container = ContainerList.SelectedItem.ToString(),
                Scale = (float)Scale.Value,
            };

            var tran = new Transcode(param, originalFileData, vlcPath);
            tran.Execute();

            MessageBox.Show(
                $"Użyte argumenty: {tran.Argumets}\r\n" +
                $"Czas transkodowania: {tran.TargetParams.Time / 1000} sekund\r\n" +
                $"Oryginalny rozmiar: {tran.TargetParams.OriginalSize} kB\r\n" +
                $"Nowy rozmiar: {tran.TargetParams.TranscodedSize} kB\r\n"
                , "Wynik transkodowania", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Program z zadania 'Obsługa VLC' z przedmiotu Archiwizacja i kompresja danych.\nWykonanie:\nAlan Biegun\nJan Snopek\nSekcja 9\n 10-04-2018\n\n");

        }

        private void SetSizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SetSizeRadio.Checked)
            {
                Scale.Enabled = false;
                VideoHeight.Enabled = true;
                VideoWidth.Enabled = true;
            }
        }

        private void SetScaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SetScaleRadio.Checked)
            {
                Scale.Enabled = true;
                VideoHeight.Enabled = false;
                VideoWidth.Enabled = false;
            }
        }

        private void SelectVLCexe_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = false,
                FileName = "vlc.exe",
                Filter = "Exe Files (vlc.exe)|vlc.exe|All Files (vlc.exe)|vlc.exe",
                FilterIndex = 1,
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (dialog.FileName.ToLower().Contains("vlc.exe"))
                {
                    VLCPath.Text = dialog.FileName;
                }
                else
                {
                    MessageBox.Show("Wybrano nieprawidłowy plik. Proszę wybrać vlc.exe!", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}