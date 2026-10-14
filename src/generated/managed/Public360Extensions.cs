//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Public360
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Public360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateFileResponse> CreateFile(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparameterdocumentNumber = null, Expression<Func<int>> bodyparameterdocumentRecno = null, Expression<Func<string>> bodyparameterformat = null, Expression<Func<string>> bodyparameterbase64Data = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var __workflow_hosturl = hosturl == null ? null : WorkflowExpression.Compile(hosturl);
            WorkflowExpression.Validate(__workflow_hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = bodyparametertitle == null ? null : WorkflowExpression.Compile(bodyparametertitle);
            WorkflowExpression.Validate(__workflow_bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparameterdocumentNumber = bodyparameterdocumentNumber == null ? null : WorkflowExpression.Compile(bodyparameterdocumentNumber);
            WorkflowExpression.Validate(__workflow_bodyparameterdocumentNumber, nameof(bodyparameterdocumentNumber), required: false);
            var __workflow_bodyparameterdocumentRecno = bodyparameterdocumentRecno == null ? null : WorkflowExpression.Compile(bodyparameterdocumentRecno);
            WorkflowExpression.Validate(__workflow_bodyparameterdocumentRecno, nameof(bodyparameterdocumentRecno), required: false);
            var __workflow_bodyparameterformat = bodyparameterformat == null ? null : WorkflowExpression.Compile(bodyparameterformat);
            WorkflowExpression.Validate(__workflow_bodyparameterformat, nameof(bodyparameterformat), required: false);
            var __workflow_bodyparameterbase64Data = bodyparameterbase64Data == null ? null : WorkflowExpression.Compile(bodyparameterbase64Data);
            WorkflowExpression.Validate(__workflow_bodyparameterbase64Data, nameof(bodyparameterbase64Data), required: false);
            var __workflow_bodyparameteradditionalFields = bodyparameteradditionalFields == null ? null : WorkflowExpression.Compile(bodyparameteradditionalFields);
            WorkflowExpression.Validate(__workflow_bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
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
            var __workflow_hosturl = hosturl == null ? null : WorkflowExpression.Compile(hosturl);
            WorkflowExpression.Validate(__workflow_hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = bodyparametertitle == null ? null : WorkflowExpression.Compile(bodyparametertitle);
            WorkflowExpression.Validate(__workflow_bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparametercaseNumber = bodyparametercaseNumber == null ? null : WorkflowExpression.Compile(bodyparametercaseNumber);
            WorkflowExpression.Validate(__workflow_bodyparametercaseNumber, nameof(bodyparametercaseNumber), required: false);
            var __workflow_bodyparameterdefaultValueSet = bodyparameterdefaultValueSet == null ? null : WorkflowExpression.Compile(bodyparameterdefaultValueSet);
            WorkflowExpression.Validate(__workflow_bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            var __workflow_bodyparameterunofficialTitle = bodyparameterunofficialTitle == null ? null : WorkflowExpression.Compile(bodyparameterunofficialTitle);
            WorkflowExpression.Validate(__workflow_bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            var __workflow_bodyparameterresponsiblePersonEmail = bodyparameterresponsiblePersonEmail == null ? null : WorkflowExpression.Compile(bodyparameterresponsiblePersonEmail);
            WorkflowExpression.Validate(__workflow_bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            var __workflow_bodyparametercategory = bodyparametercategory == null ? null : WorkflowExpression.Compile(bodyparametercategory);
            WorkflowExpression.Validate(__workflow_bodyparametercategory, nameof(bodyparametercategory), required: false);
            var __workflow_bodyparameterstatus = bodyparameterstatus == null ? null : WorkflowExpression.Compile(bodyparameterstatus);
            WorkflowExpression.Validate(__workflow_bodyparameterstatus, nameof(bodyparameterstatus), required: false);
            var __workflow_bodyparameterarchive = bodyparameterarchive == null ? null : WorkflowExpression.Compile(bodyparameterarchive);
            WorkflowExpression.Validate(__workflow_bodyparameterarchive, nameof(bodyparameterarchive), required: false);
            var __workflow_bodyparameternotes = bodyparameternotes == null ? null : WorkflowExpression.Compile(bodyparameternotes);
            WorkflowExpression.Validate(__workflow_bodyparameternotes, nameof(bodyparameternotes), required: false);
            var __workflow_bodyparametercontacts = bodyparametercontacts == null ? null : WorkflowExpression.Compile(bodyparametercontacts);
            WorkflowExpression.Validate(__workflow_bodyparametercontacts, nameof(bodyparametercontacts), required: false);
            var __workflow_bodyparameteradditionalFields = bodyparameteradditionalFields == null ? null : WorkflowExpression.Compile(bodyparameteradditionalFields);
            WorkflowExpression.Validate(__workflow_bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
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
            var __workflow_hosturl = hosturl == null ? null : WorkflowExpression.Compile(hosturl);
            WorkflowExpression.Validate(__workflow_hosturl, nameof(hosturl), required: true);
            var __workflow_bodyparametertitle = bodyparametertitle == null ? null : WorkflowExpression.Compile(bodyparametertitle);
            WorkflowExpression.Validate(__workflow_bodyparametertitle, nameof(bodyparametertitle), required: false);
            var __workflow_bodyparameterdefaultValueSet = bodyparameterdefaultValueSet == null ? null : WorkflowExpression.Compile(bodyparameterdefaultValueSet);
            WorkflowExpression.Validate(__workflow_bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            var __workflow_bodyparameterunofficialTitle = bodyparameterunofficialTitle == null ? null : WorkflowExpression.Compile(bodyparameterunofficialTitle);
            WorkflowExpression.Validate(__workflow_bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            var __workflow_bodyparametercaseType = bodyparametercaseType == null ? null : WorkflowExpression.Compile(bodyparametercaseType);
            WorkflowExpression.Validate(__workflow_bodyparametercaseType, nameof(bodyparametercaseType), required: false);
            var __workflow_bodyparameterresponsiblePersonEmail = bodyparameterresponsiblePersonEmail == null ? null : WorkflowExpression.Compile(bodyparameterresponsiblePersonEmail);
            WorkflowExpression.Validate(__workflow_bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            var __workflow_bodyparameterresponsiblePersonIdNumber = bodyparameterresponsiblePersonIdNumber == null ? null : WorkflowExpression.Compile(bodyparameterresponsiblePersonIdNumber);
            WorkflowExpression.Validate(__workflow_bodyparameterresponsiblePersonIdNumber, nameof(bodyparameterresponsiblePersonIdNumber), required: false);
            var __workflow_bodyparameterresponsibleEnterpriseNumber = bodyparameterresponsibleEnterpriseNumber == null ? null : WorkflowExpression.Compile(bodyparameterresponsibleEnterpriseNumber);
            WorkflowExpression.Validate(__workflow_bodyparameterresponsibleEnterpriseNumber, nameof(bodyparameterresponsibleEnterpriseNumber), required: false);
            var __workflow_bodyparameterprogressPlanId = bodyparameterprogressPlanId == null ? null : WorkflowExpression.Compile(bodyparameterprogressPlanId);
            WorkflowExpression.Validate(__workflow_bodyparameterprogressPlanId, nameof(bodyparameterprogressPlanId), required: false);
            var __workflow_bodyparameteradditionalFields = bodyparameteradditionalFields == null ? null : WorkflowExpression.Compile(bodyparameteradditionalFields);
            WorkflowExpression.Validate(__workflow_bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
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
