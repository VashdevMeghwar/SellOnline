using System.ComponentModel.DataAnnotations;

namespace SellOnline.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }
    public class ProductMetaData
    {
        [Display(Name = "Product Name")]
        public string Name;
    }
}