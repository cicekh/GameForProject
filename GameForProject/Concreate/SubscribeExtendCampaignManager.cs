using GameForProject.Abstract;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    class SubscribeExtendCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Üyelik uzatma kampanyası uygulandı");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Üyelik uzatma kampanyası silindi");
        }

        public void Hesapla()
        {
            Console.WriteLine("Üyelik yenileme kampanya hesaplandı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Üyelik uzatma kampanyası güncellendi");
        }
    }
}
