# Koudenpa.Mackerel.Api.Api.HostMetricApi

All URIs are relative to *https://api.mackerelio.com/api/v0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostHostMetric**](HostMetricApi.md#posthostmetric) | **POST** /tsdb | 


<a name="posthostmetric"></a>
# **PostHostMetric**
> ApiResponse PostHostMetric (List<HostMetricValue> hostMetrics)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class PostHostMetricExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new HostMetricApi(Configuration.Default);
            var hostMetrics = new List<HostMetricValue>(); // List<HostMetricValue> | 

            try
            {
                ApiResponse result = apiInstance.PostHostMetric(hostMetrics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HostMetricApi.PostHostMetric: " + e.Message );
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
 **hostMetrics** | [**List&lt;HostMetricValue&gt;**](HostMetricValue.md)|  | 

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

