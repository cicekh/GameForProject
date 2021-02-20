using GameForProject.Concreate;
using GameForProject.Entities;
using System;

namespace GameForProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new newUserValidationManager());
            
            Gamer gamer = new Gamer { FirstName = "murat", LastName = "mehmetoğlu", UserName = "cicekh", BirthYear = new DateTime(1980, 1, 1).Year, Id = 1, NationalityId = 90 };


            gamerManager.Add(gamer);
        }
    }
}
