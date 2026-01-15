//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Hashgeneratorip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashgeneratoripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashgeneratorip")]
        public IBodyWorkflowAction<HashResponse> Hash(Expression<Func<string>> bodystring, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<HashResponse>(callPayload);
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

    public enum bodytypeInput
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
    using Microsoft.Azure.Workflows.Sdk.Hashgeneratorip;

    public partial class WorkflowManagedActions
    {
        public HashgeneratoripActions Hashgeneratorip(string connectionId) => new HashgeneratoripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HashgeneratoripTriggers Hashgeneratorip(string connectionId) => new HashgeneratoripTriggers(connectionId);
    }
}