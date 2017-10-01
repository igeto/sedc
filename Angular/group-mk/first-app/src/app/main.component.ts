import { Component } from '@angular/core';
import {AccordionComponent} from 'ngx-bootstrap';
@Component({
  // tslint:disable-next-line:component-selector
  selector: 'main-component',
  template: `
  <product></product>
  <app-order></app-order>
  <app-generated></app-generated>
  <accordion>
    <accordion-group heading="Static Header, initially expanded">
      This content is straight in the template.
    </accordion-group>
    <accordion-group #group>
      <div accordion-heading>
        I can have markup, too!
        <i class="pull-right float-xs-right glyphicon"
          [ngClass]="{'glyphicon-chevron-down': group?.isOpen, 'glyphicon-chevron-right': !group?.isOpen}"></i>
      </div>
      This is just some content to illustrate fancy headings.
    </accordion-group>
    <accordion-group heading="Content 1">
      <p>Content 1</p>
    </accordion-group>
    <accordion-group heading="Content 2">
      <p>Content 2</p>
    </accordion-group>
  </accordion>
  `
})
export class MainComponent {
}
