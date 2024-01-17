using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BBOAT
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Random random;
        private List<Boat> boats;
        private Boat currentBoat;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            boats = new List<Boat>
            {
                new Type1Boat("Швидкий катер", 40),
                new Type2Boat("Катер", 20),
                new Type3Boat("Спортивний катер", 60)
            };
            Load += Form1_Load;
            StartAnimation();
        }

        private void StartAnimation()
        {
            currentBoat = new SpeedDecorator(boats[random.Next(boats.Count)]);
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
            DisplayRandomImage();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int boatSpeed = ((SpeedDecorator)currentBoat).CurrentSpeed;
            int pictureBoxSpeed = boatSpeed / 2;
            pictureBox2.Left += pictureBoxSpeed;
            if (pictureBox2.Left >= 1600)
            {
                pictureBox2.Left = 0;
                timer.Stop();
                StartAnimation();
            }
        }

        private void DisplayBoatInfo(Boat boat)
        {
            labelBoat.Text = $"Тип катера: {boat.GetBoatType()}";
            labelMaxSpeed.Text = $"Максимальна швидкість: {boat.MaxSpeed} км/год";
        }

        private void DisplayCurrentSpeed(Boat boat)
        {
            labelSpeed.Text = $"Швидкість: {((SpeedDecorator)boat).CurrentSpeed} км/год";
        }

        private void DisplayRandomImage()
        {
            string boatType = currentBoat.GetBoatType();
            switch (boatType)
            {
                case "Швидкий катер":
                    pictureBox2.Image = Properties.Resources._1;
                    break;
                case "Катер":
                    pictureBox2.Image = Properties.Resources._2;
                    break;
                case "Спортивний катер":
                    pictureBox2.Image = Properties.Resources._3;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonMax.Click += ButtonMax_Click;
            ButtonMin.Click += ButtonMin_Click;
        }

        private void ButtonSpeedPlus_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = Math.Min(currentBoat.MaxSpeed, ((SpeedDecorator)currentBoat).CurrentSpeed + 1);
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }

        private void ButtonSpeedMinus_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = Math.Max(0, ((SpeedDecorator)currentBoat).CurrentSpeed - 1);
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }

        private void ButtonPlusPlus_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = Math.Min(currentBoat.MaxSpeed, ((SpeedDecorator)currentBoat).CurrentSpeed + 5);
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }

        private void ButtonMinusMinus_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = Math.Max(0, ((SpeedDecorator)currentBoat).CurrentSpeed - 5);
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = currentBoat.MaxSpeed;
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            ((SpeedDecorator)currentBoat).CurrentSpeed = 0;
            DisplayBoatInfo(currentBoat);
            DisplayCurrentSpeed(currentBoat);
        }
    }
}
