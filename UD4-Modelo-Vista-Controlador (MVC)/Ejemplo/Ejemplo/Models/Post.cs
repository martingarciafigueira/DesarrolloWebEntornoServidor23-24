namespace Ejemplo.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
        public string Autor { get; set; }
        public bool EsPublicado { get; set; }
    }
}
