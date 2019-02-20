using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControls
{
    public class NumberEntry : CustomEntry
    {
        public NumberEntry()
        {
            Initialize();
        }
        private void Initialize()
        {
            IsPassword = false;
            Keyboard = Keyboard.Numeric;
            IsSpellCheckEnabled = false;
            PlaceholderColor = Color.WhiteSmoke;
            IsTextPredictionEnabled = false;
        }
    }
}
