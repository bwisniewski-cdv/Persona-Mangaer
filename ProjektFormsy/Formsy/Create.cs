using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy.Formsy
{
    public partial class Create : Form
    {
        private PersonaService personaService = PersonaService.GetInstance();
        public Create()
        {
            InitializeComponent();
        }
        
        private void buttonClick(object sender, System.EventArgs e)
        {
            int level = Convert.ToInt32(textLevel.Text);
            string name = textName.Text;
            string trait = comboBoxTrait.Text;
            int strength = Convert.ToInt32(textBoxStrength.Text);
            int magic = Convert.ToInt32(textBoxMagic.Text);
            int endurance = Convert.ToInt32(textBoxEndurance.Text);
            int agility = Convert.ToInt32(textBoxAgility.Text);
            int luck = Convert.ToInt32(textBoxLuck.Text);
            
            CustomPersona newPersona = new CustomPersona.CustomPersonaBuilder().SetLevel(level).SetName(name).SetTrait(trait).SetStrength(strength).SetMagic(magic).SetEndurance(endurance).SetAgility(agility).SetLuck(luck).Build();
            personaService.CreatePersona(newPersona);
            MessageBox.Show("button was clicked");
        }
        
    }
}
