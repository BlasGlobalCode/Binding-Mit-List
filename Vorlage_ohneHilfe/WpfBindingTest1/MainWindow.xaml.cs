using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfBindingTest1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BLand> GetBLands { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            GetBLands = new List<BLand>();
            GetBLands.Add(new BLand("Rheinland", "Mainz",232));
            this.DataContext = this;
        }

        public class BLand
        {
            public double Population = 2222;
            public string l { get; set; }
            public string bl { get; set; }

            public BLand() { }
            public BLand(string Land, string BundesLand, double Einwohner)
            {
                l = Land;
                bl = BundesLand;
                Population = Einwohner;
            }

            public override string ToString()
            {
                return bl;
            }
        }

        private void btnEinfuegen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            double a = 1000000;
            a = rnd.NextDouble();
            try
            {
                GetBLands.Add(new BLand(txtBland.Text,txtLand.Text,a));
                txtBland.Text = string.Empty;
                txtLand.Text = string.Empty;
                LBoxLaender.Items.Refresh();
            }
            catch (Exception){}
        }
    }
}