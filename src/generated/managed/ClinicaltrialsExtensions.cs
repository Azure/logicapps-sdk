//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clinicaltrials
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClinicaltrialsActions([ConnectionName] string connectionId)
    {
    }

    public class ClinicaltrialsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clinicaltrials;

    public partial class WorkflowManagedActions
    {
        public ClinicaltrialsActions Clinicaltrials(string connectionId) => new ClinicaltrialsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClinicaltrialsTriggers Clinicaltrials(string connectionId) => new ClinicaltrialsTriggers(connectionId);
    }
}