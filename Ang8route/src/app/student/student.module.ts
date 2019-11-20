import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentComponent } from './student/student.component';
import { StudentListComponent } from './student-list/student-list.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { StudentRoutingModule } from './student-routing.module';

@NgModule({
  declarations: [StudentComponent, StudentListComponent, StudentDetailsComponent],
  imports: [CommonModule, StudentRoutingModule]
})
export class StudentModule { }
