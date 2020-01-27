import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { URI } from '../config/uri';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {

    baseUrl: string


    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

        this.baseUrl = baseUrl

    }

  guardarRegistro(Usuario){
    const uri = `${this.baseUrl}api/User`
    return this.http.post(uri, Usuario)
  }
}
