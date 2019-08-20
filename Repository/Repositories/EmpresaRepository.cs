using Model;
using Repository.DataBase;
using Repository.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public SistemaContext context;

        public EmpresaRepository(SistemaContext context)
        {
            this.context = context;
        }

        public bool Alterar(Empresa empresa)
        {
            context.Empresas.Update(empresa);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var empresa = context.Empresas.FirstOrDefault(x => x.Id == id);
            if (empresa == null)
            {
                return false;
            }
            empresa.RegistroAtivo = false;
            context.Empresas.Update(empresa);
            return context.SaveChanges() == 1;
        }

        public int Inserir(Empresa empresa)
        {
            context.Empresas.Add(empresa);
            context.SaveChanges();
            return empresa.Id;
        }

        public Empresa ObterPeloId(int id)
        {
            return context.Empresas.FirstOrDefault(x => x.Id == id);
        }

        public List<Empresa> ObterTodos(string busca)
        {
            return context.Empresas.Where(x => x.RegistroAtivo && (string.IsNullOrEmpty(busca)
            ? true : (x.NomeFantasia.Contains(busca)))).OrderBy(x => x.NomeFantasia).ToList();

        }
    }
}
