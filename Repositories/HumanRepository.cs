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
    }
}
