using MyAdvPro3.Models;
using MyAdvPro3.My3Dbcontext;


namespace MyAdvPro3.Repository
{
    public class CarsClass : ICars
    {

        private ApplicationDb3 _context;
        
        public CarsClass(ApplicationDb3 context)
        {
            _context = context;
        }

        public List<CarsModel> Get()
        {
            List<CarsModel> stdlist = (from obj in _context.Cars
                                       select obj).ToList();
            return stdlist;
        }



        public void Add(string type, int price, bool forSale, bool forRent)
        {
            CarsModel std = new CarsModel();

            std.Type = type;
            std.Price = price;
            std.ForSale = forSale;
            std.ForRent = forRent;
            _context.Cars.Add(std);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            CarsModel std = (from obj in _context.Cars
                             where obj.Id == id
                             select obj).FirstOrDefault();
            _context.Cars.Remove(std);
            _context.SaveChanges();
        }

        public CarsModel Details(int id)
        {
            CarsModel car = (from obj in _context.Cars
                             where obj.Id == id
                             select obj).FirstOrDefault();
            return car;
        }


        public void Update(int id, string type, int price, bool forSale, bool forRent)
        {
            CarsModel car = (from obj in _context.Cars
                             where obj.Id == id
                             select obj).FirstOrDefault();

            if (type != null) { car.Type = type; }
            if (price != null) { car.Price = price; }
            if (forSale != null) { car.ForSale = forSale; }
            if (forRent != null) { car.ForRent = forRent; }

            _context.SaveChanges();
        }

        public List<CarsModel> GetCarsforsale(bool ForSale)
        {
            List<CarsModel> stdlist = (from obj in _context.Cars
                                       where obj.ForSale == true
                                       select obj).ToList();
            return stdlist;
        }

        public List<CarsModel> GetCarsforrent(bool ForRent)
        {
            List<CarsModel> stdlist = (from obj in _context.Cars
                                       where obj.ForRent == true
                                       select obj).ToList();
            return stdlist;
        }

        public List<CarsModel> GetCarsforsaleAndRent(bool ForSale, bool ForRent)
        {
            List<CarsModel> stdlist = (from obj in _context.Cars
                                       where obj.ForRent == true && obj.ForSale == true
                                       select obj).ToList();
            return stdlist;
        }


        
    }
}
