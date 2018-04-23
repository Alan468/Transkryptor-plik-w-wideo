using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcoder
{
    public class Transcode
    {
        private string VlcPath;
        public TranscodeParams TargetParams { get; set; }
        public TranscodeData orgFile { get; set; }
        private Stopwatch watch = Stopwatch.StartNew();// Odmierzanie czasu kompresji plików
        private ProcessStartInfo startInfo = new ProcessStartInfo();// Uruchomienie 7zip z zadanymi argumentami


        public string Argumets
        {
            get
            {
                var args = "\"" + orgFile.FullPath + "\""; // vlc.exe "Plik/Do/Transkodowania.avi"
                args += " --sout=#transcode{"; // --sout=#transcode{ OPCJE }

                #region OpcjeWejściowe
                #region VideoCodec
                args += "vcodec=" + TargetParams.VideoCodec.ToString();
                args += ",fps=" + TargetParams.FPS;

                if (TargetParams.SetSize)
                {
                    args += ",width=" + TargetParams.Width;
                    args += ",height=" + TargetParams.Height;
                }
                else
                {
                    args += ",scale=" + TargetParams.Scale.ToString().Replace(',','.');
                }
                args += ",vb=" + TargetParams.VideoBitrate;
                #endregion

                #region AudioCodec
                args += ",acodec=" + TargetParams.AudioCodec.ToString();
                args += ",ab=" + TargetParams.AudioBitrate.ToString();
                //args += ",chanels=" + 2;
                #endregion 
                #endregion

                args += "}:standard{"; // --sout=#transcode{ OPCJE }:standard{ OPCJE }

                #region OpcjeWyjściowe

                args += "access=file";
                args += ",mux=" + TargetParams.Container;
                args += ",dst=\"" + TargetParams.Path + "." + TargetParams.Container.ToString() + "\"";

                #endregion

                args += "} vlc://quit";// --sout=#transcode{ OPCJE }:standard{ OPCJE } vlc://quit

                return args;
            }
        }

        public Transcode(TranscodeParams targetParams, TranscodeData data, string vlcPath = "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe")
        {
            VlcPath = vlcPath;
            TargetParams = targetParams;
            orgFile = data;
        }

        public void Execute()
        {
            var args = Argumets;

            startInfo.FileName = VlcPath;
            TargetParams.OriginalSize = GetSize(orgFile.FullPath);// Pobierz oryginalny rozmiar

            startInfo.Arguments = Argumets;// Utwórz argumenty dla podanego przypadku

            // Zresetuj i uruchom licznik
            watch.Reset();
            watch.Start();

            Process.Start(startInfo)?.WaitForExit();// Wykonaj program

            watch.Stop();// Zatrzymaj licznik
            
            TargetParams.Time = watch.ElapsedMilliseconds;// Zapisz czas wykonywania

            TargetParams.TranscodedSize = GetSize(TargetParams.Path + "." + TargetParams.Container.ToString());// Pobranie rozmiaru po transkrypcji
        }

        // Pobranie skompresowanego archiwum
        public double GetSize(string path)
        {
            var compressedSize = new FileInfo(path).Length / 1024;
            return compressedSize;
        }
    }
}
