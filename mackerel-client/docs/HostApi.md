# Koudenpa.Mackerel.Api.Api.HostApi

All URIs are relative to *https://api.mackerelio.com/api/v0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHost**](HostApi.md#gethost) | **GET** /hosts/{hostId} | 
[**GetHosts**](HostApi.md#gethosts) | **GET** /hosts | 
[**PostHostStatus**](HostApi.md#posthoststatus) | **POST** /hosts/{hostId}/status | 


<a name="gethost"></a>
# **GetHost**
> HostResponse GetHost (string hostId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class GetHostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new HostApi(Configuration.Default);
            var hostId = hostId_example;  // string | 

            try
            {
                HostResponse result = apiInstance.GetHost(hostId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HostApi.GetHost: " + e.Message );
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
 **hostId** | **string**|  | 

### Return type

[**HostResponse**](HostResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethosts"></a>
# **GetHosts**
> HostsResponse GetHosts (string service = null, string role = null, string name = null, string status = null, string customIdentifier = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class GetHostsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new HostApi(Configuration.Default);
            var service = service_example;  // string | optional サービス名。 (optional) 
            var role = role_example;  // string | サービス内のロール名。複数指定可能（結果は各ロールに所属するホスト群の和集合となります）。serviceが指定されていない場合は無効です。 (optional) 
            var name = name_example;  // string | optional ホスト名。 (optional) 
            var status = status_example;  // string | optional ホストのステータスを絞り込む。複数指定可能。デフォルトは working と standbyです。 (optional) 
            var customIdentifier = customIdentifier_example;  // string | optional ホスト情報の登録やホスト情報の更新で登録したユーザー独自の識別子。 (optional) 

            try
            {
                HostsResponse result = apiInstance.GetHosts(service, role, name, status, customIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HostApi.GetHosts: " + e.Message );
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
 **service** | **string**| optional サービス名。 | [optional] 
 **role** | **string**| サービス内のロール名。複数指定可能（結果は各ロールに所属するホスト群の和集合となります）。serviceが指定されていない場合は無効です。 | [optional] 
 **name** | **string**| optional ホスト名。 | [optional] 
 **status** | **string**| optional ホストのステータスを絞り込む。複数指定可能。デフォルトは working と standbyです。 | [optional] 
 **customIdentifier** | **string**| optional ホスト情報の登録やホスト情報の更新で登録したユーザー独自の識別子。 | [optional] 

### Return type

[**HostsResponse**](HostsResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posthoststatus"></a>
# **PostHostStatus**
> ApiResponse PostHostStatus (string hostId, HostStatusRequest hostStatus)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Example
{
    public class PostHostStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.mackerelio.com/api/v0";
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new HostApi(Configuration.Default);
            var hostId = hostId_example;  // string | 
            var hostStatus = new HostStatusRequest(); // HostStatusRequest | 

            try
            {
                ApiResponse result = apiInstance.PostHostStatus(hostId, hostStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HostApi.PostHostStatus: " + e.Message );
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
 **hostId** | **string**|  | 
 **hostStatus** | [**HostStatusRequest**](HostStatusRequest.md)|  | 

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

