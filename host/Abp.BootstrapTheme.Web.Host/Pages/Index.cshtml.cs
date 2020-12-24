using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Abp.BootstrapTheme.Pages
{
    public class IndexModel : BootstrapThemePageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}