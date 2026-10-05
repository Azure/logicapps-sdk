//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nameapi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NameapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nameapi")]
        [WorkflowExpressionFactory(nameof(__BuildParseName))]
        public IBodyWorkflowAction<ParseNameResponse> ParseName([WorkflowExpression] Func<JToken[]> bodyinputPersonpersonNamepersonNames, [WorkflowExpression] Func<bodyinputPersongenderInput> bodyinputPersongender = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseNameResponse> __BuildParseName(WorkflowValue<JToken[]> bodyinputPersonpersonNamepersonNames, WorkflowValue<bodyinputPersongenderInput> bodyinputPersongender = null)
        {
            WorkflowValue.Validate(bodyinputPersonpersonNamepersonNames, nameof(bodyinputPersonpersonNamepersonNames), required: true);
            WorkflowValue.Validate(bodyinputPersongender, nameof(bodyinputPersongender), required: false);
            return new DeferredBodyAction<ParseNameResponse>(() =>
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
                personNameObject["nameFields"] = ExpressionConverter.ConvertO(bodyinputPersonpersonNamepersonNames);
                if (personNameObjectpropCount > 0)
                {
                    inputPersonObject["personName"] = personNameObject;
                    inputPersonObjectpropCount++;
                }

                if (bodyinputPersongender != null)
                {
                    inputPersonObject["gender"] = ExpressionConverter.ConvertO(bodyinputPersongender);
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
        [WorkflowExpressionFactory(nameof(__BuildDetectDea))]
        public IBodyWorkflowAction<DetectDeaResponse> DetectDea([WorkflowExpression] Func<string> emailAddress)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectDeaResponse> __BuildDetectDea(WorkflowValue<string> emailAddress)
        {
            WorkflowValue.Validate(emailAddress, nameof(emailAddress), required: true);
            return new DeferredBodyAction<DetectDeaResponse>(() =>
            {
                var apiCallPath = "/v5.3/email/disposableemailaddressdetector";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailAddress"] = ExpressionConverter.Convert(emailAddress);
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
