//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Public360
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Public360Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFile))]
        public IBodyWorkflowAction<CreateFileResponse> CreateFile([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparameterdocumentNumber = null, [WorkflowExpression] Func<int> bodyparameterdocumentRecno = null, [WorkflowExpression] Func<string> bodyparameterformat = null, [WorkflowExpression] Func<string> bodyparameterbase64Data = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFileResponse> __BuildCreateFile(WorkflowExpression<string> hosturl, WorkflowExpression<string> bodyparametertitle = null, WorkflowExpression<string> bodyparameterdocumentNumber = null, WorkflowExpression<int> bodyparameterdocumentRecno = null, WorkflowExpression<string> bodyparameterformat = null, WorkflowExpression<string> bodyparameterbase64Data = null, WorkflowExpression<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            WorkflowExpression.Validate(hosturl, nameof(hosturl), required: true);
            WorkflowExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            WorkflowExpression.Validate(bodyparameterdocumentNumber, nameof(bodyparameterdocumentNumber), required: false);
            WorkflowExpression.Validate(bodyparameterdocumentRecno, nameof(bodyparameterdocumentRecno), required: false);
            WorkflowExpression.Validate(bodyparameterformat, nameof(bodyparameterformat), required: false);
            WorkflowExpression.Validate(bodyparameterbase64Data, nameof(bodyparameterbase64Data), required: false);
            WorkflowExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateFileResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService/CreateFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdocumentNumber != null)
                {
                    parameterObject["DocumentNumber"] = ExpressionConverter.ConvertO(bodyparameterdocumentNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdocumentRecno != null)
                {
                    parameterObject["DocumentRecno"] = ExpressionConverter.ConvertO(bodyparameterdocumentRecno);
                    parameterObjectpropCount++;
                }

                if (bodyparameterformat != null)
                {
                    parameterObject["Format"] = ExpressionConverter.ConvertO(bodyparameterformat);
                    parameterObjectpropCount++;
                }

                if (bodyparameterbase64Data != null)
                {
                    parameterObject["Base64Data"] = ExpressionConverter.ConvertO(bodyparameterbase64Data);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(bodyparameteradditionalFields);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparametercaseNumber = null, [WorkflowExpression] Func<string> bodyparameterdefaultValueSet = null, [WorkflowExpression] Func<string> bodyparameterunofficialTitle = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonEmail = null, [WorkflowExpression] Func<string> bodyparametercategory = null, [WorkflowExpression] Func<string> bodyparameterstatus = null, [WorkflowExpression] Func<string> bodyparameterarchive = null, [WorkflowExpression] Func<string> bodyparameternotes = null, [WorkflowExpression] Func<bodyparametercontactsInputItem[]> bodyparametercontacts = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentResponse> __BuildCreateDocument(WorkflowExpression<string> hosturl, WorkflowExpression<string> bodyparametertitle = null, WorkflowExpression<string> bodyparametercaseNumber = null, WorkflowExpression<string> bodyparameterdefaultValueSet = null, WorkflowExpression<string> bodyparameterunofficialTitle = null, WorkflowExpression<string> bodyparameterresponsiblePersonEmail = null, WorkflowExpression<string> bodyparametercategory = null, WorkflowExpression<string> bodyparameterstatus = null, WorkflowExpression<string> bodyparameterarchive = null, WorkflowExpression<string> bodyparameternotes = null, WorkflowExpression<bodyparametercontactsInputItem[]> bodyparametercontacts = null, WorkflowExpression<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            WorkflowExpression.Validate(hosturl, nameof(hosturl), required: true);
            WorkflowExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            WorkflowExpression.Validate(bodyparametercaseNumber, nameof(bodyparametercaseNumber), required: false);
            WorkflowExpression.Validate(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            WorkflowExpression.Validate(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            WorkflowExpression.Validate(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            WorkflowExpression.Validate(bodyparametercategory, nameof(bodyparametercategory), required: false);
            WorkflowExpression.Validate(bodyparameterstatus, nameof(bodyparameterstatus), required: false);
            WorkflowExpression.Validate(bodyparameterarchive, nameof(bodyparameterarchive), required: false);
            WorkflowExpression.Validate(bodyparameternotes, nameof(bodyparameternotes), required: false);
            WorkflowExpression.Validate(bodyparametercontacts, nameof(bodyparametercontacts), required: false);
            WorkflowExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateDocumentResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparametercaseNumber != null)
                {
                    parameterObject["CaseNumber"] = ExpressionConverter.ConvertO(bodyparametercaseNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = ExpressionConverter.ConvertO(bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = ExpressionConverter.ConvertO(bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = ExpressionConverter.ConvertO(bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (bodyparametercategory != null)
                {
                    parameterObject["Category"] = ExpressionConverter.ConvertO(bodyparametercategory);
                    parameterObjectpropCount++;
                }

                if (bodyparameterstatus != null)
                {
                    parameterObject["Status"] = ExpressionConverter.ConvertO(bodyparameterstatus);
                    parameterObjectpropCount++;
                }

                if (bodyparameterarchive != null)
                {
                    parameterObject["Archive"] = ExpressionConverter.ConvertO(bodyparameterarchive);
                    parameterObjectpropCount++;
                }

                if (bodyparameternotes != null)
                {
                    parameterObject["Notes"] = ExpressionConverter.ConvertO(bodyparameternotes);
                    parameterObjectpropCount++;
                }

                if (bodyparametercontacts != null)
                {
                    parameterObject["Contacts"] = ExpressionConverter.ConvertO(bodyparametercontacts);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(bodyparameteradditionalFields);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateCase))]
        public IBodyWorkflowAction<CreateCaseResponse> CreateCase([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparameterdefaultValueSet = null, [WorkflowExpression] Func<string> bodyparameterunofficialTitle = null, [WorkflowExpression] Func<string> bodyparametercaseType = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonEmail = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonIdNumber = null, [WorkflowExpression] Func<string> bodyparameterresponsibleEnterpriseNumber = null, [WorkflowExpression] Func<int> bodyparameterprogressPlanId = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCaseResponse> __BuildCreateCase(WorkflowExpression<string> hosturl, WorkflowExpression<string> bodyparametertitle = null, WorkflowExpression<string> bodyparameterdefaultValueSet = null, WorkflowExpression<string> bodyparameterunofficialTitle = null, WorkflowExpression<string> bodyparametercaseType = null, WorkflowExpression<string> bodyparameterresponsiblePersonEmail = null, WorkflowExpression<string> bodyparameterresponsiblePersonIdNumber = null, WorkflowExpression<string> bodyparameterresponsibleEnterpriseNumber = null, WorkflowExpression<int> bodyparameterprogressPlanId = null, WorkflowExpression<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            WorkflowExpression.Validate(hosturl, nameof(hosturl), required: true);
            WorkflowExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            WorkflowExpression.Validate(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            WorkflowExpression.Validate(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            WorkflowExpression.Validate(bodyparametercaseType, nameof(bodyparametercaseType), required: false);
            WorkflowExpression.Validate(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            WorkflowExpression.Validate(bodyparameterresponsiblePersonIdNumber, nameof(bodyparameterresponsiblePersonIdNumber), required: false);
            WorkflowExpression.Validate(bodyparameterresponsibleEnterpriseNumber, nameof(bodyparameterresponsibleEnterpriseNumber), required: false);
            WorkflowExpression.Validate(bodyparameterprogressPlanId, nameof(bodyparameterprogressPlanId), required: false);
            WorkflowExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            return new DeferredBodyAction<CreateCaseResponse>(() =>
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService/CreateCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = ExpressionConverter.Convert(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = ExpressionConverter.ConvertO(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = ExpressionConverter.ConvertO(bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = ExpressionConverter.ConvertO(bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (bodyparametercaseType != null)
                {
                    parameterObject["CaseType"] = ExpressionConverter.ConvertO(bodyparametercaseType);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = ExpressionConverter.ConvertO(bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonIdNumber != null)
                {
                    parameterObject["ResponsiblePersonIdNumber"] = ExpressionConverter.ConvertO(bodyparameterresponsiblePersonIdNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsibleEnterpriseNumber != null)
                {
                    parameterObject["ResponsibleEnterpriseNumber"] = ExpressionConverter.ConvertO(bodyparameterresponsibleEnterpriseNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterprogressPlanId != null)
                {
                    parameterObject["ProgressPlanId"] = ExpressionConverter.ConvertO(bodyparameterprogressPlanId);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = ExpressionConverter.ConvertO(bodyparameteradditionalFields);
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