using System;

namespace MovieStoreService.Models
{
    public class Producer : BaseModel
    {
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Nationality { get; set; }
    }
}