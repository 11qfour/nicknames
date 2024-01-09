
namespace nickname_csharp_mech
{
    partial class NewNN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNN));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NNLabel = new System.Windows.Forms.Label();
            this.NewNNButton = new System.Windows.Forms.Button();
            this.NewResultTB = new System.Windows.Forms.TextBox();
            this.CopyExistButton = new System.Windows.Forms.Button();
            this.BackExistButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NewNN3algoRB = new System.Windows.Forms.RadioButton();
            this.NewNN2algoRB = new System.Windows.Forms.RadioButton();
            this.NewNN1algoRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NNLabel
            // 
            this.NNLabel.AutoSize = true;
            this.NNLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NNLabel.Location = new System.Drawing.Point(26, 40);
            this.NNLabel.Name = "NNLabel";
            this.NNLabel.Size = new System.Drawing.Size(138, 13);
            this.NNLabel.TabIndex = 1;
            this.NNLabel.Text = "Выберите тип генератора";
            // 
            // NewNNButton
            // 
            this.NewNNButton.Location = new System.Drawing.Point(124, 160);
            this.NewNNButton.Name = "NewNNButton";
            this.NewNNButton.Size = new System.Drawing.Size(96, 23);
            this.NewNNButton.TabIndex = 2;
            this.NewNNButton.Text = "Сгенерировать";
            this.NewNNButton.UseVisualStyleBackColor = true;
            this.NewNNButton.Click += new System.EventHandler(this.NewNNButton_Click);
            // 
            // NewResultTB
            // 
            this.NewResultTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewResultTB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewResultTB.Enabled = false;
            this.NewResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewResultTB.Location = new System.Drawing.Point(12, 215);
            this.NewResultTB.Name = "NewResultTB";
            this.NewResultTB.Size = new System.Drawing.Size(272, 30);
            this.NewResultTB.TabIndex = 3;
            this.NewResultTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CopyExistButton
            // 
            this.CopyExistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyExistButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyExistButton.Image")));
            this.CopyExistButton.Location = new System.Drawing.Point(307, 214);
            this.CopyExistButton.Name = "CopyExistButton";
            this.CopyExistButton.Size = new System.Drawing.Size(36, 31);
            this.CopyExistButton.TabIndex = 7;
            this.CopyExistButton.UseVisualStyleBackColor = true;
            this.CopyExistButton.Click += new System.EventHandler(this.CopyExistButton_Click);
            // 
            // BackExistButton
            // 
            this.BackExistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackExistButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackExistButton.Image = ((System.Drawing.Image)(resources.GetObject("BackExistButton.Image")));
            this.BackExistButton.Location = new System.Drawing.Point(143, 283);
            this.BackExistButton.Name = "BackExistButton";
            this.BackExistButton.Size = new System.Drawing.Size(50, 50);
            this.BackExistButton.TabIndex = 8;
            this.BackExistButton.UseVisualStyleBackColor = false;
            this.BackExistButton.Click += new System.EventHandler(this.BackExistButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(202, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // NewNN3algoRB
            // 
            this.NewNN3algoRB.AutoSize = true;
            this.NewNN3algoRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewNN3algoRB.Location = new System.Drawing.Point(202, 82);
            this.NewNN3algoRB.Name = "NewNN3algoRB";
            this.NewNN3algoRB.Size = new System.Drawing.Size(31, 17);
            this.NewNN3algoRB.TabIndex = 12;
            this.NewNN3algoRB.TabStop = true;
            this.NewNN3algoRB.Text = "3";
            this.NewNN3algoRB.UseVisualStyleBackColor = true;
            // 
            // NewNN2algoRB
            // 
            this.NewNN2algoRB.AutoSize = true;
            this.NewNN2algoRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewNN2algoRB.Location = new System.Drawing.Point(202, 59);
            this.NewNN2algoRB.Name = "NewNN2algoRB";
            this.NewNN2algoRB.Size = new System.Drawing.Size(31, 17);
            this.NewNN2algoRB.TabIndex = 13;
            this.NewNN2algoRB.TabStop = true;
            this.NewNN2algoRB.Text = "2";
            this.NewNN2algoRB.UseVisualStyleBackColor = true;
            // 
            // NewNN1algoRB
            // 
            this.NewNN1algoRB.AutoSize = true;
            this.NewNN1algoRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewNN1algoRB.Location = new System.Drawing.Point(202, 36);
            this.NewNN1algoRB.Name = "NewNN1algoRB";
            this.NewNN1algoRB.Size = new System.Drawing.Size(31, 17);
            this.NewNN1algoRB.TabIndex = 14;
            this.NewNN1algoRB.TabStop = true;
            this.NewNN1algoRB.Text = "1";
            this.NewNN1algoRB.UseVisualStyleBackColor = true;
            // 
            // NewNN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 360);
            this.Controls.Add(this.NewNN1algoRB);
            this.Controls.Add(this.NewNN2algoRB);
            this.Controls.Add(this.NewNN3algoRB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BackExistButton);
            this.Controls.Add(this.CopyExistButton);
            this.Controls.Add(this.NewResultTB);
            this.Controls.Add(this.NewNNButton);
            this.Controls.Add(this.NNLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "NewNN";
            this.Text = "Создать новый Никнейм";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label NNLabel;
        private System.Windows.Forms.Button NewNNButton;
        private System.Windows.Forms.TextBox NewResultTB;
        private System.Windows.Forms.Button CopyExistButton;
        private System.Windows.Forms.Button BackExistButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton NewNN3algoRB;
        private System.Windows.Forms.RadioButton NewNN2algoRB;
        private System.Windows.Forms.RadioButton NewNN1algoRB;
    }
}