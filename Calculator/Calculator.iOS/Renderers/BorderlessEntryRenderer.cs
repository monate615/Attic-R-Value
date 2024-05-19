using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Calculator.Controls.BorderlessEntry), typeof(Calculator.iOS.BorderlessEntryRenderer))]

namespace Calculator.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                this.Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}