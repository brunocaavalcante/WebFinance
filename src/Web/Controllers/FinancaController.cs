using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Financas.Interfaces;
using Business.Financas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.ViewModels;

namespace Web.Controllers
{
    public class FinancaController : Controller
    {
        private readonly IOperacaoRepository _operacaoRepository;
        private readonly INaturezaOperacaoRepository _naturezaOperacaoRepository;
        private readonly IMapper _autoMapper;

        public FinancaController(IOperacaoRepository operacaoRepository,
                                 INaturezaOperacaoRepository naturezaOperacaoRepository,
                                 IMapper mapper)
        {
            _operacaoRepository = operacaoRepository;
            _naturezaOperacaoRepository = naturezaOperacaoRepository;
            _autoMapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var operacoes = _autoMapper.Map<List<OperacaoViewModel>>(await _operacaoRepository.ObeterOperacoesPorConta(Guid.NewGuid()));
            return View(operacoes);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> CreateOperacao()
        {
            var operacaoViewModel = new OperacaoViewModel();
            var listaNaturezaOp = _autoMapper.Map<List<NaturezaOperacaoViewModel>>(await _naturezaOperacaoRepository.ObeterNaturezaOpercao());

            operacaoViewModel.ListaNatureza = listaNaturezaOp.Select(n => new SelectListItem() { Text = n.Descricao, Value = n.Id.ToString() }).ToList();

            return View("Operacao/CreateOperacao", operacaoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SalvarOperacao(OperacaoViewModel operacaoViewModel)
        {
            try
            {
                if (operacaoViewModel != null)
                {
                    operacaoViewModel.Id = Guid.NewGuid();
                    operacaoViewModel.Valor = operacaoViewModel.Valor.Replace(",", ".");
                    operacaoViewModel.DataCadastro = DateTime.Now;

                    var operacao = _autoMapper.Map<Operacao>(operacaoViewModel);
                    operacao.ContaId = Guid.Parse("5006ef38-fd62-45ae-8b9a-89192b34f227");
                    
                    await _operacaoRepository.Adicionar(operacao);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
