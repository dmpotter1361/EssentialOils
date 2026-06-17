namespace EssentialOils;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

        OilCatalog catalog;
        try
        {
            catalog = OilCatalog.Load();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Could not load the oil data (oils.json).\n\n{ex.Message}",
                "Essential Oil Mixer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        Application.Run(new MainForm(catalog));
    }
}
