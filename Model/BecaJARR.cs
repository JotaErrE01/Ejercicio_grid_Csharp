namespace Model{
    public class Beca{

        private string ruta;
        private string cedula;
        private string nombre;
        private string universidad;
        private double monto;
        private int tiempoEstudio;

        public Beca(string nombre, string cedula, string universidad, double monto, int tiempoEstudio, string ruta){
            this.cedula = cedula;
            this.nombre = nombre;
            this.universidad = universidad;
            this.monto = monto;
            this.tiempoEstudio = tiempoEstudio;
            this.ruta = ruta;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public double Monto { get => monto; set => monto = value; }
        public int TiempoEstudio { get => tiempoEstudio; set => tiempoEstudio = value; }
        public string Ruta { get => ruta; set => ruta = value; }

        public double MontoPago(int partes) {
            // double x = 0.0;
            
            return Monto / partes;
        }

        public double TiempoRestante(int tiempo){
            return tiempoEstudio - tiempo;
        }

        public override string ToString(){
            return $"Cedula: {cedula}\r\nNombre: {nombre}\r\nUniversidad: {universidad}\r\nMonto: {monto}\r\r\nTiempo Estudio: {tiempoEstudio}\r\nRuta Imagen: {ruta}";
        }

        public virtual string Conferencia () {
            return nombre + " asiste a algunas conferencias en " + universidad;
        }
    }
}