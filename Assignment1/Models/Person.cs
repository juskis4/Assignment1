using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(20)]
    public string HairColor { get; set; }
    [Required, MaxLength(20)]
    public string EyeColor { get; set; }
    [Required, Range(1, 140, ErrorMessage = "Please enter a valid Age number")]
    public int Age { get; set; }
    [Required, Range(1,400, ErrorMessage = "Please enter a valid Weight number in kilograms")]
    public float Weight { get; set; }
    [Required, Range(10,300, ErrorMessage = "Please enter a valid Height number in centimeters")]
    public int Height { get; set; }
    [Required]
    public string Sex { get; set; }
    
}


}