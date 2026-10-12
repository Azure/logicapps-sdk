//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicprograms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicprogramsActions([ConnectionName] string connectionId)
    {
    }

    public class SeismicprogramsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicprograms;

    public partial class WorkflowManagedActions
    {
        public SeismicprogramsActions Seismicprograms(string connectionId) => new SeismicprogramsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicprogramsTriggers Seismicprograms(string connectionId) => new SeismicprogramsTriggers(connectionId);
    }
}