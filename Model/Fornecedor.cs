using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("fornecedores")]
    public class Fornecedor : Base
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("cnpj")]
        public string Cnpj { get; set; }

        [Column("rg")]
        public string Rg { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Column("id_empresa")]
        public int IdEmpresa { get; set; }


    }
}
