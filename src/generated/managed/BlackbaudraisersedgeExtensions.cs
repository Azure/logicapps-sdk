//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudraisersedgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent> CreateConstituentConsent([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodychannel, [WorkflowExpression] Func<bodyresponseInput> bodyresponse, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyconsentStatement = null, [WorkflowExpression] Func<string> bodyprivacyNotice = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodychannel, nameof(bodychannel), required: true);
            SourceExpression.Validate(bodyresponse, nameof(bodyresponse), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            SourceExpression.Validate(bodyconsentStatement, nameof(bodyconsentStatement), required: false);
            SourceExpression.Validate(bodyprivacyNotice, nameof(bodyprivacyNotice), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/commpref/v1/consent/consents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["channel"] = SourceExpressionConverter.ConvertToken(bodychannel);
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                bodypropCount++;
                body["constituent_consent_response"] = SourceExpressionConverter.Convert(bodyresponse);
                bodypropCount++;
                body["consent_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodyconsentStatement != null)
                {
                    body["consent_statement"] = SourceExpressionConverter.ConvertToken(bodyconsentStatement);
                    bodypropCount++;
                }

                if (bodyprivacyNotice != null)
                {
                    body["privacy_notice"] = SourceExpressionConverter.ConvertToken(bodyprivacyNotice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection> ListConstituentConsents([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> mostRecentOnly = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(mostRecentOnly, nameof(mostRecentOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituents/{0}/consents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = SourceExpressionConverter.ConvertO(mostRecentOnly);
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection> ListConstituentSolicitCodes([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituents/{0}/constituentsolicitcodes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode> CreateConstituentSolicitCode([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodysolicitCode, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodysolicitCode, nameof(bodysolicitCode), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/commpref/v1/constituentsolicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId, [WorkflowExpression] Func<string> bodysolicitCode = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            SourceExpression.Validate(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            SourceExpression.Validate(bodysolicitCode, nameof(bodysolicitCode), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituentsolicitcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysolicitCode != null)
                {
                    body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> computedStatus = null, [WorkflowExpression] Func<string> statusCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(computedStatus, nameof(computedStatus), required: false);
            SourceExpression.Validate(statusCode, nameof(statusCode), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (computedStatus != null)
                    callPayload.Queries["computed_status"] = SourceExpressionConverter.ConvertO(computedStatus);
                if (statusCode != null)
                    callPayload.Queries["status_code"] = SourceExpressionConverter.ConvertO(statusCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<bodycategoryInput> bodycategory, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityId = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodycompleted, nameof(bodycompleted), required: false);
            SourceExpression.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            SourceExpression.Validate(bodydirection, nameof(bodydirection), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            SourceExpression.Validate(bodyopportunityId, nameof(bodyopportunityId), required: false);
            SourceExpression.Validate(bodyoutcome, nameof(bodyoutcome), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.Convert(bodycategory);
                if (bodycompleted != null)
                {
                    body["completed"] = SourceExpressionConverter.ConvertToken(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = SourceExpressionConverter.ConvertToken(bodycompletedOn);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodynote != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = SourceExpressionConverter.Convert(bodydirection);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityId != null)
                {
                    body["opportunity_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = SourceExpressionConverter.Convert(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction([WorkflowExpression] Func<string> actionId)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiActionRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditAction([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<bodycategoryInput> bodycategory = null, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityId = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodycompleted, nameof(bodycompleted), required: false);
            SourceExpression.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            SourceExpression.Validate(bodydirection, nameof(bodydirection), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            SourceExpression.Validate(bodyopportunityId, nameof(bodyopportunityId), required: false);
            SourceExpression.Validate(bodyoutcome, nameof(bodyoutcome), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.Convert(bodycategory);
                    bodypropCount++;
                }

                if (bodycompleted != null)
                {
                    body["completed"] = SourceExpressionConverter.ConvertToken(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = SourceExpressionConverter.ConvertToken(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = SourceExpressionConverter.Convert(bodydirection);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityId != null)
                {
                    body["opportunity_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = SourceExpressionConverter.Convert(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments([WorkflowExpression] Func<string> actionId)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields([WorkflowExpression] Func<string> actionId)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment([WorkflowExpression] Func<string> bodyactionId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodyactionId, nameof(bodyactionId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyactionId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditActionAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField([WorkflowExpression] Func<string> bodyactionId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyactionId, nameof(bodyactionId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyactionId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditActionCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress> CreateConstituentAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyaddressType, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddressLines = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodysuburb = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodyvalidFrom = null, [WorkflowExpression] Func<string> bodyvalidTo = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartyear = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndyear = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: true);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodyaddressLines, nameof(bodyaddressLines), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            SourceExpression.Validate(bodysuburb, nameof(bodysuburb), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            SourceExpression.Validate(bodycART, nameof(bodycART), required: false);
            SourceExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            SourceExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            SourceExpression.Validate(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            SourceExpression.Validate(bodyvalidTo, nameof(bodyvalidTo), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            SourceExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            SourceExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            SourceExpression.Validate(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            SourceExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            SourceExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            SourceExpression.Validate(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddressLines != null)
                {
                    body["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddressLines);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodysuburb != null)
                {
                    body["suburb"] = SourceExpressionConverter.ConvertToken(bodysuburb);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["information_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodyvalidFrom != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyvalidFrom);
                    bodypropCount++;
                }

                if (bodyvalidTo != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyvalidTo);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["preferred"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAddress([WorkflowExpression] Func<string> addressId, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddressLines = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodysuburb = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodyvalidFrom = null, [WorkflowExpression] Func<string> bodyvalidTo = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartyear = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndyear = null)
        {
            SourceExpression.Validate(addressId, nameof(addressId), required: true);
            SourceExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodyaddressLines, nameof(bodyaddressLines), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            SourceExpression.Validate(bodysuburb, nameof(bodysuburb), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            SourceExpression.Validate(bodycART, nameof(bodycART), required: false);
            SourceExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            SourceExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            SourceExpression.Validate(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            SourceExpression.Validate(bodyvalidTo, nameof(bodyvalidTo), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            SourceExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            SourceExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            SourceExpression.Validate(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            SourceExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            SourceExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            SourceExpression.Validate(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/addresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(addressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressType != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddressLines != null)
                {
                    body["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddressLines);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodysuburb != null)
                {
                    body["suburb"] = SourceExpressionConverter.ConvertToken(bodysuburb);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["information_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodyvalidFrom != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyvalidFrom);
                    bodypropCount++;
                }

                if (bodyvalidTo != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyvalidTo);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["preferred"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias> CreateConstituentAlias([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyalias, [WorkflowExpression] Func<string> bodytype = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyalias, nameof(bodyalias), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/aliases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyalias);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAlias([WorkflowExpression] Func<string> aliasId, [WorkflowExpression] Func<string> bodyalias = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            SourceExpression.Validate(aliasId, nameof(aliasId), required: true);
            SourceExpression.Validate(bodyalias, nameof(bodyalias), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/aliases/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aliasId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyalias != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyalias);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode> CreateConstituentCode([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyconstituentCode, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyconstituentCode, nameof(bodyconstituentCode), required: true);
            SourceExpression.Validate(bodystartday, nameof(bodystartday), required: false);
            SourceExpression.Validate(bodystartmonth, nameof(bodystartmonth), required: false);
            SourceExpression.Validate(bodystartyear, nameof(bodystartyear), required: false);
            SourceExpression.Validate(bodyendday, nameof(bodyendday), required: false);
            SourceExpression.Validate(bodyendmonth, nameof(bodyendmonth), required: false);
            SourceExpression.Validate(bodyendyear, nameof(bodyendyear), required: false);
            SourceExpression.Validate(bodysequence, nameof(bodysequence), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituentcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodyconstituentCode);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction DeleteConstituentCode([WorkflowExpression] Func<string> constituentCodeId)
        {
            SourceExpression.Validate(constituentCodeId, nameof(constituentCodeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituentcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentCode([WorkflowExpression] Func<string> constituentCodeId, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            SourceExpression.Validate(constituentCodeId, nameof(constituentCodeId), required: true);
            SourceExpression.Validate(bodystartday, nameof(bodystartday), required: false);
            SourceExpression.Validate(bodystartmonth, nameof(bodystartmonth), required: false);
            SourceExpression.Validate(bodystartyear, nameof(bodystartyear), required: false);
            SourceExpression.Validate(bodyendday, nameof(bodyendday), required: false);
            SourceExpression.Validate(bodyendmonth, nameof(bodyendmonth), required: false);
            SourceExpression.Validate(bodyendyear, nameof(bodyendyear), required: false);
            SourceExpression.Validate(bodysequence, nameof(bodysequence), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituentcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCodeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead> ListConstituents([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> constituentCode = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<string> customFieldCategory = null, [WorkflowExpression] Func<string> fundraiserStatus = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(constituentCode, nameof(constituentCode), required: false);
            SourceExpression.Validate(constituentId, nameof(constituentId), required: false);
            SourceExpression.Validate(customFieldCategory, nameof(customFieldCategory), required: false);
            SourceExpression.Validate(fundraiserStatus, nameof(fundraiserStatus), required: false);
            SourceExpression.Validate(includeDeceased, nameof(includeDeceased), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (constituentCode != null)
                    callPayload.Queries["constituent_code"] = SourceExpressionConverter.ConvertO(constituentCode);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (customFieldCategory != null)
                    callPayload.Queries["custom_field_category"] = SourceExpressionConverter.ConvertO(customFieldCategory);
                if (fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = SourceExpressionConverter.ConvertO(fundraiserStatus);
                if (includeDeceased != null)
                    callPayload.Queries["include_deceased"] = SourceExpressionConverter.ConvertO(includeDeceased);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (postalCode != null)
                    callPayload.Queries["postal_code"] = SourceExpressionConverter.ConvertO(postalCode);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead> GetConstituent([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiConstituentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyorganizationName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyformerName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<string> bodybirthplace = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<string> bodyincome = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynumberOfEmployees = null, [WorkflowExpression] Func<bool> bodymatchesGifts = null, [WorkflowExpression] Func<double> bodymatchingGiftFactor = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMinminMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMinminMatchPerConstit = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, [WorkflowExpression] Func<string> bodymatchingGiftNotes = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<int> bodydeceasedDateday = null, [WorkflowExpression] Func<int> bodydeceasedDatemonth = null, [WorkflowExpression] Func<int> bodydeceasedDateyear = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyorganizationName, nameof(bodyorganizationName), required: false);
            SourceExpression.Validate(bodysuffix, nameof(bodysuffix), required: false);
            SourceExpression.Validate(bodypreferredName, nameof(bodypreferredName), required: false);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodyformerName, nameof(bodyformerName), required: false);
            SourceExpression.Validate(bodytitle2, nameof(bodytitle2), required: false);
            SourceExpression.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            SourceExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            SourceExpression.Validate(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            SourceExpression.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            SourceExpression.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            SourceExpression.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            SourceExpression.Validate(bodybirthplace, nameof(bodybirthplace), required: false);
            SourceExpression.Validate(bodyethnicity, nameof(bodyethnicity), required: false);
            SourceExpression.Validate(bodyincome, nameof(bodyincome), required: false);
            SourceExpression.Validate(bodyreligion, nameof(bodyreligion), required: false);
            SourceExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            SourceExpression.Validate(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            SourceExpression.Validate(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            SourceExpression.Validate(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            SourceExpression.Validate(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            SourceExpression.Validate(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            SourceExpression.Validate(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            SourceExpression.Validate(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            SourceExpression.Validate(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            SourceExpression.Validate(bodydeceased, nameof(bodydeceased), required: false);
            SourceExpression.Validate(bodydeceasedDateday, nameof(bodydeceasedDateday), required: false);
            SourceExpression.Validate(bodydeceasedDatemonth, nameof(bodydeceasedDatemonth), required: false);
            SourceExpression.Validate(bodydeceasedDateyear, nameof(bodydeceasedDateyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyorganizationName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyorganizationName);
                    bodypropCount++;
                }

                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferred_name"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyformerName != null)
                {
                    body["former_name"] = SourceExpressionConverter.ConvertToken(bodyformerName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (bodybirthdateday != null)
                {
                    birthdateObject["d"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdateyear != null)
                {
                    birthdateObject["y"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (bodybirthplace != null)
                {
                    body["birthplace"] = SourceExpressionConverter.ConvertToken(bodybirthplace);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodyincome != null)
                {
                    body["income"] = SourceExpressionConverter.ConvertToken(bodyincome);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynumberOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (bodymatchesGifts != null)
                {
                    body["matches_gifts"] = SourceExpressionConverter.ConvertToken(bodymatchesGifts);
                    bodypropCount++;
                }

                if (bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (bodydeceased != null)
                {
                    body["deceased"] = SourceExpressionConverter.ConvertToken(bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (bodydeceasedDateday != null)
                {
                    deceasedDateObject["d"] = SourceExpressionConverter.ConvertToken(bodydeceasedDateday);
                    deceasedDateObjectpropCount++;
                }

                if (bodydeceasedDatemonth != null)
                {
                    deceasedDateObject["m"] = SourceExpressionConverter.ConvertToken(bodydeceasedDatemonth);
                    deceasedDateObjectpropCount++;
                }

                if (bodydeceasedDateyear != null)
                {
                    deceasedDateObject["y"] = SourceExpressionConverter.ConvertToken(bodydeceasedDateyear);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["deceased_date"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead> ListConstituentAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead> ListConstituentAliases([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/aliases", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead> ListConstituentAttachments([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead> ListConstituentCodes([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/constituentcodes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead> ListConstituentCustomFields([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead> ListConstituentEducations([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/educations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead> ListConstituentEmailAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/emailaddresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead> ListConstituentFundraiserAssignments([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/fundraiserassignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentFirstGift([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/first", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentGreatestGift([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/greatest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentLatestGift([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead> GetConstituentLifetimeGiving([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead> ListConstituentNotes([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead> ListConstituentOnlinePresences([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/onlinepresences", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead> ListConstituentPhones([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/phones", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead> GetConstituentProfilePicture([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/profilepicture", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiProfilePictureRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentProfilePicture([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodythumbnailId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/profilepicture", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
                body["document_id"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> GetConstituentProspectStatus([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiProspectStatusRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> ListConstituentRatings([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> mostRecentOnly = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(mostRecentOnly, nameof(mostRecentOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/ratings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = SourceExpressionConverter.ConvertO(mostRecentOnly);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead> ListConstituentRelationships([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment> CreateConstituentAttachment([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField> CreateConstituentCustomField([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead> SearchConstituent([WorkflowExpression] Func<string> searchText, [WorkflowExpression] Func<string> fundraiserStatus = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<searchFieldInput> searchField = null, [WorkflowExpression] Func<bool> strictSearch = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(searchText, nameof(searchText), required: true);
            SourceExpression.Validate(fundraiserStatus, nameof(fundraiserStatus), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(searchField, nameof(searchField), required: false);
            SourceExpression.Validate(strictSearch, nameof(strictSearch), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = SourceExpressionConverter.ConvertO(fundraiserStatus);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (searchField != null)
                    callPayload.Queries["search_field"] = SourceExpressionConverter.Convert(searchField);
                if (strictSearch != null)
                    callPayload.Queries["strict_search"] = SourceExpressionConverter.ConvertO(strictSearch);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiFileDefinition> CreateDocument([WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<bool> bodyincludeThumbnail = null)
        {
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyincludeThumbnail, nameof(bodyincludeThumbnail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyincludeThumbnail != null)
                {
                    body["upload_thumbnail"] = SourceExpressionConverter.ConvertToken(bodyincludeThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiFileDefinition>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation> CreateConstituentEducation([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyschool, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyclassOf = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateEnteredday = null, [WorkflowExpression] Func<int> bodydateEnteredmonth = null, [WorkflowExpression] Func<int> bodydateEnteredyear = null, [WorkflowExpression] Func<int> bodydateLeftday = null, [WorkflowExpression] Func<int> bodydateLeftmonth = null, [WorkflowExpression] Func<int> bodydateLeftyear = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<double> bodygPA = null, [WorkflowExpression] Func<string> bodysubjectOfStudy = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string[]> bodymajors = null, [WorkflowExpression] Func<string[]> bodyminors = null, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodysocialOrganization = null, [WorkflowExpression] Func<string> bodyknownName = null, [WorkflowExpression] Func<string> bodyclassOfDegree = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<string> bodyregistrationNumber = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyschool, nameof(bodyschool), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            SourceExpression.Validate(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            SourceExpression.Validate(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            SourceExpression.Validate(bodydateLeftday, nameof(bodydateLeftday), required: false);
            SourceExpression.Validate(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            SourceExpression.Validate(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            SourceExpression.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            SourceExpression.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            SourceExpression.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            SourceExpression.Validate(bodydegree, nameof(bodydegree), required: false);
            SourceExpression.Validate(bodygPA, nameof(bodygPA), required: false);
            SourceExpression.Validate(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodymajors, nameof(bodymajors), required: false);
            SourceExpression.Validate(bodyminors, nameof(bodyminors), required: false);
            SourceExpression.Validate(bodycampus, nameof(bodycampus), required: false);
            SourceExpression.Validate(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            SourceExpression.Validate(bodyknownName, nameof(bodyknownName), required: false);
            SourceExpression.Validate(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyfaculty, nameof(bodyfaculty), required: false);
            SourceExpression.Validate(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/educations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["school"] = SourceExpressionConverter.ConvertToken(bodyschool);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_of"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = SourceExpressionConverter.ConvertToken(bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = SourceExpressionConverter.ConvertToken(bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = SourceExpressionConverter.ConvertToken(bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (bodydateLeftday != null)
                {
                    dateLeftObject["d"] = SourceExpressionConverter.ConvertToken(bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = SourceExpressionConverter.ConvertToken(bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = SourceExpressionConverter.ConvertToken(bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodygPA != null)
                {
                    body["gpa"] = SourceExpressionConverter.ConvertToken(bodygPA);
                    bodypropCount++;
                }

                if (bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = SourceExpressionConverter.ConvertToken(bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodymajors != null)
                {
                    body["majors"] = SourceExpressionConverter.ConvertToken(bodymajors);
                    bodypropCount++;
                }

                if (bodyminors != null)
                {
                    body["minors"] = SourceExpressionConverter.ConvertToken(bodyminors);
                    bodypropCount++;
                }

                if (bodycampus != null)
                {
                    body["campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodysocialOrganization != null)
                {
                    body["social_organization"] = SourceExpressionConverter.ConvertToken(bodysocialOrganization);
                    bodypropCount++;
                }

                if (bodyknownName != null)
                {
                    body["known_name"] = SourceExpressionConverter.ConvertToken(bodyknownName);
                    bodypropCount++;
                }

                if (bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = SourceExpressionConverter.ConvertToken(bodyclassOfDegree);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyregistrationNumber != null)
                {
                    body["registration_number"] = SourceExpressionConverter.ConvertToken(bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentEducation([WorkflowExpression] Func<string> educationId, [WorkflowExpression] Func<string> bodyschool = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyclassOf = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateEnteredday = null, [WorkflowExpression] Func<int> bodydateEnteredmonth = null, [WorkflowExpression] Func<int> bodydateEnteredyear = null, [WorkflowExpression] Func<int> bodydateLeftday = null, [WorkflowExpression] Func<int> bodydateLeftmonth = null, [WorkflowExpression] Func<int> bodydateLeftyear = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<double> bodygPA = null, [WorkflowExpression] Func<string> bodysubjectOfStudy = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string[]> bodymajors = null, [WorkflowExpression] Func<string[]> bodyminors = null, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodysocialOrganization = null, [WorkflowExpression] Func<string> bodyknownName = null, [WorkflowExpression] Func<string> bodyclassOfDegree = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<string> bodyregistrationNumber = null)
        {
            SourceExpression.Validate(educationId, nameof(educationId), required: true);
            SourceExpression.Validate(bodyschool, nameof(bodyschool), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            SourceExpression.Validate(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            SourceExpression.Validate(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            SourceExpression.Validate(bodydateLeftday, nameof(bodydateLeftday), required: false);
            SourceExpression.Validate(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            SourceExpression.Validate(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            SourceExpression.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            SourceExpression.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            SourceExpression.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            SourceExpression.Validate(bodydegree, nameof(bodydegree), required: false);
            SourceExpression.Validate(bodygPA, nameof(bodygPA), required: false);
            SourceExpression.Validate(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodymajors, nameof(bodymajors), required: false);
            SourceExpression.Validate(bodyminors, nameof(bodyminors), required: false);
            SourceExpression.Validate(bodycampus, nameof(bodycampus), required: false);
            SourceExpression.Validate(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            SourceExpression.Validate(bodyknownName, nameof(bodyknownName), required: false);
            SourceExpression.Validate(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyfaculty, nameof(bodyfaculty), required: false);
            SourceExpression.Validate(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/educations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyschool != null)
                {
                    body["school"] = SourceExpressionConverter.ConvertToken(bodyschool);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_of"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = SourceExpressionConverter.ConvertToken(bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = SourceExpressionConverter.ConvertToken(bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = SourceExpressionConverter.ConvertToken(bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (bodydateLeftday != null)
                {
                    dateLeftObject["d"] = SourceExpressionConverter.ConvertToken(bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = SourceExpressionConverter.ConvertToken(bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = SourceExpressionConverter.ConvertToken(bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodygPA != null)
                {
                    body["gpa"] = SourceExpressionConverter.ConvertToken(bodygPA);
                    bodypropCount++;
                }

                if (bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = SourceExpressionConverter.ConvertToken(bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodymajors != null)
                {
                    body["majors"] = SourceExpressionConverter.ConvertToken(bodymajors);
                    bodypropCount++;
                }

                if (bodyminors != null)
                {
                    body["minors"] = SourceExpressionConverter.ConvertToken(bodyminors);
                    bodypropCount++;
                }

                if (bodycampus != null)
                {
                    body["campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodysocialOrganization != null)
                {
                    body["social_organization"] = SourceExpressionConverter.ConvertToken(bodysocialOrganization);
                    bodypropCount++;
                }

                if (bodyknownName != null)
                {
                    body["known_name"] = SourceExpressionConverter.ConvertToken(bodyknownName);
                    bodypropCount++;
                }

                if (bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = SourceExpressionConverter.ConvertToken(bodyclassOfDegree);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyregistrationNumber != null)
                {
                    body["registration_number"] = SourceExpressionConverter.ConvertToken(bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress> CreateConstituentEmailAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyemailType, [WorkflowExpression] Func<string> bodyemailAddress, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyemailType, nameof(bodyemailType), required: true);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(emailAddressId, nameof(emailAddressId), required: true);
            SourceExpression.Validate(bodyemailType, nameof(bodyemailType), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/emailaddresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemailType != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentNote> CreateConstituentNote([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodydateday, nameof(bodydateday), required: false);
            SourceExpression.Validate(bodydatemonth, nameof(bodydatemonth), required: false);
            SourceExpression.Validate(bodydateyear, nameof(bodydateyear), required: false);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentNote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentNote([WorkflowExpression] Func<string> noteId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            SourceExpression.Validate(noteId, nameof(noteId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodydateday, nameof(bodydateday), required: false);
            SourceExpression.Validate(bodydatemonth, nameof(bodydatemonth), required: false);
            SourceExpression.Validate(bodydateyear, nameof(bodydateyear), required: false);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/notes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(noteId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence> CreateConstituentOnlinePresence([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodylink, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/onlinepresences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodylink);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentOnlinePresence([WorkflowExpression] Func<string> onlinePresenceId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(onlinePresenceId, nameof(onlinePresenceId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/onlinepresences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(onlinePresenceId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone> CreateConstituentPhone([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentPhone([WorkflowExpression] Func<string> phoneId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(phoneId, nameof(phoneId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/phones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> CreateConstituentRating([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/ratings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditConstituentRelationship([WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisSpouse = null, [WorkflowExpression] Func<bool> bodyisConstituentHeadOfHousehold = null, [WorkflowExpression] Func<bool> bodyisSpouseHeadOfHousehold = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyisContact = null, [WorkflowExpression] Func<bool> bodyisPrimaryBusiness = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodyposition = null)
        {
            SourceExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            SourceExpression.Validate(bodystartday, nameof(bodystartday), required: false);
            SourceExpression.Validate(bodystartmonth, nameof(bodystartmonth), required: false);
            SourceExpression.Validate(bodystartyear, nameof(bodystartyear), required: false);
            SourceExpression.Validate(bodyendday, nameof(bodyendday), required: false);
            SourceExpression.Validate(bodyendmonth, nameof(bodyendmonth), required: false);
            SourceExpression.Validate(bodyendyear, nameof(bodyendyear), required: false);
            SourceExpression.Validate(bodyisSpouse, nameof(bodyisSpouse), required: false);
            SourceExpression.Validate(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            SourceExpression.Validate(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyisContact, nameof(bodyisContact), required: false);
            SourceExpression.Validate(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/relationships/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisSpouse != null)
                {
                    body["is_spouse"] = SourceExpressionConverter.ConvertToken(bodyisSpouse);
                    bodypropCount++;
                }

                if (bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyisContact != null)
                {
                    body["is_organization_contact"] = SourceExpressionConverter.ConvertToken(bodyisContact);
                    bodypropCount++;
                }

                if (bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["organization_contact_type"] = SourceExpressionConverter.ConvertToken(bodycontactType);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent> CreateIndividualConstituent([WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyaddresstype, [WorkflowExpression] Func<string> bodyphonetype, [WorkflowExpression] Func<string> bodyphonenumber, [WorkflowExpression] Func<string> bodyemailtype, [WorkflowExpression] Func<string> bodyemailaddress, [WorkflowExpression] Func<string> bodyonlinePresencetype, [WorkflowExpression] Func<string> bodyonlinePresenceaddress, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddresssuburb = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddressstart = null, [WorkflowExpression] Func<string> bodyaddressend = null, [WorkflowExpression] Func<bool> bodyphoneisPrimary = null, [WorkflowExpression] Func<bool> bodyemailisPrimary = null, [WorkflowExpression] Func<bool> bodyonlinePresenceisPrimary = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyformerName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<string> bodybirthplace = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<string> bodyincome = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<bool> bodyprimaryAddresseecustomAddressee = null, [WorkflowExpression] Func<string> bodyprimaryAddresseeaddresseeFormat = null, [WorkflowExpression] Func<string> bodyprimaryAddresseeaddresseeCustomName = null, [WorkflowExpression] Func<bool> bodyprimarySalutationcustomSalutation = null, [WorkflowExpression] Func<string> bodyprimarySalutationsalutationFormat = null, [WorkflowExpression] Func<string> bodyprimarySalutationsalutationCustomName = null)
        {
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodyaddresstype, nameof(bodyaddresstype), required: true);
            SourceExpression.Validate(bodyphonetype, nameof(bodyphonetype), required: true);
            SourceExpression.Validate(bodyphonenumber, nameof(bodyphonenumber), required: true);
            SourceExpression.Validate(bodyemailtype, nameof(bodyemailtype), required: true);
            SourceExpression.Validate(bodyemailaddress, nameof(bodyemailaddress), required: true);
            SourceExpression.Validate(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            SourceExpression.Validate(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodysuffix, nameof(bodysuffix), required: false);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresslines, nameof(bodyaddresslines), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            SourceExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            SourceExpression.Validate(bodyaddressstart, nameof(bodyaddressstart), required: false);
            SourceExpression.Validate(bodyaddressend, nameof(bodyaddressend), required: false);
            SourceExpression.Validate(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            SourceExpression.Validate(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            SourceExpression.Validate(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            SourceExpression.Validate(bodypreferredName, nameof(bodypreferredName), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodyformerName, nameof(bodyformerName), required: false);
            SourceExpression.Validate(bodytitle2, nameof(bodytitle2), required: false);
            SourceExpression.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            SourceExpression.Validate(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            SourceExpression.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            SourceExpression.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            SourceExpression.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            SourceExpression.Validate(bodybirthplace, nameof(bodybirthplace), required: false);
            SourceExpression.Validate(bodyethnicity, nameof(bodyethnicity), required: false);
            SourceExpression.Validate(bodyincome, nameof(bodyincome), required: false);
            SourceExpression.Validate(bodyreligion, nameof(bodyreligion), required: false);
            SourceExpression.Validate(bodyprimaryAddresseecustomAddressee, nameof(bodyprimaryAddresseecustomAddressee), required: false);
            SourceExpression.Validate(bodyprimaryAddresseeaddresseeFormat, nameof(bodyprimaryAddresseeaddresseeFormat), required: false);
            SourceExpression.Validate(bodyprimaryAddresseeaddresseeCustomName, nameof(bodyprimaryAddresseeaddresseeCustomName), required: false);
            SourceExpression.Validate(bodyprimarySalutationcustomSalutation, nameof(bodyprimarySalutationcustomSalutation), required: false);
            SourceExpression.Validate(bodyprimarySalutationsalutationFormat, nameof(bodyprimarySalutationsalutationFormat), required: false);
            SourceExpression.Validate(bodyprimarySalutationsalutationCustomName, nameof(bodyprimarySalutationsalutationCustomName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Individual";
                bodypropCount++;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = SourceExpressionConverter.ConvertToken(bodyaddresstype);
                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresslines != null)
                {
                    addressObject["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = SourceExpressionConverter.ConvertToken(bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddressstart != null)
                {
                    addressObject["start"] = SourceExpressionConverter.ConvertToken(bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (bodyaddressend != null)
                {
                    addressObject["end"] = SourceExpressionConverter.ConvertToken(bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = SourceExpressionConverter.ConvertToken(bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = SourceExpressionConverter.ConvertToken(bodyphonenumber);
                if (bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = SourceExpressionConverter.ConvertToken(bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = SourceExpressionConverter.ConvertToken(bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = SourceExpressionConverter.ConvertToken(bodyemailaddress);
                if (bodyemailisPrimary != null)
                {
                    emailObject["primary"] = SourceExpressionConverter.ConvertToken(bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = SourceExpressionConverter.ConvertToken(bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceaddress);
                if (bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferred_name"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyformerName != null)
                {
                    body["former_name"] = SourceExpressionConverter.ConvertToken(bodyformerName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (bodybirthdateday != null)
                {
                    birthdateObject["d"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdateyear != null)
                {
                    birthdateObject["y"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (bodybirthplace != null)
                {
                    body["birthplace"] = SourceExpressionConverter.ConvertToken(bodybirthplace);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodyincome != null)
                {
                    body["income"] = SourceExpressionConverter.ConvertToken(bodyincome);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                var primaryAddresseeObject = new JObject();
                var primaryAddresseeObjectpropCount = 0;
                if (bodyprimaryAddresseecustomAddressee != null)
                {
                    primaryAddresseeObject["custom_format"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseecustomAddressee);
                    primaryAddresseeObjectpropCount++;
                }

                if (bodyprimaryAddresseeaddresseeFormat != null)
                {
                    primaryAddresseeObject["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseeaddresseeFormat);
                    primaryAddresseeObjectpropCount++;
                }

                if (bodyprimaryAddresseeaddresseeCustomName != null)
                {
                    primaryAddresseeObject["formatted_name"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseeaddresseeCustomName);
                    primaryAddresseeObjectpropCount++;
                }

                if (primaryAddresseeObjectpropCount > 0)
                {
                    body["primary_addressee"] = primaryAddresseeObject;
                    bodypropCount++;
                }

                var primarySalutationObject = new JObject();
                var primarySalutationObjectpropCount = 0;
                if (bodyprimarySalutationcustomSalutation != null)
                {
                    primarySalutationObject["custom_format"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationcustomSalutation);
                    primarySalutationObjectpropCount++;
                }

                if (bodyprimarySalutationsalutationFormat != null)
                {
                    primarySalutationObject["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationsalutationFormat);
                    primarySalutationObjectpropCount++;
                }

                if (bodyprimarySalutationsalutationCustomName != null)
                {
                    primarySalutationObject["formatted_name"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationsalutationCustomName);
                    primarySalutationObjectpropCount++;
                }

                if (primarySalutationObjectpropCount > 0)
                {
                    body["primary_salutation"] = primarySalutationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship> CreateIndividualRelationship([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyrelationId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisSpouse = null, [WorkflowExpression] Func<bool> bodyisConstituentHeadOfHousehold = null, [WorkflowExpression] Func<bool> bodyisSpouseHeadOfHousehold = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyrelationId, nameof(bodyrelationId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            SourceExpression.Validate(bodystartday, nameof(bodystartday), required: false);
            SourceExpression.Validate(bodystartmonth, nameof(bodystartmonth), required: false);
            SourceExpression.Validate(bodystartyear, nameof(bodystartyear), required: false);
            SourceExpression.Validate(bodyendday, nameof(bodyendday), required: false);
            SourceExpression.Validate(bodyendmonth, nameof(bodyendmonth), required: false);
            SourceExpression.Validate(bodyendyear, nameof(bodyendyear), required: false);
            SourceExpression.Validate(bodyisSpouse, nameof(bodyisSpouse), required: false);
            SourceExpression.Validate(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            SourceExpression.Validate(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/individualrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = SourceExpressionConverter.ConvertToken(bodyrelationId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisSpouse != null)
                {
                    body["is_spouse"] = SourceExpressionConverter.ConvertToken(bodyisSpouse);
                    bodypropCount++;
                }

                if (bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent> CreateOrganizationConstituent([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyaddresstype, [WorkflowExpression] Func<string> bodyphonetype, [WorkflowExpression] Func<string> bodyphonenumber, [WorkflowExpression] Func<string> bodyemailtype, [WorkflowExpression] Func<string> bodyemailaddress, [WorkflowExpression] Func<string> bodyonlinePresencetype, [WorkflowExpression] Func<string> bodyonlinePresenceaddress, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddresssuburb = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddressstart = null, [WorkflowExpression] Func<string> bodyaddressend = null, [WorkflowExpression] Func<bool> bodyphoneisPrimary = null, [WorkflowExpression] Func<bool> bodyemailisPrimary = null, [WorkflowExpression] Func<bool> bodyonlinePresenceisPrimary = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynumberOfEmployees = null, [WorkflowExpression] Func<bool> bodymatchesGifts = null, [WorkflowExpression] Func<double> bodymatchingGiftFactor = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMinminMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMinminMatchPerConstit = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, [WorkflowExpression] Func<string> bodymatchingGiftNotes = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyaddresstype, nameof(bodyaddresstype), required: true);
            SourceExpression.Validate(bodyphonetype, nameof(bodyphonetype), required: true);
            SourceExpression.Validate(bodyphonenumber, nameof(bodyphonenumber), required: true);
            SourceExpression.Validate(bodyemailtype, nameof(bodyemailtype), required: true);
            SourceExpression.Validate(bodyemailaddress, nameof(bodyemailaddress), required: true);
            SourceExpression.Validate(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            SourceExpression.Validate(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresslines, nameof(bodyaddresslines), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            SourceExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            SourceExpression.Validate(bodyaddressstart, nameof(bodyaddressstart), required: false);
            SourceExpression.Validate(bodyaddressend, nameof(bodyaddressend), required: false);
            SourceExpression.Validate(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            SourceExpression.Validate(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            SourceExpression.Validate(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            SourceExpression.Validate(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            SourceExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            SourceExpression.Validate(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            SourceExpression.Validate(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            SourceExpression.Validate(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            SourceExpression.Validate(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            SourceExpression.Validate(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            SourceExpression.Validate(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            SourceExpression.Validate(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            SourceExpression.Validate(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Organization";
                bodypropCount++;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = SourceExpressionConverter.ConvertToken(bodyaddresstype);
                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresslines != null)
                {
                    addressObject["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = SourceExpressionConverter.ConvertToken(bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddressstart != null)
                {
                    addressObject["start"] = SourceExpressionConverter.ConvertToken(bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (bodyaddressend != null)
                {
                    addressObject["end"] = SourceExpressionConverter.ConvertToken(bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = SourceExpressionConverter.ConvertToken(bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = SourceExpressionConverter.ConvertToken(bodyphonenumber);
                if (bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = SourceExpressionConverter.ConvertToken(bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = SourceExpressionConverter.ConvertToken(bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = SourceExpressionConverter.ConvertToken(bodyemailaddress);
                if (bodyemailisPrimary != null)
                {
                    emailObject["primary"] = SourceExpressionConverter.ConvertToken(bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = SourceExpressionConverter.ConvertToken(bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceaddress);
                if (bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynumberOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (bodymatchesGifts != null)
                {
                    body["matches_gifts"] = SourceExpressionConverter.ConvertToken(bodymatchesGifts);
                    bodypropCount++;
                }

                if (bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship> CreateOrganizationRelationship([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyrelationId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisContact = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bool> bodyisPrimaryBusiness = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyrelationId, nameof(bodyrelationId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            SourceExpression.Validate(bodystartday, nameof(bodystartday), required: false);
            SourceExpression.Validate(bodystartmonth, nameof(bodystartmonth), required: false);
            SourceExpression.Validate(bodystartyear, nameof(bodystartyear), required: false);
            SourceExpression.Validate(bodyendday, nameof(bodyendday), required: false);
            SourceExpression.Validate(bodyendmonth, nameof(bodyendmonth), required: false);
            SourceExpression.Validate(bodyendyear, nameof(bodyendyear), required: false);
            SourceExpression.Validate(bodyisContact, nameof(bodyisContact), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = SourceExpressionConverter.ConvertToken(bodyrelationId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisContact != null)
                {
                    body["is_organization_contact"] = SourceExpressionConverter.ConvertToken(bodyisContact);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["organization_contact_type"] = SourceExpressionConverter.ConvertToken(bodycontactType);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry> ListEvents([WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> startDateFrom = null, [WorkflowExpression] Func<string> startDateTo = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> eventId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(startDateFrom, nameof(startDateFrom), required: false);
            SourceExpression.Validate(startDateTo, nameof(startDateTo), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(eventId, nameof(eventId), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/eventlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (startDateFrom != null)
                    callPayload.Queries["start_date_from"] = SourceExpressionConverter.ConvertO(startDateFrom);
                if (startDateTo != null)
                    callPayload.Queries["start_date_to"] = SourceExpressionConverter.ConvertO(startDateTo);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (eventId != null)
                    callPayload.Queries["event_id"] = SourceExpressionConverter.ConvertO(eventId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEvent> CreateEvent([WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: true);
            SourceExpression.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodycapacity, nameof(bodycapacity), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/v1/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = SourceExpressionConverter.ConvertToken(bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodycapacity != null)
                {
                    body["capacity"] = SourceExpressionConverter.ConvertToken(bodycapacity);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiEvent> GetEvent([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiEvent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodycategorycategory, [WorkflowExpression] Func<string> bodyeventName = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<int> bodycapacity = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodycategorycategory, nameof(bodycategorycategory), required: true);
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodycapacity, nameof(bodycapacity), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = SourceExpressionConverter.ConvertToken(bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodycapacity != null)
                {
                    body["capacity"] = SourceExpressionConverter.ConvertToken(bodycapacity);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee> ListEventFees([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventFee> CreateEventFee([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            SourceExpression.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventfees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["cost"] = SourceExpressionConverter.ConvertToken(bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = SourceExpressionConverter.ConvertToken(bodycontributionAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedEventFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption> ListEventParticipantOptions([WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption> CreateEventParticipantOption([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyinputTypeInput> bodyinputType, [WorkflowExpression] Func<bool> bodyallowMultiSelect = null, [WorkflowExpression] Func<EventApiCreateParticipantOptionListOption[]> bodylistOptions = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyinputType, nameof(bodyinputType), required: true);
            SourceExpression.Validate(bodyallowMultiSelect, nameof(bodyallowMultiSelect), required: false);
            SourceExpression.Validate(bodylistOptions, nameof(bodylistOptions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/eventparticipantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["input_type"] = SourceExpressionConverter.Convert(bodyinputType);
                if (bodyallowMultiSelect != null)
                {
                    body["multi_select"] = SourceExpressionConverter.ConvertToken(bodyallowMultiSelect);
                    bodypropCount++;
                }

                if (bodylistOptions != null)
                {
                    body["list_options"] = SourceExpressionConverter.ConvertToken(bodylistOptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedEventParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry> ListEventParticipants([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<rsvpStatusInput> rsvpStatus = null, [WorkflowExpression] Func<invitationStatusInput> invitationStatus = null, [WorkflowExpression] Func<string> participationLevel = null, [WorkflowExpression] Func<bool> attendedFilter = null, [WorkflowExpression] Func<bool> feesPaidFilter = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> isConstituentFilter = null, [WorkflowExpression] Func<bool> emailEligibleFilter = null, [WorkflowExpression] Func<bool> phoneCallEligibleFilter = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(rsvpStatus, nameof(rsvpStatus), required: false);
            SourceExpression.Validate(invitationStatus, nameof(invitationStatus), required: false);
            SourceExpression.Validate(participationLevel, nameof(participationLevel), required: false);
            SourceExpression.Validate(attendedFilter, nameof(attendedFilter), required: false);
            SourceExpression.Validate(feesPaidFilter, nameof(feesPaidFilter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(isConstituentFilter, nameof(isConstituentFilter), required: false);
            SourceExpression.Validate(emailEligibleFilter, nameof(emailEligibleFilter), required: false);
            SourceExpression.Validate(phoneCallEligibleFilter, nameof(phoneCallEligibleFilter), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (rsvpStatus != null)
                    callPayload.Queries["rsvp_status"] = SourceExpressionConverter.Convert(rsvpStatus);
                if (invitationStatus != null)
                    callPayload.Queries["invitation_status"] = SourceExpressionConverter.Convert(invitationStatus);
                if (participationLevel != null)
                    callPayload.Queries["participation_level"] = SourceExpressionConverter.ConvertO(participationLevel);
                if (attendedFilter != null)
                    callPayload.Queries["attended_filter"] = SourceExpressionConverter.ConvertO(attendedFilter);
                if (feesPaidFilter != null)
                    callPayload.Queries["fees_paid_filter"] = SourceExpressionConverter.ConvertO(feesPaidFilter);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (isConstituentFilter != null)
                    callPayload.Queries["is_constituent_filter"] = SourceExpressionConverter.ConvertO(isConstituentFilter);
                if (emailEligibleFilter != null)
                    callPayload.Queries["email_eligible_filter"] = SourceExpressionConverter.ConvertO(emailEligibleFilter);
                if (phoneCallEligibleFilter != null)
                    callPayload.Queries["phone_call_eligible_filter"] = SourceExpressionConverter.ConvertO(phoneCallEligibleFilter);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipant> CreateParticipant([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyhostId = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null)
        {
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            SourceExpression.Validate(bodyhostId, nameof(bodyhostId), required: false);
            SourceExpression.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            SourceExpression.Validate(bodyattended, nameof(bodyattended), required: false);
            SourceExpression.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            SourceExpression.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            SourceExpression.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            SourceExpression.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            SourceExpression.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            SourceExpression.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            SourceExpression.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/events/{0}/participants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodyhostId != null)
                {
                    body["host_id"] = SourceExpressionConverter.ConvertToken(bodyhostId);
                    bodypropCount++;
                }

                if (bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = SourceExpressionConverter.Convert(bodyrSVPStatus);
                    bodypropCount++;
                }

                if (bodyattended != null)
                {
                    body["attended"] = SourceExpressionConverter.ConvertToken(bodyattended);
                    bodypropCount++;
                }

                if (bodyinvitationStatus != null)
                {
                    body["invitation_status"] = SourceExpressionConverter.Convert(bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = SourceExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditParticipantOption([WorkflowExpression] Func<string> optionId, [WorkflowExpression] Func<string> bodyvalue)
        {
            SourceExpression.Validate(optionId, nameof(optionId), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participantoptions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(optionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["option_value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiParticipant> GetParticipant([WorkflowExpression] Func<string> participantId)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiParticipant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditParticipant([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyparticipationLevelparticipationLevel, [WorkflowExpression] Func<string> bodyconstituentId = null, [WorkflowExpression] Func<string> bodyhostId = null, [WorkflowExpression] Func<bodyrSVPStatusInput> bodyrSVPStatus = null, [WorkflowExpression] Func<bool> bodyattended = null, [WorkflowExpression] Func<bodyinvitationStatusInput> bodyinvitationStatus = null, [WorkflowExpression] Func<int> bodyrSVPDateday = null, [WorkflowExpression] Func<int> bodyrSVPDatemonth = null, [WorkflowExpression] Func<int> bodyrSVPDateyear = null, [WorkflowExpression] Func<int> bodyinvitationDateday = null, [WorkflowExpression] Func<int> bodyinvitationDatemonth = null, [WorkflowExpression] Func<int> bodyinvitationDateyear = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: false);
            SourceExpression.Validate(bodyhostId, nameof(bodyhostId), required: false);
            SourceExpression.Validate(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            SourceExpression.Validate(bodyattended, nameof(bodyattended), required: false);
            SourceExpression.Validate(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            SourceExpression.Validate(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            SourceExpression.Validate(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            SourceExpression.Validate(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            SourceExpression.Validate(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            SourceExpression.Validate(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            SourceExpression.Validate(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconstituentId != null)
                {
                    body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                    bodypropCount++;
                }

                if (bodyhostId != null)
                {
                    body["host_id"] = SourceExpressionConverter.ConvertToken(bodyhostId);
                    bodypropCount++;
                }

                if (bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = SourceExpressionConverter.Convert(bodyrSVPStatus);
                    bodypropCount++;
                }

                if (bodyattended != null)
                {
                    body["attended"] = SourceExpressionConverter.ConvertToken(bodyattended);
                    bodypropCount++;
                }

                if (bodyinvitationStatus != null)
                {
                    body["invitation_status"] = SourceExpressionConverter.Convert(bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = SourceExpressionConverter.ConvertToken(bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation> ListParticipantDonations([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation> CreateParticipantDonation([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftId)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodygiftId, nameof(bodygiftId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/donations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantDonation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment> ListParticipantFeePayments([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment> CreateParticipantFeePayment([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodygiftId, [WorkflowExpression] Func<double> bodyappliedAmount)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodygiftId, nameof(bodygiftId), required: true);
            SourceExpression.Validate(bodyappliedAmount, nameof(bodyappliedAmount), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/feepayments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["applied_amount"] = SourceExpressionConverter.ConvertToken(bodyappliedAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee> ListParticipantFees([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee> CreateParticipantFee([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventId, [WorkflowExpression] Func<string> bodyfee, [WorkflowExpression] Func<int> bodyquantity, [WorkflowExpression] Func<double> bodyfeeAmount, [WorkflowExpression] Func<double> bodycontributionAmount, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyeventId, nameof(bodyeventId), required: true);
            SourceExpression.Validate(bodyfee, nameof(bodyfee), required: true);
            SourceExpression.Validate(bodyquantity, nameof(bodyquantity), required: true);
            SourceExpression.Validate(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            SourceExpression.Validate(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            SourceExpression.Validate(bodydateday, nameof(bodydateday), required: false);
            SourceExpression.Validate(bodydatemonth, nameof(bodydatemonth), required: false);
            SourceExpression.Validate(bodydateyear, nameof(bodydateyear), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/fees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                bodypropCount++;
                body["event_fee_id"] = SourceExpressionConverter.ConvertToken(bodyfee);
                bodypropCount++;
                body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
                bodypropCount++;
                body["fee_amount"] = SourceExpressionConverter.ConvertToken(bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = SourceExpressionConverter.ConvertToken(bodycontributionAmount);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantFee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption> ListParticipantOptions([WorkflowExpression] Func<string> participantId)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption> CreateParticipantOption([WorkflowExpression] Func<string> participantId, [WorkflowExpression] Func<string> bodyeventId, [WorkflowExpression] Func<string> bodyoption, [WorkflowExpression] Func<object> bodyoptionValue)
        {
            SourceExpression.Validate(participantId, nameof(participantId), required: true);
            SourceExpression.Validate(bodyeventId, nameof(bodyeventId), required: true);
            SourceExpression.Validate(bodyoption, nameof(bodyoption), required: true);
            SourceExpression.Validate(bodyoptionValue, nameof(bodyoptionValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/v1/participants/{0}/participantoptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(participantId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                bodypropCount++;
                body["event_participant_option_id"] = SourceExpressionConverter.ConvertToken(bodyoption);
                bodypropCount++;
                body["option_value"] = SourceExpressionConverter.ConvertToken(bodyoptionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EventApiCreatedParticipantOption>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealRead> ListAppeals([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/appeals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiAppealRead> GetAppeal([WorkflowExpression] Func<string> appealId)
        {
            SourceExpression.Validate(appealId, nameof(appealId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/appeals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiAppealRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealAttachmentRead> ListAppealAttachments([WorkflowExpression] Func<string> appealId)
        {
            SourceExpression.Validate(appealId, nameof(appealId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/appeals/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealCustomFieldRead> ListAppealCustomFields([WorkflowExpression] Func<string> appealId)
        {
            SourceExpression.Validate(appealId, nameof(appealId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/appeals/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealAttachment> CreateAppealAttachment([WorkflowExpression] Func<string> bodyappealId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodyappealId, nameof(bodyappealId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/appeals/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedAppealAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditAppealAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/appeals/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealCustomField> CreateAppealCustomField([WorkflowExpression] Func<string> bodyappealId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyappealId, nameof(bodyappealId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/appeals/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedAppealCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditAppealCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/appeals/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignRead> ListCampaigns([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCampaignRead> GetCampaign([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCampaignRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignAttachmentRead> ListCampaignAttachments([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/campaigns/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead> ListCampaignCustomFields([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/campaigns/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignAttachment> CreateCampaignAttachment([WorkflowExpression] Func<string> bodycampaignId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/campaigns/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedCampaignAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditCampaignAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/campaigns/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignCustomField> CreateCampaignCustomField([WorkflowExpression] Func<string> bodycampaignId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/campaigns/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedCampaignCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditCampaignCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/campaigns/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment> CreateFundraiserAssignment([WorkflowExpression] Func<string> bodyfundraiserId, [WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<double> bodyamountamount, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyassignmentStarts = null, [WorkflowExpression] Func<string> bodyassignmentEnds = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<string> bodyappealId = null)
        {
            SourceExpression.Validate(bodyfundraiserId, nameof(bodyfundraiserId), required: true);
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyamountamount, nameof(bodyamountamount), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyassignmentStarts, nameof(bodyassignmentStarts), required: false);
            SourceExpression.Validate(bodyassignmentEnds, nameof(bodyassignmentEnds), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: false);
            SourceExpression.Validate(bodyappealId, nameof(bodyappealId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/fundraisers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodyfundraiserId);
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyassignmentStarts != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyassignmentStarts);
                    bodypropCount++;
                }

                if (bodyassignmentEnds != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyassignmentEnds);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyappealId != null)
                {
                    body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead> ListFundraiserAssignments([WorkflowExpression] Func<string> fundraiserId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(fundraiserId, nameof(fundraiserId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/fundraisers/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundRead> ListFunds([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/funds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiFundRead> GetFund([WorkflowExpression] Func<string> fundId)
        {
            SourceExpression.Validate(fundId, nameof(fundId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/funds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiFundRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundAttachmentRead> ListFundAttachments([WorkflowExpression] Func<string> fundId)
        {
            SourceExpression.Validate(fundId, nameof(fundId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/funds/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundCustomFieldRead> ListFundCustomFields([WorkflowExpression] Func<string> fundId)
        {
            SourceExpression.Validate(fundId, nameof(fundId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/funds/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundAttachment> CreateFundAttachment([WorkflowExpression] Func<string> bodyfundId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/funds/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditFundAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/funds/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundCustomField> CreateFundCustomField([WorkflowExpression] Func<string> bodyfundId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/funds/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditFundCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/funds/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfPackageRead> ListPackages([WorkflowExpression] Func<string> appealId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(appealId, nameof(appealId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (appealId != null)
                    callPayload.Queries["appeal_id"] = SourceExpressionConverter.ConvertO(appealId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfPackageRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiPackageRead> GetPackage([WorkflowExpression] Func<string> packageId)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/packages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiPackageRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftAcknowledgement([WorkflowExpression] Func<string> acknowledgementId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyletter = null)
        {
            SourceExpression.Validate(acknowledgementId, nameof(acknowledgementId), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyletter, nameof(bodyletter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/giftacknowledgements/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(acknowledgementId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyletter != null)
                {
                    body["letter"] = SourceExpressionConverter.ConvertToken(bodyletter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftReceipt([WorkflowExpression] Func<string> receiptId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<double> bodyamountvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodynumber = null)
        {
            SourceExpression.Validate(receiptId, nameof(receiptId), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyamountvalue, nameof(bodyamountvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/giftreceipts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(receiptId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountvalue != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountvalue);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead> ListGifts([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> giftType = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<string> campaignId = null, [WorkflowExpression] Func<string> fundId = null, [WorkflowExpression] Func<string> appealId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> startGiftDate = null, [WorkflowExpression] Func<string> endGiftDate = null, [WorkflowExpression] Func<double> startGiftAmount = null, [WorkflowExpression] Func<double> endGiftAmount = null, [WorkflowExpression] Func<string> postStatus = null, [WorkflowExpression] Func<string> receiptStatus = null, [WorkflowExpression] Func<string> acknowledgementStatus = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(giftType, nameof(giftType), required: false);
            SourceExpression.Validate(constituentId, nameof(constituentId), required: false);
            SourceExpression.Validate(campaignId, nameof(campaignId), required: false);
            SourceExpression.Validate(fundId, nameof(fundId), required: false);
            SourceExpression.Validate(appealId, nameof(appealId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(startGiftDate, nameof(startGiftDate), required: false);
            SourceExpression.Validate(endGiftDate, nameof(endGiftDate), required: false);
            SourceExpression.Validate(startGiftAmount, nameof(startGiftAmount), required: false);
            SourceExpression.Validate(endGiftAmount, nameof(endGiftAmount), required: false);
            SourceExpression.Validate(postStatus, nameof(postStatus), required: false);
            SourceExpression.Validate(receiptStatus, nameof(receiptStatus), required: false);
            SourceExpression.Validate(acknowledgementStatus, nameof(acknowledgementStatus), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (giftType != null)
                    callPayload.Queries["gift_type"] = SourceExpressionConverter.ConvertO(giftType);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (campaignId != null)
                    callPayload.Queries["campaign_id"] = SourceExpressionConverter.ConvertO(campaignId);
                if (fundId != null)
                    callPayload.Queries["fund_id"] = SourceExpressionConverter.ConvertO(fundId);
                if (appealId != null)
                    callPayload.Queries["appeal_id"] = SourceExpressionConverter.ConvertO(appealId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (startGiftDate != null)
                    callPayload.Queries["start_gift_date"] = SourceExpressionConverter.ConvertO(startGiftDate);
                if (endGiftDate != null)
                    callPayload.Queries["end_gift_date"] = SourceExpressionConverter.ConvertO(endGiftDate);
                if (startGiftAmount != null)
                    callPayload.Queries["start_gift_amount"] = SourceExpressionConverter.ConvertO(startGiftAmount);
                if (endGiftAmount != null)
                    callPayload.Queries["end_gift_amount"] = SourceExpressionConverter.ConvertO(endGiftAmount);
                if (postStatus != null)
                    callPayload.Queries["post_status"] = SourceExpressionConverter.ConvertO(postStatus);
                if (receiptStatus != null)
                    callPayload.Queries["receipt_status"] = SourceExpressionConverter.ConvertO(receiptStatus);
                if (acknowledgementStatus != null)
                    callPayload.Queries["acknowledgement_status"] = SourceExpressionConverter.ConvertO(acknowledgementStatus);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGift> CreateGift([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<GiftApiGiftSplitAdd[]> bodysplits, [WorkflowExpression] Func<bodyreceiptsreceiptStatusInput> bodyreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodyreceiptsamountreceiptAmount, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<bodypaymentspaymentMethodInput> bodypaymentspaymentMethod = null, [WorkflowExpression] Func<string> bodypaymentscheckNumber = null, [WorkflowExpression] Func<int> bodypaymentscheckDateday = null, [WorkflowExpression] Func<int> bodypaymentscheckDatemonth = null, [WorkflowExpression] Func<int> bodypaymentscheckDateyear = null, [WorkflowExpression] Func<string> bodypaymentsreference = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDateday = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDatemonth = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDateyear = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodysubtype = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<bool> bodyuseFundraiserCredits = null, [WorkflowExpression] Func<bool> bodyuseSoftCredits = null, [WorkflowExpression] Func<string> bodyconstituency = null, [WorkflowExpression] Func<string> bodybatchPrefix = null, [WorkflowExpression] Func<string> bodybatchNumber = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptDate = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodysplits, nameof(bodysplits), required: true);
            SourceExpression.Validate(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            SourceExpression.Validate(bodyreceiptsamountreceiptAmount, nameof(bodyreceiptsamountreceiptAmount), required: true);
            SourceExpression.Validate(bodyamountamount, nameof(bodyamountamount), required: false);
            SourceExpression.Validate(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            SourceExpression.Validate(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            SourceExpression.Validate(bodypaymentscheckDateday, nameof(bodypaymentscheckDateday), required: false);
            SourceExpression.Validate(bodypaymentscheckDatemonth, nameof(bodypaymentscheckDatemonth), required: false);
            SourceExpression.Validate(bodypaymentscheckDateyear, nameof(bodypaymentscheckDateyear), required: false);
            SourceExpression.Validate(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            SourceExpression.Validate(bodypaymentsreferenceDateday, nameof(bodypaymentsreferenceDateday), required: false);
            SourceExpression.Validate(bodypaymentsreferenceDatemonth, nameof(bodypaymentsreferenceDatemonth), required: false);
            SourceExpression.Validate(bodypaymentsreferenceDateyear, nameof(bodypaymentsreferenceDateyear), required: false);
            SourceExpression.Validate(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            SourceExpression.Validate(bodysubtype, nameof(bodysubtype), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodyuseFundraiserCredits, nameof(bodyuseFundraiserCredits), required: false);
            SourceExpression.Validate(bodyuseSoftCredits, nameof(bodyuseSoftCredits), required: false);
            SourceExpression.Validate(bodyconstituency, nameof(bodyconstituency), required: false);
            SourceExpression.Validate(bodybatchPrefix, nameof(bodybatchPrefix), required: false);
            SourceExpression.Validate(bodybatchNumber, nameof(bodybatchNumber), required: false);
            SourceExpression.Validate(bodypostStatus, nameof(bodypostStatus), required: false);
            SourceExpression.Validate(bodypostDate, nameof(bodypostDate), required: false);
            SourceExpression.Validate(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["gift_splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (bodypaymentspaymentMethod != null)
                {
                    if (bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["payment_method"] = SourceExpressionConverter.Convert(bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["payment_method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (bodypaymentscheckDateday != null)
                {
                    checkDateObject["d"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (bodypaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (bodypaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (bodypaymentsreference != null)
                {
                    paymentsObject["reference"] = SourceExpressionConverter.ConvertToken(bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (bodypaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (bodypaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (bodypaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["is_anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                if (bodysubtype != null)
                {
                    body["subtype"] = SourceExpressionConverter.ConvertToken(bodysubtype);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodyuseFundraiserCredits != null)
                {
                    body["default_fundraiser_credits"] = SourceExpressionConverter.ConvertToken(bodyuseFundraiserCredits);
                    bodypropCount++;
                }

                if (bodyuseSoftCredits != null)
                {
                    body["default_soft_credits"] = SourceExpressionConverter.ConvertToken(bodyuseSoftCredits);
                    bodypropCount++;
                }

                if (bodyconstituency != null)
                {
                    body["constituency"] = SourceExpressionConverter.ConvertToken(bodyconstituency);
                    bodypropCount++;
                }

                if (bodybatchPrefix != null)
                {
                    body["batch_prefix"] = SourceExpressionConverter.ConvertToken(bodybatchPrefix);
                    bodypropCount++;
                }

                if (bodybatchNumber != null)
                {
                    body["batch_number"] = SourceExpressionConverter.ConvertToken(bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = SourceExpressionConverter.Convert(bodyreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGift>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiGiftRead> GetGift([WorkflowExpression] Func<string> giftId)
        {
            SourceExpression.Validate(giftId, nameof(giftId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiGiftRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead> ListGiftAttachments([WorkflowExpression] Func<string> giftId)
        {
            SourceExpression.Validate(giftId, nameof(giftId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead> ListGiftCustomFields([WorkflowExpression] Func<string> giftId)
        {
            SourceExpression.Validate(giftId, nameof(giftId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment> CreateGiftAttachment([WorkflowExpression] Func<string> bodygiftId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodygiftId, nameof(bodygiftId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField> CreateGiftCustomField([WorkflowExpression] Func<string> bodygiftId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodygiftId, nameof(bodygiftId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditGiftCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiBatchGiftAddResults> AddGiftToBatch([WorkflowExpression] Func<string> batchId, [WorkflowExpression] Func<double> bodygiftsamountamount, [WorkflowExpression] Func<bodygiftspaymentspaymentMethodInput> bodygiftspaymentspaymentMethod, [WorkflowExpression] Func<bodygiftsreceiptsreceiptStatusInput> bodygiftsreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodygiftsreceiptsamountreceiptAmount, [WorkflowExpression] Func<string> bodygiftsconstituentId = null, [WorkflowExpression] Func<string> bodygiftsdate = null, [WorkflowExpression] Func<bodygiftstypeInput> bodygiftstype = null, [WorkflowExpression] Func<GiftApiVirtualBatchGiftSplitAdd[]> bodygiftssplits = null, [WorkflowExpression] Func<string> bodygiftspaymentscheckNumber = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDateday = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDatemonth = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDateyear = null, [WorkflowExpression] Func<string> bodygiftspaymentsreference = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDateday = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDatemonth = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDateyear = null, [WorkflowExpression] Func<bool> bodygiftsisAnonymous = null, [WorkflowExpression] Func<string> bodygiftssubtype = null, [WorkflowExpression] Func<string> bodygiftscomment = null, [WorkflowExpression] Func<string> bodygiftslookupId = null, [WorkflowExpression] Func<bool> bodygiftsuseFundraiserCredits = null, [WorkflowExpression] Func<bool> bodygiftsuseSoftCredits = null, [WorkflowExpression] Func<string> bodygiftsconstituency = null, [WorkflowExpression] Func<bodygiftspostStatusInput> bodygiftspostStatus = null, [WorkflowExpression] Func<string> bodygiftspostDate = null, [WorkflowExpression] Func<string> bodygiftsreceiptsreceiptDate = null)
        {
            SourceExpression.Validate(batchId, nameof(batchId), required: true);
            SourceExpression.Validate(bodygiftsamountamount, nameof(bodygiftsamountamount), required: true);
            SourceExpression.Validate(bodygiftspaymentspaymentMethod, nameof(bodygiftspaymentspaymentMethod), required: true);
            SourceExpression.Validate(bodygiftsreceiptsreceiptStatus, nameof(bodygiftsreceiptsreceiptStatus), required: true);
            SourceExpression.Validate(bodygiftsreceiptsamountreceiptAmount, nameof(bodygiftsreceiptsamountreceiptAmount), required: true);
            SourceExpression.Validate(bodygiftsconstituentId, nameof(bodygiftsconstituentId), required: false);
            SourceExpression.Validate(bodygiftsdate, nameof(bodygiftsdate), required: false);
            SourceExpression.Validate(bodygiftstype, nameof(bodygiftstype), required: false);
            SourceExpression.Validate(bodygiftssplits, nameof(bodygiftssplits), required: false);
            SourceExpression.Validate(bodygiftspaymentscheckNumber, nameof(bodygiftspaymentscheckNumber), required: false);
            SourceExpression.Validate(bodygiftspaymentscheckDateday, nameof(bodygiftspaymentscheckDateday), required: false);
            SourceExpression.Validate(bodygiftspaymentscheckDatemonth, nameof(bodygiftspaymentscheckDatemonth), required: false);
            SourceExpression.Validate(bodygiftspaymentscheckDateyear, nameof(bodygiftspaymentscheckDateyear), required: false);
            SourceExpression.Validate(bodygiftspaymentsreference, nameof(bodygiftspaymentsreference), required: false);
            SourceExpression.Validate(bodygiftspaymentsreferenceDateday, nameof(bodygiftspaymentsreferenceDateday), required: false);
            SourceExpression.Validate(bodygiftspaymentsreferenceDatemonth, nameof(bodygiftspaymentsreferenceDatemonth), required: false);
            SourceExpression.Validate(bodygiftspaymentsreferenceDateyear, nameof(bodygiftspaymentsreferenceDateyear), required: false);
            SourceExpression.Validate(bodygiftsisAnonymous, nameof(bodygiftsisAnonymous), required: false);
            SourceExpression.Validate(bodygiftssubtype, nameof(bodygiftssubtype), required: false);
            SourceExpression.Validate(bodygiftscomment, nameof(bodygiftscomment), required: false);
            SourceExpression.Validate(bodygiftslookupId, nameof(bodygiftslookupId), required: false);
            SourceExpression.Validate(bodygiftsuseFundraiserCredits, nameof(bodygiftsuseFundraiserCredits), required: false);
            SourceExpression.Validate(bodygiftsuseSoftCredits, nameof(bodygiftsuseSoftCredits), required: false);
            SourceExpression.Validate(bodygiftsconstituency, nameof(bodygiftsconstituency), required: false);
            SourceExpression.Validate(bodygiftspostStatus, nameof(bodygiftspostStatus), required: false);
            SourceExpression.Validate(bodygiftspostDate, nameof(bodygiftspostDate), required: false);
            SourceExpression.Validate(bodygiftsreceiptsreceiptDate, nameof(bodygiftsreceiptsreceiptDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/virtual/giftbatches/{0}/gifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(batchId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var giftsObject = new JObject();
                var giftsObjectpropCount = 0;
                if (bodygiftsconstituentId != null)
                {
                    giftsObject["constituent_id"] = SourceExpressionConverter.ConvertToken(bodygiftsconstituentId);
                    giftsObjectpropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftsamountamount);
                if (amountObjectpropCount > 0)
                {
                    giftsObject["amount"] = amountObject;
                    giftsObjectpropCount++;
                }

                if (bodygiftsdate != null)
                {
                    giftsObject["date"] = SourceExpressionConverter.ConvertToken(bodygiftsdate);
                    giftsObjectpropCount++;
                }

                if (bodygiftstype != null)
                {
                    giftsObject["type"] = SourceExpressionConverter.Convert(bodygiftstype);
                    giftsObjectpropCount++;
                }

                if (bodygiftssplits != null)
                {
                    giftsObject["gift_splits"] = SourceExpressionConverter.ConvertToken(bodygiftssplits);
                    giftsObjectpropCount++;
                }

                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                paymentsObjectpropCount++;
                paymentsObject["payment_method"] = SourceExpressionConverter.Convert(bodygiftspaymentspaymentMethod);
                if (bodygiftspaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (bodygiftspaymentscheckDateday != null)
                {
                    checkDateObject["d"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (bodygiftspaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (bodygiftspaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (bodygiftspaymentsreference != null)
                {
                    paymentsObject["reference"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (bodygiftspaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (bodygiftspaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (bodygiftspaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    giftsObject["payments"] = paymentsObject;
                    giftsObjectpropCount++;
                }

                if (bodygiftsisAnonymous != null)
                {
                    giftsObject["is_anonymous"] = SourceExpressionConverter.ConvertToken(bodygiftsisAnonymous);
                    giftsObjectpropCount++;
                }

                if (bodygiftssubtype != null)
                {
                    giftsObject["subtype"] = SourceExpressionConverter.ConvertToken(bodygiftssubtype);
                    giftsObjectpropCount++;
                }

                if (bodygiftscomment != null)
                {
                    giftsObject["reference"] = SourceExpressionConverter.ConvertToken(bodygiftscomment);
                    giftsObjectpropCount++;
                }

                if (bodygiftslookupId != null)
                {
                    giftsObject["lookup_id"] = SourceExpressionConverter.ConvertToken(bodygiftslookupId);
                    giftsObjectpropCount++;
                }

                if (bodygiftsuseFundraiserCredits != null)
                {
                    giftsObject["default_fundraiser_credits"] = SourceExpressionConverter.ConvertToken(bodygiftsuseFundraiserCredits);
                    giftsObjectpropCount++;
                }

                if (bodygiftsuseSoftCredits != null)
                {
                    giftsObject["default_soft_credits"] = SourceExpressionConverter.ConvertToken(bodygiftsuseSoftCredits);
                    giftsObjectpropCount++;
                }

                if (bodygiftsconstituency != null)
                {
                    giftsObject["constituency"] = SourceExpressionConverter.ConvertToken(bodygiftsconstituency);
                    giftsObjectpropCount++;
                }

                if (bodygiftspostStatus != null)
                {
                    giftsObject["post_status"] = SourceExpressionConverter.Convert(bodygiftspostStatus);
                    giftsObjectpropCount++;
                }

                if (bodygiftspostDate != null)
                {
                    giftsObject["post_date"] = SourceExpressionConverter.ConvertToken(bodygiftspostDate);
                    giftsObjectpropCount++;
                }

                giftsObject["origin"] = "{ \"name\": \"Power Platform\" }";
                giftsObjectpropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = SourceExpressionConverter.Convert(bodygiftsreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = SourceExpressionConverter.ConvertToken(bodygiftsreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (bodygiftsreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = SourceExpressionConverter.ConvertToken(bodygiftsreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    giftsObject["receipts"] = receiptsObject;
                    giftsObjectpropCount++;
                }

                if (giftsObjectpropCount > 0)
                {
                    body["gifts"] = giftsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiBatchGiftAddResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch> ListGiftBatches([WorkflowExpression] Func<string> batchNumber = null, [WorkflowExpression] Func<bool> approved = null, [WorkflowExpression] Func<bool> hasExceptions = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<string> createdBy = null)
        {
            SourceExpression.Validate(batchNumber, nameof(batchNumber), required: false);
            SourceExpression.Validate(approved, nameof(approved), required: false);
            SourceExpression.Validate(hasExceptions, nameof(hasExceptions), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(searchText, nameof(searchText), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (batchNumber != null)
                    callPayload.Queries["batch_number"] = SourceExpressionConverter.ConvertO(batchNumber);
                if (approved != null)
                    callPayload.Queries["approved"] = SourceExpressionConverter.ConvertO(approved);
                if (hasExceptions != null)
                    callPayload.Queries["has_exceptions"] = SourceExpressionConverter.ConvertO(hasExceptions);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (createdBy != null)
                    callPayload.Queries["created_by"] = SourceExpressionConverter.ConvertO(createdBy);
                return callPayload;
            }

            return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch> CreateGiftBatch([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyexpectedNumber = null, [WorkflowExpression] Func<double> bodyexpectedTotal = null, [WorkflowExpression] Func<string> bodybatchNumber = null)
        {
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyexpectedNumber, nameof(bodyexpectedNumber), required: false);
            SourceExpression.Validate(bodyexpectedTotal, nameof(bodyexpectedTotal), required: false);
            SourceExpression.Validate(bodybatchNumber, nameof(bodybatchNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["batch_description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpectedNumber != null)
                {
                    body["expected_number"] = SourceExpressionConverter.ConvertToken(bodyexpectedNumber);
                    bodypropCount++;
                }

                if (bodyexpectedTotal != null)
                {
                    body["expected_batch_total"] = SourceExpressionConverter.ConvertToken(bodyexpectedTotal);
                    bodypropCount++;
                }

                if (bodybatchNumber != null)
                {
                    body["batch_number"] = SourceExpressionConverter.ConvertToken(bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftBatchApiCreatedBatch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction AppendIDsToList([WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<string> bodylist, [WorkflowExpression] Func<string[]> bodyidS)
        {
            SourceExpression.Validate(bodylistType, nameof(bodylistType), required: true);
            SourceExpression.Validate(bodylist, nameof(bodylist), required: true);
            SourceExpression.Validate(bodyidS, nameof(bodyidS), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_type"] = SourceExpressionConverter.Convert(bodylistType);
                bodypropCount++;
                body["list_id"] = SourceExpressionConverter.ConvertToken(bodylist);
                bodypropCount++;
                body["ids"] = SourceExpressionConverter.ConvertToken(bodyidS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ListApiCreatedList> CreateListFromIDs([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<bodypermissionsInput> bodypermissions, [WorkflowExpression] Func<string[]> bodyidS)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodylistType, nameof(bodylistType), required: true);
            SourceExpression.Validate(bodypermissions, nameof(bodypermissions), required: true);
            SourceExpression.Validate(bodyidS, nameof(bodyidS), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["list_type"] = SourceExpressionConverter.Convert(bodylistType);
                bodypropCount++;
                body["list_permissions"] = SourceExpressionConverter.Convert(bodypermissions);
                bodypropCount++;
                body["ids"] = SourceExpressionConverter.ConvertToken(bodyidS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListApiCreatedList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> ListOpportunities([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: false);
            SourceExpression.Validate(constituentId, nameof(constituentId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            SourceExpression.Validate(dateAdded, nameof(dateAdded), required: false);
            SourceExpression.Validate(lastModified, nameof(lastModified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> CreateOpportunity([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodypurpose, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodypurpose, nameof(bodypurpose), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            SourceExpression.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            SourceExpression.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            SourceExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            SourceExpression.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            SourceExpression.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            SourceExpression.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["purpose"] = SourceExpressionConverter.ConvertToken(bodypurpose);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = SourceExpressionConverter.ConvertToken(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> GetOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiOpportunityRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<string> bodypurpose = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydeadline = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyaskAmountvalue = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<double> bodyexpectedAmountvalue = null, [WorkflowExpression] Func<string> bodyfundedDate = null, [WorkflowExpression] Func<double> bodyfundedAmountvalue = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<OpportunityApiFundraiser[]> bodyfundraiserS = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            SourceExpression.Validate(bodypurpose, nameof(bodypurpose), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            SourceExpression.Validate(bodyaskDate, nameof(bodyaskDate), required: false);
            SourceExpression.Validate(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            SourceExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            SourceExpression.Validate(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            SourceExpression.Validate(bodyfundedDate, nameof(bodyfundedDate), required: false);
            SourceExpression.Validate(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: false);
            SourceExpression.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypurpose != null)
                {
                    body["purpose"] = SourceExpressionConverter.ConvertToken(bodypurpose);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (bodyfundedDate != null)
                {
                    body["funded_date"] = SourceExpressionConverter.ConvertToken(bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> ListOpportunityAttachments([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> ListOpportunityCustomFields([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> CreateOpportunityAttachment([WorkflowExpression] Func<string> bodyopportunityId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null)
        {
            SourceExpression.Validate(bodyopportunityId, nameof(bodyopportunityId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunityAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> CreateOpportunityCustomField([WorkflowExpression] Func<string> bodyopportunityId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(bodyopportunityId, nameof(bodyopportunityId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunity/v1/opportunities/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction EditOpportunityCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class BlackbaudraisersedgeTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyresponseInput
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfActionRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionRead[] Value { get; set; }
    }

    public class ConstituentApiActionRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedOn { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Note { get; set; }

        [JsonProperty("direction")]
        public ConstituentApiActionReadDirectionType Direction { get; set; }

        [JsonProperty("fundraisers")]
        public string[] FundraiserS { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("opportunity_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("outcome")]
        public ConstituentApiActionReadOutcomeType Outcome { get; set; }

        [JsonProperty("priority")]
        public ConstituentApiActionReadPriorityType Priority { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("computed_status")]
        public ConstituentApiActionReadComputedStatusType ComputedStatus { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionReadDirectionType
    {
        Inbound,
        Outbound
    }

    public enum ConstituentApiActionReadOutcomeType
    {
        Successful,
        Unsuccessful
    }

    public enum ConstituentApiActionReadPriorityType
    {
        Normal,
        High,
        Low
    }

    public enum ConstituentApiActionReadComputedStatusType
    {
        Open,
        Completed,
        PastDue
    }

    public class ConstituentApiCreatedAction
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodycategoryInput
    {
        [EnumMember(Value = "Phone Call")]
        PhoneCall,
        Meeting,
        Mailing,
        Email,
        [EnumMember(Value = "Task/Other")]
        TaskOther
    }

    public enum bodydirectionInput
    {
        Inbound,
        Outbound
    }

    public enum bodyoutcomeInput
    {
        Successful,
        Unsuccessful
    }

    public enum bodypriorityInput
    {
        Normal,
        High,
        Low
    }

    public class ConstituentApiApiCollectionOfActionAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiActionAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum ConstituentApiActionAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfActionCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiActionCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiCreatedActionAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class ConstituentApiCreatedActionCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMinType MatchingGiftPerGiftMin { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMaxType MatchingGiftPerGiftMax { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMatchingGiftTotalMinType MatchingGiftTotalMin { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMatchingGiftTotalMaxType MatchingGiftTotalMax { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiGivingSummaryRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiGivingSummaryReadAmountType Amount { get; set; }

        [JsonProperty("appeals")]
        public ConstituentApiAppealRead[] Appeal { get; set; }

        [JsonProperty("campaigns")]
        public ConstituentApiCampaignRead[] Campaign { get; set; }

        [JsonProperty("funds")]
        public ConstituentApiFundRead[] Fund { get; set; }
    }

    public class ConstituentApiGivingSummaryReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiCampaignRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiFundRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiLifetimeGivingRead
    {
        [JsonProperty("consecutive_years_given")]
        public int ConsecutiveYearsGiven { get; set; }

        [JsonProperty("total_years_given")]
        public int TotalYearsGiven { get; set; }

        [JsonProperty("total_giving")]
        public ConstituentApiLifetimeGivingReadTotalGivingType TotalGiving { get; set; }

        [JsonProperty("total_pledge_balance")]
        public ConstituentApiLifetimeGivingReadTotalPledgeBalanceType TotalPledgeBalance { get; set; }

        [JsonProperty("total_received_giving")]
        public ConstituentApiLifetimeGivingReadTotalReceivedGivingType TotalReceivedGiving { get; set; }

        [JsonProperty("total_committed_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType TotalCommittedMatchingGifts { get; set; }

        [JsonProperty("total_received_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType TotalReceivedMatchingGifts { get; set; }

        [JsonProperty("total_soft_credits")]
        public ConstituentApiLifetimeGivingReadTotalSoftCreditsType TotalSoftCredits { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalPledgeBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalSoftCreditsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class ConstituentApiProspectStatusRead
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("days_elapsed")]
        public int DaysElapsed { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiApiCollectionOfRatingRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRatingRead[] Value { get; set; }
    }

    public class ConstituentApiRatingRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public JToken Description { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("type")]
        public ConstituentApiRatingReadTypeType Type { get; set; }
    }

    public enum ConstituentApiRatingReadTypeType
    {
        Text,
        Number,
        DateTime,
        Currency,
        Boolean,
        CodeTable,
        Unknown
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("relation_id")]
        public string RelationID { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }
    }

    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId
    }

    public class ConstituentApiFileDefinition
    {
        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("file_upload_request")]
        public ConstituentApiFileDefinitionFileUploadType FileUpload { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_upload_request")]
        public ConstituentApiFileDefinitionThumbnailUploadType ThumbnailUpload { get; set; }
    }

    public class ConstituentApiFileDefinitionFileUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ConstituentApiFileDefinitionThumbnailUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfEventListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventListEntry[] Value { get; set; }
    }

    public class EventApiEventListEntry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("attending_count")]
        public int Attending { get; set; }

        [JsonProperty("attended_count")]
        public int Attended { get; set; }

        [JsonProperty("invited_count")]
        public int Invited { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("percent_of_goal")]
        public int PercentOfGoal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiEventCategory
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiCreatedEvent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiEvent
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("location")]
        public EventApiLocation Location { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public EventApiLocality Locality { get; set; }

        [JsonProperty("administrative_area")]
        public EventApiAdministrativeArea AdministrativeArea { get; set; }

        [JsonProperty("sub_administrative_area")]
        public EventApiSubAdministrativeArea SubAdministrativeArea { get; set; }

        [JsonProperty("country")]
        public EventApiCountry Country { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }

    public class EventApiLocality
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiAdministrativeArea
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
    }

    public class EventApiSubAdministrativeArea
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiCountry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("iso_alpha2_code")]
        public string ISOCode { get; set; }
    }

    public class EventApiApiCollectionOfEventFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventFee[] Value { get; set; }
    }

    public class EventApiEventFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public double Amount { get; set; }

        [JsonProperty("contribution_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("number_sold")]
        public int NumberSold { get; set; }
    }

    public class EventApiCreatedEventFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfEventParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventParticipantOption[] Value { get; set; }
    }

    public class EventApiEventParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("input_type")]
        public EventApiEventParticipantOptionInputTypeType InputType { get; set; }

        [JsonProperty("multi_select")]
        public bool AllowMultiSelect { get; set; }

        [JsonProperty("list_options")]
        public EventApiEventParticipantOptionListOption[] ListOptions { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public enum EventApiEventParticipantOptionInputTypeType
    {
        Boolean,
        String,
        List
    }

    public class EventApiEventParticipantOptionListOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiCreatedEventParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyinputTypeInput
    {
        Boolean,
        String,
        List
    }

    public class EventApiCreateParticipantOptionListOption
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiApiCollectionOfParticipantListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantListEntry[] Value { get; set; }
    }

    public class EventApiParticipantListEntry
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantListEntryRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantListEntryInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantListEntryRSVPDateType RSVPDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("total_registration_fees")]
        public double TotalRegistrationFees { get; set; }

        [JsonProperty("total_paid")]
        public double TotalPaid { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("name_tag")]
        public string NameTag { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("host")]
        public EventApiParticipantListEntryHostType Host { get; set; }

        [JsonProperty("guests")]
        public EventApiParticipantListParticipantSummary[] Guests { get; set; }

        [JsonProperty("memberships")]
        public EventApiMembership[] Memberships { get; set; }
    }

    public enum EventApiParticipantListEntryRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum EventApiParticipantListEntryInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantListEntryRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipationLevel
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiParticipantListEntryHostType
    {
        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiParticipantListParticipantSummary
    {
        [JsonProperty("contact_id")]
        public string ContactID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiMembership
    {
        [JsonProperty("category")]
        public EventApiMembershipCategory Category { get; set; }
    }

    public class EventApiMembershipCategory
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum rsvpStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum invitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiCreatedParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyrSVPStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum bodyinvitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("host_id")]
        public string HostID { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantRSVPDateType RSVPDate { get; set; }

        [JsonProperty("invitation_date")]
        public EventApiParticipantInvitationDateType InvitationDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum EventApiParticipantRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    public enum EventApiParticipantInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipantInvitationDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiApiCollectionOfParticipantDonation
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantDonation[] Value { get; set; }
    }

    public class EventApiParticipantDonation
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }
    }

    public class EventApiCreatedParticipantDonation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFeePayment
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFeePayment[] Value { get; set; }
    }

    public class EventApiParticipantFeePayment
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }

        [JsonProperty("applied_amount")]
        public double AppliedAmount { get; set; }
    }

    public class EventApiCreatedParticipantFeePayment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFee[] Value { get; set; }
    }

    public class EventApiParticipantFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("fee_amount")]
        public double FeeAmount { get; set; }

        [JsonProperty("tax_receiptable_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("date")]
        public EventApiParticipantFeeDateType Date { get; set; }

        [JsonProperty("event_fee")]
        public EventApiEventFee EventFee { get; set; }
    }

    public class EventApiParticipantFeeDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiCreatedParticipantFee
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class EventApiApiCollectionOfParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantOption[] Value { get; set; }
    }

    public class EventApiParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantID { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("event_participant_option_id")]
        public string EventParticipantOptionID { get; set; }

        [JsonProperty("option_value")]
        public string Value { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }
    }

    public class EventApiCreatedParticipantOption
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealRead[] Value { get; set; }
    }

    public class FundraisingApiAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiAppealReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiAppealReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiAppealAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string AppealID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum FundraisingApiAppealAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfAppealCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiAppealCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string AppealID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiAppealCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedAppealAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedAppealCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiCampaignReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiCampaignReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum FundraisingApiCampaignAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfCampaignCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiCampaignCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedCampaignAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedCampaignCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundRead[] Value { get; set; }
    }

    public class FundraisingApiFundRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiFundReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class FundraisingApiFundReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string FundID { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum FundraisingApiFundAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfFundCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiFundCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string FundID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum FundraisingApiFundCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedFundAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedFundCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfPackageRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiPackageRead[] Value { get; set; }
    }

    public class FundraisingApiPackageRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("default_gift_amount")]
        public FundraisingApiPackageReadDefaultGiftAmountType DefaultGiftAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiPackageReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("recipient_count")]
        public int RecipientCount { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiPackageReadDefaultGiftAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiPackageReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public enum bodystatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class GiftApiApiCollectionOfGiftRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftRead[] Value { get; set; }
    }

    public class GiftApiGiftRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitReadAmountType Amount { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftSplitReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }
    }

    public class GiftApiGiftSplitReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftFundraiserRead
    {
        [JsonProperty("amount")]
        public GiftApiGiftFundraiserReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string FundraiserID { get; set; }
    }

    public class GiftApiGiftFundraiserReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiSoftCreditRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiSoftCreditReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }
    }

    public class GiftApiSoftCreditReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiReceiptRead
    {
        [JsonProperty("amount")]
        public GiftApiReceiptReadAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiReceiptReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiAcknowledgementRead
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiPaymentRead
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("bbps_configuration_id")]
        public string BBPSConfigurationID { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BBPSTransactionID { get; set; }

        [JsonProperty("check_date")]
        public GiftApiPaymentReadCheckDateType CheckDate { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("checkout_transaction_id")]
        public string CheckoutTransactionID { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public GiftApiPaymentReadReferenceDateType ReferenceDate { get; set; }
    }

    public class GiftApiPaymentReadCheckDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiPaymentReadReferenceDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiCreatedGift
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class GiftApiGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    public enum bodyreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public enum bodypaymentspaymentMethodInput
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    public enum bodypostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class GiftApiApiCollectionOfGiftAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftAttachmentRead[] Value { get; set; }
    }

    public class GiftApiGiftAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum GiftApiGiftAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class GiftApiApiCollectionOfGiftCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftCustomFieldRead[] Value { get; set; }
    }

    public class GiftApiGiftCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum GiftApiGiftCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class GiftApiCreatedGiftAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class GiftApiBatchGiftAddResults
    {
        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("gifts")]
        public GiftApiBatchGiftRead[] Gifts { get; set; }
    }

    public class GiftApiGiftBatchGiftError
    {
        [JsonProperty("affected_field")]
        public string AffectedField { get; set; }

        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

        [JsonProperty("exception_error_code")]
        public int ExceptionErrorCode { get; set; }

        [JsonProperty("exception_error_message")]
        public string ExceptionErrorMessage { get; set; }

        [JsonProperty("exception_error_name")]
        public string ExceptionErrorName { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }
    }

    public class GiftApiBatchGiftRead
    {
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiBatchGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiBatchGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiBatchGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiBatchGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiBatchGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiBatchGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiBatchGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public enum bodygiftspaymentspaymentMethodInput
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    public enum bodygiftsreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public enum bodygiftstypeInput
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiVirtualBatchGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }

        [JsonProperty("amount")]
        public GiftApiVirtualBatchGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiVirtualBatchGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    public enum bodygiftspostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class GiftBatchApiApiCollectionOfGiftBatch
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftBatchApiGiftBatch[] Value { get; set; }
    }

    public class GiftBatchApiGiftBatch
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("batch_description")]
        public string Description { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("projected_number_of_gifts")]
        public int ProjectedNumber { get; set; }

        [JsonProperty("number_of_gifts")]
        public int ActualNumber { get; set; }

        [JsonProperty("projected_amount")]
        public double ProjectedAmount { get; set; }

        [JsonProperty("actual_amount")]
        public double ActualAmount { get; set; }

        [JsonProperty("has_exceptions")]
        public bool HasExceptions { get; set; }

        [JsonProperty("is_approved")]
        public bool Approved { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class GiftBatchApiCreatedBatch
    {
        [JsonProperty("batch_id")]
        public string ID { get; set; }
    }

    public enum bodylistTypeInput
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodypermissionsInput
    {
        OnlyOwnerCanAccess,
        OthersCanView,
        OthersCanViewAndEdit
    }

    public class OpportunityApiApiCollectionOfOpportunityRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("ask_amount")]
        public OpportunityApiOpportunityReadAskAmountType AskAmount { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_amount")]
        public OpportunityApiOpportunityReadExpectedAmountType ExpectedAmount { get; set; }

        [JsonProperty("funded_date")]
        public string FundedDate { get; set; }

        [JsonProperty("funded_amount")]
        public OpportunityApiOpportunityReadFundedAmountType FundedAmount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("fundraisers")]
        public OpportunityApiFundraiser[] FundraiserS { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class OpportunityApiOpportunityReadAskAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadExpectedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadFundedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiFundraiser
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("credit_amount")]
        public OpportunityApiFundraiserCreditAmountType CreditAmount { get; set; }
    }

    public class OpportunityApiFundraiserCreditAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiCreatedOpportunity
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiApiCollectionOfOpportunityAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityAttachmentRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    public enum OpportunityApiOpportunityAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class OpportunityApiApiCollectionOfOpportunityCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityCustomFieldRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum OpportunityApiOpportunityCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class OpportunityApiCreatedOpportunityAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge;

    public partial class WorkflowManagedActions
    {
        public BlackbaudraisersedgeActions Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudraisersedgeTriggers Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeTriggers(connectionId);
    }
}