using GameOfLife.Models;

namespace GameOfLife.Repositories
{
    public interface IHumanRepository
    {
        public Response AddHuman(Human human);
    }
}
