namespace GarageMVC.Models
{
    public class Garage
    {
        public int numeroGaraje { get; set; }
        public string descripcion { get; set; }
        public int capacidadEspacios { get; set; }
        public int espaciosOcupados { get; set; }

        // Atributo para almacenar la lista de autos
        private List<Auto> autos;

        // Constructor para inicializar
        public Garage(int numeroGaraje, string descripcion, int capacidadEspacios)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            espaciosOcupados = 0; // Inicia en 0
            autos = new List<Auto>(); // Inicializa la lista vacía
        }

        // 4. Método para ingresar un auto a la lista
        public void ingresarAuto(Auto auto)
        {
            if (espaciosOcupados < capacidadEspacios)
            {
                autos.Add(auto);
                espaciosOcupados++; // Incrementamos los espacios ocupados
            }
        }

        // 5. Método para retornar la lista de autos
        public List<Auto> GetAutos()
        {
            return autos;
        }

        // Método extra para que funcione el código de la vista
        public string getDescripcion()
        {
            return descripcion;
        }
    }
}