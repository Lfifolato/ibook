using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ibook.Models
{   
    [Table("Livros")]
    public class Livros
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "titulo Obrigadop")]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "Descrição Obrigadop")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Genero Obrigatorio")]
        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Quantidade de Pagina Obrigatorio")]
        [Display(Name = "Quantidade de Pagina")]
        public int quantPag { get; set; }

        [Required(ErrorMessage = "Data Obrigatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datalancamento { get; set; }


    }
}
