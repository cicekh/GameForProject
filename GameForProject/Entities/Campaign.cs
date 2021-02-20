using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfStart { get; set; }
        public string DateOfEnd { get; set; }
        public double Price { get; set; }
        public int CampaingTypeId { get; set; }

    }
}
