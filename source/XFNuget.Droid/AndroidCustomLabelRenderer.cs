using Xamarin.Forms;  
using Xamarin.Forms.Platform.Android;  
using XFNuget.Droid;  
using XFNuget.Forms;  
  
[assembly: ExportRenderer(typeof(CustomLabel), typeof(AndroidCustomLabelRenderer))]  
namespace XFNuget.Droid  
{  
    public class AndroidCustomLabelRenderer : LabelRenderer  
    {  
  
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)  
        {  
            base.OnElementChanged(e);  
              
            if (Control != null)  
            {  
                Control.Text = "This a custom Android component";  
            }  
        }  
    }  
}
