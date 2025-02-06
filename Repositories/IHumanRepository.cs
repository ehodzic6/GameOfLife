using GameOfLife.Models;

namespace GameOfLife.Repositories
{
    public interface IHumanRepository
    {
        public Response AddHuman(Human human);
        public Response DeleteHuman(string humanId);
        public Response DoEngineering(string humanId);
        public Response Eat(string humanId);
        public Response FitnessTraining(string humanId);
        public Response GoToSleep(string humanId);
        public Response PlayPS5(string humanId);
        public Response ReadABook(string humanId);
    }
}
