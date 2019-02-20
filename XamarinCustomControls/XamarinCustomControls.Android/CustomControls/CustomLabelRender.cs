using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinCustomControls.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRender))]
namespace XamarinCustomControls.Droid.CustomControls
{
    public class CustomLabelRender : LabelRenderer
    {
        public CustomLabelRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Typeface typeface = Typeface.CreateFromAsset(Context.Assets, "fonts/iranyekan.ttf");
                Control.SetTypeface(typeface, TypefaceStyle.Normal);
            }
        }
    }
}