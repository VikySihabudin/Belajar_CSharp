using System.Web.Mvc;


// namespace ini adalah nama dari project kita
namespace BELAJAR_CSHARP.Controllers
{
    // nama dari Class yang kita buat 
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            // return view() adalah mengembalikan nilai suaty type, dalam kasus di  bawah dia mengembalikan nilai di folder "View/Login/Index"
            return View();
        }

        // string fname, string Pass : Adalah Pembuatan Parameter fname dan pass bertipe data string
        // Parameter adalah sebuah variabel yang dinamis atau variabel yang berubah ubah isinya
        public ActionResult CheckUpass(string fname, string Pass)
        {
            if (fname == "admin" && Pass == "admin")
            {
                // RedirectToAction berfungsi membuka url/ memanggil action di dalam sebuah controller, dalam kasus di memanggil action about di dalam home controller  "Controller/HomeController" 
                return RedirectToAction("About", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

    }
}