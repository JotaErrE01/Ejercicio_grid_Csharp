using System;

namespace _05_ejercicio_clase{
    class BecaInternacional : Beca {

        private string pais;

        DateTime fechaViajeIda;

        public string Pais { get => pais; set => pais = value; }

        public DateTime FechaViajeIda { get => fechaViajeIda; set => fechaViajeIda = value; }

        public BecaInternacional(string nombre, string cedula, string pais, string universidad, double monto, int tiempoEstudio, DateTime fechaViajeIda) : base(nombre, cedula, universidad, monto, tiempoEstudio){
            this.pais = pais;
            this.fechaViajeIda = fechaViajeIda;
        }

        public override string ToString(){
            return base.ToString() + $"\r\nPais: {pais}\r\nFecha de viaje de Ida: {FechaViajeIda.ToShortDateString()}";
        }

        public override string Conferencia(){
            return base.Conferencia() + $" en {pais}";
        }

        public string Mensaje(){
            return $"{Nombre} tiene una beca nacional\n";
        }
    }
}