using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizze")]
    public class Pizza
    {
        [Key]   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int Price { get; set; }

        public Pizza(int id, string name, string description, string img, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Img = img;
            Price = price;
        }
    }
}