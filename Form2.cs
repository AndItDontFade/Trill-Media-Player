using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Security.Permissions;
using System.Diagnostics;
using WMPLib;
//space = play
//Ctrl + O = open file.
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int currPlaylistIndex = 0;
        bool loopMode = false;
        bool ff = false; //fast forward
        bool rewind = false;
        static object Lock = new object();
        double vidDuration;
        WMPLib.IWMPPlaylist playlist;
        public Form2()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //close button
        {
            Application.Exit();
        }

        private void playPause_Click(object sender, EventArgs e) //play pause
        {
            if((ff || rewind) == true)
            {
                if (ff == true)
                    ffBtn_Click(sender, e);
                else
                    rewindBtn_Click(sender, e);
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused) {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
                togglePauseBtnImage();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timer1.Stop();
                togglePlayBtnImage();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int count = axWindowsMediaPlayer1.currentPlaylist.count;
            if (loopMode || (currPlaylistIndex < count - 1)){
                axWindowsMediaPlayer1.Ctlcontrols.next();
                currPlaylistIndex = (currPlaylistIndex + 1) % (count);
                setVidLabel();
                setNextVidNameText();
            }
        }

        private void loopBtn_Click(object sender, EventArgs e) //loop button
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
            if (axWindowsMediaPlayer1.currentPlaylist.count > 1) {
                if(axWindowsMediaPlayer1.settings.getMode("loop") == true)
                {
                    axWindowsMediaPlayer1.settings.setMode("loop", false);
                }
                else { axWindowsMediaPlayer1.settings.setMode("loop", true); }
            }
            else if (axWindowsMediaPlayer1.settings.playCount != 100)
            {
                axWindowsMediaPlayer1.settings.playCount = 100;
            }
            else
            {
                axWindowsMediaPlayer1.settings.playCount = 0;
            }
            loopMode = !loopMode;
            toggleLoopButton();
        }

        private void toggleLoopButton()
        {
            string dir = Environment.CurrentDirectory;
            if (loopMode)
            {
                string path = dir + @"\buttons\loopActive.png";
                loopBtn.BackgroundImage = Image.FromFile(path);
            }
            else
            {
                string path = dir + @"\buttons\loop.png";
                loopBtn.BackgroundImage = Image.FromFile(path);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (currPlaylistIndex > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.previous();
                currPlaylistIndex--;
                setVidLabel();
                setNextVidNameText();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void expButton_Click(object sender, EventArgs e) // full click
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimButton_Click(object sender, EventArgs e) //minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = colorSlider2.Value;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void volume_Click(object sender, EventArgs e)
        {
            if(soundPanel.Visible == false)
            {
                soundPanel.Visible = true;
            }
            else
            {
                soundPanel.Visible = false;
            }
        }

        private void colorSlider2_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = colorSlider2.Value;
            volLabel.Text = colorSlider2.Value + "%";
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState != 0) {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                timer1.Stop();
                label2.Text = "00:00:00/00:00:00";
                colorSlider1.Value = 0;
            }
        }

        private void playlistBtn_Click(object sender, EventArgs e)
        {
            if(splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else {splitContainer1.Panel1Collapsed = true;}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void openFile_click(object sender, EventArgs e) //openFile
        {
            currPlaylistIndex = 0;
            playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("currentPlaylist");
            WMPLib.IWMPMedia media;
            OFD.Filter = "Video Files(*.MP4;*.MKV;*.M4V;*.AVI;*MOV)|*.MP4;*.MKV;*.M4V;*.AVI;*MOV";
            DialogResult ofd = OFD.ShowDialog();
            if (ofd == DialogResult.OK) {
                try {
                    foreach(string file in OFD.FileNames){
                        media = axWindowsMediaPlayer1.newMedia(file);
                        playlist.appendItem(media);
                    }
                    axWindowsMediaPlayer1.currentPlaylist = playlist;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //axWindowsMediaPlayer1.URL = OFD.FileName;
                }
                catch (Exception) { }
                timer1.Start();
                setVidLabel();
            }
        }

        private void setVidLabel()
        {
            vidNameLabel.Text = "PLAYING " + axWindowsMediaPlayer1.currentPlaylist.Item[currPlaylistIndex].name;
        }

        

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double timeElapsed = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            if(timeElapsed > 0)
            {
                vidDuration = axWindowsMediaPlayer1.currentMedia.duration;
                TimeSpan tE = TimeSpan.FromSeconds(timeElapsed);
                TimeSpan vD = TimeSpan.FromSeconds(vidDuration);
                label2.Text = tE.ToString(@"hh\:mm\:ss") + "/" + vD.ToString(@"hh\:mm\:ss");
                colorSlider1.Value = (int)((axWindowsMediaPlayer1.Ctlcontrols.currentPosition / vidDuration) * 100);
            }
        }

        private void togglePlayBtnImage()
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + @"\buttons\play.png";
            PlayBtn.BackgroundImage = Image.FromFile(path);
        }

        private void togglePauseBtnImage()
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + @"\buttons\pause.png";
            PlayBtn.BackgroundImage = Image.FromFile(path);
        }

        private void toggleFFBtnImage()
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + @"\buttons\foward.png";
            ffBtn.BackgroundImage = Image.FromFile(path);
        }

        private void toggleRewBtnImage()
        {
            string dir = Environment.CurrentDirectory;
            string path = dir + @"\buttons\rewind.png";
            rewindBtn.BackgroundImage = Image.FromFile(path);
        }
        private void ffBtn_Click(object sender, EventArgs e) //fast forward
        {
            if (axWindowsMediaPlayer1.playState == 0)
                return;
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                playPause_Click(sender, e);
            }
            if (ff == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                ff = false;
                togglePauseBtnImage();
                toggleFFBtnImage();
            }
            else {
                axWindowsMediaPlayer1.Ctlcontrols.fastForward();
                ff = true;
                string dir = Environment.CurrentDirectory;
                string path = dir + @"\buttons\fowardActive.png";
                ffBtn.BackgroundImage = Image.FromFile(path);
                togglePlayBtnImage();
            }
        }

        private void rewindBtn_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == 0)
                return;
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                playPause_Click(sender, e);
            } 
            if (rewind == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                rewind = false;
                togglePauseBtnImage();
                toggleRewBtnImage();
            }
            else {
                axWindowsMediaPlayer1.Ctlcontrols.fastReverse();
                rewind = true;
                string dir = Environment.CurrentDirectory;
                string path = dir + @"\buttons\rewindActive.png";
                rewindBtn.BackgroundImage = Image.FromFile(path);
                togglePlayBtnImage();
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && axWindowsMediaPlayer1.playState != 0)
            {
                playPause_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape && axWindowsMediaPlayer1.playState != 0)
            {
                if (!axWindowsMediaPlayer1.fullScreen)
                {
                    axWindowsMediaPlayer1.fullScreen = true;
                }
                else { axWindowsMediaPlayer1.fullScreen = false; }
            }
            else if (e.Control == true && e.KeyCode == Keys.O)
            {
                openFile_click(sender, e);
            }
            else if (e.KeyCode == Keys.L)
            {
                loopBtn_Click(sender, e);
            }
            else if (e.Control == true && e.KeyCode == Keys.Right)
                nextButton_Click(sender, e);
            else if (e.Control == true && e.KeyCode == Keys.Left)
                backButton_Click(sender, e);
            else if (e.Control == true && e.KeyCode == Keys.T)
                ffBtn_Click(sender, e);
            else if (e.Control == true && e.KeyCode == Keys.R)
                rewindBtn_Click(sender, e);
            else if (e.KeyCode == Keys.P)
                splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            else if (e.Control == true && e.KeyCode == Keys.A)
                addVideo_Click(sender, e);
            else if (e.KeyCode == Keys.V)
                volume_Click(sender, e);
            else if (e.Control == true && e.KeyCode == Keys.S)
                stopBtn_Click(sender, e);
        }

        private void colorSlider1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void colorSlider1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            if (axWindowsMediaPlayer1.playState != 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ((double)colorSlider1.Value / 100) * axWindowsMediaPlayer1.currentMedia.duration;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
            else { colorSlider1.Value = 0; }
            
        }

        private void colorSlider1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void vid1NamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vid1NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void next2_Click(object sender, EventArgs e)
        {
            nextButton_Click(sender, e);
        }

        private void setNextVidNameText()
        {
            int check = axWindowsMediaPlayer1.currentPlaylist.count;
            nextVidNameLabel.Text = "";
            if (currPlaylistIndex < check - 1) //if we are at end of playlist, will display name of next video below
                nextVidNameLabel.Text = "UP NEXT: " + axWindowsMediaPlayer1.currentPlaylist.Item[currPlaylistIndex + 1].name;
        }
        private void addVideo_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == 0)
                return;
            WMPLib.IWMPMedia media;
            OFD.Filter = "Video Files(*.MP4;*.MKV;*.M4V;*.AVI;*MOV)|*.MP4;*.MKV;*.M4V;*.AVI;*MOV";
            DialogResult ofd = OFD.ShowDialog();
            
            if (ofd == DialogResult.OK)
            {
                try
                {
                    foreach (string file in OFD.FileNames)
                    {
                        media = axWindowsMediaPlayer1.newMedia(file);
                        axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                    }
                    setNextVidNameText();
                    //axWindowsMediaPlayer1.URL = OFD.FileName;
                }
                catch (Exception) { }
            }
        }

        private void back2_Click(object sender, EventArgs e)
        {
            backButton_Click(sender, e);
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) { //mediaEnded
                if (loopMode || (axWindowsMediaPlayer1.currentPlaylist.count - 1 > currPlaylistIndex))
                {
                    currPlaylistIndex = (currPlaylistIndex + 1) % axWindowsMediaPlayer1.currentPlaylist.count;
                    setVidLabel();
                    setNextVidNameText();
                }
            }
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {

        }

        private void openFileCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile_click(sender, e);
        }

        private void hideShowPlaylistPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlistBtn_Click(sender, e);
        }

        private void loopLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loopBtn_Click(sender, e);
        }

        private void playSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playPause_Click(sender, e);
        }

        private void addToPlaylistCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addVideo_Click(sender, e);
        }

        private void showHideVolumeVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            volume_Click(sender, e);
        }

        private void fastFowardCtrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ffBtn_Click(sender, e);
        }

        private void rewindCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rewindBtn_Click(sender, e);
        }

        private void stopCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopBtn_Click(sender, e);
        }

        private void nextCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextButton_Click(sender, e);
        }

        private void backCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
