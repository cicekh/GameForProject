using GameForProject.Abstract.MicroServices;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    public class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.LastName=="haydar")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
