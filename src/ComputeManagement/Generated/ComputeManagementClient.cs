// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public partial class ComputeManagementClient : ServiceClient<ComputeManagementClient>, Microsoft.WindowsAzure.Management.Compute.IComputeManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IDeploymentOperations _deployments;
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// deployments beneath your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460812.aspx
        /// for more information)
        /// </summary>
        public virtual IDeploymentOperations Deployments
        {
            get { return this._deployments; }
        }
        
        private IHostedServiceOperations _hostedServices;
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// hosted services beneath your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460812.aspx
        /// for more information)
        /// </summary>
        public virtual IHostedServiceOperations HostedServices
        {
            get { return this._hostedServices; }
        }
        
        private IOperatingSystemOperations _operatingSystems;
        
        /// <summary>
        /// Operations for determining the version of the Windows Azure Guest
        /// Operating System on which your service is running.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ff684169.aspx
        /// for more information)
        /// </summary>
        public virtual IOperatingSystemOperations OperatingSystems
        {
            get { return this._operatingSystems; }
        }
        
        private IServiceCertificateOperations _serviceCertificates;
        
        /// <summary>
        /// Operations for managing service certificates for your subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee795178.aspx
        /// for more information)
        /// </summary>
        public virtual IServiceCertificateOperations ServiceCertificates
        {
            get { return this._serviceCertificates; }
        }
        
        private IVirtualMachineDiskOperations _virtualMachineDisks;
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// disks in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157188.aspx
        /// for more information)
        /// </summary>
        public virtual IVirtualMachineDiskOperations VirtualMachineDisks
        {
            get { return this._virtualMachineDisks; }
        }
        
        private IVirtualMachineExtensionOperations _virtualMachineExtensions;
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// virtual machine extensions in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx
        /// for more information)
        /// </summary>
        public virtual IVirtualMachineExtensionOperations VirtualMachineExtensions
        {
            get { return this._virtualMachineExtensions; }
        }
        
        private IVirtualMachineImageOperations _virtualMachineImages;
        
        /// <summary>
        /// The Service Management API includes operations for managing the OS
        /// images in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157175.aspx
        /// for more information)
        /// </summary>
        public virtual IVirtualMachineImageOperations VirtualMachineImages
        {
            get { return this._virtualMachineImages; }
        }
        
        private IVirtualMachineOperations _virtualMachines;
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// virtual machines in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx
        /// for more information)
        /// </summary>
        public virtual IVirtualMachineOperations VirtualMachines
        {
            get { return this._virtualMachines; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        private ComputeManagementClient()
            : base()
        {
            this._deployments = new DeploymentOperations(this);
            this._hostedServices = new HostedServiceOperations(this);
            this._operatingSystems = new OperatingSystemOperations(this);
            this._serviceCertificates = new ServiceCertificateOperations(this);
            this._virtualMachineDisks = new VirtualMachineDiskOperations(this);
            this._virtualMachineExtensions = new VirtualMachineExtensionOperations(this);
            this._virtualMachineImages = new VirtualMachineImageOperations(this);
            this._virtualMachines = new VirtualMachineOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </param>
        /// <param name='baseUri'>
        /// The URI used as the base for all Service Management requests.
        /// </param>
        public ComputeManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </param>
        public ComputeManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// The request ID for the request you wish to track. The request ID is
        /// returned in the x-ms-request-id response header for every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Compute.Models.ComputeOperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken)
        {
            // Validate
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("requestId", requestId);
                Tracing.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = new Uri(this.BaseUri, "/").ToString() + this.Credentials.SubscriptionId + "/operations/" + requestId;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-11-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Xml);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ComputeOperationStatusResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new ComputeOperationStatusResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement operationElement = responseDoc.Element(XName.Get("Operation", "http://schemas.microsoft.com/windowsazure"));
                    if (operationElement != null)
                    {
                        XElement idElement = operationElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                        if (idElement != null)
                        {
                            string idInstance = idElement.Value;
                            result.Id = idInstance;
                        }
                        
                        XElement statusElement = operationElement.Element(XName.Get("Status", "http://schemas.microsoft.com/windowsazure"));
                        if (statusElement != null)
                        {
                            OperationStatus statusInstance = (OperationStatus)Enum.Parse(typeof(OperationStatus), statusElement.Value, false);
                            result.Status = statusInstance;
                        }
                        
                        XElement httpStatusCodeElement = operationElement.Element(XName.Get("HttpStatusCode", "http://schemas.microsoft.com/windowsazure"));
                        if (httpStatusCodeElement != null)
                        {
                            HttpStatusCode httpStatusCodeInstance = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), httpStatusCodeElement.Value, false);
                            result.HttpStatusCode = httpStatusCodeInstance;
                        }
                        
                        XElement errorElement = operationElement.Element(XName.Get("Error", "http://schemas.microsoft.com/windowsazure"));
                        if (errorElement != null)
                        {
                            ComputeOperationStatusResponse.ErrorDetails errorInstance = new ComputeOperationStatusResponse.ErrorDetails();
                            result.Error = errorInstance;
                            
                            XElement codeElement = errorElement.Element(XName.Get("Code", "http://schemas.microsoft.com/windowsazure"));
                            if (codeElement != null)
                            {
                                string codeInstance = codeElement.Value;
                                errorInstance.Code = codeInstance;
                            }
                            
                            XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/windowsazure"));
                            if (messageElement != null)
                            {
                                string messageInstance = messageElement.Value;
                                errorInstance.Message = messageInstance;
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Parse enum values for type CertificateFormat.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static CertificateFormat ParseCertificateFormat(string value)
        {
            if (value == "pfx")
            {
                return CertificateFormat.Pfx;
            }
            if (value == "cer")
            {
                return CertificateFormat.Cer;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type CertificateFormat to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string CertificateFormatToString(CertificateFormat value)
        {
            if (value == CertificateFormat.Pfx)
            {
                return "pfx";
            }
            if (value == CertificateFormat.Cer)
            {
                return "cer";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type HostingResources.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static HostingResources ParseHostingResources(string value)
        {
            if (value == "WebRole")
            {
                return HostingResources.WebRole;
            }
            if (value == "WorkerRole")
            {
                return HostingResources.WorkerRole;
            }
            if (value == "WebRole|WorkerRole")
            {
                return HostingResources.WebOrWorkerRole;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type HostingResources to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string HostingResourcesToString(HostingResources value)
        {
            if (value == HostingResources.WebRole)
            {
                return "WebRole";
            }
            if (value == HostingResources.WorkerRole)
            {
                return "WorkerRole";
            }
            if (value == HostingResources.WebOrWorkerRole)
            {
                return "WebRole|WorkerRole";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type LoadBalancerProbeTransportProtocol.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static LoadBalancerProbeTransportProtocol ParseLoadBalancerProbeTransportProtocol(string value)
        {
            if (value == "tcp")
            {
                return LoadBalancerProbeTransportProtocol.Tcp;
            }
            if (value == "http")
            {
                return LoadBalancerProbeTransportProtocol.Http;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type LoadBalancerProbeTransportProtocol to a
        /// string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string LoadBalancerProbeTransportProtocolToString(LoadBalancerProbeTransportProtocol value)
        {
            if (value == LoadBalancerProbeTransportProtocol.Tcp)
            {
                return "tcp";
            }
            if (value == LoadBalancerProbeTransportProtocol.Http)
            {
                return "http";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
