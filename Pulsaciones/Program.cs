using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;

namespace Pulsaciones1231
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaService personaService = new PersonaService();
            Persona persona = new Persona();
            Console.WriteLine("*** Bienvenido al programa de calculo de pulsaciones ***");
            Console.WriteLine("Por favor digite su identificacion: ");
            persona.Identificacion = Console.ReadLine();
            Console.WriteLine("Por favor digite su nombre: ");
            persona.Nombre= Console.ReadLine();
            Console.WriteLine("Por favor digite su edad: ");
            persona.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor especifique su sexo (M/F): ");
            persona.Sexo = Console.ReadLine();
            personaService.CalcularPulsacion(persona);
            personaService.Guardar(persona);
            

            Console.ReadKey();

        }
    }
}
