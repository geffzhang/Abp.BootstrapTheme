﻿using Volo.Abp.Data;

namespace Abp.BootstrapThemeUI.Components.ObjectExtending;

public partial class TextExtensionProperty<TEntity, TResourceType>
    where TEntity : IHasExtraProperties
{
    protected string Value {
        get {
            return PropertyInfo.GetTextInputValueOrNull(Entity.GetProperty(PropertyInfo.Name));
        }
        set {
            Entity.SetProperty(PropertyInfo.Name, value, validate: false);
        }
    }
}
