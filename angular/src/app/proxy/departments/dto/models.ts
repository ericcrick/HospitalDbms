import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateDepartmentDto {
  departmentName: string;
  departmentHead?: string;
  departmentTelephone?: string;
  departmentMail?: string;
}

export interface DepartmentDto extends AuditedEntityDto<string> {
  departmentName?: string;
  departmentHead?: string;
  departmentTelephone?: string;
  departmentMail?: string;
}
