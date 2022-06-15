using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFCTcode
{
	public partial class Form1 : Form
	{
		 string _SettingFilePath = "";
        private SettingForm _SettingForm = new SettingForm();

        private const int ColorByteRed      = 0;
        private const int ColorByteGreen    = 8;
        private const int ColorByteBlue     = 16;

        public Form1()
        {   
            InitializeComponent();
        }
/*
        override protected void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush myBrush = new HatchBrush(
                HatchStyle.Horizontal,
                Color.FromArgb(0xFF, 0xFF, 0xFF)
            );
            Pen myPen = new Pen(myBrush, 10);
            g.DrawLine(myPen, 0, 0, 200, 100);
        }
*/
        private void InputFileOpenButton_Click(object sender, EventArgs e)
        {
            if (openInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                InputPath.Text = openInputFileDialog.FileName;
            }
        }

        private void OutputFileOpenButton_Click_1(object sender, EventArgs e)
        {
            openOutputFileDialog.FileName = "SelectFolder";
            openOutputFileDialog.Filter = "Folder|.";
            openOutputFileDialog.CheckFileExists = false;

            if (openOutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                OutputPath.Text = System.IO.Path.GetDirectoryName(openOutputFileDialog.FileName);
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
		}

        private void ModecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var _SettingFile = new SettingFileXmlController();
            _SettingFile.Open(System.IO.Path.GetFullPath(_SettingFile.DefaultFileName));
            _SettingFile.ReadSetting(new SettingProcessXmlForm(_SettingForm));
            InputPath.Text = _SettingForm.InputFilePath;
            OutputPath.Text = _SettingForm.OutputFilePath;

            _SettingFilePath = _SettingFile.SettingFilePath;
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            var _SettingFile = new SettingFileXmlController(_SettingFilePath);
            _SettingFile.WriteSetting(new SettingProcessXmlForm(_SettingForm));
            _SettingFile.Save();
            _SettingFile.Close();
        }

		private void property_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            var _SettingFile = new SettingFileXmlController(_SettingFilePath);
            _SettingFile.WriteSetting(new SettingProcessXmlForm(_SettingForm));
            _SettingFile.Save();
            _SettingFile.Close();

            System.Diagnostics.Process p = System.Diagnostics.Process.Start(_SettingFilePath);
        }

		private void toolStripTextBox1_Click(object sender, EventArgs e)
		{
            this.Close();
        }

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void RsCommandNameText_TextChanged(object sender, EventArgs e)
		{

		}

		private void RamCommandNameText_TextChanged(object sender, EventArgs e)
		{

		}

		private void CommentText_TextChanged(object sender, EventArgs e)
		{

		}

		private void MinWriteAddrText_TextChanged(object sender, EventArgs e)
		{

		}

		private void MaxWriteAddrText_TextChanged(object sender, EventArgs e)
		{

		}

		private void MaxWriteBlockText_TextChanged(object sender, EventArgs e)
		{

		}

		private void MinWriteSizeText_TextChanged(object sender, EventArgs e)
		{

		}

		private void MaxWriteSizeText_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
