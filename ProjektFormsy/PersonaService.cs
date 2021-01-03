using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjektFormsy
{
    class PersonaService
    {
        private readonly List<Persona> personas = new List<Persona>();

        private static PersonaService Instance = null;

        private int id = 1;

        private PersonaService()
        {
        }


        public void CreatePersona(Persona persona)
        {
            personas.Add(persona);
        }

        public bool EditPersona(CustomPersona persona)
        {
            Persona found = personas.Find(p => p.GetID() == persona.GetID());
            if (found is CustomPersona)
            {
                personas[personas.IndexOf(found)] = persona;
                return true;
            }

            return false;
        }

        public bool DeletePersona(CustomPersona persona)
        {
            Persona found = personas.Find(p => p.GetID() == persona.GetID());
            if (found is CustomPersona)
            {
                personas.Remove(persona);
                return true;
            }

            return false;
        }

        public List<Persona> GetAllPersonas()
        {
            return new List<Persona>(personas);
        }

        public static PersonaService GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PersonaService();
            }

            return Instance;
        }

        public Persona GetPersona(int ID)
        {
            return personas.Find(p => p.GetID() == ID);
        }

        public bool DeletePersona(int ID)
        {
            Persona found = personas.Find(p => p.GetID() == ID);
            if (found is CustomPersona)
            {
                personas.Remove(found);
                return true;
            }

            MessageBox.Show("You cannot delete that Persona");
            return false;
        }
    }
}