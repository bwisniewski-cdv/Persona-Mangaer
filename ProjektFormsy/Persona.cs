using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektFormsy
{
    class Persona
    {
        private int ID { get; }
        private  int Level { get; }
        private string Name { get; }

        public class PersonaBuilder
        {
            private int ID;
            private int Level;
            private string Name;

            public PersonaBuilder(int ID)
            {
                this.ID = ID;
            }

            public PersonaBuilder SetLevel(int Level)
            {
                this.Level = Level;
                return this;
            }

            public PersonaBuilder SetName(string Name)
            {
                this.Name = Name;
                return this;
            }

            public Persona Build()
            {
                return new Persona(this.ID, this.Level, this.Name);
            }
        }

        public Persona(int ID, int Level, string Name)
        {
            this.ID = ID;
            this.Level = Level;
            this.Name = Name;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetLevel()
        {
            return Level;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
