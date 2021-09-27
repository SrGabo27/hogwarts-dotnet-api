using hogwartsApi.Domain.Models;

namespace hogwartsApi.Resources
{
    public class ApplicationResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public long Identification { get; set; }
        public EHouse House { get; set; }
    }
}
