using System.ComponentModel.DataAnnotations;

namespace HelperTag.Models
{
    public class Person
    {
        [Display(Name ="شماره یکتا")]
        [Required(ErrorMessage = "فیلد شماره یکتا نمیتواند خالی باشد")]
        public required int Id { get; set; }


        [Display(Name = "نام")]
        [Required(ErrorMessage ="فیلد نام نمیتواند خالی باشد")]
        public string? Name { get; set; }
        [Display(Name = "فامیلی")]
        [Required(ErrorMessage = "فیلد فامیلی نمیتواند خالی باشد")]
        public string? Family { get; set; }
        [Display(Name = "توضیحات")]
        public string? Description { get; set; }
        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }
    }
}
