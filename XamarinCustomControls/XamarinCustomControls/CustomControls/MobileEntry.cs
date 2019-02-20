using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinCustomControls.CustomControls
{
    public class MobileEntry : CustomEntry
    {
        public MobileEntry()
        {
            Initialize();
        }
        private void Initialize()
        {
            MaxLength = 11;
            LableText = "شماره همراه";
            IsPassword = false;
            Keyboard = Keyboard.Numeric;
            ReturnType = ReturnType.Send;
            IsSpellCheckEnabled = false;
            Placeholder = "09XXXXXXXXX";
            IsTextPredictionEnabled = false;
            TextChanged += Entry_TextChanged;
        }
        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
            if (!newText.StartsWith("09"))
            {

            }
        }
    }
}
