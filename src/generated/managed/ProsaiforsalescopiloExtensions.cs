//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Prosaiforsalescopilo
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProsaiforsalescopiloActions([ConnectionName] string connectionId)
    {
    }

    public class ProsaiforsalescopiloTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Prosaiforsalescopilo;

    public partial class WorkflowManagedActions
    {
        public ProsaiforsalescopiloActions Prosaiforsalescopilo(string connectionId) => new ProsaiforsalescopiloActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProsaiforsalescopiloTriggers Prosaiforsalescopilo(string connectionId) => new ProsaiforsalescopiloTriggers(connectionId);
    }
}