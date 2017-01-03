using System.ComponentModel.DataAnnotations;
namespace weptintuc.Models
{
    /// <summary>
    /// Lien he Model
    /// </summary>
    public class Lienhemodel
    {
        [Display(Name = "Tên của bạn ( * )")]
        [Required(ErrorMessage = "Tên không được trống")]
        public string UserName { get; set; }

        [Display(Name = "Email ( * )")]
        [Required(ErrorMessage = "Email không được trống")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email không đúng")]
        public string Email { get; set; }

        [Display(Name = "Chủ đề ( * )")]
        [Required(ErrorMessage = "Chủ đề không được trống")]
        public string Subject { get; set; }

        [Display(Name = "Nội dung ( * )")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }

    class ContactModel
    {
        public ContactModel()
        {
        }
    }
}