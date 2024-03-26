using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaApplication3.Models;
namespace WpfApp10.data
{
    public static class DataWorker
    {
        public static List<Place> GetPlaces()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.places.ToList();
                return result;


            }
        }

        public static string CreatePlace(string name, string street)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool CheckIsExists = db.places.Any(el => el.Name == name);
                if (!CheckIsExists)
                {
                    Place newPlace = new Place() { Name = name, Street = street };
                    db.places.Add(newPlace);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;


            }


        }

        public static string DeletePlace(Place place)
        {
            string result = "Такого места не существует";
            using (ApplicationContext db = new ApplicationContext())
            {

                db.places.Remove(place);
                db.SaveChanges();
                result = "Удален " + place.Name;




            }
            return result;

        }

        public static string EditPlace(Place oldplace, string name)
        {
            var result = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                Place place = db.places.FirstOrDefault(p => p.Id == oldplace.Id);
                place.Name = name;
                db.SaveChanges();
                result = "Изменен" + place.Name;




            }
            return result;

        }

    }
}
