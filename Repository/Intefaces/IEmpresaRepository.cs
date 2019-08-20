using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Intefaces
{
    public interface IEmpresaRepository
    {
        int Inserir(Empresa empresa);

        bool Alterar(Empresa empresa);

        List<Empresa> ObterTodos(string busca);
            
        Empresa ObterPeloId(int id);

        bool Apagar(int id);
    }
}
