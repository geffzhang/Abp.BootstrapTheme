﻿using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme;
using Volo.Abp.SettingManagement.Localization;
using Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.Settings;

namespace Abp.SettingManagement.Blazor.BootstrapBlazorUI.Pages.SettingManagement.BootstrapBlazorThemeGroup;


//TODO  localization
public partial class BootstrapBlazorThemeGroupViewComponent
{
    public const string Name = "Volo.Abp.BootstrapBlazorThemeGroupViewComponent";
    
    [Inject]
    protected IOptions<AbpBootstrapBlazorThemeOptions> Options { get; set; }

    [Inject]
    protected IBootstrapBlazorSettingsProvider BootstrapBlazorSettingsProvider { get; set; }
    
    [CascadingParameter]
    protected SettingManagement SettingManagement { get; set; }

    protected AbpBootstrapBlazorThemeOptions AbpBootstrapBlazorThemeOptions { get; set; } = new();
    
    public BootstrapBlazorThemeGroupViewComponent()
    {
        LocalizationResource = typeof(AbpSettingManagementResource);
    }

    protected override void OnInitialized()
    {
        AbpBootstrapBlazorThemeOptions = Options.Value;
    }

    private async Task UpdateSettingAsync()
    {
        await BootstrapBlazorSettingsProvider.TriggerSettingChanged();

        await Notify.Success(L["SuccessfullySaved"]);
    }
}
