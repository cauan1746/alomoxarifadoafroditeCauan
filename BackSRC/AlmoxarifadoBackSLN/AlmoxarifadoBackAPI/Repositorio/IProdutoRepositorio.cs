using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public interface IFonecedorRepositorio
    {
        void Add(Produto produto);

        List<Produto> GetAll();

        
    }
}
