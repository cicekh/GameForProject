using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
