using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektFormsy
{
    class CustomPersona : Persona
    {
        public CustomPersona(int ID, int Level, string Name) : base(ID, Level, Name)
        {

        }

        public CustomPersona(Persona persona) : this(persona.GetID(), persona.GetLevel() , persona.GetName())
        {

        }

        class CustomPersonaBuilder : PersonaBuilder
        {
            public CustomPersonaBuilder(int ID) : base(ID)
            {

            }

            public new CustomPersona Build()
            {
                return new CustomPersona(base.Build());
            }
        }
    }
}
