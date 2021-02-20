using GameForProject.Abstract;
using GameForProject.Abstract.MicroServices;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;

        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer))
            {
                Console.WriteLine("Gamer Added:" + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Validation failure. Gamer does not added!");
            }
           
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
