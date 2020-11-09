using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Barcode
{
    public partial class AdminWindow : Window
    {
        private static BarcodesEntities db = new BarcodesEntities();
        public List<CountryBarcodes> Cb { get; set; } = db.CountryBarcodes.ToList();

        public AdminWindow()
        {
            InitializeComponent();
        }

        private async void Delete(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (CountryBarcodes item in dataGrid.SelectedItems)
                        db.CountryBarcodes.Remove(item);
                    await db.SaveChangesAsync();
                    dataGrid.Items.Refresh();
                }
                catch (Exception)
                {

                }
            }
        }

        private async void Update(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (CountryBarcodes item in dataGrid.SelectedItems)
                        db.CountryBarcodes.SqlQuery($"UPDATE CountryBarcodes SET Country = \'{item.Country}\' SET Barcode = \'{item.Barcode}\' WHERE Id = {item.Id}");
                    await db.SaveChangesAsync();
                    dataGrid.Items.Refresh();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
