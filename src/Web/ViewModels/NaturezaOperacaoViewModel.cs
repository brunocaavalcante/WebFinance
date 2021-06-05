using System;
using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class NaturezaOperacaoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }       
        
    }
}
