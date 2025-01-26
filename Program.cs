namespace InventoryControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Registering  the global instances of required application services (if required)
            // see https://docs.devexpress.com/WindowsForms/114173/build-an-application/winforms-mvvm/concepts/view-management
            // DevExpress.Mvvm.ServiceContainer.Default.RegisterService(new ViewLocatorService());

            Application.Run(new MainView());
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}