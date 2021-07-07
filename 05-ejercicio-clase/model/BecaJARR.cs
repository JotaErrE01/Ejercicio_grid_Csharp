namespace _05_ejercicio_clase{
    class Beca{
        private string cedula;
        private string nombre;
        private string universidad;
        private double monto;
        private int tiempoEstudio;

        public Beca(string nombre, string cedula, string universidad, double monto, int tiempoEstudio){
            this.cedula = cedula;
            this.nombre = nombre;
            this.universidad = universidad;
            this.monto = monto;
            this.tiempoEstudio = tiempoEstudio;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public double Monto { get => monto; set => monto = value; }
        public int TiempoEstudio { get => tiempoEstudio; set => tiempoEstudio = value; }

        public double MontoPago(int partes) {
            // double x = 0.0;
            
            return Monto / partes;
        }

        public double TiempoRestante(int tiempo){
            return tiempoEstudio - tiempo;
        }

        public override string ToString(){
            return "\nCedula: " + cedula + "\r\nNombre: " + nombre + "\r\nUniversidad: " + universidad + "\r\nMonto: " + monto + "\r\nTiempo de estudio: " + tiempoEstudio;
        }

        public virtual string Conferencia () {
            return nombre + " asiste a algunas conferencias en " + universidad;
        }
    }
}