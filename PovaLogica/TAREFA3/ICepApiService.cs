using Refit;

namespace TAREFA3
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<Cep> GetAddressAsync(string cep);
    }
}
