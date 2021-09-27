using System.ComponentModel.DataAnnotations;
using hogwartsApi.Domain.Models;

namespace hogwartsApi.Resources
{
    public class SaveApplicationResource
    {
        [Required]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid numbers")]
        [Range(0, 9999999999, ErrorMessage = "The identification must have a maximum of 10 digits")]
        public long Identification { get; set; }


        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid numbers")]
        [Range(1, 99, ErrorMessage = "The age must have a maximum of 2 digits")]
        public int Age { get; set; }

        [Required]
        [EnumDataType(typeof(EHouse), ErrorMessage = "Must select a valid house")]
        public EHouse House { get; set; }
    }
}
