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
            TxtHighscore.Text = highscore.ToString();
            
        }

        public TeamsViewModel ViewTeams { get; set; }
        public int highscore = 0;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void BtnQuiz_Click(object sender, RoutedEventArgs e)
        {

                BtnArsYes.Visibility = Visibility.Visible;
                BtnArsNo.Visibility = Visibility.Visible;
            



        }

        private void BtnQuiz2_Click(object sender, RoutedEventArgs e)
        {

                BtnCheYes.Visibility = Visibility.Visible;
                BtnCheNo.Visibility = Visibility.Visible;
           
        }

        private void BtnQuiz3_Click(object sender, RoutedEventArgs e)
        {
       
            BtnLeiYes.Visibility = Visibility.Visible;
            BtnLeiNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz4_Click(object sender, RoutedEventArgs e)
        {
            BtnLivYes.Visibility = Visibility.Visible;
            BtnLivNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz5_Click(object sender, RoutedEventArgs e)
        {
            BtnManCYes.Visibility = Visibility.Visible;
            BtnManCNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz6_Click(object sender, RoutedEventArgs e)
        {
            BtnManUYes.Visibility = Visibility.Visible;
            BtnManUNo.Visibility = Visibility.Visible;
        }

        private void BtnQuiz7_Click(object sender, RoutedEventArgs e)
        {
            BtnSpursYes.Visibility = Visibility.Visible;
            BtnSpursNo.Visibility = Visibility.Visible;
        }

        private async void BtnArsYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're correct! Arsenal are the first English team to beat Real Madrid at Santiago Bernabeu, Bayern Munich at Allianz Arena and AC Milan at San Siro.");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz.Visibility = Visibility.Collapsed;
            BtnArsYes.Visibility = Visibility.Collapsed;
            BtnArsNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnArsNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Wrong! Arsenal are the first English team to beat Real Madrid at Santiago Bernabeu, Bayern Munich at Allianz Arena and AC Milan at San Siro.");
            var result = await dialog.ShowAsync();
            BtnQuiz.Visibility = Visibility.Collapsed;
            BtnArsYes.Visibility = Visibility.Collapsed;
            BtnArsNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnCheYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Wrong! Chelsea FC’s 21–0 victory over Jeunesse Hautcharage in the UEFA Cup Winners’ Cup in 1971 is a record in all European competition.");
            var result = await dialog.ShowAsync();
            BtnQuiz2.Visibility = Visibility.Collapsed;
            BtnCheYes.Visibility = Visibility.Collapsed;
            BtnCheNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnCheNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Correct! Chelsea FC’s 21–0 victory over Jeunesse Hautcharage in the UEFA Cup Winners’ Cup in 1971 is a record in all European competition.");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz2.Visibility = Visibility.Collapsed;
            BtnCheYes.Visibility = Visibility.Collapsed;
            BtnCheNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnLeiYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Correct! The club holds a joint-highest seven second-tier titles (six Second Division and one Championship.");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz3.Visibility = Visibility.Collapsed;
            BtnLeiYes.Visibility = Visibility.Collapsed;
            BtnLeiNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnLeiNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                 "You're Wrong! Chelsea FC’s 21–0 victory over Jeunesse Hautcharage in the UEFA Cup Winners’ Cup in 1971 is a record in all European competition.");
            var result = await dialog.ShowAsync();
            BtnQuiz3.Visibility = Visibility.Collapsed;
            BtnLeiYes.Visibility = Visibility.Collapsed;
            BtnLeiNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnLivYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                 "You're Wrong! Liverpool lost the World Club Championship in 2005 to Sao Paulo, after having three goals disallowed for offside.");
            var result = await dialog.ShowAsync();
            BtnQuiz4.Visibility = Visibility.Collapsed;
            BtnLivYes.Visibility = Visibility.Collapsed;
            BtnLivNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnLivNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Correct! Liverpool lost the World Club Championship in 2005 to Sao Paulo, after having three goals disallowed for offside.");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz4.Visibility = Visibility.Collapsed;
            BtnLivYes.Visibility = Visibility.Collapsed;
            BtnLivNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnManCYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "You're Correct! Manchester City scored over a hundred goals in 1957/58, only to concede a 100 goals in the same season.");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz5.Visibility = Visibility.Collapsed;
            BtnManCYes.Visibility = Visibility.Collapsed;
            BtnManCNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnManCNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
               "You're Wrong! Manchester City scored over a hundred goals in 1957/58, only to concede a 100 goals in the same season.");
            var result = await dialog.ShowAsync();
            BtnQuiz5.Visibility = Visibility.Collapsed;
            BtnManCYes.Visibility = Visibility.Collapsed;
            BtnManCNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnManUYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
               "You're Correct! Ryan Giggs, Roy Keane and Peter Schmeichel are in fact the only players in the history of English football to have won three doubles");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz6.Visibility = Visibility.Collapsed;
            BtnManUYes.Visibility = Visibility.Collapsed;
            BtnManUNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnManUNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
               "You're Wrong! Ryan Giggs, Roy Keane and Peter Schmeichel are in fact the only players in the history of English football to have won three doubles");
            var result = await dialog.ShowAsync();
            BtnQuiz6.Visibility = Visibility.Collapsed;
            BtnManUYes.Visibility = Visibility.Collapsed;
            BtnManUNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnSpursYes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
               "You're Right! In 1963 they became the first British club to win a UEFA club competition and were the inaugural winner of the UEFA Cup in 1972, becoming the first British club to win two different major European trophies");
            var result = await dialog.ShowAsync();
            highscore++;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz7.Visibility = Visibility.Collapsed;
            BtnSpursYes.Visibility = Visibility.Collapsed;
            BtnSpursNo.Visibility = Visibility.Collapsed;
        }

        private async void BtnSpursNo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
               "You're Wrong! In 1963 they became the first British club to win a UEFA club competition and were the inaugural winner of the UEFA Cup in 1972, becoming the first British club to win two different major European trophies");
            var result = await dialog.ShowAsync();
            BtnQuiz7.Visibility = Visibility.Collapsed;
            BtnSpursYes.Visibility = Visibility.Collapsed;
            BtnSpursNo.Visibility = Visibility.Collapsed;
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            highscore=0;
            TxtHighscore.Text = highscore.ToString();
            BtnQuiz.Visibility = Visibility.Visible;
            BtnQuiz2.Visibility = Visibility.Visible;
            BtnQuiz3.Visibility = Visibility.Visible;
            BtnQuiz4.Visibility = Visibility.Visible;
            BtnQuiz5.Visibility = Visibility.Visible;
            BtnQuiz6.Visibility = Visibility.Visible;
            BtnQuiz7.Visibility = Visibility.Visible;

        }
    }
}
