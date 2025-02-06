namespace GameOfLife.Models
{
    public class Human
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Health { get; set; }
        public double Fitness { get; set; }
        public double Hunger { get; set; }
        public double Engineering { get; set; }
        public double BrainCapacity { get; set; }
        public double Fun { get; set; }

        public Human(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Health = 50;
            Fitness = 50;
            Hunger = 50;
            Engineering = 50;
            BrainCapacity = 50;
            Fun = 50;

        }

        public Human() { }
    }
}
