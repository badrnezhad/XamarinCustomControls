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

[assembly: ExportRenderer(typeof(PCLabel), typeof(CustomLabelRender))]
namespace XamarinCustomControls.iOS.CustomControls
{
    public class CustomLabelRender : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

        }
    }
}