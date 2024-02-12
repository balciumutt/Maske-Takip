using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Umut";
            person1.LastName = "Balcı";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Kara";
            person1.DateOfBirthYear = 1987;
            person1.NationalIdentity = 147;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }
    }
}