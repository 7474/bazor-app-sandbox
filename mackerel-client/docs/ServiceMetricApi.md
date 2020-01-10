# Koudenpa.Mackerel.Api.Api.ServiceMetricApi

All URIs are relative to *https://api.mackerelio.com/api/v0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostServiceMetric**](ServiceMetricApi.md#postservicemetric) | **POST** /services/{serviceName}/tsdb | 


<a name="postservicemetric"></a>
# **PostServiceMetric**
> ApiResponse PostServiceMetric (string serviceName, List<ServiceMetricValue> serviceMetrics)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class PostServiceMetricExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new ServiceMetricApi(Configuration.Default);
            var serviceName = serviceName_example;  // string | 
            var serviceMetrics = new List<ServiceMetricValue>(); // List<ServiceMetricValue> | 

            try
            {
                ApiResponse result = apiInstance.PostServiceMetric(serviceName, serviceMetrics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceMetricApi.PostServiceMetric: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceName** | **string**|  | 
 **serviceMetrics** | [**List&lt;ServiceMetricValue&gt;**](ServiceMetricValue.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

