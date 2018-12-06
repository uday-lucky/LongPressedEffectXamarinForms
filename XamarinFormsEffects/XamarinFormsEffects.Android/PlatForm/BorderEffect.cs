using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsEffects.Droid.PlatForm;

[assembly: ResolutionGroupName("SuperAwesome")]
[assembly: ExportEffect(typeof(LongPressAndroid_Effect), "LongPressEffect")]
namespace XamarinFormsEffects.Droid.PlatForm
{
    public class LongPressAndroid_Effect : PlatformEffect
    {
        protected override void OnAttached()
        {
            

                // Control.SetBackgroundColor(Android.Graphics.Color.Blue);

                // Control.SetBackgroundColor(Android.Graphics.Color.Red);
                Control.LongClick += Control_LongClick;
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Red);
           // }

        }

        private void Control_LongClick(object sender, Android.Views.View.LongClickEventArgs e)
        {
           // Control.SetBackgroundColor(Android.Graphics.Color.Black);
            var command = Models.LongPressEffect.GetCommand(Element);
            command?.Execute(Models.LongPressEffect.GetCommandParameter(Element));
        }

      

        protected override void OnDetached()
        {
           // Control.SetBackgroundColor(Android.Graphics.Color.White);
            //  Control.SetBackgroundColor(Android.Graphics.Color.Black);
        }
    }
}