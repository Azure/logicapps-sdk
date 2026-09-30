//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contentmanagerpowerc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContentmanagerpowercActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<JToken> RecordSearchAdvanced([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> properties, [WorkflowExpression] Func<string> userToImpersonate = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(properties, nameof(properties), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FindRecordAdvanced";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                callPayload.Headers["parseResponse"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> properties, [WorkflowExpression] Func<string> userToImpersonate = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(properties, nameof(properties), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Record";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> DeleteRecord([WorkflowExpression] Func<int> uri, [WorkflowExpression] Func<bool> deleteRecordDetailsdeleteContents, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> deleteRecordDetailsnewHomeForContents = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(deleteRecordDetailsdeleteContents, nameof(deleteRecordDetailsdeleteContents), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(deleteRecordDetailsnewHomeForContents, nameof(deleteRecordDetailsnewHomeForContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/DeleteRecord/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(uri, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var deleteRecordDetails = new JObject();
                var deleteRecordDetailspropCount = 0;
                deleteRecordDetailspropCount++;
                deleteRecordDetails["DeleteContents"] = SourceExpressionConverter.ConvertToken(deleteRecordDetailsdeleteContents);
                if (deleteRecordDetailsnewHomeForContents != null)
                {
                    deleteRecordDetails["NewHomeForContents"] = SourceExpressionConverter.ConvertToken(deleteRecordDetailsnewHomeForContents);
                    deleteRecordDetailspropCount++;
                }

                if (deleteRecordDetailspropCount > 0)
                {
                    callPayload.Body = deleteRecordDetails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSearchById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> includePropertyDefs = null, [WorkflowExpression] Func<string> descendantProperties = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertySets = null, [WorkflowExpression] Func<propertyValueInput> propertyValue = null, [WorkflowExpression] Func<stringDisplayTypeInput> stringDisplayType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(includePropertyDefs, nameof(includePropertyDefs), required: false);
            SourceExpression.Validate(descendantProperties, nameof(descendantProperties), required: false);
            SourceExpression.Validate(properties, nameof(properties), required: false);
            SourceExpression.Validate(propertySets, nameof(propertySets), required: false);
            SourceExpression.Validate(propertyValue, nameof(propertyValue), required: false);
            SourceExpression.Validate(stringDisplayType, nameof(stringDisplayType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Record/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = SourceExpressionConverter.ConvertO(includePropertyDefs);
                if (descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = SourceExpressionConverter.ConvertO(descendantProperties);
                callPayload.Queries["properties"] = Convert.ToString("RecordNumber");
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (propertySets != null)
                    callPayload.Queries["propertySets"] = SourceExpressionConverter.ConvertO(propertySets);
                if (propertyValue != null)
                    callPayload.Queries["PropertyValue"] = SourceExpressionConverter.Convert(propertyValue);
                if (stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = SourceExpressionConverter.Convert(stringDisplayType);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<string> RecordElecDownload([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<string> userToImpersonate = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordElecDownload";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["uri"] = SourceExpressionConverter.ConvertO(uri);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordReassignAction([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordnewAssignee, [WorkflowExpression] Func<int> recordactionToReassign, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordnewAssignee, nameof(recordnewAssignee), required: true);
            SourceExpression.Validate(recordactionToReassign, nameof(recordactionToReassign), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordReassignAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                @recordpropCount++;
                @record["NewAssignee"] = SourceExpressionConverter.ConvertToken(recordnewAssignee);
                @recordpropCount++;
                @record["RecordActionUri"] = SourceExpressionConverter.ConvertToken(recordactionToReassign);
                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse> RecordClose([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> recordcontinueOnError = null, [WorkflowExpression] Func<bool> recordencloseContents = null, [WorkflowExpression] Func<bool> recordfinalizeContents = null, [WorkflowExpression] Func<bool> recordlogErrorsOnly = null, [WorkflowExpression] Func<bool> recordlogResults = null, [WorkflowExpression] Func<bool> recordpurgeContentRevisions = null, [WorkflowExpression] Func<string> recordspecificCloseDate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            SourceExpression.Validate(recordencloseContents, nameof(recordencloseContents), required: false);
            SourceExpression.Validate(recordfinalizeContents, nameof(recordfinalizeContents), required: false);
            SourceExpression.Validate(recordlogErrorsOnly, nameof(recordlogErrorsOnly), required: false);
            SourceExpression.Validate(recordlogResults, nameof(recordlogResults), required: false);
            SourceExpression.Validate(recordpurgeContentRevisions, nameof(recordpurgeContentRevisions), required: false);
            SourceExpression.Validate(recordspecificCloseDate, nameof(recordspecificCloseDate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcontinueOnError != null)
                {
                    if (recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = SourceExpressionConverter.ConvertToken(recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = true;
                    @recordpropCount++;
                }

                if (recordencloseContents != null)
                {
                    if (recordencloseContents != null)
                    {
                        @record["EncloseContents"] = SourceExpressionConverter.ConvertToken(recordencloseContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["EncloseContents"] = true;
                    @recordpropCount++;
                }

                if (recordfinalizeContents != null)
                {
                    if (recordfinalizeContents != null)
                    {
                        @record["FinalizeContents"] = SourceExpressionConverter.ConvertToken(recordfinalizeContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["FinalizeContents"] = true;
                    @recordpropCount++;
                }

                if (recordlogErrorsOnly != null)
                {
                    if (recordlogErrorsOnly != null)
                    {
                        @record["LogErrorsOnly"] = SourceExpressionConverter.ConvertToken(recordlogErrorsOnly);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogErrorsOnly"] = false;
                    @recordpropCount++;
                }

                if (recordlogResults != null)
                {
                    if (recordlogResults != null)
                    {
                        @record["LogResults"] = SourceExpressionConverter.ConvertToken(recordlogResults);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogResults"] = true;
                    @recordpropCount++;
                }

                if (recordpurgeContentRevisions != null)
                {
                    if (recordpurgeContentRevisions != null)
                    {
                        @record["PurgeContentRevisions"] = SourceExpressionConverter.ConvertToken(recordpurgeContentRevisions);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["PurgeContentRevisions"] = true;
                    @recordpropCount++;
                }

                if (recordspecificCloseDate != null)
                {
                    @record["SpecificCloseDate"] = SourceExpressionConverter.ConvertToken(recordspecificCloseDate);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse> RecordReopen([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> recordcontinueOnError = null, [WorkflowExpression] Func<bool> recordlogResults = null, [WorkflowExpression] Func<bool> recordunfinalizeContents = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            SourceExpression.Validate(recordlogResults, nameof(recordlogResults), required: false);
            SourceExpression.Validate(recordunfinalizeContents, nameof(recordunfinalizeContents), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordReopen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcontinueOnError != null)
                {
                    if (recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = SourceExpressionConverter.ConvertToken(recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = true;
                    @recordpropCount++;
                }

                if (recordlogResults != null)
                {
                    if (recordlogResults != null)
                    {
                        @record["LogResults"] = SourceExpressionConverter.ConvertToken(recordlogResults);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["LogResults"] = true;
                    @recordpropCount++;
                }

                if (recordunfinalizeContents != null)
                {
                    if (recordunfinalizeContents != null)
                    {
                        @record["UnfinalizeContents"] = SourceExpressionConverter.ConvertToken(recordunfinalizeContents);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["UnfinalizeContents"] = true;
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<GetFileFromUrlResponse> GetFileFromUrl([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> filename = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(url, nameof(url), required: true);
            SourceExpression.Validate(filename, nameof(filename), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetFileFromUrl";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (filename != null)
                    callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                if (contentType != null)
                    callPayload.Queries["contentType"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileFromUrlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachAction([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<int> recordactionToAttach, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<int> recordassigneeUniqueId = null, [WorkflowExpression] Func<recordassigneeOptionInput> recordassigneeOption = null, [WorkflowExpression] Func<string> recordscheduleStartDate = null, [WorkflowExpression] Func<int> recordexistingAction = null, [WorkflowExpression] Func<recordinsertPositionInput> recordinsertPosition = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordactionToAttach, nameof(recordactionToAttach), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordassigneeUniqueId, nameof(recordassigneeUniqueId), required: false);
            SourceExpression.Validate(recordassigneeOption, nameof(recordassigneeOption), required: false);
            SourceExpression.Validate(recordscheduleStartDate, nameof(recordscheduleStartDate), required: false);
            SourceExpression.Validate(recordexistingAction, nameof(recordexistingAction), required: false);
            SourceExpression.Validate(recordinsertPosition, nameof(recordinsertPosition), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordAttachAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                @recordpropCount++;
                @record["ActionToAttach"] = SourceExpressionConverter.ConvertToken(recordactionToAttach);
                if (recordassigneeUniqueId != null)
                {
                    @record["NewAssignee"] = SourceExpressionConverter.ConvertToken(recordassigneeUniqueId);
                    @recordpropCount++;
                }

                if (recordassigneeOption != null)
                {
                    if (recordassigneeOption != null)
                    {
                        @record["AssigneeOption"] = SourceExpressionConverter.Convert(recordassigneeOption);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["AssigneeOption"] = "OverrideExisting";
                    @recordpropCount++;
                }

                if (recordscheduleStartDate != null)
                {
                    @record["ScheduleStartDate"] = SourceExpressionConverter.ConvertToken(recordscheduleStartDate);
                    @recordpropCount++;
                }

                if (recordexistingAction != null)
                {
                    @record["RecordAction"] = SourceExpressionConverter.ConvertToken(recordexistingAction);
                    @recordpropCount++;
                }

                if (recordinsertPosition != null)
                {
                    if (recordinsertPosition != null)
                    {
                        @record["InsertPos"] = SourceExpressionConverter.Convert(recordinsertPosition);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["InsertPos"] = "After";
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCompleteActions([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<recordcompleteInput> recordcomplete, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> recordcompletePreviousActions = null, [WorkflowExpression] Func<string> recordcompletionDate = null, [WorkflowExpression] Func<int> recordrecordActionUniqueId = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordcomplete, nameof(recordcomplete), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcompletePreviousActions, nameof(recordcompletePreviousActions), required: false);
            SourceExpression.Validate(recordcompletionDate, nameof(recordcompletionDate), required: false);
            SourceExpression.Validate(recordrecordActionUniqueId, nameof(recordrecordActionUniqueId), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordCompleteActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                @recordpropCount++;
                @record["Complete"] = SourceExpressionConverter.Convert(recordcomplete);
                if (recordcompletePreviousActions != null)
                {
                    if (recordcompletePreviousActions != null)
                    {
                        @record["CompletePrevious"] = SourceExpressionConverter.ConvertToken(recordcompletePreviousActions);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["CompletePrevious"] = false;
                    @recordpropCount++;
                }

                if (recordcompletionDate != null)
                {
                    @record["CompletionDate"] = SourceExpressionConverter.ConvertToken(recordcompletionDate);
                    @recordpropCount++;
                }

                if (recordrecordActionUniqueId != null)
                {
                    @record["RecordActionUri"] = SourceExpressionConverter.ConvertToken(recordrecordActionUniqueId);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRemoveAllActions([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordRemoveAllActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRescheduleActions([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordfromBaseDate = null, [WorkflowExpression] Func<bool> recorduseActualDurations = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordfromBaseDate, nameof(recordfromBaseDate), required: false);
            SourceExpression.Validate(recorduseActualDurations, nameof(recorduseActualDurations), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordRescheduleActions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordfromBaseDate != null)
                {
                    @record["FromBaseDate"] = SourceExpressionConverter.ConvertToken(recordfromBaseDate);
                    @recordpropCount++;
                }

                if (recorduseActualDurations != null)
                {
                    if (recorduseActualDurations != null)
                    {
                        @record["UseActualDurations"] = SourceExpressionConverter.ConvertToken(recorduseActualDurations);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["UseActualDurations"] = true;
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordDispose([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> recordcontinueOnError = null, [WorkflowExpression] Func<recordmethodOfDisposalInput> recordmethodOfDisposal = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            SourceExpression.Validate(recordmethodOfDisposal, nameof(recordmethodOfDisposal), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcontinueOnError != null)
                {
                    if (recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = SourceExpressionConverter.ConvertToken(recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = false;
                    @recordpropCount++;
                }

                if (recordmethodOfDisposal != null)
                {
                    @record["MethodOfDisposal"] = SourceExpressionConverter.Convert(recordmethodOfDisposal);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUndispose([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> recordcontinueOnError = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcontinueOnError, nameof(recordcontinueOnError), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordUndispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcontinueOnError != null)
                {
                    if (recordcontinueOnError != null)
                    {
                        @record["ContinueOnError"] = SourceExpressionConverter.ConvertToken(recordcontinueOnError);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["ContinueOnError"] = false;
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCheckout([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordcomments = null, [WorkflowExpression] Func<string> recordsaveCheckoutPathAs = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcomments, nameof(recordcomments), required: false);
            SourceExpression.Validate(recordsaveCheckoutPathAs, nameof(recordsaveCheckoutPathAs), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcomments != null)
                {
                    @record["Comments"] = SourceExpressionConverter.ConvertToken(recordcomments);
                    @recordpropCount++;
                }

                if (recordsaveCheckoutPathAs != null)
                {
                    @record["SaveCheckoutPathAs"] = SourceExpressionConverter.ConvertToken(recordsaveCheckoutPathAs);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUndoCheckout([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordcomments = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordcomments, nameof(recordcomments), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordUndoCheckout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordcomments != null)
                {
                    @record["Comments"] = SourceExpressionConverter.ConvertToken(recordcomments);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachContact([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordcontactType, [WorkflowExpression] Func<string> recordcontactLocation, [WorkflowExpression] Func<bool> recordsetAsPrimaryContact, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordcontactType, nameof(recordcontactType), required: true);
            SourceExpression.Validate(recordcontactLocation, nameof(recordcontactLocation), required: true);
            SourceExpression.Validate(recordsetAsPrimaryContact, nameof(recordsetAsPrimaryContact), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordAttachContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                @recordpropCount++;
                @record["ContactType"] = SourceExpressionConverter.ConvertToken(recordcontactType);
                @recordpropCount++;
                @record["ContactLocation"] = SourceExpressionConverter.ConvertToken(recordcontactLocation);
                @recordpropCount++;
                @record["IsPrimary"] = SourceExpressionConverter.ConvertToken(recordsetAsPrimaryContact);
                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachKeyword([WorkflowExpression] Func<int> recordRecord, [WorkflowExpression] Func<string> recordthesaurusTerm, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recordRecord, nameof(recordRecord), required: true);
            SourceExpression.Validate(recordthesaurusTerm, nameof(recordthesaurusTerm), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordAttachKeyword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recordRecord);
                @recordpropCount++;
                @record["Keyword"] = SourceExpressionConverter.ConvertToken(recordthesaurusTerm);
                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSetUserLabel([WorkflowExpression] Func<int> recordRecord, [WorkflowExpression] Func<string> recorduserLabel, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordfavouriteType = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recordRecord, nameof(recordRecord), required: true);
            SourceExpression.Validate(recorduserLabel, nameof(recorduserLabel), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordfavouriteType, nameof(recordfavouriteType), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordSetUserLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recordRecord);
                @recordpropCount++;
                @record["UserLabel"] = SourceExpressionConverter.ConvertToken(recorduserLabel);
                if (recordfavouriteType != null)
                {
                    @record["FavouriteType"] = SourceExpressionConverter.ConvertToken(recordfavouriteType);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRequestRendition([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordrenditionType, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordrenditionType, nameof(recordrenditionType), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordRequestRendition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                @recordpropCount++;
                @record["RenditionType"] = SourceExpressionConverter.ConvertToken(recordrenditionType);
                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSetAssignee([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> recordnewAssignee = null, [WorkflowExpression] Func<recordassigneeTypeInput> recordassigneeType = null, [WorkflowExpression] Func<string> recorddueForReturnByDate = null, [WorkflowExpression] Func<string> recordactualTimeChangeOccurred = null, [WorkflowExpression] Func<string> recordproperties = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(recordnewAssignee, nameof(recordnewAssignee), required: false);
            SourceExpression.Validate(recordassigneeType, nameof(recordassigneeType), required: false);
            SourceExpression.Validate(recorddueForReturnByDate, nameof(recorddueForReturnByDate), required: false);
            SourceExpression.Validate(recordactualTimeChangeOccurred, nameof(recordactualTimeChangeOccurred), required: false);
            SourceExpression.Validate(recordproperties, nameof(recordproperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RecordSetAssignee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                if (recordnewAssignee != null)
                {
                    @record["NewAssignee"] = SourceExpressionConverter.ConvertToken(recordnewAssignee);
                    @recordpropCount++;
                }

                if (recordassigneeType != null)
                {
                    if (recordassigneeType != null)
                    {
                        @record["AssigneeType"] = SourceExpressionConverter.Convert(recordassigneeType);
                        @recordpropCount++;
                    }

                    @recordpropCount++;
                }
                else
                {
                    @record["AssigneeType"] = "AtLocation";
                    @recordpropCount++;
                }

                if (recorddueForReturnByDate != null)
                {
                    @record["DueForReturnByDate"] = SourceExpressionConverter.ConvertToken(recorddueForReturnByDate);
                    @recordpropCount++;
                }

                if (recordactualTimeChangeOccurred != null)
                {
                    @record["ActualTimeChangeOccurred"] = SourceExpressionConverter.ConvertToken(recordactualTimeChangeOccurred);
                    @recordpropCount++;
                }

                if (recordproperties != null)
                {
                    if (recordproperties != null)
                    {
                        @record["Properties"] = SourceExpressionConverter.ConvertToken(recordproperties);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<bool> applyDefaults = null, [WorkflowExpression] Func<bool> countResults = null, [WorkflowExpression] Func<bool> excludeCount = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> fromSearch = null, [WorkflowExpression] Func<string> descendantProperties = null, [WorkflowExpression] Func<bool> includePropertyDefs = null, [WorkflowExpression] Func<string> options = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertySets = null, [WorkflowExpression] Func<propertyValueInput> propertyValue = null, [WorkflowExpression] Func<string> pageSize = null, [WorkflowExpression] Func<string> purpose = null, [WorkflowExpression] Func<string> purposeExtra = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<stringDisplayTypeInput> stringDisplayType = null)
        {
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(applyDefaults, nameof(applyDefaults), required: false);
            SourceExpression.Validate(countResults, nameof(countResults), required: false);
            SourceExpression.Validate(excludeCount, nameof(excludeCount), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(fromSearch, nameof(fromSearch), required: false);
            SourceExpression.Validate(descendantProperties, nameof(descendantProperties), required: false);
            SourceExpression.Validate(includePropertyDefs, nameof(includePropertyDefs), required: false);
            SourceExpression.Validate(options, nameof(options), required: false);
            SourceExpression.Validate(properties, nameof(properties), required: false);
            SourceExpression.Validate(propertySets, nameof(propertySets), required: false);
            SourceExpression.Validate(propertyValue, nameof(propertyValue), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(purpose, nameof(purpose), required: false);
            SourceExpression.Validate(purposeExtra, nameof(purposeExtra), required: false);
            SourceExpression.Validate(sortBy, nameof(sortBy), required: false);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(stringDisplayType, nameof(stringDisplayType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (applyDefaults != null)
                    callPayload.Queries["ApplyDefaults"] = SourceExpressionConverter.ConvertO(applyDefaults);
                if (countResults != null)
                    callPayload.Queries["CountResults"] = SourceExpressionConverter.ConvertO(countResults);
                if (excludeCount != null)
                    callPayload.Queries["ExcludeCount"] = SourceExpressionConverter.ConvertO(excludeCount);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (fromSearch != null)
                    callPayload.Queries["fromSearch"] = SourceExpressionConverter.ConvertO(fromSearch);
                if (descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = SourceExpressionConverter.ConvertO(descendantProperties);
                if (includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = SourceExpressionConverter.ConvertO(includePropertyDefs);
                if (options != null)
                    callPayload.Queries["Options"] = SourceExpressionConverter.ConvertO(options);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (propertySets != null)
                    callPayload.Queries["propertySets"] = SourceExpressionConverter.ConvertO(propertySets);
                if (propertyValue != null)
                    callPayload.Queries["PropertyValue"] = SourceExpressionConverter.Convert(propertyValue);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (purpose != null)
                    callPayload.Queries["purpose"] = SourceExpressionConverter.ConvertO(purpose);
                if (purposeExtra != null)
                    callPayload.Queries["purposeExtra"] = SourceExpressionConverter.ConvertO(purposeExtra);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = SourceExpressionConverter.Convert(stringDisplayType);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<CMLocationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationSearchById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> userToImpersonate = null, [WorkflowExpression] Func<string> descendantProperties = null, [WorkflowExpression] Func<bool> includePropertyDefs = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> propertySets = null, [WorkflowExpression] Func<propertyValueInput> propertyValue = null, [WorkflowExpression] Func<stringDisplayTypeInput> stringDisplayType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            SourceExpression.Validate(descendantProperties, nameof(descendantProperties), required: false);
            SourceExpression.Validate(includePropertyDefs, nameof(includePropertyDefs), required: false);
            SourceExpression.Validate(properties, nameof(properties), required: false);
            SourceExpression.Validate(propertySets, nameof(propertySets), required: false);
            SourceExpression.Validate(propertyValue, nameof(propertyValue), required: false);
            SourceExpression.Validate(stringDisplayType, nameof(stringDisplayType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (descendantProperties != null)
                    callPayload.Queries["descendantProperties"] = SourceExpressionConverter.ConvertO(descendantProperties);
                if (includePropertyDefs != null)
                    callPayload.Queries["IncludePropertyDefs"] = SourceExpressionConverter.ConvertO(includePropertyDefs);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (propertySets != null)
                    callPayload.Queries["propertySets"] = SourceExpressionConverter.ConvertO(propertySets);
                if (propertyValue != null)
                    callPayload.Queries["PropertyValue"] = SourceExpressionConverter.Convert(propertyValue);
                if (stringDisplayType != null)
                    callPayload.Queries["stringDisplayType"] = SourceExpressionConverter.Convert(stringDisplayType);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<CMLocationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationAddressUri> FindLocationChildAddressUri([WorkflowExpression] Func<string> locationUri, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> userToImpersonate = null)
        {
            SourceExpression.Validate(locationUri, nameof(locationUri), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(userToImpersonate, nameof(userToImpersonate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FindLocationChildAddressUri/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationUri, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (userToImpersonate != null)
                    callPayload.Headers["userToImpersonate"] = SourceExpressionConverter.ConvertO(userToImpersonate);
                return callPayload;
            }

            return new ApiConnectionAction<CMLocationAddressUri>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMEventData> ReadEventData([WorkflowExpression] Func<string> rawEventDatacontent = null)
        {
            SourceExpression.Validate(rawEventDatacontent, nameof(rawEventDatacontent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ReadEventData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var rawEventData = new JObject();
                var rawEventDatapropCount = 0;
                if (rawEventDatacontent != null)
                {
                    rawEventData["Content"] = SourceExpressionConverter.ConvertToken(rawEventDatacontent);
                    rawEventDatapropCount++;
                }

                if (rawEventDatapropCount > 0)
                {
                    callPayload.Body = rawEventData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CMEventData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> AddAccessControl([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordaccessControlListfunctionEnum = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (recordaccessControlListfunctionEnum != null)
                {
                    if (recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionEnum);
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
                if (recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesaddContentscontributeContents);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RemoveAccessControl([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordaccessControlListfunctionEnum = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RemoveAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (recordaccessControlListfunctionEnum != null)
                {
                    if (recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionEnum);
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
                if (recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesaddContentscontributeContents);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> SetAccessControl([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordaccessControlListfunctionEnum = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SetAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (recordaccessControlListfunctionEnum != null)
                {
                    if (recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionEnum);
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
                if (recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesaddContentscontributeContents);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> InheritAccessControl([WorkflowExpression] Func<int> recorduniqueIdentifier, [WorkflowExpression] Func<string> recordaccessControlListfunctionEnum = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewDocumentviewDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesviewRecordviewMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateDocumentupdateDocument = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord = null, [WorkflowExpression] Func<AccessLocationsItem[]> recordaccessControlListfunctionProfilesaddContentscontributeContents = null)
        {
            SourceExpression.Validate(recorduniqueIdentifier, nameof(recorduniqueIdentifier), required: true);
            SourceExpression.Validate(recordaccessControlListfunctionEnum, nameof(recordaccessControlListfunctionEnum), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewDocumentviewDocument, nameof(recordaccessControlListfunctionProfilesviewDocumentviewDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesviewRecordviewMetadata, nameof(recordaccessControlListfunctionProfilesviewRecordviewMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument, nameof(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata, nameof(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess, nameof(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord, nameof(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord), required: false);
            SourceExpression.Validate(recordaccessControlListfunctionProfilesaddContentscontributeContents, nameof(recordaccessControlListfunctionProfilesaddContentscontributeContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/InheritAccessControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                var @record = new JObject();
                var @recordpropCount = 0;
                @recordpropCount++;
                @record["Uri"] = SourceExpressionConverter.ConvertToken(recorduniqueIdentifier);
                var accessControlListObject = new JObject();
                var accessControlListObjectpropCount = 0;
                if (recordaccessControlListfunctionEnum != null)
                {
                    if (recordaccessControlListfunctionEnum != null)
                    {
                        accessControlListObject["FunctionEnum"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionEnum);
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
                if (recordaccessControlListfunctionProfilesviewDocumentviewDocument != null)
                {
                    viewDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewDocumentviewDocument);
                    viewDocumentObjectpropCount++;
                }

                if (viewDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["ViewDocument"] = viewDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var viewRecordObject = new JObject();
                var viewRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesviewRecordviewMetadata != null)
                {
                    viewRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesviewRecordviewMetadata);
                    viewRecordObjectpropCount++;
                }

                if (viewRecordObjectpropCount > 0)
                {
                    functionProfilesObject["ViewRecord"] = viewRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var updateDocumentObject = new JObject();
                var updateDocumentObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateDocumentupdateDocument != null)
                {
                    updateDocumentObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateDocumentupdateDocument);
                    updateDocumentObjectpropCount++;
                }

                if (updateDocumentObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateDocument"] = updateDocumentObject;
                    functionProfilesObjectpropCount++;
                }

                var updateMetadataObject = new JObject();
                var updateMetadataObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata != null)
                {
                    updateMetadataObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesupdateMetadataupdateRecordMetadata);
                    updateMetadataObjectpropCount++;
                }

                if (updateMetadataObjectpropCount > 0)
                {
                    functionProfilesObject["UpdateMetadata"] = updateMetadataObject;
                    functionProfilesObjectpropCount++;
                }

                var modifyAccessObject = new JObject();
                var modifyAccessObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess != null)
                {
                    modifyAccessObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesmodifyAccessmodifyRecordAccess);
                    modifyAccessObjectpropCount++;
                }

                if (modifyAccessObjectpropCount > 0)
                {
                    functionProfilesObject["ModifyAccess"] = modifyAccessObject;
                    functionProfilesObjectpropCount++;
                }

                var destroyRecordObject = new JObject();
                var destroyRecordObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord != null)
                {
                    destroyRecordObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesdestroyRecorddestroyRecord);
                    destroyRecordObjectpropCount++;
                }

                if (destroyRecordObjectpropCount > 0)
                {
                    functionProfilesObject["DestroyRecord"] = destroyRecordObject;
                    functionProfilesObjectpropCount++;
                }

                var addContentsObject = new JObject();
                var addContentsObjectpropCount = 0;
                if (recordaccessControlListfunctionProfilesaddContentscontributeContents != null)
                {
                    addContentsObject["AccessLocations"] = SourceExpressionConverter.ConvertToken(recordaccessControlListfunctionProfilesaddContentscontributeContents);
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
                return callPayload;
            }

            return new ApiConnectionAction<CMRecordsResponse>(BuildSourceInput);
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

    public enum CMRecordAuthorizationMethodType
    {
        Simple,
        Challenge,
        Docusign
    }

    public enum CMRecordClassOfRecordType
    {
        Vital,
        Corporate,
        WorkGroup,
        Personal,
        Reference,
        Temporary
    }

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

    public enum propertyValueInput
    {
        Raw,
        String,
        Both
    }

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

    public enum recordassigneeOptionInput
    {
        OverrideExisting,
        OnlyIfNoneSpecified
    }

    public enum recordinsertPositionInput
    {
        Before,
        After
    }

    public enum recordcompleteInput
    {
        Current,
        All,
        [EnumMember(Value = "ForUri")]
        ForUniqueIdentifier
    }

    public enum recordmethodOfDisposalInput
    {
        None,
        Archived,
        Transferred,
        Destroyed
    }

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
        public int UniqueID { get; set; }
    }

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
        public int EventTypeID { get; set; }

        [JsonProperty("EventTypeString")]
        public string EventType { get; set; }
        public string EventDate { get; set; }

        [JsonProperty("ObjectType")]
        public int ObjectTypeID { get; set; }

        [JsonProperty("ObjectTypeString")]
        public string ObjectType { get; set; }

        [JsonProperty("ObjectUri")]
        public int ObjectUniqueID { get; set; }

        [JsonProperty("RelatedObjectType")]
        public int RelatedObjectTypeID { get; set; }

        [JsonProperty("RelatedObjectTypeString")]
        public string RelatedObjectType { get; set; }

        [JsonProperty("RelatedObjectUri")]
        public int RelatedObjectUniqueID { get; set; }
        public string FromMachine { get; set; }
        public string ConnectionIPAddress { get; set; }
        public string ClientIPAddress { get; set; }
        public int FromTimeZone { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("LoginUri")]
        public int LoginUniqueID { get; set; }
        public string ExtraDetails { get; set; }
    }

    public class AccessLocationsItem
    {
        [JsonProperty("Uri")]
        public int UniqueID { get; set; }
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