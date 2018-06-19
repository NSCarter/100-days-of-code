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

namespace RecipeOrganiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BakingMenu : Page
    {
        public BakingMenu()
        {
            InitializeComponent();
        }

        //Page2 Testing = new Page2();

        private void cookingButton(object sender, RoutedEventArgs e)
        {
            //CookingMenu cooking = new CookingMenu();
            //cooking.Show();
            //cooking.Activate();
            //mainFrame.Navigate(new CookingMenu());
            App.ParentWindowRef.ParentFrame.Navigate(new CookingMenu());
            //this.Content = Testing.Content;
        }


    }
}
