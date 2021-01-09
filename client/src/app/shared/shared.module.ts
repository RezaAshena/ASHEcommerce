import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
//import { PaginationModule } from 'ngx-bootstrap';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';


@NgModule({
  declarations: [PagingHeaderComponent],
  imports: [
    CommonModule,
    PaginationModule
  ],
  exports: [
    PaginationModule,
    PagingHeaderComponent
  ]
})
export class SharedModule { }
