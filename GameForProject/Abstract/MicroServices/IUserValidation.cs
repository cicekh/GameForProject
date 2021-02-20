using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Abstract.MicroServices
{
    public interface IUserValidation
    {
        bool Validate(Gamer gamer);
    }
}
