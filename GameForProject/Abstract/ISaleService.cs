using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Abstract
{
    interface ISaleService
    {
        void Add();
        void Update(Sale sale);
        void Delete(Sale sale);

    }
}
