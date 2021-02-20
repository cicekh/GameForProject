using GameForProject.Abstract;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    class NewSubscribeCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni üyelik kampanyası uygulandı");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Yeni üyelik kampanyası silindi");
        }

        public void Hesapla()
        {
            Console.WriteLine("İlk üyelik kampanyası uygulandı");      
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Yeni üyelik kampanyası güncelledi");
        }
    }
}
