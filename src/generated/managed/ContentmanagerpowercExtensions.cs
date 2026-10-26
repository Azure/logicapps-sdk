//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contentmanagerpowerc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContentmanagerpowercActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RecordSearchAdvanced(Expression<Func<string>> q, Expression<Func<string>> properties, Expression<Func<string>> userToImpersonate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FindRecordAdvanced";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                callPayload.Headers["parseResponse"] = Convert.ToString(false);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSearch(Expression<Func<string>> q, Expression<Func<string>> properties, Expression<Func<string>> userToImpersonate = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Record";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> DeleteRecord(Expression<Func<int>> uri, Expression<Func<string>> userToImpersonate = null, Expression<Func<DeleteRecordInput>> deleteRecordDetails = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_deleteRecordDetails = WorkflowExpression.Compile(deleteRecordDetails, nameof(deleteRecordDetails), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DeleteRecord/{0}", __workflow_uri.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_deleteRecordDetails != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteRecordDetails);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSearchById(Expression<Func<string>> id, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> descendantProperties = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_includePropertyDefs = WorkflowExpression.Compile(includePropertyDefs, nameof(includePropertyDefs), required: false);
            var __workflow_descendantProperties = WorkflowExpression.Compile(descendantProperties, nameof(descendantProperties), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertySets = WorkflowExpression.Compile(propertySets, nameof(propertySets), required: false);
            var __workflow_propertyValue = WorkflowExpression.Compile(propertyValue, nameof(propertyValue), required: false);
            var __workflow_stringDisplayType = WorkflowExpression.Compile(stringDisplayType, nameof(stringDisplayType), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Record/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(__workflow_includePropertyDefs);
                if (__workflow_descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(__workflow_descendantProperties);
                callPayload.Queries["properties"] = Convert.ToString("RecordNumber");
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertySets != null)
                    callPayload.Queries["propertySets"] = ExpressionConverter.Convert(__workflow_propertySets);
                if (__workflow_propertyValue != null)
                    callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(__workflow_propertyValue);
                if (__workflow_stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(__workflow_stringDisplayType);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RecordElecDownload(Expression<Func<string>> uri, Expression<Func<string>> userToImpersonate = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordElecDownload";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["uri"] = ExpressionConverter.Convert(__workflow_uri);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordReassignAction(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordReassignActionInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordReassignAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse, ApiConnectionActionConfiguration> RecordClose(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordCloseInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse, ApiConnectionActionConfiguration> RecordReopen(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordReopenInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordReopen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<GetFileFromUrlResponse, ApiConnectionActionConfiguration> GetFileFromUrl(Expression<Func<string>> url, Expression<Func<string>> filename = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<GetFileFromUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetFileFromUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction<GetFileFromUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachAction(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordAttachActionInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordCompleteActions(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordCompleteActionsInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordCompleteActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRemoveAllActions(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordRemoveAllActionsInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRemoveAllActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRescheduleActions(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordRescheduleActionsInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRescheduleActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordDispose(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordDisposeInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordUndispose(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordUndisposeInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordUndispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordCheckout(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordCheckoutInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordUndoCheckout(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordUndoCheckoutInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordUndoCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachContact(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordAttachContactInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachKeyword(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordAttachKeywordInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachKeyword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSetUserLabel(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordSetUserLabelInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordSetUserLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRequestRendition(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordRequestRenditionInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRequestRendition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSetAssignee(Expression<Func<string>> userToImpersonate = null, Expression<Func<RecordSetAssigneeInput>> @record = null)
        {
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordSetAssignee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse, ApiConnectionActionConfiguration> LocationSearch(Expression<Func<string>> q, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> applyDefaults = null, Expression<Func<bool>> countResults = null, Expression<Func<bool>> excludeCount = null, Expression<Func<string>> filter = null, Expression<Func<string>> fromSearch = null, Expression<Func<string>> descendantProperties = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> options = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<string>> pageSize = null, Expression<Func<string>> purpose = null, Expression<Func<string>> purposeExtra = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> start = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_applyDefaults = WorkflowExpression.Compile(applyDefaults, nameof(applyDefaults), required: false);
            var __workflow_countResults = WorkflowExpression.Compile(countResults, nameof(countResults), required: false);
            var __workflow_excludeCount = WorkflowExpression.Compile(excludeCount, nameof(excludeCount), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_fromSearch = WorkflowExpression.Compile(fromSearch, nameof(fromSearch), required: false);
            var __workflow_descendantProperties = WorkflowExpression.Compile(descendantProperties, nameof(descendantProperties), required: false);
            var __workflow_includePropertyDefs = WorkflowExpression.Compile(includePropertyDefs, nameof(includePropertyDefs), required: false);
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertySets = WorkflowExpression.Compile(propertySets, nameof(propertySets), required: false);
            var __workflow_propertyValue = WorkflowExpression.Compile(propertyValue, nameof(propertyValue), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_purpose = WorkflowExpression.Compile(purpose, nameof(purpose), required: false);
            var __workflow_purposeExtra = WorkflowExpression.Compile(purposeExtra, nameof(purposeExtra), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_stringDisplayType = WorkflowExpression.Compile(stringDisplayType, nameof(stringDisplayType), required: false);
            return new DeferredBodyAction<CMLocationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_applyDefaults != null)
                    callPayload.Queries["ApplyDefaults"] = ExpressionConverter.Convert(__workflow_applyDefaults);
                if (__workflow_countResults != null)
                    callPayload.Queries["CountResults"] = ExpressionConverter.Convert(__workflow_countResults);
                if (__workflow_excludeCount != null)
                    callPayload.Queries["ExcludeCount"] = ExpressionConverter.Convert(__workflow_excludeCount);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_fromSearch != null)
                    callPayload.Queries["fromSearch"] = ExpressionConverter.Convert(__workflow_fromSearch);
                if (__workflow_descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(__workflow_descendantProperties);
                if (__workflow_includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(__workflow_includePropertyDefs);
                if (__workflow_options != null)
                    callPayload.Queries["Options"] = ExpressionConverter.Convert(__workflow_options);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertySets != null)
                    callPayload.Queries["propertySets"] = ExpressionConverter.Convert(__workflow_propertySets);
                if (__workflow_propertyValue != null)
                    callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(__workflow_propertyValue);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_purpose != null)
                    callPayload.Queries["purpose"] = ExpressionConverter.Convert(__workflow_purpose);
                if (__workflow_purposeExtra != null)
                    callPayload.Queries["purposeExtra"] = ExpressionConverter.Convert(__workflow_purposeExtra);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(__workflow_stringDisplayType);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<CMLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse, ApiConnectionActionConfiguration> LocationSearchById(Expression<Func<string>> id, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> descendantProperties = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_descendantProperties = WorkflowExpression.Compile(descendantProperties, nameof(descendantProperties), required: false);
            var __workflow_includePropertyDefs = WorkflowExpression.Compile(includePropertyDefs, nameof(includePropertyDefs), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_propertySets = WorkflowExpression.Compile(propertySets, nameof(propertySets), required: false);
            var __workflow_propertyValue = WorkflowExpression.Compile(propertyValue, nameof(propertyValue), required: false);
            var __workflow_stringDisplayType = WorkflowExpression.Compile(stringDisplayType, nameof(stringDisplayType), required: false);
            return new DeferredBodyAction<CMLocationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(__workflow_descendantProperties);
                if (__workflow_includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(__workflow_includePropertyDefs);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_propertySets != null)
                    callPayload.Queries["propertySets"] = ExpressionConverter.Convert(__workflow_propertySets);
                if (__workflow_propertyValue != null)
                    callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(__workflow_propertyValue);
                if (__workflow_stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(__workflow_stringDisplayType);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<CMLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationAddressUri, ApiConnectionActionConfiguration> FindLocationChildAddressUri(Expression<Func<string>> locationUri, Expression<Func<typeInput>> type = null, Expression<Func<string>> userToImpersonate = null)
        {
            var __workflow_locationUri = WorkflowExpression.Compile(locationUri, nameof(locationUri), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            return new DeferredBodyAction<CMLocationAddressUri, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FindLocationChildAddressUri/{0}", __workflow_locationUri.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                return new ApiConnectionAction<CMLocationAddressUri>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMEventData, ApiConnectionActionConfiguration> ReadEventData(Expression<Func<ReadEventDataInput>> rawEventData = null)
        {
            var __workflow_rawEventData = WorkflowExpression.Compile(rawEventData, nameof(rawEventData), required: false);
            return new DeferredBodyAction<CMEventData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ReadEventData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_rawEventData != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_rawEventData);
                return new ApiConnectionAction<CMEventData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> AddAccessControl(Expression<Func<AddAccessControlInput>> @record = null)
        {
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RemoveAccessControl(Expression<Func<RemoveAccessControlInput>> @record = null)
        {
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RemoveAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> SetAccessControl(Expression<Func<SetAccessControlInput>> @record = null)
        {
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SetAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> InheritAccessControl(Expression<Func<InheritAccessControlInput>> @record = null)
        {
            var __workflow_record = WorkflowExpression.Compile(@record, nameof(@record), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InheritAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_record != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_record);
                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }
    }

    public class ContentmanagerpowercTriggers([ConnectionName] string connectionId)
    {
    }

    public class CMRecordsResponse
    {
        public CMRecord[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMRecord
    {
        [JsonProperty("RecordFilePath")]
        public string FilePath { get; set; }

        [JsonProperty("RecordAccessionNumber")]
        public int AccessionNumber { get; set; }

        [JsonProperty("RecordAddressee")]
        public int Addressee { get; set; }

        [JsonProperty("RecordAlternativeContainer")]
        public int AlternativeContainer { get; set; }

        [JsonProperty("RecordAssignee")]
        public int Assignee { get; set; }

        [JsonProperty("RecordAuthor")]
        public int Author { get; set; }

        [JsonProperty("RecordAuthorizationMethod")]
        public CMRecordAuthorizationMethodType AuthorizationMethod { get; set; }

        [JsonProperty("RecordAutoClassificationConfidenceLevel")]
        public int AutoClassificationConfidenceLevel { get; set; }

        [JsonProperty("RecordAutoRenderToPDFOnSave")]
        public bool AutoRenderToPDFOnSave { get; set; }

        [JsonProperty("RecordBlueprintTitle")]
        public string BluePrintTitle { get; set; }

        [JsonProperty("RecordBypassRecordTypeAccessControls")]
        public bool BypassRecordTypeAccessControls { get; set; }

        [JsonProperty("RecordCheckedInBy")]
        public int CheckedInBy { get; set; }

        [JsonProperty("RecordCheckedOutTo")]
        public int CheckedOutTo { get; set; }

        [JsonProperty("RecordClassification")]
        public int Classification { get; set; }

        [JsonProperty("RecordClassOfRecord")]
        public CMRecordClassOfRecordType ClassOfRecord { get; set; }

        [JsonProperty("RecordClient")]
        public int Client { get; set; }

        [JsonProperty("RecordClientRecord")]
        public int ClientRecord { get; set; }

        [JsonProperty("RecordConsignment")]
        public string Consignment { get; set; }

        [JsonProperty("RecordConsignmentObject")]
        public string ConsignmentObject { get; set; }

        [JsonProperty("RecordContainer")]
        public int Container { get; set; }

        [JsonProperty("RecordCreator")]
        public int Creator { get; set; }

        [JsonProperty("RecordCurrentVersion")]
        public string CurrentVersion { get; set; }

        [JsonProperty("RecordDateClosed")]
        public string DateClosed { get; set; }

        [JsonProperty("RecordDateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("RecordDateDue")]
        public string DateDue { get; set; }

        [JsonProperty("RecordDateFinalized")]
        public string DateFinalized { get; set; }

        [JsonProperty("RecordDateImported")]
        public string DateImported { get; set; }

        [JsonProperty("RecordDateInactive")]
        public string DateInactive { get; set; }

        [JsonProperty("RecordDateModified")]
        public string DateModified { get; set; }

        [JsonProperty("RecordDatePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("RecordDateReceived")]
        public string DateReceived { get; set; }

        [JsonProperty("RecordDateRegistered")]
        public string DateRegistered { get; set; }

        [JsonProperty("RecordDocumentAttachPending")]
        public bool DocumentAttachPending { get; set; }

        [JsonProperty("RecordDocumentSize")]
        public int DocumentSize { get; set; }

        [JsonProperty("RecordDocumentType")]
        public string DocumentType { get; set; }

        [JsonProperty("RecordEditor")]
        public int Editor { get; set; }

        [JsonProperty("RecordEStore")]
        public int ElectronicDocumentStore { get; set; }

        [JsonProperty("RecordExtension")]
        public string DocumentExtension { get; set; }

        [JsonProperty("RecordExternalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty("RecordFinalizeOnSave")]
        public bool FinalizeOnSave { get; set; }

        [JsonProperty("RecordFolderOrigin")]
        public int FolderOrigin { get; set; }

        [JsonProperty("RecordForeignBarcode")]
        public string ForeignBarcode { get; set; }

        [JsonProperty("RecordGeneratedTitle")]
        public string GeneratedTitle { get; set; }

        [JsonProperty("RecordGpsLocation")]
        public string GPSLocation { get; set; }

        [JsonProperty("RecordHomeLocation")]
        public int HomeLocation { get; set; }

        [JsonProperty("RecordHomeSpace")]
        public int HomeSpace { get; set; }

        [JsonProperty("RecordInitiateTemplate")]
        public string InitiateTemplate { get; set; }

        [JsonProperty("RecordIsEnclosed")]
        public bool IsEnclosed { get; set; }

        [JsonProperty("RecordJurisdictions")]
        public string Jurisdiction { get; set; }

        [JsonProperty("RecordLastActionDate")]
        public string LastActionDate { get; set; }

        [JsonProperty("RecordLastPartRecord")]
        public int LastPartRecord { get; set; }

        [JsonProperty("RecordLatestVersion")]
        public int LatestVersion { get; set; }

        [JsonProperty("RecordLongNumber")]
        public string ExpandedNumber { get; set; }
        public string RecordNumber { get; set; }

        [JsonProperty("RecordManualDestructionDate")]
        public string ManualDestructionDate { get; set; }

        [JsonProperty("RecordMatterRecord")]
        public int MatterRecord { get; set; }

        [JsonProperty("RecordMediaType")]
        public string MediaType { get; set; }

        [JsonProperty("RecordMeeting")]
        public int Meeting { get; set; }

        [JsonProperty("RecordMimeType")]
        public string MimeType { get; set; }

        [JsonProperty("RecordMyAuthorizationComments")]
        public string MyAuthorizationComments { get; set; }

        [JsonProperty("RecordMyAuthorizationComplete")]
        public bool MyAuthorizationComplete { get; set; }

        [JsonProperty("RecordMyReviewComments")]
        public string MyReviewComments { get; set; }

        [JsonProperty("RecordMyReviewComplete")]
        public bool MyReviewComplete { get; set; }

        [JsonProperty("RecordNbrPages")]
        public int NumberPages { get; set; }

        [JsonProperty("RecordNeedsAuthorization")]
        public bool NeedsAuthorization { get; set; }

        [JsonProperty("RecordNeedsReview")]
        public bool NeedsReview { get; set; }

        [JsonProperty("RecordNewPartCreationRule")]
        public string NewPartCreationRule { get; set; }

        [JsonProperty("RecordNextPartRecord")]
        public int NextPartRecord { get; set; }
        public CMRecordNotesUpdateTypeType NotesUpdateType { get; set; }

        [JsonProperty("RecordNotes")]
        public string Notes { get; set; }

        [JsonProperty("RecordOriginatedFrom")]
        public string OriginatedFrom { get; set; }

        [JsonProperty("RecordOriginatedFromRun")]
        public string OriginatedFromRun { get; set; }

        [JsonProperty("RecordOtherContact")]
        public int OtherContact { get; set; }

        [JsonProperty("RecordOwnerLocation")]
        public int OwnerLocation { get; set; }

        [JsonProperty("RecordPreserveHierarchyOnDataEntry")]
        public bool PreserverHierarchyOnDataEntry { get; set; }

        [JsonProperty("RecordPrevPartRecord")]
        public int PreviousPartRecord { get; set; }

        [JsonProperty("RecordPrimaryContact")]
        public int PrimaryContact { get; set; }

        [JsonProperty("RecordPriority")]
        public string Priority { get; set; }

        [JsonProperty("RecordRecordType")]
        public int RecordType { get; set; }

        [JsonProperty("RecordRelatedRecord")]
        public int RelatedRecord { get; set; }

        [JsonProperty("RecordRepresentative")]
        public int Representative { get; set; }

        [JsonProperty("RecordRetentionSchedule")]
        public int RetentionSchedule { get; set; }

        [JsonProperty("RecordReviewDate")]
        public string ReviewDate { get; set; }

        [JsonProperty("RecordReviewDueDate")]
        public string ReviewDueDate { get; set; }

        [JsonProperty("RecordReviewState")]
        public string ReviewState { get; set; }

        [JsonProperty("RecordRootPartRecord")]
        public int RootPartRecord { get; set; }

        [JsonProperty("RecordSecurity")]
        public string Security { get; set; }

        [JsonProperty("RecordSeriesRecord")]
        public int SeriesRecord { get; set; }

        [JsonProperty("RecordTitle")]
        public string Title { get; set; }

        [JsonProperty("RecordTypedTitle")]
        public string TitleFreeTextPart { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }

        [JsonProperty("Fields")]
        public JToken AdditionalFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CMRecordAuthorizationMethodType
    {
        Simple,
        Challenge,
        Docusign
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CMRecordClassOfRecordType
    {
        Vital,
        Corporate,
        WorkGroup,
        Personal,
        Reference,
        Temporary
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CMRecordNotesUpdateTypeType
    {
        Overwrite,
        AppendOnly,
        AppendWithNewLine,
        AppendWithUserStamp,
        PrependOnly,
        PrependWithNewLine,
        PrependWithUserStamp
    }

    public class CMUpdateErrorResponse
    {
        public string ErrorCode { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string NameExtra { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CMTrimType
    {
        Record,
        Location,
        Classification,
        ActionDef,
        ActionDefStep,
        Activity,
        ActivityAuthorization,
        ActivityDocument,
        ActivityEmailRecipient,
        ActivityEscalation,
        ActivityResult,
        ActivityStartCondition,
        AgendaItem,
        AgendaItemAttachment,
        AgendaItemType,
        AgendaItemTypeAttachment,
        Alert,
        AlertSubscriber,
        ArchiveEvent,
        ArchiveEventOccurrence,
        AutoPartRule,
        Census,
        CheckinPlace,
        CheckinStyle,
        ClassificationOnlyRecordType,
        [EnumMember(Value = "ClassificationSapBusinessObject")]
        ClassificationSAPBusinessObject,
        Communication,
        CommunicationDetail,
        Consignment,
        ConsignmentApprover,
        ConsignmentIssue,
        ConsignmentRejection,
        Database,
        DocumentQueue,
        ElectronicStore,
        FieldDefinition,
        History,
        Hold,
        HtmlLayout,
        Jurisdiction,
        JurisdictionMember,
        [EnumMember(Value = "Keyword")]
        ThesaurusTerm,
        LocationAddress,
        LocationEAddress,
        LookupItem,
        LookupSet,
        MailTemplate,
        Meeting,
        MeetingDocument,
        MeetingInvitation,
        MeetingType,
        MeetingTypeUsualParticipant,
        MetadataRule,
        MinuteItem,
        MinuteItemActionArising,
        MinuteItemType,
        Notification,
        OfflineRecord,
        Origin,
        OriginHistory,
        RecordAction,
        RecordClientMatterParty,
        RecordClientMatterRole,
        RecordHold,
        RecordJurisdiction,
        [EnumMember(Value = "RecordKeyword")]
        RecordThesaurusTerm,
        RecordLinkedDocument,
        RecordLocation,
        RecordRelationship,
        RecordRendition,
        RecordRevision,
        [EnumMember(Value = "RecordSapComponent")]
        RecordSAPComponent,
        RecordType,
        RecordTypeAutoSubFolder,
        Report,
        ReportBitmap,
        Request,
        SavedSearch,
        Schedule,
        ScheduledTask,
        ScheduledTaskHistory,
        ScheduleTrigger,
        SearchForm,
        SecurityCaveat,
        SecurityGuide,
        SecurityLevel,
        SharePointItem,
        Space,
        StopWord,
        TodoItem,
        TodoItemItemReference,
        Unknown,
        UserLabel,
        Word,
        Workflow,
        WorkflowDocument,
        WorkflowTemplate,
        WorkflowTemplateDocument,
        WorkingCopy,
        ZipCode
    }

    public class CMResponseStatus
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public CMResponseError[] Errors { get; set; }
        public JToken Meta { get; set; }
    }

    public class CMResponseError
    {
        public string ErrorCode { get; set; }
        public string FieldName { get; set; }
        public string Message { get; set; }
        public JToken Meta { get; set; }
    }

    public class DeleteRecordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DeleteContents { get; set; } = false;
        public string NewHomeForContents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum propertyValueInput
    {
        Raw,
        String,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum stringDisplayTypeInput
    {
        Default,
        DataEntry,
        ErrorMessage,
        Export,
        Merge,
        Reporter,
        TreeColumn,
        ViewPane,
        WebPublish,
        WebService
    }

    public class RecordReassignActionInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewAssignee { get; set; }

        [JsonProperty("RecordActionUri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ActionToReassign { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class CMLogResponse
    {
        public CMLogMessage[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMLogMessage
    {
        public string LogMessage { get; set; }
        public CMTrimType TrimType { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }
    }

    public class RecordCloseInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ContinueOnError { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EncloseContents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FinalizeContents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogErrorsOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogResults { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PurgeContentRevisions { get; set; } = true;
        public string SpecificCloseDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordReopenInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ContinueOnError { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogResults { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UnfinalizeContents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class GetFileFromUrlResponse
    {
        public string Filepath { get; set; }
        public string Message { get; set; }
    }

    public class RecordAttachActionInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ActionToAttach { get; set; }

        [JsonProperty("NewAssignee")]
        public int? AssigneeUniqueId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordAttachActionInputAssigneeOptionType? AssigneeOption { get; set; } = RecordAttachActionInputAssigneeOptionType.OverrideExisting;
        public string ScheduleStartDate { get; set; }

        [JsonProperty("RecordAction")]
        public int? ExistingAction { get; set; }

        [JsonProperty("InsertPos", DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordAttachActionInputInsertPositionType? InsertPosition { get; set; } = RecordAttachActionInputInsertPositionType.After;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordAttachActionInputAssigneeOptionType
    {
        OverrideExisting,
        OnlyIfNoneSpecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordAttachActionInputInsertPositionType
    {
        Before,
        After
    }

    public class RecordCompleteActionsInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordCompleteActionsInputCompleteType Complete { get; set; }

        [JsonProperty("CompletePrevious", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CompletePreviousActions { get; set; } = false;
        public string CompletionDate { get; set; }

        [JsonProperty("RecordActionUri")]
        public int? RecordActionUniqueId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordCompleteActionsInputCompleteType
    {
        Current,
        All,
        [EnumMember(Value = "ForUri")]
        ForUniqueIdentifier
    }

    public class RecordRemoveAllActionsInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordRescheduleActionsInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public string FromBaseDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseActualDurations { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordDisposeInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ContinueOnError { get; set; } = false;
        public RecordDisposeInputMethodOfDisposalType? MethodOfDisposal { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordDisposeInputMethodOfDisposalType
    {
        None,
        Archived,
        Transferred,
        Destroyed
    }

    public class RecordUndisposeInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ContinueOnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordCheckoutInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public string Comments { get; set; }
        public string SaveCheckoutPathAs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordUndoCheckoutInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public string Comments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordAttachContactInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactLocation { get; set; }

        [JsonProperty("IsPrimary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SetAsPrimaryContact { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordAttachKeywordInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Record { get; set; }

        [JsonProperty("Keyword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ThesaurusTerm { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordSetUserLabelInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Record { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserLabel { get; set; }
        public string FavouriteType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordRequestRenditionInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RenditionType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    public class RecordSetAssigneeInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public string NewAssignee { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RecordSetAssigneeInputAssigneeTypeType? AssigneeType { get; set; } = RecordSetAssigneeInputAssigneeTypeType.AtLocation;
        public string DueForReturnByDate { get; set; }
        public string ActualTimeChangeOccurred { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Properties { get; set; } = "RecordTitle, RecordNumber";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecordSetAssigneeInputAssigneeTypeType
    {
        AtLocation,
        AtHome,
        Missing,
        EarliestRequestor
    }

    public class CMLocationsResponse
    {
        public CMLocation[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMLocation
    {
        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }

        [JsonProperty("NameString")]
        public string Name { get; set; }
        public string LocationFullFormattedName { get; set; }
        public string LocationSortName { get; set; }
    }

    public class CMLocationAddressUri
    {
        [JsonProperty("Uri")]
        public int UniqueId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        Street,
        [EnumMember(Value = "Postal")]
        Mailing
    }

    public class CMEventData
    {
        [JsonProperty("OnlineEventUri")]
        public int EventUniqueIdentifier { get; set; }

        [JsonProperty("EventType")]
        public int EventTypeId { get; set; }

        [JsonProperty("EventTypeString")]
        public string EventType { get; set; }
        public string EventDate { get; set; }

        [JsonProperty("ObjectType")]
        public int ObjectTypeId { get; set; }

        [JsonProperty("ObjectTypeString")]
        public string ObjectType { get; set; }

        [JsonProperty("ObjectUri")]
        public int ObjectUniqueId { get; set; }

        [JsonProperty("RelatedObjectType")]
        public int RelatedObjectTypeId { get; set; }

        [JsonProperty("RelatedObjectTypeString")]
        public string RelatedObjectType { get; set; }

        [JsonProperty("RelatedObjectUri")]
        public int RelatedObjectUniqueId { get; set; }
        public string FromMachine { get; set; }
        public string ConnectionIPAddress { get; set; }
        public string ClientIPAddress { get; set; }
        public int FromTimeZone { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("LoginUri")]
        public int LoginUniqueId { get; set; }
        public string ExtraDetails { get; set; }
    }

    public class ReadEventDataInput
    {
        public string Content { get; set; }
    }

    public class AddAccessControlInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public AccessControlList AccessControlList { get; set; }
    }

    public class AccessControlList
    {
        public string FunctionEnum { get; set; }
        public FunctionProfiles FunctionProfiles { get; set; }
    }

    public class FunctionProfiles
    {
        public ViewDocumentInfo ViewDocument { get; set; }
        public ViewRecord ViewRecord { get; set; }
        public UpdateDocumentInfo UpdateDocument { get; set; }
        public UpdateMetadata UpdateMetadata { get; set; }
        public ModifyAccess ModifyAccess { get; set; }
        public DestroyRecordInfo DestroyRecord { get; set; }
        public AddContents AddContents { get; set; }
    }

    public class ViewDocumentInfo
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] ViewDocument { get; set; }
    }

    public class AccessLocationsItem
    {
        [JsonProperty("Uri")]
        public int UniqueId { get; set; }
    }

    public class ViewRecord
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] ViewMetadata { get; set; }
    }

    public class UpdateDocumentInfo
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] UpdateDocument { get; set; }
    }

    public class UpdateMetadata
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] UpdateRecordMetadata { get; set; }
    }

    public class ModifyAccess
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] ModifyRecordAccess { get; set; }
    }

    public class DestroyRecordInfo
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] DestroyRecord { get; set; }
    }

    public class AddContents
    {
        [JsonProperty("AccessLocations")]
        public AccessLocationsItem[] ContributeContents { get; set; }
    }

    public class RemoveAccessControlInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public AccessControlList AccessControlList { get; set; }
    }

    public class SetAccessControlInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public AccessControlList AccessControlList { get; set; }
    }

    public class InheritAccessControlInput
    {
        [JsonProperty("Uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UniqueIdentifier { get; set; }
        public AccessControlList AccessControlList { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Contentmanagerpowerc;

    public partial class WorkflowManagedActions
    {
        public ContentmanagerpowercActions Contentmanagerpowerc(string connectionId) => new ContentmanagerpowercActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContentmanagerpowercTriggers Contentmanagerpowerc(string connectionId) => new ContentmanagerpowercTriggers(connectionId);
    }
}