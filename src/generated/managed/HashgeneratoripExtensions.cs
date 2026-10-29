//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashgeneratorip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashgeneratoripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashgeneratorip")]
        public IBodyWorkflowAction<HashResponse, ApiConnectionActionConfiguration> Hash(Expression<Func<HashInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<HashResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HashResponse>(callPayload);
            });
        }
    }

    public class HashgeneratoripTriggers([ConnectionName] string connectionId)
    {
    }

    public class HashResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("valueToHash")]
        public string ValueToHash { get; set; }
    }

    public class HashInput
    {
        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public HashInputTypeType? Type { get; set; } = HashInputTypeType.SHA1;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HashInputTypeType
    {
        [EnumMember(Value = "sha1")]
        SHA1,
        [EnumMember(Value = "sha256")]
        SHA256,
        [EnumMember(Value = "sha512")]
        SHA512,
        [EnumMember(Value = "md5")]
        MD5
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hashgeneratorip;

    public partial class WorkflowManagedActions
    {
        public HashgeneratoripActions Hashgeneratorip(string connectionId) => new HashgeneratoripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HashgeneratoripTriggers Hashgeneratorip(string connectionId) => new HashgeneratoripTriggers(connectionId);
    }
}