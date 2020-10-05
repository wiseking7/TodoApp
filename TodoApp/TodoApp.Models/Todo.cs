namespace TodoApp.Models
{
    /// <summary>
    /// [1]모델클래스
    /// </summary>
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}
