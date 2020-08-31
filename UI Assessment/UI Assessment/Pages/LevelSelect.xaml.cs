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
    public sealed partial class LevelSelect : Page
    {
        public LevelSelect()
        {
            this.InitializeComponent();
        }

        private void Level_1_Button_Click(object sender, RoutedEventArgs e)
        {
            Level_Info_Text.Text = "Level 1 Selected";
            Level_Start_Button.IsEnabled = true;
        }

        private void Level_2_Button_Click(object sender, RoutedEventArgs e)
        {
            Level_Info_Text.Text = "Level 2 Selected";
            Level_Start_Button.IsEnabled = true;
        }

        private void Level_3_Button_Click(object sender, RoutedEventArgs e)
        {
            Level_Info_Text.Text = "Level 3 Selected";
            Level_Start_Button.IsEnabled = true;
        }

        private void Level_4_Button_Click(object sender, RoutedEventArgs e)
        {
            Level_Info_Text.Text = "Level 4 Selected";
            Level_Start_Button.IsEnabled = true;
        }

        private void Level_5_Button_Click(object sender, RoutedEventArgs e)
        {
            Level_Info_Text.Text = "Level 5 Selected";
            Level_Start_Button.IsEnabled = true;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
