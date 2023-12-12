using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Globalization;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox[,] textBoxes = new TextBox[3, 3];
        private double[,] kernel = new double[3, 3];
        private double kernelSum;
        private bool alreadyFocused;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TextBox GotFocus, MouseUp and Leave assignment
            /*txtKern00.GotFocus += textBox_GotFocus;
            txtKern10.GotFocus += textBox_GotFocus;
            txtKern20.GotFocus += textBox_GotFocus;
            txtKern01.GotFocus += textBox_GotFocus;
            txtKern11.GotFocus += textBox_GotFocus;
            txtKern21.GotFocus += textBox_GotFocus;
            txtKern02.GotFocus += textBox_GotFocus;
            txtKern12.GotFocus += textBox_GotFocus;
            txtKern22.GotFocus += textBox_GotFocus;

            txtKern00.MouseUp += textBox_MouseUp;
            txtKern10.MouseUp += textBox_MouseUp;
            txtKern20.MouseUp += textBox_MouseUp;
            txtKern01.MouseUp += textBox_MouseUp;
            txtKern11.MouseUp += textBox_MouseUp;
            txtKern21.MouseUp += textBox_MouseUp;
            txtKern02.MouseUp += textBox_MouseUp;
            txtKern12.MouseUp += textBox_MouseUp;
            txtKern22.MouseUp += textBox_MouseUp;

            txtKern00.Leave += textBox_Leave;
            txtKern10.Leave += textBox_Leave;
            txtKern20.Leave += textBox_Leave;
            txtKern01.Leave += textBox_Leave;
            txtKern11.Leave += textBox_Leave;
            txtKern21.Leave += textBox_Leave;
            txtKern02.Leave += textBox_Leave;
            txtKern12.Leave += textBox_Leave;
            txtKern22.Leave += textBox_Leave;*/
            #endregion

            GenerateTextBoxes(textBoxes);
            numericUpDownXValue.Value = 3;
            numericUpDownYValue.Value = 3;
        }

        #region TextBox GotFocus, MouseUp and Leave
        // Source: https://stackoverflow.com/questions/97459/making-a-winforms-textbox-behave-like-your-browsers-address-bar
        void textBox_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
        }

        void textBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (MouseButtons == MouseButtons.None)
            {
                textBox.SelectAll();
                alreadyFocused = true;
            }
        }

        void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!alreadyFocused && this.txtKern00.SelectionLength == 0)
            {
                alreadyFocused = true;
                textBox.SelectAll();
            }
        }
        #endregion

        void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if (numericUpDown.Value % 2 == 0)
            {
                numericUpDown.Value++;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open File";
                ofd.Filter = "bmp files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                ofd.InitialDirectory = "C:\\Users\\dustin\\Bilder";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxOriginal.Image = new Bitmap(ofd.FileName);

                    var image = pictureBoxOriginal.Image;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBoxOriginal.Image);
            int border = kernel.GetLength(0) / 2;
            Bitmap newImage = new Bitmap(image.Width - 2 * border, image.Height - 2 * border);

            FillKernelArray();

            for (int x = 0; x < image.Width - 2*border; x++)
            {
                for (int y = 0; y < image.Height - 2 * border; y++)
                {
                    newImage.SetPixel(x, y, GetNewColor(image, kernel, kernelSum, x, y));
                }
            }
            processedImage.Image = newImage;
        }

        private Color GetNewColor(Bitmap img, double[,] kernel, double kernelSum, int imgX, int imgY)
        {
            double redChannel = 0.0;
            double greenChannel = 0.0;
            double blueChannel = 0.0;

            for (int arrX = 0; arrX < kernel.GetLength(0); arrX++)
            {
                for (int arrY = 0; arrY < kernel.GetLength(1); arrY++)
                {
                    redChannel += img.GetPixel(imgX + (arrX), imgY + (arrY)).R * kernel[arrX, arrY];
                    greenChannel += img.GetPixel(imgX + (arrX), imgY + (arrY)).G * kernel[arrX, arrY];
                    blueChannel += img.GetPixel(imgX + (arrX), imgY + (arrY)).B * kernel[arrX, arrY];
                }
            }

            if (Double.IsNaN(redChannel))
            {
                redChannel = 0.0;
            }
            if (Double.IsNaN(greenChannel))
            {
                greenChannel = 0.0;
            }
            if (Double.IsNaN(blueChannel))
            {
                blueChannel = 0.0;
            }

            int ClampToByte(double value)
            {
                if (value > 255) return 255;
                if (value < 0) return 0;
                return (int)value;
            }

            Color newColor = Color.FromArgb(ClampToByte(redChannel), ClampToByte(greenChannel), ClampToByte(blueChannel));

            return newColor;
        }

        void FillKernelArray()
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    kernel[i, j] = Convert.ToDouble(textBoxes[i, j].Text);
                }
            }
            kernelSum = kernel.Cast<double>().Sum();
            if (false)
            {
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {
                        kernel[i, j] = kernel[i, j] / kernelSum;
                        textBoxes[i, j].Text = kernel[i, j].ToString(CultureInfo.InvariantCulture);
                    }
                }
            }
        }

        private void btnNewImgToOriImg_Click(object sender, EventArgs e)
        {
            pictureBoxOriginal.Image = processedImage.Image;
        }

        private void btnCustomKernelSettings_Click(object sender, EventArgs e)
        {
            int kernelSizeX = Convert.ToInt32(numericUpDownXValue.Value);
            int kernelSizeY = Convert.ToInt32(numericUpDownYValue.Value);

            textBoxes = ResizeTextBoxArray(textBoxes, kernelSizeX, kernelSizeY);
            GenerateTextBoxes(textBoxes);
            kernel = ResizeKernel(kernel, kernelSizeX, kernelSizeY);
        }

        TextBox[,] ResizeTextBoxArray(TextBox[,] textBoxesOld, int rows, int cols)
        {
            TextBox[,] textBoxesNew = new TextBox[rows, cols];
            int minRows = Math.Min(rows, textBoxesOld.GetLength(0));
            int minCols = Math.Min(cols, textBoxesOld.GetLength(1));
            for (int i = 0; i < minRows; i++)
            {
                for (int j = 0; j < minCols; j++)
                {
                    textBoxesNew[i, j] = textBoxesOld[i, j];
                }
            }
            return textBoxesNew;
        }

        double[,] ResizeKernel(double[,] kernelOld, int rows, int cols)
        {
            double[,] kernelNew = new double[rows, cols];
            int minRows = Math.Min(rows, kernelOld.GetLength(0));
            int minCols = Math.Min(cols, kernelOld.GetLength(1));
            for (int i = 0; i < minRows; i++)
            {
                for (int j = 0; j < minCols; j++)
                {
                    kernelNew[i, j] = kernelOld[i, j];
                }
            }
            return kernelNew;
        }

        void GenerateTextBoxes(TextBox[,] textBoxes)
        {

            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    groupBoxKernelValues.Controls.Remove(textBoxes[i, j]);
                    // TODO: Clear kernel array

                    TextBox textBox = new TextBox();
                    textBox.Name = "kernelValueTextBox" + i + j;
                    textBox.Width = 28;
                    textBox.Height = 23;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Left = (i * 35) + 6;
                    textBox.Top = (j * 30) + 20;
                    groupBoxKernelValues.Controls.Add(textBox);
                    textBoxes[i, j] = textBox;
                }
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.GotFocus += textBox_GotFocus;
                textBox.MouseUp += textBox_MouseUp;
                textBox.Leave += textBox_Leave;
            }
        }
    }
}
