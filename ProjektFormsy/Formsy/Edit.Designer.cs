using System;

namespace ProjektFormsy.Formsy
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.labelTrait = new System.Windows.Forms.Label();
            this.comboBoxTrait = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLuck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgility = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEndurance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStrength = new System.Windows.Forms.TextBox();
            this.textBoxMagic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(866, 522);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 46);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Confirm Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonClick);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(8, 18);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "Level";
            // 
            // textLevel
            // 
            this.textLevel.Location = new System.Drawing.Point(11, 34);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(100, 20);
            this.textLevel.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(11, 100);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 10;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(11, 522);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 46);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // labelTrait
            // 
            this.labelTrait.AutoSize = true;
            this.labelTrait.Location = new System.Drawing.Point(199, 49);
            this.labelTrait.Name = "labelTrait";
            this.labelTrait.Size = new System.Drawing.Size(28, 13);
            this.labelTrait.TabIndex = 17;
            this.labelTrait.Text = "Trait";
            // 
            // comboBoxTrait
            // 
            this.comboBoxTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrait.FormattingEnabled = true;
            this.comboBoxTrait.Items.AddRange(new object[] { "Fool", "Magician", "Lovers", "Chariot", "Death", "Hermit" });
            this.comboBoxTrait.Location = new System.Drawing.Point(202, 64);
            this.comboBoxTrait.Name = "comboBoxTrait";
            this.comboBoxTrait.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrait.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textLevel);
            this.groupBox1.Controls.Add(this.comboBoxTrait);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.labelTrait);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelLevel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxLuck);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxAgility);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxEndurance);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxStrength);
            this.groupBox2.Controls.Add(this.textBoxMagic);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelStrength);
            this.groupBox2.Location = new System.Drawing.Point(11, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 200);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // textBoxLuck
            // 
            this.textBoxLuck.Location = new System.Drawing.Point(223, 128);
            this.textBoxLuck.Name = "textBoxLuck";
            this.textBoxLuck.Size = new System.Drawing.Size(100, 20);
            this.textBoxLuck.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Luck";
            // 
            // textBoxAgility
            // 
            this.textBoxAgility.Location = new System.Drawing.Point(223, 60);
            this.textBoxAgility.Name = "textBoxAgility";
            this.textBoxAgility.Size = new System.Drawing.Size(100, 20);
            this.textBoxAgility.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Agility";
            // 
            // textBoxEndurance
            // 
            this.textBoxEndurance.Location = new System.Drawing.Point(11, 164);
            this.textBoxEndurance.Name = "textBoxEndurance";
            this.textBoxEndurance.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndurance.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endurance";
            // 
            // textBoxStrength
            // 
            this.textBoxStrength.Location = new System.Drawing.Point(11, 34);
            this.textBoxStrength.Name = "textBoxStrength";
            this.textBoxStrength.Size = new System.Drawing.Size(100, 20);
            this.textBoxStrength.TabIndex = 12;
            // 
            // textBoxMagic
            // 
            this.textBoxMagic.Location = new System.Drawing.Point(11, 96);
            this.textBoxMagic.Name = "textBoxMagic";
            this.textBoxMagic.Size = new System.Drawing.Size(100, 20);
            this.textBoxMagic.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Magic";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(8, 18);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 13;
            this.labelStrength.Text = "Strength";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BackgroundImage = global::ProjektFormsy.Properties.Resources.Protagonisci;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1028, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.buttonEdit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "Edit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label labelTrait;
        private System.Windows.Forms.ComboBox comboBoxTrait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStrength;
        private System.Windows.Forms.TextBox textBoxMagic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.TextBox textBoxLuck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAgility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEndurance;
        private System.Windows.Forms.Label label1;
    }
}