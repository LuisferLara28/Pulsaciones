using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";
        Persona persona = new Persona();
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{persona.Identificacion}; {persona.Nombre}; {persona.Sexo}; {persona.Edad}; {persona.Pulsaciones}");
            escritor.Close();
            file.Close();
        }
        public List<Persona> Personas = new List<Persona>();


        public List<Persona> Consultar()
        {
            FileStream SourceStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(SourceStream);

            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Persona persona = Map(linea);

                Personas.Add(persona);
            }

            linea = reader.ReadLine();
            reader.Close();
            SourceStream.Close();

            return Personas;
        }

        private static Persona Map(string linea)
        {
            char delimiter = ';';
            string[] DatosPersona = linea.Split(delimiter);

            Persona persona = new Persona();
            persona.Identificacion = DatosPersona[0];
            persona.Nombre = DatosPersona[1];
            persona.Edad = Convert.ToInt32(DatosPersona[2]);
            persona.Sexo = DatosPersona[3];
            persona.Pulsaciones = Convert.ToInt32(DatosPersona[4]);
            return persona;
        }

        public Persona Buscar(string identificacion)
        {
            foreach (var item in Personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
