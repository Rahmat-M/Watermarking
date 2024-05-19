namespace Watermarking
{
    partial class Form1
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
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnUploadWatermark = new System.Windows.Forms.Button();
            this.btnInsertWatermark = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.UploadWatermarked = new System.Windows.Forms.Button();
            this.btnExtractWatermark = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnSaveExtractedWM = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnMenuInsert = new FontAwesome.Sharp.IconButton();
            this.btnMenuExtract = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBoxInserted = new System.Windows.Forms.PictureBox();
            this.pictureBoxExtractedWM = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBoxWatermark = new System.Windows.Forms.PictureBox();
            this.pictureBoxWatermarked = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelHome = new Watermarking.Home();
            this.panelAbout = new Watermarking.About();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInserted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedWM)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermarked)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.Location = new System.Drawing.Point(162, 427);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(102, 39);
            this.btnUploadImage.TabIndex = 0;
            this.btnUploadImage.Text = "Load Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnUploadWatermark
            // 
            this.btnUploadWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnUploadWatermark.FlatAppearance.BorderSize = 0;
            this.btnUploadWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadWatermark.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadWatermark.ForeColor = System.Drawing.Color.White;
            this.btnUploadWatermark.Location = new System.Drawing.Point(452, 427);
            this.btnUploadWatermark.Name = "btnUploadWatermark";
            this.btnUploadWatermark.Size = new System.Drawing.Size(168, 39);
            this.btnUploadWatermark.TabIndex = 1;
            this.btnUploadWatermark.Text = "Load Watermark";
            this.btnUploadWatermark.UseVisualStyleBackColor = false;
            this.btnUploadWatermark.Click += new System.EventHandler(this.btnUploadWatermark_Click);
            // 
            // btnInsertWatermark
            // 
            this.btnInsertWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnInsertWatermark.FlatAppearance.BorderSize = 0;
            this.btnInsertWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertWatermark.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertWatermark.ForeColor = System.Drawing.Color.White;
            this.btnInsertWatermark.Location = new System.Drawing.Point(653, 427);
            this.btnInsertWatermark.Name = "btnInsertWatermark";
            this.btnInsertWatermark.Size = new System.Drawing.Size(136, 39);
            this.btnInsertWatermark.TabIndex = 2;
            this.btnInsertWatermark.Text = "Insert Watermark";
            this.btnInsertWatermark.UseVisualStyleBackColor = false;
            this.btnInsertWatermark.Click += new System.EventHandler(this.btnInsertWatermark_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(985, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UploadWatermarked
            // 
            this.UploadWatermarked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.UploadWatermarked.FlatAppearance.BorderSize = 0;
            this.UploadWatermarked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadWatermarked.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadWatermarked.ForeColor = System.Drawing.Color.White;
            this.UploadWatermarked.Location = new System.Drawing.Point(452, 427);
            this.UploadWatermarked.Name = "UploadWatermarked";
            this.UploadWatermarked.Size = new System.Drawing.Size(168, 39);
            this.UploadWatermarked.TabIndex = 4;
            this.UploadWatermarked.Text = "Load Watermarked IMG";
            this.UploadWatermarked.UseVisualStyleBackColor = false;
            this.UploadWatermarked.Click += new System.EventHandler(this.UploadWatermarked_Click);
            // 
            // btnExtractWatermark
            // 
            this.btnExtractWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnExtractWatermark.FlatAppearance.BorderSize = 0;
            this.btnExtractWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractWatermark.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractWatermark.ForeColor = System.Drawing.Color.White;
            this.btnExtractWatermark.Location = new System.Drawing.Point(653, 427);
            this.btnExtractWatermark.Name = "btnExtractWatermark";
            this.btnExtractWatermark.Size = new System.Drawing.Size(136, 39);
            this.btnExtractWatermark.TabIndex = 5;
            this.btnExtractWatermark.Text = "Extract Watermark";
            this.btnExtractWatermark.UseVisualStyleBackColor = false;
            this.btnExtractWatermark.Click += new System.EventHandler(this.btnExtractWatermark_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(12, 505);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(64, 13);
            this.lblLoading.TabIndex = 12;
            this.lblLoading.Text = "Please Wait";
            this.lblLoading.Visible = false;
            // 
            // btnSaveExtractedWM
            // 
            this.btnSaveExtractedWM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.btnSaveExtractedWM.FlatAppearance.BorderSize = 0;
            this.btnSaveExtractedWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExtractedWM.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExtractedWM.ForeColor = System.Drawing.Color.White;
            this.btnSaveExtractedWM.Location = new System.Drawing.Point(985, 427);
            this.btnSaveExtractedWM.Name = "btnSaveExtractedWM";
            this.btnSaveExtractedWM.Size = new System.Drawing.Size(75, 39);
            this.btnSaveExtractedWM.TabIndex = 13;
            this.btnSaveExtractedWM.Text = "Save";
            this.btnSaveExtractedWM.UseVisualStyleBackColor = false;
            this.btnSaveExtractedWM.Click += new System.EventHandler(this.btnSaveExtractedWM_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(57)))), ((int)(((byte)(241)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnMenuInsert);
            this.panelMenu.Controls.Add(this.btnMenuExtract);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(0, 604);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1238, 77);
            this.panelMenu.TabIndex = 15;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 32;
            this.btnAbout.Location = new System.Drawing.Point(930, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(17, 0, 36, 0);
            this.btnAbout.Size = new System.Drawing.Size(310, 77);
            this.btnAbout.TabIndex = 31;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.Location = new System.Drawing.Point(620, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(17, 0, 36, 0);
            this.btnHome.Size = new System.Drawing.Size(310, 77);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenuInsert
            // 
            this.btnMenuInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenuInsert.FlatAppearance.BorderSize = 0;
            this.btnMenuInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInsert.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInsert.ForeColor = System.Drawing.Color.White;
            this.btnMenuInsert.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnMenuInsert.IconColor = System.Drawing.Color.White;
            this.btnMenuInsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuInsert.IconSize = 32;
            this.btnMenuInsert.Location = new System.Drawing.Point(310, 0);
            this.btnMenuInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuInsert.Name = "btnMenuInsert";
            this.btnMenuInsert.Padding = new System.Windows.Forms.Padding(17, 0, 36, 0);
            this.btnMenuInsert.Size = new System.Drawing.Size(310, 77);
            this.btnMenuInsert.TabIndex = 30;
            this.btnMenuInsert.Text = "Insert Watermark";
            this.btnMenuInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuInsert.UseVisualStyleBackColor = true;
            this.btnMenuInsert.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnMenuExtract
            // 
            this.btnMenuExtract.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenuExtract.FlatAppearance.BorderSize = 0;
            this.btnMenuExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuExtract.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuExtract.ForeColor = System.Drawing.Color.White;
            this.btnMenuExtract.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnMenuExtract.IconColor = System.Drawing.Color.White;
            this.btnMenuExtract.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuExtract.IconSize = 32;
            this.btnMenuExtract.Location = new System.Drawing.Point(0, 0);
            this.btnMenuExtract.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuExtract.Name = "btnMenuExtract";
            this.btnMenuExtract.Padding = new System.Windows.Forms.Padding(17, 0, 36, 0);
            this.btnMenuExtract.Size = new System.Drawing.Size(310, 77);
            this.btnMenuExtract.TabIndex = 29;
            this.btnMenuExtract.Text = "Extract Watermark";
            this.btnMenuExtract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuExtract.UseVisualStyleBackColor = true;
            this.btnMenuExtract.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.bunifuCards2);
            this.mainPanel.Controls.Add(this.bunifuCards1);
            this.mainPanel.Controls.Add(this.btnSave);
            this.mainPanel.Controls.Add(this.bunifuCards3);
            this.mainPanel.Controls.Add(this.lblLoading);
            this.mainPanel.Controls.Add(this.btnUploadImage);
            this.mainPanel.Controls.Add(this.btnInsertWatermark);
            this.mainPanel.Controls.Add(this.btnUploadWatermark);
            this.mainPanel.Controls.Add(this.btnSaveExtractedWM);
            this.mainPanel.Controls.Add(this.progressBar1);
            this.mainPanel.Controls.Add(this.UploadWatermarked);
            this.mainPanel.Controls.Add(this.btnExtractWatermark);
            this.mainPanel.Location = new System.Drawing.Point(0, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1238, 560);
            this.mainPanel.TabIndex = 16;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 30;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.BottomShadow = false;
            this.bunifuCards2.color = System.Drawing.Color.White;
            this.bunifuCards2.Controls.Add(this.pictureBoxInserted);
            this.bunifuCards2.Controls.Add(this.pictureBoxExtractedWM);
            this.bunifuCards2.IndicatorColor = System.Drawing.Color.White;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.LeftShadow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(818, 68);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.RightShadow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(392, 342);
            this.bunifuCards2.TabIndex = 15;
            // 
            // pictureBoxInserted
            // 
            this.pictureBoxInserted.Location = new System.Drawing.Point(23, 22);
            this.pictureBoxInserted.Name = "pictureBoxInserted";
            this.pictureBoxInserted.Size = new System.Drawing.Size(346, 294);
            this.pictureBoxInserted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInserted.TabIndex = 10;
            this.pictureBoxInserted.TabStop = false;
            // 
            // pictureBoxExtractedWM
            // 
            this.pictureBoxExtractedWM.Location = new System.Drawing.Point(23, 22);
            this.pictureBoxExtractedWM.Name = "pictureBoxExtractedWM";
            this.pictureBoxExtractedWM.Size = new System.Drawing.Size(346, 294);
            this.pictureBoxExtractedWM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExtractedWM.TabIndex = 11;
            this.pictureBoxExtractedWM.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 30;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.BottomShadow = false;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.pictureBoxMain);
            this.bunifuCards1.IndicatorColor = System.Drawing.Color.White;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.LeftShadow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(31, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.RightShadow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(392, 342);
            this.bunifuCards1.TabIndex = 14;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(28, 22);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(339, 294);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 6;
            this.pictureBoxMain.TabStop = false;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(107)))), ((int)(((byte)(228)))));
            this.bunifuCards3.BorderRadius = 30;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.BottomShadow = false;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(107)))), ((int)(((byte)(228)))));
            this.bunifuCards3.Controls.Add(this.pictureBoxWatermark);
            this.bunifuCards3.Controls.Add(this.pictureBoxWatermarked);
            this.bunifuCards3.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(107)))), ((int)(((byte)(228)))));
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.LeftShadow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(437, 68);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = false;
            this.bunifuCards3.RightShadow = false;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(368, 342);
            this.bunifuCards3.TabIndex = 16;
            // 
            // pictureBoxWatermark
            // 
            this.pictureBoxWatermark.Location = new System.Drawing.Point(15, 22);
            this.pictureBoxWatermark.Name = "pictureBoxWatermark";
            this.pictureBoxWatermark.Size = new System.Drawing.Size(339, 294);
            this.pictureBoxWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWatermark.TabIndex = 7;
            this.pictureBoxWatermark.TabStop = false;
            // 
            // pictureBoxWatermarked
            // 
            this.pictureBoxWatermarked.Location = new System.Drawing.Point(15, 22);
            this.pictureBoxWatermarked.Name = "pictureBoxWatermarked";
            this.pictureBoxWatermarked.Size = new System.Drawing.Size(337, 294);
            this.pictureBoxWatermarked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWatermarked.TabIndex = 8;
            this.pictureBoxWatermarked.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(1150, 5);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(59, 35);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(0, 45);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1238, 560);
            this.panelHome.TabIndex = 17;
            // 
            // panelAbout
            // 
            this.panelAbout.Location = new System.Drawing.Point(0, 45);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(1238, 560);
            this.panelAbout.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Watermark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(837, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Watermarked Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Watermarked Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(837, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Extracted Watermark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 681);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInserted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedWM)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWatermarked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnUploadWatermark;
        private System.Windows.Forms.Button btnInsertWatermark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button UploadWatermarked;
        private System.Windows.Forms.Button btnExtractWatermark;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox pictureBoxWatermark;
        private System.Windows.Forms.PictureBox pictureBoxWatermarked;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBoxInserted;
        private System.Windows.Forms.PictureBox pictureBoxExtractedWM;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnSaveExtractedWM;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMenuInsert;
        private FontAwesome.Sharp.IconButton btnMenuExtract;
        private System.Windows.Forms.Panel mainPanel;
        private Home panelHome;
        private About panelAbout;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

