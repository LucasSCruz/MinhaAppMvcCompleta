using System;
using DevIo.Business.Models;
using System.Threading.Tasks;

namespace DevIo.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid id);
    }
}
