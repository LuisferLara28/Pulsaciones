using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository; 
        public void CalcularPulsacion(Persona persona)
        {
            if (persona.Sexo.Equals("M") || persona.Sexo.Equals("m"))
            {
                persona.Pulsaciones = (210 - persona.Edad) / 10;
                Console.WriteLine($"El señor {persona.Nombre} de {persona.Edad} años de edad tiene {persona.Pulsaciones} pulsaciones. ");
            }
            else
            {
                persona.Pulsaciones = (220 - persona.Edad) / 10;
                Console.WriteLine($"La chica {persona.Nombre} de {persona.Edad} años de edad tiene {persona.Pulsaciones} pulsaciones. ");
            }
        }

        public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }
        public List<Persona> Consultar()
        {
            return personaRepository.Consultar();
        }

        public Persona Buscar(string identificacion)
        {
            return personaRepository.Buscar(identificacion);
        }

        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
    }
}
