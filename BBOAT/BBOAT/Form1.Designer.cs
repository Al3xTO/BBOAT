namespace BBOAT
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
            this.labelBoat = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonSpeedPlus = new System.Windows.Forms.Button();
            this.ButtonSpeedMinus = new System.Windows.Forms.Button();
            this.ButtonPlusPlus = new System.Windows.Forms.Button();
            this.ButtonMinusMinus = new System.Windows.Forms.Button();
            this.ButtonMax = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBoat
            // 
            this.labelBoat.AutoSize = true;
            this.labelBoat.Location = new System.Drawing.Point(6, 58);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(26, 13);
            this.labelBoat.TabIndex = 3;
            this.labelBoat.Text = "Тип";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(6, 82);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(59, 13);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Швидкість";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 107);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(91, 13);
            this.labelMaxSpeed.TabIndex = 5;
            this.labelMaxSpeed.Text = "Макс  швидкість";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(-4, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 167);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::BBOAT.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonSpeedPlus
            // 
            this.ButtonSpeedPlus.Location = new System.Drawing.Point(12, 225);
            this.ButtonSpeedPlus.Name = "ButtonSpeedPlus";
            this.ButtonSpeedPlus.Size = new System.Drawing.Size(39, 23);
            this.ButtonSpeedPlus.TabIndex = 6;
            this.ButtonSpeedPlus.Text = "+ 1";
            this.ButtonSpeedPlus.UseVisualStyleBackColor = true;
            this.ButtonSpeedPlus.Click += new System.EventHandler(this.ButtonSpeedPlus_Click);
            // 
            // ButtonSpeedMinus
            // 
            this.ButtonSpeedMinus.Location = new System.Drawing.Point(12, 254);
            this.ButtonSpeedMinus.Name = "ButtonSpeedMinus";
            this.ButtonSpeedMinus.Size = new System.Drawing.Size(39, 23);
            this.ButtonSpeedMinus.TabIndex = 7;
            this.ButtonSpeedMinus.Text = "- 1";
            this.ButtonSpeedMinus.UseVisualStyleBackColor = true;
            this.ButtonSpeedMinus.Click += new System.EventHandler(this.ButtonSpeedMinus_Click);
            // 
            // ButtonPlusPlus
            // 
            this.ButtonPlusPlus.Location = new System.Drawing.Point(57, 225);
            this.ButtonPlusPlus.Name = "ButtonPlusPlus";
            this.ButtonPlusPlus.Size = new System.Drawing.Size(39, 23);
            this.ButtonPlusPlus.TabIndex = 8;
            this.ButtonPlusPlus.Text = "+ 5";
            this.ButtonPlusPlus.UseVisualStyleBackColor = true;
            this.ButtonPlusPlus.Click += new System.EventHandler(this.ButtonPlusPlus_Click);
            // 
            // ButtonMinusMinus
            // 
            this.ButtonMinusMinus.Location = new System.Drawing.Point(59, 254);
            this.ButtonMinusMinus.Name = "ButtonMinusMinus";
            this.ButtonMinusMinus.Size = new System.Drawing.Size(37, 23);
            this.ButtonMinusMinus.TabIndex = 9;
            this.ButtonMinusMinus.Text = "- 5";
            this.ButtonMinusMinus.UseVisualStyleBackColor = true;
            this.ButtonMinusMinus.Click += new System.EventHandler(this.ButtonMinusMinus_Click);
            // 
            // ButtonMax
            // 
            this.ButtonMax.Location = new System.Drawing.Point(102, 225);
            this.ButtonMax.Name = "ButtonMax";
            this.ButtonMax.Size = new System.Drawing.Size(37, 23);
            this.ButtonMax.TabIndex = 10;
            this.ButtonMax.Text = "Max";
            this.ButtonMax.UseVisualStyleBackColor = true;
            this.ButtonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Location = new System.Drawing.Point(102, 254);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(37, 23);
            this.ButtonMin.TabIndex = 11;
            this.ButtonMin.Text = "Stop";
            this.ButtonMin.UseVisualStyleBackColor = true;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Управління швидкістю:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonMin);
            this.Controls.Add(this.ButtonMax);
            this.Controls.Add(this.ButtonMinusMinus);
            this.Controls.Add(this.ButtonPlusPlus);
            this.Controls.Add(this.ButtonSpeedMinus);
            this.Controls.Add(this.ButtonSpeedPlus);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelBoat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Button ButtonSpeedPlus;
        private System.Windows.Forms.Button ButtonSpeedMinus;
        private System.Windows.Forms.Button ButtonPlusPlus;
        private System.Windows.Forms.Button ButtonMinusMinus;
        private System.Windows.Forms.Button ButtonMax;
        private System.Windows.Forms.Button ButtonMin;
        private System.Windows.Forms.Label label1;
    }
}

