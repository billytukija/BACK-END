using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVM.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
    }

    public class ProdutoViewModel
    {
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public bool State { get; set; }
    }
}