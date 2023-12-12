namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.processedImage = new System.Windows.Forms.PictureBox();
            this.txtKern00 = new System.Windows.Forms.TextBox();
            this.txtKern20 = new System.Windows.Forms.TextBox();
            this.txtKern10 = new System.Windows.Forms.TextBox();
            this.txtKern02 = new System.Windows.Forms.TextBox();
            this.txtKern12 = new System.Windows.Forms.TextBox();
            this.txtKern22 = new System.Windows.Forms.TextBox();
            this.txtKern01 = new System.Windows.Forms.TextBox();
            this.txtKern11 = new System.Windows.Forms.TextBox();
            this.txtKern21 = new System.Windows.Forms.TextBox();
            this.groupBoxKernelValues = new System.Windows.Forms.GroupBox();
            this.btnNewImgToOriImg = new System.Windows.Forms.Button();
            this.btnCustomKernelSettings = new System.Windows.Forms.Button();
            this.groupCustomKernel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownYValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).BeginInit();
            this.groupCustomKernel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 420);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(94, 419);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Set Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 3;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // processedImage
            // 
            this.processedImage.Location = new System.Drawing.Point(419, 12);
            this.processedImage.Name = "processedImage";
            this.processedImage.Size = new System.Drawing.Size(400, 400);
            this.processedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processedImage.TabIndex = 3;
            this.processedImage.TabStop = false;
            // 
            // txtKern00
            // 
            this.txtKern00.Location = new System.Drawing.Point(447, 503);
            this.txtKern00.MaxLength = 3;
            this.txtKern00.Name = "txtKern00";
            this.txtKern00.Size = new System.Drawing.Size(28, 23);
            this.txtKern00.TabIndex = 3;
            this.txtKern00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKern20
            // 
            this.txtKern20.Location = new System.Drawing.Point(515, 503);
            this.txtKern20.MaxLength = 3;
            this.txtKern20.Name = "txtKern20";
            this.txtKern20.Size = new System.Drawing.Size(28, 23);
            this.txtKern20.TabIndex = 5;
            // 
            // txtKern10
            // 
            this.txtKern10.Location = new System.Drawing.Point(481, 503);
            this.txtKern10.MaxLength = 3;
            this.txtKern10.Name = "txtKern10";
            this.txtKern10.Size = new System.Drawing.Size(28, 23);
            this.txtKern10.TabIndex = 4;
            // 
            // txtKern02
            // 
            this.txtKern02.Location = new System.Drawing.Point(447, 561);
            this.txtKern02.MaxLength = 3;
            this.txtKern02.Name = "txtKern02";
            this.txtKern02.Size = new System.Drawing.Size(28, 23);
            this.txtKern02.TabIndex = 9;
            // 
            // txtKern12
            // 
            this.txtKern12.Location = new System.Drawing.Point(481, 561);
            this.txtKern12.MaxLength = 3;
            this.txtKern12.Name = "txtKern12";
            this.txtKern12.Size = new System.Drawing.Size(28, 23);
            this.txtKern12.TabIndex = 10;
            // 
            // txtKern22
            // 
            this.txtKern22.Location = new System.Drawing.Point(515, 561);
            this.txtKern22.MaxLength = 3;
            this.txtKern22.Name = "txtKern22";
            this.txtKern22.Size = new System.Drawing.Size(28, 23);
            this.txtKern22.TabIndex = 11;
            // 
            // txtKern01
            // 
            this.txtKern01.Location = new System.Drawing.Point(447, 532);
            this.txtKern01.MaxLength = 3;
            this.txtKern01.Name = "txtKern01";
            this.txtKern01.Size = new System.Drawing.Size(28, 23);
            this.txtKern01.TabIndex = 6;
            // 
            // txtKern11
            // 
            this.txtKern11.Location = new System.Drawing.Point(481, 532);
            this.txtKern11.MaxLength = 3;
            this.txtKern11.Name = "txtKern11";
            this.txtKern11.Size = new System.Drawing.Size(28, 23);
            this.txtKern11.TabIndex = 7;
            // 
            // txtKern21
            // 
            this.txtKern21.Location = new System.Drawing.Point(515, 532);
            this.txtKern21.MaxLength = 3;
            this.txtKern21.Name = "txtKern21";
            this.txtKern21.Size = new System.Drawing.Size(28, 23);
            this.txtKern21.TabIndex = 8;
            // 
            // groupBoxKernelValues
            // 
            this.groupBoxKernelValues.Location = new System.Drawing.Point(175, 419);
            this.groupBoxKernelValues.Name = "groupBoxKernelValues";
            this.groupBoxKernelValues.Size = new System.Drawing.Size(238, 222);
            this.groupBoxKernelValues.TabIndex = 5;
            this.groupBoxKernelValues.TabStop = false;
            this.groupBoxKernelValues.Text = "Kernel Values";
            // 
            // btnNewImgToOriImg
            // 
            this.btnNewImgToOriImg.Location = new System.Drawing.Point(13, 449);
            this.btnNewImgToOriImg.Name = "btnNewImgToOriImg";
            this.btnNewImgToOriImg.Size = new System.Drawing.Size(156, 23);
            this.btnNewImgToOriImg.TabIndex = 6;
            this.btnNewImgToOriImg.Text = "Update Original";
            this.btnNewImgToOriImg.UseVisualStyleBackColor = true;
            this.btnNewImgToOriImg.Click += new System.EventHandler(this.btnNewImgToOriImg_Click);
            // 
            // btnCustomKernelSettings
            // 
            this.btnCustomKernelSettings.Location = new System.Drawing.Point(6, 80);
            this.btnCustomKernelSettings.Name = "btnCustomKernelSettings";
            this.btnCustomKernelSettings.Size = new System.Drawing.Size(144, 23);
            this.btnCustomKernelSettings.TabIndex = 7;
            this.btnCustomKernelSettings.Text = "Apply";
            this.btnCustomKernelSettings.UseVisualStyleBackColor = true;
            this.btnCustomKernelSettings.Click += new System.EventHandler(this.btnCustomKernelSettings_Click);
            // 
            // groupCustomKernel
            // 
            this.groupCustomKernel.Controls.Add(this.label2);
            this.groupCustomKernel.Controls.Add(this.label1);
            this.groupCustomKernel.Controls.Add(this.numericUpDownYValue);
            this.groupCustomKernel.Controls.Add(this.btnCustomKernelSettings);
            this.groupCustomKernel.Controls.Add(this.numericUpDownXValue);
            this.groupCustomKernel.Location = new System.Drawing.Point(13, 478);
            this.groupCustomKernel.Name = "groupCustomKernel";
            this.groupCustomKernel.Size = new System.Drawing.Size(156, 116);
            this.groupCustomKernel.TabIndex = 8;
            this.groupCustomKernel.TabStop = false;
            this.groupCustomKernel.Text = "Custom Kernel Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "X:";
            // 
            // numericUpDownYValue
            // 
            this.numericUpDownYValue.Location = new System.Drawing.Point(31, 51);
            this.numericUpDownYValue.Name = "numericUpDownYValue";
            this.numericUpDownYValue.Size = new System.Drawing.Size(46, 23);
            this.numericUpDownYValue.TabIndex = 9;
            this.numericUpDownYValue.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownXValue
            // 
            this.numericUpDownXValue.Location = new System.Drawing.Point(31, 22);
            this.numericUpDownXValue.Name = "numericUpDownXValue";
            this.numericUpDownXValue.Size = new System.Drawing.Size(46, 23);
            this.numericUpDownXValue.TabIndex = 9;
            this.numericUpDownXValue.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 712);
            this.Controls.Add(this.txtKern00);
            this.Controls.Add(this.txtKern21);
            this.Controls.Add(this.groupCustomKernel);
            this.Controls.Add(this.txtKern20);
            this.Controls.Add(this.btnNewImgToOriImg);
            this.Controls.Add(this.txtKern11);
            this.Controls.Add(this.groupBoxKernelValues);
            this.Controls.Add(this.txtKern10);
            this.Controls.Add(this.processedImage);
            this.Controls.Add(this.txtKern01);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.txtKern02);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtKern22);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtKern12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).EndInit();
            this.groupCustomKernel.ResumeLayout(false);
            this.groupCustomKernel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox processedImage;
        private System.Windows.Forms.TextBox txtKern00;
        private System.Windows.Forms.TextBox txtKern20;
        private System.Windows.Forms.TextBox txtKern10;
        private System.Windows.Forms.TextBox txtKern02;
        private System.Windows.Forms.TextBox txtKern12;
        private System.Windows.Forms.TextBox txtKern22;
        private System.Windows.Forms.TextBox txtKern01;
        private System.Windows.Forms.TextBox txtKern11;
        private System.Windows.Forms.TextBox txtKern21;
        private System.Windows.Forms.GroupBox groupBoxKernelValues;
        private System.Windows.Forms.Button btnNewImgToOriImg;
        private System.Windows.Forms.Button btnCustomKernelSettings;
        private System.Windows.Forms.GroupBox groupCustomKernel;
        private System.Windows.Forms.NumericUpDown numericUpDownYValue;
        private System.Windows.Forms.NumericUpDown numericUpDownXValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

