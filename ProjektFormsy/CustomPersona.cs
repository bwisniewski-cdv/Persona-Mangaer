using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektFormsy
{
    class CustomPersona : Persona
    {
        public CustomPersona(int ID, int Level, string Name, string Trait, int Strength, int Magic, int Endurance,
            int Agility, int Luck) : base(ID, Level, Name, Trait, Strength, Magic, Endurance, Agility, Luck)
        {
        }

        public CustomPersona(Persona persona) : this(persona.GetID(), persona.GetLevel(), persona.GetName(),
            persona.GetTrait(), persona.GetStrength(), persona.GetMagic(), persona.GetEndurance(), persona.GetAgility(),
            persona.GetLuck())
        {
        }

        public class CustomPersonaBuilder : PersonaBuilder
        {
            public new CustomPersonaBuilder SetID(int ID)
            {
                return (CustomPersonaBuilder) base.SetID(ID);
            }

            public new CustomPersonaBuilder SetLevel(int Level)
            {
                return (CustomPersonaBuilder) base.SetLevel(Level);
            }

            public new CustomPersonaBuilder SetName(string Name)
            {
                return (CustomPersonaBuilder) base.SetName(Name);
            }

            public new CustomPersonaBuilder SetTrait(string Trait)
            {
                return (CustomPersonaBuilder) base.SetTrait(Trait);
            }

            public new CustomPersonaBuilder SetStrength(int Strength)
            {
                return (CustomPersonaBuilder) base.SetStrength(Strength);
            }

            public new CustomPersonaBuilder SetMagic(int Magic)
            {
                return (CustomPersonaBuilder) base.SetMagic(Magic);
            }

            public new CustomPersonaBuilder SetEndurance(int Endurance)
            {
                return (CustomPersonaBuilder) base.SetEndurance(Endurance);
            }

            public new CustomPersonaBuilder SetAgility(int Agility)
            {
                return (CustomPersonaBuilder) base.SetAgility(Agility);
            }

            public new CustomPersonaBuilder SetLuck(int Luck)
            {
                return (CustomPersonaBuilder) base.SetLuck(Luck);
            }

            public new CustomPersona Build()
            {
                return new CustomPersona(base.Build());
            }
        }
    }
}