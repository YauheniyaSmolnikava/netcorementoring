using NetCoreTestApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NetCoreTestApp.ConsoleClient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void ShowProducts(List<Products> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.ProductName}");
            }
        }

        static void ShowCategories(List<Categories> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine($"Name: {category.CategoryName}\n");
            }
        }

        static async Task<List<Products>> GetProductsAsync(string path)
        {
            List<Products> products = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsAsync<List<Products>>();
            }
            return products;
        }

        static async Task<List<Categories>> GetCategoriesAsync(string path)
        {
            List<Categories> categories = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                categories = await response.Content.ReadAsAsync<List<Categories>>();
            }
            return categories;
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:44352/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Console.WriteLine("Products:");
                var products = await GetProductsAsync("api/products");
                ShowProducts(products);

                Console.WriteLine("Categories:");
                var categories = await GetCategoriesAsync("api/categories");
                ShowCategories(categories);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}
