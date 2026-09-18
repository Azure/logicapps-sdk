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
        public IBodyWorkflowAction<CreateFileResponse> CreateFile([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparameterdocumentNumber = null, [WorkflowExpression] Func<int> bodyparameterdocumentRecno = null, [WorkflowExpression] Func<string> bodyparameterformat = null, [WorkflowExpression] Func<string> bodyparameterbase64Data = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            SourceExpression.Validate(hosturl, nameof(hosturl), required: true);
            SourceExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            SourceExpression.Validate(bodyparameterdocumentNumber, nameof(bodyparameterdocumentNumber), required: false);
            SourceExpression.Validate(bodyparameterdocumentRecno, nameof(bodyparameterdocumentRecno), required: false);
            SourceExpression.Validate(bodyparameterformat, nameof(bodyparameterformat), required: false);
            SourceExpression.Validate(bodyparameterbase64Data, nameof(bodyparameterbase64Data), required: false);
            SourceExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/FileService/CreateFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = SourceExpressionConverter.ConvertO(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = SourceExpressionConverter.ConvertToken(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdocumentNumber != null)
                {
                    parameterObject["DocumentNumber"] = SourceExpressionConverter.ConvertToken(bodyparameterdocumentNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdocumentRecno != null)
                {
                    parameterObject["DocumentRecno"] = SourceExpressionConverter.ConvertToken(bodyparameterdocumentRecno);
                    parameterObjectpropCount++;
                }

                if (bodyparameterformat != null)
                {
                    parameterObject["Format"] = SourceExpressionConverter.ConvertToken(bodyparameterformat);
                    parameterObjectpropCount++;
                }

                if (bodyparameterbase64Data != null)
                {
                    parameterObject["Base64Data"] = SourceExpressionConverter.ConvertToken(bodyparameterbase64Data);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparametercaseNumber = null, [WorkflowExpression] Func<string> bodyparameterdefaultValueSet = null, [WorkflowExpression] Func<string> bodyparameterunofficialTitle = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonEmail = null, [WorkflowExpression] Func<string> bodyparametercategory = null, [WorkflowExpression] Func<string> bodyparameterstatus = null, [WorkflowExpression] Func<string> bodyparameterarchive = null, [WorkflowExpression] Func<string> bodyparameternotes = null, [WorkflowExpression] Func<bodyparametercontactsInputItem[]> bodyparametercontacts = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            SourceExpression.Validate(hosturl, nameof(hosturl), required: true);
            SourceExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            SourceExpression.Validate(bodyparametercaseNumber, nameof(bodyparametercaseNumber), required: false);
            SourceExpression.Validate(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            SourceExpression.Validate(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            SourceExpression.Validate(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            SourceExpression.Validate(bodyparametercategory, nameof(bodyparametercategory), required: false);
            SourceExpression.Validate(bodyparameterstatus, nameof(bodyparameterstatus), required: false);
            SourceExpression.Validate(bodyparameterarchive, nameof(bodyparameterarchive), required: false);
            SourceExpression.Validate(bodyparameternotes, nameof(bodyparameternotes), required: false);
            SourceExpression.Validate(bodyparametercontacts, nameof(bodyparametercontacts), required: false);
            SourceExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/DocumentService/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = SourceExpressionConverter.ConvertO(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = SourceExpressionConverter.ConvertToken(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparametercaseNumber != null)
                {
                    parameterObject["CaseNumber"] = SourceExpressionConverter.ConvertToken(bodyparametercaseNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = SourceExpressionConverter.ConvertToken(bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = SourceExpressionConverter.ConvertToken(bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = SourceExpressionConverter.ConvertToken(bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (bodyparametercategory != null)
                {
                    parameterObject["Category"] = SourceExpressionConverter.ConvertToken(bodyparametercategory);
                    parameterObjectpropCount++;
                }

                if (bodyparameterstatus != null)
                {
                    parameterObject["Status"] = SourceExpressionConverter.ConvertToken(bodyparameterstatus);
                    parameterObjectpropCount++;
                }

                if (bodyparameterarchive != null)
                {
                    parameterObject["Archive"] = SourceExpressionConverter.ConvertToken(bodyparameterarchive);
                    parameterObjectpropCount++;
                }

                if (bodyparameternotes != null)
                {
                    parameterObject["Notes"] = SourceExpressionConverter.ConvertToken(bodyparameternotes);
                    parameterObjectpropCount++;
                }

                if (bodyparametercontacts != null)
                {
                    parameterObject["Contacts"] = SourceExpressionConverter.ConvertToken(bodyparametercontacts);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "public360")]
        public IBodyWorkflowAction<CreateCaseResponse> CreateCase([WorkflowExpression] Func<string> hosturl, [WorkflowExpression] Func<string> bodyparametertitle = null, [WorkflowExpression] Func<string> bodyparameterdefaultValueSet = null, [WorkflowExpression] Func<string> bodyparameterunofficialTitle = null, [WorkflowExpression] Func<string> bodyparametercaseType = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonEmail = null, [WorkflowExpression] Func<string> bodyparameterresponsiblePersonIdNumber = null, [WorkflowExpression] Func<string> bodyparameterresponsibleEnterpriseNumber = null, [WorkflowExpression] Func<int> bodyparameterprogressPlanId = null, [WorkflowExpression] Func<bodyparameteradditionalFieldsInputItem[]> bodyparameteradditionalFields = null)
        {
            SourceExpression.Validate(hosturl, nameof(hosturl), required: true);
            SourceExpression.Validate(bodyparametertitle, nameof(bodyparametertitle), required: false);
            SourceExpression.Validate(bodyparameterdefaultValueSet, nameof(bodyparameterdefaultValueSet), required: false);
            SourceExpression.Validate(bodyparameterunofficialTitle, nameof(bodyparameterunofficialTitle), required: false);
            SourceExpression.Validate(bodyparametercaseType, nameof(bodyparametercaseType), required: false);
            SourceExpression.Validate(bodyparameterresponsiblePersonEmail, nameof(bodyparameterresponsiblePersonEmail), required: false);
            SourceExpression.Validate(bodyparameterresponsiblePersonIdNumber, nameof(bodyparameterresponsiblePersonIdNumber), required: false);
            SourceExpression.Validate(bodyparameterresponsibleEnterpriseNumber, nameof(bodyparameterresponsibleEnterpriseNumber), required: false);
            SourceExpression.Validate(bodyparameterprogressPlanId, nameof(bodyparameterprogressPlanId), required: false);
            SourceExpression.Validate(bodyparameteradditionalFields, nameof(bodyparameteradditionalFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Biz/v2/api/call/SI.Data.RPC/SI.Data.RPC/CaseService/CreateCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hosturl"] = SourceExpressionConverter.ConvertO(hosturl);
                var body = new JObject();
                var bodypropCount = 0;
                var parameterObject = new JObject();
                var parameterObjectpropCount = 0;
                if (bodyparametertitle != null)
                {
                    parameterObject["Title"] = SourceExpressionConverter.ConvertToken(bodyparametertitle);
                    parameterObjectpropCount++;
                }

                if (bodyparameterdefaultValueSet != null)
                {
                    parameterObject["DefaultValueSet"] = SourceExpressionConverter.ConvertToken(bodyparameterdefaultValueSet);
                    parameterObjectpropCount++;
                }

                if (bodyparameterunofficialTitle != null)
                {
                    parameterObject["UnofficialTitle"] = SourceExpressionConverter.ConvertToken(bodyparameterunofficialTitle);
                    parameterObjectpropCount++;
                }

                if (bodyparametercaseType != null)
                {
                    parameterObject["CaseType"] = SourceExpressionConverter.ConvertToken(bodyparametercaseType);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonEmail != null)
                {
                    parameterObject["ResponsiblePersonEmail"] = SourceExpressionConverter.ConvertToken(bodyparameterresponsiblePersonEmail);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsiblePersonIdNumber != null)
                {
                    parameterObject["ResponsiblePersonIdNumber"] = SourceExpressionConverter.ConvertToken(bodyparameterresponsiblePersonIdNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterresponsibleEnterpriseNumber != null)
                {
                    parameterObject["ResponsibleEnterpriseNumber"] = SourceExpressionConverter.ConvertToken(bodyparameterresponsibleEnterpriseNumber);
                    parameterObjectpropCount++;
                }

                if (bodyparameterprogressPlanId != null)
                {
                    parameterObject["ProgressPlanId"] = SourceExpressionConverter.ConvertToken(bodyparameterprogressPlanId);
                    parameterObjectpropCount++;
                }

                if (bodyparameteradditionalFields != null)
                {
                    parameterObject["AdditionalFields"] = SourceExpressionConverter.ConvertToken(bodyparameteradditionalFields);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateCaseResponse>(BuildSourceInput);
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