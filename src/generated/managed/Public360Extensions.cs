//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Public360
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Public360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateFileResponse> CreateFile(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparameterdocumentNumber = null, Expression<Func<int>> bodyparameterdocumentRecno = null, Expression<Func<string>> bodyparameterformat = null, Expression<Func<string>> bodyparameterbase64Data = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService/CreateFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["hosturl"] = CSharpExpressionConverter.ConvertO(hosturl);
            var body = new JObject();
            var bodypropCount = 0;
            var parameterObject = new JObject();
            var parameterObjectpropCount = 0;
            if (bodyparametertitle != null)
            {
                parameterObject["Title"] = CSharpExpressionConverter.ConvertToken(bodyparametertitle);
                parameterObjectpropCount++;
            }

            if (bodyparameterdocumentNumber != null)
            {
                parameterObject["DocumentNumber"] = CSharpExpressionConverter.ConvertToken(bodyparameterdocumentNumber);
                parameterObjectpropCount++;
            }

            if (bodyparameterdocumentRecno != null)
            {
                parameterObject["DocumentRecno"] = CSharpExpressionConverter.ConvertToken(bodyparameterdocumentRecno);
                parameterObjectpropCount++;
            }

            if (bodyparameterformat != null)
            {
                parameterObject["Format"] = CSharpExpressionConverter.ConvertToken(bodyparameterformat);
                parameterObjectpropCount++;
            }

            if (bodyparameterbase64Data != null)
            {
                parameterObject["Base64Data"] = CSharpExpressionConverter.ConvertToken(bodyparameterbase64Data);
                parameterObjectpropCount++;
            }

            if (bodyparameteradditionalFields != null)
            {
                parameterObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparametercaseNumber = null, Expression<Func<string>> bodyparameterdefaultValueSet = null, Expression<Func<string>> bodyparameterunofficialTitle = null, Expression<Func<string>> bodyparameterresponsiblePersonEmail = null, Expression<Func<string>> bodyparametercategory = null, Expression<Func<string>> bodyparameterstatus = null, Expression<Func<string>> bodyparameterarchive = null, Expression<Func<string>> bodyparameternotes = null, Expression<Func<bodyparametercontactsInputItem[]>> bodyparametercontacts = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService/CreateDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["hosturl"] = CSharpExpressionConverter.ConvertO(hosturl);
            var body = new JObject();
            var bodypropCount = 0;
            var parameterObject = new JObject();
            var parameterObjectpropCount = 0;
            if (bodyparametertitle != null)
            {
                parameterObject["Title"] = CSharpExpressionConverter.ConvertToken(bodyparametertitle);
                parameterObjectpropCount++;
            }

            if (bodyparametercaseNumber != null)
            {
                parameterObject["CaseNumber"] = CSharpExpressionConverter.ConvertToken(bodyparametercaseNumber);
                parameterObjectpropCount++;
            }

            if (bodyparameterdefaultValueSet != null)
            {
                parameterObject["DefaultValueSet"] = CSharpExpressionConverter.ConvertToken(bodyparameterdefaultValueSet);
                parameterObjectpropCount++;
            }

            if (bodyparameterunofficialTitle != null)
            {
                parameterObject["UnofficialTitle"] = CSharpExpressionConverter.ConvertToken(bodyparameterunofficialTitle);
                parameterObjectpropCount++;
            }

            if (bodyparameterresponsiblePersonEmail != null)
            {
                parameterObject["ResponsiblePersonEmail"] = CSharpExpressionConverter.ConvertToken(bodyparameterresponsiblePersonEmail);
                parameterObjectpropCount++;
            }

            if (bodyparametercategory != null)
            {
                parameterObject["Category"] = CSharpExpressionConverter.ConvertToken(bodyparametercategory);
                parameterObjectpropCount++;
            }

            if (bodyparameterstatus != null)
            {
                parameterObject["Status"] = CSharpExpressionConverter.ConvertToken(bodyparameterstatus);
                parameterObjectpropCount++;
            }

            if (bodyparameterarchive != null)
            {
                parameterObject["Archive"] = CSharpExpressionConverter.ConvertToken(bodyparameterarchive);
                parameterObjectpropCount++;
            }

            if (bodyparameternotes != null)
            {
                parameterObject["Notes"] = CSharpExpressionConverter.ConvertToken(bodyparameternotes);
                parameterObjectpropCount++;
            }

            if (bodyparametercontacts != null)
            {
                parameterObject["Contacts"] = CSharpExpressionConverter.ConvertToken(bodyparametercontacts);
                parameterObjectpropCount++;
            }

            if (bodyparameteradditionalFields != null)
            {
                parameterObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateCaseResponse> CreateCase(Expression<Func<string>> hosturl, Expression<Func<string>> bodyparametertitle = null, Expression<Func<string>> bodyparameterdefaultValueSet = null, Expression<Func<string>> bodyparameterunofficialTitle = null, Expression<Func<string>> bodyparametercaseType = null, Expression<Func<string>> bodyparameterresponsiblePersonEmail = null, Expression<Func<string>> bodyparameterresponsiblePersonIdNumber = null, Expression<Func<string>> bodyparameterresponsibleEnterpriseNumber = null, Expression<Func<int>> bodyparameterprogressPlanId = null, Expression<Func<bodyparameteradditionalFieldsInputItem[]>> bodyparameteradditionalFields = null)
        {
            var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService/CreateCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["hosturl"] = CSharpExpressionConverter.ConvertO(hosturl);
            var body = new JObject();
            var bodypropCount = 0;
            var parameterObject = new JObject();
            var parameterObjectpropCount = 0;
            if (bodyparametertitle != null)
            {
                parameterObject["Title"] = CSharpExpressionConverter.ConvertToken(bodyparametertitle);
                parameterObjectpropCount++;
            }

            if (bodyparameterdefaultValueSet != null)
            {
                parameterObject["DefaultValueSet"] = CSharpExpressionConverter.ConvertToken(bodyparameterdefaultValueSet);
                parameterObjectpropCount++;
            }

            if (bodyparameterunofficialTitle != null)
            {
                parameterObject["UnofficialTitle"] = CSharpExpressionConverter.ConvertToken(bodyparameterunofficialTitle);
                parameterObjectpropCount++;
            }

            if (bodyparametercaseType != null)
            {
                parameterObject["CaseType"] = CSharpExpressionConverter.ConvertToken(bodyparametercaseType);
                parameterObjectpropCount++;
            }

            if (bodyparameterresponsiblePersonEmail != null)
            {
                parameterObject["ResponsiblePersonEmail"] = CSharpExpressionConverter.ConvertToken(bodyparameterresponsiblePersonEmail);
                parameterObjectpropCount++;
            }

            if (bodyparameterresponsiblePersonIdNumber != null)
            {
                parameterObject["ResponsiblePersonIdNumber"] = CSharpExpressionConverter.ConvertToken(bodyparameterresponsiblePersonIdNumber);
                parameterObjectpropCount++;
            }

            if (bodyparameterresponsibleEnterpriseNumber != null)
            {
                parameterObject["ResponsibleEnterpriseNumber"] = CSharpExpressionConverter.ConvertToken(bodyparameterresponsibleEnterpriseNumber);
                parameterObjectpropCount++;
            }

            if (bodyparameterprogressPlanId != null)
            {
                parameterObject["ProgressPlanId"] = CSharpExpressionConverter.ConvertToken(bodyparameterprogressPlanId);
                parameterObjectpropCount++;
            }

            if (bodyparameteradditionalFields != null)
            {
                parameterObject["AdditionalFields"] = CSharpExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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