//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfundraising
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfundraisingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAppealRead> ListConstituentAppeals([WorkflowExpression] Func<string> constituentId)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/appeals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAppealRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealAttachment> CreateAppealAttachment([WorkflowExpression] Func<string> bodyappealId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(bodyappealId, nameof(bodyappealId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditAppealAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignAttachment> CreateCampaignAttachment([WorkflowExpression] Func<string> bodycampaignId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditCampaignAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundAttachment> CreateFundAttachment([WorkflowExpression] Func<string> bodyfundId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(bodyfundId, nameof(bodyfundId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodythumbnailId, nameof(bodythumbnailId), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditFundAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
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

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedAppeal> CreateAppeal([WorkflowExpression] Func<string> bodylookupId, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<double> bodydefaultGiftAmount = null, [WorkflowExpression] Func<int> bodynumberSolicited = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodydefaultCampaignId = null, [WorkflowExpression] Func<int> bodydefaultFundId = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodydefaultGiftAmount, nameof(bodydefaultGiftAmount), required: false);
            SourceExpression.Validate(bodynumberSolicited, nameof(bodynumberSolicited), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodydefaultCampaignId, nameof(bodydefaultCampaignId), required: false);
            SourceExpression.Validate(bodydefaultFundId, nameof(bodydefaultFundId), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/appeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["appeal_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodydefaultGiftAmount != null)
                {
                    body["default_gift_amount"] = SourceExpressionConverter.ConvertToken(bodydefaultGiftAmount);
                    bodypropCount++;
                }

                if (bodynumberSolicited != null)
                {
                    body["number_solicited"] = SourceExpressionConverter.ConvertToken(bodynumberSolicited);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodydefaultCampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodydefaultCampaignId);
                    bodypropCount++;
                }

                if (bodydefaultFundId != null)
                {
                    body["default_fund_id"] = SourceExpressionConverter.ConvertToken(bodydefaultFundId);
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

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedAppeal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditAppeal([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<double> bodydefaultGiftAmount = null, [WorkflowExpression] Func<int> bodynumberSolicited = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodydefaultCampaignId = null, [WorkflowExpression] Func<int> bodydefaultFundId = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodydefaultGiftAmount, nameof(bodydefaultGiftAmount), required: false);
            SourceExpression.Validate(bodynumberSolicited, nameof(bodynumberSolicited), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodydefaultCampaignId, nameof(bodydefaultCampaignId), required: false);
            SourceExpression.Validate(bodydefaultFundId, nameof(bodydefaultFundId), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/appeals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylookupId != null)
                {
                    body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["appeal_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodydefaultGiftAmount != null)
                {
                    body["default_gift_amount"] = SourceExpressionConverter.ConvertToken(bodydefaultGiftAmount);
                    bodypropCount++;
                }

                if (bodynumberSolicited != null)
                {
                    body["number_solicited"] = SourceExpressionConverter.ConvertToken(bodynumberSolicited);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodydefaultCampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodydefaultCampaignId);
                    bodypropCount++;
                }

                if (bodydefaultFundId != null)
                {
                    body["default_fund_id"] = SourceExpressionConverter.ConvertToken(bodydefaultFundId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedCampaign> CreateCampaign([WorkflowExpression] Func<string> bodylookupId, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodydefaultFundId = null)
        {
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            SourceExpression.Validate(bodydefaultFundId, nameof(bodydefaultFundId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["campaign_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodydefaultFundId != null)
                {
                    body["default_fund_id"] = SourceExpressionConverter.ConvertToken(bodydefaultFundId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedCampaign>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditCampaign([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodydefaultFundId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            SourceExpression.Validate(bodydefaultFundId, nameof(bodydefaultFundId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylookupId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["campaign_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodydefaultFundId != null)
                {
                    body["default_fund_id"] = SourceExpressionConverter.ConvertToken(bodydefaultFundId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentAppeal> CreateConstituentAppeal([WorkflowExpression] Func<int> bodyconstituentId, [WorkflowExpression] Func<string> bodyappealDescription, [WorkflowExpression] Func<string> bodypackageDescription = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyresponse = null, [WorkflowExpression] Func<string> bodymarketingSegment = null, [WorkflowExpression] Func<string> bodymarketingSourceCode = null, [WorkflowExpression] Func<int> bodymailingId = null, [WorkflowExpression] Func<string> bodyfinderNumber = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyimportId = null)
        {
            SourceExpression.Validate(bodyconstituentId, nameof(bodyconstituentId), required: true);
            SourceExpression.Validate(bodyappealDescription, nameof(bodyappealDescription), required: true);
            SourceExpression.Validate(bodypackageDescription, nameof(bodypackageDescription), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyresponse, nameof(bodyresponse), required: false);
            SourceExpression.Validate(bodymarketingSegment, nameof(bodymarketingSegment), required: false);
            SourceExpression.Validate(bodymarketingSourceCode, nameof(bodymarketingSourceCode), required: false);
            SourceExpression.Validate(bodymailingId, nameof(bodymailingId), required: false);
            SourceExpression.Validate(bodyfinderNumber, nameof(bodyfinderNumber), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyimportId, nameof(bodyimportId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/constitappeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["appeal_description"] = SourceExpressionConverter.ConvertToken(bodyappealDescription);
                if (bodypackageDescription != null)
                {
                    body["package_description"] = SourceExpressionConverter.ConvertToken(bodypackageDescription);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["appeal_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyresponse != null)
                {
                    body["response_description"] = SourceExpressionConverter.ConvertToken(bodyresponse);
                    bodypropCount++;
                }

                if (bodymarketingSegment != null)
                {
                    body["marketing_segment"] = SourceExpressionConverter.ConvertToken(bodymarketingSegment);
                    bodypropCount++;
                }

                if (bodymarketingSourceCode != null)
                {
                    body["marketing_source_code"] = SourceExpressionConverter.ConvertToken(bodymarketingSourceCode);
                    bodypropCount++;
                }

                if (bodymailingId != null)
                {
                    body["mailing_id"] = SourceExpressionConverter.ConvertToken(bodymailingId);
                    bodypropCount++;
                }

                if (bodyfinderNumber != null)
                {
                    body["market_finder_number"] = SourceExpressionConverter.ConvertToken(bodyfinderNumber);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyimportId != null)
                {
                    body["import_id"] = SourceExpressionConverter.ConvertToken(bodyimportId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentAppeal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditConstituentAppeal([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodyappealDescription = null, [WorkflowExpression] Func<string> bodypackageDescription = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyresponse = null, [WorkflowExpression] Func<string> bodymarketingSegment = null, [WorkflowExpression] Func<string> bodymarketingSourceCode = null, [WorkflowExpression] Func<int> bodymailingId = null, [WorkflowExpression] Func<string> bodyfinderNumber = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyappealDescription, nameof(bodyappealDescription), required: false);
            SourceExpression.Validate(bodypackageDescription, nameof(bodypackageDescription), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyresponse, nameof(bodyresponse), required: false);
            SourceExpression.Validate(bodymarketingSegment, nameof(bodymarketingSegment), required: false);
            SourceExpression.Validate(bodymarketingSourceCode, nameof(bodymarketingSourceCode), required: false);
            SourceExpression.Validate(bodymailingId, nameof(bodymailingId), required: false);
            SourceExpression.Validate(bodyfinderNumber, nameof(bodyfinderNumber), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/constitappeals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyappealDescription != null)
                {
                    body["appeal_description"] = SourceExpressionConverter.ConvertToken(bodyappealDescription);
                    bodypropCount++;
                }

                if (bodypackageDescription != null)
                {
                    body["package_description"] = SourceExpressionConverter.ConvertToken(bodypackageDescription);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["appeal_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyresponse != null)
                {
                    body["response_description"] = SourceExpressionConverter.ConvertToken(bodyresponse);
                    bodypropCount++;
                }

                if (bodymarketingSegment != null)
                {
                    body["marketing_segment"] = SourceExpressionConverter.ConvertToken(bodymarketingSegment);
                    bodypropCount++;
                }

                if (bodymarketingSourceCode != null)
                {
                    body["marketing_source_code"] = SourceExpressionConverter.ConvertToken(bodymarketingSourceCode);
                    bodypropCount++;
                }

                if (bodymailingId != null)
                {
                    body["mailing_id"] = SourceExpressionConverter.ConvertToken(bodymailingId);
                    bodypropCount++;
                }

                if (bodyfinderNumber != null)
                {
                    body["market_finder_number"] = SourceExpressionConverter.ConvertToken(bodyfinderNumber);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedFund> CreateFund([WorkflowExpression] Func<string> bodylookupId, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<int> bodytype = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyrestricted = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodycampaignId = null, [WorkflowExpression] Func<int> bodydefaultAppealId = null)
        {
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyrestricted, nameof(bodyrestricted), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodydefaultAppealId, nameof(bodydefaultAppealId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/funds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fund_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["fund_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["fund_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyrestricted != null)
                {
                    body["restricted"] = SourceExpressionConverter.ConvertToken(bodyrestricted);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodydefaultAppealId != null)
                {
                    body["default_appeal_id"] = SourceExpressionConverter.ConvertToken(bodydefaultAppealId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedFund>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IWorkflowAction EditFund([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<int> bodycategory = null, [WorkflowExpression] Func<int> bodytype = null, [WorkflowExpression] Func<double> bodygoal = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyrestricted = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodycampaignId = null, [WorkflowExpression] Func<int> bodydefaultAppealId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodylookupId, nameof(bodylookupId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyrestricted, nameof(bodyrestricted), required: false);
            SourceExpression.Validate(bodyinactive, nameof(bodyinactive), required: false);
            SourceExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            SourceExpression.Validate(bodydefaultAppealId, nameof(bodydefaultAppealId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/funds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylookupId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodycategory != null)
                {
                    body["fund_category_id"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["fund_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = SourceExpressionConverter.ConvertToken(bodygoal);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyrestricted != null)
                {
                    body["restricted"] = SourceExpressionConverter.ConvertToken(bodyrestricted);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodydefaultAppealId != null)
                {
                    body["default_appeal_id"] = SourceExpressionConverter.ConvertToken(bodydefaultAppealId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentRelationshipCollection> ListFundConstituentRelationships([WorkflowExpression] Func<int> fundId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(fundId, nameof(fundId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/relationships/constituents/fund/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(fundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiConstituentRelationshipCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfundraising")]
        public IBodyWorkflowAction<NXTDataIntegrationApiFundRelationshipCollection> ListConstituentFundRelationships([WorkflowExpression] Func<int> constituentId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(constituentId, nameof(constituentId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/relationships/funds/constituent/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiFundRelationshipCollection>(BuildSourceInput);
        }
    }

    public class BlackbaudfundraisingTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiApiCollectionOfConstituentAppealRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAppealRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAppealRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("appeal")]
        public ConstituentApiConstituentAppealReadAppealType Appeal { get; set; }

        [JsonProperty("package")]
        public ConstituentApiConstituentAppealReadPackageType Package { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("marketing_segment")]
        public string MarketingSegment { get; set; }

        [JsonProperty("marketing_source_code")]
        public string MarketingSourceCode { get; set; }

        [JsonProperty("mailing_id")]
        public string MailingID { get; set; }

        [JsonProperty("finder_number")]
        public string FinderNumber { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiConstituentAppealReadAppealType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiConstituentAppealReadPackageType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
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

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
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

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiAppealCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

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

    public class FundraisingApiAppealCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class FundraisingApiCreatedAppealAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
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

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
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

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiCampaignCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

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

    public class FundraisingApiCampaignCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
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

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
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

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public FundraisingApiFundCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

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

    public class FundraisingApiFundCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
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

    public class NXTDataIntegrationApiCreatedAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedCampaign
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedConstituentAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiCreatedFund
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiConstituentRelationshipCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiConstituentRelationship[] Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentRelationship
    {
        [JsonProperty("relation_id")]
        public int ConstituentID { get; set; }

        [JsonProperty("relation_description")]
        public string RelationDescription { get; set; }

        [JsonProperty("relationship_type")]
        public string RelationshipType { get; set; }

        [JsonProperty("reciprocal_relationship_type")]
        public string ReciprocalRelationshipType { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class NXTDataIntegrationApiFundRelationshipCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiFundRelationship[] Value { get; set; }
    }

    public class NXTDataIntegrationApiFundRelationship
    {
        [JsonProperty("relation_id")]
        public int FundID { get; set; }

        [JsonProperty("relation_description")]
        public string RelationDescription { get; set; }

        [JsonProperty("relationship_type")]
        public string RelationshipType { get; set; }

        [JsonProperty("reciprocal_relationship_type")]
        public string ReciprocalRelationshipType { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfundraising;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfundraisingActions Blackbaudfundraising(string connectionId) => new BlackbaudfundraisingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfundraisingTriggers Blackbaudfundraising(string connectionId) => new BlackbaudfundraisingTriggers(connectionId);
    }
}