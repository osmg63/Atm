using Atm.Api.Core.Repository;
using Atm.Api.Data.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace ConsoleApp1
{
    public class Class1
    {
        private readonly PersonelRepository _personelRepository;

        public Class1(PersonelRepository personelRepository)
        {
            _personelRepository = personelRepository;
        }

        public void Run()
        {
            // GetAll metodunu çağırarak örnek doğru çalıştığını kontrol edelim
            var personelList = _personelRepository.GetAll();

            foreach (var personel in personelList)
            {
                Console.WriteLine(personel.Name);
            }
        }

        public static void Main(string[] args)
        {
             //PersonelGetAll();
            //CreatePersonel();
            UpdatePersonel();

           // Update2();

        }

        private static void Update2()
        {
            Personel personel = new Personel();
            personel.SurName = "SurName";
            PersonelRepository personelRepository = new PersonelRepository();
            personelRepository.UpdateById(personel, 4);
        }

        private static void UpdatePersonel()
        {
            Personel personel = _personelRepository.GetById(4);
            personel.Id = 4;
            personel.Name = "Ali";
            personel.SurName = "Dogru";
            PersonelRepository personelRepository = new PersonelRepository();
            personelRepository.Update(personel);
        }

        private static void CreatePersonel()
        {
            PersonelRepository personelRepository = new PersonelRepository();
            Personel personel = new Personel();
            personel.Name = "Ahmet";
            personel.SurName = "Kaya";
            personel.Age = 40;
            personel.JobId = 1;
            personelRepository.Add(personel);
        }

        private static void PersonelGetAll()
        {
            PersonelRepository personelRepository = new PersonelRepository();

            foreach (var personel in personelRepository.GetAll())
            {
                Console.WriteLine("********  " + personel.Name + " *******");
            }
        }
    }
}
