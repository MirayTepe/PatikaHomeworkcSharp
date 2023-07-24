using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public  class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();

        // Başlangıçta 5 kişinin bilgilerini varsayılan olarak ekler.
        public void InitializeDefaultContacts()
        {
            contacts.Add(new Contact { Name = "John", Surname = "Doe", PhoneNumber = "1234567890" });
            contacts.Add(new Contact { Name = "Jane", Surname = "Smith", PhoneNumber = "9876543210" });
            contacts.Add(new Contact { Name = "Michael", Surname = "Johnson", PhoneNumber = "5678901234" });
            contacts.Add(new Contact { Name = "Emily", Surname = "Williams", PhoneNumber = "9081726354" });
            contacts.Add(new Contact { Name = "Robert", Surname = "Brown", PhoneNumber = "2468135790" });
        }

        // Yeni bir kişiyi rehbere ekler.
        public void AddNewContact()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string phoneNumber = Console.ReadLine();

            // Girilen bilgilerle yeni kişiyi rehbere ekler.
            contacts.Add(new Contact { Name = name, Surname = surname, PhoneNumber = phoneNumber });
            Console.WriteLine("Kişi başarıyla rehbere eklendi.");
        }

        // Rehberden bir kişiyi siler.
        public void DeleteContact()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string searchKey = Console.ReadLine();

            // Arama kriterlerine uygun kişiyi bulur.
            Contact foundContact = contacts.Find(c => c.Name.Equals(searchKey, StringComparison.OrdinalIgnoreCase) || c.Surname.Equals(searchKey, StringComparison.OrdinalIgnoreCase));

            if (foundContact == null)
            {
                // Aranan kişi rehberde bulunamadığında uyarı verir ve seçim yapma imkanı sunar.
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Silmeyi sonlandırmak için seçim yapılırsa işlem sonlandırılır.
                    return;
                }
                else if (choice == 2)
                {
                    // Yeniden denemek için seçim yapılırsa işlem tekrarlanır.
                    DeleteContact();
                }
                else
                {
                    // Geçersiz seçim yapıldığında uyarı verir ve işlem sonlandırılır.
                    Console.WriteLine("Geçersiz seçim, işlem sonlandırıldı.");
                    return;
                }
            }

            // Kişiyi rehberden silip silmeyeceğini onaylar.
            Console.WriteLine($"{foundContact.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
            string confirmation = Console.ReadLine();

            if (confirmation.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                // Onay verilirse kişi rehberden silinir.
                contacts.Remove(foundContact);
                Console.WriteLine("Kişi rehberden silindi.");
            }
            else
            {
                // Onay verilmezse işlem iptal edilir.
                Console.WriteLine("İşlem iptal edildi.");
            }
        }

        // Rehberdeki bir kişinin telefon numarasını günceller.
        public void UpdateContact()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string searchKey = Console.ReadLine();

            // Arama kriterlerine uygun kişiyi bulur.
            Contact foundContact = contacts.Find(c => c.Name.Equals(searchKey, StringComparison.OrdinalIgnoreCase) || c.Surname.Equals(searchKey, StringComparison.OrdinalIgnoreCase));

            if (foundContact == null)
            {
                // Aranan kişi rehberde bulunamadığında uyarı verir ve seçim yapma imkanı sunar.
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Güncellemeyi sonlandırmak için seçim yapılırsa işlem sonlandırılır.
                    return;
                }
                else if (choice == 2)
                {
                    // Yeniden denemek için seçim yapılırsa işlem tekrarlanır.
                    UpdateContact();
                }
                else
                {
                    // Geçersiz seçim yapıldığında uyarı verir ve işlem sonlandırılır.
                    Console.WriteLine("Geçersiz seçim, işlem sonlandırıldı.");
                    return;
                }
            }

            // Yeni telefon numarasını alır ve kişinin numarasını günceller.
            Console.WriteLine("Lütfen yeni telefon numarasını giriniz:");
            string newPhoneNumber = Console.ReadLine();

            foundContact.PhoneNumber = newPhoneNumber;
            Console.WriteLine("Kişinin telefon numarası başarıyla güncellendi.");
        }

        // Rehberdeki tüm kişileri listeler.
        public void ListContacts()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            // Tüm kişileri rehberdeki formata uygun şekilde liste halinde gösterir.
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"isim: {contact.Name} Soyisim: {contact.Surname} Telefon Numarası: {contact.PhoneNumber}");
            }

            Console.WriteLine();
        }

        // Rehberde arama yapar ve sonuçları gösterir.
        public void SearchContacts()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // İsim veya soyisime göre arama yapar ve sonuçları listeler.
                Console.WriteLine("Lütfen isim veya soyisim giriniz:");
                string searchKey = Console.ReadLine();

                // Arama kriterlerine uygun kişileri bulur.
                List<Contact> searchResults = contacts.FindAll(c => c.Name.Contains(searchKey, StringComparison.OrdinalIgnoreCase) || c.Surname.Contains(searchKey, StringComparison.OrdinalIgnoreCase));

                if (searchResults.Count == 0)
                {
                    // Aranan kişi rehberde bulunamadığında uyarı verir.
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                }
                else
                {
                    // Aranan kişileri rehberdeki formata uygun şekilde liste halinde gösterir.
                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    foreach (Contact result in searchResults)
                    {
                        Console.WriteLine($"isim: {result.Name} Soyisim: {result.Surname} Telefon Numarası: {result.PhoneNumber}");
                    }
                }
            }
            else if (choice == 2)
            {
                // Telefon numarasına göre arama yapar ve sonucu gösterir.
                Console.WriteLine("Lütfen telefon numarası giriniz:");
                string searchKey = Console.ReadLine();

                // Arama kriterlerine uygun kişiyi bulur.
                Contact foundContact = contacts.Find(c => c.PhoneNumber.Equals(searchKey));

                if (foundContact == null)
                {
                    // Aranan kişi rehberde bulunamadığında uyarı verir.
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                }
                else
                {
                    // Aranan kişiyi rehberdeki formata uygun şekilde gösterir.
                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine($"isim: {foundContact.Name} Soyisim: {foundContact.Surname} Telefon Numarası: {foundContact.PhoneNumber}");
                }
            }
            else
            {
                // Geçersiz seçim yapıldığında uyarı verir.
                Console.WriteLine("Geçersiz seçim.");
            }
        }
    }
}
