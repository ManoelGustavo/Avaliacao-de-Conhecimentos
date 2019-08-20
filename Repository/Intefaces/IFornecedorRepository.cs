using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Intefaces
{
    public interface IFornecedorRepository
    {
        int Inserir(Fornecedor fornecedor);

        bool Alterar(Fornecedor fornecedor);

        List<Fornecedor> ObterTodos(string busca);

        Fornecedor ObterPeloId(int id);

        bool Apagar(int id);
    }
}