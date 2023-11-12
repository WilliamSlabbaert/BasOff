import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private url : string = 'http://localhost:3000/';

  constructor(private http : HttpClient ) { }

  login(username : string, password : string) : Observable<any>{
    console.log(username + " => "+ password)
      return this.http.post(this.url + "Login",{ user: username, pass: password});
  }
}
