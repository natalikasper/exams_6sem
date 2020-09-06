using System.ComponentModel.DataAnnotations;

namespace entity_VALIDATION.ViewModel
{
    public class PlanViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
       [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Regular { get; set; }
        [CheckType(new string[] { "User", "Admin" }, ErrorMessage = "Invalid type")]
        public string Data { get; set; }
    }
}
