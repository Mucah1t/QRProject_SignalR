using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutFooterPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	
	}
}
