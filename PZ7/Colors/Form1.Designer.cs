namespace Colors
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Color = new System.Windows.Forms.PictureBox();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.18045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.90226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2406F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Color, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_red, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_green, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_blue, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_red, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_green, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_blue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.106434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_Color
            // 
            this.pictureBox_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Color.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_Color.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Color.Name = "pictureBox_Color";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox_Color, 9);
            this.pictureBox_Color.Size = new System.Drawing.Size(230, 221);
            this.pictureBox_Color.TabIndex = 0;
            this.pictureBox_Color.TabStop = false;
            this.pictureBox_Color.MouseHover += new System.EventHandler(this.pictureBox_Color_MouseHover);
            // 
            // trackBar_red
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_red, 2);
            this.trackBar_red.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_red.Location = new System.Drawing.Point(310, 22);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(219, 35);
            this.trackBar_red.TabIndex = 1;
            this.trackBar_red.TickFrequency = 15;
            this.trackBar_red.Value = 125;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_red_Scroll);
            // 
            // trackBar_green
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_green, 2);
            this.trackBar_green.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar_green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_green.Location = new System.Drawing.Point(310, 101);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(219, 35);
            this.trackBar_green.TabIndex = 2;
            this.trackBar_green.TickFrequency = 15;
            this.trackBar_green.Value = 125;
            this.trackBar_green.Scroll += new System.EventHandler(this.trackBar_green_Scroll);
            // 
            // trackBar_blue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.trackBar_blue, 2);
            this.trackBar_blue.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_blue.Location = new System.Drawing.Point(310, 180);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(219, 35);
            this.trackBar_blue.TabIndex = 3;
            this.trackBar_blue.TickFrequency = 15;
            this.trackBar_blue.Value = 125;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_blue_Scroll);
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_red.Location = new System.Drawing.Point(253, 19);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(51, 41);
            this.label_red.TabIndex = 4;
            this.label_red.Text = "Red";
            this.label_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_green.Location = new System.Drawing.Point(253, 98);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(51, 41);
            this.label_green.TabIndex = 5;
            this.label_green.Text = "Green";
            this.label_green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_blue.Location = new System.Drawing.Point(253, 177);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(51, 41);
            this.label_blue.TabIndex = 6;
            this.label_blue.Text = "Blue";
            this.label_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(310, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(422, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "255";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(310, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(422, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "255";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(310, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(422, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "255";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Color;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

