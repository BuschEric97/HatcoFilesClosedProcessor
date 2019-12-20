using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HatcoFilesClosedProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenMLS_Click(object sender, EventArgs e)
        {
            openFileDialogMLS.ShowHelp = true;
            openFileDialogMLS.ShowDialog();
            MLSInputFile.Text = openFileDialogMLS.FileName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Processor proc = new Processor();
            var watch = new System.Diagnostics.Stopwatch();
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            var progress = new Progress<int>(v =>
            {
                progressBar1.Increment(v);
            });

            try
            {
                watch.Start();
                await Task.Run(() => proc.mainProcessor(MLSInputFile.Text,
                    includeNonMLSAgent.Checked, progress, this));
                watch.Stop();
                MessageBox.Show("Complete!\nTime elapsed: " + watch.Elapsed);
            } catch (Exception ex)
            {
                // display any exceptions that are thrown as a popup message box
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
