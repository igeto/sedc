import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { MainComponent, COMPONENTS } from './';
import {AccordionModule} from 'ngx-bootstrap';
const moduleInfo = {
  declarations: [
    MainComponent,
    ...COMPONENTS
  ],
  imports: [
    BrowserModule,
    AccordionModule.forRoot(),
    FormsModule
  ],
  providers: [],
  bootstrap: [ MainComponent ]
};

@NgModule(moduleInfo)
export class AppModule { }


