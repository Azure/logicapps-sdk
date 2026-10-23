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
        public IBodyWorkflowAction<ParseNameResponse, ApiConnectionActionConfiguration> ParseName(Expression<Func<JToken[]>> bodyinputPersonpersonNamepersonNames, Expression<Func<bodyinputPersongenderInput>> bodyinputPersongender = null)
        {
            var __workflow_bodyinputPersonpersonNamepersonNames = WorkflowExpression.Compile(bodyinputPersonpersonNamepersonNames, nameof(bodyinputPersonpersonNamepersonNames), required: true);
            var __workflow_bodyinputPersongender = WorkflowExpression.Compile(bodyinputPersongender, nameof(bodyinputPersongender), required: false);
            return new DeferredBodyAction<ParseNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v5.3/parser/personnameparser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputPersonObject = new JObject();
                var inputPersonObjectpropCount = 0;
                inputPersonObject["type"] = "NaturalInputPerson";
                inputPersonObjectpropCount++;
                var personNameObject = new JObject();
                var personNameObjectpropCount = 0;
                personNameObjectpropCount++;
                personNameObject["nameFields"] = ExpressionConverter.ConvertO(__workflow_bodyinputPersonpersonNamepersonNames);
                if (personNameObjectpropCount > 0)
                {
                    inputPersonObject["personName"] = personNameObject;
                    inputPersonObjectpropCount++;
                }

                if (__workflow_bodyinputPersongender != null)
                {
                    inputPersonObject["gender"] = ExpressionConverter.ConvertO(__workflow_bodyinputPersongender);
                    inputPersonObjectpropCount++;
                }

                if (inputPersonObjectpropCount > 0)
                {
                    body["inputPerson"] = inputPersonObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinputPersongenderInput
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
