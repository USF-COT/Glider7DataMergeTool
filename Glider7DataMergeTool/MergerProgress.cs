using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glider7DataMergeTool
{
    public partial class MergerProgress : Form
    {
        private Glider7DataMerger merger;
        private String outputPath;

        public MergerProgress(Glider7DataMerger merger, String outputPath)
        {
            InitializeComponent();
            this.merger = merger;
            this.outputPath = outputPath;
            this.Shown +=new EventHandler(MergerProgress_Shown);
        }

        void MergerProgress_Shown(object sender, EventArgs e)
        {
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerAsync();
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.merger.mergeDataTo(this.outputPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Merging Files");
            }
        }
    }
}
