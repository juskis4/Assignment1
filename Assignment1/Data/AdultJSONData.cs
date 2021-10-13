using System.Collections.Generic;
using System.Linq;
using Assignment1.Persistence;
using Models;

namespace Assignment1.Data
{
    public class AdultJSONData : IAdultData
    {
        private FileContext FileContext;
        private IList<Adult> adults;

        public AdultJSONData()
        {
            FileContext = new FileContext();
            adults = FileContext.Adults;
        }
        
        public IList<Adult> GetAdults()
        {
            IList<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            adult.Id = adults.Max(t => t.Id) + 1;
            adults.Add(adult);
            FileContext.SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult toUpdate = adults.First(t => t.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            toUpdate.Age = adult.Age;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            toUpdate.Weight = adult.Weight;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.JobTitle.Salary = adult.JobTitle.Salary;
            FileContext.SaveChanges();
        }

        public void removeAdult(int AdultId)
        {
            Adult toRemove = adults.First(t => t.Id == AdultId);
            adults.Remove(toRemove);
            FileContext.SaveChanges();
        }
        

        public Adult get(int id)
        {
            return adults.FirstOrDefault(t => t.Id == id);
        }
    }
}