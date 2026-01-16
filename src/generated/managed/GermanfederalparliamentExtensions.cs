//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Germanfederalparliament
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GermanfederalparliamentActions([ConnectionName] string connectionId)
    {
    }

    public class GermanfederalparliamentTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Germanfederalparliament;

    public partial class WorkflowManagedActions
    {
        public GermanfederalparliamentActions Germanfederalparliament(string connectionId) => new GermanfederalparliamentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GermanfederalparliamentTriggers Germanfederalparliament(string connectionId) => new GermanfederalparliamentTriggers(connectionId);
    }
}