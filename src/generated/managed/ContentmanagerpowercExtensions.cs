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
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> DeleteRecord(Expression<Func<int>> uri, Expression<Func<bool>> deleteRecordDetailsdeleteContents, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> deleteRecordDetailsnewHomeForContents = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_deleteRecordDetailsdeleteContents = WorkflowExpression.Compile(deleteRecordDetailsdeleteContents, nameof(deleteRecordDetailsdeleteContents), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_deleteRecordDetailsnewHomeForContents = WorkflowExpression.Compile(deleteRecordDetailsnewHomeForContents, nameof(deleteRecordDetailsnewHomeForContents), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DeleteRecord/{0}", __workflow_uri.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var deleteRecordDetails = new JObject();
                var deleteRecordDetailspropCount = 0;
                deleteRecordDetailspropCount++;
                deleteRecordDetails["DeleteContents"] = ExpressionConverter.ConvertO(__workflow_deleteRecordDetailsdeleteContents);
                if (__workflow_deleteRecordDetailsnewHomeForContents != null)
                {
                    deleteRecordDetails["NewHomeForContents"] = ExpressionConverter.ConvertO(__workflow_deleteRecordDetailsnewHomeForContents);
                    deleteRecordDetailspropCount++;
                }

                if (deleteRecordDetailspropCount > 0)
                {
                    callPayload.Body = deleteRecordDetails;
                }

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
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordReassignAction(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordnewAssignee, Expression<Func<int>> recordactionToReassign, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordnewAssignee = WorkflowExpression.Compile(recordnewAssignee, nameof(recordnewAssignee), required: true);
            var __workflow_recordactionToReassign = WorkflowExpression.Compile(recordactionToReassign, nameof(recordactionToReassign), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordReassignAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                @recordpropCount++;
                @record["NewAssignee"] = ExpressionConverter.ConvertO(__workflow_recordnewAssignee);
                @recordpropCount++;
                @record["RecordActionUri"] = ExpressionConverter.ConvertO(__workflow_recordactionToReassign);
                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse, ApiConnectionActionConfiguration> RecordClose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<bool>> recordencloseContents = null, Expression<Func<bool>> recordfinalizeContents = null, Expression<Func<bool>> recordlogErrorsOnly = null, Expression<Func<bool>> recordlogResults = null, Expression<Func<bool>> recordpurgeContentRevisions = null, Expression<Func<string>> recordspecificCloseDate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcontinueOnError = WorkflowExpression.Compile(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            var __workflow_recordencloseContents = WorkflowExpression.Compile(recordencloseContents, nameof(recordencloseContents), required: false);
            var __workflow_recordfinalizeContents = WorkflowExpression.Compile(recordfinalizeContents, nameof(recordfinalizeContents), required: false);
            var __workflow_recordlogErrorsOnly = WorkflowExpression.Compile(recordlogErrorsOnly, nameof(recordlogErrorsOnly), required: false);
            var __workflow_recordlogResults = WorkflowExpression.Compile(recordlogResults, nameof(recordlogResults), required: false);
            var __workflow_recordpurgeContentRevisions = WorkflowExpression.Compile(recordpurgeContentRevisions, nameof(recordpurgeContentRevisions), required: false);
            var __workflow_recordspecificCloseDate = WorkflowExpression.Compile(recordspecificCloseDate, nameof(recordspecificCloseDate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcontinueOnError != null)
                {
                    if (__workflow_recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = ExpressionConverter.ConvertO(__workflow_recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordencloseContents != null)
                {
                    if (__workflow_recordencloseContents != null)
                    {
                        @record["EncloseContents"] = ExpressionConverter.ConvertO(__workflow_recordencloseContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["EncloseContents"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordfinalizeContents != null)
                {
                    if (__workflow_recordfinalizeContents != null)
                    {
                        @record["FinalizeContents"] = ExpressionConverter.ConvertO(__workflow_recordfinalizeContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["FinalizeContents"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordlogErrorsOnly != null)
                {
                    if (__workflow_recordlogErrorsOnly != null)
                    {
                        @record["LogErrorsOnly"] = ExpressionConverter.ConvertO(__workflow_recordlogErrorsOnly);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogErrorsOnly"] = false;
                    @recordpropCount++;
                }

                if (__workflow_recordlogResults != null)
                {
                    if (__workflow_recordlogResults != null)
                    {
                        @record["LogResults"] = ExpressionConverter.ConvertO(__workflow_recordlogResults);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogResults"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordpurgeContentRevisions != null)
                {
                    if (__workflow_recordpurgeContentRevisions != null)
                    {
                        @record["PurgeContentRevisions"] = ExpressionConverter.ConvertO(__workflow_recordpurgeContentRevisions);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["PurgeContentRevisions"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordspecificCloseDate != null)
                {
                    @record["SpecificCloseDate"] = ExpressionConverter.ConvertO(__workflow_recordspecificCloseDate);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse, ApiConnectionActionConfiguration> RecordReopen(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<bool>> recordlogResults = null, Expression<Func<bool>> recordunfinalizeContents = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcontinueOnError = WorkflowExpression.Compile(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            var __workflow_recordlogResults = WorkflowExpression.Compile(recordlogResults, nameof(recordlogResults), required: false);
            var __workflow_recordunfinalizeContents = WorkflowExpression.Compile(recordunfinalizeContents, nameof(recordunfinalizeContents), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordReopen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcontinueOnError != null)
                {
                    if (__workflow_recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = ExpressionConverter.ConvertO(__workflow_recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordlogResults != null)
                {
                    if (__workflow_recordlogResults != null)
                    {
                        @record["LogResults"] = ExpressionConverter.ConvertO(__workflow_recordlogResults);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogResults"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordunfinalizeContents != null)
                {
                    if (__workflow_recordunfinalizeContents != null)
                    {
                        @record["UnfinalizeContents"] = ExpressionConverter.ConvertO(__workflow_recordunfinalizeContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["UnfinalizeContents"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

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
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachAction(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<int>> recordactionToAttach, Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> recordassigneeUniqueId = null, Expression<Func<recordassigneeOptionInput>> recordassigneeOption = null, Expression<Func<string>> recordscheduleStartDate = null, Expression<Func<int>> recordexistingAction = null, Expression<Func<recordinsertPositionInput>> recordinsertPosition = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordactionToAttach = WorkflowExpression.Compile(recordactionToAttach, nameof(recordactionToAttach), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordassigneeUniqueId = WorkflowExpression.Compile(recordassigneeUniqueId, nameof(recordassigneeUniqueId), required: false);
            var __workflow_recordassigneeOption = WorkflowExpression.Compile(recordassigneeOption, nameof(recordassigneeOption), required: false);
            var __workflow_recordscheduleStartDate = WorkflowExpression.Compile(recordscheduleStartDate, nameof(recordscheduleStartDate), required: false);
            var __workflow_recordexistingAction = WorkflowExpression.Compile(recordexistingAction, nameof(recordexistingAction), required: false);
            var __workflow_recordinsertPosition = WorkflowExpression.Compile(recordinsertPosition, nameof(recordinsertPosition), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                @recordpropCount++;
                @record["ActionToAttach"] = ExpressionConverter.ConvertO(__workflow_recordactionToAttach);
                if (__workflow_recordassigneeUniqueId != null)
                {
                    @record["NewAssignee"] = ExpressionConverter.ConvertO(__workflow_recordassigneeUniqueId);
                    @recordpropCount++;
                }

                if (__workflow_recordassigneeOption != null)
                {
                    if (__workflow_recordassigneeOption != null)
                    {
                        @record["AssigneeOption"] = ExpressionConverter.ConvertO(__workflow_recordassigneeOption);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["AssigneeOption"] = "OverrideExisting";
                    @recordpropCount++;
                }

                if (__workflow_recordscheduleStartDate != null)
                {
                    @record["ScheduleStartDate"] = ExpressionConverter.ConvertO(__workflow_recordscheduleStartDate);
                    @recordpropCount++;
                }

                if (__workflow_recordexistingAction != null)
                {
                    @record["RecordAction"] = ExpressionConverter.ConvertO(__workflow_recordexistingAction);
                    @recordpropCount++;
                }

                if (__workflow_recordinsertPosition != null)
                {
                    if (__workflow_recordinsertPosition != null)
                    {
                        @record["InsertPos"] = ExpressionConverter.ConvertO(__workflow_recordinsertPosition);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["InsertPos"] = "After";
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordCompleteActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<recordcompleteInput>> recordcomplete, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcompletePreviousActions = null, Expression<Func<string>> recordcompletionDate = null, Expression<Func<int>> recordrecordActionUniqueId = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordcomplete = WorkflowExpression.Compile(recordcomplete, nameof(recordcomplete), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcompletePreviousActions = WorkflowExpression.Compile(recordcompletePreviousActions, nameof(recordcompletePreviousActions), required: false);
            var __workflow_recordcompletionDate = WorkflowExpression.Compile(recordcompletionDate, nameof(recordcompletionDate), required: false);
            var __workflow_recordrecordActionUniqueId = WorkflowExpression.Compile(recordrecordActionUniqueId, nameof(recordrecordActionUniqueId), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordCompleteActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                @recordpropCount++;
                @record["Complete"] = ExpressionConverter.ConvertO(__workflow_recordcomplete);
                if (__workflow_recordcompletePreviousActions != null)
                {
                    if (__workflow_recordcompletePreviousActions != null)
                    {
                        @record["CompletePrevious"] = ExpressionConverter.ConvertO(__workflow_recordcompletePreviousActions);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["CompletePrevious"] = false;
                    @recordpropCount++;
                }

                if (__workflow_recordcompletionDate != null)
                {
                    @record["CompletionDate"] = ExpressionConverter.ConvertO(__workflow_recordcompletionDate);
                    @recordpropCount++;
                }

                if (__workflow_recordrecordActionUniqueId != null)
                {
                    @record["RecordActionUri"] = ExpressionConverter.ConvertO(__workflow_recordrecordActionUniqueId);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRemoveAllActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRemoveAllActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRescheduleActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordfromBaseDate = null, Expression<Func<bool>> recorduseActualDurations = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordfromBaseDate = WorkflowExpression.Compile(recordfromBaseDate, nameof(recordfromBaseDate), required: false);
            var __workflow_recorduseActualDurations = WorkflowExpression.Compile(recorduseActualDurations, nameof(recorduseActualDurations), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRescheduleActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordfromBaseDate != null)
                {
                    @record["FromBaseDate"] = ExpressionConverter.ConvertO(__workflow_recordfromBaseDate);
                    @recordpropCount++;
                }

                if (__workflow_recorduseActualDurations != null)
                {
                    if (__workflow_recorduseActualDurations != null)
                    {
                        @record["UseActualDurations"] = ExpressionConverter.ConvertO(__workflow_recorduseActualDurations);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["UseActualDurations"] = true;
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordDispose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<recordmethodOfDisposalInput>> recordmethodOfDisposal = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcontinueOnError = WorkflowExpression.Compile(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            var __workflow_recordmethodOfDisposal = WorkflowExpression.Compile(recordmethodOfDisposal, nameof(recordmethodOfDisposal), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcontinueOnError != null)
                {
                    if (__workflow_recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = ExpressionConverter.ConvertO(__workflow_recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = false;
                    @recordpropCount++;
                }

                if (__workflow_recordmethodOfDisposal != null)
                {
                    @record["MethodOfDisposal"] = ExpressionConverter.ConvertO(__workflow_recordmethodOfDisposal);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordUndispose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcontinueOnError = WorkflowExpression.Compile(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordUndispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcontinueOnError != null)
                {
                    if (__workflow_recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = ExpressionConverter.ConvertO(__workflow_recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = false;
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordCheckout(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordsaveCheckoutPathAs = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcomments = WorkflowExpression.Compile(recordcomments, nameof(recordcomments), required: false);
            var __workflow_recordsaveCheckoutPathAs = WorkflowExpression.Compile(recordsaveCheckoutPathAs, nameof(recordsaveCheckoutPathAs), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcomments != null)
                {
                    @record["Comments"] = ExpressionConverter.ConvertO(__workflow_recordcomments);
                    @recordpropCount++;
                }

                if (__workflow_recordsaveCheckoutPathAs != null)
                {
                    @record["SaveCheckoutPathAs"] = ExpressionConverter.ConvertO(__workflow_recordsaveCheckoutPathAs);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordUndoCheckout(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordcomments = WorkflowExpression.Compile(recordcomments, nameof(recordcomments), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordUndoCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordcomments != null)
                {
                    @record["Comments"] = ExpressionConverter.ConvertO(__workflow_recordcomments);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachContact(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordcontactType, Expression<Func<string>> recordcontactLocation, Expression<Func<bool>> recordsetAsPrimaryContact, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordcontactType = WorkflowExpression.Compile(recordcontactType, nameof(recordcontactType), required: true);
            var __workflow_recordcontactLocation = WorkflowExpression.Compile(recordcontactLocation, nameof(recordcontactLocation), required: true);
            var __workflow_recordsetAsPrimaryContact = WorkflowExpression.Compile(recordsetAsPrimaryContact, nameof(recordsetAsPrimaryContact), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                @recordpropCount++;
                @record["ContactType"] = ExpressionConverter.ConvertO(__workflow_recordcontactType);
                @recordpropCount++;
                @record["ContactLocation"] = ExpressionConverter.ConvertO(__workflow_recordcontactLocation);
                @recordpropCount++;
                @record["IsPrimary"] = ExpressionConverter.ConvertO(__workflow_recordsetAsPrimaryContact);
                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordAttachKeyword(Expression<Func<int>> recordRecord, Expression<Func<string>> recordthesaurusTerm, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recordRecord = WorkflowExpression.Compile(recordRecord, nameof(recordRecord), required: true);
            var __workflow_recordthesaurusTerm = WorkflowExpression.Compile(recordthesaurusTerm, nameof(recordthesaurusTerm), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordAttachKeyword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recordRecord);
                @recordpropCount++;
                @record["Keyword"] = ExpressionConverter.ConvertO(__workflow_recordthesaurusTerm);
                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSetUserLabel(Expression<Func<int>> recordRecord, Expression<Func<string>> recorduserLabel, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordfavouriteType = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recordRecord = WorkflowExpression.Compile(recordRecord, nameof(recordRecord), required: true);
            var __workflow_recorduserLabel = WorkflowExpression.Compile(recorduserLabel, nameof(recorduserLabel), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordfavouriteType = WorkflowExpression.Compile(recordfavouriteType, nameof(recordfavouriteType), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordSetUserLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recordRecord);
                @recordpropCount++;
                @record["UserLabel"] = ExpressionConverter.ConvertO(__workflow_recorduserLabel);
                if (__workflow_recordfavouriteType != null)
                {
                    @record["FavouriteType"] = ExpressionConverter.ConvertO(__workflow_recordfavouriteType);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordRequestRendition(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordrenditionType, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordrenditionType = WorkflowExpression.Compile(recordrenditionType, nameof(recordrenditionType), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordRequestRendition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                @recordpropCount++;
                @record["RenditionType"] = ExpressionConverter.ConvertO(__workflow_recordrenditionType);
                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RecordSetAssignee(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordnewAssignee = null, Expression<Func<recordassigneeTypeInput>> recordassigneeType = null, Expression<Func<string>> recorddueForReturnByDate = null, Expression<Func<string>> recordactualTimeChangeOccurred = null, Expression<Func<string>> recordproperties = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_userToImpersonate = WorkflowExpression.Compile(userToImpersonate, nameof(userToImpersonate), required: false);
            var __workflow_recordnewAssignee = WorkflowExpression.Compile(recordnewAssignee, nameof(recordnewAssignee), required: false);
            var __workflow_recordassigneeType = WorkflowExpression.Compile(recordassigneeType, nameof(recordassigneeType), required: false);
            var __workflow_recorddueForReturnByDate = WorkflowExpression.Compile(recorddueForReturnByDate, nameof(recorddueForReturnByDate), required: false);
            var __workflow_recordactualTimeChangeOccurred = WorkflowExpression.Compile(recordactualTimeChangeOccurred, nameof(recordactualTimeChangeOccurred), required: false);
            var __workflow_recordproperties = WorkflowExpression.Compile(recordproperties, nameof(recordproperties), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RecordSetAssignee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(__workflow_userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                if (__workflow_recordnewAssignee != null)
                {
                    @record["NewAssignee"] = ExpressionConverter.ConvertO(__workflow_recordnewAssignee);
                    @recordpropCount++;
                }

                if (__workflow_recordassigneeType != null)
                {
                    if (__workflow_recordassigneeType != null)
                    {
                        @record["AssigneeType"] = ExpressionConverter.ConvertO(__workflow_recordassigneeType);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["AssigneeType"] = "AtLocation";
                    @recordpropCount++;
                }

                if (__workflow_recorddueForReturnByDate != null)
                {
                    @record["DueForReturnByDate"] = ExpressionConverter.ConvertO(__workflow_recorddueForReturnByDate);
                    @recordpropCount++;
                }

                if (__workflow_recordactualTimeChangeOccurred != null)
                {
                    @record["ActualTimeChangeOccurred"] = ExpressionConverter.ConvertO(__workflow_recordactualTimeChangeOccurred);
                    @recordpropCount++;
                }

                if (__workflow_recordproperties != null)
                {
                    if (__workflow_recordproperties != null)
                    {
                        @record["Properties"] = ExpressionConverter.ConvertO(__workflow_recordproperties);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["Properties"] = "RecordTitle, RecordNumber";
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

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
        public IBodyWorkflowAction<CMEventData, ApiConnectionActionConfiguration> ReadEventData(Expression<Func<string>> rawEventDatacontent = null)
        {
            var __workflow_rawEventDatacontent = WorkflowExpression.Compile(rawEventDatacontent, nameof(rawEventDatacontent), required: false);
            return new DeferredBodyAction<CMEventData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ReadEventData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rawEventData = new JObject();
                var rawEventDatapropCount = 0;
                if (__workflow_rawEventDatacontent != null)
                {
                    rawEventData["Content"] = ExpressionConverter.ConvertO(__workflow_rawEventDatacontent);
                    rawEventDatapropCount++;
                }

                if (rawEventDatapropCount > 0)
                {
                    callPayload.Body = rawEventData;
                }

                return new ApiConnectionAction<CMEventData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> AddAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordaccessControlListfunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordaccessControlListfunctionEnum = WorkflowExpression.Compile(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            var __workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            var __workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionEnum != null)
                {
                    if (__workflow_recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionEnum);
                        accessControlListObjectpropCount++;
                    }

                    accessControlListObjectpropCount++;
                }
                else
                {
                    accessControlListObject["FunctionEnum"] = "RecordAccess";
                    accessControlListObjectpropCount++;
                }

                var functionProfilesObject = new JObject();
                var functionProfilesObjectpropCount = 0;
                var viewDocumentObject = new JObject();
                var viewDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents);
                    addContentsObjectpropCount++;
                }

                if (addContentsObjectpropCount > 0)
                {
                    functionProfilesObject["AddContents"] = addContentsObject;
                    functionProfilesObjectpropCount++;
                }

                if (functionProfilesObjectpropCount > 0)
                {
                    accessControlListObject["FunctionProfiles"] = functionProfilesObject;
                    accessControlListObjectpropCount++;
                }

                if (accessControlListObjectpropCount > 0)
                {
                    @record["AccessControlList"] = accessControlListObject;
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> RemoveAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordaccessControlListfunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordaccessControlListfunctionEnum = WorkflowExpression.Compile(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            var __workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            var __workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RemoveAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionEnum != null)
                {
                    if (__workflow_recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionEnum);
                        accessControlListObjectpropCount++;
                    }

                    accessControlListObjectpropCount++;
                }
                else
                {
                    accessControlListObject["FunctionEnum"] = "RecordAccess";
                    accessControlListObjectpropCount++;
                }

                var functionProfilesObject = new JObject();
                var functionProfilesObjectpropCount = 0;
                var viewDocumentObject = new JObject();
                var viewDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents);
                    addContentsObjectpropCount++;
                }

                if (addContentsObjectpropCount > 0)
                {
                    functionProfilesObject["AddContents"] = addContentsObject;
                    functionProfilesObjectpropCount++;
                }

                if (functionProfilesObjectpropCount > 0)
                {
                    accessControlListObject["FunctionProfiles"] = functionProfilesObject;
                    accessControlListObjectpropCount++;
                }

                if (accessControlListObjectpropCount > 0)
                {
                    @record["AccessControlList"] = accessControlListObject;
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> SetAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordaccessControlListfunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordaccessControlListfunctionEnum = WorkflowExpression.Compile(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            var __workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            var __workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SetAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionEnum != null)
                {
                    if (__workflow_recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionEnum);
                        accessControlListObjectpropCount++;
                    }

                    accessControlListObjectpropCount++;
                }
                else
                {
                    accessControlListObject["FunctionEnum"] = "RecordAccess";
                    accessControlListObjectpropCount++;
                }

                var functionProfilesObject = new JObject();
                var functionProfilesObjectpropCount = 0;
                var viewDocumentObject = new JObject();
                var viewDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents);
                    addContentsObjectpropCount++;
                }

                if (addContentsObjectpropCount > 0)
                {
                    functionProfilesObject["AddContents"] = addContentsObject;
                    functionProfilesObjectpropCount++;
                }

                if (functionProfilesObjectpropCount > 0)
                {
                    accessControlListObject["FunctionProfiles"] = functionProfilesObject;
                    accessControlListObjectpropCount++;
                }

                if (accessControlListObjectpropCount > 0)
                {
                    @record["AccessControlList"] = accessControlListObject;
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

                return new ApiConnectionAction<CMRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse, ApiConnectionActionConfiguration> InheritAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordaccessControlListfunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            var __workflow_recorduniqueIdentifier = WorkflowExpression.Compile(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            var __workflow_recordaccessControlListfunctionEnum = WorkflowExpression.Compile(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            var __workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            var __workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            var __workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            var __workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents = WorkflowExpression.Compile(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            return new DeferredBodyAction<CMRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InheritAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = ExpressionConverter.ConvertO(__workflow_recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionEnum != null)
                {
                    if (__workflow_recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionEnum);
                        accessControlListObjectpropCount++;
                    }

                    accessControlListObjectpropCount++;
                }
                else
                {
                    accessControlListObject["FunctionEnum"] = "RecordAccess";
                    accessControlListObjectpropCount++;
                }

                var functionProfilesObject = new JObject();
                var functionProfilesObjectpropCount = 0;
                var viewDocumentObject = new JObject();
                var viewDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(__workflow_recordaccessControlListfunctionProfilesaddContentscontributeContents);
                    addContentsObjectpropCount++;
                }

                if (addContentsObjectpropCount > 0)
                {
                    functionProfilesObject["AddContents"] = addContentsObject;
                    functionProfilesObjectpropCount++;
                }

                if (functionProfilesObjectpropCount > 0)
                {
                    accessControlListObject["FunctionProfiles"] = functionProfilesObject;
                    accessControlListObjectpropCount++;
                }

                if (accessControlListObjectpropCount > 0)
                {
                    @record["AccessControlList"] = accessControlListObject;
                    @recordpropCount++;
                }

                if (@recordpropCount > 0)
                {
                    callPayload.Body = @record;
                }

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

    public class GetFileFromUrlResponse
    {
        public string Filepath { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordassigneeOptionInput
    {
        OverrideExisting,
        OnlyIfNoneSpecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordinsertPositionInput
    {
        Before,
        After
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordcompleteInput
    {
        Current,
        All,
        [EnumMember(Value = "ForUri")]
        ForUniqueIdentifier
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordmethodOfDisposalInput
    {
        None,
        Archived,
        Transferred,
        Destroyed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordassigneeTypeInput
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

    public class AccessLocationsItem
    {
        [JsonProperty("Uri")]
        public int UniqueId { get; set; }
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