using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Web.ViewModels;
using Business.Financas.Models;
using Business.Financas.Interfaces;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class AdministracaoController : Controller
    {
        private readonly IMapper _autoMapper;
        private readonly INaturezaOperacaoService _naturezaOperacaoService;
        public AdministracaoController(IMapper autoMapper,
                                       INaturezaOperacaoService naturezaOperacaoService)
        {
            _autoMapper = autoMapper;
            _naturezaOperacaoService = naturezaOperacaoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        #region NATUREZA OPERACAO

        [HttpGet]
        public async Task<IActionResult> NaturezaOperacaoIndex()
        {
            var lista = _autoMapper.Map<List<NaturezaOperacaoViewModel>>(await _naturezaOperacaoService.ObterNaturezaOpercao());
            return View("NaturezaOperacao/NaturezaOperacaoIndex", lista);
        }

        [HttpGet]
        public IActionResult CreateNaturezaOperacao()
        {
            var natureza = new NaturezaOperacaoViewModel();
            return View("NaturezaOperacao/CreateNaturezaOperacao", natureza);
        }

        [HttpPost]
        public async Task<IActionResult> SalvaNaturezaOperacao(NaturezaOperacaoViewModel model)
        {
            var natureza = _autoMapper.Map<NaturezaOperacao>(model);
            natureza.Id = Guid.NewGuid();

            await _naturezaOperacaoService.Adicionar(natureza);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DetalhesNaturezaOperacao(Guid Id)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteNaturezaOpercao(Guid Id)
        {
            if (Id == null) return NotFound();

            var natureza = _autoMapper.Map<NaturezaOperacaoViewModel>(await _naturezaOperacaoService.ObterPorId(Id));

            if (natureza == null) return NotFound();

            return View("NaturezaOperacao/DeleteNaturezaOperacao", natureza);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteNatureza(Guid Id)
        {
            if (Id == null) return NotFound();

            var natureza = await _naturezaOperacaoService.ObterPorId(Id);

            if (natureza == null) return NotFound();

            await _naturezaOperacaoService.Delete(natureza);

            var lista = _autoMapper.Map<List<NaturezaOperacaoViewModel>>(await _naturezaOperacaoService.ObterNaturezaOpercao());

            return View("NaturezaOperacao/NaturezaOperacaoIndex", lista);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNaturezaOperacao(NaturezaOperacaoViewModel natureza)
        {
            return Ok();
        }

        #endregion
    }
}