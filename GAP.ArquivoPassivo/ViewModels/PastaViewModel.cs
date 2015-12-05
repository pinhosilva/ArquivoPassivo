using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAP.ArquivoPassivo.ViewModels
{
    public class PastaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Nome Obrigatório.")]
        [MaxLength(150,ErrorMessage="Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome da Mãe é Obrigatório.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Mae { get; set; }

        [Required(ErrorMessage = "Preencher campo Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Nascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeCadastro { get; set; }

        public int ArquivoId { get; set; }
        public virtual ArquivoViewModel Arquivo { get; set; }
    }
}