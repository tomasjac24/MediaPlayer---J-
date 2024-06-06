using Microsoft.Win32;
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

namespace MediaPlayer___Jáč
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Player.Stop();
		}
		private bool isPlaying = false;
		private void OpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();

			bool? result = dialog.ShowDialog();

			if (result == true)
			{
				string path = dialog.FileName;
				Player.Source = new Uri(path); // Přiřaďte získanou cestu k videu k zdroji přehrávače.
				Player.Play();
				isPlaying = true;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (isPlaying)
			{
				Player.Pause(); // Pokud je video právě přehráváno, pozastavte ho.
				isPlaying = false;
			}
			else
			{
				Player.Play(); // Pokud je video pozastaveno, spusťte ho.
				isPlaying = true;
			}
		}

	}
}
