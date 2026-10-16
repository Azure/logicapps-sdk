//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuretexttospeech
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuretexttospeechActions([ConnectionName] string connectionId)
    {
    }

    public class AzuretexttospeechTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuretexttospeech;

    public partial class WorkflowManagedActions
    {
        public AzuretexttospeechActions Azuretexttospeech(string connectionId) => new AzuretexttospeechActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuretexttospeechTriggers Azuretexttospeech(string connectionId) => new AzuretexttospeechTriggers(connectionId);
    }
}