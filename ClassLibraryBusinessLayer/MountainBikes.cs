using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessLayer.Bus
{
    public class MountainBikes : Bikes
    {
        private double height;
        private EnumSuspension suspension;
        private EnumHeadlight headlight;
        private double newSpeed;

        public double Height { get => height; set => height = value; }
        public EnumSuspension Suspension { get => suspension; set => suspension = value; }
        public EnumHeadlight Headlight { get => headlight; set => headlight = value; }
        public double NewSpeed { get => newSpeed; set => newSpeed = value; }

        public string Make { get => make; set => make = value; }
        public double Speed { get => speed; set => speed = value; }
        public EnumColor Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public float Price { get => price; set => price = value; }

        public MountainBikes() : base() { }
        //public MountainBikes() : base()
        //{
        //    this.height = 0;
        //    this.suspension = EnumSuspension.Undefined;
        //    this.headlight = EnumHeadlight.Undefined;
        //    this.newSpeed = 0;
        //}

        public MountainBikes(long serNum, string make, double speed, EnumColor color, int year, float price, double hght, EnumSuspension sus, EnumHeadlight hd, double nwSpd) :
            base(serNum, make, speed, color, year, price)
        {
            this.serNum = serNum;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.year = year;
            this.price = price;
            this.suspension = sus;
            this.headlight = hd;
            this.height = hght;
            this.suspension = sus;
            this.newSpeed = nwSpd;
        }

        public override string ToString()
        {
            return base.ToString() + " -- Mountain Bikes --Height: " + this.height + "ft -- Suspension: " + this.suspension + 
                " -- Headlight: " + this.headlight + " -- New Speed: " + this.GetMaxSpeed() + " km/hr";
        }

        public override void SpeedUp(double newSpeed) => GetMaxSpeed();

        public override double GetMaxSpeed()
        {
            if ((this.speed + newSpeed) < 20)
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
