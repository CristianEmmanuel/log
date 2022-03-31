using Login.Entities;
using Login.Helpers;

namespace Login.Services
{

    public interface IProvinceService
    {
        Province GetByName(string name);
    }

    public class ProvinceService : IProvinceService
    {
        private DataContext _context;

        public ProvinceService(DataContext context)
        {
            _context = context;
        }

        public Province GetByName(string name)
        {
            throw new NotImplementedException();
        }

        //public Province GetByName(string name);
        //      {
        //          var provinces = "https://apis.datos.gob.ar/georef/api/provincias?nombre=" && name();

        //          if (provinces == null)
        //              throw new AppException("User not found");

        //          return provinces;
        //      }

    }
}
