export class Product {
    id: string;
    name: string;

    public static empty(): Product {
        return {
            id: '',
            name: ''
        };
    }
}
