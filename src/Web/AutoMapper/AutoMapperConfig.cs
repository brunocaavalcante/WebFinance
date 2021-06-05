
using AutoMapper;
using Business.Financas.Models;
using Web.ViewModels;

namespace Web.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Operacao, OperacaoViewModel>().ReverseMap();
            CreateMap<NaturezaOperacao, NaturezaOperacaoViewModel>().ReverseMap();
        }
    }
}
