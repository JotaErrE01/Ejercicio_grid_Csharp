namespace _05_ejercicio_clase{
    class BecaNacional : Beca {

        private string ciudad;

        public string Ciudad { get => ciudad; set => ciudad = value; }

        public BecaNacional(): base("000000", "S/N", "Universidad de Guayaquil", 100, 10){
            Ciudad = "Guayaquil";
        }

        public BecaNacional(string ciudad, string cedula, string nombre, string universidad, double monto, int tiempoEstudio) : base(cedula, nombre, universidad, monto, tiempoEstudio){
            this.Ciudad = ciudad;
        }

        public override string ToString(){
            return base.ToString() + "\nCiudad: " + Ciudad;
        }

        public string Mensaje(){
            return $"{Nombre} tiene una beca nacional\n";
        }
    }
}