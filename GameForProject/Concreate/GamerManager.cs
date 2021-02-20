using GameForProject.Abstract;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer Added:" + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted:" + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated:" + gamer.FirstName);
        }
    }
}
