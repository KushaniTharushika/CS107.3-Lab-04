namespace Lab_04_2
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblno2 = new System.Windows.Forms.Label();
            this.lblno1 = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.rdbutAddtion = new System.Windows.Forms.RadioButton();
            this.rdbutSubtraction = new System.Windows.Forms.RadioButton();
            this.rdbutDivition = new System.Windows.Forms.RadioButton();
            this.rdbutMultiplycation = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(395, 323);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(334, 330);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblno2
            // 
            this.lblno2.AutoSize = true;
            this.lblno2.Location = new System.Drawing.Point(305, 162);
            this.lblno2.Name = "lblno2";
            this.lblno2.Size = new System.Drawing.Size(81, 13);
            this.lblno2.TabIndex = 8;
            this.lblno2.Text = "Enter Number 2";
            // 
            // lblno1
            // 
            this.lblno1.AutoSize = true;
            this.lblno1.Location = new System.Drawing.Point(305, 108);
            this.lblno1.Name = "lblno1";
            this.lblno1.Size = new System.Drawing.Size(81, 13);
            this.lblno1.TabIndex = 7;
            this.lblno1.Text = "Enter Number 1";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(208, 219);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(71, 13);
            this.lblSelect.TabIndex = 14;
            this.lblSelect.Text = "Select Option";
            // 
            // rdbutAddtion
            // 
            this.rdbutAddtion.AutoSize = true;
            this.rdbutAddtion.Location = new System.Drawing.Point(308, 219);
            this.rdbutAddtion.Name = "rdbutAddtion";
            this.rdbutAddtion.Size = new System.Drawing.Size(63, 17);
            this.rdbutAddtion.TabIndex = 15;
            this.rdbutAddtion.TabStop = true;
            this.rdbutAddtion.Text = "Addition";
            this.rdbutAddtion.UseVisualStyleBackColor = true;
            this.rdbutAddtion.CheckedChanged += new System.EventHandler(this.rdbutAddtion_CheckedChanged);
            // 
            // rdbutSubtraction
            // 
            this.rdbutSubtraction.AutoSize = true;
            this.rdbutSubtraction.Location = new System.Drawing.Point(391, 218);
            this.rdbutSubtraction.Name = "rdbutSubtraction";
            this.rdbutSubtraction.Size = new System.Drawing.Size(79, 17);
            this.rdbutSubtraction.TabIndex = 16;
            this.rdbutSubtraction.TabStop = true;
            this.rdbutSubtraction.Text = "Subtraction";
            this.rdbutSubtraction.UseVisualStyleBackColor = true;
            this.rdbutSubtraction.CheckedChanged += new System.EventHandler(this.rdbutSubtraction_CheckedChanged);
            // 
            // rdbutDivition
            // 
            this.rdbutDivition.AutoSize = true;
            this.rdbutDivition.Location = new System.Drawing.Point(488, 218);
            this.rdbutDivition.Name = "rdbutDivition";
            this.rdbutDivition.Size = new System.Drawing.Size(60, 17);
            this.rdbutDivition.TabIndex = 17;
            this.rdbutDivition.TabStop = true;
            this.rdbutDivition.Text = "Divition";
            this.rdbutDivition.UseVisualStyleBackColor = true;
            this.rdbutDivition.CheckedChanged += new System.EventHandler(this.rdbutDivition_CheckedChanged);
            // 
            // rdbutMultiplycation
            // 
            this.rdbutMultiplycation.AutoSize = true;
            this.rdbutMultiplycation.Location = new System.Drawing.Point(572, 219);
            this.rdbutMultiplycation.Name = "rdbutMultiplycation";
            this.rdbutMultiplycation.Size = new System.Drawing.Size(89, 17);
            this.rdbutMultiplycation.TabIndex = 18;
            this.rdbutMultiplycation.TabStop = true;
            this.rdbutMultiplycation.Text = "Multiplycation";
            this.rdbutMultiplycation.UseVisualStyleBackColor = true;
            this.rdbutMultiplycation.CheckedChanged += new System.EventHandler(this.rdbutMultiplycation_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbutMultiplycation);
            this.Controls.Add(this.rdbutDivition);
            this.Controls.Add(this.rdbutSubtraction);
            this.Controls.Add(this.rdbutAddtion);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
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

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblno2;
        private System.Windows.Forms.Label lblno1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.RadioButton rdbutAddtion;
        private System.Windows.Forms.RadioButton rdbutSubtraction;
        private System.Windows.Forms.RadioButton rdbutDivition;
        private System.Windows.Forms.RadioButton rdbutMultiplycation;
    }
}

