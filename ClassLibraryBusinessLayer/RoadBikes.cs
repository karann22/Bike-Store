using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessLayer.Bus
{
    public class RoadBikes : Bikes
    {
        private double seatHeight;
        private double weight;
        private double newSpeed;

        public double SeatHeight { get => seatHeight; set => seatHeight = value; }
        public double Weight { get => weight; set => weight = value; }
        public double NewSpeed { get => newSpeed; set => newSpeed = value; }

        public string Make { get => make; set => make = value; }
        public double Speed { get => speed; set => speed = value; }
        public EnumColor Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public float Price { get => price; set => price = value; }

        public RoadBikes() : base() { }


        public RoadBikes(long serNum, string make, double speed, EnumColor color, int year, float price, double stHght, double wght, double nwspd) :
            base(serNum, make, speed, color, year, price)
        {
            this.serNum = serNum;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.year = year;
            this.price = price;
            this.seatHeight = stHght;
            this.weight = wght;
            this.newSpeed = nwspd;
        }

        public override string ToString()
        {
            return base.ToString() + " -- Road Bikes -- Seat Height: " + this.seatHeight + "in -- Weight: " + this.weight
                + "kg -- New Speed: " + this.GetMaxSpeed() + " km/hr";
        }


        public override void SpeedUp(double newSpeed) => GetMaxSpeed();

        public override double GetMaxSpeed()
        {
            if ((this.speed + newSpeed) < 40)
            {
                this.speed += this.newSpeed;
            }

            else
            {
                this.speed = this.newSpeed;
            }

            return this.speed;

        }
    }
}
