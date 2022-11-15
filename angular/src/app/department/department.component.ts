import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { DepartmentDto } from '@proxy/departments/dto';
import { DepartmentService } from '@proxy/departments/service';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.scss'],
  providers: [ListService]
})
export class DepartmentComponent implements OnInit {
  department = { items: [], totalCount: 0 } as PagedResultDto<DepartmentDto>
  constructor(
    public readonly list: ListService, 
    private departmentService:DepartmentService
    ) { }

  ngOnInit(): void {
    const departmentStreamCreator = (query) => this.departmentService.getList(query);

    this.list.hookToQuery(departmentStreamCreator).subscribe((response) => {
      this.department = response;
    });
  }

}
