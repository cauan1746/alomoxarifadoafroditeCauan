using AlmoxarifadoBackAPI.Models;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class ProdutoRepositorio : IFonecedorRepositorio
    {
        private readonly Context _db;

        public ProdutoRepositorio(Context db)
        {
            _db = db;
        }

        public void Add(Produto produto)
        {
<<<<<<< HEAD
            
=======

>>>>>>> a32f9cdb547b5ee0963854e0060f7c274b67af30
            _db.Produto.Add(produto);
            _db.SaveChanges();
        }

        public List<Produto> GetAll() { 
          return _db.Produto.ToList();
        }

    }
}
