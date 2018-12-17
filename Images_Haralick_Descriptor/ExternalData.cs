using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Accord.IO;

namespace Images_Haralick_Descriptor
{
    class ExternalData
    {
        private DataTable ImportCsv(string FileName)
        {
            using (CsvReader CsvFileReader = new CsvReader(FileName, true))
            {
                return CsvFileReader.ToTable();
            }
        }

        public DataTable ImportFile(string FileName)
        {
            DataTable ImportedData = new DataTable();
            ImportedData = ImportCsv(FileName);
            return ImportedData;
        }

        public void SaveDatasets(string FileName,DataTable Datasets)
        {
            using (CsvWriter csvWriter = new CsvWriter(FileName))
            {
                csvWriter.Write(Datasets);
            }
        }
    }
}
