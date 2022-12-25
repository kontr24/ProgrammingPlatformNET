using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Лаб1
{
    public class PowerTools
    {
        /*bool _DeviceClass1()
        {
            bool _DeviceClass1 = true;
            if (_Weight <= 3)
                _DeviceClass1 = false;
          
            return _DeviceClass1;
        }

        private string _DeviceClass;
        public string GetDeviceClass()
        {
                _DeviceClass = _DeviceClass1() ?  "тяжёлый" : "лёгкий";
           
            return _DeviceClass;
        }
        public void SetDeviceClass(string DeviceClass)
        {
            _DeviceClass = DeviceClass;
        }*/

        /*bool _DeviceClass1 = true;

         private string _DeviceClass;
         public string GetDeviceClass()
         {
             if (_DeviceClass1 = _Weight >= 4)
                 _DeviceClass = "тяжёлый";
             else
                 _DeviceClass = "лёгкий";
             return _DeviceClass;
         }
         public void SetDeviceClass(string DeviceClass)
         {
             _DeviceClass = DeviceClass;
         }*/



            private bool _DeviceClass;
            public bool GetDeviceClass()
             {
                 return _Weight < 4;
             }

             public bool SetDeviceClass(bool DeviceClass)
             {
                 return _DeviceClass;
             }


            /*2) private string _DeviceClass;
         public string GetDeviceClass()
             {

                 return _DeviceClass;
             }
             public string SetDeviceClass(string DeviceClass, int Weight)
             {
                 if(Weight<=3)

                 _DeviceClass = "лёгкий";
                 else
                     _DeviceClass = "тяжёлый";
             }*/

        private int _NoiseLevel;
        public int GetNoiseLevel()
        {
            return _NoiseLevel;
        }
        public void SetNoiseLevel(int NoiseLevel)
        {
            _NoiseLevel = NoiseLevel;
        }
        private int _Weight;
        public int GetWeight()
        {
            return _Weight;
        }
        public void SetWeight(int Weight)
        {

            _Weight = Weight;
        }
        private double _Price;
        public double GetPrice()
        {
            return _Price;
        }
        public void SetPrice(double Price)
        {
            _Price = Price;
        }

    }

}
