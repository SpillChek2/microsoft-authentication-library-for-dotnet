﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Identity.Client.Core;
using Microsoft.Identity.Client.PlatformsCommon.Interfaces;
using Microsoft.Identity.Client.UI;
using System;

namespace Microsoft.Identity.Client.Platforms.Mac
{
    internal class MacUIFactory : IWebUIFactory
    {
        public IWebUI CreateAuthenticationDialog(CoreUIParent parent, RequestContext requestContext)
        {
            return new MacEmbeddedWebUI()
            {
                CoreUIParent = parent,
                RequestContext = requestContext
            };
        }
    }
}
