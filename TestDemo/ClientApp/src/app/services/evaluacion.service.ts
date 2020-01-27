import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { URI } from '../config/uri';

@Injectable({
  providedIn: 'root'
})
export class EvaluacionService {

    baseUrl: string

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl
    }

  ListarEvaluacion(){
    const uri = `${this.baseUrl}api/Evaluation`
    return this.http.get(uri);
  }

  Agregar(Evaluacion){
      const uri = `${this.baseUrl}api/Evaluation`
    return this.http.post(uri, Evaluacion);
  }

  Delete(id){
      const uri = `${this.baseUrl}api/Evaluation/${id}`
    return this.http.delete(uri);
  }

  editar(Evaluacion, id){
      const uri = `${this.baseUrl}api/Evaluation/${id}`
    return this.http.put(uri, Evaluacion);
  }

  nuevaOpinion(Opinion){
      const uri = `${this.baseUrl}api/Opinion`
    return this.http.post(uri, Opinion);
  }

  listarOpinion(){
      const uri = `${this.baseUrl}api/Opinion`
    return this.http.get(uri);
  }
}
