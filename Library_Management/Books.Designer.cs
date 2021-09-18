namespace Library_Management
{
    partial class Books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.setcat = new System.Windows.Forms.Label();
            this.infos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.setauth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.setcat);
            this.panel1.Controls.Add(this.infos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.setauth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 178);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.clicky);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.Goldy);
            this.panel1.MouseLeave += new System.EventHandler(this.Plainey);
            // 
            // setcat
            // 
            this.setcat.Font = new System.Drawing.Font("Roboto", 7F);
            this.setcat.ForeColor = System.Drawing.Color.DimGray;
            this.setcat.Location = new System.Drawing.Point(204, 69);
            this.setcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setcat.Name = "setcat";
            this.setcat.Size = new System.Drawing.Size(151, 39);
            this.setcat.TabIndex = 11;
            this.setcat.Text = "Author();";
            this.setcat.Click += new System.EventHandler(this.clicky);
            this.setcat.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // infos
            // 
            this.infos.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos.ForeColor = System.Drawing.Color.DimGray;
            this.infos.Location = new System.Drawing.Point(149, 123);
            this.infos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(207, 45);
            this.infos.TabIndex = 10;
            this.infos.Text = "Author();";
            this.infos.Click += new System.EventHandler(this.clicky);
            this.infos.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(149, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Information :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.clicky);
            this.label7.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(148, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.clicky);
            this.label5.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Author :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.clicky);
            this.label4.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.clicky);
            this.label3.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 190);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.clicky);
            this.panel2.MouseEnter += new System.EventHandler(this.Goldy);
            this.panel2.MouseLeave += new System.EventHandler(this.Plainey);
            // 
            // setauth
            // 
            this.setauth.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setauth.ForeColor = System.Drawing.Color.DimGray;
            this.setauth.Location = new System.Drawing.Point(192, 49);
            this.setauth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setauth.Name = "setauth";
            this.setauth.Size = new System.Drawing.Size(144, 19);
            this.setauth.TabIndex = 1;
            this.setauth.Text = "Author();";
            this.setauth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setauth.Click += new System.EventHandler(this.clicky);
            this.setauth.MouseEnter += new System.EventHandler(this.Goldy);
            this.setauth.MouseLeave += new System.EventHandler(this.Plainey);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.clicky);
            this.label1.MouseEnter += new System.EventHandler(this.Goldy);
            this.label1.MouseLeave += new System.EventHandler(this.Plainey);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(143, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 162);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 178);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 160);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.clicky);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Goldy);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(367, 177);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Books";
            this.Text = "Books";
            this.MouseLeave += new System.EventHandler(this.Plainey);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label setauth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label infos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label setcat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}