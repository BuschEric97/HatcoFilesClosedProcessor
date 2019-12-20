namespace HatcoFilesClosedProcessor
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressDetailed = new System.Windows.Forms.Label();
            this.includeNonMLSAgent = new System.Windows.Forms.CheckBox();
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
            this.button1.Location = new System.Drawing.Point(34, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(690, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(690, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Progress";
            // 
            // progressDetailed
            // 
            this.progressDetailed.AutoSize = true;
            this.progressDetailed.Location = new System.Drawing.Point(37, 315);
            this.progressDetailed.Name = "progressDetailed";
            this.progressDetailed.Size = new System.Drawing.Size(24, 13);
            this.progressDetailed.TabIndex = 6;
            this.progressDetailed.Text = "0/0";
            // 
            // includeNonMLSAgent
            // 
            this.includeNonMLSAgent.AutoSize = true;
            this.includeNonMLSAgent.Checked = true;
            this.includeNonMLSAgent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeNonMLSAgent.Location = new System.Drawing.Point(34, 101);
            this.includeNonMLSAgent.Name = "includeNonMLSAgent";
            this.includeNonMLSAgent.Size = new System.Drawing.Size(140, 17);
            this.includeNonMLSAgent.TabIndex = 7;
            this.includeNonMLSAgent.Text = "Include Non-MLS Agent";
            this.includeNonMLSAgent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 342);
            this.Controls.Add(this.includeNonMLSAgent);
            this.Controls.Add(this.progressDetailed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
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
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label progressDetailed;
        private System.Windows.Forms.CheckBox includeNonMLSAgent;
    }
}

