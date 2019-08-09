using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("fornecedores_pessoa_juridica")]
    public class FornecedorPj : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Column("id_empresa")]
        public int IdEmpresa { get; set; }


    }
}
