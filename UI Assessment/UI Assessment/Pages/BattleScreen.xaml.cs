using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UI_Assessment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BattleScreen : Page
    {
        public BattleScreen()
        {
            this.InitializeComponent();
        }

        private void Unit_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            Unit_Button.IsEnabled = true;
            Team_Button.IsEnabled = true;
            Shop_Button.IsEnabled = true;
        }

        private void Battle_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.BattleScreen));
        }

        private void Unit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.UnitScreen));
        }

        private void Team_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.TeamScreen));
        }

        private void Shop_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.ShopScreen));
        }

        private void Chapter_1_Button_Click(object sender, RoutedEventArgs e)
        {
            Info_Panel_Text.Text = "Chapter 1 Selected";
            Chapter_Select_Button.IsEnabled = true;
        }

        private void Chapter_2_Button_Click(object sender, RoutedEventArgs e)
        {
            Info_Panel_Text.Text = "Chapter 2 Selected";
            Chapter_Select_Button.IsEnabled = true;
        }

        private void Chapter_3_Button_Click(object sender, RoutedEventArgs e)
        {
            Info_Panel_Text.Text = "Chapter 3 Selected";
            Chapter_Select_Button.IsEnabled = true;
        }

        private void Chapter_4_Button_Click(object sender, RoutedEventArgs e)
        {
            Info_Panel_Text.Text = "Chapter 4 Selected";
            Chapter_Select_Button.IsEnabled = true;
        }

        private void Chapter_Select_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.LevelSelect));
        }
    }
}
