using Microsoft.EntityFrameworkCore;
using ShopReports.Models;
using ShopReports.Reports;

namespace ShopReports.Services
{
    public class CustomerReportService
    {
        private readonly ShopContext shopContext;

        public CustomerReportService(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public CustomerSalesRevenueReport GetCustomerSalesRevenueReport()
        {
            var lines = this.shopContext.OrderDetails
                .Include(p => p.Order)
                .Include(p => p.Order.Customer)
                .Where(p => p.Order.Customer != null)
                .GroupBy(s => s.Order.Customer!.Id)
                .Select(g => new CustomerSalesRevenueReportLine
                {
                    CustomerId = g.Key,
                    PersonFirstName = g.First().Order.Customer!.Person.FirstName,
                    PersonLastName = g.First().Order.Customer!.Person.LastName,
                    SalesRevenue = g.Sum(x => x.PriceWithDiscount),
                })
                .OrderByDescending(l => l.SalesRevenue)
                .ToArray();

            return new CustomerSalesRevenueReport(lines, DateTime.Now);
        }
    }
}
