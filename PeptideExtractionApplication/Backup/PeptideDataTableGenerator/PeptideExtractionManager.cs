using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.Peptides.PeptideGenerator;
using Qazi.Common;


namespace Qazi.Peptides.PeptideDataTableGenerator
{
    public class PeptideExtractionManager : IDisposable 
    {
        public event WorkerStartedEventHandler PeptideExtractionStarted;
        public event WorkerProgressUpdateEventHandler PeptideExtractionProgress;
        public event WorkerCompletedEventHandler PeptideExtractionCompleted;

        public WorkerCompletedEventArg PeptideExtractionCompletedEventArg;
        public WorkerProgressEventArg PeptideExtractionProgressEventArg;

        private int _SizeOfOneSide;
        private DataTable _SourceDataTable;
        private DataTable _PeptideDataTable;
        private bool _IsExtendedSequence;
        private string _NameOfSequenceFeildName = null;
        private string _NameOfPositionFeildName = null;
        private string _NamePIDFeildName = null;
        private bool _MarkClassificationLabel;
        private string _ClassificationLabel;

        private int index, totalRows, rowIndex;
        private float progress;
        private string sequence;
        private int position;
        private DataRow row;
        private DataRow peptideRow;
        private string peptideID;
        private PeptideData pd;
        private int ctr;
        

        public PeptideExtractionManager(int sizeOfOneSide, DataTable dtSource, string nameOfPIDFieldName, string nameOfSequenceFeild, bool isExtendedSequenceField, string nameOfPositionFeild, bool markClassificationLabel, string classificationLabel)
        {
            _SizeOfOneSide = sizeOfOneSide;
            _SourceDataTable = dtSource;
            _IsExtendedSequence = isExtendedSequenceField;
            _NameOfPositionFeildName = nameOfPositionFeild;
            _NamePIDFeildName = nameOfPIDFieldName;
            _NameOfSequenceFeildName = nameOfSequenceFeild;
            _ClassificationLabel = classificationLabel;
            _MarkClassificationLabel = markClassificationLabel;

            _PeptideDataTable = new DataTable("Peptides");
            _PeptideDataTable.Columns.Add("PeptideID");
            _PeptideDataTable.Columns.Add("ExtendedSequence");
            if (_MarkClassificationLabel == true)
                _PeptideDataTable.Columns.Add("Class");

            PeptideExtractionCompletedEventArg = new WorkerCompletedEventArg();
            PeptideExtractionProgressEventArg = new WorkerProgressEventArg();

            for (index = (-1 * _SizeOfOneSide); index <= _SizeOfOneSide; index++)
                _PeptideDataTable.Columns.Add("P" + index.ToString());
        }

        public void ExtractPeptides()
        {
            if (PeptideExtractionStarted != null)
                PeptideExtractionStarted(this);
            totalRows = _SourceDataTable.Rows.Count;
            #region Peptide Extraction Loop
            for (rowIndex = 0; rowIndex < totalRows; rowIndex++)
            {
                row = _SourceDataTable.Rows[rowIndex];
                sequence = row[_NameOfSequenceFeildName].ToString();
                position = int.Parse(row[_NameOfPositionFeildName].ToString());
                
                if (_IsExtendedSequence == true)
                    pd = PeptideCutter.ToPeptideFromExtendedSequence(sequence, position, _SizeOfOneSide);
                else
                    pd = PeptideCutter.ToPeptideFromStandardSequence(sequence, position, _SizeOfOneSide);

                peptideID = row[_NamePIDFeildName].ToString() + "-" + position.ToString();
                peptideRow = _PeptideDataTable.NewRow();
                peptideRow["PeptideID"] = peptideID;
                peptideRow["ExtendedSequence"] = pd.ExtendedPeptideSequence;
                if (_MarkClassificationLabel == true)
                    peptideRow["Class"] = _ClassificationLabel;
                ctr = 0;
                for (index = (-1 * _SizeOfOneSide); index <= _SizeOfOneSide; index++)
                {
                    peptideRow["P" + index.ToString()] = pd.PeptideSequence[ctr];
                    ctr++;
                }
                _PeptideDataTable.Rows.Add(peptideRow);

                
                if (PeptideExtractionProgress != null)
                {
                    progress = (((float)(rowIndex + 1) / (float)totalRows) * 100);
                    PeptideExtractionProgressEventArg.AssociatedData = null;
                    PeptideExtractionProgressEventArg.ProgressPercentage = progress;
                    PeptideExtractionProgress(this, PeptideExtractionProgressEventArg);
                }
            }
            #endregion Peptide Extraction Loop
            if (PeptideExtractionCompleted != null)
            {
                PeptideExtractionCompletedEventArg.UserStateMessage = "";
                PeptideExtractionCompletedEventArg.Result = PeptideDataTable;
                PeptideExtractionCompleted(this, PeptideExtractionCompletedEventArg);
            }
        }

        public DataTable PeptideDataTable
        {

            get {
                return _PeptideDataTable;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_SourceDataTable != null)
            {
                _SourceDataTable.Clear();
                _SourceDataTable.Dispose();
                _SourceDataTable = null;
            }
            if(_PeptideDataTable != null)
            {
                _PeptideDataTable.Clear();
                _PeptideDataTable.Dispose();
                _PeptideDataTable = null;
            }

            if (pd != null)
            {
                pd.Dispose();
                pd = null;
                
            }
        
        }

        #endregion
    }
}
