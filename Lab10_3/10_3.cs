using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lab10_3
{
   public class P10_3
    {
        public static int numEnter(string str, int num1 = 0, int num2 = 100000)
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
        public static void Main(string[] args)
        {
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
            IExecutable[] mass1 = new IExecutable[] { place, city2, city, area3, city1, place2, city3, city4, city5 };
             
            foreach (IExecutable obj in mass1)
            {
                if (obj is Address)
                {
                    Address tmp = (Address)obj;
                    tmp.Show();
                }
                else if (obj is Megapolice)
                {
                    Megapolice tmp = (Megapolice)obj;
                    tmp.Show();
                }
                else if (obj is City)
                {
                    City tmp = (City)obj;
                    tmp.Show();
                }

                else if (obj is Area)
                {
                    Area tmp = (Area)obj;
                    tmp.Show();
                }
                else if (obj is Place)
                    obj.Show();
                Console.WriteLine("__________________________________________");
            }
            Console.WriteLine("############################");
            Array.Sort(mass1);
            foreach (IExecutable obj in mass1)
            {
                if (obj is Address)
                {
                    Address tmp = (Address)obj;
                    tmp.Show();
                }
                else if (obj is Megapolice)
                {
                    Megapolice tmp = (Megapolice)obj;
                    tmp.Show();
                }
                else if (obj is City)
                {
                    City tmp = (City)obj;
                    tmp.Show();
                }

                else if (obj is Area)
                {
                    Area tmp = (Area)obj;
                    tmp.Show();
                }
                else if (obj is Place)
                    obj.Show();
                Console.WriteLine("__________________________________________");
            }
            do
            {
                Console.WriteLine("__________________________________________");
                Console.WriteLine(@"Введите параметр поиска
Введите 0 для выхода");
                string enter = Console.ReadLine();
                if (enter == "0") break;
                Console.WriteLine("__________________________________________");

                foreach (IExecutable obj in mass1)
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
            City clone = city2.ShallowCopy();
            City clone2 = (City)city2.Clone();
            clone.Show();
            clone2.Show();
            Console.ReadKey();

        }
    }

    public interface IExecutable: ICloneable
    {
        public void Show();
        
    }
    public class Place:IExecutable, IComparable 
    {
        internal float latitude,
              longitude;
        public override string ToString()
        {
            string ret = "Координаты: ";
            if (latitude > 0)
            {
                ret += "+" + latitude + "°ш, ";
            }
            else
            {
                ret += latitude + "°ш, ";
            }
            if (latitude > 0)
            {
                ret += "+" + longitude + "°д";
            }
            else
            {
                ret += longitude + "°д";
            }
            return ret;

        }
        public float Latitude
        {
            get { return latitude; }
            set
            {
                if (value >= -90 && value <= 90)
                    latitude = value;
                else
                    Console.WriteLine("Широта может быть больше -180 и меньше 180");
            }
        }
        public float Longitude
        {
            get { return longitude; }
            set
            {
                if (value >= -180 && value <= 180)
                    longitude = value;
                else
                    Console.WriteLine("Долгота может быть больше -180 и меньше 180");
            }
        }
        public Place(float la, float lo)
        {
            if (la <= 90 && la >= -90 && lo <= 180 && lo >= -180)
            {
                latitude = la;
                longitude = lo;
            }
            else
            {
                Console.WriteLine("Выход за пределы допустимых значений");
            }
        }
        public Place()
        {
            Random rnd = new Random();
            latitude = rnd.Next(-90,91);
            longitude = rnd.Next(-180, 181);
        }
        virtual public void Show()
        {
            Console.WriteLine($"Координаты места: Ш.{latitude}°, Д.{longitude}°");
        }
        virtual public int CompareTo(object ex)
        {
            Place pl1 = (Place)this;
            Place pl2 = (Place)ex;
            if (pl1.Latitude > pl2.Latitude) 
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 1;
                else
                    return -1;
            }
            else if(pl1.Latitude == pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (pl1.Longitude < pl2.Longitude)
                    return -1;
                else if (pl1.Longitude == pl2.Longitude)
                    return -1;
                else
                    return 1;
            }
        }
        public Place ShallowCopy() //поверхностное копирование
        {
            return (Place)this.MemberwiseClone();
        }
        virtual public object Clone()
        {
            return new Place(this.Latitude, this.Longitude);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Place p = (Place)obj;
            return (latitude == p.Latitude) && (longitude == p.Longitude);
        }
        
    }
    public class Area : Place, IExecutable
    {
        public Place placeSaver;
        internal string nameOfArea;
        internal int countOfCity;
        internal float squearOfArea;
        internal string nameOfContinetn;
        string[] Continents = new string[] { "Австралия", "Азия", "Африка", "Европа", "Северная Америка", "Южная Америка" };
        public override string ToString()
        {
            return $"Область:{nameOfArea} с площадью {squearOfArea}км^2 содержит {countOfCity} городов и находится на континенте {nameOfContinetn}";
        }
        public Place BasePlace
        {
            get
            {
                return new Place(latitude, longitude);//возвращает объект базового класса
            }

        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Area p = (Area)obj;
            return (latitude == p.Latitude) && (longitude == p.Longitude);
        }
        public string NameOfArea
        {
            get { return nameOfArea; }
            set { nameOfArea = value; }
        }
        public string NameOfContinetn
        {
            get { return nameOfContinetn; }
            set
            {
                for (int i = 0; i < Continents.Length; i++)
                {
                    if (Continents[i] == value)
                    {
                        nameOfContinetn = value;
                        break;
                    }
                    if (i + 1 == Continents.Length)
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }
        public int CountOfCity
        {
            get { return countOfCity; }
            set { countOfCity = value; }
        }
        public float SquearOfArea
        {
            get { return squearOfArea; }
            set
            {
                if (value > 0)
                    squearOfArea = value;
                else
                    Console.WriteLine("Невозможно присвоить отрицательную площадь");
            }
        }
        public Area(Place pl, string nameInCountry, string nameInTheWorld, int co, float sq)
        {
            nameOfArea = nameInCountry;
            nameOfContinetn = nameInTheWorld;
            Latitude = pl.Latitude;
            Longitude = pl.Longitude;
            countOfCity = co;
            squearOfArea = sq;
            placeSaver = (Place)pl.Clone();
        }
        public Area()
        {
            Random rnd = new Random();
            string[] area = new string[] { "Алтайский край", "Амурская область", "Архангельская область", "Астраханская область","Белгородская область", "Брянская область","Владимирская область","Волгоградская область","Вологодская область","Воронежская область","г. Москва","Еврейская автономная область","Забайкальский край","Ивановская область","Иркутская область","Кабардино-Балкарская Республика","Калининградская область", "Калужская область", "Камчатский край" };
            nameOfArea = area[rnd.Next(0,19)];
            countOfCity = rnd.Next(1,100);
            placeSaver = new Place();
            Latitude = placeSaver.Latitude;
            Longitude = placeSaver.Longitude;
            squearOfArea = rnd.Next(100, 1000000)+ ((float)rnd.Next(0,100))/100;
            
            nameOfContinetn = Continents[rnd.Next(0, 6)];

        }
        public override void Show()
        {
            Console.WriteLine($"Название области: {nameOfArea}");
            Console.WriteLine($"Площадь области: {squearOfArea} км^2");
            Console.WriteLine($"Количество городов в области: {countOfCity}");
            Console.WriteLine($"Область находиться на континенте: {nameOfContinetn}");
            Console.WriteLine($"Координаты места: Ш.{Latitude}°, Д.{Longitude}°");

        }
        public override int CompareTo(object ex)
        {

            Place pl1 = (Place)this;
            Place pl2 = (Place)ex;
            if (pl1.Latitude > pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 1;
                else
                    return -1;
            }
            else if (pl1.Latitude == pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (pl1.Longitude < pl2.Longitude)
                    return -1;
                else if (pl1.Longitude == pl2.Longitude)
                    return -1;
                else
                    return 1;
            }

        }

        public Area ShallowCopy() //поверхностное копирование
        {
            return (Area)this.MemberwiseClone();
        }
        public override object Clone()
        {
            Place clone = new Place(this.Latitude, this.Longitude);
            return new Area(clone,this.NameOfArea,this.NameOfContinetn,this.CountOfCity,this.SquearOfArea);
        }
    }
    public class City : Area, IExecutable
    {

        internal string nameOfCity;
        internal int countOfPeople;
        internal float squearOfCity;
        public override string ToString()
        {
            return $"Город {nameOfCity} с площадью {squearOfCity}км^2 содержит {countOfPeople} людей";
        }
        public Place BasePlace
        {
            get
            {
                return new Place(latitude, longitude);//возвращает объект базового класса
            }

        }
        public Area BaseArea
        {
            get
            {
                return new Area(BasePlace, nameOfArea, nameOfContinetn, countOfCity, squearOfArea);//возвращает объект базового класса
            }

        }
        public float SquearOfCity
        {
            get
            {
                return squearOfCity;
            }
            set
            {

                if (value > 0)
                    squearOfCity = value;
                else
                    Console.WriteLine("Невозможно присвоить отрицательную площадь");
            }
        }
        public string NameOfCity
        {
            get { return nameOfCity; }
            set { nameOfCity = value; }
        }
        public int CountOfPeople
        {
            get { return countOfPeople; }
            set { countOfPeople = value; }
        }
        public City(Area ar, string name, int count, float squear)
        {
            Latitude = ar.Latitude;
            Longitude = ar.Longitude;
            NameOfArea = ar.NameOfArea;
            NameOfContinetn = ar.NameOfContinetn;
            CountOfCity = ar.CountOfCity;
            SquearOfArea = ar.SquearOfArea;
            nameOfCity = name;
            countOfPeople = count;
            squearOfCity = squear;
            placeSaver = (Place)ar.placeSaver.Clone();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            City p = (City)obj;
            return (latitude == p.Latitude) && (longitude == p.Longitude);
        }
        public City()
        {
            Random rnd = new Random();
            Area ar = new Area();
            placeSaver = (Place)ar.placeSaver.Clone();
            Latitude = placeSaver.Latitude;
            Longitude = placeSaver.Longitude;
            NameOfArea = ar.NameOfArea;
            CountOfCity = ar.CountOfCity;
            SquearOfArea = ar.SquearOfArea;
            nameOfCity = "Random";
            countOfPeople = rnd.Next(0, 99999999);
            squearOfCity = rnd.Next(1, 1000) + ((float)rnd.Next(0, 100)) / 100; 
        }
        public override void Show()
        {
            Console.WriteLine($"Название города: {nameOfCity}");
            Console.WriteLine($"Площадь города: {squearOfCity} км^2");
            Console.WriteLine($"Население: {countOfPeople}");
            Console.WriteLine($"Название области: {NameOfArea}");
            Console.WriteLine($"Площадь области: {SquearOfArea} км^2");
            Console.WriteLine($"Количество городов в области: {countOfCity}");
            Console.WriteLine($"Название области: {NameOfArea}");
            Console.WriteLine($"Координаты места: Ш.{Latitude}°, Д.{Longitude}°");
        }
        public override int CompareTo(object ex)
        {
            Place pl1 = (Place)this;
            Place pl2 = (Place)ex;
            if (pl1.Latitude > pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 1;
                else
                    return -1;
            }
            else if (pl1.Latitude == pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (pl1.Longitude < pl2.Longitude)
                    return -1;
                else if (pl1.Longitude == pl2.Longitude)
                    return -1;
                else
                    return 1;
            }

        }
        public City ShallowCopy() //поверхностное копирование
        {
            return (City)this.MemberwiseClone();
        }
        public override object Clone()
        {
            Place clone = new Place(this.Latitude, this.Longitude);
            Area clone1 = new Area(clone, this.NameOfArea, this.NameOfContinetn, this.CountOfCity, this.SquearOfArea);
            return new City(clone1, this.NameOfCity, this.CountOfPeople, this.SquearOfCity);
        }

    }
    public class Megapolice : City, IExecutable
    {
        internal int countOfAglommeration;
        public override string ToString()
        {
            return $"Мегаполис {nameOfCity} с площадью {squearOfCity}км^2 содержит {countOfPeople} людей а также {countOfAglommeration}";
        }
        public Place BasePlace
        {
            get
            {
                return new Place(latitude, longitude);//возвращает объект базового класса
            }

        }
        public Area BaseArea
        {
            get
            {
                return new Area(BasePlace, nameOfArea, nameOfContinetn, countOfCity, squearOfArea);//возвращает объект базового класса
            }

        }
        public City BaseCity
        {
            get
            {
                return new City(BaseArea, nameOfCity, countOfPeople, squearOfCity);//возвращает объект базового класса
            }

        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Megapolice p = (Megapolice)obj;
            return (latitude == p.Latitude) && (longitude == p.Longitude);
        }
        public Megapolice(City city, int count)
        {
            Latitude = city.Latitude;
            Longitude = city.Longitude;
            NameOfArea = city.NameOfArea;
            CountOfCity = city.CountOfCity;
            NameOfContinetn = city.NameOfContinetn;
            SquearOfArea = city.SquearOfArea;
            CountOfPeople = city.CountOfPeople;
            NameOfCity = city.NameOfCity;
            SquearOfCity = city.SquearOfCity;
            countOfAglommeration = count;
            placeSaver = (Place)city.placeSaver.Clone();
        }
        public Megapolice()
        {
            Random rnd = new Random();
            City city = new City();
            placeSaver = (Place)city.placeSaver.Clone();
            Latitude = placeSaver.Latitude;

            Longitude = placeSaver.Longitude;
            NameOfArea = city.NameOfArea;
            CountOfCity = city.CountOfCity;
            SquearOfArea = city.SquearOfArea;
            CountOfPeople = city.CountOfPeople;
            NameOfCity = city.NameOfCity;
            SquearOfCity = city.SquearOfCity;
            countOfAglommeration = rnd.Next(1,20);
           
        }
        public int CountOfAglommeration
        {
            get { return countOfAglommeration; }
            set { countOfAglommeration = value; }
        }
        public override void Show()
        {
            Console.WriteLine($"Количество агломераций мегаполиса: {countOfAglommeration}");
            Console.WriteLine($"Название мегаполиса: {NameOfCity}");
            Console.WriteLine($"Площадь мегаполиса: {SquearOfCity} км^2");
            Console.WriteLine($"Население: {CountOfPeople}");
            Console.WriteLine($"Название области: {NameOfArea}");
            Console.WriteLine($"Площадь области: {SquearOfArea} км^2");
            Console.WriteLine($"Количество городов в области: {countOfCity}");
            Console.WriteLine($"Название области: {NameOfArea}");
            Console.WriteLine($"Координаты места: Ш.{Latitude}°, Д.{Longitude}°");
        }
        public override int CompareTo(object ex)
        {
            Place pl1 = (Place)this;
            Place pl2 = (Place)ex;
            if (pl1.Latitude > pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 1;
                else
                    return -1;
            }
            else if (pl1.Latitude == pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (pl1.Longitude < pl2.Longitude)
                    return -1;
                else if (pl1.Longitude == pl2.Longitude)
                    return -1;
                else
                    return 1;
            }
        }
        
        public Megapolice ShallowCopy() //поверхностное копирование
        {
            return (Megapolice)this.MemberwiseClone();
        }
        public override object Clone()
        {
            Place clone = new Place(this.Latitude, this.Longitude);
            Area clone1 = new Area(clone, this.NameOfArea, this.NameOfContinetn, this.CountOfCity, this.SquearOfArea);
            City clone2 = new City(clone1, this.NameOfCity, this.CountOfPeople, this.SquearOfCity);
            return new Megapolice(clone2, this.CountOfAglommeration);
        }
    }
    public class Address : Megapolice
    {
        string streatName;
        int numberOfStreat;
        public override string ToString()
        {
            return $"ул. {streatName} д. {numberOfStreat}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Address p = (Address)obj;
            return (latitude == p.Latitude) && (longitude == p.Longitude);
        }
        public override int GetHashCode()
        {
            return Tuple.Create(streatName, numberOfStreat).GetHashCode();
        }
        public Place BasePlace
        {
            get
            {
                return new Place(latitude, longitude);//возвращает объект базового класса
            }

        }
        public Area BaseArea
        {
            get
            {
                return new Area(BasePlace, nameOfArea, nameOfContinetn, countOfCity, squearOfArea);//возвращает объект базового класса
            }

        }
        public City BaseCity
        {
            get
            {
                return new City(BaseArea, nameOfCity, countOfPeople, squearOfCity);//возвращает объект базового класса
            }

        }
        public Megapolice BaseMegapolice
        {
            get
            {
                return new Megapolice(BaseCity, countOfAglommeration);//возвращает объект базового класса
            }

        }
        public Address(Megapolice megapolice, string name, int num)
        {
            Latitude = megapolice.Latitude;
            Longitude = megapolice.Longitude;
            NameOfContinetn = megapolice.NameOfContinetn;
            NameOfArea = megapolice.NameOfArea;
            CountOfCity = megapolice.CountOfCity;
            SquearOfArea = megapolice.SquearOfArea;
            CountOfPeople = megapolice.CountOfPeople;
            NameOfCity = megapolice.NameOfCity;
            SquearOfCity = megapolice.SquearOfCity;
            CountOfAglommeration = megapolice.CountOfAglommeration;
            if (megapolice.CountOfAglommeration == -1)
            {
                CountOfAglommeration = 1;
            }
            placeSaver = (Place)megapolice.placeSaver.Clone();
            streatName = name;
            numberOfStreat = num;
        }
        public Address(City city, string name, int num)
        {
            placeSaver = (Place)city.placeSaver.Clone();
            Latitude = city.Latitude;
            NameOfContinetn = city.NameOfContinetn;
            Longitude = city.Longitude;
            NameOfArea = city.NameOfArea;
            CountOfCity = city.CountOfCity;
            SquearOfArea = city.SquearOfArea;
            CountOfPeople = city.CountOfPeople;
            NameOfCity = city.NameOfCity;
            SquearOfCity = city.SquearOfCity;
            CountOfAglommeration = -1;
            streatName = name;
            numberOfStreat = num;
        }
        public Address()
        {
            Random rnd = new Random();
            City city = new City();
            placeSaver = (Place)city.placeSaver.Clone();
            Latitude = placeSaver.Latitude;
            Longitude = placeSaver.Longitude;
            NameOfArea = city.NameOfArea;
            CountOfCity = city.CountOfCity;
            SquearOfArea = city.SquearOfArea;
            CountOfPeople = city.CountOfPeople;
            NameOfCity = city.NameOfCity;
            SquearOfCity = city.SquearOfCity;
            CountOfAglommeration = -1;
            streatName = "Random";
            numberOfStreat = rnd.Next(1,500);
        }
        public string StreatName
        {
            get { return streatName; }
            set { streatName = value; }
        }


        public override void Show()
        {
            Console.WriteLine($"Адрес: ул.{streatName} №{numberOfStreat}");
            if (CountOfAglommeration != -1)
            {
                Console.WriteLine($"Количество агломераций мегаполиса: {CountOfAglommeration}");
                Console.WriteLine($"Название мегаполиса: {NameOfCity}");
                Console.WriteLine($"Площадь мегаполиса: {SquearOfCity}");

                Console.WriteLine($"Население: {CountOfPeople}");

                Console.WriteLine($"Название области: {NameOfArea}");
                Console.WriteLine($"Площадь области: {SquearOfArea}");
                Console.WriteLine($"Количество городов в области: {CountOfCity}");
                Console.WriteLine($"Название области: {NameOfArea}");
                Console.WriteLine($"Координаты места: Ш.{Latitude}°, Д.{Longitude}°");
            }
            else
            {
                Console.WriteLine($"Название города: {NameOfCity}");
                Console.WriteLine($"Площадь города: {SquearOfCity}");
                Console.WriteLine($"Население: {CountOfPeople}");
                Console.WriteLine($"Название области: {NameOfArea}");
                Console.WriteLine($"Площадь области: {SquearOfArea} км^2");
                Console.WriteLine($"Количество городов в области: {countOfCity}");
                Console.WriteLine($"Название области: {NameOfArea}");
                Console.WriteLine($"Координаты места: Ш.{Latitude}°, Д.{Longitude}°");
            }

        }
        public override int CompareTo(object ex)
        {
            Place pl1 = (Place)this;
            Place pl2 = (Place)ex;
            if (pl1.Latitude > pl2.Latitude) 
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 1;
                else
                    return -1;
            }
            else if(pl1.Latitude == pl2.Latitude)
            {
                if (pl1.Longitude > pl2.Longitude)
                    return 1;
                else if (pl1.Longitude == pl2.Longitude)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (pl1.Longitude < pl2.Longitude)
                    return -1;
                else if (pl1.Longitude == pl2.Longitude)
                    return -1;
                else
                    return 1;
            }
        }
        public Address ShallowCopy() //поверхностное копирование
        {
            return (Address)this.MemberwiseClone();
        }
        public override object Clone()
        {
            Place clone = new Place(this.Latitude, this.Longitude);
            Area clone1 = new Area(clone, this.NameOfArea, this.NameOfContinetn, this.CountOfCity, this.SquearOfArea);
            City clone2 = new City(clone1, this.NameOfCity, this.CountOfPeople, this.SquearOfCity);
            Megapolice clone3 = new Megapolice(clone2, this.CountOfAglommeration);
            return new Address(clone3, this.streatName, this.numberOfStreat);
        }
    }
    public class TestCollections
    {
        public List<Place> CollectionOneList = new List<Place> { };

        public List<string> CollectionTwoList = new List<string> { };

        public SortedDictionary<Place,Place> CollectionOneSD = new SortedDictionary<Place, Place> { };
        public SortedDictionary<string, Place> CollectionTwoSD = new SortedDictionary<string, Place> { };
        public TestCollections(int numberOf)
        {
            for (int i = 0; i < numberOf; i++)
            {

                Random rnd = new Random();
                int menue = rnd.Next(1, 6);
                switch (menue)
                {
                    case 1:
                        Place add = new Place();
                        while (true)
                        {
                            try
                            {
                                CollectionOneList.Add(add);
                                CollectionTwoList.Add(add.ToString());
                                CollectionTwoSD.Add(add.ToString(), add);
                                CollectionOneSD.Add(add, add);
                                break;
                            }
                            catch
                            {
                                CollectionOneList.Remove(add);
                                CollectionTwoList.Remove(add.ToString());
                                add = new Place();
                            }
                        }
                        break;
                    case 2:
                        Area ad = new Area();
                        while (true) {
                            try
                            {
                                CollectionOneList.Add(ad);
                                CollectionTwoList.Add(ad.ToString());
                                CollectionTwoSD.Add(ad.placeSaver.ToString(), ad);
                                CollectionOneSD.Add(ad.placeSaver, ad);
                                break;
                            }
                            catch
                            {
                                CollectionOneList.Remove(ad);
                                CollectionTwoList.Remove(ad.ToString());
                                ad = new Area();
                            }
                            }
                        break;
                    case 3:
                        City addd = new City();
                        while (true)
                        {
                            try
                            {
                                CollectionOneList.Add(addd);
                                CollectionTwoList.Add(addd.ToString());
                                CollectionTwoSD.Add(addd.placeSaver.ToString(), addd);
                                CollectionOneSD.Add(addd.placeSaver, addd);
                                break;
                            }
                            catch
                            {
                                CollectionOneList.Remove(addd);
                                CollectionTwoList.Remove(addd.ToString());
                                addd = new City();
                            }
                        }
                        break;
                    case 4:
                        Megapolice adddd = new Megapolice();
                        while (true)
                        {
                            try
                            {
                                CollectionOneList.Add(adddd);
                                CollectionTwoList.Add(adddd.ToString());
                                CollectionTwoSD.Add(adddd.placeSaver.ToString(), adddd);
                                CollectionOneSD.Add(adddd.placeSaver, adddd);
                                break;
                            }
                            catch
                            {
                                CollectionOneList.Remove(adddd);
                                CollectionTwoList.Remove(adddd.ToString());
                                adddd = new Megapolice();
                            }
                        }
                        break;
                    case 5:
                        Address addddd = new Address();
                        while (true)
                        {
                            try
                            {
                                CollectionOneList.Add(addddd);
                                CollectionTwoList.Add(addddd.ToString());
                                CollectionTwoSD.Add(addddd.placeSaver.ToString(), addddd);
                                CollectionOneSD.Add(addddd.placeSaver, addddd);
                                break;
                            }
                            catch
                            {
                                CollectionOneList.Remove(addddd);
                                CollectionTwoList.Remove(addddd.ToString());
                                addddd = new Address();
                            }
                        }
                        break;
                }
            }
        }
    }
    [ExcludeFromCodeCoverage]
    class ByName
    {
        public static int Compare(object s1, object s2)
        {
            if (s1 is Address)
            {
                Address tmp1 = (Address)s1;
                if (s2 is Address)
                {
                    Address tmp2 = (Address)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is Megapolice)
                {
                    Megapolice tmp2 = (Megapolice)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is City)
                {
                    City tmp2 = (City)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }

                else if (s2 is Area)
                {
                    Area tmp2 = (Area)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is Place)
                {
                    Place tmp2 = (Place)s2;
                    Place tmp = new Place(tmp1.Latitude, tmp1.Longitude);
                    return tmp2.CompareTo(tmp);
                }
                else return 0;

            }
            else if (s1 is Megapolice)
            {
                Megapolice tmp1 = (Megapolice)s1;
                if (s2 is Address)
                {
                    Address tmp2 = (Address)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is Megapolice)
                {
                    Megapolice tmp2 = (Megapolice)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is City)
                {
                    City tmp2 = (City)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }

                else if (s2 is Area)
                {
                    Area tmp2 = (Area)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is Place)
                {
                    Place tmp2 = (Place)s2;
                    Place tmp = new Place(tmp1.Latitude, tmp1.Longitude);
                    return tmp2.CompareTo(tmp);
                }else return 0;
            }
            else if (s1 is City)
            {
                City tmp1 = (City)s1;
                if (s2 is Address)
                {
                    Address tmp2 = (Address)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is Megapolice)
                {
                    Megapolice tmp2 = (Megapolice)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }
                else if (s2 is City)
                {
                    City tmp2 = (City)s2;
                    return String.Compare(tmp1.NameOfCity, tmp2.NameOfCity);
                }

                else if (s2 is Area)
                {
                    Area tmp2 = (Area)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is Place)
                {
                    Place tmp2 = (Place)s2;
                    Place tmp = new Place(tmp1.Latitude, tmp1.Longitude);
                    return tmp2.CompareTo(tmp);
                }
                else return 0;
            }

            else if (s1 is Area)
            {
                Area tmp1 = (Area)s1;
                if (s2 is Address)
                {
                    Address tmp2 = (Address)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is Megapolice)
                {
                    Megapolice tmp2 = (Megapolice)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is City)
                {
                    City tmp2 = (City)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }

                else if (s2 is Area)
                {
                    Area tmp2 = (Area)s2;
                    return String.Compare(tmp1.NameOfArea, tmp2.NameOfArea);
                }
                else if (s2 is Place)
                {
                    Place tmp2 = (Place)s2;
                    Place tmp = new Place(tmp1.Latitude, tmp1.Longitude);
                    return tmp2.CompareTo(tmp);
                }
                else return 0;
            }
            else if (s1 is Place)
            {
                Place tmp1 = (Place)s1;
                if (s2 is Address)
                {
                    Address tmp = (Address)s2;
                    Place tmp2 = new Place(tmp.Latitude, tmp.Longitude);
                    return tmp1.CompareTo(tmp2);
                }
                else if (s2 is Megapolice)
                {
                    Megapolice tmp = (Megapolice)s2;
                    Place tmp2 = new Place(tmp.Latitude, tmp.Longitude);
                    return tmp1.CompareTo(tmp2);
                }
                else if (s2 is City)
                {
                    City tmp = (City)s2;
                    Place tmp2 = new Place(tmp.Latitude, tmp.Longitude);
                    return tmp1.CompareTo(tmp2);
                }

                else if (s2 is Area)
                {
                    Area tmp = (Area)s2;
                    Place tmp2 = new Place(tmp.Latitude, tmp.Longitude);
                    return tmp1.CompareTo(tmp2);
                }
                else if (s2 is Place)
                {
                    Place tmp2 = (Place)s2;
                    return tmp1.CompareTo(tmp2);
                }
                else return 0;
            }
            else
            {
                return 0;
            }
        }
    }

}
