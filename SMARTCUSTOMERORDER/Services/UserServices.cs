using Microsoft.EntityFrameworkCore;
using SMARTCUSTOMERORDER.Data;
using SMARTCUSTOMERORDER.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SMARTCUSTOMERORDER.Services
{
    public class UserServices
    {
        private readonly ApplicationDbContext _Context;
        public UserServices(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public List<UserDataTable> GetUserinfo(int SNo)
        {
            var ui = new SqlParameter("@SNo", SNo);
            List<UserDataTable> UserList = new List<UserDataTable>();
            try
            {
                UserList = _Context.UserDataTables.FromSql("Exec GetList @SNo", ui).ToList();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            return UserList;
        }
        public void UpdateUserDetails(Userxml Userxml)
        {
            var Uservar = new SqlParameter("@User", Userxml.GetXml());
            try
            {
                _Context.Database.ExecuteSqlCommand("Exec UserDetails @User", Uservar);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }
        public void DeleteUserInfo(int SNo)
        {
            var Sno = new SqlParameter("@SNo", SNo);
            try
            {
                _Context.Database.ExecuteSqlCommand("Exec DeleteUser @SNo", Sno);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }
        public List<Products> GetProducts(int Productid)
        {
            var us = new SqlParameter("@Productid", Productid);
            List<Products> ProductsList = new List<Products>();
            try
            {
                ProductsList = _Context.Productsdb.FromSql("Exec GetProductsLists @Productid", us).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return ProductsList;
        }
        public List<Carts> GetCartinfo(int Productid)
        {
            var ui = new SqlParameter("@Productid", Productid);
            List<Carts> CartsList = new List<Carts>();
            try
            {
                CartsList = _Context.Cartsdb.FromSql("Exec GetCartList @Productid", ui).ToList();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            return CartsList;
        }
        public void UpdateCartDetails(Productxml Productxml)
        {
            var Uservar = new SqlParameter("@Cid", Productxml.GetXml());
            try
            {
                _Context.Database.ExecuteSqlCommand("Exec UpdateCart @Cid", Uservar);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }
        public void DeleteItems(int Productid)
        {
            var productid = new SqlParameter("@Productid", Productid);
            try
            {
                _Context.Database.ExecuteSqlCommand("Exec DeleteItems @Productid", productid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
