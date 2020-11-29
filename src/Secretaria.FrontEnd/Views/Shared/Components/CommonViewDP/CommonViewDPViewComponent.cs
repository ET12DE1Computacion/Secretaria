using Secretaria.FrontEnd.Models.Components;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.FrontEnd.Views.Shared.Components.CommonViewDP
{
    public class CommonViewDPViewComponent : ViewComponent
    {
        public CommonViewDPViewComponent ()
        {

        }

        public IViewComponentResult Invoke(SimpleText model)
        {
            return View(model);
        }

        // public async Task<IViewComponentResult> InvokeAsync(BootstrapModalModel model)
        // {
        //     var algo = await ...
        //     return View(model);
        // }
    }
}
