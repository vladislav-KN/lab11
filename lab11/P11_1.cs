using System;
using System.Collections;
using System.Collections.Generic;
using Lab10_3;

namespace lab11
{
    class P11_1
    {
        static int numEnter(string str, int num1 = 0, int num2 = 100000)
        {
            bool ok;
            int num;
            do
            {
                Console.Write(str + " ");
                ok = int.TryParse(Console.ReadLine(), out num);
                if ((num1 != 1 || num2 != 4 || num2 != 3 || num2 != 5) && (!ok || num < num1 || num > num2))
                {
                    Console.WriteLine($"Число введено с ошибкой, либо вышло за допустимые пределы (от {num1} до {num2})");
                    ok = false;
                }
                else if (num < 1 && num > 5)
                {
                    Console.WriteLine("Пожалуйста выберете пункт из перечисленного меню");
                    ok = false;
                }
            } while (!ok);
            return num;
        }
        static double numEnterD(string str, int num1 = 0, int num2 = 100000)
        {
            bool ok;
            double num;
            do
            {
                Console.Write(str + " ");
                ok = double.TryParse(Console.ReadLine(), out num);
                if ((num1 != 1 || num2 != 4 || num2 != 3 || num2 != 5) && (!ok || num < num1 || num > num2))
                {
                    Console.WriteLine($"Число введено с ошибкой, либо вышло за допустимые пределы (от {num1} до {num2})");
                    ok = false;
                }
                else if (num < 1 && num > 5)
                {
                    Console.WriteLine("Пожалуйста выберете пункт из перечисленного меню");
                    ok = false;
                }
            } while (!ok);
            return num;
        }

