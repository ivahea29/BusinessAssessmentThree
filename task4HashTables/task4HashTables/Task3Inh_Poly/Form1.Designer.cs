namespace Task3Inh_Poly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cow_milk_input = new System.Windows.Forms.TextBox();
            this.goat_milk_input = new System.Windows.Forms.TextBox();
            this.goat_vax_input = new System.Windows.Forms.TextBox();
            this.cow_vax_input = new System.Windows.Forms.TextBox();
            this.jersey_vax_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.total_prof_output = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cow_milk_input
            // 
            this.cow_milk_input.Location = new System.Drawing.Point(124, 142);
            this.cow_milk_input.Name = "cow_milk_input";
            this.cow_milk_input.Size = new System.Drawing.Size(100, 23);
            this.cow_milk_input.TabIndex = 0;
            // 
            // goat_milk_input
            // 
            this.goat_milk_input.Location = new System.Drawing.Point(124, 177);
            this.goat_milk_input.Name = "goat_milk_input";
            this.goat_milk_input.Size = new System.Drawing.Size(100, 23);
            this.goat_milk_input.TabIndex = 1;
            // 
            // goat_vax_input
            // 
            this.goat_vax_input.Location = new System.Drawing.Point(554, 189);
            this.goat_vax_input.Name = "goat_vax_input";
            this.goat_vax_input.Size = new System.Drawing.Size(100, 23);
            this.goat_vax_input.TabIndex = 2;
            // 
            // cow_vax_input
            // 
            this.cow_vax_input.Location = new System.Drawing.Point(554, 160);
            this.cow_vax_input.Name = "cow_vax_input";
            this.cow_vax_input.Size = new System.Drawing.Size(100, 23);
            this.cow_vax_input.TabIndex = 3;
            // 
            // jersey_vax_input
            // 
            this.jersey_vax_input.Location = new System.Drawing.Point(554, 131);
            this.jersey_vax_input.Name = "jersey_vax_input";
            this.jersey_vax_input.Size = new System.Drawing.Size(100, 23);
            this.jersey_vax_input.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Cows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Goat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(290, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calculate Profitability";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(135, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Milk Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // total_prof_output
            // 
            this.total_prof_output.Location = new System.Drawing.Point(337, 315);
            this.total_prof_output.Name = "total_prof_output";
            this.total_prof_output.Size = new System.Drawing.Size(108, 23);
            this.total_prof_output.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(542, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vaccination Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Jersey Cow";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cow";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(513, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Goat";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Profitability:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total_prof_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jersey_vax_input);
            this.Controls.Add(this.cow_vax_input);
            this.Controls.Add(this.goat_vax_input);
            this.Controls.Add(this.goat_milk_input);
            this.Controls.Add(this.cow_milk_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cow_milk_input;
        private TextBox goat_milk_input;
        private TextBox goat_vax_input;
        private TextBox cow_vax_input;
        private TextBox jersey_vax_input;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox total_prof_output;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}