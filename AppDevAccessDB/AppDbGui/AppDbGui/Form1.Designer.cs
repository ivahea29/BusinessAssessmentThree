namespace AppDbGui
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
            this.outputQry = new System.Windows.Forms.DataGridView();
            this.btnQry = new System.Windows.Forms.Button();
            this.inputQry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputQry)).BeginInit();
            this.SuspendLayout();
            // 
            // outputQry
            // 
            this.outputQry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputQry.Location = new System.Drawing.Point(82, 100);
            this.outputQry.Name = "outputQry";
            this.outputQry.RowTemplate.Height = 25;
            this.outputQry.Size = new System.Drawing.Size(633, 309);
            this.outputQry.TabIndex = 0;
            // 
            // btnQry
            // 
            this.btnQry.Location = new System.Drawing.Point(349, 71);
            this.btnQry.Name = "btnQry";
            this.btnQry.Size = new System.Drawing.Size(75, 23);
            this.btnQry.TabIndex = 1;
            this.btnQry.Text = "Generate";
            this.btnQry.UseVisualStyleBackColor = true;
            this.btnQry.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputQry
            // 
            this.inputQry.Location = new System.Drawing.Point(142, 42);
            this.inputQry.Name = "inputQry";
            this.inputQry.Size = new System.Drawing.Size(509, 23);
            this.inputQry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Table Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputQry);
            this.Controls.Add(this.btnQry);
            this.Controls.Add(this.outputQry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.outputQry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView outputQry;
        private Button btnQry;
        private TextBox inputQry;
        private Label label1;
    }
}