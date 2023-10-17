// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class program
{
    static void Main()
    {
        Console.Write("2'li sayıda veri girişi yapınız : ");
        string ikiligiris = Console.ReadLine(); // string = değişken'e harlerle isim atamamızı sağlar

        try // try = hata blogudur eğer kod hata verirse çökmesini engeller 
        {
            int ondalıgiris = Convert.ToInt32(ikiligiris, 2); // int = tam olan sayılar kullanılır
            //Convert.ToInt32 = 32 bitlik sayı yazma genelde küçük kodlarda daha rahat olması için 64 yerine kullanılır
            
            Console.WriteLine($" {ikiligiris} (2'li Değerde) = {ondalıgiris} (10'lu Değerde) ");
        }
        catch (FormatException) // catch = try ile beraber kullanılır hatayı yakalar
        {
            Console.WriteLine("Girdiğiniz Değerler Geçersizdir.Sadece 1 ile 0 Olan İkili Değer Giriniz"); //console.WriteLine = konsola yazdır 
            
        }
    }
}
