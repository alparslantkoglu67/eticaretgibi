using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product{
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Lütfen ürün adı giriniz.")]
        [Display(Name="Ürün Adı")]
        public string? Name { get; set; }
        [Range(0,100000,ErrorMessage ="Ürün fiyatı 0 ile 100000 arasında olmalıdır.")]
        [Required(ErrorMessage ="Lütfen ürün fiyatı giriniz.")]
        [Display(Name="Fiyat")]
        public decimal? Price { get; set; }
        [Display(Name="Resim")]
        public string? Image { get; set; }=string.Empty;
        [Required(ErrorMessage ="Lütfen ürün kategorisi giriniz.")]
        public bool IsActive { get; set; }
        [Display(Name="Kategori")]
        public int CategoryId { get; set; }

    }
}