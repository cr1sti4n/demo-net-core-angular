import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { URI } from '../config/uri';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

    baseUrl: string

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl
    }

  login(user: {Email: string, Password: string}) {
    const uri = `${this.baseUrl}api/Login/Login`
    return this.http.post(uri, user);
  }
}
