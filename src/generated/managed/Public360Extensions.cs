//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Public360
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Public360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateFileResponse, ApiConnectionActionConfiguration> CreateFile(Expression<Func<string>> hosturl, Expression<Func<CreateFileInput>> body)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService/CreateFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateDocumentResponse, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> hosturl, Expression<Func<CreateDocumentInput>> body)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateCaseResponse, ApiConnectionActionConfiguration> CreateCase(Expression<Func<string>> hosturl, Expression<Func<CreateCaseInput>> body)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService/CreateCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCaseResponse>(callPayload);
            });
        }
    }

    public class Public360Triggers([ConnectionName] string connectionId)
    {
    }

    public class CreateFileResponse
    {
        public int Recno { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }

    public class CreateFileInput
    {
        [JsonProperty("parameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateFileInputParameterType Parameter { get; set; }
    }

    public class CreateFileInputParameterType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
        public string DocumentNumber { get; set; }
        public int? DocumentRecno { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Format { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64Data { get; set; }
        public CreateFileInputParameterTypeAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class CreateFileInputParameterTypeAdditionalFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CreateDocumentResponse
    {
        public int Recno { get; set; }
        public string DocumentNumber { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }

    public class CreateDocumentInput
    {
        [JsonProperty("parameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocumentInputParameterType Parameter { get; set; }
    }

    public class CreateDocumentInputParameterType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
        public string CaseNumber { get; set; }
        public string DefaultValueSet { get; set; }
        public string UnofficialTitle { get; set; }
        public string ResponsiblePersonEmail { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Archive { get; set; }
        public string Notes { get; set; }
        public CreateDocumentInputParameterTypeContactsTypeItem[] Contacts { get; set; }
        public CreateDocumentInputParameterTypeAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class CreateDocumentInputParameterTypeContactsTypeItem
    {
        public string Role { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class CreateDocumentInputParameterTypeAdditionalFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CreateCaseResponse
    {
        public int Recno { get; set; }
        public string CaseNumber { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }

    public class CreateCaseInput
    {
        [JsonProperty("parameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCaseInputParameterType Parameter { get; set; }
    }

    public class CreateCaseInputParameterType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
        public string DefaultValueSet { get; set; }
        public string UnofficialTitle { get; set; }
        public string CaseType { get; set; }
        public string ResponsiblePersonEmail { get; set; }
        public string ResponsiblePersonIdNumber { get; set; }
        public string ResponsibleEnterpriseNumber { get; set; }
        public int? ProgressPlanId { get; set; }
        public CreateCaseInputParameterTypeAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class CreateCaseInputParameterTypeAdditionalFieldsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Public360;

    public partial class WorkflowManagedActions
    {
        public Public360Actions Public360(string connectionId) => new Public360Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Public360Triggers Public360(string connectionId) => new Public360Triggers(connectionId);
    }
}