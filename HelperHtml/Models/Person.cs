using System.ComponentModel.DataAnnotations;

namespace HelperHtml.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name ="نام")]
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? Description { get; set; }
        public bool Gender { get; set; }
    }
}
