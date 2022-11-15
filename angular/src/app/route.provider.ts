import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/employee',
        name: "Employees",
        iconClass: 'fa fa-user',
        order: 2,
        layout: eLayoutType.application
      },
      {
        path: '/department',
        name: "Departments",
        iconClass: 'fa fa-university',
        order: 3,
        layout: eLayoutType.application
      },
      {
        path: '/promotion',
        name: "Promotions",
        iconClass: 'fa fa-briefcase',
        order: 4,
        layout: eLayoutType.application
      },
      {
        path: '/leave',
        name: "Leave",
        iconClass: 'fa fa-calendar',
        order: 5,
        layout: eLayoutType.application
      },
      {
        path: '/welfare',
        name: "Welfare",
        iconClass: 'fa fa-balance-scale',
        order: 6,
        layout: eLayoutType.application
      },
    ]);
  };
}
