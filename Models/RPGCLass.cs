using System.Text.Json.Serialization;

namespace yoojinCode.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Simp = 1,
        Femboy = 2, 
        GigaChad = 3,
        SigmaMale = 4
    }
}