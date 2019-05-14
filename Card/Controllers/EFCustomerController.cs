using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Card_EF_Model;
using Card_EF_IDAL;
using Card_EF_DAL;
using Card_EF_BILL;
using Car_EF_Factory;
using Card_EF_IBLL;

namespace Card.Controllers
{
    public class EFCustomerController : Controller
    {
        private log4net.ILog log = log4net.LogManager.GetLogger("EFCustomerController");
        private IT_CustomInfo_TBService bll = new T_CustomInfo_TBService();
        public ActionResult Index()
        {
            log.Info("这是日志信息！");
            log.Error("这是错误信息！");
            IList<T_CustomInfo_TB> culist = bll.GetListAll();

            return View(culist);
        }

        // GET: EFCustomer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EFCustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EFCustomer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EFCustomer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EFCustomer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EFCustomer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EFCustomer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
