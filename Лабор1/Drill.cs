namespace Лаб1
{
    public class Drill : PowerTools
    {
        View _View;

        private string _Company;
        public string GetCompany()
        {
            return _Company;
        }
        public void SetCompany(string Company)
        {
            _Company = Company;
        }

        public View GetView()
        {
            return _View;
        }
        public void SetView(View view)
        {
            _View = view;
        }
        /*public bool DeviceClass(float Weight)
        {
            if (Weight =< 3)
            {
                return true
                    }
            else
            {
                return false
                     }
        }*/
 
       
        public Drill(string Company, View view, bool DeviceClass, int NoiseLevel, int Weight, double Price)
        {
            SetCompany(Company);  //Производитель
            SetView(view); // вид
            SetDeviceClass(DeviceClass); //класс прибора
            SetNoiseLevel(NoiseLevel); //уровень шума(Дб)
            SetWeight(Weight); //вес
            SetPrice(Price); //цена
        }
        public override string ToString()
        {

            return GetCompany() + "\t|" + GetView() + "\t|" + (GetDeviceClass() ? "лёгкий" : "тяжёлый") + "    \t|" + GetNoiseLevel() + "\t|" + GetWeight() + "\t|" + GetPrice();
            /*return String.Format("{{0, -20}}}|"+_Company)  /*+ _DeviceClass + "\t" + _NoiseLevel + "\t" + _Weight + "\t" + "\t" + _Price;
            return _Company + "\t" + _View  + _DeviceClass + "\t" + _NoiseLevel + "\t" + _Weight + "\t" + "\t" + _Price;*/
        }

    }
    public enum View
    {
        ударный = 1,
        безударный = 2
        /*
        PowerOutput, //Мощность (Вт)
        DeviceClass, //Класс прибора (лёгкий, тежёлый)
        Weight, // Вес (кг)
        NoiseLevel // Уровень шума (Дб)
        */
    }
}
