﻿// Copyright 2018 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// An exception logger for use from withing a Web Api application.
    /// </summary>
    public interface IWebApiExceptionLogger
    {
        /// <summary>
        /// Logs an exception that occurred.
        /// </summary>
        /// <param name="exception">The exception to log. Cannot be null.</param>
        /// <param name="context">Optional, the current HTTP action context from which to get HTTP context information.
        /// If it is not set, no HTTP context information will be logged alongside exception information.</param>
        void Log(Exception exception, HttpActionContext context = null);

        /// <summary>
        /// Asynchronously logs an exception that occurred.
        /// </summary>
        /// <param name="exception">The exception to log. Cannot be null.</param>
        /// <param name="context">Optional, the current HTTP action context from which to get HTTP context information.
        /// If it is not set, no HTTP context information will be logged alongside exception information.</param>
        /// <param name="cancellationToken">Optional, the token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task LogAsync(Exception exception, HttpActionContext context = null, CancellationToken cancellationToken = default);
    }
}