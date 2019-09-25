using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Passwords.Api.Entities
{
    public class Account
    {
        public Account()
        {
            Contents = new List<Content>();
        }

        public int AccountId { get; set; }
        [Required(ErrorMessage = "Service is required")]
        public string Service { get; set; }
        public ICollection<Content> Contents { get; set; }
    }

    public class Content
    {
        public int ContentId { get; set; }
        [Required(ErrorMessage = "Login is required")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Observacao { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
