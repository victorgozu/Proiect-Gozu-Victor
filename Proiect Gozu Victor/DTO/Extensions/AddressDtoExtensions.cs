using Proiect_Gozu_Victor.Models;

namespace Proiect_Gozu_Victor.DTO.Extensions
{
    public static class AddressDtoExtensions

    {
        public static AddressToGetDto ToAddressToGet(this Address address)
        {
            if (address == null)
                return null;
            return new AddressToGetDto
            {
                City = address.City,
                Street = address.Street,
                No = address.No,
            };
        }
    }
}
