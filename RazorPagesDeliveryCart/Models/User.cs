using System.ComponentModel.DataAnnotations;

namespace RazorPagesDeliveryCart.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        private string Password { get; set;} = string.Empty;

    }
}