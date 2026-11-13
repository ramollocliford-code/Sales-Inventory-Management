using System;
using System.Windows.Forms;

namespace Sales_Inventory_Management
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                if (OwnerAccountService.HasOwnerAccount())
                {
                    Application.Run(new LOGIN());
                }
                else
                {
                    Application.Run(new OwnerSetUp());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The application could not start.\n\n" + ex.Message,
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}