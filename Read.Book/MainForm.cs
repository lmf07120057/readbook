using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;

namespace Read.Book
{
    public partial class MainForm : Form
    {
        SpeechSynthesizer speech;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            btn_pause.Enabled = false;
            btn_resume.Enabled = false;
            btn_stop.Enabled = false;
            rtx_book.ScrollBars = RichTextBoxScrollBars.Vertical;
        }
         
        /// <summary>
        /// 开始读
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            speech.Dispose();
            if (!string.IsNullOrWhiteSpace(rtx_book.Text))
            {
                speech = new SpeechSynthesizer(); 
                 
                speech.Volume = trackbar_volume.Value;
                speech.Rate = trackbar_rate.Value;

                var voices = speech.GetInstalledVoices();

                speech.SelectVoice(voices[0].VoiceInfo.Name);

                //speech.SelectVoiceByHints(VoiceGender.Male);

                speech.SpeakAsync(rtx_book.Text);
                btn_pause.Enabled = true; 
                btn_stop.Enabled = true;
                speech.SpeakCompleted += Speech_SpeakCompleted;
                speech.SpeakStarted += Speech_SpeakStarted; 
            }
            else
            {
                this.Text = "可以添加一些内容试试哦...";
            }

        }
  
        private void Speech_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            this.Text = "阅读中...";
        }

        private void Speech_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            this.Text = "结束";
        }

        /// <summary>
        /// 暂停读
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (speech!=null)
            {
                if (speech.State== SynthesizerState.Speaking)
                {
                    speech.Pause();
                    this.Text = "暂停";
                    btn_resume.Enabled = true;
                    btn_pause.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 恢复暂停读
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (speech!=null)
            {
                if (speech.State== SynthesizerState.Paused)
                { 
                    speech.Resume();
                    this.Text = "阅读中...";
                }
                btn_resume.Enabled = false;
                btn_pause.Enabled = true;
            }
        }

        /// <summary>
        /// 停止读
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (speech!=null)
            { 
                speech.Dispose();
                this.Text = "读书";
                btn_stop.Enabled = false;
                btn_resume.Enabled = false;
                btn_pause.Enabled = false;
            }
        }

        /// <summary>
        /// 调节音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbar_volume_Scroll(object sender, EventArgs e)
        {
             lbl_volume2.Text = trackbar_volume.Value.ToString();
        }

        /// <summary>
        /// 调节音速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackbar_rate_Scroll(object sender, EventArgs e)
        {
            lbl_rate2.Text = trackbar_rate.Value.ToString();
        }

        private void 导出语音EToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            speech.Dispose();
            speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = 0; 

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存语音";
            saveFileDialog.Filter = "*.wav|*.wav|*.mp3|*.mp3";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    speech.SetOutputToWaveFile(fileName);
                    speech.Speak(rtx_book.Text);
                    speech.SetOutputToNull(); 
                    var dir = Path.GetDirectoryName(fileName); 
                    Process.Start(saveFileDialog.InitialDirectory);
                }
            }
            catch (Exception)
            { 
                speech.Dispose();
                this.Text = "保存语音异常,请联系我（mobile：18681081080, 微信：18681081080）"; 
            } 
        }

        private void OpenFileDialog_output_FileOk(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void 清除CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx_book.Text = "";
            speech.Dispose();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var txt = File.ReadAllText(fileName);
                rtx_book.Text = txt;
            } 
        }
         
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speech.Dispose();
            this.Close();
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            var dialogResult = fontDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                rtx_book.Font = fontDialog.Font;
            } 
        }

        private void 关于读书AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abb_read abb_Read = new Abb_read();
            abb_Read.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            speech.Dispose();
        }
         
    }
}
