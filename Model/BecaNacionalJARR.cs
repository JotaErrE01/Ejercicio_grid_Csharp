namespace Model{
    public class BecaNacional : Beca {

        private string ciudad;

        public string Ciudad { get => ciudad; set => ciudad = value; }

        //public BecaNacional(): base("000000", "S/N", "Universidad de Guayaquil", 100, 10){
        //    Ciudad = "Guayaquil";
        //}

        public BecaNacional(string nombre, string cedula, string ciudad, string universidad, double monto, int tiempoEstudio, string ruta) : base(nombre, cedula, universidad, monto, tiempoEstudio, ruta){
            this.Ciudad = ciudad;
        }

        public override string ToString(){
            return $"{ base.ToString() }\r\nCiudad: {ciudad}\r\n";
        }

        public string Mensaje(){
            return $"{Nombre} tiene una beca nacional\n";
        }
    }
}