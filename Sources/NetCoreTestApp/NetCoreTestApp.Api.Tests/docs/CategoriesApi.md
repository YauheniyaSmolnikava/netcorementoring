# IO.Swagger.Api.CategoriesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](CategoriesApi.md#get) | **GET** /api/Categories | This methid allows to get all available catgories
[**GetImage**](CategoriesApi.md#getimage) | **GET** /api/Categories/images/{id} | This method allows to get image for the specified category
[**Upload**](CategoriesApi.md#upload) | **POST** /api/Categories/images/{id} | This method allows to update image for the specified category


<a name="get"></a>
# **Get**
> List<Categories> Get ()

This methid allows to get all available catgories

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
            var apiInstance = new CategoriesApi();

            try
            {
                // This methid allows to get all available catgories
                List&lt;Categories&gt; result = apiInstance.Get();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Categories>**](Categories.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimage"></a>
# **GetImage**
> void GetImage (int? id)

This method allows to get image for the specified category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetImageExample
    {
        public void main()
        {
            var apiInstance = new CategoriesApi();
            var id = 56;  // int? | identifier of category

            try
            {
                // This method allows to get image for the specified category
                apiInstance.GetImage(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.GetImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| identifier of category | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upload"></a>
# **Upload**
> void Upload (string id, ImageUpload image = null)

This method allows to update image for the specified category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadExample
    {
        public void main()
        {
            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | 
            var image = new ImageUpload(); // ImageUpload | image object (optional) 

            try
            {
                // This method allows to update image for the specified category
                apiInstance.Upload(id, image);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.Upload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **image** | [**ImageUpload**](ImageUpload.md)| image object | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

