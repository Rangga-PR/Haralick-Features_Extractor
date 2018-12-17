using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using Accord.Imaging;
using Accord.Imaging.Filters;

namespace Images_Haralick_Descriptor
{
    class Features_Extract
    {

        //var medianFilter = new Median();
        //var resizeBilinear = new ResizeBilinear(250, 250);
        GrayscaleBT709 grayscaleBT = new GrayscaleBT709();

        private double[,] CreateGLCM (Bitmap image)
        {
            var grayLevelCooccurrenceMatrix = new GrayLevelCooccurrenceMatrix();
            image = grayscaleBT.Apply(image);

            return grayLevelCooccurrenceMatrix.Compute(image);
        }

        private double[] GlcmFeatures (Bitmap image)
        {
            var descriptor = new HaralickDescriptor(CreateGLCM(image));
            var features = new double[13];

            features[0] = descriptor.F01;
            features[1] = descriptor.F02;
            features[2] = descriptor.F03;
            features[3] = descriptor.F04;
            features[4] = descriptor.F05;
            features[5] = descriptor.F06;
            features[6] = descriptor.F07;
            features[7] = descriptor.F08;
            features[8] = descriptor.F09;
            features[9] = descriptor.F10;
            features[10] = descriptor.F11;
            features[11] = descriptor.F12;
            features[12] = descriptor.F13;

            return features;
        }

        public void AddHeader (DataTable data)
        {
            data.Clear();
            data.Columns.Clear();

            data.Columns.Add("Energy", typeof(double));
            data.Columns.Add("Contrast", typeof(double));
            data.Columns.Add("Correlation", typeof(double));
            data.Columns.Add("Variance", typeof(double));
            data.Columns.Add("Inverse Difference Moment", typeof(double));
            data.Columns.Add("Sum Average", typeof(double));
            data.Columns.Add("Sum Variance", typeof(double));
            data.Columns.Add("Sum Entropy", typeof(double));
            data.Columns.Add("Entropy", typeof(double));
            data.Columns.Add("Difference Variance", typeof(double));
            data.Columns.Add("Difference Enropy", typeof(double));
            data.Columns.Add("First Information Measure", typeof(double));
            data.Columns.Add("Second Information Measure", typeof(double));
            data.Columns.Add("Label", typeof(string));
        }

        public void ExtractFeature(Bitmap image, DataTable data, string label)
        {
            double[] f=GlcmFeatures(image);

            data.Rows.Add(f[0], f[1], f[2], f[3], f[4],
                          f[5], f[6], f[7], f[8], f[9], 
                          f[10], f[11], f[12], label);
        }
    }
}
