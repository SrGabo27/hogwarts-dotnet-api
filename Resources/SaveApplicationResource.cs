using System.ComponentModel.DataAnnotations;
using hogwartsApi.Domain.Models;

namespace hogwartsApi.Resources
{
    public class SaveApplicationResource
    {
        /// <summary>
        /// The student name
        /// </summary>
        [Required]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// The student lastname 
        /// </summary>
        [Required]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        /// <summary>
        /// The student identification
        /// </summary>
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid numbers")]
        [Range(0, 9999999999, ErrorMessage = "The identification must have a maximum of 10 digits")]
        public long Identification { get; set; }


        /// <summary>
        /// The studen age 
        /// </summary>
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid numbers")]
        [Range(1, 99, ErrorMessage = "The age must have a maximum of 2 digits")]
        public int Age { get; set; }

        /// <summary>
        /// A hogwarts house
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string House { get; set; }
    }
}
