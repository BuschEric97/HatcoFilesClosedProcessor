﻿namespace HatcoFilesClosedProcessor
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
            this.MLSInputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogMLS = new System.Windows.Forms.OpenFileDialog();
            this.OpenMLS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MLSInputFile
            // 
            this.MLSInputFile.Location = new System.Drawing.Point(34, 55);
            this.MLSInputFile.Name = "MLSInputFile";
            this.MLSInputFile.Size = new System.Drawing.Size(609, 20);
            this.MLSInputFile.TabIndex = 0;
            this.MLSInputFile.Text = "C:\\Users\\Origami1105\\source\\repos\\HatcoFilesClosedProcessor\\TestFiles\\MLSDataSmal" +
    "lTesting.xlsx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MLS Input File";
            // 
            // openFileDialogMLS
            // 
            this.openFileDialogMLS.FileName = "openFileDialog1";
            // 
            // OpenMLS
            // 
            this.OpenMLS.Location = new System.Drawing.Point(649, 53);
            this.OpenMLS.Name = "OpenMLS";
            this.OpenMLS.Size = new System.Drawing.Size(75, 23);
            this.OpenMLS.TabIndex = 2;
            this.OpenMLS.Text = "Open";
            this.OpenMLS.UseVisualStyleBackColor = true;
            this.OpenMLS.Click += new System.EventHandler(this.OpenMLS_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(690, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenMLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MLSInputFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MLSInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogMLS;
        private System.Windows.Forms.Button OpenMLS;
        private System.Windows.Forms.Button button1;
    }
}

