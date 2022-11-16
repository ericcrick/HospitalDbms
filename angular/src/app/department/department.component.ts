import { ListService, PagedResultDto } from '@abp/ng.core';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
  isModalOpen = false;
  form: FormGroup
  searchDepartment = {} as DepartmentDto;
  searchKey: string = ""

  selectedDepartment = {} as DepartmentDto;

  constructor(
    public readonly list: ListService, 
    private departmentService:DepartmentService,
    private formBuilder: FormBuilder,
    private confirmation: ConfirmationService
    ) { }
  
  ngOnInit(): void {
    const departmentStreamCreator = (query) => this.departmentService.getList(query);

    this.list.hookToQuery(departmentStreamCreator).subscribe((response) => {
      this.department = response;
    });
    // this.onSearchDepartment(this.searchKey);
  }

  createDepartment() {
    this.buildDepartmentForm();
    this.isModalOpen = true;
  }

  editDepartment(id: string) {
      this.departmentService.get(id).subscribe((department) => {
      this.selectedDepartment = department;
      this.buildDepartmentForm();
      this.isModalOpen = true;
    });
  }

  buildDepartmentForm(){
    this.form = this.formBuilder.group({
      departmentName: [this.selectedDepartment.departmentName || null, Validators.required],
      departmentHead: [this.selectedDepartment.departmentHead || null],
      departmentTelephone: [this.selectedDepartment.departmentTelephone || null],
      departmentMail: [this.selectedDepartment.departmentMail || null]
    })
  }

  save() {
    if (this.form.invalid) {
      return;
    }
    const request = this.selectedDepartment.id
    ?this.departmentService.update(this.selectedDepartment.id, this.form.value)
    :this.departmentService.create(this.form.value);

    request.subscribe( ()=> {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    })
  }

  delete(id: string) {
    this.confirmation.warn('::Confirm you want to delete this record', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.departmentService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
  onSearchDepartment(searchKeyWord: string){
    console.log(searchKeyWord);
  }

}
