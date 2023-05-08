using Microsoft.AspNetCore.Components;

namespace Abp.IdentityManagement.Blazor.BootstrapBlazorUI.Pages;

public partial class RoleNameComponent: ComponentBase
{
    [Parameter]
    public object Data { get; set; }
}
