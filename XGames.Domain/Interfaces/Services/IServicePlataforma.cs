using XGames.Domain.Arguments.Plataforma;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
