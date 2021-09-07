using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório.")]
        public string Description { get; set; }
        [Display(Name = "Quantidade")]
        [Range(0,2000, ErrorMessage ="Valor fora da faixa.")]
        public int Amount { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }


    }
}
