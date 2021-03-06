using System.Collections.Generic;
using System.Linq;

using R4Mvc.Locators;

namespace R4Mvc.Services
{
	public class ViewLocatorService : IViewLocatorService
	{
		private readonly IEnumerable<IViewLocator> _viewLocators;

		public ViewLocatorService(IEnumerable<IViewLocator> viewLocators)
		{
			_viewLocators = viewLocators;
		}

		public IEnumerable<View> FindViews()
		{
			return _viewLocators.SelectMany(x => x.Find());
		}
	}
}