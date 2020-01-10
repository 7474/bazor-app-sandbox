# Koudenpa.Mackerel.Api.Api.AlertApi

All URIs are relative to *https://api.mackerelio.com/api/v0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAlerts**](AlertApi.md#getalerts) | **GET** /alerts | 


<a name="getalerts"></a>
# **GetAlerts**
> AlertsResponse GetAlerts (bool? withClosed = null, string nextId = null, decimal? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class GetAlertsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new AlertApi(Configuration.Default);
            var withClosed = true;  // bool? |  (optional) 
            var nextId = nextId_example;  // string |  (optional) 
            var limit = 8.14;  // decimal? |  (optional) 

            try
            {
                AlertsResponse result = apiInstance.GetAlerts(withClosed, nextId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertApi.GetAlerts: " + e.Message );
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
 **withClosed** | **bool?**|  | [optional] 
 **nextId** | **string**|  | [optional] 
 **limit** | **decimal?**|  | [optional] 

### Return type

[**AlertsResponse**](AlertsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 並び順は、アラートの発生時刻が新しい順です。 一覧は最大100件まで取得されます。nextId はアラートがlimit件より多くあるときに取得されます。 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

