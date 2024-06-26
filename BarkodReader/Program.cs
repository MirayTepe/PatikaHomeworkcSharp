﻿using BarcodeLib;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;


namespace BarcodeGeneratorDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod yazdırmak için metni girin: ");
            string text = Console.ReadLine();

            writeBarcode(text);
            readBarcode();
        }

        static void writeBarcode(string word)
        {
            Barcode barcode = new Barcode();


            Image img = barcode.Encode(TYPE.CODE128, word); //Barkodu resme dönüştürme

            Bitmap bmp = new Bitmap(img);// Barkod resmini Bitmap'e dönüştürme

            string filePath = @"D:\source\repos\PatikaHomework-master\BarkodReader\barcode.png";

            bmp.Save(filePath);// Barkodu dosyaya kaydetme
        }


        static void readBarcode()
        {

            BarcodeReader barcodeReader = new BarcodeReader(); // Barkod okuyucu nesnesi oluşturma

            barcodeReader.Options.TryHarder = true; //Daha doğru okuma için

            var barcodeBitMap = new Bitmap(@"D:\source\repos\PatikaHomework-master\BarkodReader\barcode.png");

            var result = barcodeReader.Decode(barcodeBitMap); // Barkodu okuma

            if (result != null) // Eğer barkod okunamazsa sonuç null olacaktır
                Console.WriteLine("Barkod içeriği: " + result.Text);
            else
                Console.WriteLine("Barkod okunamadı.");


            // Konsol penceresini açık tutmak için
            Console.ReadKey();
        }
    }
}