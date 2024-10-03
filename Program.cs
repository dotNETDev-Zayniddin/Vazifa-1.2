/*
Valyuta konvertri
Bir valyutadagi summani sumga aylantiruvchi dastur tuzing. Summa va valyuta kursini 
e’lon qiling va konvertatsiya qilingan summani hisoblang. Natijani ekranga chiqaring.
Input: qiymat=2, kurs=12400 so’m
Output: 24800 so’m
----------------
Input: qiymat=7.6, kurs=12400 so’m
Output: 94240 so’m
*/
using System;
namespace Vazifa{
    class Program{
        static void Main(string[] args){
            System.Console.Write("Qiymatni kiriting: ");
            decimal qiymat = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Hozirgi kursni kiriting: ");
            decimal kurs = Convert.ToDecimal(Console.ReadLine());
            
            decimal natija;
            natija = kurs * qiymat;
            System.Console.WriteLine(natija);

        }
    }
}