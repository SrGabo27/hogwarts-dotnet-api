using System.ComponentModel;

namespace hogwartsApi.Domain.Models
{
    public enum EHouse : byte
    {
        [Description("Gry")]
        Gryffindor = 1,

        [Description("Rav")]
        Ravenclaw = 2,

        [Description("Hof")]
        Hufflepuff = 3,

        [Description("Sly")]
        Slytherin = 4,
    }
}
