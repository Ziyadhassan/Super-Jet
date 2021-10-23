namespace OurCrystal
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
            this.AD_btn = new System.Windows.Forms.Button();
            this.Rent_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AD_btn
            // 
            this.AD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD_btn.ForeColor = System.Drawing.Color.Black;
            this.AD_btn.Location = new System.Drawing.Point(49, 42);
            this.AD_btn.Name = "AD_btn";
            this.AD_btn.Size = new System.Drawing.Size(318, 89);
            this.AD_btn.TabIndex = 0;
            this.AD_btn.Text = "Statistics About Ad Contracts";
            this.AD_btn.UseVisualStyleBackColor = true;
            this.AD_btn.Click += new System.EventHandler(this.AD_btn_Click);
            // 
            // Rent_btn
            // 
            this.Rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_btn.ForeColor = System.Drawing.Color.Black;
            this.Rent_btn.Location = new System.Drawing.Point(49, 241);
            this.Rent_btn.Name = "Rent_btn";
            this.Rent_btn.Size = new System.Drawing.Size(318, 89);
            this.Rent_btn.TabIndex = 0;
            this.Rent_btn.Text = "Statistics About Rent Contracts";
            this.Rent_btn.UseVisualStyleBackColor = true;
            this.Rent_btn.Click += new System.EventHandler(this.Rent_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.Rent_btn);
            this.Controls.Add(this.AD_btn);
            this.Name = "Form1";
            this.Text = "AD Contracts Statistical";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AD_btn;
        private System.Windows.Forms.Button Rent_btn;
    }
}

