import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../model.component';
import { AuthService } from '../auth/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent
{
  isExpanded = false;
  
  public user: User;
  public isLoggedIn: boolean = true;

  constructor(private router: Router, public authService: AuthService) { }

  
 collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }


  ngOnInit(){
    
  }

  login() {

    this.userAuthenticated();
    //this.authService.authenticateUser().subscribe(user => this.user = user, error => console.error(error), () => this.userAuthenticated());
  }

  public userAuthenticated() {
    console.log(this.user);
    this.isLoggedIn = true;
    this.router.navigate(['/contratos']);
  }

  logOut() {
    this.isLoggedIn = false;
    this.authService.exitUser();
    this.router.navigate(['/']);
  }





}


