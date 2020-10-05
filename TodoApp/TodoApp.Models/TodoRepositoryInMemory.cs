using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepository : ITodoRepository
    {
        //[6]필드생성 및 초기화
        private static List<Todo> _todos = new List<Todo>();
        //[6]생성자 추가 ctro 기본데이터 3개 추가
        public TodoRepository()
        {
            _todos = new List<Todo>
            {
                new Todo { ID = 1, Title = "ASP.NET Core 학습", IsDone = false },
                new Todo { ID = 2, Title = "Blazor 학습", IsDone = false },
                new Todo { ID = 3, Title = "C# 학습", IsDone = true }
            };

        }
        //[3] 클래스 상속 인-메모리 데이터베이스 사용영역
        public void Add(Todo model)
            // [5] 인터페이스 구현 설정 입력기능/출력기능 만들기
        {
            //[7] ID추가
            model.ID = _todos.Max(t => t.ID) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            //[8]반환
            return _todos.ToList();
        }
    }
}
