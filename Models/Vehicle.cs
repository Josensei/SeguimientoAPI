namespace SeguimientoAPI.Models
{
    public class Vehicle
    {   
        public long Id { get; set; }
        public string? Driver { get; set; }
        public string? gps{ get; set; }

        public Pedido? Pedido { get; set; } 

        //public string? coordenadas{ get; set; }
    }
}
