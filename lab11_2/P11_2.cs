using System;
using System.Collections.Generic;
using System.Collections;
using Lab10_3;
using System.Linq;

namespace lab11_2
{
    class P11_2
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
            Dictionary<Place, Place> dict = new Dictionary<Place, Place> ();
            dict.Add(place, place);
            dict.Add(place2, area2);
           

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
                int menue = numEnter("Выберите: ", 0, 5);
                if (menue == 0)
                {
                    break;
                }
                int saveNum1, saveNum2;
                string saverName1, saverName2;
                float saverNum;
                switch (menue)
                {
                    case 1:

                        Console.Write("Введите широту в градусах: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                        Console.Write("Введите долготу в градусах: ");
                        saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        try
                        {
                            dict.Add(addedPlace, addedPlace);
                        }
                        catch
                        {
                            Console.WriteLine("Данный элемент уже в коллекции");
                        }
                        break;
                    case 2:
                        Console.Write("Введите широту в градусах: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                        Console.Write("Введите долготу в градусах: ");
                        saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();
                        Console.Write("Введите количество городов в области: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        Console.Write("Введите площадь области в км^2: ");
                        saverNum = (float)numEnterD(Console.ReadLine().ToString());
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        try
                        {
                            dict.Add(addedPlace, addedArea);
                        }
                        catch
                        {
                            Console.WriteLine("Данный элемент уже в коллекции");
                        }

                        break;
                    case 3:
                        Console.Write("Введите широту в градусах: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                        Console.Write("Введите долготу в градусах: ");
                        saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();
                        Console.Write("Введите количество городов в области: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        Console.Write("Введите площадь области в км^2: ");
                        saverNum = (float)numEnterD(Console.ReadLine().ToString());
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        Console.Write("Введите название города: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите население города: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        Console.Write("Введите площадь города в км^2: ");
                        saverNum = (float)numEnterD(Console.ReadLine().ToString());
                        addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                        try
                        {
                            dict.Add(addedPlace, addedCity);
                        }
                        catch
                        {
                            Console.WriteLine("Данный элемент уже в коллекции");
                        }
                        break;
                    case 4:
                        Console.Write("Введите широту в градусах: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                        Console.Write("Введите долготу в градусах: ");
                        saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                        addedPlace = new Place(saveNum1, saveNum2);
                        Console.Write("Введите название области: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите название континента: ");
                        saverName2 = Console.ReadLine().ToString();
                        Console.Write("Введите количество городов в области: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        Console.Write("Введите площадь области в км^2: ");
                        saverNum = (float)numEnterD(Console.ReadLine().ToString());
                        addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                        Console.Write("Введите название мегаполиса: ");
                        saverName1 = Console.ReadLine().ToString();
                        Console.Write("Введите население мегаполиса: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        Console.Write("Введите площадь мегаполиса в км^2: ");
                        saverNum = (float)numEnterD(Console.ReadLine().ToString());
                        addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                        Console.WriteLine("Введите количество агломераций: ");
                        saveNum1 = numEnter(Console.ReadLine().ToString());
                        addedMegapolice = new Megapolice(addedCity, saveNum1);
                        try
                        {
                            dict.Add(addedPlace, addedMegapolice);
                        }
                        catch
                        {
                            Console.WriteLine("Данный элемент уже в коллекции");
                        }
                        break;
                    case 5:
                        Console.WriteLine(@"
1. Добавить аддрес в городе
2. Добавить аддрес в мегаполисе
");
                        int menue2 = numEnter(Console.ReadLine().ToString(), 0, 5);
                        switch (menue2)
                        {
                            case 1:
                                Console.Write("Введите широту в градусах: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                                Console.Write("Введите долготу в градусах: ");
                                saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                                addedPlace = new Place(saveNum1, saveNum2);
                                Console.Write("Введите название области: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите название континента: ");
                                saverName2 = Console.ReadLine().ToString();
                                Console.Write("Введите количество городов в области: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                Console.Write("Введите площадь области в км^2: ");
                                saverNum = (float)numEnterD(Console.ReadLine().ToString());
                                addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                                Console.Write("Введите название города: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите население города: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                Console.Write("Введите площадь города в км^2: ");
                                saverNum = (float)numEnterD(Console.ReadLine().ToString());
                                addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                                Console.Write("Введите название улицы: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите номер улицы: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                addedAddress = new Address(addedCity, saverName1, saveNum1);
                                try
                                {
                                    dict.Add(addedPlace, addedAddress);
                                }
                                catch
                                {
                                    Console.WriteLine("Данный элемент уже в коллекции");
                                }
                                break;
                            case 2:
                                Console.Write("Введите широту в градусах: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString(), -90, +90);
                                Console.Write("Введите долготу в градусах: ");
                                saveNum2 = numEnter(Console.ReadLine().ToString(), -180, +180);
                                addedPlace = new Place(saveNum1, saveNum2);
                                Console.Write("Введите название области: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите название континента: ");
                                saverName2 = Console.ReadLine().ToString();
                                Console.Write("Введите количество городов в области: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                Console.Write("Введите площадь области в км^2: ");
                                saverNum = (float)numEnterD(Console.ReadLine().ToString());
                                addedArea = new Area(addedPlace, saverName1, saverName2, saveNum1, saverNum);
                                Console.Write("Введите название мегаполиса: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите население мегаполиса: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                Console.Write("Введите площадь мегаполиса в км^2: ");
                                saverNum = (float)numEnterD(Console.ReadLine().ToString());
                                addedCity = new City(addedArea, saverName1, saveNum1, saverNum);
                                Console.WriteLine("Введите количество агломераций: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                addedMegapolice = new Megapolice(addedCity, saveNum1);
                                Console.Write("Введите название улицы: ");
                                saverName1 = Console.ReadLine().ToString();
                                Console.Write("Введите номер улицы: ");
                                saveNum1 = numEnter(Console.ReadLine().ToString());
                                addedAddress = new Address(addedMegapolice, saverName1, saveNum1);
                                try
                                {
                                    dict.Add(addedPlace, addedAddress);
                                }
                                catch
                                {
                                    Console.WriteLine("Данный элемент уже в коллекции");
                                }

                                break;

                        }
                        break;

                }
            } while (true);
            Console.WriteLine(@"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
");
            foreach (KeyValuePair<Place, Place> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key.ToString() + " - " + keyValue.Value.ToString());
            }
            Dictionary<Place, Place> dict2 = new Dictionary<Place, Place>();
            foreach (KeyValuePair<Place, Place> keyValue in dict2)
            {
                Place clone1 =(Place) keyValue.Key.Clone();

                if (keyValue.Value is Address)
                {
                    Address clone2 = (Address)keyValue.Value.Clone();
                    dict2.Add(clone1, clone2);
                }
                else if (keyValue.Value is Megapolice)
                {
                    Megapolice clone2 = (Megapolice)keyValue.Value.Clone();
                    dict2.Add(clone1, clone2);
                }
                else if (keyValue.Value is City)
                {
                    City clone2 = (City)keyValue.Value.Clone();
                    dict2.Add(clone1, clone2);
                }

                else if (keyValue.Value is Area)
                {
                    Area clone2 = (Area)keyValue.Value.Clone();
                    dict2.Add(clone1, clone2);
                }
                else if (keyValue.Value is Place)
                {
                    Place clone2 = (Place)keyValue.Value.Clone();
                    dict2.Add(clone1, clone2);
                }
                
            }
            var list = dict.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("Ключ: {0}\nЗначение: {1}", key, dict[key]);
            }
            
            do
            {
                Console.WriteLine("__________________________________________");
                int enter1 = numEnter("Введите широту для поиска", -90,90);
                
                int enter = numEnter("Введите долготу для поиска", -180, 180);
                Place search = new Place(enter1, enter);
                int find = 0;
                foreach (KeyValuePair<Place, Place> keyValue in dict)
                {
                    if (keyValue.Key.Equals(search))
                    {
                        Console.WriteLine("Ключ: {0}\nЗначение: {1}", search, dict[keyValue.Key]);
                        find = 1;
                    }
                }
                if(find == 0)
                {
                    Console.WriteLine($"По ключу {search} ничего не найдено");
                }
            } while (true);
        }
    }
}
