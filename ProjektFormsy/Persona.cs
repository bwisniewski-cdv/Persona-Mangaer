using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektFormsy
{
    class Persona
    {
        public int ID { get; }
        public int Level { get; }
        public string Name { get; }
        public string Trait { get; }
        public int Strength { get; }
        public int Magic { get; }
        public int Endurance { get; }
        public int Agility { get; }
        public int Luck { get; }
        private static int globalId = 1;


        public class PersonaBuilder
        {
            private int ID;
            private int Level;
            private string Name;
            private string Trait;
            private int Strength;
            private int Magic;
            private int Endurance;
            private int Agility;
            private int Luck;

            public PersonaBuilder SetID(int ID)
            {
                if (ID < 0)
                {
                    ID = 0;
                }

                this.ID = ID;
                return this;
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

            public PersonaBuilder SetTrait(string Trait)
            {
                this.Trait = Trait;
                return this;
            }

            public PersonaBuilder SetStrength(int Strength)
            {
                this.Strength = Strength;
                return this;
            }

            public PersonaBuilder SetMagic(int Magic)
            {
                this.Magic = Magic;
                return this;
            }

            public PersonaBuilder SetEndurance(int Endurance)
            {
                this.Endurance = Endurance;
                return this;
            }

            public PersonaBuilder SetAgility(int Agility)
            {
                this.Agility = Agility;
                return this;
            }

            public PersonaBuilder SetLuck(int Luck)
            {
                this.Luck = Luck;
                return this;
            }

            public Persona Build()
            {
                return new Persona(ID, this.Level, this.Name, this.Trait, this.Strength, this.Magic, this.Endurance,
                    this.Agility, this.Luck);
            }
        }

        public Persona(int ID, int Level, string Name, string Trait, int Strength, int Magic, int Endurance,
            int Agility, int Luck)
        {
            if (ID == 0)
            {
                ID = globalId++;
            }

            this.ID = ID;
            this.Level = Level;
            this.Name = Name;
            this.Trait = Trait;
            this.Strength = Strength;
            this.Magic = Magic;
            this.Endurance = Endurance;
            this.Agility = Agility;
            this.Luck = Luck;
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

        public string GetTrait()
        {
            return Trait;
        }

        public int GetStrength()
        {
            return Strength;
        }

        public int GetMagic()
        {
            return Magic;
        }

        public int GetEndurance()
        {
            return Endurance;
        }

        public int GetAgility()
        {
            return Agility;
        }

        public int GetLuck()
        {
            return Luck;
            ;
        }
    }
}