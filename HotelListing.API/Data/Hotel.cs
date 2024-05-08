using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel //entity is used to model a table... so we made an entity named hotel and gave it properties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MyProperty { get; set; }
        public double Rating { get; set; }
        //foreign key refrence between the hotel and a country
        [ForeignKey(nameof(CountryId))] //by using nameof we can avoid mistakes that may come from mismatch in string name i.e. [ForeignKey("CountryId")] if country id gets changed we can make this simple mistake and not change it here
        public int CountryId {  get; set; }
        public Country MyProper { get; set; }

    }
}
