using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Grids;
using System.Linq.Expressions;
using Syncfusion.Blazor.Inputs;

namespace Abp.BootstrapTheme.Blazor.Host.Pages
{
    public partial class Grid2
    {
       
        private string customerId { get; set; }
        SfGrid<OrderData> Grid { get; set; }
        public static List<OrderData> Orders { get; set; }

        private Query QueryData { get; set; }
        private async Task Serach()
        {
            QueryData = new Query();
            QueryData.Where("myWhere", "equal", customerId);
            Grid.GoToPage(1);

        }
        
         
        private async Task Add()
        {
            Console.WriteLine("add");
            
            var adddata = new OrderData()
            {
                OrderID = 1,
                CustomerID = "MJDGX",
                OrderDate = DateTime.Now,
                Freight = 3.01
            };
            await this.Grid.AddRecord(adddata);
            
            Console.WriteLine("added");

        }
        
        private async Task Update()
        {
            
        }

        private async Task Remove()
        {
            
        }

        private async Task OnSelect()
        {

            var lst= await this.Grid.GetSelectedRecords();

            foreach (var order in lst)
            {
                Console.WriteLine($"order.OrderID:{order.OrderID}");
            }
            // var selectIndex=await this.Grid.GetSelectedRowIndexes();
            //
            // foreach (var idx in selectIndex)
            // {
            //     Console.WriteLine($"indx:{idx}");
            // }
        
            await Task.CompletedTask;
        }

        private async Task RecordClickHandler(RecordClickEventArgs<OrderData> args)
        {
            
        }
        
    }
    
    
    public class OrderData
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }


        public OrderData()
        {
            
        }

        public OrderData(int? orderId, string CustomerID, DateTime? OrderDate, double? Freight)
        {
            this.OrderID = orderId;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
            this.Freight = Freight;
        }
    }
    
    public  static  class OrderDataDetails{
    
        
        public  static   List<OrderData> order = new List<OrderData>();
        public static List<OrderData> GetAllRecords()
        {
            
            order.Clear();
           
            int code = 10000;
            for (int i = 1; i < 15; i++)
            {
                order.Add(new OrderData(code+i,$"{code+i}",DateTime.Now, i));
            }
            return order;
        }
    
    }



    public class CusotomAdaptor : DataAdaptor
    {
        
        public override object Read(DataManagerRequest dm, string key = null)
        {

            
            foreach (var whereFilter in dm.Where)
            {
                Console.WriteLine($" {whereFilter.Field}--{whereFilter.value}");
            }
            
            Console.WriteLine($"dm{dm.Skip} {dm.Take}");
          //  var val = dm.Where.FirstOrDefault()?.value?.ToString();
            var lst=OrderDataDetails.GetAllRecords();
            
                return new DataResult()
                {
                    Count = lst.Count,
                    Result = lst
                }; 

           
          
        }
    }
}