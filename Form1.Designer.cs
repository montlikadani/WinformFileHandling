namespace FileHandling {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nevBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.readFileButton = new System.Windows.Forms.Button();
            this.readFileRes = new System.Windows.Forms.Label();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nevBox
            // 
            this.nevBox.Location = new System.Drawing.Point(130, 35);
            this.nevBox.Name = "nevBox";
            this.nevBox.Size = new System.Drawing.Size(213, 22);
            this.nevBox.TabIndex = 0;
            this.nevBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dátum";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(130, 75);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(213, 22);
            this.datePicker.TabIndex = 4;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(130, 172);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(213, 30);
            this.readFileButton.TabIndex = 5;
            this.readFileButton.Text = "Fájlból beolvasás";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // readFileRes
            // 
            this.readFileRes.AutoSize = true;
            this.readFileRes.Location = new System.Drawing.Point(127, 214);
            this.readFileRes.Name = "readFileRes";
            this.readFileRes.Size = new System.Drawing.Size(0, 16);
            this.readFileRes.TabIndex = 6;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(130, 136);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(213, 30);
            this.saveToFileButton.TabIndex = 7;
            this.saveToFileButton.Text = "Mentés fájlba";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 298);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.readFileRes);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nevBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fájlkezelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.Label readFileRes;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

