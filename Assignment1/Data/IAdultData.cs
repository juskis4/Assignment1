using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void Update(Adult adult);
        void removeAdult(int AdultId);
        Adult get(int id);
    }
}
