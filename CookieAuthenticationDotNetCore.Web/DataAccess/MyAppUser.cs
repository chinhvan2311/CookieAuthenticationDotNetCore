using System.ComponentModel.DataAnnotations.Schema;

namespace CookieAuthenticationDotNetCore.Web.DataAccess
{
    [Table("MyAppUsers")]
    public class MyAppUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
