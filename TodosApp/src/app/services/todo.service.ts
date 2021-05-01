import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Todo } from '../models/Todo';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  todosUrl:string = 'https://localhost:44356/todos/';
  todosLimit = '';

  constructor(private http:HttpClient) { }

  // Get Todos
  getTodos():Observable<Todo[]> {
    return this.http.get<Todo[]>(`${this.todosUrl}${this.todosLimit}`);
  }

  // Toggle Completed
  toggleCompleted(todo: Todo):Observable<any> {
    const url = `${this.todosUrl}/${todo.id}`
    return this.http.put(`${this.todosUrl}${todo.id}`, todo, httpOptions);
  }
 
  // Delete Todo
  deleteTodo(todo:Todo):Observable<Todo> {
    const url = `${this.todosUrl}/${todo.id}`;
    return this.http.delete<Todo>(`${this.todosUrl}${todo.id}`, httpOptions);
  }

  // Add Todo
  addTodo(todo:Todo):Observable<Todo> {
    return this.http.post<Todo>(this.todosUrl, todo, httpOptions);
  }

}
