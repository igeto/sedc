import { Product } from './product';

export class Order {
    id: string;
    product: Product;

    public static empty(): Order {
        return {
            id: '',
            product: Product.empty()
        };
    }
}
