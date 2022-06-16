using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0616_final_410919954.Controllers
{
    public class VoiceController : Controller
    {
        public ActionResult Serach()
        { 
            return View();
        }


            [HttpPost]
        public ActionResult  Serach  (string name, string num)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMes = "請輸入名字";
            }
            if (num.IsNullOrWhiteSpace())
            {
                ViewBag.NumMes = "請輸入數字";
            }

            if (!name.IsNullOrWhiteSpace() && !num.IsNullOrWhiteSpace())
            {
                ViewBag.Name = name;

                if (num == "1")
                {
                    ViewBag.Mes = "do";
                }
                else if (num == "2")
                {
                    ViewBag.Mes = "re";
                }
                else if (num == "3")
                {
                    ViewBag.Mes = "mi";
                }
                else if (num == "4")
                {
                    ViewBag.Mes = "fa";
                }
                else if (num == "5")
                {
                    ViewBag.Mes = "so";
                }
                else if (num == "6")
                {
                    ViewBag.Mes = "la";
                }
                else if (num == "7")
                {
                    ViewBag.Mes = "xi";
                }
                else
                {
                    ViewBag.Mes = "請輸入 1 - 7 之間的數！";
                }
            }
            return View();
        }
    }
}