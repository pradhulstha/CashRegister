namespace WindowsFormsApplication2
{
    partial class RegisterStartForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.pennyLabel = new System.Windows.Forms.Label();
            this.nickelLabel = new System.Windows.Forms.Label();
            this.dimeLabel = new System.Windows.Forms.Label();
            this.quaterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pennyBox = new System.Windows.Forms.TextBox();
            this.niceklBox = new System.Windows.Forms.TextBox();
            this.dimeBox = new System.Windows.Forms.TextBox();
            this.quaterBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 837);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 44);
            this.button3.TabIndex = 34;
            this.button3.Text = "New Transaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pennyLabel
            // 
            this.pennyLabel.AutoSize = true;
            this.pennyLabel.Location = new System.Drawing.Point(362, 235);
            this.pennyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pennyLabel.Name = "pennyLabel";
            this.pennyLabel.Size = new System.Drawing.Size(42, 25);
            this.pennyLabel.TabIndex = 33;
            this.pennyLabel.Text = "0.0";
            // 
            // nickelLabel
            // 
            this.nickelLabel.AutoSize = true;
            this.nickelLabel.Location = new System.Drawing.Point(362, 188);
            this.nickelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nickelLabel.Name = "nickelLabel";
            this.nickelLabel.Size = new System.Drawing.Size(42, 25);
            this.nickelLabel.TabIndex = 32;
            this.nickelLabel.Text = "0.0";
            // 
            // dimeLabel
            // 
            this.dimeLabel.AutoSize = true;
            this.dimeLabel.Location = new System.Drawing.Point(362, 142);
            this.dimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dimeLabel.Name = "dimeLabel";
            this.dimeLabel.Size = new System.Drawing.Size(42, 25);
            this.dimeLabel.TabIndex = 31;
            this.dimeLabel.Text = "0.0";
            // 
            // quaterLabel
            // 
            this.quaterLabel.AutoSize = true;
            this.quaterLabel.Location = new System.Drawing.Point(362, 96);
            this.quaterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quaterLabel.Name = "quaterLabel";
            this.quaterLabel.Size = new System.Drawing.Size(42, 25);
            this.quaterLabel.TabIndex = 30;
            this.quaterLabel.Text = "0.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 837);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(286, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 36);
            this.label10.TabIndex = 28;
            this.label10.Text = "Add New Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 36);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 40);
            this.label8.TabIndex = 26;
            this.label8.Text = "Pennies:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 40);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nickels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 40);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quaters:";
            // 
            // pennyBox
            // 
            this.pennyBox.Location = new System.Drawing.Point(368, 602);
            this.pennyBox.Margin = new System.Windows.Forms.Padding(6);
            this.pennyBox.Name = "pennyBox";
            this.pennyBox.Size = new System.Drawing.Size(196, 31);
            this.pennyBox.TabIndex = 23;
            // 
            // niceklBox
            // 
            this.niceklBox.Location = new System.Drawing.Point(368, 525);
            this.niceklBox.Margin = new System.Windows.Forms.Padding(6);
            this.niceklBox.Name = "niceklBox";
            this.niceklBox.Size = new System.Drawing.Size(196, 31);
            this.niceklBox.TabIndex = 22;
            // 
            // dimeBox
            // 
            this.dimeBox.Location = new System.Drawing.Point(368, 448);
            this.dimeBox.Margin = new System.Windows.Forms.Padding(6);
            this.dimeBox.Name = "dimeBox";
            this.dimeBox.Size = new System.Drawing.Size(196, 31);
            this.dimeBox.TabIndex = 21;
            // 
            // quaterBox
            // 
            this.quaterBox.Location = new System.Drawing.Point(368, 371);
            this.quaterBox.Margin = new System.Windows.Forms.Padding(6);
            this.quaterBox.Name = "quaterBox";
            this.quaterBox.Size = new System.Drawing.Size(196, 31);
            this.quaterBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 608);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pennies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 531);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nickels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dimes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quaters";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 681);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 40);
            this.label6.TabIndex = 35;
            this.label6.Text = "Dimes:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 766);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 44);
            this.button4.TabIndex = 36;
            this.button4.Text = "Reciept";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RegisterStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 933);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pennyLabel);
            this.Controls.Add(this.nickelLabel);
            this.Controls.Add(this.dimeLabel);
            this.Controls.Add(this.quaterLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pennyBox);
            this.Controls.Add(this.niceklBox);
            this.Controls.Add(this.dimeBox);
            this.Controls.Add(this.quaterBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label pennyLabel;
        private System.Windows.Forms.Label nickelLabel;
        private System.Windows.Forms.Label dimeLabel;
        private System.Windows.Forms.Label quaterLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pennyBox;
        private System.Windows.Forms.TextBox niceklBox;
        private System.Windows.Forms.TextBox dimeBox;
        private System.Windows.Forms.TextBox quaterBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}