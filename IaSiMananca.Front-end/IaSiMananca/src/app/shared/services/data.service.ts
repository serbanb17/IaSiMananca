import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class DataService {
  baseUrl: string = 'http://localhost:1767/api/';
  constructor(private http: HttpClient) { }

  public get<T>(url: string): Observable<T> {
    return this.http.get(this.baseUrl + url, { headers: this.buildHeaders() })
      .pipe(
        map((response: T) => this.onSuccess(response)),
        catchError((response: T) => this.onError(response))
      ) as Observable<T>;
  }
 
  public post<T>(url: string, data: any): Observable<T> {
    return this.http.post(this.baseUrl + url, data, { headers: this.buildHeaders() })
      .pipe(
        map((response: T) => this.onSuccess(response)),
        catchError((response: T) => this.onError(response))
      ) as Observable<T>;
  }

  public delete<T>(url: string): Observable<T> {
    return this.http.delete(this.baseUrl + url, { headers: this.buildHeaders() })
      .pipe(
        map((response: T) => this.onSuccess(response)),
        catchError((response: T) => this.onError(response))
      ) as Observable<T>;
  }

  public update<T>(url: string, data: any): Observable<T> {
    return this.http.put(this.baseUrl + url, data, { headers: this.buildHeaders() })
      .pipe(
        map((response: T) => this.onSuccess(response)),
        catchError((response: T) => this.onError(response))
      ) as Observable<T>;
  }

  private onSuccess(response) {
    return response;
  }

  private onError(response) {
    return response;
  }

  private buildHeaders(): HttpHeaders {
    const headers = new HttpHeaders({
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    });
    return headers;
  }

  //RestaurantReviews
  // public getReviews<T>(url: string): Observable<T>{
  //   return this.http.get(this.baseUrl + url, {headers: this.buildHeaders()}).pipe(
  //     map((response: T) => this.onSuccess(response)), 
  //     catchError((response: T) => this.onError(response))
  //   ) as Observable<T>;
  // }

  // public deleteReview(url: string): Observable<number> {
  //   return this.http.delete(this.baseUrl + url, {
  //     headers: {
  //       'Content-Type': 'application/json', 
  //       'Accept': 'application/json'
  //     }
  //   }) as Observable<number>;
  // }
  
  // public postReview<T>(url: string, data: any): Observable<T> {
  //   var body = JSON.stringify(data);

  //   return this.http.post(this.baseUrl + url, body, {headers: this.buildHeaders()})
  //   .pipe(
  //     map((response: T) => this.onSuccess(response)),
  //     catchError((response: T) => this.onError(response))
  //   ) as Observable<T>;
  // }

  // public putReview<T>(url: string, data: any): Observable<T> {
  //   var body = JSON.stringify(data);

  //   return this.http.put(this.baseUrl + url, body, {headers: this.buildHeaders()})
  //   .pipe(
  //     map((response: T) => this.onSuccess(response)),
  //     catchError((response: T) => this.onError(response))
  //   ) as Observable<T>;
  // }

}
