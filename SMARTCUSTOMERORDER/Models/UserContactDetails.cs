using PartialViewsDemos.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMARTCUSTOMERORDER.Models
{
    public class UserContactDetails
    {
        public Userxml UserDataxml { get; set; }
        public UserDataTable UserDataTable { get; set; }
        public List<UserDataTable> UserDataTableList { get; set; }
        public Productxml ProductDataxml { get; set; }
        public Products Products { get; set; }
        public List<Products> ProductsList { get; set; }
        public Carts Carts { get; set; }
        public List<Carts> CartsList { get; set; }
    }
    //Insert/Update
    public class Userxml : EntityBase
    {
        [Key]
        public int SNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
    //List
    public class UserDataTable
    {
        [Key]
        public int SNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
    public class Productxml : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public int Productid { get; set; }
    }
    public class Products
    {
        [Key]
        public int Productid { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public byte[] Images { get; set; }
    }
    public class Carts
    {
        [Key]
        public int Productid { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int TotalQuantity { get; set; }
        public byte[] Images { get; set; }
    }
}
