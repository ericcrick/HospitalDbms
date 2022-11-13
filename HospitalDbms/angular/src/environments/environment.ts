import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'HospitalDbms',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44342/',
    redirectUri: baseUrl,
    clientId: 'HospitalDbms_App',
    responseType: 'code',
    scope: 'offline_access HospitalDbms',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44342',
      rootNamespace: 'HospitalDbms',
    },
  },
} as Environment;
