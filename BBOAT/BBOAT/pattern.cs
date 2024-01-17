using System;

namespace BBOAT
{
    public abstract class Boat
    {
        public string BoatName { get; set; }
        public abstract int MaxSpeed { get; set; }
        public abstract string GetBoatType();
    }

    public abstract class BoatDecorator : Boat
    {
        protected Boat boat;

        public BoatDecorator(Boat boat)
        {
            this.boat = boat;
        }

        public override int MaxSpeed
        {
            get { return boat.MaxSpeed; }
            set { boat.MaxSpeed = value; }
        }

        public override string GetBoatType()
        {
            return boat.GetBoatType();
        }

        public abstract int CurrentSpeed { get; set; }
    }

    public class SpeedDecorator : BoatDecorator
    {
        private int currentSpeed;

        public override int MaxSpeed
        {
            get { return boat.MaxSpeed; }
            set
            {
                boat.MaxSpeed = value < 4 ? 4 : value;
            }
        }

        public SpeedDecorator(Boat boat) : base(boat)
        {
            currentSpeed = new Random().Next(4, MaxSpeed + 1);
        }

        public override int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
    }

    public class Type1Boat : Boat
    {
        private int maxSpeed;

        public override int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value < 4 ? 4 : value; }
        }

        public Type1Boat(string name, int speed)
        {
            BoatName = name;
            MaxSpeed = speed;
        }

        public override string GetBoatType()
        {
            return "Швидкий катер";
        }
    }

    public class Type2Boat : Boat
    {
        private int maxSpeed;

        public override int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value < 4 ? 4 : value; }
        }

        public Type2Boat(string name, int speed)
        {
            BoatName = name;
            MaxSpeed = speed;
        }

        public override string GetBoatType()
        {
            return "Катер";
        }
    }

    public class Type3Boat : Boat
    {
        private int maxSpeed;

        public override int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value < 4 ? 4 : value; }
        }

        public Type3Boat(string name, int speed)
        {
            BoatName = name;
            MaxSpeed = speed;
        }

        public override string GetBoatType()
        {
            return "Спортивний катер";
        }
    }
}
