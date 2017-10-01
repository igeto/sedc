export * from './main.component';
export * from './product/product.component';
export * from './generated/generated.component';
export * from './order/order.component';

import { GeneratedComponent, MainComponent, ProductComponent, OrderComponent } from './';

export let COMPONENTS = [ GeneratedComponent, ProductComponent, OrderComponent ];
