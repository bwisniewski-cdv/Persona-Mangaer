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
            if (ValidateInputs())
            {
                int level = Convert.ToInt32(textLevel.Text);
                string name = textName.Text;
                string trait = comboBoxTrait.Text;
                int strength = Convert.ToInt32(textBoxStrength.Text);
                int magic = Convert.ToInt32(textBoxMagic.Text);
                int endurance = Convert.ToInt32(textBoxEndurance.Text);
                int agility = Convert.ToInt32(textBoxAgility.Text);
                int luck = Convert.ToInt32(textBoxLuck.Text);

                CustomPersona newPersona = new CustomPersona.CustomPersonaBuilder()
                    .SetLevel(level)
                    .SetName(name)
                    .SetTrait(trait)
                    .SetStrength(strength)
                    .SetMagic(magic)
                    .SetEndurance(endurance)
                    .SetAgility(agility)
                    .SetLuck(luck)
                    .Build();

                personaService.CreatePersona(newPersona);
                MessageBox.Show("Persona created successfully!");
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            if (!int.TryParse(textLevel.Text, out int level) || level < 1 || level > 99)
            {
                MessageBox.Show("Level must be a number between 1 and 99.");
                return false;
            }

            if (!int.TryParse(textBoxStrength.Text, out int strength) || strength < 0 || strength > 99 ||
                !int.TryParse(textBoxMagic.Text, out int magic) || magic < 0 || magic > 99 ||
                !int.TryParse(textBoxEndurance.Text, out int endurance) || endurance < 0 || endurance > 99 ||
                !int.TryParse(textBoxAgility.Text, out int agility) || agility < 0 || agility > 99 ||
                !int.TryParse(textBoxLuck.Text, out int luck) || luck < 0 || luck > 99)
            {
                MessageBox.Show("Stats must be numbers between 0 and 99.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxTrait.Text))
            {
                MessageBox.Show("Trait must be selected.");
                return false;
            }

            return true;
        }
        
    }
}
