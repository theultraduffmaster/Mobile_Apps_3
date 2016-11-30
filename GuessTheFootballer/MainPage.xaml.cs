using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using GuessTheFootballer.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GuessTheFootballer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ViewTeams = new ViewModel.TeamsViewModel();
        }

        public TeamsViewModel ViewTeams { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void BtnQuiz_Click(object sender, RoutedEventArgs e)
        {

                BtnQuiz.Visibility = Visibility.Collapsed;
                BtnArsYes.Visibility = Visibility.Visible;
                BtnArsNo.Visibility = Visibility.Visible;
            



        }

        private void BtnQuiz2_Click(object sender, RoutedEventArgs e)
        {

                BtnQuiz2.Visibility = Visibility.Collapsed;
                BtnCheYes.Visibility = Visibility.Visible;
                BtnCheNo.Visibility = Visibility.Visible;
           
        }

        private void BtnQuiz3_Click(object sender, RoutedEventArgs e)
        {
            BtnQuiz3.Visibility = Visibility.Collapsed;
            BtnLeiYes.Visibility = Visibility.Visible;
            BtnLeiNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz4_Click(object sender, RoutedEventArgs e)
        {
            BtnQuiz4.Visibility = Visibility.Collapsed;
            BtnLivYes.Visibility = Visibility.Visible;
            BtnLivNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz5_Click(object sender, RoutedEventArgs e)
        {
            BtnQuiz5.Visibility = Visibility.Collapsed;
            BtnManCYes.Visibility = Visibility.Visible;
            BtnManCNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz6_Click(object sender, RoutedEventArgs e)
        {
            BtnQuiz6.Visibility = Visibility.Collapsed;
            BtnManUYes.Visibility = Visibility.Visible;
            BtnManUNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz7_Click(object sender, RoutedEventArgs e)
        {
            BtnQuiz7.Visibility = Visibility.Collapsed;
            BtnSpursYes.Visibility = Visibility.Visible;
            BtnSpursNo.Visibility = Visibility.Visible;
        }

        private void BtnArsYes_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
