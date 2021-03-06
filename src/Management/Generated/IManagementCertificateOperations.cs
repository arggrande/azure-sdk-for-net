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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management
{
    /// <summary>
    /// You can use management certificates, which are also known as
    /// subscription certificates, to authenticate clients attempting to
    /// connect to resources associated with your Windows Azure subscription.
    /// (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154124.aspx for
    /// more information)
    /// </summary>
    public partial interface IManagementCertificateOperations
    {
        /// <summary>
        /// The Add Management Certificate operation adds a certificate to the
        /// list of management certificates. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154123.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Management Certificate operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateAsync(ManagementCertificateCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Management Certificate operation deletes a certificate
        /// from the list of management certificates. Management certificates,
        /// which are also known as subscription certificates, authenticate
        /// clients attempting to connect to resources associated with your
        /// Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154127.aspx
        /// for more information)
        /// </summary>
        /// <param name='thumbprint'>
        /// the thumbprint value of the certificate to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string thumbprint, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Management Certificate operation retrieves information
        /// about the management certificate with the specified thumbprint.
        /// Management certificates, which are also known as subscription
        /// certificates, authenticate clients attempting to connect to
        /// resources associated with your Windows Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154131.aspx
        /// for more information)
        /// </summary>
        /// <param name='thumbprint'>
        /// The thumbprint value of the certificate to retrieve information
        /// about.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Management Certificate operation response.
        /// </returns>
        Task<ManagementCertificateGetResponse> GetAsync(string thumbprint, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Management Certificates operation lists and returns basic
        /// information about all of the management certificates associated
        /// with the specified subscription. Management certificates, which
        /// are also known as subscription certificates, authenticate clients
        /// attempting to connect to resources associated with your Windows
        /// Azure subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154105.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Management Certificates operation response.
        /// </returns>
        Task<ManagementCertificateListResponse> ListAsync(CancellationToken cancellationToken);
    }
}
