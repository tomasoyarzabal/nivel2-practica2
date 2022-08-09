using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    class Vehiculo
    {
        //vehiculo: auto, auto importdado, auto de calle.
        // camioneta
        // moto

        private string ruedas;
        private string motor;
        private string amortiguadores;
        private int consumoEnLitros;
        private string color;

        public int getConsumoEnLitros
        {
            get { return consumoEnLitros; }
        }
        public void setConsumoEnLitros(int consumo) 
        {
            consumoEnLitros = consumo;
        }
        public string Color { get; set; }
    }
}
