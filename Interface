using MyAdvPro3.Models;

namespace MyAdvPro3.Repository
{
    public interface ICars
    {
        List<CarsModel> Get();
        List<CarsModel> GetCarsforsale( bool ForSale);
        List<CarsModel> GetCarsforsaleAndRent(bool ForSale, bool ForRent);
        List<CarsModel> GetCarsforrent(bool ForRent);
       // void GetCarsforsale(bool ForSale);

        void Add( string type, int price,bool ForSale, bool ForRent);
        void Delete(int Id);
        CarsModel Details(int Id);
        void Update(int Id, string type, int price,bool ForSale, bool ForRent);
        //List<CarsModel> GetCarsforsale(bool v, object forSale);
       
    }
}
         
