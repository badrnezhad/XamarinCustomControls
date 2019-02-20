using XamarinCustomControls.CustomControls.Customized;
using XamarinCustomControls.CustomControls.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControls.Factories
{
    public class EntryFactory
    {
        public static Entry GetEntry(BorderColor color)
        {
            switch (color)
            {
                case BorderColor.White:
                    return new CustomWhiteEntry();
                case BorderColor.Black:
                    return new CustomBlackEntry();
                case BorderColor.Red:
                    return new CustomRedEntry();
                case BorderColor.Green:
                    return new CustomGreenEntry();
                case BorderColor.Yellow:
                    return new CustomYellowEntry();
                default:
                    return new Entry();
            }
        }
    }
}
