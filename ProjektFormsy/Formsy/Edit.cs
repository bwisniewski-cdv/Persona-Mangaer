using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy.Formsy
{
    public partial class Edit : Form
    {
        private int ID;
        private PersonaService personaService = PersonaService.GetInstance();
        public Edit(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            MessageBox.Show(ID.ToString());
            Persona persona = personaService.GetPersona(ID);
            this.textLevel.Text = persona.GetLevel().ToString();
            this.textName.Text = persona.GetName();
            this.comboBoxTrait.Text = persona.GetTrait();
            this.textBoxStrength.Text = persona.GetStrength().ToString();
            this.textBoxMagic.Text = persona.GetMagic().ToString();
            this.textBoxEndurance.Text = persona.GetEndurance().ToString();
            this.textBoxAgility.Text = persona.GetAgility().ToString();
            this.textBoxLuck.Text = persona.GetLuck().ToString();
            if (!(persona is CustomPersona))
            {
                textLevel.ReadOnly = true;
                textName.ReadOnly = true;
                comboBoxTrait.Enabled = false;
                textBoxStrength.ReadOnly = true;
                textBoxMagic.ReadOnly = true;
                textBoxEndurance.ReadOnly = true;
                textBoxAgility.ReadOnly = true;
                textBoxLuck.ReadOnly = true;
                buttonEdit.Visible = false;
            }
            
        }
        private void buttonClick(object sender, System.EventArgs e)
        {
            /*
            int level = Convert.ToInt32(textLevel.Text);
            string name = textName.Text;
            Persona newPersona = new Persona.PersonaBuilder().SetID(ID).SetLevel(level).SetName(name).Build();
            personaService.EditPersona(CustomPersona.CustomPersonaBuilder(ID, level, name));
            string editLevel = Persona.GetLevel().ToString();*/
            int level = Convert.ToInt32(textLevel.Text);
            string name = textName.Text;
            string trait = comboBoxTrait.Text;
            int strength = Convert.ToInt32(textBoxStrength.Text);
            int magic = Convert.ToInt32(textBoxMagic.Text);
            int endurance = Convert.ToInt32(textBoxEndurance.Text);
            int agility = Convert.ToInt32(textBoxAgility.Text);
            int luck = Convert.ToInt32(textBoxLuck.Text);
            
            CustomPersona newPersona = new CustomPersona.CustomPersonaBuilder().SetID(ID).SetLevel(level).SetName(name).SetTrait(trait).SetStrength(strength).SetMagic(magic).SetEndurance(endurance).SetAgility(agility).SetLuck(luck).Build();
            personaService.EditPersona(newPersona);
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to cancel this edit?",
                "Are you sure?",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
