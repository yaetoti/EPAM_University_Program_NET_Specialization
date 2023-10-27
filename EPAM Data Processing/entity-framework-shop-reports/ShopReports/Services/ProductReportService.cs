using Microsoft.EntityFrameworkCore;
using ShopReports.Models;
using ShopReports.Reports;

namespace ShopReports.Services
{
    public class ProductReportService
    {
        private readonly ShopContext shopContext;

        public ProductReportService(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public ProductCategoryReport GetProductCategoryReport()
        {
            var lines = this.shopContext.Categories
                .Select(s => new ProductCategoryReportLine
                {
                    CategoryId = s.Id,
                    CategoryName = s.Name,
                })
                .OrderBy(s => s.CategoryName)
                .ToArray();

            return new ProductCategoryReport(lines, DateTime.Now);
        }

        public ProductReport GetProductReport()
        {
            var lines = this.shopContext.Products
               .Include(p => p.Title)
               .Include(p => p.Manufacturer)
               .Select(s => new ProductReportLine
               {
                   ProductId = s.Id,
                   ProductTitle = s.Title.Title,
                   Manufacturer = s.Manufacturer.Name,
                   Price = s.UnitPrice,
               })
               .OrderByDescending(s => s.ProductTitle)
               .ToArray();

            return new ProductReport(lines, DateTime.Now);
        }

        public FullProductReport GetFullProductReport()
        {
            var lines = this.shopContext.Products
               .Include(p => p.Title)
               .Include(p => p.Manufacturer)
               .Select(s => new FullProductReportLine
               {
                   ProductId = s.Id,
                   Name = s.Title.Title,
                   CategoryId = s.Title.CategoryId,
                   Manufacturer = s.Manufacturer.Name,
                   Price = s.UnitPrice,
                   Category = s.Title.Category.Name,
               })
               .OrderBy(s => s.Name)
               .ToArray();

            return new FullProductReport(lines, DateTime.Now);
        }

        public ProductTitleSalesRevenueReport GetProductTitleSalesRevenueReport()
        {
            var lines = this.shopContext.OrderDetails
                .Include(p => p.Product)
                .Include(p => p.Product.Title)
                .GroupBy(s => s.Product.Title.Title)
                .Select(g => new ProductTitleSalesRevenueReportLine
                {
                    ProductTitleName = g.Key,
                    SalesRevenue = g.Sum(s => s.PriceWithDiscount),
                    SalesAmount = g.Sum(s => s.ProductAmount),
                })
                .OrderByDescending(s => s.SalesRevenue)
                .ToArray();

            return new ProductTitleSalesRevenueReport(lines, DateTime.Now);
        }
    }
}
