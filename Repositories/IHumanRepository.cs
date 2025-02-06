using GameOfLife.Models;

namespace GameOfLife.Repositories
{
    public interface IHumanRepository
    {
        public Response AddHuman(Human human);
        public Response DeleteHuman(string humanId);
        public Response DoEngineering(string humanId);
    }
}
