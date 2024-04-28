using DAL.EF.Entities;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataFactory
    {
        public static IRepo<Buyer, int> BuyerData()
        {
            return new BuyerRepo();
        }
    }
}
