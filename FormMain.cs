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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Height = Properties.Settings.Default.FormHeight;
            this.Width = Properties.Settings.Default.FormWidth;
            this.Left = Properties.Settings.Default.FormLocationX;
            this.Top = Properties.Settings.Default.FormLocationY;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                textboxMain.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = ofd.OpenFile();
                StreamReader reader = new StreamReader(fileStream);

                while (!reader.EndOfStream)
                {
                    textboxMain.Text += reader.ReadLine();

                    if (!reader.EndOfStream)
                    {
                        textboxMain.Text += "\n";
                    }
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormLocationX = this.Location.X;
            Properties.Settings.Default.FormLocationY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}
