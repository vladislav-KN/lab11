using System;
using Lab10_3;

namespace Lab11_3
{
    class P11_3
    {
        static void Main(string[] args)
        {
            TestCollections testCollections = new TestCollections(1000);
            Place searchPZ = null, searchPM = null, searchPL = null;
            Area searchArZ = null, searchArM = null, searchArL = null;
            City searchCZ = null, searchCM = null, searchCL = null;
            Megapolice searchMZ = null, searchMM = null, searchML = null;
            Address searchAdZ = null, searchAdM = null, searchAdL = null;
            #region ifelse
            if (testCollections.CollectionOneList[0] is Address)
            {
                searchAdZ = (Address)testCollections.CollectionOneList[0].Clone();
            }
            else if (testCollections.CollectionOneList[0] is Megapolice)
            {
                searchMZ = (Megapolice)testCollections.CollectionOneList[0].Clone();
            }
            else if (testCollections.CollectionOneList[0] is City)
            {
                searchCZ = (City)testCollections.CollectionOneList[0].Clone();
            }

            else if (testCollections.CollectionOneList[0] is Area)
            {
                searchArZ = (Area)testCollections.CollectionOneList[0].Clone();
            }
            else if (testCollections.CollectionOneList[0] is Place)
            {
                searchPZ = (Place)testCollections.CollectionOneList[0].Clone();
            }
            if (testCollections.CollectionOneList[499] is Address)
            {
                searchAdM = (Address)testCollections.CollectionOneList[499].Clone();
            }
            else if (testCollections.CollectionOneList[499] is Megapolice)
            {
                searchMM = (Megapolice)testCollections.CollectionOneList[499].Clone();
            }
            else if (testCollections.CollectionOneList[499] is City)
            {
                searchCM = (City)testCollections.CollectionOneList[499].Clone();
            }

            else if (testCollections.CollectionOneList[499] is Area)
            {
                searchArM = (Area)testCollections.CollectionOneList[499].Clone();
            }
            else if (testCollections.CollectionOneList[499] is Place)
            {
                searchPM = (Place)testCollections.CollectionOneList[499].Clone();
            }
            if (testCollections.CollectionOneList[999] is Address)
            {
                searchAdL = (Address)testCollections.CollectionOneList[999].Clone();
            }
            else if (testCollections.CollectionOneList[999] is Megapolice)
            {
                searchML = (Megapolice)testCollections.CollectionOneList[999].Clone();
            }
            else if (testCollections.CollectionOneList[999] is City)
            {
                searchCL = (City)testCollections.CollectionOneList[999].Clone();
            }

            else if (testCollections.CollectionOneList[999] is Area)
            {
                searchArL = (Area)testCollections.CollectionOneList[999].Clone();
            }
            else if (testCollections.CollectionOneList[999] is Place)
            {
                searchPL = (Place)testCollections.CollectionOneList[999].Clone();
            }
            #endregion
            DateTime DtStart = DateTime.Now;
            #region ifelse
            if (!(searchPZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchPZ));
            }else if(!(searchArZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchArZ));
            }
            else if (!(searchCZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchCZ));
            }
            else if (!(searchMZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchMZ));
            }
            else if (!(searchAdZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchAdZ));
            }
            #endregion
            #region ifelse
            if (!(searchPM is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchPM));
            }
            else if (!(searchArM is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchArM));
            }
            else if (!(searchCM is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchCM));
            }
            else if (!(searchMM is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchMM));
            }
            else if (!(searchAdM is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchAdM));
            }
            #endregion
            #region ifelse
            if (!(searchPL is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchPL));
            }
            else if (!(searchArL is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchArL));
            }
            else if (!(searchCL is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchCL));
            }
            else if (!(searchML is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchML));
            }
            else if (!(searchAdL is null))
            {
                Console.WriteLine(testCollections.CollectionOneList.Contains(searchAdL));
            }
            #endregion
            DateTime DtEnd = DateTime.Now;
            TimeSpan Elapsed = DtEnd - DtStart;
            Console.WriteLine("Завершение - " + DtEnd.ToLongTimeString());
            Console.WriteLine("Длительность - " + String.Format("{0:00}:{1:00}:{2:00}", Elapsed.Minutes, Elapsed.Seconds,Elapsed.Milliseconds));
            DtStart = DateTime.Now;
            #region ifelse
            if (!(searchPZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchPZ.ToString()));
            }
            else if (!(searchArZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchArZ.ToString()));
            }
            else if (!(searchCZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchCZ.ToString()));
            }
            else if (!(searchMZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchMZ.ToString()));
            }
            else if (!(searchAdZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchAdZ.ToString()));
            }
            #endregion
            #region ifelse
            if (!(searchPM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchPM.ToString()));
            }
            else if (!(searchArM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchArM.ToString()));
            }
            else if (!(searchCM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchCM.ToString()));
            }
            else if (!(searchMM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchMM.ToString()));
            }
            else if (!(searchAdM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchAdM.ToString()));
            }
            #endregion
            #region ifelse
            if (!(searchPL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchPL.ToString()));
            }
            else if (!(searchArL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchArL.ToString()));
            }
            else if (!(searchCL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchCL.ToString()));
            }
            else if (!(searchML is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchML.ToString()));
            }
            else if (!(searchAdL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoList.Contains(searchAdL.ToString()));
            }
            #endregion
            DtEnd = DateTime.Now;
            Elapsed = DtEnd - DtStart;
            Console.WriteLine("Завершение - " + DtEnd.ToLongTimeString());
            Console.WriteLine("Длительность - " + String.Format("{0:00}:{1:00}:{2:00}", Elapsed.Minutes, Elapsed.Seconds,Elapsed.Milliseconds));
            DtStart = DateTime.Now;
            #region ifelse
            if (!(searchPZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchPZ));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchPZ));
            }
            else if (!(searchArZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchArZ.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchArZ));
            }
            else if (!(searchCZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchCZ.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchCZ));
            }
            else if (!(searchMZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchMZ.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchMZ));
            }
            else if (!(searchAdZ is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchAdZ.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchAdZ));
            }
            #endregion
            #region ifelse
            if (!(searchPM is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchPM));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchPM));
            }
            else if (!(searchArM is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchArM.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchArM));
            }
            else if (!(searchCM is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchCM.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchCM));
            }
            else if (!(searchMM is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchMM.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchMM));
            }
            else if (!(searchAdM is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchAdM.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchMM));
            }
            #endregion
            #region ifelse
            if (!(searchPL is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchPL));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchPL));
            }
            else if (!(searchArL is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchArL.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchArL));
            }
            else if (!(searchCL is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchCL.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchCL));
            }
            else if (!(searchML is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchML.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchML));
            }
            else if (!(searchAdL is null))
            {
                Console.WriteLine(testCollections.CollectionOneSD.ContainsKey(searchAdL.placeSaver));
                Console.WriteLine(testCollections.CollectionOneSD.ContainsValue(searchAdL));
            }
            #endregion
            DtEnd = DateTime.Now;
            Elapsed = DtEnd - DtStart;
            Console.WriteLine("Завершение - " + DtEnd.ToLongTimeString());
            Console.WriteLine("Длительность - " + String.Format("{0:00}:{1:00}:{2:00}", Elapsed.Minutes, Elapsed.Seconds, Elapsed.Milliseconds));
            DtStart = DateTime.Now;
            #region ifelse
            if (!(searchPZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchPZ.ToString()));
            }
            else if (!(searchArZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchArZ.placeSaver.ToString()));
            }
            else if (!(searchCZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchCZ.placeSaver.ToString()));
            }
            else if (!(searchMZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchMZ.placeSaver.ToString()));
            }
            else if (!(searchAdZ is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchAdZ.placeSaver.ToString()));
            }
            #endregion
            #region ifelse
            if (!(searchPM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchPM.ToString()));
            }
            else if (!(searchArM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchArM.placeSaver.ToString()));
            }
            else if (!(searchCM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchCM.placeSaver.ToString()));
            }
            else if (!(searchMM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchMM.placeSaver.ToString()));
            }
            else if (!(searchAdM is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchAdM.placeSaver.ToString()));
            }
            #endregion
            #region ifelse
            if (!(searchPL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchPL.ToString()));
            }
            else if (!(searchArL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchArL.placeSaver.ToString()));
            }
            else if (!(searchCL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchCL.placeSaver.ToString()));
            }
            else if (!(searchML is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchML.placeSaver.ToString()));
            }
            else if (!(searchAdL is null))
            {
                Console.WriteLine(testCollections.CollectionTwoSD.ContainsKey(searchAdL.placeSaver.ToString()));
            }
            #endregion
            DtEnd = DateTime.Now;
            Elapsed = DtEnd - DtStart;
            Console.WriteLine("Завершение - " + DtEnd.ToLongTimeString());
            Console.WriteLine("Длительность - " + String.Format("{0:00}:{1:00}:{2:00}", Elapsed.Minutes, Elapsed.Seconds, Elapsed.Milliseconds));
        }
    }
}
