using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;



namespace SBKAvtal.Controllers
{
    public class AvtalskatalogController : Controller
    {
        //
        // GET: /Avtalskatalog/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabell()
        {
            var lst = new List<Models.Avtalsmodel>();

            using (var conn = new NpgsqlConnection("Host=localhost;Username=arvid;password=pass;Database=avtalskatalogSBK"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select id, enligt_avtal from sbkavtal.avtal";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lst.Add(new Models.Avtalsmodel
                            {
                                diarienummer = 0,
                                startdate = DateTime.Now,
                                enddate = DateTime.Now,
                                orgnummer = "xxxxxx-xxxx",
                                enligtAvtal = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return View(lst);
        }

    }
}
