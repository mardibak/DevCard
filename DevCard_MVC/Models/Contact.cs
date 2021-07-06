using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {

        [Required(ErrorMessage ="پر کردن این فیلد اجباری است")]
        [MinLength(4,ErrorMessage ="حداقل طول نام 4 کاراکتر است")]
        [MaxLength(80,ErrorMessage ="حد اکثر طول نام ۸۰ کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "پر کردن این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="ایمیل را به صورت صحیح وارد نمایید")]
        public string Email { get; set; }

        public string Message { get; set; }
        public string Service { get; set; }

    }
}
