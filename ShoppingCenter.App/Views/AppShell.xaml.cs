namespace ShoppingCenter.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("stores/detail", typeof(Views.Stores.DetailsPage));
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.DetailsPage));
            Routing.RegisterRoute("cinemas/detaildesktop", typeof(Views.Cinemas.DetailDesktopPage));
        }
    }
}