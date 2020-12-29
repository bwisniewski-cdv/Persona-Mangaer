using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ProjektFormsy
{
    public partial class FormMenu : Form
    {
        //Pola
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form CurrentChildForm;

        public FormMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Struktury
        private struct RGBColors
        {
            public static Color color = Color.FromArgb(224, 207, 213);
        }


        //Metody
        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(86, 0, 1);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Border przycisków po lewej
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Aktualny ikona - Child
                CurrentIconChild.IconChar = currentBtn.IconChar;
                CurrentIconChild.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(200, 0, 2);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(CurrentChildForm != null)
            {
                //Otwiera tylko forma
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCurrent.Controls.Add(childForm);
            panelCurrent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            HomeTextLabel.Text = childForm.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new Formsy.Create());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new Formsy.Edit());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new Formsy.Remove());
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new Formsy.List());
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color);
            OpenChildForm(new Formsy.Settings());
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new Formsy.Start());
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible=false;
            CurrentIconChild.IconChar = IconChar.Home;
            CurrentIconChild.IconColor = Color.White;
            HomeTextLabel.Text = "Home";
        }

        //Przeciaganie TitleBarem
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Formsy.Start());
        }
    }
}
