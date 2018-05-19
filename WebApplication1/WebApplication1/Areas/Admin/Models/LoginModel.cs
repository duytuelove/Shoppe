using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Moi nhap User name!!!")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Moi nhap Password!!!")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}