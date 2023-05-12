using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opdracht7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
            btnMoveMe.Click += BtnMoveMe_Click;
        }
        private async Task MoveButton(Thickness th)
        {
            await Task.Delay(500);
            btnMoveMe.Margin = th;
            btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
        }

        private void BtnMoveMe_MouseMove(object sender, MouseEventArgs e)
        {

            // maak object btn van het binnenkomende object sender
            Button btn = (Button)sender;

            // maak een nieuwe instance van een Thickness object
            Thickness th = new Thickness();

            // Maak een randomizer object
            Random r = new Random();

            int w = r.Next(0, (int)MyGrid.ActualWidth - (int)btn.ActualWidth);
            int t = r.Next(0, (int)MyGrid.ActualHeight - (int)btn.ActualHeight);

            btnMoveMe.MouseMove -= BtnMoveMe_MouseMove;

            th.Left = w;
            th.Top = t;

            //btn.Margin = th;
            _ = MoveButton(th);

        }

        private void BtnMoveMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je hebt me te pakken");
        }
    }
}
