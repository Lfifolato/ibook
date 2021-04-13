using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ibook.Models
{
    [Table("escritores")]
    public class Escritores
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail Obrigatorio")]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        public string email { get; set; }


        [Required(ErrorMessage = "Telefone Obrigatorio")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "Idade Obrigatorio")]
        [Display(Name = "Idade")]
        public int idade { get; set; }

        [Required(ErrorMessage = "Cidade Obrigatorio")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

    }
}
