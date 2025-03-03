using System.ComponentModel.DataAnnotations;

namespace ISqlRepositoryWithValidation.DTOs
{
    public class AppUserDTO
    {
        [Required(ErrorMessage = "Server says username is requried")]
        [StringLength(5, ErrorMessage = "server says Maximum lenght is only 5 ")]
        //  [ShouldContainRRDInName()]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Server says password is requried")]
        public string UserPassword { get; set; }
    }
}
