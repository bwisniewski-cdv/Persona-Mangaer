namespace ProjektFormsy.Formsy
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.WikiLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WikiLink
            // 
            this.WikiLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WikiLink.AutoSize = true;
            this.WikiLink.BackColor = System.Drawing.Color.Transparent;
            this.WikiLink.LinkColor = System.Drawing.Color.White;
            this.WikiLink.Location = new System.Drawing.Point(395, 545);
            this.WikiLink.Name = "WikiLink";
            this.WikiLink.Size = new System.Drawing.Size(260, 26);
            this.WikiLink.TabIndex = 6;
            this.WikiLink.TabStop = true;
            this.WikiLink.Text = "Click here for more information about Persona 5 Royal\r\n[Spoiler Warning!]";
            this.WikiLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WikiLink.Click += new System.EventHandler(this.WikiLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjektFormsy.Properties.Resources.p5r_logo;
            this.pictureBox1.Location = new System.Drawing.Point(177, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // alphaBlendTextBox1
            // 
            this.alphaBlendTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alphaBlendTextBox1.BackAlpha = 0;
            this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox1.Font = new System.Drawing.Font("Bebas Neue Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alphaBlendTextBox1.ForeColor = System.Drawing.Color.White;
            this.alphaBlendTextBox1.Location = new System.Drawing.Point(177, 144);
            this.alphaBlendTextBox1.Multiline = true;
            this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
            this.alphaBlendTextBox1.Size = new System.Drawing.Size(675, 268);
            this.alphaBlendTextBox1.TabIndex = 7;
            this.alphaBlendTextBox1.Text = resources.GetString("alphaBlendTextBox1.Text");
            this.alphaBlendTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BackgroundImage = global::ProjektFormsy.Properties.Resources.Protagonisci;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1028, 580);
            this.Controls.Add(this.alphaBlendTextBox1);
            this.Controls.Add(this.WikiLink);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel WikiLink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
    }
}