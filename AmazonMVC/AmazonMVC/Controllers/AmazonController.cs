using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazonMVC.Models;

namespace AmazonMVC.Controllers
{
    public class AmazonController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            //string[,] p = new string[2, 2];
            //p[0, 0] = "Toothbrush";
            //p[0, 1] = "High quality brush";
            //p[0, 2] = "2.99";

            //p[1,0]= "Super Smash Bros 3DS";
            //p[1,1]= "Overpriced and dated game that never reduces is price.";
            //p[1,2]= "47.99";
            //p[2,0]= "Amazon Echo (2nd Gen)";
            //p[2,1]= "The 2nd generation Amazon Echo has a 2.5” downward-firing woofer and 0.6” tweeter powered by Dolby, delivering crisp vocals and dynamic bass throughout the room. You can play music from Amazon Music, Spotify, TuneIn and more. With Amazon Music, you can search by lyrics, time period or let Alexa pick the music for you. ";
            //p[2,2]= "69.99";

            Products p = new Products("Toothbrush", "https://www.amazon.co.uk/Oral-B-13281922-Pro-Expert-All-In-One-Toothbrush/dp/B001E97CZ2/ref=sr_1_13?crid=2L0U2FMO3WYEF&keywords=toothbrush&qid=1552467937&s=gateway&sprefix=tooth%2Caps%2C203&sr=8-13", "High quality brush, good for your teeth.", 3.18);
            Products p1 = new Products("Super Smash Bros 3DS", "https://www.amazon.co.uk/Super-Smash-Bros-3DS-Nintendo/dp/B00B8QDNVI/ref=sr_1_1?crid=RIJSUXH6V8EM&keywords=super+smash+bros+3ds&qid=1552468043&s=gateway&sprefix=Super+smash+%2Caps%2C211&sr=8-1", "Overpriced and dated game that never reduces is price.", 38.91);
            Products p2 = new Products("Amazon Echo (2nd Gen)", "https://www.amazon.co.uk/Amazon-Echo-2nd-Generation-Charcoal-Fabric/dp/B06Y5ZW72J/ref=sr_1_1?crid=1SO5TWZUQQWPY&keywords=amazon+echo+2nd+generation&qid=1552468122&s=gateway&sprefix=amazon+echo%2Caps%2C200&sr=8-1", "The 2nd generation Amazon Echo has a 2.5” downward-firing woofer and 0.6” tweeter powered by Dolby, delivering crisp vocals and dynamic bass throughout the room. You can play music from Amazon Music, Spotify, TuneIn and more. With Amazon Music, you can search by lyrics, time period or let Alexa pick the music for you. ", 89.99);
            List<Products> prod = new List<Products>();
            prod.Add(p);
            prod.Add(p1);
            prod.Add(p2);
            ViewBag.Products= prod;
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}