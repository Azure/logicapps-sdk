//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognizantautomationc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognizantautomationcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ActivityActionStatusResponse> ActivityActionStatus(Expression<Func<int>> activityID, Expression<Func<int>> activityActionID)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}/actions/{1}", ExpressionConverter.ConvertWithUrlEncoding(activityID, 1), ExpressionConverter.ConvertWithUrlEncoding(activityActionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("ExecutedActionView");
            return new ApiConnectionAction<ActivityActionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerActionResponse> TriggerAction(Expression<Func<string>> activityId, Expression<Func<int>> bodyactionId, Expression<Func<int>> bodyactivityId, Expression<Func<string>> bodycIId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("TriggerActionExternal");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ActionId"] = ExpressionConverter.ConvertO(bodyactionId);
            bodypropCount++;
            body["ActivityId"] = ExpressionConverter.ConvertO(bodyactivityId);
            bodypropCount++;
            body["CIId"] = ExpressionConverter.ConvertO(bodycIId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<ReadActivityAttributeResponse> ReadActivityAttribute(Expression<Func<string>> activityId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}/attributes", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("ReadAttributes");
            return new ApiConnectionAction<ReadActivityAttributeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<SetActivityAdditionalAttributeResponse> SetActivityAdditionalAttribute(Expression<Func<string>> activityId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}/attributes", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("InsertUpdate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetActivityAdditionalAttributeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<FetchISExecutionStatusResponse> FetchISExecutionStatus(Expression<Func<string>> activityId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("TriggerIsStatusApi");
            return new ApiConnectionAction<FetchISExecutionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<TriggerISResponse> TriggerIS(Expression<Func<string>> activityId, Expression<Func<string>> bodyskillId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("TriggerIS");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["SkillId"] = ExpressionConverter.ConvertO(bodyskillId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TriggerISResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<UpdateActionOutputResponse> UpdateActionOutput(Expression<Func<string>> activityActionId, Expression<Func<string>> bodyoutput, Expression<Func<bodyexecutionStatusInput>> bodyexecutionStatus = null)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activityaction/{0}", ExpressionConverter.ConvertWithUrlEncoding(activityActionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["output"] = ExpressionConverter.ConvertO(bodyoutput);
            if (bodyexecutionStatus != null)
            {
                body["ActionExecutionStatus"] = ExpressionConverter.ConvertO(bodyexecutionStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateActionOutputResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<LinkAsChildActivityResponse> LinkAsChildActivity(Expression<Func<string>> activityId, Expression<Func<int>> bodychildId)
        {
            var apiCallPath = String.Format("/portal/ino/api/v3/collab/activity/{0}/v1/link", ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("AddChild");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ChildId"] = ExpressionConverter.ConvertO(bodychildId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkAsChildActivityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateActivityResponse> CreateActivity(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription, Expression<Func<string>> bodycIId, Expression<Func<string>> bodycustomerId, Expression<Func<string>> bodyrunId = null, Expression<Func<string>> bodyworkflowRunURL = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyassignmentGroup = null)
        {
            var apiCallPath = "/portal/ino/api/v3/collab/activity";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrunId != null)
            {
                body["pa_run_id"] = ExpressionConverter.ConvertO(bodyrunId);
                bodypropCount++;
            }

            if (bodyworkflowRunURL != null)
            {
                body["pa_run_name"] = ExpressionConverter.ConvertO(bodyworkflowRunURL);
                bodypropCount++;
            }

            body["SourceId"] = 11;
            bodypropCount++;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["Description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["CIId"] = ExpressionConverter.ConvertO(bodycIId);
            if (bodyuserId != null)
            {
                body["OwnerId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyassignmentGroup != null)
            {
                body["AssignmentGroup"] = ExpressionConverter.ConvertO(bodyassignmentGroup);
                bodypropCount++;
            }

            bodypropCount++;
            body["CustomerId"] = ExpressionConverter.ConvertO(bodycustomerId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateActivityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognizantautomationc")]
        public IBodyWorkflowAction<CreateaActivityLogResponse> CreateaActivityLog(Expression<Func<int>> bodyactivityId, Expression<Func<string>> bodylogMessage, Expression<Func<int>> bodyuserId)
        {
            var apiCallPath = "/portal/ino/api/v3/collab/activity/0/logs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ttype"] = Convert.ToString("NewRecord");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ActivityId"] = ExpressionConverter.ConvertO(bodyactivityId);
            bodypropCount++;
            body["Comment"] = ExpressionConverter.ConvertO(bodylogMessage);
            bodypropCount++;
            body["CreatedById"] = ExpressionConverter.ConvertO(bodyuserId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateaActivityLogResponse>(callPayload);
        }
    }

    public class CognizantautomationcTriggers([ConnectionName] string connectionId)
    {
    }

    public class ActivityActionStatusResponse
    {
        public bool Success { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public ActivityActionStatusResponseDataTypeItem[] Data { get; set; }
        public int TotalCount { get; set; }
        public JToken[] ColumnMapping { get; set; }
        public JToken[] DateColumn { get; set; }
        public JToken[] ComboBox { get; set; }
        public JToken[] ComboSelect { get; set; }
        public string TransactionKey { get; set; }
    }

    public class ActivityActionStatusResponseDataTypeItem
    {
        public string Status { get; set; }

        [JsonProperty("Automation Status")]
        public string AutomationStatus { get; set; }

        [JsonProperty("Status Id")]
        public int StatusId { get; set; }

        [JsonProperty("Automation Status Id")]
        public int AutomationStatusId { get; set; }

        [JsonProperty("Output Status Id")]
        public int OutputStatusId { get; set; }
    }

    public class TriggerActionResponse
    {
        public int ActivityActionId { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class ReadActivityAttributeResponse
    {
        public bool Success { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public ReadActivityAttributeResponseDataTypeItem[] Data { get; set; }
    }

    public class ReadActivityAttributeResponseDataTypeItem
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
    }

    public class SetActivityAdditionalAttributeResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class FetchISExecutionStatusResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public JToken[] DateTZConversionColumn { get; set; }
        public FetchISExecutionStatusResponseDataTypeItem[] Data { get; set; }
        public int TotalCount { get; set; }
        public JToken[] ColumnMapping { get; set; }
        public JToken[] ComboBox { get; set; }
        public JToken[] ComboSelect { get; set; }
        public JToken[] DateColumn { get; set; }
        public string TransactionKey { get; set; }
    }

    public class FetchISExecutionStatusResponseDataTypeItem
    {
        public int Id { get; set; }
        public string IntelligentSequenceStatusId { get; set; }
    }

    public class TriggerISResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class UpdateActionOutputResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public enum bodyexecutionStatusInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class LinkAsChildActivityResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateActivityResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }

    public class CreateaActivityLogResponse
    {
        public bool Success { get; set; }
        public string Msg { get; set; }
        public string TransactionKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognizantautomationc;

    public partial class WorkflowManagedActions
    {
        public CognizantautomationcActions Cognizantautomationc(string connectionId) => new CognizantautomationcActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognizantautomationcTriggers Cognizantautomationc(string connectionId) => new CognizantautomationcTriggers(connectionId);
    }
}