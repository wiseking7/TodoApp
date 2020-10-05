using System;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.ConsoleApp
{
    class Program
    {
        //[9] 출력 
        static void Main(string[] args)
        {
            ITodoRepository _repository = new TodoRepository();
            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();
            //기본데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.ID} - {t.Title}({t.IsDone})");
            }
            Console.WriteLine();

            //[10] 데이터입력 
            Todo todo = new Todo { Title = "Database 학습", IsDone = true };
            _repository.Add(todo);
            todos = _repository.GetAll(); //다시로드

            //[11] 변경데이터 출력
            foreach (var t in todos)
            {
                Console.WriteLine($"{t.ID} - {t.Title}({t.IsDone})");
            }
        }
    }
}
