using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMARTCUSTOMERORDER.Data;
using SMARTCUSTOMERORDER.Models;
using SMARTCUSTOMERORDER.Services;

namespace SMARTCUSTOMERORDER.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _Context;
        private readonly UserServices _UserServices;
        public UserController(ApplicationDbContext Context)
        {
            _Context = Context;
            _UserServices = new UserServices(Context);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserMainForm()
        {
            UserContactDetails model = new UserContactDetails();
            List<UserDataTable> UserList = new List<UserDataTable>();
            model.UserDataTableList = _UserServices.GetUserinfo(0);
            return View(model);
        }
        public IActionResult UserContact(Userxml UserDataxml)
        {
            _UserServices.UpdateUserDetails(UserDataxml);
            UserContactDetails model = new UserContactDetails();
            model.UserDataTableList = _UserServices.GetUserinfo(0);
            return PartialView("UserList", model);
        }
        public IActionResult Edit(int SN)
        {
            UserContactDetails model = new UserContactDetails();
            model.UserDataTableList = _UserServices.GetUserinfo(SN);
            Userxml Userxml = new Userxml();
            foreach (var item in model.UserDataTableList)
            {
                Userxml.SNo = item.SNo;
                Userxml.Name = item.Name;
                Userxml.Surname = item.Surname;
                Userxml.Gender = item.Gender;
                Userxml.Email = item.Email;
            }
            model.UserDataxml = Userxml;
            return PartialView("UserContact", model);
        }
        public IActionResult Delete(int SNo)
        {
            _UserServices.DeleteUserInfo(SNo);
            UserContactDetails model = new UserContactDetails();
            model.UserDataTableList = _UserServices.GetUserinfo(0);
            return PartialView("UserList", model);
        }
        public IActionResult ProductForm()
        {
            UserContactDetails model = new UserContactDetails();
            List<Products> ProductsList = new List<Products>();
            model.ProductsList = _UserServices.GetProducts(0);
            return View("ProductForm", model);
        }
        public IActionResult CartForm()
        {
            UserContactDetails model = new UserContactDetails();
            List<Carts> CartsList = new List<Carts>();
            model.CartsList = _UserServices.GetCartinfo(0);
            return View("CartForm", model);
        }
        public IActionResult Remove(int Productid)
        {
            _UserServices.DeleteItems(Productid);
            UserContactDetails model = new UserContactDetails();
            model.CartsList = _UserServices.GetCartinfo(0);
            return View("CartForm", model);
        }
        public IActionResult Add(Productxml ProductDataxml)
        {
            _UserServices.UpdateCartDetails(ProductDataxml);
            UserContactDetails model = new UserContactDetails();
            model.ProductsList = _UserServices.GetProducts(0);
            return View("ProductForm", model);
        }
    }
}