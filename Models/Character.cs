namespace yoojinCode.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; } = "Wanli ";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RPGClass Class { get; set; } = RPGClass.Simp;
    }
}