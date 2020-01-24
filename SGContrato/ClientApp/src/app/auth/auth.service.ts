import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../model.component';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
//import { isNullOrUndefine } from 'util';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiURL = this.baseUrl + "api/Users";

  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): User {
    return this.currentUserSubject.value;
  }

  public authenticateUser(): Observable<User> {
    return this.http.get<User>(this.apiURL + '/authenticate')
      .pipe(map(user => {
        localStorage.setItem('currentUser', JSON.stringify(user));
        this.currentUserSubject.next(user);
        return user;
      }));
  }

  public exitUser() {
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
  }

  public getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.apiURL);
  }

  public getUser(userId: string): Observable<User> {
    return this.http.get<User>(this.apiURL + '/' + userId);
  }

}
