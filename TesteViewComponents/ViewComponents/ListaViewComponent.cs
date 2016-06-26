using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TesteViewComponents.ViewComponents
{
    public class ListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(
            string sequencia)
        {
            var valores = await Task.FromResult(
                sequencia.Split(new char[] { '|' }));
            return View(valores);
        }
    }
}