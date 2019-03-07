using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;
using System.Diagnostics;

namespace BrainCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        int sum = 0;
        int score = 0;
        int highestScore = 0;
        public MainPage()
        {
            InitializeComponent();
            countdown();
            generateNewNumbers();
        }

        public void countdown()
        {

        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (sum.ToString().Length == 1)
            {
                Debug.WriteLine("lengde er 1: " + sum.ToString());
                if (entrySum.Text.Length == 1)
                {
                    doShit();
                }
            }
            else if (sum.ToString().Length == 2)
            {
                Debug.WriteLine("lengde er 2: " + sum.ToString());
                if (entrySum.Text.Length == 2)
                {
                    doShit();
                }
            }
        }

        void doShit()
        {
            if (entrySum.Text == sum.ToString())
            {
                countdownLabel.Text = "Correct!";
                countdownLabel.TextColor = Color.Green;
                ++score;
                scoreLabel.Text = "Score: " + score.ToString();
                if (score > highestScore)
                {
                    highestScore = score;
                    highestScoreLabel.Text = "High score: " + highestScore.ToString();
                }
            }
            else
            {
                score = 0;
                scoreLabel.Text = "Score: " + score.ToString();
                countdownLabel.Text = "Incorrect";
                countdownLabel.TextColor = Color.Red;
            }
            entrySum.Text = "";
            //TODO calculate average answer time
            generateNewNumbers();
        }

        void generateNewNumbers()
        {
            var randomNumberOne = new Random().Next(20);
            var randomNumberTwo = new Random().Next(19);
            while (randomNumberOne == randomNumberTwo)
            {
                randomNumberOne = new Random().Next(19);
                randomNumberTwo = new Random().Next(20);
            }
            numberLabel.Text = randomNumberOne.ToString() + " + " + randomNumberTwo.ToString();
            sum = randomNumberOne + randomNumberTwo;
            //TODO start timer
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
