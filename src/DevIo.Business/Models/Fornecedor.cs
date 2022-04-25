using System;
using System.Collections.Generic;

namespace DevIo.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoForncedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */

        public IEnumerable<Produto> Produtos { get; set; }
    }
}