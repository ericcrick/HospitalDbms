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
        path: '/employees',
        name: "Employees",
        iconClass: 'fa fa-user',
        order: 2,
        layout: eLayoutType.application
      },
      {
        path: '/departments',
        name: "Department",
        iconClass: 'fa fa-university',
        order: 3,
        layout: eLayoutType.application
      },
      {
        path: '/welfare',
        name: "Welfare",
        iconClass: 'fa fa-balance-scale',
        order: 4,
        layout: eLayoutType.application
      },
    ]);
  };
}
