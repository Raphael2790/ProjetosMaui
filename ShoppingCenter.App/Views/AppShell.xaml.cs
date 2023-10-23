namespace ShoppingCenter.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("stores/details", typeof(Views.Stores.DetailsPage));
        }
    }
}