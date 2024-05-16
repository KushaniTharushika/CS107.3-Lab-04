namespace Lab_04_1
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
            this.lblno1 = new System.Windows.Forms.Label();
            this.lblno2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblno1
            // 
            this.lblno1.AutoSize = true;
            this.lblno1.Location = new System.Drawing.Point(177, 81);
            this.lblno1.Name = "lblno1";
            this.lblno1.Size = new System.Drawing.Size(81, 13);
            this.lblno1.TabIndex = 0;
            this.lblno1.Text = "Enter Number 1";
            // 
            // lblno2
            // 
            this.lblno2.AutoSize = true;
            this.lblno2.Location = new System.Drawing.Point(177, 135);
            this.lblno2.Name = "lblno2";
            this.lblno2.Size = new System.Drawing.Size(81, 13);
            this.lblno2.TabIndex = 1;
            this.lblno2.Text = "Enter Number 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // butCalculate
            // 
            this.butCalculate.Location = new System.Drawing.Point(219, 215);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(75, 23);
            this.butCalculate.TabIndex = 4;
            this.butCalculate.Text = "Calculate";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(206, 303);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(267, 296);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.butCalculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblno2);
            this.Controls.Add(this.lblno1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblno1;
        private System.Windows.Forms.Label lblno2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

