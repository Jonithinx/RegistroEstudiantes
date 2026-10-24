namespace RegistroEstudiantes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string? temaEnv = Environment.GetEnvironmentVariable("REGISTRO_TEMA");
            if (temaEnv == "Dark")
            {
                UserAppTheme = AppTheme.Dark;
            }
            else if (temaEnv == "Light")
            {
                UserAppTheme = AppTheme.Light;
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navegacion = new NavigationPage(new Views.RegistroPage());
            navegacion.SetAppThemeColor(NavigationPage.BarBackgroundColorProperty, 
                (Color)Resources["Primary"], 
                (Color)Resources["SurfaceDark"]);
            navegacion.SetAppThemeColor(NavigationPage.BarTextColorProperty, 
                Colors.White, 
                (Color)Resources["SecondaryDarkText"]);

            return new Window(navegacion);
        }
    }
}
