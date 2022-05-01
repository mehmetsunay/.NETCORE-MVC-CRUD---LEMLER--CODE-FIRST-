using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService

    {     //ref ekle
        private IHotelRepository  _hotelrepository;

        //ctor tab tab
        public HotelManager()
        {    //interfacele classı esıtledım bagladım
            _hotelrepository = new HotelRepository();
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelrepository.CreateHotel(hotel);
        }

        

        public List<Hotel> GetAllHotels()
        {
            return _hotelrepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if(id>0)
            { 

            return _hotelrepository.GetHotelById(id);

            }

            throw new Exception("id sıfırdan küçük olamaz");
        }

        public void HotelDelete(int id)
        {
            _hotelrepository.DeleteHotel(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelrepository.UpdateHotel(hotel);
        }
    }
}
