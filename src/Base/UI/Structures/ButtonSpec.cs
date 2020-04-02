﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.Reflection;

namespace Xarial.XCad.UI.Structures
{
    public class ButtonSpec
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Tooltip { get; set; }
        public Image Icon { get; set; }
    }

    internal static class ButtonSpecExtension 
    {
        internal static void InitFromEnum<TEnum>(this ButtonSpec btn, TEnum btnEnum)
            where TEnum : Enum
        {
            btn.UserId = Convert.ToInt32(btnEnum);

            if (!btnEnum.TryGetAttribute<DisplayNameAttribute>(
                att => btn.Title = att.DisplayName))
            {
                btn.Title = btnEnum.ToString();
            }

            if (!btnEnum.TryGetAttribute<DescriptionAttribute>(
                att => btn.Tooltip = att.Description))
            {
                btn.Tooltip = btn.Title;
            }

            if (!btnEnum.TryGetAttribute<IconAttribute>(a => btn.Icon = a.Icon))
            {
                btn.Icon = Defaults.Icon;
            }
        }
    }
}