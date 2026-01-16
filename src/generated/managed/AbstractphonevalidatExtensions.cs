//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractphonevalidat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractphonevalidatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractphonevalidat")]
        public IBodyWorkflowAction<ValidateResponse> Validate(Expression<Func<string>> phone)
        {
            var apiCallPath = "/v1/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            return new ApiConnectionAction<ValidateResponse>(callPayload);
        }
    }

    public class AbstractphonevalidatTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateResponse
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("format")]
        public ValidateResponseFormatType Format { get; set; }

        [JsonProperty("country")]
        public ValidateResponseCountryType Country { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }
    }

    public class ValidateResponseFormatType
    {
        [JsonProperty("international")]
        public string International { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }
    }

    public class ValidateResponseCountryType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractphonevalidat;

    public partial class WorkflowManagedActions
    {
        public AbstractphonevalidatActions Abstractphonevalidat(string connectionId) => new AbstractphonevalidatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractphonevalidatTriggers Abstractphonevalidat(string connectionId) => new AbstractphonevalidatTriggers(connectionId);
    }
}