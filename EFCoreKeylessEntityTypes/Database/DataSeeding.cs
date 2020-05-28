using EFCoreKeylessEntityTypes.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreKeylessEntityTypes.Database
{
    public static class DataSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "1", QGroup = "1" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "2", QGroup = "1" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "3", QGroup = "1" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "4", QGroup = "1" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "5", QGroup = "2" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "6", QGroup = "2" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "7", QGroup = "2" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "8", QGroup = "3" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "9", QGroup = "3" });
            modelBuilder.Entity<QLink>().HasData(new QLink { QNumber = "10", QGroup = "4" });

            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "1", QNumber = "1" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "2", QNumber = "1" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "3", QNumber = "2" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "4", QNumber = "2" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "5", QNumber = "3" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "6", QNumber = "3" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "7", QNumber = "4" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "8", QNumber = "4" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "9", QNumber = "5" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "10", QNumber = "6" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "11", QNumber = "6" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "12", QNumber = "6" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "13", QNumber = "7" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "14", QNumber = "7" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "15", QNumber = "8" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "16", QNumber = "8" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "17", QNumber = "9" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "18", QNumber = "9" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "19", QNumber = "10" });
            modelBuilder.Entity<SalesOrders>().HasData(new SalesOrders { SalesOrder = "20", QNumber = "10" });

            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "1", SalesOrderID = "1", PartNumber = "1", OrderQuantity = 10, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "2", SalesOrderID = "1", PartNumber = "2", OrderQuantity = 20, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "3", SalesOrderID = "2", PartNumber = "3", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "4", SalesOrderID = "3", PartNumber = "1", OrderQuantity = 70, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "5", SalesOrderID = "3", PartNumber = "2", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "6", SalesOrderID = "4", PartNumber = "2", OrderQuantity = 30, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "7", SalesOrderID = "4", PartNumber = "3", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "8", SalesOrderID = "5", PartNumber = "2", OrderQuantity = 60, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "9", SalesOrderID = "5", PartNumber = "3", OrderQuantity = 50, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "10", SalesOrderID = "5", PartNumber = "4", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "11", SalesOrderID = "6", PartNumber = "1", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "12", SalesOrderID = "7", PartNumber = "2", OrderQuantity = 30, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "13", SalesOrderID = "8", PartNumber = "3", OrderQuantity = 20, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "14", SalesOrderID = "9", PartNumber = "4", OrderQuantity = 10, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "15", SalesOrderID = "10", PartNumber = "5", OrderQuantity = 60, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "16", SalesOrderID = "11", PartNumber = "2", OrderQuantity = 50, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "17", SalesOrderID = "12", PartNumber = "3", OrderQuantity = 40, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "18", SalesOrderID = "12", PartNumber = "1", OrderQuantity = 90, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "19", SalesOrderID = "13", PartNumber = "4", OrderQuantity = 80, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "20", SalesOrderID = "14", PartNumber = "2", OrderQuantity = 30, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "21", SalesOrderID = "15", PartNumber = "3", OrderQuantity = 20, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "22", SalesOrderID = "16", PartNumber = "4", OrderQuantity = 60, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "23", SalesOrderID = "17", PartNumber = "1", OrderQuantity = 80, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "24", SalesOrderID = "18", PartNumber = "1", OrderQuantity = 90, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "25", SalesOrderID = "18", PartNumber = "2", OrderQuantity = 100, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "26", SalesOrderID = "19", PartNumber = "2", OrderQuantity = 10, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "27", SalesOrderID = "19", PartNumber = "3", OrderQuantity = 20, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "28", SalesOrderID = "19", PartNumber = "4", OrderQuantity = 55, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "29", SalesOrderID = "20", PartNumber = "5", OrderQuantity = 78, UHeight = 0 });
            modelBuilder.Entity<SalesOrdersItems>().HasData(new SalesOrdersItems { SalesOrderItem = "30", SalesOrderID = "20", PartNumber = "1", OrderQuantity = 45, UHeight = 0 });
        }
    }
}