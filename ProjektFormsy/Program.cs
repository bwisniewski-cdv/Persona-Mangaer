using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFormsy
{
    static class Program
    {
        static PersonaService personaService = new PersonaService();
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());

            Persona newPersona = new Persona.PersonaBuilder(1).SetLevel(1).SetName("Kapsel").Build();
            personaService.CreatePersona(newPersona);

            foreach (var item in personaService.GetAllPersonas())
            {
                Console.WriteLine(item.GetID());
                Console.WriteLine(item.GetLevel());
                Console.WriteLine(item.GetName());
            }
        }
    }
}
