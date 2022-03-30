namespace lab_6
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
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.BtnCalcPerimeter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TextBoxPerimeter = new System.Windows.Forms.RichTextBox();
            this.TextBoxFileContents = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcDistance = new System.Windows.Forms.Button();
            this.TextBoxDistance = new System.Windows.Forms.RichTextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOpenFile.Location = new System.Drawing.Point(12, 23);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(129, 41);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "Открыть файл";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnCalcPerimeter
            // 
            this.BtnCalcPerimeter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCalcPerimeter.Location = new System.Drawing.Point(12, 307);
            this.BtnCalcPerimeter.Name = "BtnCalcPerimeter";
            this.BtnCalcPerimeter.Size = new System.Drawing.Size(192, 41);
            this.BtnCalcPerimeter.TabIndex = 1;
            this.BtnCalcPerimeter.Text = "Вычислить периметр";
            this.BtnCalcPerimeter.UseVisualStyleBackColor = true;
            this.BtnCalcPerimeter.Click += new System.EventHandler(this.BtnCalcPerimeter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClear.Location = new System.Drawing.Point(281, 23);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(128, 41);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Очистить";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TextBoxPerimeter
            // 
            this.TextBoxPerimeter.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPerimeter.Location = new System.Drawing.Point(13, 376);
            this.TextBoxPerimeter.Name = "TextBoxPerimeter";
            this.TextBoxPerimeter.Size = new System.Drawing.Size(173, 116);
            this.TextBoxPerimeter.TabIndex = 5;
            this.TextBoxPerimeter.Text = "";
            // 
            // TextBoxFileContents
            // 
            this.TextBoxFileContents.Location = new System.Drawing.Point(12, 93);
            this.TextBoxFileContents.Name = "TextBoxFileContents";
            this.TextBoxFileContents.Size = new System.Drawing.Size(397, 151);
            this.TextBoxFileContents.TabIndex = 6;
            this.TextBoxFileContents.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Содержимое файла";
            // 
            // BtnCalcDistance
            // 
            this.BtnCalcDistance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCalcDistance.Location = new System.Drawing.Point(210, 307);
            this.BtnCalcDistance.Name = "BtnCalcDistance";
            this.BtnCalcDistance.Size = new System.Drawing.Size(192, 41);
            this.BtnCalcDistance.TabIndex = 8;
            this.BtnCalcDistance.Text = "Вычислить расстояние";
            this.BtnCalcDistance.UseVisualStyleBackColor = true;
            this.BtnCalcDistance.Click += new System.EventHandler(this.BtnCalcDistance_Click);
            // 
            // TextBoxDistance
            // 
            this.TextBoxDistance.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDistance.Location = new System.Drawing.Point(212, 376);
            this.TextBoxDistance.Name = "TextBoxDistance";
            this.TextBoxDistance.Size = new System.Drawing.Size(169, 116);
            this.TextBoxDistance.TabIndex = 9;
            this.TextBoxDistance.Text = "";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.Location = new System.Drawing.Point(147, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(128, 32);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Периметр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(209, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Расстояние";
            // 
            // BtnSaveAs
            // 
            this.BtnSaveAs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveAs.Location = new System.Drawing.Point(147, 50);
            this.BtnSaveAs.Name = "BtnSaveAs";
            this.BtnSaveAs.Size = new System.Drawing.Size(128, 29);
            this.BtnSaveAs.TabIndex = 13;
            this.BtnSaveAs.Text = "Сохранить как";
            this.BtnSaveAs.UseVisualStyleBackColor = true;
            this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 504);
            this.Controls.Add(this.BtnSaveAs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TextBoxDistance);
            this.Controls.Add(this.BtnCalcDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFileContents);
            this.Controls.Add(this.TextBoxPerimeter);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalcPerimeter);
            this.Controls.Add(this.BtnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Button BtnCalcPerimeter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RichTextBox TextBoxPerimeter;
        private System.Windows.Forms.RichTextBox TextBoxFileContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalcDistance;
        private System.Windows.Forms.RichTextBox TextBoxDistance;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSaveAs;
    }
}

