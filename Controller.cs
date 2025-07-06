using Microsoft.AspNetCore.Mvc;
using MyAdvPro3.Models;
using MyAdvPro3.Repository;

namespace MyAdvPro3.Controllers
{
    public class CarsController1 : Controller
    {
        private ICars _CarsRepository;

       // public object ForSale { get; private set; }

        public CarsController1(ICars CarsRepository)
        {

            _CarsRepository = CarsRepository;
        }
        public IActionResult Index()
        {
            List<CarsModel> listOfCarsModel = _CarsRepository.Get();
            return View(listOfCarsModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add( string type, int price, bool forSale, bool forRent)
        {
            _CarsRepository.Add(  type, price, forSale,forRent);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           CarsModel std = _CarsRepository.Details(id);
            return View(std);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            CarsModel std = _CarsRepository.Details(id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Update(int id, string type, int price, bool forSale, bool forRent)
        {
            _CarsRepository.Update(id, type, price,forSale,forRent);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
            {
                _CarsRepository.Delete(id);
                return RedirectToAction("Index");
            
        }

        public IActionResult GetCarsforsale(bool forsale)
        {
            List<CarsModel> listOfCarsModel1 = _CarsRepository.GetCarsforsale(forsale);
            return View(listOfCarsModel1);
        }

        public IActionResult GetCarsforrent(bool forRent)
        {
            List<CarsModel> listOfCarsModel2 = _CarsRepository.GetCarsforrent(forRent);
            return View(listOfCarsModel2);
        }

        public IActionResult GetCarsforsaleAndRent(bool ForSale,bool ForRent)
        {
            List<CarsModel> listOfCarsModel3 = _CarsRepository.GetCarsforsaleAndRent(ForSale,ForRent);
            return View(listOfCarsModel3);
        }

       
    }
}
