namespace SeguimientoAPI.Models
{
    public class Vehicle
    {   
        public long Id { get; set; }
        public string? Driver { get; set; }
        public string? gps{ get; set; }
        public List<Pedido>? Pedidos { get; set; } = new List<Pedido>();


        //public string? coordenadas{ get; set; }
    }
}
