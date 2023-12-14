namespace CentroPokemon.Models
{
    public class DetallePokemonViewModel
    {
        public Pokemon Pokemon { get; set; }
        public IEnumerable<Pokemon> Evoluciones { get; set; }
        public IEnumerable<Pokemon> Involuciones { get; set; }
        public IEnumerable<Movimiento> Movimientos { get; set; }
    }
}