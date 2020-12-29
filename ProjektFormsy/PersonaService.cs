using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektFormsy
{
    class PersonaService
    {
        private readonly List<Persona> personas = new List<Persona>();

        public void CreatePersona(Persona persona)
        {
            personas.Add(persona);    
        }

        public bool EditPersona(CustomPersona persona)
        {
            Persona found = personas.Find(p => p.GetID() == persona.GetID());
            if (found is CustomPersona)
            {
                personas.Insert(personas.IndexOf(found), persona);
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
    }
}
