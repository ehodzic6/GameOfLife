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
    }
}
