namespace SITEMAVENTAS.VISTA
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
            Application.Run(new NewFolder.PersonalListarVista());
            //Application.Run(new ClienteVistas.ClienteListarVista());
            //Application.Run(new DetallelngVistas.DetallelngListarvista());
            //Application.Run(new DetalleVenVistas.DetalleVenListarvista());
            //Application.Run(new IngresoVistas.IngresoListarvista());
            //Application.Run(new MarcaVistas.MarcaListarvista());
            //Application.Run(new ProductoVistas.ProductoListarvista());
            //Application.Run(new ProveeVistas.ProveeListarvista());
            //Application.Run(new ProveedorVistas.ProveedorListarvista());
            //Application.Run(new RolVistas.RolListarvista());
            //Application.Run(new TipoProdVistas.TipoProdListarvista());
            //Application.Run(new UsuarioVistas.UsuarioListarvista());
            //Application.Run(new UsuarioRolVistas.UsuarioRolListarvista());
            //Application.Run(new VentaVistas.VentaListarvista());

        }
    }
}