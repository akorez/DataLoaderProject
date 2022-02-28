using CreditSuisseInterview.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace CreditSuisseInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataLoader dataLoader = new DataLoader(new CSVDataLoader());

            var csvResult = dataLoader.Load(@"C:\Users\atafiliz\source\repos\CreditSuisseInterview\CreditSuisseInterview\DataSource1.csv");

            dataLoader = new DataLoader(new XMLDataLoader());

            var xmlResult = dataLoader.Load(@"C:\Users\atafiliz\source\repos\CreditSuisseInterview\CreditSuisseInterview\DataSource2.xml");


        }

    }




}

