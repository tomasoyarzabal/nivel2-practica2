using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    class Perro
    {
        private string color;
        private string raza;
        private int edad;
        private string tamaño;


        public string getColor()
        {
            return Color;
        }
        public string Color { get; set; }
        public string getRaza()
        {
            return raza;
        }
        public void setRaza(string razaa)
        {
            raza = razaa;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int e)
        {
            edad = e;
        }
        public string gettamaño()
        {
            return tamaño;
        }
        public void settamaño(string tamaño)
        {
            tamaño = tamaño;
        }
        
    }
}
