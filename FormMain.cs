using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEdit
{
    public partial class FormMain : Form
    {
        private int syntax = -1;
        /*
         * -1 = unknown (no highlighting), 0 = .txt (no highlighting),
         * 1 = .rtf (no highlighting), 2 = .html (highlighting),
         * 
         */
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                if (sfd.FileName.EndsWith(".txt"))
                {
                    textboxMain.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (sfd.FileName.EndsWith(".rtf"))
                {
                    textboxMain.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".txt"))
                {
                    textboxMain.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (ofd.FileName.EndsWith(".rtf"))
                {
                    textboxMain.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormLocationX = this.Location.X;
            Properties.Settings.Default.FormLocationY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void loadSettings()
        {
            this.Height = Properties.Settings.Default.FormHeight;
            this.Width = Properties.Settings.Default.FormWidth;
            this.Left = Properties.Settings.Default.FormLocationX;
            this.Top = Properties.Settings.Default.FormLocationY;
            this.textboxMain.Font = Properties.Settings.Default.CurrentFont;
        }

        private void buttonWordWrap_Click(object sender, EventArgs e)
        {
            buttonWordWrap.Checked = !buttonWordWrap.Checked;
            Properties.Settings.Default.WordWrap = buttonWordWrap.Checked;
            textboxMain.WordWrap = buttonWordWrap.Checked;
        }

        private void buttonFontSize_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = Properties.Settings.Default.CurrentFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textboxMain.Font = fd.Font;
                Properties.Settings.Default.CurrentFont = fd.Font;
                Properties.Settings.Default.Save();
            }
        }
    }
}
