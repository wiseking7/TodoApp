using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        //[2]인터페이스
        void Add(Todo model); //[4]입력
        List<Todo> GetAll(); //[4]출력

    }
}
