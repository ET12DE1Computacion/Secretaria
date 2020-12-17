using Secretaria.FrontEnd.Models.Components;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.FrontEnd.Views.Shared.Components.SaveEdit
{
    public class SaveEditViewComponent : ViewComponent
    {
        public SaveEditViewComponent ()
        {

        }

        public IViewComponentResult Invoke(SaveEditModel model)
        {
            return View(model);
        }
    }
}
