using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using NoisePollutionDashboard.DTOs;
using NoisePollutionDashboard.Models;
using NoisePollutionDashboard.ViewModels;
using PagedList;

namespace NoisePollutionDashboard.Controllers
{
    public class NoisePollutionController : Controller
    {
        EformsContext.EformsContext _context = new EformsContext.EformsContext();

        public ActionResult Dashboard(string searchBy, string search, string sortBy, int? page)
        {
//            ViewBag.SortReportType = string.IsNullOrEmpty(sortBy) ? "Report desc" : "";
            ViewBag.SortReportType = sortBy == "ReportType" ? "Report desc" : "ReportType";
            ViewBag.SortNoiseType = sortBy == "ResComm Type" ? "ResComm desc" : "ResComm Type";
            ViewBag.SortDayDetail = sortBy == "DayDetail" ? "Day desc" : "DayDetail";
            ViewBag.SortWeekDetail = sortBy == "WeekDetail" ? "Week desc" : "WeekDetail";

            NoisePollutionModel model;

            if (searchBy == "eformRef")
            {
                model = new NoisePollutionModel(_context.SearchByEformReference(search), page);
            }
            else if (searchBy == "civicaRef")
            {
                model = new NoisePollutionModel(_context.SearchByCivicaReference(search), page);
            }
            else if (searchBy == "uprn")
            {
                model = new NoisePollutionModel(_context.SearchByUPRN(search), page);
            }
            else
            {
                model = new NoisePollutionModel(_context.SelectAll(), page);
            }

            var rows = _context.SelectAll();

            switch (sortBy)
            {
                case "Report desc":
                    rows = rows.OrderBy(r => r.REPORT_TYPE).ToList();
                    model = new NoisePollutionModel(rows, 1);
                    break;
                case "ResComm desc":
                    rows = rows.OrderBy(r => r.RESIDENTIAL_COMMERCIAL).ToList();
                    model = new NoisePollutionModel(rows, 1);
                    break;
                case "Day desc":
                    rows = rows.OrderBy(r => r.DAYTIME_EVENING).ToList();
                    model = new NoisePollutionModel(rows, 1);
                    break;
                case "Week desc":
                    rows = rows.OrderBy(r => r.WEEKEND_WEEKDAY).ToList();
                    model = new NoisePollutionModel(rows, 1);
                    break;
            }

            return View(model);
        }

        public ActionResult FailedRecords(int? page)
        {
            var model = new NoisePollutionModel(_context.SelectAllFailedRecords(), page);
            return View(model);
        }

        public ActionResult Reports()
        {
            var list = _context.SelectAll();

            //chart data selection for REPORT_TYPE field values
            var countReportType = new List<int>();
            var reportType = list.Select(rTR => rTR.REPORT_TYPE).Distinct().ToList();
            foreach (var item in reportType)
            {
                countReportType.Add(list.Count(x => x.REPORT_TYPE == item));
            }
            ViewBag.reportType = reportType;
            ViewBag.rep = countReportType;

            //chart data selection for RESIDENTIAL_COMMERCIAL field values
            var countResComm = new List<int>();
            var resComm = list.Select(rS => rS.RESIDENTIAL_COMMERCIAL).Distinct().ToList();
            foreach (var item in resComm)
            {
                countResComm.Add(list.Count(x => x.RESIDENTIAL_COMMERCIAL == item));
            }
            ViewBag.resComm = resComm;
            ViewBag.rep1 = countResComm;

            //chart data selection for NOISE_TYPE field values
            var countNoiseType = new List<int>();
            var noiseType = list.Select(rS => rS.NOISE_TYPE).Distinct().ToList();
            foreach (var item in noiseType)
            {
                countNoiseType.Add(list.Count(x => x.NOISE_TYPE == item));
            }
            ViewBag.noiseType = noiseType;
            ViewBag.rep2 = countNoiseType;

            //chart data selection for WEEKEND_WEEKDAYS
            var countWeekendWeekday = new List<int>();
            var weekendWeekday = list.Select(rS => rS.WEEKEND_WEEKDAY).Distinct().ToList();
            foreach (var item in weekendWeekday)
            {
                countWeekendWeekday.Add(list.Count(x => x.WEEKEND_WEEKDAY == item));
            }
            ViewBag.weekendWeekday = weekendWeekday;
            ViewBag.rep3 = countWeekendWeekday;

//            List<string> postcodes = new List<string>();
//            postcodes.Add("EC1V 2DD");
//            postcodes.Add("EC1M 51D");
//
//            var query = postcodes.Select(x => x.Split(' ')[1]).ToList();
//            foreach (var item in query)
//            {
//                Console.WriteLine(item);
//            }

            return View();

        }
    }
}