
using Android.Content;
using Android.Graphics;
using Android.Widget;
using XamarinCustomControls.CustomControls;
using XamarinCustomControls.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRender))]
namespace XamarinCustomControls.Droid.CustomControls
{
    public class CustomButtonRender : ButtonRenderer
    {
        public CustomButtonRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
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