using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace u19072237HW3.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
             return View();
           
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string Type)
        {
            try
            {
                if (file != null && file.ContentLength > 0)
                {
                    string filename = Path.GetFileName(file.FileName);
                    string filepath = Path.Combine(Server.MapPath("/Media/" + Type), filename);
                    file.SaveAs(filepath);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }

        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

       
    }
}