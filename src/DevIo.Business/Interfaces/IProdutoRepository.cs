using DevIo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIo.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores(Guid id);
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
