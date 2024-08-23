using System.ComponentModel.DataAnnotations;

namespace Proiect_Gozu_Victor.DTO
{
    public class StudentToCreateDTO
    {
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Range(2, int.MaxValue)]
        public int Age { get; set; }
        public int? AddressId { get; set; }
    }
}
