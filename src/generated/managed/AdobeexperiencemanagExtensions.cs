//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobeexperiencemanag
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobeexperiencemanagActions([ConnectionName] string connectionId)
    {
    }

    public class AdobeexperiencemanagTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobeexperiencemanag;

    public partial class WorkflowManagedActions
    {
        public AdobeexperiencemanagActions Adobeexperiencemanag(string connectionId) => new AdobeexperiencemanagActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobeexperiencemanagTriggers Adobeexperiencemanag(string connectionId) => new AdobeexperiencemanagTriggers(connectionId);
    }
}