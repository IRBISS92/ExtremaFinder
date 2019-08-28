using System;
using System.Web.Mvc;
using ExtremaFinder.Models;
using ExtremaFinder.Core;

namespace ExtremaFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChartPartial(FormCollection problem)
        {
            ViewBag.Series = new Series().GetSeries(
                problem["Function"],
                int.Parse(problem["LowerLimit"]),
                int.Parse(problem["HigherLimit"])
            );
            ViewBag.Peaks = new Peaks().GetPeaks(
                ViewBag.Series,
                problem["ExtremumType"]
            );
            return PartialView("_ChartPartial");
        }
    }
}