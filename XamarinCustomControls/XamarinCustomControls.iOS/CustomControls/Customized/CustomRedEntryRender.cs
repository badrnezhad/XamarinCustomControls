using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using XamarinCustomControls.CustomControls.Customized;
using XamarinCustomControls.iOS.CustomControls.Customized;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomRedEntry), typeof(CustomRedEntryRender))]
namespace XamarinCustomControls.iOS.CustomControls.Customized
{
    public class CustomRedEntryRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            Control.BackgroundColor = UIColor.Red;
            Control.TextColor = UIColor.White;
            Control.BorderStyle = UITextBorderStyle.Line;

        }
    }
}