using System;

namespace ConstructorDemo
{
    class Car
    {
        string carname, carSeries;
        int price;
        double milage,speed;
        public Car() { }
        public Car(string carname,string carSeries)
        {
            this.carname = carname;
            this.carSeries = carSeries;
        }
        public Car(string carname, string carSeries, double speed)
        {
            this.carname = carname;
            this.carSeries = carSeries;
            this.speed = speed;
        }
        public Car(string carname, string carSeries, int price, double milage, double speed)
        {
            this.carname = carname;
            this.carSeries = carSeries;
            this.price = price;
            this.milage = milage;
            this.speed = speed;
               
        }
        public string showCar()
        {
           
            return string.Format("Car Name is:{0} \n  Car Series is:{1} \n Car Price is:{2} \n Car Milage is:{3} Car Speed is:{4}" ,carname,carSeries,price,milage,speed);
        }
      
    }
}
