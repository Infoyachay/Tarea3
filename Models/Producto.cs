namespace Tarea3Brandon.Models
{
    public class Producto
    {
        public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
