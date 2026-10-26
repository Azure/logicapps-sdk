//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nameapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NameapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nameapi")]
        public IBodyWorkflowAction<ParseNameResponse, ApiConnectionActionConfiguration> ParseName(Expression<Func<ParseNameInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ParseNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v5.3/parser/personnameparser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ParseNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nameapi")]
        public IBodyWorkflowAction<DetectDeaResponse, ApiConnectionActionConfiguration> DetectDea(Expression<Func<string>> emailAddress)
        {
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: true);
            return new DeferredBodyAction<DetectDeaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v5.3/email/disposableemailaddressdetector";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailAddress"] = ExpressionConverter.Convert(__workflow_emailAddress);
                return new ApiConnectionAction<DetectDeaResponse>(callPayload);
            });
        }
    }

    public class NameapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class ParseNameResponse
    {
        [JsonProperty("matches")]
        public ParseNameResponseMatchesTypeItem[] Matches { get; set; }

        [JsonProperty("bestMatch")]
        public ParseNameResponseBestMatchType BestMatch { get; set; }
    }

    public class ParseNameResponseMatchesTypeItem
    {
        [JsonProperty("parsedPerson")]
        public ParsedPersonRef ParsedPerson { get; set; }

        [JsonProperty("parserDisputes")]
        public JToken[] ParserDisputes { get; set; }

        [JsonProperty("likeliness")]
        public double Likeliness { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ParsedPersonRef
    {
        [JsonProperty("personType")]
        public string PersonType { get; set; }

        [JsonProperty("personRole")]
        public string PersonRole { get; set; }

        [JsonProperty("mailingPersonRoles")]
        public string[] MailingPersonRoles { get; set; }

        [JsonProperty("gender")]
        public ParsedPersonRefGenderType Gender { get; set; }

        [JsonProperty("addressingGivenName")]
        public string AddressingGivenName { get; set; }

        [JsonProperty("addressingSurname")]
        public string AddressingSurname { get; set; }

        [JsonProperty("outputPersonName")]
        public ParsedPersonRefOutputPersonNameType OutputPersonName { get; set; }
    }

    public class ParsedPersonRefGenderType
    {
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("maleProportion")]
        public string MaleProportion { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ParsedPersonRefOutputPersonNameType
    {
        [JsonProperty("terms")]
        public ParsedPersonRefOutputPersonNameTypeTermsTypeItem[] Terms { get; set; }
    }

    public class ParsedPersonRefOutputPersonNameTypeTermsTypeItem
    {
        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("termType")]
        public string TermType { get; set; }
    }

    public class ParseNameResponseBestMatchType
    {
        [JsonProperty("parsedPerson")]
        public ParsedPersonRef ParsedPerson { get; set; }

        [JsonProperty("parserDisputes")]
        public JToken[] ParserDisputes { get; set; }

        [JsonProperty("likeliness")]
        public double Likeliness { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class ParseNameInput
    {
        [JsonProperty("inputPerson", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParseNameInputInputPersonType InputPerson { get; set; }
    }

    public class ParseNameInputInputPersonType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "NaturalInputPerson";

        [JsonProperty("personName")]
        public ParseNameInputInputPersonTypePersonNameType PersonName { get; set; }

        [JsonProperty("gender")]
        public ParseNameInputInputPersonTypeGenderType? Gender { get; set; }
    }

    public class ParseNameInputInputPersonTypePersonNameType
    {
        [JsonProperty("nameFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] PersonNames { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParseNameInputInputPersonTypeGenderType
    {
        MALE,
        FEMALE,
        UNKNOWN
    }

    public class DetectDeaResponse
    {
        [JsonProperty("disposable")]
        public string Disposable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nameapi;

    public partial class WorkflowManagedActions
    {
        public NameapiActions Nameapi(string connectionId) => new NameapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NameapiTriggers Nameapi(string connectionId) => new NameapiTriggers(connectionId);
    }
}