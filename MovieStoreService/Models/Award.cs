namespace MovieStoreService.Models
{
    public class Award : BaseModel
    {
        public Country Location { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}