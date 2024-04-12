using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSApp
{
    interface IHouseCRUD  //  Interface for perfoming CRUD operations with the House class
    {
        int GetMaxMLS();
        int GetPriceCat(int price);
        int GetAreaCat(int area);
        void AddHouse(House house);
        void RemoveHouse(House house);
        void UpdateHouse(int MLS, House house);
        ICollection<House> GetHouses();
        House GetHouse(int MLS);
    }
    class HouseCRUD : IHouseCRUD
    {
        MLSAppDBEntities entities;  //  Used to access and modify the DB
        public HouseCRUD()
        {
            entities = new MLSAppDBEntities();
        }
        public void AddHouse(House house)  //  Add the passed house info to the DB
        {
            entities.Houses.Add(house);
            entities.SaveChanges();
        }

        public int GetAreaCat(int area)  //  Calculate and return AreaCat based on passed area
        {
            if (area < 1500) { return 1; }  //  Returned values match index of catagories in combo box 
            if (area >= 1500 && area < 2000) { return 2; }
            if (area >= 2000 && area < 2500) { return 3; }
            if (area >= 2500 && area < 3000) { return 4; }
            if (area >= 3000 && area < 3250) { return 5; }
            if (area >= 3250) { return 6; }
            else return 7;
        }

        public House GetHouse(int MLS)  //  Find and return house from DB by MLS number
        {
            return entities.Houses.Find(MLS);
        }

        public ICollection<House> GetHouses()  //  Return the houses in the DB as a list
        {
            return entities.Houses.ToList();
        }

        public int GetMaxMLS()  //  Returns the max MLS in the DB (used to set new House MLS)
        {
            return entities.Houses.Max(h => h.MLS);
        }

        public int GetPriceCat(int price)  //  Calculate and return PriceCat based on passed price
        {
            if (price < 350000) { return 1; }  //  Returned values match index of catagories in combo box 
            if (price >= 350000 && price < 400000) { return 2; }
            if (price >= 400000 && price < 450000) { return 3; }
            if (price >= 450000 && price < 500000) { return 4; }
            if (price >= 500000 && price < 550000) { return 5; }
            if (price >= 550000 && price < 600000) { return 6; }
            if (price > 600000) { return 7; }
            else return 8;
        }

        public void RemoveHouse(House house)  //  Removes the passed House from DB
        {
            entities.Houses.Remove(house);
            entities.SaveChanges();
        }

        public void UpdateHouse(int MLS, House house)  //  Updates house info in DB
        {
            var houseupdate = entities.Houses.Find(MLS);
            houseupdate.MLS = house.MLS;
            houseupdate.Price = house.Price;
            houseupdate.PriceCat = house.PriceCat;
            houseupdate.Area = house.Area;
            houseupdate.AreaCat = house.AreaCat;
            houseupdate.Bed = house.Bed;
            houseupdate.Bath = house.Bath;
            houseupdate.Street = house.Street;
            houseupdate.City = house.City;
            houseupdate.State = house.State;
            houseupdate.Zip = house.Zip;
            houseupdate.Description = house.Description;
            houseupdate.AgentID = house.AgentID;
            houseupdate.Picture = house.Picture;
            houseupdate.PictureFileName = house.PictureFileName;
            entities.SaveChanges();
        }
    }
}
