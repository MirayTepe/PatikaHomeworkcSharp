using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            // Başlangıçta 5 kişinin telefon numarasını varsayılan olarak ekler.
            phoneBook.InitializeDefaultContacts();

            while (true)
            {
                // Kullanıcıya yapmak istediği işlem seçtirilir.
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Yeni numara kaydetme işlemi.
                        phoneBook.AddNewContact();
                        break;
                    case 2:
                        // Varolan numarayı silme işlemi.
                        phoneBook.DeleteContact();
                        break;
                    case 3:
                        // Varolan numarayı güncelleme işlemi.
                        phoneBook.UpdateContact();
                        break;
                    case 4:
                        // Rehberi listeleme işlemi.
                        phoneBook.ListContacts();
                        break;
                    case 5:
                        // Rehberde arama yapma işlemi.
                        phoneBook.SearchContacts();
                        break;
                    default:
                        // Geçersiz bir seçim yapıldığında uyarı verilir.
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}