        static void Main(string[] args)
        {

            Place addedPlace;
            Area addedArea;
            City addedCity;
            Megapolice addedMegapolice;
            Address addedAddress;
            Place place = new Place(90, 65);
            Area area = new Area(place, "Пермский край", "Европа", 25, 160600);
            City city = new City(area, "Пермь", 1053938, 803);
            Place place2 = new Place(12, 14);
            City city1 = new City(area, "Кунгур", 66074, 68.7f);
            City city3 = new City(area, "Соликамск", 95500, 166.6f);
            City city4 = new City(area, "Березники", 141276, 66);
            Area area2 = new Area(place2, "Свердловская область", "Европа", 47, 194800);
            City city2 = new City(area2, "Екатеринбург", 1453938, 468);
            Area area3 = new Area(place, "Гуандун", "Азия", 30, 177900);
            City city5 = new City(area3, "Цинъюань", 3660000, 19152);
            Megapolice megapolice = new Megapolice(city2, 1);
            Address address = new Address(city, "Пушкина", 14);
            Address address2 = new Address(megapolice, "Пушкина", 16);
            //Задание 1
            ArrayList list1 = new ArrayList { place, city2, city, area3, city1, place2, city3, city4, city5 };
            do
            {
                Console.WriteLine(@"Меню:

1. Добавить Координаты
2. Добавить Область
3. Добавить Город
4. Добавить Мегаполис
5. Добавить Адрес
0. Выход
");
                int menue =  numEnter("Выберите: ",0,5);
                if(menue == 0)
                {
                    break;
                }
                int saveNum1,saveNum2;
                string saverName1, saverName2;
                float saverNum;
                switch (menue)
                {
                    case 1:

                        saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                        saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        list1.Add(addedPlace);
                        break;
                    case 2:
                        saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                        saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();
                       
                        saveNum1 = numEnter("Введите количество городов в области: ");
                        saverNum = (float)numEnterD("Введите площадь области в км^2: ");
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        list1.Add(addedArea);
                        
                        break;
                    case 3:
                        saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                        saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();

                        saveNum1 = numEnter("Введите количество городов в области: ");
                        saverNum = (float)numEnterD("Введите площадь области в км^2: ");
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        Console.Write("Введите название города: ");
                        saverName1 = Console.ReadLine().ToString();
                    
                        saveNum1 = numEnter("Введите население города: ");
                        
                        saverNum = (float)numEnterD("Введите площадь города в км^2: ");
                        addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                        list1.Add(addedCity);
                        
                        break;
                    case 4:
                        saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                        saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();

                        saveNum1 = numEnter("Введите количество городов в области: ");
                        saverNum = (float)numEnterD("Введите площадь области в км^2: ");
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        Console.Write("Введите название города: ");
                        saverName1 = Console.ReadLine().ToString();

                        saveNum1 = numEnter("Введите население города: ");

                        saverNum = (float)numEnterD("Введите площадь города в км^2: ");
                        addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                        Console.WriteLine("Введите количество агломераций: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        addedMegapolice = new Megapolice(addedCity, saveNum1);

                        list1.Add(addedMegapolice);
                        
                        break;
                    case 5:
                        Console.WriteLine(@"
1. Добавить аддрес в городе
2. Добавить аддрес в мегаполисе
");
                        int menue2 = numEnter(Console.ReadLine().ToString(), 0, 5);
                        switch (menue2){
                            case 1:
                                saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                                saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                                addedPlace = new Place(saveNum1, saveNum2);
                                Console.Write("Введите название области: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите название континента: ");
                                saverName2 = Console.ReadLine().ToString();

                                saveNum1 = numEnter("Введите количество городов в области: ");
                                saverNum = (float)numEnterD("Введите площадь области в км^2: ");
                                addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                                Console.Write("Введите название города: ");
                                saverName1 = Console.ReadLine().ToString();

                                saveNum1 = numEnter("Введите население города: ");

                                saverNum = (float)numEnterD("Введите площадь города в км^2: ");
                                addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                                Console.Write("Введите название улицы: ");
                                saverName1 = Console.ReadLine().ToString();
                                saveNum1 = numEnter("Введите номер улицы: ");
                                addedAddress = new Address(addedCity, saverName1, saveNum1);
                                list1.Add(addedAddress);
                                
                                break;
                            case 2:
                                saveNum1 = numEnter("Введите широту в градусах: ", -90, +90);
                                saveNum2 = numEnter("Введите долготу в градусах: ", -180, +180);
                                addedPlace = new Place(saveNum1, saveNum2);
                                Console.Write("Введите название области: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите название континента: ");
                                saverName2 = Console.ReadLine().ToString();

                                saveNum1 = numEnter("Введите количество городов в области: ");
                                saverNum = (float)numEnterD("Введите площадь области в км^2: ");
                                addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                                Console.Write("Введите название города: ");
                                saverName1 = Console.ReadLine().ToString();

                                saveNum1 = numEnter("Введите население мегаполиса: ");

                                saverNum = (float)numEnterD("Введите площадь мегаполиса в км^2: ");
                                addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                                
                                saveNum1 = numEnter("Введите количество агломераций: ");
                                addedMegapolice = new Megapolice(addedCity, saveNum1);
                                Console.Write("Введите название улицы: ");
                                saverName1 = Console.ReadLine().ToString();
                                
                                saveNum1 = numEnter("Введите номер улицы: ");
                                addedAddress = new Address(addedMegapolice, saverName1, saveNum1);
                                list1.Add(addedAddress);
                                
                                break;

                        }
                        break;

                }
            } while (true);
            Console.WriteLine(@"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
");
            foreach (IExecutable tmp in list1)
                tmp.Show();
            Console.WriteLine(@"
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            ArrayList list1Clone = (ArrayList)list1.Clone();
            list1.Sort();
            Console.WriteLine(@"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
");
            foreach (IExecutable tmp in list1)
                tmp.Show();
            Console.WriteLine(@"
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            do
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(@"Введите параметр поиска
Введите 0 для выхода");
                string enter = Console.ReadLine();
                if (enter == "0") break;
                Console.WriteLine("__________________________________________");

                foreach (IExecutable obj in list1)
                {
                    if (obj is Address)
                    {
                        Address tmp = (Address)obj;
                        if (tmp.StreatName == enter)
                        {
                            tmp.Show();
                            break;
                        }
                    }
                    else if (obj is Megapolice)
                    {
                        Megapolice tmp = (Megapolice)obj;
                        if (tmp.NameOfCity == enter)
                        {
                            tmp.Show();
                            break;
                        }
                    }
                    else if (obj is City)
                    {
                        City tmp = (City)obj;
                        if (tmp.NameOfCity == enter)
                        {
                            tmp.Show();
                            break;
                        }
                    }

                    else if (obj is Area)
                    {
                        Area tmp = (Area)obj;
                        if (tmp.NameOfArea == enter)
                        {
                            tmp.Show();
                            break;
                        }
                    }
                    else if (obj is Place)
                    {
                        Place tmp = (Place)obj;
                        if (tmp.Latitude.ToString() == enter || tmp.Longitude.ToString() == enter)
                        {
                            tmp.Show();
                            break;
                        }
                    }

                }
            } while (true);
            //Задание 2





        }
    }

}
