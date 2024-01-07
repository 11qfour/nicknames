
namespace nickname_csharp_mech
{
    partial class ExistNN
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
            this.ExistLabel1 = new System.Windows.Forms.Label();
            this.ExistStartTB = new System.Windows.Forms.TextBox();
            this.ExistResultButton = new System.Windows.Forms.TextBox();
            this.ExistButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExistLabel1
            // 
            this.ExistLabel1.AutoSize = true;
            this.ExistLabel1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistLabel1.Location = new System.Drawing.Point(12, 9);
            this.ExistLabel1.Name = "ExistLabel1";
            this.ExistLabel1.Size = new System.Drawing.Size(344, 26);
            this.ExistLabel1.TabIndex = 0;
            this.ExistLabel1.Text = "Введите существующий никнейм";
            // 
            // ExistStartTB
            // 
            this.ExistStartTB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExistStartTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistStartTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExistStartTB.Location = new System.Drawing.Point(47, 28);
            this.ExistStartTB.Name = "ExistStartTB";
            this.ExistStartTB.Size = new System.Drawing.Size(242, 30);
            this.ExistStartTB.TabIndex = 1;
            this.ExistStartTB.Text = "Ваш никнейм";
            this.ExistStartTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExistStartTB.Click += new System.EventHandler(this.ExistStartTB_Click);
            // 
            // ExistResultButton
            // 
            this.ExistResultButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExistResultButton.Enabled = false;
            this.ExistResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistResultButton.Location = new System.Drawing.Point(47, 208);
            this.ExistResultButton.Name = "ExistResultButton";
            this.ExistResultButton.Size = new System.Drawing.Size(242, 30);
            this.ExistResultButton.TabIndex = 2;
            this.ExistResultButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExistButton
            // 
            this.ExistButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ExistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistButton.Location = new System.Drawing.Point(84, 111);
            this.ExistButton.Name = "ExistButton";
            this.ExistButton.Size = new System.Drawing.Size(171, 44);
            this.ExistButton.TabIndex = 3;
            this.ExistButton.Text = "Видоизменить";
            this.ExistButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(126, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExistNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExistButton);
            this.Controls.Add(this.ExistResultButton);
            this.Controls.Add(this.ExistStartTB);
            this.Controls.Add(this.ExistLabel1);
            this.Name = "ExistNN";
            this.Text = "Видоизменить существующий Никнейм";
            this.Load += new System.EventHandler(this.ExistNN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExistLabel1;
        private System.Windows.Forms.TextBox ExistStartTB;
        private System.Windows.Forms.TextBox ExistResultButton;
        private System.Windows.Forms.Button ExistButton;
        private System.Windows.Forms.Button button1;
    }
}