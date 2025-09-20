namespace GarageMVC.Models
{
    public class Auto
    {
        public int numeroAuto { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }

        // Constructor para inicializar los atributos
        public Auto(int numeroAuto, string marca, string placa)
        {
            this.numeroAuto = numeroAuto;
            this.marca = marca;
            this.placa = placa;
        }
    }
}