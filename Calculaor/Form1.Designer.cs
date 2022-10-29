namespace Calculaor
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
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiples = new System.Windows.Forms.Button();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtnumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtnumber2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnplus.Location = new System.Drawing.Point(91, 90);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(59, 24);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnminus.Location = new System.Drawing.Point(156, 90);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(59, 24);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiples
            // 
            this.btnmultiples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnmultiples.Location = new System.Drawing.Point(221, 90);
            this.btnmultiples.Name = "btnmultiples";
            this.btnmultiples.Size = new System.Drawing.Size(59, 23);
            this.btnmultiples.TabIndex = 2;
            this.btnmultiples.Text = "*";
            this.btnmultiples.UseVisualStyleBackColor = false;
            this.btnmultiples.Click += new System.EventHandler(this.btnmultiples_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(307, 49);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(68, 24);
            this.lblnum2.TabIndex = 6;
            this.lblnum2.Text = "عدد دوم :";
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(307, 20);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(66, 24);
            this.lblnum1.TabIndex = 7;
            this.lblnum1.Text = "عدد اول :";
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPower.Location = new System.Drawing.Point(26, 91);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(59, 23);
            this.btnPower.TabIndex = 8;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDivide.Location = new System.Drawing.Point(286, 89);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(26, 21);
            this.txtnumber1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtnumber1.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(269, 23);
            this.txtnumber1.TabIndex = 11;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(26, 50);
            this.txtnumber2.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtnumber2.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(269, 23);
            this.txtnumber2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(397, 135);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnmultiples);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiples;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.NumericUpDown txtnumber1;
        private System.Windows.Forms.NumericUpDown txtnumber2;
    }
}

