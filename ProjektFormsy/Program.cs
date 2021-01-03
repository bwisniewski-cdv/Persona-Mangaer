using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy
{
    static class Program
    { 
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        private static PersonaService personaService = PersonaService.GetInstance();
        [STAThread]
        static void Main()
        {
            Persona newPersona = new Persona.PersonaBuilder().SetLevel(1).SetName("Arsene").SetTrait("Fool").SetStrength(2).SetMagic(2).SetEndurance(3).SetAgility(3).SetLuck(1).Build();
            Persona newPersona2 = new Persona.PersonaBuilder().SetLevel(2).SetName("Jack-o'-Lantern").SetTrait("Magician").SetStrength(2).SetMagic(3).SetEndurance(3).SetAgility(3).SetLuck(2).Build();
            Persona newPersona3 = new Persona.PersonaBuilder().SetLevel(2).SetName("Pixie").SetTrait("Lovers").SetStrength(1).SetMagic(3).SetEndurance(3).SetAgility(4).SetLuck(2).Build();
            Persona newPersona4 = new Persona.PersonaBuilder().SetLevel(3).SetName("Agathion").SetTrait("Chariot").SetStrength(3).SetMagic(4).SetEndurance(5).SetAgility(7).SetLuck(3).Build();
            Persona newPersona5 = new Persona.PersonaBuilder().SetLevel(3).SetName("Mandrake").SetTrait("Death").SetStrength(2).SetMagic(3).SetEndurance(3).SetAgility(4).SetLuck(4).Build();
            Persona newPersona6 = new Persona.PersonaBuilder().SetLevel(4).SetName("Bicorn").SetTrait("Hermit").SetStrength(5).SetMagic(3).SetEndurance(3).SetAgility(5).SetLuck(3).Build();
            personaService.CreatePersona(newPersona);
            personaService.CreatePersona(newPersona2);
            personaService.CreatePersona(newPersona3);
            personaService.CreatePersona(newPersona4);
            personaService.CreatePersona(newPersona5);
            personaService.CreatePersona(newPersona6);

            foreach (var item in personaService.GetAllPersonas())
            {
                Console.WriteLine(item.GetID());
                Console.WriteLine(item.GetLevel());
                Console.WriteLine(item.GetName());
                Console.WriteLine(item.GetTrait());
                Console.WriteLine(item.GetStrength());
                Console.WriteLine(item.GetMagic());
                Console.WriteLine(item.GetEndurance());
                Console.WriteLine(item.GetAgility());
                Console.WriteLine(item.GetLuck());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
}
