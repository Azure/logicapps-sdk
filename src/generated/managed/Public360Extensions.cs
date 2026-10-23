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
        public IBodyWorkflowAction<CreateFileResponse> CreateFile(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparameterdocumentNumber = null, Expression<Func<int>> bodyparameterdocumentRecno = null, Expression<Func<string>> bodyparameterformat = null, Expression<Func<string>> bodyparameterbase64Data = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = WorkflowExpression.Compile(bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparameterdocumentNumber = WorkflowExpression.Compile(bodyparameterdocumentNumber, nameof(bodyparameterdocumentNumber), required: false);
            var __workflow_bodyparameterdocumentRecno = WorkflowExpression.Compile(bodyparameterdocumentRecno, nameof(bodyparameterdocumentRecno), required: false);
            var __workflow_bodyparameterformat = WorkflowExpression.Compile(bodyparameterformat, nameof(bodyparameterformat), required: false);
            var __workflow_bodyparameterbase64Data = WorkflowExpression.Compile(bodyparameterbase64Data, nameof(bodyparameterbase64Data), required: false);
            var __workflow_bodyparameteradditionalFields = WorkflowExpression.Compile(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateFileResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService/CreateFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (__workflow_bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterdocumentNumber != null)
                {
                    parameterObject["DocumentNumber"] = ExpressionConverter.ConvertO(__workflow_bodyparameterdocumentNumber);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterdocumentRecno != null)
                {
                    parameterObject["DocumentRecno"] = ExpressionConverter.ConvertO(__workflow_bodyparameterdocumentRecno);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterformat != null)
                {
                    parameterObject["Format"] = ExpressionConverter.ConvertO(__workflow_bodyparameterformat);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterbase64Data != null)
                {
                    parameterObject["Base64Data"] = ExpressionConverter.ConvertO(__workflow_bodyparameterbase64Data);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_bodyparameteradditionalFields);
                    parameterObjectpropCount++;
                }

                if (parameterObjectpropCount > 0)
                {
                    body["parameter"] = parameterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparametercaseNumber = null, Expression<Func<string>> bodyparameterdefaultValueSet = null, Expression<Func<string>> bodyparameterunofficialTitle = null, Expression<Func<string>> bodyparameterresponsiblePersonEmail = null, Expression<Func<string>> bodyparametercategory = null, Expression<Func<string>> bodyparameterstatus = null, Expression<Func<string>> bodyparameterarchive = null, Expression<Func<string>> bodyparameternotes = null, Expression<Func<bodyparametercontactsInputItem[]>> bodyparametercontacts = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = WorkflowExpression.Compile(bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparametercaseNumber = WorkflowExpression.Compile(bodyparametercaseNumber, nameof(bodyparametercaseNumber), required: false);
            var __workflow_bodyparameterdefaultValueSet = WorkflowExpression.Compile(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            var __workflow_bodyparameterunofficialTitle = WorkflowExpression.Compile(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            var __workflow_bodyparameterresponsiblePersonEmail = WorkflowExpression.Compile(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            var __workflow_bodyparametercategory = WorkflowExpression.Compile(bodyparametercategory, nameof(bodyparametercategory), required: false);
            var __workflow_bodyparameterstatus = WorkflowExpression.Compile(bodyparameterstatus, nameof(bodyparameterstatus), required: false);
            var __workflow_bodyparameterarchive = WorkflowExpression.Compile(bodyparameterarchive, nameof(bodyparameterarchive), required: false);
            var __workflow_bodyparameternotes = WorkflowExpression.Compile(bodyparameternotes, nameof(bodyparameternotes), required: false);
            var __workflow_bodyparametercontacts = WorkflowExpression.Compile(bodyparametercontacts, nameof(bodyparametercontacts), required: false);
            var __workflow_bodyparameteradditionalFields = WorkflowExpression.Compile(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateDocumentResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (__workflow_bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparametercaseNumber != null)
                {
                    parameterObject["CaseNumber"] = ExpressionConverter.ConvertO(__workflow_bodyparametercaseNumber);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = ExpressionConverter.ConvertO(__workflow_bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = ExpressionConverter.ConvertO(__workflow_bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = ExpressionConverter.ConvertO(__workflow_bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparametercategory != null)
                {
                    parameterObject["Category"] = ExpressionConverter.ConvertO(__workflow_bodyparametercategory);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterstatus != null)
                {
                    parameterObject["Status"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstatus);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterarchive != null)
                {
                    parameterObject["Archive"] = ExpressionConverter.ConvertO(__workflow_bodyparameterarchive);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameternotes != null)
                {
                    parameterObject["Notes"] = ExpressionConverter.ConvertO(__workflow_bodyparameternotes);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparametercontacts != null)
                {
                    parameterObject["Contacts"] = ExpressionConverter.ConvertO(__workflow_bodyparametercontacts);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_bodyparameteradditionalFields);
                    parameterObjectpropCount++;
                }

                if (parameterObjectpropCount > 0)
                {
                    body["parameter"] = parameterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateCaseResponse> CreateCase(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparameterdefaultValueSet = null, Expression<Func<string>> bodyparameterunofficialTitle = null, Expression<Func<string>> bodyparametercaseType = null, Expression<Func<string>> bodyparameterresponsiblePersonEmail = null, Expression<Func<string>> bodyparameterresponsiblePersonIdNumber = null, Expression<Func<string>> bodyparameterresponsibleEnterpriseNumber = null, Expression<Func<int>> bodyparameterprogressPlanId = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var __workflow_hosturl = WorkflowExpression.Compile(hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = WorkflowExpression.Compile(bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparameterdefaultValueSet = WorkflowExpression.Compile(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            var __workflow_bodyparameterunofficialTitle = WorkflowExpression.Compile(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            var __workflow_bodyparametercaseType = WorkflowExpression.Compile(bodyparametercaseType, nameof(bodyparametercaseType), required: false);
            var __workflow_bodyparameterresponsiblePersonEmail = WorkflowExpression.Compile(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            var __workflow_bodyparameterresponsiblePersonIdNumber = WorkflowExpression.Compile(bodyparameterresponsiblePersonIdNumber, nameof(bodyparameterresponsiblePersonIdNumber), required: false);
            var __workflow_bodyparameterresponsibleEnterpriseNumber = WorkflowExpression.Compile(bodyparameterresponsibleEnterpriseNumber, nameof(bodyparameterresponsibleEnterpriseNumber), required: false);
            var __workflow_bodyparameterprogressPlanId = WorkflowExpression.Compile(bodyparameterprogressPlanId, nameof(bodyparameterprogressPlanId), required: false);
            var __workflow_bodyparameteradditionalFields = WorkflowExpression.Compile(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateCaseResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService/CreateCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(__workflow_hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (__workflow_bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = ExpressionConverter.ConvertO(__workflow_bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = ExpressionConverter.ConvertO(__workflow_bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparametercaseType != null)
                {
                    parameterObject["CaseType"] = ExpressionConverter.ConvertO(__workflow_bodyparametercaseType);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = ExpressionConverter.ConvertO(__workflow_bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterresponsiblePersonIdNumber != null)
                {
                    parameterObject["ResponsiblePersonIdNumber"] = ExpressionConverter.ConvertO(__workflow_bodyparameterresponsiblePersonIdNumber);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterresponsibleEnterpriseNumber != null)
                {
                    parameterObject["ResponsibleEnterpriseNumber"] = ExpressionConverter.ConvertO(__workflow_bodyparameterresponsibleEnterpriseNumber);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameterprogressPlanId != null)
                {
                    parameterObject["ProgressPlanId"] = ExpressionConverter.ConvertO(__workflow_bodyparameterprogressPlanId);
                    parameterObjectpropCount++;
                }

                if (__workflow_bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(__workflow_bodyparameteradditionalFields);
                    parameterObjectpropCount++;
                }

                if (parameterObjectpropCount > 0)
                {
                    body["parameter"] = parameterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodyparameteradditionalFieldsInputItem
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

    public class bodyparametercontactsInputItem
    {
        public string Role { get; set; }
        public string ReferenceNumber { get; set; }
    }

    public class CreateCaseResponse
    {
        public int Recno { get; set; }
        public string CaseNumber { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
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
