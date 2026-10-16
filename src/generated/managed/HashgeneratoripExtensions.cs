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
        public IBodyWorkflowAction<HashResponse> Hash(Expression<Func<string>> bodystring, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<HashResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodytype != null)
                {
                    if (__workflow_bodytype != null)
                    {
                        body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["type"] = "sha1";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
