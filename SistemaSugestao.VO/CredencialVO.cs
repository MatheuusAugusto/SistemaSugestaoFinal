using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaSugestao.VO
{
    public class CredencialVO
    {
        [Required]
        public int IdCredencial { get; set; }

        [Required]
        [Display(Name = "Nome do Login")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        [Display(Name = "Password")]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Informe o Nome")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Informe o CPF")]
        [RegularExpression("[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9]-[0-9][0-9]")]
        public string CPF { get; set; }


    }
}
