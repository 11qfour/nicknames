
namespace nickname_csharp_mech
{
    partial class InfoNN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoNN));
            this.InfoRichTB = new System.Windows.Forms.RichTextBox();
            this.BackExistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRichTB
            // 
            this.InfoRichTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoRichTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InfoRichTB.Enabled = false;
            this.InfoRichTB.Location = new System.Drawing.Point(0, -2);
            this.InfoRichTB.Name = "InfoRichTB";
            this.InfoRichTB.Size = new System.Drawing.Size(356, 293);
            this.InfoRichTB.TabIndex = 0;
            this.InfoRichTB.Text = "";
            // 
            // BackExistButton
            // 
            this.BackExistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackExistButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackExistButton.Image = ((System.Drawing.Image)(resources.GetObject("BackExistButton.Image")));
            this.BackExistButton.Location = new System.Drawing.Point(153, 298);
            this.BackExistButton.Name = "BackExistButton";
            this.BackExistButton.Size = new System.Drawing.Size(50, 50);
            this.BackExistButton.TabIndex = 5;
            this.BackExistButton.UseVisualStyleBackColor = false;
            this.BackExistButton.Click += new System.EventHandler(this.BackExistButton_Click);
            // 
            // InfoNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.BackExistButton);
            this.Controls.Add(this.InfoRichTB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "InfoNN";
            this.Text = "InfoNN";
            this.Load += new System.EventHandler(this.InfoNN_Load);
            this.Resize += new System.EventHandler(this.InfoNN_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoRichTB;
        private System.Windows.Forms.Button BackExistButton;
    }
}