using GameForProject.Abstract.MicroServices;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    public class newUserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
