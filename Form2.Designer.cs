
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loopBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.rewindBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.ffBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.playlistBtn = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.vidThumbnail = new System.Windows.Forms.PictureBox();
            this.vid1NamePanel = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.vidNameLabel = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.addVideoPanel = new System.Windows.Forms.Panel();
            this.addVideo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nextVidNameLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.soundPanel = new System.Windows.Forms.Panel();
            this.volLabel = new System.Windows.Forms.Label();
            this.colorSlider2 = new MB.Controls.ColorSlider();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideShowPlaylistPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPlaylistCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideVolumeVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastFowardCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewindCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vidThumbnail)).BeginInit();
            this.vid1NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.addVideoPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.soundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loopBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.rewindBtn);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.ffBtn);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.playlistBtn);
            this.panel1.Controls.Add(this.volume);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 92);
            this.panel1.TabIndex = 0;
            // 
            // loopBtn
            // 
            this.loopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loopBtn.BackgroundImage")));
            this.loopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loopBtn.Location = new System.Drawing.Point(741, 30);
            this.loopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(77, 63);
            this.loopBtn.TabIndex = 9;
            this.loopBtn.UseVisualStyleBackColor = true;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(229, 30);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(77, 63);
            this.backBtn.TabIndex = 8;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backButton_Click);
            // 
            // rewindBtn
            // 
            this.rewindBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rewindBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rewindBtn.BackgroundImage")));
            this.rewindBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rewindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewindBtn.Location = new System.Drawing.Point(315, 30);
            this.rewindBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rewindBtn.Name = "rewindBtn";
            this.rewindBtn.Size = new System.Drawing.Size(77, 63);
            this.rewindBtn.TabIndex = 7;
            this.rewindBtn.UseVisualStyleBackColor = true;
            this.rewindBtn.Click += new System.EventHandler(this.rewindBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Location = new System.Drawing.Point(656, 30);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(77, 63);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ffBtn
            // 
            this.ffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ffBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ffBtn.BackgroundImage")));
            this.ffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ffBtn.Location = new System.Drawing.Point(571, 30);
            this.ffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ffBtn.Name = "ffBtn";
            this.ffBtn.Size = new System.Drawing.Size(77, 63);
            this.ffBtn.TabIndex = 5;
            this.ffBtn.UseVisualStyleBackColor = true;
            this.ffBtn.Click += new System.EventHandler(this.ffBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(400, 30);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(77, 63);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayBtn.BackgroundImage")));
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(485, 30);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(77, 63);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.playPause_Click);
            // 
            // playlistBtn
            // 
            this.playlistBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistBtn.BackgroundImage")));
            this.playlistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playlistBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.playlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistBtn.Location = new System.Drawing.Point(0, 30);
            this.playlistBtn.Margin = new System.Windows.Forms.Padding(4);
            this.playlistBtn.Name = "playlistBtn";
            this.playlistBtn.Size = new System.Drawing.Size(77, 62);
            this.playlistBtn.TabIndex = 2;
            this.playlistBtn.UseVisualStyleBackColor = true;
            this.playlistBtn.Click += new System.EventHandler(this.playlistBtn_Click);
            // 
            // volume
            // 
            this.volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume.BackgroundImage")));
            this.volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volume.Dock = System.Windows.Forms.DockStyle.Right;
            this.volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volume.Location = new System.Drawing.Point(990, 30);
            this.volume.Margin = new System.Windows.Forms.Padding(4);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(77, 62);
            this.volume.TabIndex = 1;
            this.volume.UseVisualStyleBackColor = true;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 30);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.Controls.Add(this.colorSlider1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(875, 30);
            this.panel5.TabIndex = 4;
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BarInnerColor = System.Drawing.Color.DarkRed;
            this.colorSlider1.BarOuterColor = System.Drawing.Color.Black;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSlider1.DrawFocusRectangle = false;
            this.colorSlider1.DrawSemitransparentThumb = false;
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.Red;
            this.colorSlider1.ElapsedOuterColor = System.Drawing.Color.Black;
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(0, 0);
            this.colorSlider1.Margin = new System.Windows.Forms.Padding(4);
            this.colorSlider1.MouseEffects = false;
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Size = new System.Drawing.Size(875, 30);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 3;
            this.colorSlider1.Text = "colorSlider1";
            this.colorSlider1.ThumbInnerColor = System.Drawing.Color.Black;
            this.colorSlider1.ThumbOuterColor = System.Drawing.Color.Black;
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.Value = 0;
            this.colorSlider1.ValueChanged += new System.EventHandler(this.colorSlider1_ValueChanged);
            this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
            this.colorSlider1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorSlider1_MouseClick);
            this.colorSlider1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorSlider1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(875, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 30);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "00:00:00/00:00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OpenFile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 47);
            this.panel2.TabIndex = 1;
            // 
            // OpenFile
            // 
            this.OpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFile.BackgroundImage")));
            this.OpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Location = new System.Drawing.Point(0, 0);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(77, 47);
            this.OpenFile.TabIndex = 10;
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.openFile_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRILL MEDIA PLAYER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1Collapsed = true;
            this.splitContainer1.Panel1MinSize = 120;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.soundPanel);
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2MinSize = 470;
            this.splitContainer1.Size = new System.Drawing.Size(1067, 415);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.splitContainer2);
            this.flowLayoutPanel1.Controls.Add(this.addVideoPanel);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.vidThumbnail);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.vid1NamePanel);
            this.splitContainer2.Size = new System.Drawing.Size(325, 107);
            this.splitContainer2.SplitterDistance = 105;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // vidThumbnail
            // 
            this.vidThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vidThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidThumbnail.Location = new System.Drawing.Point(0, 0);
            this.vidThumbnail.Margin = new System.Windows.Forms.Padding(4);
            this.vidThumbnail.Name = "vidThumbnail";
            this.vidThumbnail.Size = new System.Drawing.Size(105, 107);
            this.vidThumbnail.TabIndex = 11;
            this.vidThumbnail.TabStop = false;
            this.vidThumbnail.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // vid1NamePanel
            // 
            this.vid1NamePanel.Controls.Add(this.splitContainer3);
            this.vid1NamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vid1NamePanel.Location = new System.Drawing.Point(0, 0);
            this.vid1NamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.vid1NamePanel.Name = "vid1NamePanel";
            this.vid1NamePanel.Size = new System.Drawing.Size(215, 107);
            this.vid1NamePanel.TabIndex = 0;
            this.vid1NamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.vid1NamePanel_Paint);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.vidNameLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.next2);
            this.splitContainer3.Panel2.Controls.Add(this.back2);
            this.splitContainer3.Size = new System.Drawing.Size(215, 107);
            this.splitContainer3.SplitterDistance = 137;
            this.splitContainer3.TabIndex = 0;
            // 
            // vidNameLabel
            // 
            this.vidNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vidNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vidNameLabel.Location = new System.Drawing.Point(0, 0);
            this.vidNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vidNameLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.vidNameLabel.Name = "vidNameLabel";
            this.vidNameLabel.Size = new System.Drawing.Size(137, 107);
            this.vidNameLabel.TabIndex = 0;
            this.vidNameLabel.Click += new System.EventHandler(this.vid1NameLabel_Click);
            // 
            // next2
            // 
            this.next2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next2.BackgroundImage")));
            this.next2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next2.Dock = System.Windows.Forms.DockStyle.Top;
            this.next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next2.Location = new System.Drawing.Point(0, 0);
            this.next2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(74, 49);
            this.next2.TabIndex = 1;
            this.next2.UseVisualStyleBackColor = false;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // back2
            // 
            this.back2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back2.BackgroundImage")));
            this.back2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back2.Location = new System.Drawing.Point(0, 58);
            this.back2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(74, 49);
            this.back2.TabIndex = 2;
            this.back2.UseVisualStyleBackColor = false;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // addVideoPanel
            // 
            this.addVideoPanel.Controls.Add(this.addVideo);
            this.addVideoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addVideoPanel.Location = new System.Drawing.Point(3, 117);
            this.addVideoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVideoPanel.Name = "addVideoPanel";
            this.addVideoPanel.Size = new System.Drawing.Size(325, 47);
            this.addVideoPanel.TabIndex = 1;
            // 
            // addVideo
            // 
            this.addVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addVideo.BackgroundImage")));
            this.addVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addVideo.Dock = System.Windows.Forms.DockStyle.Right;
            this.addVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVideo.Location = new System.Drawing.Point(274, 0);
            this.addVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVideo.Name = "addVideo";
            this.addVideo.Size = new System.Drawing.Size(51, 47);
            this.addVideo.TabIndex = 3;
            this.addVideo.UseVisualStyleBackColor = false;
            this.addVideo.Click += new System.EventHandler(this.addVideo_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nextVidNameLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 168);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 64);
            this.panel7.TabIndex = 2;
            // 
            // nextVidNameLabel
            // 
            this.nextVidNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextVidNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVidNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextVidNameLabel.Location = new System.Drawing.Point(0, 0);
            this.nextVidNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextVidNameLabel.MaximumSize = new System.Drawing.Size(325, 0);
            this.nextVidNameLabel.Name = "nextVidNameLabel";
            this.nextVidNameLabel.Size = new System.Drawing.Size(325, 64);
            this.nextVidNameLabel.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 100);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // soundPanel
            // 
            this.soundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.soundPanel.Controls.Add(this.volLabel);
            this.soundPanel.Controls.Add(this.colorSlider2);
            this.soundPanel.Location = new System.Drawing.Point(989, 204);
            this.soundPanel.Margin = new System.Windows.Forms.Padding(4);
            this.soundPanel.Name = "soundPanel";
            this.soundPanel.Size = new System.Drawing.Size(77, 210);
            this.soundPanel.TabIndex = 1;
            this.soundPanel.Visible = false;
            this.soundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.BackColor = System.Drawing.Color.Black;
            this.volLabel.ForeColor = System.Drawing.Color.Red;
            this.volLabel.Location = new System.Drawing.Point(25, 15);
            this.volLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(44, 17);
            this.volLabel.TabIndex = 2;
            this.volLabel.Text = "100%";
            this.volLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // colorSlider2
            // 
            this.colorSlider2.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider2.BarInnerColor = System.Drawing.Color.DarkRed;
            this.colorSlider2.BarOuterColor = System.Drawing.Color.Black;
            this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.DrawFocusRectangle = false;
            this.colorSlider2.DrawSemitransparentThumb = false;
            this.colorSlider2.ElapsedInnerColor = System.Drawing.Color.Red;
            this.colorSlider2.ElapsedOuterColor = System.Drawing.Color.Black;
            this.colorSlider2.LargeChange = ((uint)(5u));
            this.colorSlider2.Location = new System.Drawing.Point(28, 46);
            this.colorSlider2.Margin = new System.Windows.Forms.Padding(4);
            this.colorSlider2.MouseEffects = false;
            this.colorSlider2.Name = "colorSlider2";
            this.colorSlider2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider2.Size = new System.Drawing.Size(33, 146);
            this.colorSlider2.SmallChange = ((uint)(1u));
            this.colorSlider2.TabIndex = 2;
            this.colorSlider2.Text = "colorSlider2";
            this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.Value = 100;
            this.colorSlider2.ValueChanged += new System.EventHandler(this.colorSlider2_ValueChanged);
            this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1067, 415);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer1_CurrentItemChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OFD
            // 
            this.OFD.Multiselect = true;
            this.OFD.RestoreDirectory = true;
            this.OFD.Title = "Open Media";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 52);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileCtrlOToolStripMenuItem,
            this.hideShowPlaylistPToolStripMenuItem,
            this.loopLToolStripMenuItem,
            this.playSpaceToolStripMenuItem,
            this.pauseSpaceToolStripMenuItem,
            this.addToPlaylistCtrlAToolStripMenuItem,
            this.showHideVolumeVToolStripMenuItem,
            this.fastFowardCtrlTToolStripMenuItem,
            this.rewindCtrlRToolStripMenuItem,
            this.stopCtrlSToolStripMenuItem,
            this.nextCtrlToolStripMenuItem,
            this.backCtrlToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // openFileCtrlOToolStripMenuItem
            // 
            this.openFileCtrlOToolStripMenuItem.Name = "openFileCtrlOToolStripMenuItem";
            this.openFileCtrlOToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.openFileCtrlOToolStripMenuItem.Text = "Open File (Ctrl + O)";
            this.openFileCtrlOToolStripMenuItem.Click += new System.EventHandler(this.openFileCtrlOToolStripMenuItem_Click);
            // 
            // hideShowPlaylistPToolStripMenuItem
            // 
            this.hideShowPlaylistPToolStripMenuItem.Name = "hideShowPlaylistPToolStripMenuItem";
            this.hideShowPlaylistPToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.hideShowPlaylistPToolStripMenuItem.Text = "Hide/Show playlist (P)";
            this.hideShowPlaylistPToolStripMenuItem.Click += new System.EventHandler(this.hideShowPlaylistPToolStripMenuItem_Click);
            // 
            // loopLToolStripMenuItem
            // 
            this.loopLToolStripMenuItem.Name = "loopLToolStripMenuItem";
            this.loopLToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.loopLToolStripMenuItem.Text = "Loop (L)";
            this.loopLToolStripMenuItem.Click += new System.EventHandler(this.loopLToolStripMenuItem_Click);
            // 
            // playSpaceToolStripMenuItem
            // 
            this.playSpaceToolStripMenuItem.Name = "playSpaceToolStripMenuItem";
            this.playSpaceToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.playSpaceToolStripMenuItem.Text = "Play/Pause (Space)";
            this.playSpaceToolStripMenuItem.Click += new System.EventHandler(this.playSpaceToolStripMenuItem_Click);
            // 
            // pauseSpaceToolStripMenuItem
            // 
            this.pauseSpaceToolStripMenuItem.Name = "pauseSpaceToolStripMenuItem";
            this.pauseSpaceToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.pauseSpaceToolStripMenuItem.Text = "Pause(Space)";
            // 
            // addToPlaylistCtrlAToolStripMenuItem
            // 
            this.addToPlaylistCtrlAToolStripMenuItem.Name = "addToPlaylistCtrlAToolStripMenuItem";
            this.addToPlaylistCtrlAToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.addToPlaylistCtrlAToolStripMenuItem.Text = "Add to Playlist (Ctrl + A)";
            this.addToPlaylistCtrlAToolStripMenuItem.Click += new System.EventHandler(this.addToPlaylistCtrlAToolStripMenuItem_Click);
            // 
            // showHideVolumeVToolStripMenuItem
            // 
            this.showHideVolumeVToolStripMenuItem.Name = "showHideVolumeVToolStripMenuItem";
            this.showHideVolumeVToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.showHideVolumeVToolStripMenuItem.Text = "Show/Hide volume (V)";
            this.showHideVolumeVToolStripMenuItem.Click += new System.EventHandler(this.showHideVolumeVToolStripMenuItem_Click);
            // 
            // fastFowardCtrlTToolStripMenuItem
            // 
            this.fastFowardCtrlTToolStripMenuItem.Name = "fastFowardCtrlTToolStripMenuItem";
            this.fastFowardCtrlTToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.fastFowardCtrlTToolStripMenuItem.Text = "Fast Foward (Ctrl + T)";
            this.fastFowardCtrlTToolStripMenuItem.Click += new System.EventHandler(this.fastFowardCtrlTToolStripMenuItem_Click);
            // 
            // rewindCtrlRToolStripMenuItem
            // 
            this.rewindCtrlRToolStripMenuItem.Name = "rewindCtrlRToolStripMenuItem";
            this.rewindCtrlRToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.rewindCtrlRToolStripMenuItem.Text = "Rewind (Ctrl + R)";
            this.rewindCtrlRToolStripMenuItem.Click += new System.EventHandler(this.rewindCtrlRToolStripMenuItem_Click);
            // 
            // stopCtrlSToolStripMenuItem
            // 
            this.stopCtrlSToolStripMenuItem.Name = "stopCtrlSToolStripMenuItem";
            this.stopCtrlSToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.stopCtrlSToolStripMenuItem.Text = "Stop (Ctrl + S)";
            this.stopCtrlSToolStripMenuItem.Click += new System.EventHandler(this.stopCtrlSToolStripMenuItem_Click);
            // 
            // nextCtrlToolStripMenuItem
            // 
            this.nextCtrlToolStripMenuItem.Name = "nextCtrlToolStripMenuItem";
            this.nextCtrlToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.nextCtrlToolStripMenuItem.Text = "Next (Ctrl + →)";
            this.nextCtrlToolStripMenuItem.Click += new System.EventHandler(this.nextCtrlToolStripMenuItem_Click);
            // 
            // backCtrlToolStripMenuItem
            // 
            this.backCtrlToolStripMenuItem.Name = "backCtrlToolStripMenuItem";
            this.backCtrlToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.backCtrlToolStripMenuItem.Text = "Back (Ctrl + ←)";
            this.backCtrlToolStripMenuItem.Click += new System.EventHandler(this.backCtrlToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRILL MEDIA PLAYER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vidThumbnail)).EndInit();
            this.vid1NamePanel.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.addVideoPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.soundPanel.ResumeLayout(false);
            this.soundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button playlistBtn;
        private System.Windows.Forms.Button volume;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button ffBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button loopBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button rewindBtn;
        private System.Windows.Forms.ListView listView1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private MB.Controls.ColorSlider colorSlider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel soundPanel;
        private MB.Controls.ColorSlider colorSlider2;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox vidThumbnail;
        private System.Windows.Forms.Panel vid1NamePanel;
        private System.Windows.Forms.Label vidNameLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.Panel addVideoPanel;
        private System.Windows.Forms.Button addVideo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label nextVidNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideShowPlaylistPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideVolumeVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastFowardCtrlTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewindCtrlRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backCtrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}