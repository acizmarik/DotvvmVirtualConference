using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotvvmVirtualConference.ViewModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisteredAt { get; set; }
    }

    public enum Category { Red = 1, Green = 2, Blue = 3 }

    public class ClientSideFilteringViewModel : MasterPageViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "Alice", Category = Category.Red, RegisteredAt = DateTime.Parse("2018-06-02T03:20:45"), IsActive = true },
            new Customer() {Id = 2, Name = "Dean", Category = Category.Green, RegisteredAt = DateTime.Parse("2018-06-02T20:45:29"), IsActive = false },
            new Customer() {Id = 3, Name = "Everett", Category = Category.Blue, RegisteredAt = DateTime.Parse("2018-01-18T00:09:20"), IsActive = false },
            new Customer() {Id = 4, Name = "Jenny", Category = Category.Blue, RegisteredAt = DateTime.Parse("2018-10-20T13:16:35"), IsActive = true },
            new Customer() {Id = 5, Name = "Carl", Category = Category.Blue, RegisteredAt = DateTime.Parse("2019-05-29T16:47:25"), IsActive = true },
            new Customer() {Id = 6, Name = "Karen", Category = Category.Red, RegisteredAt = DateTime.Parse("2019-02-15T11:37:15"), IsActive = false },
            new Customer() {Id = 7, Name = "John", Category = Category.Red, RegisteredAt = DateTime.Parse("2020-05-28T20:57:41"), IsActive = true },
            new Customer() {Id = 8, Name = "Johnny", Category = Category.Red, RegisteredAt = DateTime.Parse("2018-01-21T07:03:41"), IsActive = false },
            new Customer() {Id = 9, Name = "Robert", Category = Category.Green, RegisteredAt = DateTime.Parse("2019-05-22T18:58:33"), IsActive = true }
        };

        public List<Customer> FilteredCustomers { get; set; }
    }
}

