using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cumarteside.Models
{
    public class UserCreateModel
    {
        [Display(Name ="Adınız")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Alan Boş Geçilemez.")]
        public string FirstName { get; set; }


        [Display(Name = "Soyadınız")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Alan Boş Geçilemez.")]
        public string LastName { get; set; }


        [Display(Name = "Kullanıcı Adınız")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Alan Boş Geçilemez.")]
        public string UserName { get; set; }


        [Display(Name = "Şifreniz")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Alan Boş Geçilemez.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Şifrenizi Tekrar Girin")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Alan Boş Geçilemez.")]
        public string RePassword { get; set; }


        [Display(Name = "Doğum Tarihiniz")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Alan Boş Geçilemez.")]
        [DataType(DataType.Date,ErrorMessage ="lütfen bir tarih seçiniz.")]
        public DateTime BirthDate { get; set; }
    }
}