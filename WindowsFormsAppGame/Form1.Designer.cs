namespace WindowsFormsAppGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.btnChoice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enemySoul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(214, 146);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(148, 26);
            this.txtPlayer.TabIndex = 1;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(214, 234);
            this.txtRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(148, 26);
            this.txtRace.TabIndex = 2;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(214, 326);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(148, 26);
            this.txtBranch.TabIndex = 3;
            // 
            // txtGun
            // 
            this.txtGun.BackColor = System.Drawing.SystemColors.Info;
            this.txtGun.Location = new System.Drawing.Point(216, 429);
            this.txtGun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(148, 26);
            this.txtGun.TabIndex = 4;
            this.txtGun.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(411, 211);
            this.btnChoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(164, 54);
            this.btnChoice.TabIndex = 5;
            this.btnChoice.Text = "btnChoice";
            this.btnChoice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "PlayerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Race";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gun";
            // 
            // enemySoul
            // 
            this.enemySoul.BackColor = System.Drawing.SystemColors.Window;
            this.enemySoul.Location = new System.Drawing.Point(635, 198);
            this.enemySoul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemySoul.Name = "enemySoul";
            this.enemySoul.Size = new System.Drawing.Size(450, 39);
            this.enemySoul.TabIndex = 10;
            this.enemySoul.Text = "EnemySoul";
            this.enemySoul.Click += new System.EventHandler(this.EnemySoul_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppGame.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(639, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 253);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(411, 323);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(164, 44);
            this.btnAttack.TabIndex = 12;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1251, 754);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemySoul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label enemySoul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAttack;
    }
}

