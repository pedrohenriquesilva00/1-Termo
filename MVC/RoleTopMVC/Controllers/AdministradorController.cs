using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public AdministradorController()
        {

        }
        [HttpGet]
        public IActionResult Dashboard()
        {
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            if(!ninguemLogado && (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var datas = agendamentoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();
            foreach (var data in datas)
            {
                switch(data.Status)
                {
                    case(uint) StatusAgendamento.APROVADO:
                    dashboardViewModel.EventosAprovados++;
                    break;
                    case(uint) StatusAgendamento.REPROVADO:
                    dashboardViewModel.EventosReprovados++;
                    break;
                    default:
                    dashboardViewModel.EventosPendentes++;
                    dashboardViewModel.Eventos.Add(data);
                    break;
                }
            }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
                return View(dashboardViewModel);
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });
            }
        }
    }
}