using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Qazi.Peptides.PeptideDataTableGenerator;
using Qazi.GUI.CommonDialogs;
using Qazi.Common;

namespace PeptideExtractionApplication
{
    public partial class Form1 : Form
    {
        
        private PeptideExtractionManager _PeptideExtractionManager;
        private DataTable _SourceDataTable;
        private bool _MarkClasses;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.FileName != "")
            {
                DataSet ds = new DataSet();
                ds.ReadXml(openFileDialog1.FileName);
                DataTableSelectorWnd dts = new DataTableSelectorWnd("Select Source Data Table", ds);
                dts.ShowDialog(this);
                _SourceDataTable = ds.Tables[dts.TableName];
                gridSource.DataSource = _SourceDataTable;
                lblSourceRecordCount.Text = _SourceDataTable.Rows.Count.ToString();
            }
        }

        private void runUsingStandardSequenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MarkClasses = false;
            RunExtraction();
        }

        private void RunExtraction()
        {
            int size;
            size = int.Parse(txtSize.Text);
            _PeptideExtractionManager = new PeptideExtractionManager(size, _SourceDataTable, txtPID.Text, txtSequence.Text, false, txtPosition.Text, _MarkClasses, txtClassLabel.Text);
            _PeptideExtractionManager.PeptideExtractionCompleted += new WorkerCompletedEventHandler(_PeptideExtractionManager_PeptideExtractionCompleted);
            _PeptideExtractionManager.PeptideExtractionProgress += new WorkerProgressUpdateEventHandler(_PeptideExtractionManager_PeptideExtractionProgress);
            _PeptideExtractionManager.PeptideExtractionStarted += new WorkerStartedEventHandler(_PeptideExtractionManager_PeptideExtractionStarted);
            _PeptideExtractionManager.ExtractPeptides();
            lblStatus.Text = "Peptde Extraction Done...";
            lblPeptideRecordCount.Text = _PeptideExtractionManager.PeptideDataTable.Rows.Count.ToString();
            gridPeptides.DataSource = _PeptideExtractionManager.PeptideDataTable;
        }

        void _PeptideExtractionManager_PeptideExtractionStarted(object sender)
        {
            lblStatus.Text = "Peptde Extraction Started...";
        }

        void _PeptideExtractionManager_PeptideExtractionProgress(object sender, WorkerProgressEventArg e)
        {
            progressbar.Value = (int)e.ProgressPercentage;
            lblStatus.Text = e.UserState;
        }

        void _PeptideExtractionManager_PeptideExtractionCompleted(object sender, WorkerCompletedEventArg e)
        {
            lblStatus.Text = "Peptde Extraction Done...";
            gridPeptides.DataSource = _PeptideExtractionManager.PeptideDataTable;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            _PeptideExtractionManager.PeptideDataTable.WriteXml(saveFileDialog1.FileName);
            MessageBox.Show("Peptide DataTable Saved...");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void runMarkClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtClassLabel.Text == "")
            {
                MessageBox.Show("Please provide class label");
                return;
            }
            _MarkClasses = true;
            RunExtraction();
        }


    }
}