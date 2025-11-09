using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Volksdex_II.Data;
using Volksdex_II.Models;

namespace Volksdex_II.Controllers
{
    public class HomeController : Controller
    {
        private readonly VolksdexContext _context;

        public HomeController(VolksdexContext context)
        {
            _context = context;
        }

        // Converte "XX cv" em inteiro para ordenar
        private int ConvertPotenciaToInt(string potencia)
        {
            if (string.IsNullOrEmpty(potencia)) return 0;
            var partes = potencia.Split(' ');
            if (int.TryParse(partes[0], out int valor))
                return valor;
            return 0;
        }

        // GET: /Home/Index
        public IActionResult Index(string filtro)
        {
            var carros = _context.Carros.AsQueryable();

            // Filtra por nome do modelo
            if (!string.IsNullOrEmpty(filtro) && filtro != "anoAsc" && filtro != "anoDesc" &&
                filtro != "potenciaAsc" && filtro != "potenciaDesc" && filtro != "nome")
            {
                carros = carros.Where(c => c.NomeModelo.Contains(filtro));
            }

            // Ordena conforme o filtro
            switch (filtro)
            {
                case "anoAsc":
                    carros = carros.OrderBy(c => c.AnoLancamento);
                    break;
                case "anoDesc":
                    carros = carros.OrderByDescending(c => c.AnoLancamento);
                    break;
                case "potenciaAsc":
                    carros = carros
                        .AsEnumerable() // traz os dados para memória para usar o método ConvertPotenciaToInt
                        .OrderBy(c => ConvertPotenciaToInt(c.Potencia))
                        .AsQueryable();
                    break;
                case "potenciaDesc":
                    carros = carros
                        .AsEnumerable()
                        .OrderByDescending(c => ConvertPotenciaToInt(c.Potencia))
                        .AsQueryable();
                    break;
                case "nome":
                    carros = carros.OrderBy(c => c.NomeModelo);
                    break;
                default:
                    carros = carros.OrderBy(c => c.NomeModelo);
                    break;
            }

            return View(carros.ToList());
        }
    }
}
