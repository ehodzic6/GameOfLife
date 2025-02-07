namespace GameOfLife.Models
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string Description { get; set; }
        public Human Human { get; set; }
    }
}
