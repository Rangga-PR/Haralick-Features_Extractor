using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Images_Haralick_Descriptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            features_Extract.AddHeader(data);
        }

        private void GetFiles(string[] Files)
        {
            ListofImage.Items.Clear();

            foreach (string file in Files)
            {
                string fileName = Path.GetFileName(file);

                if (Files.Length == 1)
                {
                    var SelectedImage = new Bitmap(file);
                    SelectedPict.Image = SelectedImage;
                }

                if (Regex.IsMatch(fileName, "([^\\s]+(\\.(?i)(jpg|jpeg|png|jfif|jpe|bmp))$)"))
                {
                    ListViewItem item = new ListViewItem(fileName)
                    {
                       Tag = file
                    };

                 ListofImage.Items.Add(item);
                }
                ListofImage.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool MouseIsDown;
        private Point LastLocation;

        private void Borderpnl1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            LastLocation = e.Location;
        }

        private void Borderpnl1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseIsDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X ,
                    (this.Location.Y-LastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Borderpnl1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
        }

        private void Borderpnl2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
            LastLocation = e.Location;
        }

        private void Borderpnl2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X,
                    (this.Location.Y - LastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Borderpnl2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
        }

        private void Openfilefolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog FileDialog = new OpenFileDialog())
            {
                FileDialog.Filter = "Images Files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
                FileDialog.Title = "Select the Images";
                FileDialog.Multiselect = true;

                if(FileDialog.ShowDialog() == DialogResult.OK)
                {
                    GetFiles(FileDialog.FileNames);   
                }
            }       
        }

        private void Openfolderbtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FolderBrowser = new FolderBrowserDialog())
            {
                if(FolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string[] Files = Directory.GetFiles(FolderBrowser.SelectedPath);
                    GetFiles(Files);
                }
            }
        }

        ExternalData externalData = new ExternalData();

        private void Opendatasetbtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog FileDialog = new OpenFileDialog())
            {
                FileDialog.Filter = "csv Files | *.csv; *.txt;";
                FileDialog.Title = "Select the Datasets";

                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    Datasets.DataSource = externalData.ImportFile(FileDialog.FileName);
                    data= externalData.ImportFile(FileDialog.FileName);
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SaveFileDialog = new SaveFileDialog())
            {
                SaveFileDialog.AddExtension = true;
                SaveFileDialog.DefaultExt = "csv";
                SaveFileDialog.Filter = "Csv File|*.csv|Text File|*.txt";

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    externalData.SaveDatasets(SaveFileDialog.FileName, (DataTable)Datasets.DataSource);
                }
            }
        }

        DataTable data = new DataTable();
        Features_Extract features_Extract = new Features_Extract();

        private void NewDatabtn_Click(object sender, EventArgs e)
        {
            data.Clear();
            Datasets.DataSource = null;
            Datasets.Rows.Clear();
            Datasets.Refresh();

            features_Extract.AddHeader(data);
            Datasets.DataSource = data;
        }
        
        private void ListofImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ListofImage.FocusedItem.Tag.ToString();
            var image = new Bitmap(selectedItem);
            SelectedPict.Image = image;
        }

        private void Extractbtn_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem file in ListofImage.Items)
            {
                using (var image = new Bitmap(file.Tag.ToString()))
                {
                    features_Extract.ExtractFeature(image, data, Data_label.Text);
                }
            }

            Datasets.DataSource = data;
        }
    }
}
