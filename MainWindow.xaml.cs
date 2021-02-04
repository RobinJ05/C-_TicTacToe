using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string CurrentUser;

        public MainWindow()
        {
            InitializeComponent();
            this.CurrentUser = "X";
        }



        public void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content == null)
            {
                if (CurrentUser == "X")
                {
                    CurrentUser = "O";
                    display_label.Content = "X ist am setzen.";
                }
                else
                {
                    CurrentUser = "X";
                    display_label.Content = "O ist am setzen.";
                }
                button.Content = CurrentUser;
                CheckIfWon();
            }

            if(
                Button11.Content != null &&
                Button12.Content != null &&
                Button13.Content != null &&
                Button21.Content != null &&
                Button22.Content != null &&
                Button23.Content != null &&
                Button31.Content != null &&
                Button32.Content != null &&
                Button33.Content != null)

            {
                Button11.IsEnabled = false;
                Button12.IsEnabled = false;
                Button13.IsEnabled = false;
                Button21.IsEnabled = false;
                Button22.IsEnabled = false;
                Button23.IsEnabled = false;
                Button31.IsEnabled = false;
                Button32.IsEnabled = false;
                Button33.IsEnabled = false;
            }
            
        }



        public void CheckIfWon()
        {
            if( Button11.Content == CurrentUser &&
                Button12.Content == CurrentUser && 
                Button13.Content == CurrentUser ||

                Button11.Content == CurrentUser &&
                Button22.Content == CurrentUser &&
                Button33.Content == CurrentUser ||

                Button11.Content == CurrentUser &&
                Button21.Content == CurrentUser &&
                Button31.Content == CurrentUser ||

                Button12.Content == CurrentUser &&
                Button22.Content == CurrentUser &&
                Button32.Content == CurrentUser ||

                Button13.Content == CurrentUser &&
                Button23.Content == CurrentUser &&
                Button33.Content == CurrentUser ||

                Button13.Content == CurrentUser &&
                Button22.Content == CurrentUser &&
                Button31.Content == CurrentUser ||

                Button21.Content == CurrentUser &&
                Button22.Content == CurrentUser &&
                Button23.Content == CurrentUser ||

                Button31.Content == CurrentUser &&
                Button32.Content == CurrentUser &&
                Button33.Content == CurrentUser
                )
            {
                display_label.Content = $"{CurrentUser} gewinnt.";

                Button11.IsEnabled = false;
                Button12.IsEnabled = false;
                Button13.IsEnabled = false;
                Button21.IsEnabled = false;
                Button22.IsEnabled = false;
                Button23.IsEnabled = false;
                Button31.IsEnabled = false;
                Button32.IsEnabled = false;
                Button33.IsEnabled = false;
            }
        }
        
        

        public void Restart_Clicked(object sender, EventArgs e)
        {
            CurrentUser = "O";
            display_label.Content = "X ist am setzen";

            Button11.Content = null;
            Button12.Content = null;
            Button13.Content = null;
            Button21.Content = null;
            Button22.Content = null;
            Button23.Content = null;
            Button31.Content = null;
            Button32.Content = null;
            Button33.Content = null;

            Button11.IsEnabled = true;
            Button12.IsEnabled = true;
            Button13.IsEnabled = true;
            Button21.IsEnabled = true;
            Button22.IsEnabled = true;
            Button23.IsEnabled = true;
            Button31.IsEnabled = true;
            Button32.IsEnabled = true;
            Button33.IsEnabled = true;
        }



        public void EndBtn_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
