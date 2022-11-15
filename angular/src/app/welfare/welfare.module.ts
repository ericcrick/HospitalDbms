import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WelfareRoutingModule } from './welfare-routing.module';
import { WelfareComponent } from './welfare.component';


@NgModule({
  declarations: [
    WelfareComponent
  ],
  imports: [
    CommonModule,
    WelfareRoutingModule
  ]
})
export class WelfareModule { }
