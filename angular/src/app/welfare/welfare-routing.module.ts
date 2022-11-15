import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelfareComponent } from './welfare.component';

const routes: Routes = [{ path: '', component: WelfareComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class WelfareRoutingModule { }
