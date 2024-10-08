﻿using Content.Client.Message;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Dropship.Weapon;

[GenerateTypedNameReferences]
public sealed partial class DropshipWeaponsButtonRow : BoxContainer
{
    public DropshipWeaponsButtonRow()
    {
        RobustXamlLoader.Load(this);
    }

    public void Refresh()
    {
        switch (Orientation)
        {
            case LayoutOrientation.Horizontal:
                PaddingStart.HorizontalExpand = true;
                PaddingStart.VerticalExpand = false;

                PaddingEnd.HorizontalExpand = true;
                PaddingEnd.VerticalExpand = false;
                break;
            case LayoutOrientation.Vertical:
                PaddingStart.HorizontalExpand = false;
                PaddingStart.VerticalExpand = true;

                PaddingEnd.HorizontalExpand = false;
                PaddingEnd.VerticalExpand = true;
                SetHeight = 500;
                break;
        }
    }

    public void SetData(
        DropshipWeaponsButtonData? one = null,
        DropshipWeaponsButtonData? two = null,
        DropshipWeaponsButtonData? three = null,
        DropshipWeaponsButtonData? four = null,
        DropshipWeaponsButtonData? five = null)
    {
        SetData(One, one);
        SetData(Two, two);
        SetData(Three, three);
        SetData(Four, four);
        SetData(Five, five);
    }

    private void SetData(DropshipWeaponsButton button, DropshipWeaponsButtonData? data)
    {
        static string Wrap(LocId? loc)
        {
            var text = loc == null ? string.Empty : Loc.GetString(loc);
            var size = 9;
            // TODO RMC14 FIXME my kingdom for mono font
            if (text == "WEAPON")
                size = 8;

            return $"[font size={size}][color=white]{text}[/color][/font]";
        }

        button.RichLabel.SetMarkupPermissive(Wrap(data?.Text));
        button.SetOnPressed(data?.OnPressed);
    }
}
