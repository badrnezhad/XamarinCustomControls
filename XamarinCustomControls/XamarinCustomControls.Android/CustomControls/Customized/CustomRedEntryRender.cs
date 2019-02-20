
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Java.Lang;
using XamarinCustomControls.CustomControls;
using XamarinCustomControls.CustomControls.Customized;
using XamarinCustomControls.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomRedEntry), typeof(CustomRedEntryRender))]
namespace XamarinCustomControls.Droid.CustomControls
{
    public class CustomRedEntryRender : EntryRenderer
    {
        public CustomRedEntryRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            var ele = e.NewElement;

            var color = Android.Graphics.Color.Red;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(color);
            else
                Control.Background.SetColorFilter(color, PorterDuff.Mode.SrcAtop);

            Typeface typeface = Typeface.CreateFromAsset(Context.Assets, "fonts/iranyekan.ttf");
            Control.SetTypeface(typeface, TypefaceStyle.Normal);
        }

    }
}