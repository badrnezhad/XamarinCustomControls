using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using XamarinCustomControls.CustomControls;
using XamarinCustomControls.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRender))]
namespace XamarinCustomControls.iOS.CustomControls
{
    public class CustomButtonRender : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

        }
    }
}