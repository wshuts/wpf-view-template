using System.Collections.Generic;

namespace wpf_app.ViewModels
{
    public class NavigationViewModel
    {
        public void Initialize()
        {
            NavigationItems = new List<NavigationItem> { new NavigationItem { DisplayValue = "FooBar" } };
        }

        public List<NavigationItem> NavigationItems { get; set; }
    }
}