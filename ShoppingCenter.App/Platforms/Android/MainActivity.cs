using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;

namespace ShoppingCenter.App
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            if(ev.Action == MotionEventActions.Down)
            {
                var view = CurrentFocus;
                if(view is EditText edit)
                {
                    edit.ClearFocus();
                    InputMethodManager imm = (InputMethodManager)GetSystemService(InputMethodService);
                    imm.HideSoftInputFromWindow(edit.WindowToken, 0);
                }
            }

            return base.DispatchTouchEvent(ev);
        }
    }
}