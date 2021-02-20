using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PayType { get; set; }
    }
}
