using Model;
using Repository.DataBase;
using Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public SistemaContext context;

        public FornecedorRepository(SistemaContext context)
        {
            this.context = context;
        }
        public bool Alterar(Fornecedor fornecedor)
        {
            context.Fornecedores.Update(fornecedor);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var empresa = context.Fornecedores.FirstOrDefault(x => x.Id == id);
            if (empresa == null)
            {
                return false;
            }
            empresa.RegistroAtivo = false;
            context.Fornecedores.Update(empresa);
            return context.SaveChanges() == 1;
        }

        public int Inserir(Fornecedor fornecedor)
        {
            context.Fornecedores.Add(fornecedor);
            context.SaveChanges();
            return fornecedor.Id;
        }

        public Fornecedor ObterPeloId(int id)
        {
            return context.Fornecedores.FirstOrDefault(x => x.Id == id);
        }

        public List<Fornecedor> ObterTodos(string busca)
        {
            return context.Fornecedores.Where(x => x.RegistroAtivo && (string.IsNullOrEmpty(busca)
            ? true : (x.Nome.Contains(busca)))).OrderBy(x => x.Nome).ToList();

        }
    }
}
