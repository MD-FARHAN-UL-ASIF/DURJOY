using AutoMapper;
using BLL.DTOs;
using DAL.EF.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BuyerService
    {
        public static BuyerDTO Get(int id)
        {
            var data = DataFactory.BuyerData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Buyer, BuyerDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<BuyerDTO>(data);
            return ret;
        }

        public static void Create(BuyerDTO b)
        {
            //convert buyerDTO to Buyer
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyerDTO, Buyer>();
            });
            var mapper = new Mapper(config);
            var buyer = mapper.Map<Buyer>(b);
            DataFactory.BuyerData().Create(buyer);
        }

        public static List<BuyerDTO> Get()
        {
            var data = DataFactory.BuyerData().Get(); //List<Buyer> ef model
            //mapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Buyer, BuyerDTO>();
            });
            var mapper = new Mapper(config);
            var retdata = mapper.Map<List<BuyerDTO>>(data);
            return retdata;
        }

        public static void Delete(int id)
        {
            DataFactory.BuyerData().Delete(id);
        }

        public static void Update(BuyerDTO b)
        {
            //convert buyerDTO to Buyer
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyerDTO, Buyer>();
            });
            var mapper = new Mapper(config);
            var buyer = mapper.Map<Buyer>(b);
            DataFactory.BuyerData().Update(buyer);
        }
    }
}
