# IO.Swagger.Api.ProductsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Delete**](ProductsApi.md#delete) | **DELETE** /api/Products/{id} | This method allows to delete exisiting product
[**Get**](ProductsApi.md#get) | **GET** /api/Products | This method returns all available products
[**Post**](ProductsApi.md#post) | **POST** /api/Products | This method allows to create new product based on passed param
[**Put**](ProductsApi.md#put) | **PUT** /api/Products/{id} | This method allows to update existing product


<a name="delete"></a>
# **Delete**
> void Delete (int? id)

This method allows to delete exisiting product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var id = 56;  // int? | identifier of product that need to be deleted

            try
            {
                // This method allows to delete exisiting product
                apiInstance.Delete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| identifier of product that need to be deleted | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> List<Products> Get ()

This method returns all available products

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();

            try
            {
                // This method returns all available products
                List&lt;Products&gt; result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Products>**](Products.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> void Post (Products product = null)

This method allows to create new product based on passed param

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var product = new Products(); // Products | Filled product object (optional) 

            try
            {
                // This method allows to create new product based on passed param
                apiInstance.Post(product);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | [**Products**](Products.md)| Filled product object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="put"></a>
# **Put**
> void Put (int? id, Products product = null)

This method allows to update existing product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var id = 56;  // int? | id of existing product
            var product = new Products(); // Products | product with updated data (optional) 

            try
            {
                // This method allows to update existing product
                apiInstance.Put(id, product);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.Put: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id of existing product | 
 **product** | [**Products**](Products.md)| product with updated data | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

