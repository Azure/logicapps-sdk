//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Noxtuasubmission
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NoxtuasubmissionActions([ConnectionName] string connectionId)
    {
    }

    public class NoxtuasubmissionTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Noxtuasubmission;

    public partial class WorkflowManagedActions
    {
        public NoxtuasubmissionActions Noxtuasubmission(string connectionId) => new NoxtuasubmissionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NoxtuasubmissionTriggers Noxtuasubmission(string connectionId) => new NoxtuasubmissionTriggers(connectionId);
    }
}