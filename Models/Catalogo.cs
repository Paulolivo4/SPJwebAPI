using System.ComponentModel.DataAnnotations;

namespace SPJ_ProyectoMVC.Models
{
    public class Catalogo
    {
        public int CatalogoId { get; set; }

        [Required, StringLength(100)]
        public string Marca { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Modelo { get; set; }

        public bool Usado { get; set; }

        [Range(5000.00, 50000.00)]
        public decimal Precio { get; set; }

        [Range(0, 100)]
        public decimal IVA => Precio * 0.16M; // Ejemplo de cálculo automático

        [StringLength(255)]
        public string? ImagePath { get; set; }
    }



}
    

