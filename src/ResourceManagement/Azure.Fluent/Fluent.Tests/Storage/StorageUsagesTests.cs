﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Resource.Fluent.Authentication;
using Microsoft.Azure.Management.Resource.Fluent.Core;
using Microsoft.Azure.Management.Storage.Fluent;
using Xunit;

namespace Fluent.Tests.Storage
{
    public class StorageUsagesTests
    {
        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanListUsages()
        {
            var storageManger = CreateStorageManager();
            var usages = storageManger.Usages.List();
        }

        private IStorageManager CreateStorageManager()
        {
            AzureCredentials credentials = AzureCredentials.FromFile(@"C:\my.azureauth");
            return StorageManager
                .Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.BODY)
                .Authenticate(credentials, credentials.DefaultSubscriptionId);
        }
    }
}