using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutSidebarPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	
	}
}
