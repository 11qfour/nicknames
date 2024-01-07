
namespace nickname_csharp_mech
{
    partial class basepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basepage));
            this.basepageLabel1 = new System.Windows.Forms.Label();
            this.ExistNNButton = new System.Windows.Forms.Button();
            this.NewNNButton = new System.Windows.Forms.Button();
            this.LikedNNButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ExitMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basepageLabel1
            // 
            this.basepageLabel1.AutoSize = true;
            this.basepageLabel1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basepageLabel1.Location = new System.Drawing.Point(0, 9);
            this.basepageLabel1.Name = "basepageLabel1";
            this.basepageLabel1.Size = new System.Drawing.Size(359, 31);
            this.basepageLabel1.TabIndex = 0;
            this.basepageLabel1.Text = "Сгенерируй свой никнейм!";
            // 
            // ExistNNButton
            // 
            this.ExistNNButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExistNNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistNNButton.Location = new System.Drawing.Point(22, 30);
            this.ExistNNButton.Name = "ExistNNButton";
            this.ExistNNButton.Size = new System.Drawing.Size(310, 63);
            this.ExistNNButton.TabIndex = 1;
            this.ExistNNButton.Text = "Изменить имеющийся никнейм";
            this.ExistNNButton.UseVisualStyleBackColor = false;
            this.ExistNNButton.Click += new System.EventHandler(this.ExistNNButton_Click);
            // 
            // NewNNButton
            // 
            this.NewNNButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewNNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNNButton.Location = new System.Drawing.Point(22, 125);
            this.NewNNButton.Name = "NewNNButton";
            this.NewNNButton.Size = new System.Drawing.Size(310, 46);
            this.NewNNButton.TabIndex = 2;
            this.NewNNButton.Text = "Новый Никнейм";
            this.NewNNButton.UseVisualStyleBackColor = false;
            this.NewNNButton.Click += new System.EventHandler(this.NewNNButton_Click);
            // 
            // LikedNNButton
            // 
            this.LikedNNButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LikedNNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedNNButton.Location = new System.Drawing.Point(22, 207);
            this.LikedNNButton.Name = "LikedNNButton";
            this.LikedNNButton.Size = new System.Drawing.Size(310, 46);
            this.LikedNNButton.TabIndex = 3;
            this.LikedNNButton.Text = "Понравившиеся Никенеймы";
            this.LikedNNButton.UseVisualStyleBackColor = false;
            this.LikedNNButton.Click += new System.EventHandler(this.LikedNNButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Teal;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.Location = new System.Drawing.Point(22, 286);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(140, 40);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Справка";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ExitMainButton
            // 
            this.ExitMainButton.BackColor = System.Drawing.Color.Teal;
            this.ExitMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitMainButton.Location = new System.Drawing.Point(192, 286);
            this.ExitMainButton.Name = "ExitMainButton";
            this.ExitMainButton.Size = new System.Drawing.Size(140, 40);
            this.ExitMainButton.TabIndex = 5;
            this.ExitMainButton.Text = "Выйти";
            this.ExitMainButton.UseVisualStyleBackColor = false;
            this.ExitMainButton.Click += new System.EventHandler(this.ExitMainButton_Click);
            // 
            // basepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.ExitMainButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.LikedNNButton);
            this.Controls.Add(this.NewNNButton);
            this.Controls.Add(this.ExistNNButton);
            this.Controls.Add(this.basepageLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "basepage";
            this.Text = "Никнейм для социальных сетей";
            this.Load += new System.EventHandler(this.basepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label basepageLabel1;
        private System.Windows.Forms.Button ExistNNButton;
        private System.Windows.Forms.Button NewNNButton;
        private System.Windows.Forms.Button LikedNNButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button ExitMainButton;
    }
}

