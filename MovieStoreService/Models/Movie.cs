using System.Collections.Generic;

namespace MovieStoreService.Models
{
    public class Movie : BaseModel
    {
        public List<Award> Awards { get; set; }
        public List<Actor> Cast { get; set; }
        public string Name { get; set; }
        public Country Nationality { get; set; }
        public int Year { get; set; }
        public Category Category { get; set; }
    }
}