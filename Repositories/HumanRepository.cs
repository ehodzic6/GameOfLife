using GameOfLife.Context;
using GameOfLife.Models;

namespace GameOfLife.Repositories
{
    public class HumanRepository : IHumanRepository
    {
        public AppDbContext _context;
        public HumanRepository(AppDbContext context)
        {
            _context = context;
        }
        public Response AddHuman(Human human)
        {
            _context.Add(human);
            _context.SaveChangesAsync();

            return new Response
            {
                Success = true,
                Message = "Human added succesfully!",
                Description = human.Id.ToString()
            };
        }

        public Response DeleteHuman(string humanId)
        {
            Human? human = _context.Set<Human>().Find(Guid.Parse(humanId));

            if (human != null)
            {
                _context.Set<Human>().Remove(human);
                _context.SaveChangesAsync();
                return new Response
                {
                    Success = true,
                    Message = "Human is deleted!",
                    Description = ""
                };
            }
            else
            {
                return new Response
                {
                    Success = false,
                    Message = "Human is not found!",
                    Description = "Check Id!"
                };
            }
        }

        private bool CheckStats(ref double engineering, ref double fitness, ref double health, ref double hunger,
            ref double brainCapacity, ref double fun)
        {
            if (engineering < 0 || fitness < 0 || health < 0 || hunger < 0 || brainCapacity < 0 || fun < 0)
            {
                return false;
            }
            else if (engineering > 100) engineering = 100;
            else if (fitness > 100) fitness = 100;
            else if (health > 100) health = 100;
            else if (hunger > 100) hunger = 100;
            else if (brainCapacity > 100) brainCapacity = 100;
            else if (fun > 100) fun = 100;
            return true;
        }
        public Response DoEngineering(string humanId)
        {
            Human? human = _context.Set<Human>().Find(Guid.Parse(humanId));

            if (human != null)
            {
                Random random = new Random();
                double coefficient = random.NextDouble();
                human.Engineering += coefficient * 25;
                human.Fitness -= coefficient * 15;
                human.Hunger -= coefficient * 5;
                human.BrainCapacity -= coefficient * 20;

                double engineering = human.Engineering;
                double fitness = human.Fitness;
                double health = human.Health;
                double hunger = human.Hunger;
                double brainCapacity = human.BrainCapacity;
                double fun = human.Fun;

                var dataCheck = CheckStats(ref engineering, ref fitness, ref health, ref hunger, ref brainCapacity, ref fun);

                if (!dataCheck)
                {
                    return new Response
                    {
                        Success = false,
                        Message = "You don't have enough stats for this activity!",
                        Description = "Hint: Change activity!"
                    };
                }
                human.Engineering = engineering;
                human.Fitness = fitness;
                human.Health = health;
                human.Hunger = hunger;
                human.BrainCapacity = brainCapacity;
                human.Fun = fun;
                _context.SaveChangesAsync();
                return new Response
                {
                    Success = true,
                    Message = "Human successfully finished an activity!",
                    Description = "Engineering: " + Math.Round(human.Engineering, 2)
                };
            }
            else
            {
                return new Response
                {
                    Success = false,
                    Message = "Human is not found!",
                    Description = "Check Id!"
                };
            }
        }
    }
}
