import { Component, OnInit } from '@angular/core';
import { Order } from '../../models/order';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  order: Order;
  counterInOrders: number;

  ngOnInit() {
    this.order = Order.empty();
    this.order.id = 'order_id';
    this.order.product.id = 'product_id';
    this.order.product.name = 'pleskavica';
  }

  handleCounterChanged($event: number) {
    this.counterInOrders = $event;
  }
}
