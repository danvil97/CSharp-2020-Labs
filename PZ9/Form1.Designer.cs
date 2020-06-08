namespace PZ9
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.trackBarTemp = new System.Windows.Forms.TrackBar();
            this.numericUpDownMolCount = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMolCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.trackBarTemp);
            this.panel1.Controls.Add(this.numericUpDownMolCount);
            this.panel1.Location = new System.Drawing.Point(524, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 114);
            this.panel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(4, 81);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(241, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // trackBarTemp
            // 
            this.trackBarTemp.Location = new System.Drawing.Point(3, 29);
            this.trackBarTemp.Maximum = 20;
            this.trackBarTemp.Name = "trackBarTemp";
            this.trackBarTemp.Size = new System.Drawing.Size(242, 45);
            this.trackBarTemp.TabIndex = 1;
            this.trackBarTemp.Scroll += new System.EventHandler(this.trackBarTemp_Scroll);
            // 
            // numericUpDownMolCount
            // 
            this.numericUpDownMolCount.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownMolCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMolCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMolCount.Name = "numericUpDownMolCount";
            this.numericUpDownMolCount.Size = new System.Drawing.Size(242, 20);
            this.numericUpDownMolCount.TabIndex = 0;
            this.numericUpDownMolCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(506, 426);
            this.pictureBoxDisplay.TabIndex = 1;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMolCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TrackBar trackBarTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownMolCount;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Timer timer1;
    }
}

