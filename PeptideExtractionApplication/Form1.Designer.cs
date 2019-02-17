namespace PeptideExtractionApplication
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peptideExtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runUsingStandardSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMarkClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblValidationRecordCount = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridSource = new System.Windows.Forms.DataGridView();
            this.lblSourceRecordCount = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PeptideDataSet = new System.Windows.Forms.GroupBox();
            this.gridPeptides = new System.Windows.Forms.DataGridView();
            this.lblPeptideRecordCount = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtSequence = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtPosition = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtPID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtClassLabel = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.PeptideDataSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeptides)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.peptideExtractionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // peptideExtractionToolStripMenuItem
            // 
            this.peptideExtractionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runUsingStandardSequenceToolStripMenuItem,
            this.runMarkClassesToolStripMenuItem});
            this.peptideExtractionToolStripMenuItem.Name = "peptideExtractionToolStripMenuItem";
            this.peptideExtractionToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.peptideExtractionToolStripMenuItem.Text = "Peptide Extraction";
            // 
            // runUsingStandardSequenceToolStripMenuItem
            // 
            this.runUsingStandardSequenceToolStripMenuItem.Name = "runUsingStandardSequenceToolStripMenuItem";
            this.runUsingStandardSequenceToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.runUsingStandardSequenceToolStripMenuItem.Text = "Run";
            this.runUsingStandardSequenceToolStripMenuItem.Click += new System.EventHandler(this.runUsingStandardSequenceToolStripMenuItem_Click);
            // 
            // runMarkClassesToolStripMenuItem
            // 
            this.runMarkClassesToolStripMenuItem.Name = "runMarkClassesToolStripMenuItem";
            this.runMarkClassesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.runMarkClassesToolStripMenuItem.Text = "Run (Mark Classes)";
            this.runMarkClassesToolStripMenuItem.Click += new System.EventHandler(this.runMarkClassesToolStripMenuItem_Click);
            // 
            // lblValidationRecordCount
            // 
            this.lblValidationRecordCount.AutoSize = true;
            this.lblValidationRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblValidationRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblValidationRecordCount.Location = new System.Drawing.Point(3, 237);
            this.lblValidationRecordCount.Name = "lblValidationRecordCount";
            this.lblValidationRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblValidationRecordCount.TabIndex = 6;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML File|*.XML";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML File|*.XML";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(150, 16);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridSource);
            this.groupBox1.Controls.Add(this.lblSourceRecordCount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source DataTable";
            // 
            // gridSource
            // 
            this.gridSource.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSource.Location = new System.Drawing.Point(3, 16);
            this.gridSource.Name = "gridSource";
            this.gridSource.Size = new System.Drawing.Size(1022, 114);
            this.gridSource.TabIndex = 5;
            // 
            // lblSourceRecordCount
            // 
            this.lblSourceRecordCount.AutoSize = true;
            this.lblSourceRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSourceRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblSourceRecordCount.Location = new System.Drawing.Point(3, 130);
            this.lblSourceRecordCount.Name = "lblSourceRecordCount";
            this.lblSourceRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblSourceRecordCount.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PeptideDataSet
            // 
            this.PeptideDataSet.Controls.Add(this.gridPeptides);
            this.PeptideDataSet.Controls.Add(this.lblPeptideRecordCount);
            this.PeptideDataSet.Controls.Add(this.lblValidationRecordCount);
            this.PeptideDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeptideDataSet.Location = new System.Drawing.Point(0, 0);
            this.PeptideDataSet.Name = "PeptideDataSet";
            this.PeptideDataSet.Size = new System.Drawing.Size(1028, 253);
            this.PeptideDataSet.TabIndex = 1;
            this.PeptideDataSet.TabStop = false;
            this.PeptideDataSet.Text = "Validation DataSet";
            // 
            // gridPeptides
            // 
            this.gridPeptides.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridPeptides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPeptides.Location = new System.Drawing.Point(3, 16);
            this.gridPeptides.Name = "gridPeptides";
            this.gridPeptides.Size = new System.Drawing.Size(1022, 208);
            this.gridPeptides.TabIndex = 9;
            // 
            // lblPeptideRecordCount
            // 
            this.lblPeptideRecordCount.AutoSize = true;
            this.lblPeptideRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPeptideRecordCount.ForeColor = System.Drawing.Color.Navy;
            this.lblPeptideRecordCount.Location = new System.Drawing.Point(3, 224);
            this.lblPeptideRecordCount.Name = "lblPeptideRecordCount";
            this.lblPeptideRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblPeptideRecordCount.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PeptideDataSet);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 403);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 5;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(173, 22);
            this.toolStripLabel1.Text = "Size of Peptide (One Side Only):";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // txtSize
            // 
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(40, 25);
            this.txtSize.Text = "10";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel2.Text = "Sequence FieldName:";
            // 
            // txtSequence
            // 
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(100, 25);
            this.txtSequence.Text = "Sequence";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel3.Text = "Position Field Name:";
            // 
            // txtPosition
            // 
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 25);
            this.txtPosition.Text = "Position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel4.Text = "PID Field Name:";
            // 
            // txtPID
            // 
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 25);
            this.txtPID.Text = "PID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.txtSize,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.txtSequence,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.txtPosition,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.txtPID,
            this.toolStripSeparator5,
            this.toolStripLabel5,
            this.txtClassLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel5.Text = "Class Label:";
            // 
            // txtClassLabel
            // 
            this.txtClassLabel.Name = "txtClassLabel";
            this.txtClassLabel.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Peptide Extraction Application [(C) Wajahat M. Qazi, CIRL, Department of Computer" +
                " Science, GC University Lahore]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PeptideDataSet.ResumeLayout(false);
            this.PeptideDataSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeptides)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblValidationRecordCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridSource;
        private System.Windows.Forms.Label lblSourceRecordCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox PeptideDataSet;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtSequence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtPID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem peptideExtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runUsingStandardSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridPeptides;
        private System.Windows.Forms.Label lblPeptideRecordCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtClassLabel;
        private System.Windows.Forms.ToolStripMenuItem runMarkClassesToolStripMenuItem;

    }
}

