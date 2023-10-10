using Microsoft.Maui.Platform;

namespace AppMAUIGallery.Libraries;

public static class KeyboardFix
{
    public static void HideKeyboard()
    {
#if ANDROID
        if(Platform.CurrentActivity.CurrentFocus is not null)
        {
            Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
        }
#endif
    }
}
