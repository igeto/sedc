import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Product } from '../../models/product';
import { NgModel } from '@angular/forms';

@Component({
    // tslint:disable-next-line:component-selector
    selector: 'product',
    templateUrl: './product.component.html',
    styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
    someText: number = 0;
    @Input()
    product: Product = Product.empty();
    css: 'testClass';

    @Output()
    counterChanged: EventEmitter<number> = new EventEmitter<number>();
    handleButtonClick(e: MouseEvent): void {
        this.counterChanged.emit(++this.someText);
    }

    ngOnInit() {

    }
 }
