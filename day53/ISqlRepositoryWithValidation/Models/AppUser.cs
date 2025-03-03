using System.ComponentModel.DataAnnotations;

namespace ISqlRepositoryWithValidation.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Server says username is requried")]
        //[StringLength(5, ErrorMessage = "server says Maximum lenght is only 20 ")]
        public string UserName { get; set; }

        //[Display(Name = "Password")]
        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Server says password is requried")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Server says password is requried")]
        public string UserEmail { get; set; }


    }
}
