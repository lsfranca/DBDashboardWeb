using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Customer
    {
        [Required, StringLength(25)]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}