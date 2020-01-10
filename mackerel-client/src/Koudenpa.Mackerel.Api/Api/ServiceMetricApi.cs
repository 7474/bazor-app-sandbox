/* 
 * Makerel API
 *
 * This is part of Makerel API.
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Model;

namespace Koudenpa.Mackerel.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceMetricApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse PostServiceMetric (string serviceName, List<ServiceMetricValue> serviceMetrics);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> PostServiceMetricWithHttpInfo (string serviceName, List<ServiceMetricValue> serviceMetrics);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceMetricApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> PostServiceMetricAsync (string serviceName, List<ServiceMetricValue> serviceMetrics);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> PostServiceMetricAsyncWithHttpInfo (string serviceName, List<ServiceMetricValue> serviceMetrics);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceMetricApi : IServiceMetricApiSync, IServiceMetricApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServiceMetricApi : IServiceMetricApi
    {
        private Koudenpa.Mackerel.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetricApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceMetricApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetricApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceMetricApi(String basePath)
        {
            this.Configuration = Koudenpa.Mackerel.Api.Client.Configuration.MergeConfigurations(
                Koudenpa.Mackerel.Api.Client.GlobalConfiguration.Instance,
                new Koudenpa.Mackerel.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Koudenpa.Mackerel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Koudenpa.Mackerel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Koudenpa.Mackerel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetricApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServiceMetricApi(Koudenpa.Mackerel.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Koudenpa.Mackerel.Api.Client.Configuration.MergeConfigurations(
                Koudenpa.Mackerel.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Koudenpa.Mackerel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Koudenpa.Mackerel.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Koudenpa.Mackerel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMetricApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ServiceMetricApi(Koudenpa.Mackerel.Api.Client.ISynchronousClient client,Koudenpa.Mackerel.Api.Client.IAsynchronousClient asyncClient, Koudenpa.Mackerel.Api.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Koudenpa.Mackerel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Koudenpa.Mackerel.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Koudenpa.Mackerel.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Koudenpa.Mackerel.Api.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Koudenpa.Mackerel.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse PostServiceMetric (string serviceName, List<ServiceMetricValue> serviceMetrics)
        {
             Koudenpa.Mackerel.Api.Client.ApiResponse<ApiResponse> localVarResponse = PostServiceMetricWithHttpInfo(serviceName, serviceMetrics);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public Koudenpa.Mackerel.Api.Client.ApiResponse< ApiResponse > PostServiceMetricWithHttpInfo (string serviceName, List<ServiceMetricValue> serviceMetrics)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new Koudenpa.Mackerel.Api.Client.ApiException(400, "Missing required parameter 'serviceName' when calling ServiceMetricApi->PostServiceMetric");

            // verify the required parameter 'serviceMetrics' is set
            if (serviceMetrics == null)
                throw new Koudenpa.Mackerel.Api.Client.ApiException(400, "Missing required parameter 'serviceMetrics' when calling ServiceMetricApi->PostServiceMetric");

            Koudenpa.Mackerel.Api.Client.RequestOptions localVarRequestOptions = new Koudenpa.Mackerel.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Koudenpa.Mackerel.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Koudenpa.Mackerel.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (serviceName != null)
                localVarRequestOptions.PathParameters.Add("serviceName", Koudenpa.Mackerel.Api.Client.ClientUtils.ParameterToString(serviceName)); // path parameter
            localVarRequestOptions.Data = serviceMetrics;

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< ApiResponse >("/services/{serviceName}/tsdb", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostServiceMetric", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> PostServiceMetricAsync (string serviceName, List<ServiceMetricValue> serviceMetrics)
        {
             Koudenpa.Mackerel.Api.Client.ApiResponse<ApiResponse> localVarResponse = await PostServiceMetricAsyncWithHttpInfo(serviceName, serviceMetrics);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Koudenpa.Mackerel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serviceName"></param>
        /// <param name="serviceMetrics"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<Koudenpa.Mackerel.Api.Client.ApiResponse<ApiResponse>> PostServiceMetricAsyncWithHttpInfo (string serviceName, List<ServiceMetricValue> serviceMetrics)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null)
                throw new Koudenpa.Mackerel.Api.Client.ApiException(400, "Missing required parameter 'serviceName' when calling ServiceMetricApi->PostServiceMetric");

            // verify the required parameter 'serviceMetrics' is set
            if (serviceMetrics == null)
                throw new Koudenpa.Mackerel.Api.Client.ApiException(400, "Missing required parameter 'serviceMetrics' when calling ServiceMetricApi->PostServiceMetric");


            Koudenpa.Mackerel.Api.Client.RequestOptions localVarRequestOptions = new Koudenpa.Mackerel.Api.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (serviceName != null)
                localVarRequestOptions.PathParameters.Add("serviceName", Koudenpa.Mackerel.Api.Client.ClientUtils.ParameterToString(serviceName)); // path parameter
            localVarRequestOptions.Data = serviceMetrics;

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Api-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Api-Key", this.Configuration.GetApiKeyWithPrefix("X-Api-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiResponse>("/services/{serviceName}/tsdb", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostServiceMetric", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
