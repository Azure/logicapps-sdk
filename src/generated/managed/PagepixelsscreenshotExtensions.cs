//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pagepixelsscreenshot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PagepixelsscreenshotActions([ConnectionName] string connectionId)
    {
    }

    public class PagepixelsscreenshotTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pagepixelsscreenshot;

    public partial class WorkflowManagedActions
    {
        public PagepixelsscreenshotActions Pagepixelsscreenshot(string connectionId) => new PagepixelsscreenshotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PagepixelsscreenshotTriggers Pagepixelsscreenshot(string connectionId) => new PagepixelsscreenshotTriggers(connectionId);
    }
}