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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Random random = new Random();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void runawayButton_MouseEnter(object sender, MouseEventArgs e)
		{
			double newX = random.Next(0, (int)(this.ActualWidth - runawayButton.ActualWidth));
			double newY = random.Next(0, (int)(this.ActualHeight - runawayButton.ActualHeight));

			DoubleAnimation xAnimation = new DoubleAnimation(newX, TimeSpan.FromSeconds(1));
			DoubleAnimation yAnimation = new DoubleAnimation(newY, TimeSpan.FromSeconds(1));

			translateTransform.BeginAnimation(TranslateTransform.XProperty, xAnimation);
			translateTransform.BeginAnimation(TranslateTransform.YProperty, yAnimation);
		}
	}
}
