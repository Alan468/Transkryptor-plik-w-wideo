namespace ObslugaVLC
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileSelectPanel = new System.Windows.Forms.Panel();
            this.SelectVLCexe = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SaveFilePath = new System.Windows.Forms.Button();
            this.VLCPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectVideoFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveFilePathName = new System.Windows.Forms.TextBox();
            this.FilePathAndName = new System.Windows.Forms.TextBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AudioBitrate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AudioCodecList = new System.Windows.Forms.ComboBox();
            this.ContainerList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetScaleRadio = new System.Windows.Forms.RadioButton();
            this.SetSizeRadio = new System.Windows.Forms.RadioButton();
            this.Scale = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.VideoWidth = new System.Windows.Forms.NumericUpDown();
            this.VideoHeight = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.VideoBitrate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.FPS = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VideoCodecList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTranscoding = new System.Windows.Forms.Button();
            this.SelectedFileSummaryPanel = new System.Windows.Forms.Panel();
            this.FileSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSelectPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBitrate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS)).BeginInit();
            this.SelectedFileSummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSelectPanel
            // 
            this.FileSelectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSelectPanel.Controls.Add(this.SelectVLCexe);
            this.FileSelectPanel.Controls.Add(this.label16);
            this.FileSelectPanel.Controls.Add(this.SaveFilePath);
            this.FileSelectPanel.Controls.Add(this.VLCPath);
            this.FileSelectPanel.Controls.Add(this.label11);
            this.FileSelectPanel.Controls.Add(this.SelectVideoFile);
            this.FileSelectPanel.Controls.Add(this.label2);
            this.FileSelectPanel.Controls.Add(this.label1);
            this.FileSelectPanel.Controls.Add(this.SaveFilePathName);
            this.FileSelectPanel.Controls.Add(this.FilePathAndName);
            this.FileSelectPanel.Location = new System.Drawing.Point(12, 12);
            this.FileSelectPanel.Name = "FileSelectPanel";
            this.FileSelectPanel.Size = new System.Drawing.Size(330, 437);
            this.FileSelectPanel.TabIndex = 0;
            // 
            // SelectVLCexe
            // 
            this.SelectVLCexe.Location = new System.Drawing.Point(190, 3);
            this.SelectVLCexe.Name = "SelectVLCexe";
            this.SelectVLCexe.Size = new System.Drawing.Size(138, 20);
            this.SelectVLCexe.TabIndex = 12;
            this.SelectVLCexe.Text = "Wybierz plik VLC.exe";
            this.SelectVLCexe.UseVisualStyleBackColor = true;
            this.SelectVLCexe.Click += new System.EventHandler(this.SelectVLCexe_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(8, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Ścieżka do VLC";
            // 
            // SaveFilePath
            // 
            this.SaveFilePath.Location = new System.Drawing.Point(188, 136);
            this.SaveFilePath.Name = "SaveFilePath";
            this.SaveFilePath.Size = new System.Drawing.Size(136, 20);
            this.SaveFilePath.TabIndex = 6;
            this.SaveFilePath.Text = "Wybierz lokalizacje";
            this.SaveFilePath.UseVisualStyleBackColor = true;
            this.SaveFilePath.Click += new System.EventHandler(this.SaveFilePath_Click);
            // 
            // VLCPath
            // 
            this.VLCPath.Location = new System.Drawing.Point(8, 28);
            this.VLCPath.Margin = new System.Windows.Forms.Padding(5);
            this.VLCPath.Name = "VLCPath";
            this.VLCPath.ReadOnly = true;
            this.VLCPath.Size = new System.Drawing.Size(318, 20);
            this.VLCPath.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(4, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ścieżka zapisu pliku";
            // 
            // SelectVideoFile
            // 
            this.SelectVideoFile.Location = new System.Drawing.Point(188, 60);
            this.SelectVideoFile.Name = "SelectVideoFile";
            this.SelectVideoFile.Size = new System.Drawing.Size(138, 20);
            this.SelectVideoFile.TabIndex = 3;
            this.SelectVideoFile.Text = "Wybierz plik wideo";
            this.SelectVideoFile.UseVisualStyleBackColor = true;
            this.SelectVideoFile.Click += new System.EventHandler(this.SelectVideoFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dozwolone formaty: mp4, mpeg, avi, i pare innych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ścieżka do pliku wideo";
            // 
            // SaveFilePathName
            // 
            this.SaveFilePathName.Location = new System.Drawing.Point(4, 161);
            this.SaveFilePathName.Margin = new System.Windows.Forms.Padding(5);
            this.SaveFilePathName.Name = "SaveFilePathName";
            this.SaveFilePathName.Size = new System.Drawing.Size(318, 20);
            this.SaveFilePathName.TabIndex = 4;
            // 
            // FilePathAndName
            // 
            this.FilePathAndName.Location = new System.Drawing.Point(6, 85);
            this.FilePathAndName.Margin = new System.Windows.Forms.Padding(5);
            this.FilePathAndName.Name = "FilePathAndName";
            this.FilePathAndName.ReadOnly = true;
            this.FilePathAndName.Size = new System.Drawing.Size(318, 20);
            this.FilePathAndName.TabIndex = 0;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.Info);
            this.ControlsPanel.Controls.Add(this.label12);
            this.ControlsPanel.Controls.Add(this.panel2);
            this.ControlsPanel.Controls.Add(this.ContainerList);
            this.ControlsPanel.Controls.Add(this.panel1);
            this.ControlsPanel.Controls.Add(this.StartTranscoding);
            this.ControlsPanel.Location = new System.Drawing.Point(348, 12);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(224, 437);
            this.ControlsPanel.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.Location = new System.Drawing.Point(3, 413);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(216, 18);
            this.Info.TabIndex = 13;
            this.Info.Text = "O Programie";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kontener:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AudioBitrate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AudioCodecList);
            this.panel2.Location = new System.Drawing.Point(3, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 80);
            this.panel2.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 52);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Bit rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kodek: ";
            // 
            // AudioBitrate
            // 
            this.AudioBitrate.Location = new System.Drawing.Point(72, 50);
            this.AudioBitrate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AudioBitrate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AudioBitrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AudioBitrate.Name = "AudioBitrate";
            this.AudioBitrate.Size = new System.Drawing.Size(137, 20);
            this.AudioBitrate.TabIndex = 11;
            this.AudioBitrate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Audio";
            // 
            // AudioCodecList
            // 
            this.AudioCodecList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioCodecList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AudioCodecList.FormattingEnabled = true;
            this.AudioCodecList.Location = new System.Drawing.Point(72, 19);
            this.AudioCodecList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AudioCodecList.Name = "AudioCodecList";
            this.AudioCodecList.Size = new System.Drawing.Size(138, 21);
            this.AudioCodecList.TabIndex = 3;
            // 
            // ContainerList
            // 
            this.ContainerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContainerList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ContainerList.FormattingEnabled = true;
            this.ContainerList.Location = new System.Drawing.Point(68, 325);
            this.ContainerList.Name = "ContainerList";
            this.ContainerList.Size = new System.Drawing.Size(151, 21);
            this.ContainerList.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SetScaleRadio);
            this.panel1.Controls.Add(this.SetSizeRadio);
            this.panel1.Controls.Add(this.Scale);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.VideoWidth);
            this.panel1.Controls.Add(this.VideoHeight);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.VideoBitrate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.FPS);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.VideoCodecList);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 230);
            this.panel1.TabIndex = 5;
            // 
            // SetScaleRadio
            // 
            this.SetScaleRadio.AutoSize = true;
            this.SetScaleRadio.Location = new System.Drawing.Point(127, 201);
            this.SetScaleRadio.Name = "SetScaleRadio";
            this.SetScaleRadio.Size = new System.Drawing.Size(69, 17);
            this.SetScaleRadio.TabIndex = 16;
            this.SetScaleRadio.TabStop = true;
            this.SetScaleRadio.Text = "Użyj skali";
            this.SetScaleRadio.UseVisualStyleBackColor = true;
            this.SetScaleRadio.CheckedChanged += new System.EventHandler(this.SetScaleRadio_CheckedChanged);
            // 
            // SetSizeRadio
            // 
            this.SetSizeRadio.AutoSize = true;
            this.SetSizeRadio.Checked = true;
            this.SetSizeRadio.Location = new System.Drawing.Point(35, 201);
            this.SetSizeRadio.Name = "SetSizeRadio";
            this.SetSizeRadio.Size = new System.Drawing.Size(86, 17);
            this.SetSizeRadio.TabIndex = 15;
            this.SetSizeRadio.TabStop = true;
            this.SetSizeRadio.Text = "Użyj wymiaru";
            this.SetSizeRadio.UseVisualStyleBackColor = true;
            this.SetSizeRadio.CheckedChanged += new System.EventHandler(this.SetSizeRadio_CheckedChanged);
            // 
            // Scale
            // 
            this.Scale.DecimalPlaces = 2;
            this.Scale.Enabled = false;
            this.Scale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Scale.Location = new System.Drawing.Point(71, 173);
            this.Scale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(138, 20);
            this.Scale.TabIndex = 14;
            this.Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 175);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Skala:";
            // 
            // VideoWidth
            // 
            this.VideoWidth.Location = new System.Drawing.Point(71, 145);
            this.VideoWidth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.VideoWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VideoWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VideoWidth.Name = "VideoWidth";
            this.VideoWidth.Size = new System.Drawing.Size(138, 20);
            this.VideoWidth.TabIndex = 12;
            this.VideoWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // VideoHeight
            // 
            this.VideoHeight.Location = new System.Drawing.Point(71, 115);
            this.VideoHeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.VideoHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VideoHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VideoHeight.Name = "VideoHeight";
            this.VideoHeight.Size = new System.Drawing.Size(138, 20);
            this.VideoHeight.TabIndex = 11;
            this.VideoHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bit rate:";
            // 
            // VideoBitrate
            // 
            this.VideoBitrate.Location = new System.Drawing.Point(71, 85);
            this.VideoBitrate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.VideoBitrate.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.VideoBitrate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VideoBitrate.Name = "VideoBitrate";
            this.VideoBitrate.Size = new System.Drawing.Size(138, 20);
            this.VideoBitrate.TabIndex = 9;
            this.VideoBitrate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "FPS: ";
            // 
            // FPS
            // 
            this.FPS.Location = new System.Drawing.Point(71, 55);
            this.FPS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(138, 20);
            this.FPS.TabIndex = 7;
            this.FPS.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Szerokość: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Wysokość:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kodek: ";
            // 
            // VideoCodecList
            // 
            this.VideoCodecList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoCodecList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.VideoCodecList.FormattingEnabled = true;
            this.VideoCodecList.Location = new System.Drawing.Point(72, 24);
            this.VideoCodecList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.VideoCodecList.Name = "VideoCodecList";
            this.VideoCodecList.Size = new System.Drawing.Size(137, 21);
            this.VideoCodecList.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wideo";
            // 
            // StartTranscoding
            // 
            this.StartTranscoding.Location = new System.Drawing.Point(3, 352);
            this.StartTranscoding.Name = "StartTranscoding";
            this.StartTranscoding.Size = new System.Drawing.Size(216, 55);
            this.StartTranscoding.TabIndex = 0;
            this.StartTranscoding.Text = "Rozpocznij transkodowanie";
            this.StartTranscoding.UseVisualStyleBackColor = true;
            this.StartTranscoding.Click += new System.EventHandler(this.StartTranscoding_Click);
            // 
            // SelectedFileSummaryPanel
            // 
            this.SelectedFileSummaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFileSummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedFileSummaryPanel.Controls.Add(this.FileSummary);
            this.SelectedFileSummaryPanel.Controls.Add(this.label3);
            this.SelectedFileSummaryPanel.Location = new System.Drawing.Point(13, 204);
            this.SelectedFileSummaryPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SelectedFileSummaryPanel.Name = "SelectedFileSummaryPanel";
            this.SelectedFileSummaryPanel.Size = new System.Drawing.Size(328, 244);
            this.SelectedFileSummaryPanel.TabIndex = 4;
            // 
            // FileSummary
            // 
            this.FileSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileSummary.Location = new System.Drawing.Point(6, 22);
            this.FileSummary.Multiline = true;
            this.FileSummary.Name = "FileSummary";
            this.FileSummary.ReadOnly = true;
            this.FileSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileSummary.Size = new System.Drawing.Size(312, 215);
            this.FileSummary.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Informacje o wybranym pliku";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.SelectedFileSummaryPanel);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.FileSelectPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainWindow";
            this.Text = "Obsluga VLC";
            this.FileSelectPanel.ResumeLayout(false);
            this.FileSelectPanel.PerformLayout();
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudioBitrate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPS)).EndInit();
            this.SelectedFileSummaryPanel.ResumeLayout(false);
            this.SelectedFileSummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FileSelectPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathAndName;
        private System.Windows.Forms.Button SelectVideoFile;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel SelectedFileSummaryPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartTranscoding;
        private System.Windows.Forms.TextBox FileSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VideoCodecList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AudioCodecList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown FPS;
        private System.Windows.Forms.Button SaveFilePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SaveFilePathName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ContainerList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown AudioBitrate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown VideoBitrate;
        private System.Windows.Forms.NumericUpDown VideoWidth;
        private System.Windows.Forms.NumericUpDown VideoHeight;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.NumericUpDown Scale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton SetScaleRadio;
        private System.Windows.Forms.RadioButton SetSizeRadio;
        private System.Windows.Forms.Button SelectVLCexe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox VLCPath;
    }
}

