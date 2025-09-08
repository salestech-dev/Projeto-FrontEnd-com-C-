using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_FrontEnd_com_C_.Db
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

       public DbSet<Models.UsuarioModel> Usuarios { get; set; }
       public DbSet<Models.Produto> Produtos { get; set; }
    }
}