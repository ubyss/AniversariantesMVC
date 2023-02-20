using Aniversariantes.Domain.Interfaces;
using Aniversariantes.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Thiago_Vinicius_TP1.Controllers
{
    public class AniversarianteController : Controller
    {
        private readonly IAniversariante _aniversariante;

        public AniversarianteController(IAniversariante aniversariante)
        {
            _aniversariante = aniversariante;
        }

        #region private_methods

        private void SetSession(List<int> selected)
        {
            var selectedStri = JsonConvert.SerializeObject(selected);
            HttpContext.Session.SetString("itensSelecionados", selectedStri);
        }

        private List<int> GetSelected() 
        {
            var selectedInSession = HttpContext.Session.GetString("itensSelecionados");
            return JsonConvert.DeserializeObject<List<int>>(selectedInSession);
        }

        #endregion

        [Route("/aniversariante/listadeaniversariantes")]
        public IActionResult ListaDeAniversariantes()
        {
            var aniversariantes = _aniversariante.GetAll();
            return View(aniversariantes);
        }
        [HttpPost]
        [Route("/aniversariante/selecionar")]
        public IActionResult Selecionar(List<int> selected)
        {
            SetSession(selected);

            var listSelecionados = _aniversariante.GetSelected(selected);

            return View(listSelecionados);
        }
    }
}
