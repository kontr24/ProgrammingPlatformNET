using System;
using System.Collections.Generic;
using System.Text;

namespace Лабор2
{
    public class Shop
    {
        private List<Drill> _products;

        public List<Drill> Products
        {
            get
            {
                return _products;
            }

            set
            {
                _products = value;
            }
        }

        public void ShowDrills()
        {
            foreach (Drill p in _products)
            {
                Console.WriteLine(p);
            }

        }

        public abstract class Sorter
        {
            //0: равны, -1: X меньше Y, 1: X больше Y
            public abstract int Compare(Drill X, Drill Y);

            public virtual void Sort(List<Drill> list)
            {

                list.Sort(Compare);

            }
        }



        public class CompanySorter : Sorter //1. 
        {
            public override int Compare(Drill X, Drill Y)
            {
                return String.Compare(X.GetCompany(), Y.GetCompany());

            }


        }


        public class MechanismTypeSorter : Sorter //2. Пузырьковая сортировка +
        {
            public override int Compare(Drill X, Drill Y)
            {
                if (X.GetMechanismType() > Y.GetMechanismType())
                {
                    return 1;
                }
                else
                if (X.GetMechanismType() < Y.GetMechanismType())
                {
                    return -1;
                }
                return 0;
            }

            public override void Sort(List<Drill> drill)
            {
                for (int j = 0; j < drill.Count; j++)
                {
                    for (int i = 0; i < drill.Count - 1; i++)
                    {

                        if (Compare(drill[i], drill[j]) == 1)
                        {
                            Drill temp = drill[i];
                            drill[i] = drill[j];
                            drill[j] = temp;
                        }

                    }


                }
            }
        }



        public class DeviceClassSorter : Sorter //3. Сортировка Шелла +
        {

            public override int Compare(Drill X, Drill Y)
            {
                if (X.GetDeviceClass() == Y.GetDeviceClass())
                {
                    return 0;
                }
                else
                    return 1;

            }

            public override void Sort(List<Drill> list)
            {
                int i, j, k;
                Drill t;
                for (k = list.Count / 2; k > 0; k /= 2)
                    for (i = k; i < list.Count; i++)
                    {
                        t = list[i];
                        for (j = i; j >= k; j -= k)
                        {
                            if (Compare(t, list[j - k]) == 1)
                                list[j] = list[j - k];
                            else
                                break;
                        }
                        list[j] = t;

                    }
            }


        }

        public class NoiseLevelSorter : Sorter //4. X +
        {
            public override int Compare(Drill X, Drill Y)
            {


                if (X.GetNoiseLevel() < Y.GetNoiseLevel())
                {

                    return 1;
                }

                if (X.GetNoiseLevel() > Y.GetNoiseLevel())
                {
                    return -1;
                }
                else
                    return 0;

            }


            public override void Sort(List<Drill> list)
            {
                list.Sort(Compare);
            }
        }

        public class WeightSorter : Sorter //5. Глупая сортировка +
        {
            public override int Compare(Drill X, Drill Y)
            {
                if (X.GetWeight() < Y.GetWeight())
                {
                    return -1;
                }

                if (X.GetWeight() > Y.GetWeight())
                {
                    return 1;
                }
                else
                    return 0;
            }


            public override void Sort(List<Drill> list)
            {
                int i = 0;
                Drill tmp;
                while (i < list.Count - 1)
                {
                    int compare = Compare(list[i + 1], list[i]);
                    if (compare == 1)
                    {
                        tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                        i = 0;
                    }
                    else i++;

                }
            }
        }

        public class PriceSorter : Sorter //6. Сортировка выбором +
        {
            public override int Compare(Drill X, Drill Y)
            {
                if (X.GetPrice() < Y.GetPrice())
                {
                    return -1;
                }

                if (X.GetPrice() > Y.GetPrice())
                {
                    return 1;
                }
                else
                    return 0;
            }


            public override void Sort(List<Drill> list)
            {

                Drill temp;
                for (int i = 0; i < list.Count; i++)
                {
                    int minValueIndex = i;

                    for (int j = i + 1; j < list.Count; j++)
                    {

                        if (Compare(list[minValueIndex], list[j]) == 1)
                        {
                            minValueIndex = j;
                        }
                    }
                    temp = list[i];
                    list[i] = list[minValueIndex];
                    list[minValueIndex] = temp;

                }

            }
        }


        public void CompanySort()
        {
            CompanySorter sort = new CompanySorter();
            sort.Sort(_products);

            ShowDrills();
        }


        public void MechanismTypeSort()
        {

            MechanismTypeSorter sort = new MechanismTypeSorter();
            sort.Sort(_products);
            ShowDrills();
        }

        public void DeviceClassSort()
        {
            DeviceClassSorter sort = new DeviceClassSorter();
            sort.Sort(_products);
            ShowDrills();
        }

        public void NoiseLevelSort()
        {
            NoiseLevelSorter sort = new NoiseLevelSorter();
            sort.Sort(_products);
            ShowDrills();
        }

        public void WeightSorterSort()
        {
            WeightSorter sort = new WeightSorter();
            sort.Sort(_products);
            ShowDrills();
        }

        public void PriceSort()
        {
            PriceSorter sort = new PriceSorter();
            sort.Sort(_products);
            ShowDrills();
        }

    }
}

/*Drill p = list[(last - first) / 2 + first];
               Drill temp;
               int i = first, j = last;
               while (i <= j)
               {
                   while (list[i].GetNoiseLevel() < p.GetNoiseLevel() && i <= last) ++i;
                   while (list[j].GetNoiseLevel() > p.GetNoiseLevel() && j >= first) --j;
                   if (i <= j)
                   {
                       temp = list[i];
                       list[i] = list[j];
                       list[j] = temp;
                       ++i; --j;
                   }
               }
               if (j > first) Sort(list, first, j);
               if (i < last) Sort(list, i, last);*/




/*public class Sorter2 : Sorter
       {
           public override int Compare(Drill X, Drill Y)
           {
               /*for (X.GetNoiseLevel() = 0; X.GetNoiseLevel() < Drill.Length; X.GetNoiseLevel()++)
               {
                   for (Y.GetNoiseLevel() = X.GetNoiseLevel() + 1; Y.GetNoiseLevel() < Drill.Length; Y.GetNoiseLevel()++)
                   {
                       if (Drill [Y.GetNoiseLevel()] < Drill[X.GetNoiseLevel()])
                       {
                           var temp = Drill[X.GetNoiseLevel()];
                           Drill[X.GetNoiseLevel()] = Drill[Y.GetNoiseLevel()];
                           Drill[Y.GetNoiseLevel()] = temp;
                       }
                   }
               }
               throw new NotImplementedException();
           }
       }*/

/* Drill p = Grouplist[(Y.GetWeight() - X.GetWeight()) / 2 + X.GetWeight()];
               Drill temp;
               int i = X.GetWeight(), j = Y.GetWeight();
               while (i <= j)
               {
                   while (Grouplist[i].Name_sub < p.Name_sub && i <= Y.GetWeight()) ++i;
                   while (Grouplist[j].Name_sub > p.Name_sub && j >= X.GetWeight()) --j;
                   if (i <= j)
                   {
                       temp = Grouplist[i];
                       Grouplist[i] = Grouplist[j];
                       Grouplist[j] = temp;
                       ++i; --j;
                   }
               }
               if (j > X.GetWeight()) sorting(Grouplist, X.GetWeight(), j);
               if (i < Y.GetWeight()) sorting(Grouplist, i, Y.GetWeight());*/