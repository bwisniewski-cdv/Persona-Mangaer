namespace ProjektFormsy
{
    partial class FormMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.ListButton = new FontAwesome.Sharp.IconButton();
            this.RemoveButton = new FontAwesome.Sharp.IconButton();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.CreateButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.HomeTextLabel = new System.Windows.Forms.Label();
            this.CurrentIconChild = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelCurrent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIconChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.panelMenu.Controls.Add(this.SettingsButton);
            this.panelMenu.Controls.Add(this.ListButton);
            this.panelMenu.Controls.Add(this.RemoveButton);
            this.panelMenu.Controls.Add(this.EditButton);
            this.panelMenu.Controls.Add(this.CreateButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 704);
            this.panelMenu.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.SettingsButton.IconColor = System.Drawing.Color.White;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 340);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsButton.Size = new System.Drawing.Size(220, 60);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListButton.FlatAppearance.BorderSize = 0;
            this.ListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListButton.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.ListButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ListButton.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.ListButton.IconColor = System.Drawing.Color.White;
            this.ListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListButton.Location = new System.Drawing.Point(0, 280);
            this.ListButton.Name = "ListButton";
            this.ListButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ListButton.Size = new System.Drawing.Size(220, 60);
            this.ListButton.TabIndex = 5;
            this.ListButton.Text = "View the current list of Persona\'s";
            this.ListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.RemoveButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RemoveButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.RemoveButton.IconColor = System.Drawing.Color.White;
            this.RemoveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(0, 220);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RemoveButton.Size = new System.Drawing.Size(220, 60);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove Custom Persona";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.EditButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditButton.IconColor = System.Drawing.Color.White;
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(0, 160);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EditButton.Size = new System.Drawing.Size(220, 60);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Custom Persona";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreateButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.CreateButton.IconColor = System.Drawing.Color.White;
            this.CreateButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CreateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateButton.Location = new System.Drawing.Point(0, 100);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CreateButton.Size = new System.Drawing.Size(220, 60);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create New Persona";
            this.CreateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HomeButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButton.Image = global::ProjektFormsy.Properties.Resources.R_Logo1;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(220, 100);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeButton.TabIndex = 0;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panelTitleBar.Controls.Add(this.MinimizeButton);
            this.panelTitleBar.Controls.Add(this.MaximizeButton);
            this.panelTitleBar.Controls.Add(this.ExitButton);
            this.panelTitleBar.Controls.Add(this.HomeTextLabel);
            this.panelTitleBar.Controls.Add(this.CurrentIconChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1044, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.Color.Red;
            this.MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeButton.IconSize = 25;
            this.MinimizeButton.Location = new System.Drawing.Point(966, 3);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.Color.Red;
            this.MaximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeButton.IconSize = 25;
            this.MaximizeButton.Location = new System.Drawing.Point(991, 3);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(25, 25);
            this.MaximizeButton.TabIndex = 3;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ExitButton.IconColor = System.Drawing.Color.Red;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 25;
            this.ExitButton.Location = new System.Drawing.Point(1016, 3);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomeTextLabel
            // 
            this.HomeTextLabel.AutoSize = true;
            this.HomeTextLabel.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.HomeTextLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeTextLabel.Location = new System.Drawing.Point(49, 33);
            this.HomeTextLabel.Name = "HomeTextLabel";
            this.HomeTextLabel.Size = new System.Drawing.Size(36, 13);
            this.HomeTextLabel.TabIndex = 1;
            this.HomeTextLabel.Text = "Home";
            // 
            // CurrentIconChild
            // 
            this.CurrentIconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.CurrentIconChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentIconChild.IconColor = System.Drawing.Color.White;
            this.CurrentIconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CurrentIconChild.Location = new System.Drawing.Point(10, 24);
            this.CurrentIconChild.Name = "CurrentIconChild";
            this.CurrentIconChild.Size = new System.Drawing.Size(32, 32);
            this.CurrentIconChild.TabIndex = 0;
            this.CurrentIconChild.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1044, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelCurrent
            // 
            this.panelCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panelCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrent.Location = new System.Drawing.Point(220, 85);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(1044, 619);
            this.panelCurrent.TabIndex = 3;
            // 
            // FormMenu
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 704);
            this.ControlBox = false;
            this.Controls.Add(this.panelCurrent);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIconChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ListButton;
        private FontAwesome.Sharp.IconButton RemoveButton;
        private FontAwesome.Sharp.IconButton EditButton;
        private FontAwesome.Sharp.IconButton CreateButton;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label HomeTextLabel;
        private FontAwesome.Sharp.IconPictureBox CurrentIconChild;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelCurrent;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton ExitButton;
    }
}

