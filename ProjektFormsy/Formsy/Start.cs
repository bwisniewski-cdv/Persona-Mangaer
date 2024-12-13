using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy.Formsy
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            alphaBlendTextBox1.ReadOnly = true;

        }



        private void WikiLink_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("https://megamitensei.fandom.com/wiki/Persona_5_Royal");
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
