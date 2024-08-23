using Proiect_Gozu_Victor.Data;
using Proiect_Gozu_Victor.DTO;
using Proiect_Gozu_Victor.DTO.Extensions;
using Proiect_Gozu_Victor.Models;

namespace Proiect_Gozu_Victor.Services
{
    public class AddressesService
    {
        private readonly StudentsRegistryDbContext ctx;
        public AddressesService(StudentsRegistryDbContext ctx)
        {
            this.ctx = ctx;
        }

        public AddressToGetDto GetAddressById(int id) =>
           ctx.Address.FirstOrDefault(a => a.Id == id).ToAddressToGet();
        public Address AddAddress(string City, string Street, int No)
        {
            var address = ctx.Address.FirstOrDefault(s => s.City == City && s.Street == Street && s.No == No);
            if (address != null)
            {
                return address;
            }

            address = new Address { City = City, Street = Street, No = No };
            ctx.Address.Add(address);
            ctx.SaveChanges();
            return address;

        }
    }
}
