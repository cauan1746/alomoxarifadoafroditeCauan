using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    public class FornecedorController : Controller
    {
         private readonly IFornecedorRepositorio _db;
        public FornecedorController(IFornecedorRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/lista")]
        public IActionResult listaFornecedor()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Fornecedor")]
        public IActionResult listaFornecedor(FornecedorDTO fornecedor)
        {
            return Ok(_db.GetAll().Where(x => x.Codigo == fornecedor.Codigo));
        }

        [HttpPost("/criarFornecedor")]
        public IActionResult criarFornecedor(FornecedorCadastroDTO fornecedor, object descricao)
        {

            var novafornecedor = new Fornecedor()
            {
                nome = fornecedor.nome,
                Cidade = fornecedor.Cidade,
                CNPJ = fornecedor.CNPJ,
                Telefone = fornecedor.Telefone,
                Estado = fornecedor.Estado
            };
            //_categorias.Add(novaFornecedor);
            _db.Add(novaFornecedor);
            return Ok("Fornecedor com Sucesso");
        }
        }
    }

