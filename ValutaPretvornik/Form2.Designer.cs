namespace ValutaPretvornik
{
    partial class Form2
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
            this.prijavatxtbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijavatxtbox
            // 
            this.prijavatxtbox.Location = new System.Drawing.Point(13, 13);
            this.prijavatxtbox.Name = "prijavatxtbox";
            this.prijavatxtbox.Size = new System.Drawing.Size(100, 20);
            this.prijavatxtbox.TabIndex = 0;
            this.prijavatxtbox.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(136, 13);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Prijava";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 52);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.prijavatxtbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prijavatxtbox;
        private System.Windows.Forms.Button loginbutton;
    }
}