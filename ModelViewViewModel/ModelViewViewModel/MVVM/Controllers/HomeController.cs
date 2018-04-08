using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVVM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{ empId = 1, empName="Billy", empSalary = 40},
                new Employee{ empId = 2, empName="Elie", empSalary = 80},
                new Employee{ empId = 3, empName="Alves", empSalary = 60},
            };
            //return View("Index", emp);

            List<EmployeeViewModel> empvmobj = new List<EmployeeViewModel>();

            foreach (Employee empobj in emp)
            {
                EmployeeViewModel vmobj = new EmployeeViewModel();

                vmobj.empName = empobj.empName;
                vmobj.empSalary = empobj.empSalary;

                if (vmobj.empSalary > 50)
                {
                    vmobj.empSalaryColor = 1;
                }
                else
                {
                    vmobj.empSalaryColor = 2;
                }
                empvmobj.Add(vmobj);
            }
            return View("VmView", empvmobj);
        }

        public ActionResult ConsultaProduto()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto{ IdProduto = 1, Descricao = "Macarrão", Quantidade = 10},
                new Produto{ IdProduto = 2, Descricao = "Sardina", Quantidade = 40},
                new Produto{ IdProduto = 3, Descricao = "Aroz", Quantidade = 10},
                new Produto{ IdProduto = 4, Descricao = "Feijão", Quantidade = 25}
            };

            List<ProdutoViewModel> produtosViewModel = new List<ProdutoViewModel>();

            foreach (Produto itemProduto in produtos)
            {
                ProdutoViewModel produtoViewModel = new ProdutoViewModel();

                produtoViewModel.Descricao = itemProduto.Descricao;

                if (produtoViewModel.Quantidade > 20)
                    produtoViewModel.State = true;
                else
                    produtoViewModel.State = false;

                produtosViewModel.Add(produtoViewModel);
            }
            return View("ConsultaProduto", produtosViewModel);
        }
    }
}