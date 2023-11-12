import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginService } from '../../services/login.service';
import { HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule, HttpClientModule, FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
  providers: [LoginService]
})
export class LoginComponent {

  username: string = ''
  password: string = ''

  login$? : Observable<object>;
  
  constructor(private _loginService: LoginService) { }

  onLogin(): void {
    this.login$ = this._loginService.login(this.username, this.password);
    this.login$.subscribe(s => console.log(s));
    this.clearForm();
  }

  clearForm() : void {
    this.username = '';
    this.password = '';
  }
}
