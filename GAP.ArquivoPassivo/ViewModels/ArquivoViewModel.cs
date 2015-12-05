using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GAP.ArquivoPassivo.ViewModels
{
    public class ArquivoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Preencha o campo Letra.")]
        [MaxLength(1,ErrorMessage="Máximo {0} Letra.")]
        public string Letra { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número.")]
        [MaxLength(1, ErrorMessage = "Máximo {0} Número.")]
        public int Numero { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataDeCadastro { get; set; }

        public virtual IEnumerable<PastaViewModel> Pastas { get; set; }
    }
}