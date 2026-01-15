//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Microsofttranslator
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosofttranslatorActions([ConnectionName] string connectionId)
    {
    }

    public class MicrosofttranslatorTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Microsofttranslator;

    public partial class WorkflowManagedActions
    {
        public MicrosofttranslatorActions Microsofttranslator(string connectionId) => new MicrosofttranslatorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosofttranslatorTriggers Microsofttranslator(string connectionId) => new MicrosofttranslatorTriggers(connectionId);
    }
}