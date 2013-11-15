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
    public partial class Form1 : Form
    {
        private const String FLIGHTTIMEHEADER = "m_present_time";
        private const String SCITIMEHEADER = "sci_m_present_time";

        public Form1()
        {
            InitializeComponent();
        }

        private void browseFlightButton_Click(object sender, EventArgs e)
        {
            DialogResult result = dataFileDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                flightPathBox.Text = dataFileDialog.FileName;
                flightPathBox.BackColor = Color.White;
            }
        }

        private void browseScienceButton_Click(object sender, EventArgs e)
        {
            DialogResult result = dataFileDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                sciencePathBox.Text = dataFileDialog.FileName;
                sciencePathBox.BackColor = Color.White;
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (flightPathBox.Text.Length == 0)
            {
                errorProvider.SetError(flightPathBox, "Must Select a Flight Data File Before Performing Merge.");
                errors = true;
            }

            if (sciencePathBox.Text.Length == 0)
            {
                errorProvider.SetError(sciencePathBox, "Must Select a Science Data File Before Performing Merge.");
                errors = true;
            }

            if (errors) return;

            DialogResult result = saveOutputDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    Glider7DataFile flightFile = new Glider7DataFile(flightPathBox.Text, FLIGHTTIMEHEADER);
                    Glider7DataFile sciFile = new Glider7DataFile(sciencePathBox.Text, SCITIMEHEADER);
                    Glider7DataMerger merger = new Glider7DataMerger(flightFile, sciFile);
                    MergerProgress progress = new MergerProgress(merger,saveOutputDialog.FileName);
                    progress.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error merging file: " + ex.ToString());
                }
            }
        }
    }
}
