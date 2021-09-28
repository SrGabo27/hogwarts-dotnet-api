using System.ComponentModel;

namespace hogwartsApi.Domain.Models
{
    public enum EHouse : byte
    {
        [Description("Gryffindor")]
        Gryffindor = 1,

        [Description("Ravenclaw")]
        Ravenclaw = 2,

        [Description("Hofflepuff")]
        Hufflepuff = 3,

        [Description("Slytherin")]
        Slytherin = 4,
    }
}
