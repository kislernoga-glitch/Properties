using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public abstract class Drinks
    {
        public string name { get; set; }
        private int price;

        public int Price
        {
            get { return price; }
            set { if (price > 0) { price = value; } }
        }

       

        
        private int volume;
        public int Volume
        {
            get { return volume; }
            set { if(volume > 50 && volume< 1500) { volume = value; } }
        }

        public Drinks(string name, int price, int volume)
        {
            this.name = name;
            this.price = price;
            this.volume = volume;
        }

        //חלק א: טיפוס אבסטרקטי
    }

    public abstract class HotDrinks : Drinks
    {
        private double temp;

        public double Temp
        {
            get { return temp; }
            set { if(value>30 && value<90) temp = value; }
        }

        public virtual double priceTip()
        {
            return price * 1.1;
        }


    }

    public abstract class Espresso : HotDrinks
    {
        public int Amount { get; set; }
    }

    public abstract class Afugato : Espresso
    {
        private int scoop;
        public int Scoop
        {
            get { return Scoop; }
            set { if(value>=1) Scoop = value; }
        }

        public override double priceTip()
        {
            return base.priceTip +5*scoop;
        }

    }






}
