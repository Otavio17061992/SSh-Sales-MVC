using SalesMVCCore.Models.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVCCore.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // list of sellers 
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department()
        {

        }

        public Department(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public void AddSeller(Seller seler)
        {
            Sellers.Add(seler);
        }

        public double TotalSales(DateTime initial,DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSale(initial, final));
        }
    }
}
