﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using osu.Framework.Graphics.UserInterface;

namespace osu.Game.Graphics.UserInterface
{
    public class OsuContextMenuItem : MenuItem
    {
        public readonly MenuItemType Type;

        public OsuContextMenuItem(string text, MenuItemType type = MenuItemType.Standard)
            : base(text)
        {
            Type = type;
        }

        public OsuContextMenuItem(string text, MenuItemType type, Action action)
            : base(text, action)
        {
            Type = type;
        }
    }
}