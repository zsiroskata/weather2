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
		public MainWindow()
		{
			InitializeComponent();
		}

		private void hozzaad_click(object sender, RoutedEventArgs e)
		{
            if (txtBox.Text != "")
            {
				list.Items.Add(txtBox.Text);
            }
			else
			{
				MessageBox.Show("írjál valamit be");
			}
        }

		private void torles_click(object sender, RoutedEventArgs e)
		{
			if (list.SelectedItem != null)
			{
				list.Items.Remove(list.SelectedItem);
			}
		}
	}
}