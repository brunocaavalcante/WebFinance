using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class OperacaoViewModel
    {
        public Guid Id { get; set; }
        public Guid NaturezaOperacaoId { get; set; }

        [Display(Name = "Valor")]
        public string Valor { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }
        public ContaViewModel Conta { get; set; }
        public UsuarioViewModel Usuario { get; set; }
        [Display(Name = "Operação")]
        public int TipoOperacao { get; set; }
        [Display(Name = "Natureza")]
        public NaturezaOperacaoViewModel NaturezaOperacao { get; set; }

        [Display(Name = "Selecione o tipo da Operação")]
        public List<SelectListItem> ListaOperacao = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Depósito" },
            new SelectListItem { Value = "2", Text = "Saque" }

        };
        [Display(Name = "Selecione o tipo da Operação")]
        public List<SelectListItem> ListaNatureza { get; set; }
    }
}
