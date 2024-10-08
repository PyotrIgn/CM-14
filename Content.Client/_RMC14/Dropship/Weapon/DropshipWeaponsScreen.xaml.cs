﻿using Robust.Client.AutoGenerated;
using Robust.Client.Graphics;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Dropship.Weapon;

[GenerateTypedNameReferences]
public sealed partial class DropshipWeaponsScreen : Control
{
    public DropshipWeaponsScreen()
    {
        RobustXamlLoader.Load(this);
        Viewport.ViewportSize = new Vector2i(500, 500);
        Viewport.Eye = new FixedEye();
    }
}
