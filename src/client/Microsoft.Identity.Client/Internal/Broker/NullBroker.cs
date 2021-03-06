﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Identity.Client.OAuth2;
using Microsoft.Identity.Client.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Identity.Client.Internal.Broker
{
    /// <summary>
    /// For platforms that do not support a broker (net desktop, net core, UWP, netstandard)
    /// </summary>
    internal class NullBroker : IBroker
    {
        public bool IsBrokerInstalledAndInvokable()
        {
            return false;
        }

        public Task<MsalTokenResponse> AcquireTokenUsingBrokerAsync(Dictionary<string, string> brokerPayload)
        {
            throw new PlatformNotSupportedException(MsalErrorMessage.BrokerNotSupportedOnThisPlatform);
        }

        public Task<IEnumerable<IAccount>> GetAccountsAsync(string clientID)
        {
            throw new PlatformNotSupportedException(MsalErrorMessage.BrokerNotSupportedOnThisPlatform);
        }

        public Task RemoveAccountAsync(string clientID, IAccount account)
        {
            throw new NotImplementedException(MsalErrorMessage.BrokerNotSupportedOnThisPlatform);
        }
    }
}
