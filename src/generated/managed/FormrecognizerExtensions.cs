//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Formrecognizer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FormrecognizerActions([ConnectionName] string connectionId)
    {
    }

    public class FormrecognizerTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Formrecognizer;

    public partial class WorkflowManagedActions
    {
        public FormrecognizerActions Formrecognizer(string connectionId) => new FormrecognizerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FormrecognizerTriggers Formrecognizer(string connectionId) => new FormrecognizerTriggers(connectionId);
    }
}