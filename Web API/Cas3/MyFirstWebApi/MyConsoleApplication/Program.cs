using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;
using RestSharp;

namespace MyConsoleApplication
{
    class Program
    {
        static RestClient client2 = new RestClient("http://localhost:61491/");
        static HttpClient client = new HttpClient();
        static void ShowProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name of product: {product.Name}\n");
            }
        }
        static void Main(string[] args)
        {
            //Product product = new Product();
            //Console.Write("Enter the id of the product: ");
            //product.Id = Console.ReadLine();
            //Console.Write("Enter the name of the product: ");
            //product.Name = Console.ReadLine();
            var request = new RestRequest("api/product", Method.GET);
            IRestResponse<List<Product>> response = client2.Execute<List<Product>>(request);
            var products = response.Data;

            foreach (var product in products)
            {
                ShowProducts(products);
            }
            //PostProduct(product);
            //GetProduct(product.Id);
            Console.ReadLine();
        }
        static async void RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:61491/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("api/products");

            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadAsAsync<List<Product>>();
                ShowProducts(products);
            }
        }
        static async void GetProduct(string id)
        {
            client.BaseAddress = new Uri("http://localhost:61491/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            

            HttpResponseMessage response = await client.GetAsync($"api/products/{id}");

            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadAsAsync<Product>();
                
                    Console.WriteLine($"Name of product: {product.Name}\n");
                
            }
        }
        static async void PostProduct(Product product)
        {
            client.BaseAddress = new Uri("http://localhost:61491/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await client.PostAsJsonAsync($"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();
        }
    }
}
