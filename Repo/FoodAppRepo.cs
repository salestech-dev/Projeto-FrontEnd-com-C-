using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_FrontEnd_com_C_.Db;
using Projeto_FrontEnd_com_C_.Models;

namespace Projeto_FrontEnd_com_C_.Repo
{
    public class FoodAppRepo : iFoodApp
    {
        private readonly Db.BancoContext _context;

        public FoodAppRepo(BancoContext context)
        {
            _context = context;
        }

        public Produto AddProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        void iFoodApp.AddProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}