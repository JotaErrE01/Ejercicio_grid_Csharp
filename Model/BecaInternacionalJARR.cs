using System;

namespace Model{
    public class BecaInternacional : Beca {

        private string pais;

        DateTime fechaViajeIda;

        public string Pais { get => pais; set => pais = value; }

        public DateTime FechaViajeIda { get => fechaViajeIda; set => fechaViajeIda = value; }

        public BecaInternacional(string nombre, string cedula, string pais, string universidad, double monto, int tiempoEstudio, DateTime fechaViajeIda, string ruta) : base(nombre, cedula, universidad, monto, tiempoEstudio, ruta){
            this.pais = pais;
            this.fechaViajeIda = fechaViajeIda;
        }

        public override string ToString(){
            return $"{base.ToString()}\r\nPais: {pais}\r\nFecha de viaje de Ida: {FechaViajeIda.ToShortDateString()}\r\n";
        }

        public override string Conferencia(){
            return base.Conferencia() + $" en {pais}";
        }

        public string Mensaje(){
            return $"{Nombre} tiene una beca nacional\n";
        }
    }
}