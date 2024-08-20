using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebAppModels
{
    public class ClassModel
    {
        public int? ClassId { get; set; }

        [DisplayName("Class Name")]
        [Required(ErrorMessage ="Enter Value",AllowEmptyStrings =false)]
        public string ClassName { get; set; } = string.Empty;

        [DisplayName("Created By")]
        [Required(ErrorMessage = "Enter Value", AllowEmptyStrings = false)]
        public string CreatedBy { get; set; } = string.Empty;

        [DisplayName("Created On")]
        [Required(ErrorMessage = "Select Value")]
        public DateTime CreatedOn { get; set; }=DateTime.Now;
    }
}
