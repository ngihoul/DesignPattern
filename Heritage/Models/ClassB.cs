namespace Heritage.Models
{
    internal class ClassB : ClassA
    {
        public ClassA ClassA { get; set; }
        public ClassB() {
            b = 50;
            c = 20;
            d = 30;
        }
    }
}
