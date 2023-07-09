namespace Constructor
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
            this.btnBirth = new System.Windows.Forms.Button();
            this.txtBaby = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBirth
            // 
            this.btnBirth.Location = new System.Drawing.Point(117, 153);
            this.btnBirth.Name = "btnBirth";
            this.btnBirth.Size = new System.Drawing.Size(75, 23);
            this.btnBirth.TabIndex = 0;
            this.btnBirth.Text = "btnBirth";
            this.btnBirth.UseVisualStyleBackColor = true;
            this.btnBirth.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBaby
            // 
            this.txtBaby.Location = new System.Drawing.Point(236, 156);
            this.txtBaby.Name = "txtBaby";
            this.txtBaby.Size = new System.Drawing.Size(100, 20);
            this.txtBaby.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBaby);
            this.Controls.Add(this.btnBirth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBirth;
        private System.Windows.Forms.TextBox txtBaby;
    }
}

