﻿using Volo.Abp.Data;

namespace Abp.BootstrapThemeUI.Components.ObjectExtending;

public partial class CheckExtensionProperty<TEntity, TResourceType>
    where TEntity : IHasExtraProperties
{
    protected bool Value {
        get {
            return PropertyInfo.GetInputValueOrDefault<bool>(Entity.GetProperty(PropertyInfo.Name));
        }
        set {
            Entity.SetProperty(PropertyInfo.Name, value, false);
        }
    }
}
