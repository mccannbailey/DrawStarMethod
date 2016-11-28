namespace DrawStarMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 300);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // xBox
            // 
            this.xBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xBox.Location = new System.Drawing.Point(12, 25);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(49, 20);
            this.xBox.TabIndex = 1;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.White;
            this.xLabel.ForeColor = System.Drawing.Color.Black;
            this.xLabel.Location = new System.Drawing.Point(9, 9);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(68, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x coordinate:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.BackColor = System.Drawing.Color.White;
            this.yLabel.ForeColor = System.Drawing.Color.Black;
            this.yLabel.Location = new System.Drawing.Point(9, 61);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(68, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "y coordinate:";
            // 
            // yBox
            // 
            this.yBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yBox.Location = new System.Drawing.Point(12, 77);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(49, 20);
            this.yBox.TabIndex = 4;
            // 
            // sizeBox
            // 
            this.sizeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeBox.Location = new System.Drawing.Point(12, 127);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(49, 20);
            this.sizeBox.TabIndex = 5;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.BackColor = System.Drawing.Color.White;
            this.sizeLabel.ForeColor = System.Drawing.Color.Black;
            this.sizeLabel.Location = new System.Drawing.Point(9, 111);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 6;
            this.sizeLabel.Text = "Size:";
            // 
            // drawButton
            // 
            this.drawButton.ForeColor = System.Drawing.Color.Black;
            this.drawButton.Location = new System.Drawing.Point(12, 213);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(49, 23);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Black;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(86, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 8;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Silver;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "White"});
            this.colorBox.Location = new System.Drawing.Point(12, 175);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(49, 21);
            this.colorBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Label label2;
    }
}

