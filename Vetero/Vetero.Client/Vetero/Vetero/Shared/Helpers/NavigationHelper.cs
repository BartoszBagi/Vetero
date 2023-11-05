using Microsoft.AspNetCore.Components;

namespace Vetero.Shared.Helpers
{
    public static class NavigationHelper
    {
        public static void ReloadPage(this NavigationManager manager)
        {
            manager.NavigateTo(manager.Uri, true);
        }
    }
}
