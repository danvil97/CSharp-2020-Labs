namespace Button
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
            this.buttonPushMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPushMe
            // 
            this.buttonPushMe.Location = new System.Drawing.Point(363, 202);
            this.buttonPushMe.Name = "buttonPushMe";
            this.buttonPushMe.Size = new System.Drawing.Size(75, 23);
            this.buttonPushMe.TabIndex = 0;
            this.buttonPushMe.Text = "Push me";
            this.buttonPushMe.UseVisualStyleBackColor = true;
            this.buttonPushMe.Click += new System.EventHandler(this.buttonPushMe_Click);
            this.buttonPushMe.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPushMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.WindowResizing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowMouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPushMe;
    }
}

