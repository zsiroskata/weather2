using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace weather2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Weather> varosok = new();
		public MainWindow()
		{
			InitializeComponent();

			using StreamReader sr = new StreamReader(
				path: @"..\..\..\src\idojarasok.txt",
				encoding: System.Text.Encoding.UTF8);
			while ( !sr.EndOfStream ) 
			{ 
				varosok.Add(new Weather( sr.ReadLine()) );
			}
			sr.Close();

            foreach (var item in varosok)
            {
                list.Items.Add( item.Varos );
            }

        }

		private void hozzaad_click(object sender, RoutedEventArgs e)
		{
            if (txtBox.Text != "" && txtBoxH.Text != "" && txtBoxP.Text != "")
            {
				list.Items.Add(txtBox.Text);
				varosok.Add(new Weather(txtBox.Text));
				varosok.Add(new Weather(txtBoxH.Text ));
				varosok.Add(new Weather(txtBoxP.Text ));
            }
			else
			{
				MessageBox.Show("valamelyik adat hiányzik");
			}
        }

		private void torles_click(object sender, RoutedEventArgs e)
		{
			if (list.SelectedItem != null)
			{
				list.Items.Remove(list.SelectedItem);
			}
		}

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedItem != null)
			{
				int index = list.SelectedIndex;
                homersekletLabel.Content = varosok[index].Homerseklet + "°C";
				paratartalomLabel.Content = varosok[index].Paratartalom + "%";
               

            }
        }
    }
}