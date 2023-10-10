﻿namespace AppMAUIGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;

            MainPage = new AppFlyout();
        }

        private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            if(e.RequestedTheme is AppTheme.Light)
                App.Current.MainPage.DisplayAlert("Troca de tema", "Trocou para o tema claro", "Ok");
            else
                App.Current.MainPage.DisplayAlert("Troca de tema", "Trocou para o tema escuro", "Ok");
        }
    }
}