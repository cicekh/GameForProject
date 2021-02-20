using GameForProject.Abstract;
using GameForProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameForProject.Concreate
{
    class SaleManager : ISaleService
    {
        Gamer _gamer;
        ICampaignService _campaignService;
        public SaleManager(Gamer gamer, ICampaignService campaignService)
        {
            _gamer = gamer;
            _campaignService = campaignService;
        }



        public void Add()
        {
            _campaignService.Hesapla();
            Console.WriteLine(_gamer.FirstName + " için yukarıdaki kampanya ile satış işlemi gerçekleşti.");
        }

        public void Delete(Sale sale)
        {
            _campaignService.Hesapla();
            Console.WriteLine(_gamer.FirstName + " için yukarıdaki kampanya ile satış iptal edildi");
        }

        public void Update(Sale sale)
        {
            _campaignService.Hesapla();
            Console.WriteLine(_gamer.FirstName + " için yukarıdaki kampanya ile satış işlemi güncellendi.");
        }
    }
}
