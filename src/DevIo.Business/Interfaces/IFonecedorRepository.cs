using DevIo.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIo.Business.Interfaces
{
    public interface IFonecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
