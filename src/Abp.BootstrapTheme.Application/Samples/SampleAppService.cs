using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Abp.BootstrapTheme.Management.Samples
{
    public class SampleAppService : BootstrapThemeAppService, ISampleAppService
    {
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
    }
}