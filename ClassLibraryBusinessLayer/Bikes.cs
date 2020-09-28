using ClassLibraryBusinessLayer.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBusinessLayer
{
    [System.Xml.Serialization.XmlInclude(typeof(MountainBikes))]
    [System.Xml.Serialization.XmlInclude(typeof(RoadBikes))]
    [Serializable]
    public abstract class Bikes : IMovable
    {
        protected long serNum;
        protected string make;
        protected double speed;
        protected EnumColor color;
        protected int year;
        protected float price;

        public long SerNum{get => serNum; set => serNum = value;}

        //public string Make { get => make; set => make = value; }
        //public double Speed { get => speed; set => speed = value; }
        //public EnumColor Color { get => color; set => color = value; }
        //public int Year { get => year; set => year = value; }
        //public float Price { get => price; set => price = value; }



        public Bikes() { }
     
       public Bikes(long id, string mk, double sp, int yyyy, float pr)
        {
            this.serNum = id;
            this.make = mk;
            this.speed = sp;
            this.color = EnumColor.Undefined;
            this.year = yyyy;
            this.price = pr;
        }

        public Bikes(long serNum, string make, double speed, EnumColor color, int yyyy, float prce)
        {
            this.serNum = serNum;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.year = yyyy;
            this.price = prce;
        }

        public virtual double GetMaxSpeed()
        {
            return 0.00;
        }

        public abstract void SpeedUp(double newSpeed);

        public override string ToString()
        {
            return "\nSer Num: " + this.serNum + " -- Made: " + this.make  + " -- Speed: " + this.speed + " km/hr" + " -- Color: " + this.color + 
                 " -- Year: " + this.year + " -- Price: $" + this.price;
        }
    }
}
