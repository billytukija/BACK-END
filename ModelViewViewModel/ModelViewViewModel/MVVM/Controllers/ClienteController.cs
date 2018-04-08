using MVVM.Models;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVM.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
            public ActionResult Index()
        {
            List<Cliente> LstClientes = new List<Cliente>()
            {
                new Cliente{ Id=1, Nome = "Billy", Apelido = "Premio"},
                new Cliente{ Id=2, Nome = "Mariana", Apelido = "common"},
                new Cliente{ Id=3, Nome = "Eric", Apelido = "common"}
            };

            List<ClienteViewModel> LstClientesViewModel = new List<ClienteViewModel>();
            foreach (Cliente cliente in LstClientes)
            {
                ClienteViewModel clienteViewMode = new ClienteViewModel();

                clienteViewMode.Nome = cliente.Nome;
                clienteViewMode.Apelido = cliente.Apelido;
                clienteViewMode.Access = cliente.Apelido == "Premio" ? true : false;

                LstClientesViewModel.Add(clienteViewMode);
            }
            return View("ConsultaClientes", LstClientesViewModel);
        }
    }
}