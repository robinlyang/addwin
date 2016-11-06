namespace addwin
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
            this.number1Lbl = new System.Windows.Forms.Label();
            this.number2Lbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.number1TxtBox = new System.Windows.Forms.TextBox();
            this.number2TxtBox = new System.Windows.Forms.TextBox();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number1Lbl
            // 
            this.number1Lbl.AutoSize = true;
            this.number1Lbl.Location = new System.Drawing.Point(13, 13);
            this.number1Lbl.Name = "number1Lbl";
            this.number1Lbl.Size = new System.Drawing.Size(53, 13);
            this.number1Lbl.TabIndex = 0;
            this.number1Lbl.Text = "Number 1";
            this.number1Lbl.Click += new System.EventHandler(this.number1Lbl_Click);
            // 
            // number2Lbl
            // 
            this.number2Lbl.AutoSize = true;
            this.number2Lbl.Location = new System.Drawing.Point(12, 45);
            this.number2Lbl.Name = "number2Lbl";
            this.number2Lbl.Size = new System.Drawing.Size(53, 13);
            this.number2Lbl.TabIndex = 1;
            this.number2Lbl.Text = "Number 2";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 73);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(12, 118);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(31, 13);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "Total";
            // 
            // number1TxtBox
            // 
            this.number1TxtBox.Location = new System.Drawing.Point(170, 13);
            this.number1TxtBox.Name = "number1TxtBox";
            this.number1TxtBox.Size = new System.Drawing.Size(100, 20);
            this.number1TxtBox.TabIndex = 4;
            this.number1TxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number2TxtBox
            // 
            this.number2TxtBox.Location = new System.Drawing.Point(170, 42);
            this.number2TxtBox.Name = "number2TxtBox";
            this.number2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.number2TxtBox.TabIndex = 5;
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Location = new System.Drawing.Point(170, 111);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.totalTxtBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.number2TxtBox);
            this.Controls.Add(this.number1TxtBox);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.number2Lbl);
            this.Controls.Add(this.number1Lbl);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number1Lbl;
        private System.Windows.Forms.Label number2Lbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox number1TxtBox;
        private System.Windows.Forms.TextBox number2TxtBox;
        private System.Windows.Forms.TextBox totalTxtBox;
    }
}

