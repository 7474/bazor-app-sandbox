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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Koudenpa.Mackerel.Api.Client;
using Koudenpa.Mackerel.Api.Api;
using Koudenpa.Mackerel.Api.Model;

namespace Koudenpa.Mackerel.Api.Test
{
    /// <summary>
    ///  Class for testing HostMetricApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HostMetricApiTests : IDisposable
    {
        private HostMetricApi instance;

        public HostMetricApiTests()
        {
            instance = new HostMetricApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HostMetricApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HostMetricApi
            //Assert.IsType(typeof(HostMetricApi), instance, "instance is a HostMetricApi");
        }

        
        /// <summary>
        /// Test PostHostMetric
        /// </summary>
        [Fact]
        public void PostHostMetricTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<HostMetricValue> hostMetrics = null;
            //var response = instance.PostHostMetric(hostMetrics);
            //Assert.IsType<ApiResponse> (response, "response is ApiResponse");
        }
        
    }

}
