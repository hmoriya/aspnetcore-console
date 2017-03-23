using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using mssql.Models;

namespace mssql
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new NorthwindContext()){
                
                foreach (var item in db.Products
                                        .Distinct()
                                        .Where(p=>p.CategoryId > 4)
                                        .ToList())
                {
                    System.Console.WriteLine( item.ProductName );
                }
                var list = db.Products;
                foreach(var item in list){
                    System.Console.WriteLine( item.ProductId );
                }
                var query = db.Products
                    //.Include(p=>p.Category)
                    .Where(p=>p.CategoryId == 1);
                
                    //.Select(c=>c.CategoryId == 1);
            }
        }
    }
}
