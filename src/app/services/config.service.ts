import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Mask } from '../models/mask';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  constructor(private http:HttpClient) {}

  postMask(mask:Mask):Observable<any>{
    return this.http.post<any>("https://localhost:44364/api/mask",mask);
  }
}
