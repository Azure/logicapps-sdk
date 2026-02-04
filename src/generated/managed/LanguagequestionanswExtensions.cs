//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Languagequestionansw
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LanguagequestionanswActions([ConnectionName] string connectionId)
    {
    }

    public class LanguagequestionanswTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Languagequestionansw;

    public partial class WorkflowManagedActions
    {
        public LanguagequestionanswActions Languagequestionansw(string connectionId) => new LanguagequestionanswActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LanguagequestionanswTriggers Languagequestionansw(string connectionId) => new LanguagequestionanswTriggers(connectionId);
    }
}