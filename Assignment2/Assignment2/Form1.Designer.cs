namespace Assignment2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialogBG = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogS = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(13, 13);
            this.btnBackground.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(133, 28);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Find Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.Location = new System.Drawing.Point(13, 49);
            this.btnSprite.Margin = new System.Windows.Forms.Padding(4);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(133, 28);
            this.btnSprite.TabIndex = 2;
            this.btnSprite.Text = "Find Sprite";
            this.btnSprite.UseVisualStyleBackColor = true;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(154, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 28);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(154, 49);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(133, 28);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import Image";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialogBG
            // 
            this.openFileDialogBG.FileName = "openFileDialogBG";
            // 
            // openFileDialogS
            // 
            this.openFileDialogS.FileName = "openFileDialogS";
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.FileName = "openFileDialogImport";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 679);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSprite);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialogBG;
        private System.Windows.Forms.OpenFileDialog openFileDialogS;
        private System.Windows.Forms.OpenFileDialog openFileDialogImport;
    }
}

