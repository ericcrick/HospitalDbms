import { AuthService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { DepartmentService } from '@proxy/departments/service';
import { OAuthService } from 'angular-oauth2-oidc';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }
  totalDepartmentRecord: Observable<number>;
  constructor(
    private oAuthService: OAuthService, 
    private authService: AuthService, 
    private departmentService:DepartmentService,
    ){}
  ngOnInit(): void {
    this.totalDepartmentRecord = this.departmentService.getDepartmentRecordCount();
  }

  login() {
    this.authService.navigateToLogin();
  }
}
