//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailchimpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetCampaignsResponse> GetCampaigns()
        {
            var apiCallPath = "/campaigns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCampaignsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildSendcampaign))]
        public IWorkflowAction Sendcampaign([WorkflowExpression] Func<string> campaignId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendcampaign(WorkflowExpression<string> campaignId)
        {
            WorkflowExpression.Validate(campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/actions/send", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildGetLists))]
        public IBodyWorkflowAction<GetListsResponseModel> GetLists([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetListsResponseModel> __BuildGetLists(WorkflowExpression<int> count = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetListsResponseModel>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<GetListsResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildNewlist))]
        public IBodyWorkflowAction<CreateNewListResponseModel> Newlist([WorkflowExpression] Func<string> newListRequestlistName, [WorkflowExpression] Func<string> newListRequestcontactcompanyName, [WorkflowExpression] Func<string> newListRequestcontactaddressLine1, [WorkflowExpression] Func<string> newListRequestcontactcity, [WorkflowExpression] Func<string> newListRequestcontactstate, [WorkflowExpression] Func<string> newListRequestcontactpostalCode, [WorkflowExpression] Func<string> newListRequestcontactcountryCode, [WorkflowExpression] Func<string> newListRequestcontactphoneNumber, [WorkflowExpression] Func<string> newListRequestpermissionReminder, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssenderSName, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssenderSEmailAddress, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssubject, [WorkflowExpression] Func<newListRequestcampaignDefaultslanguageInput> newListRequestcampaignDefaultslanguage, [WorkflowExpression] Func<bool> newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, [WorkflowExpression] Func<string> newListRequestcontactaddressLine2 = null, [WorkflowExpression] Func<bool> newListRequestuseArchiveBar = null, [WorkflowExpression] Func<string> newListRequestnotifyOnSubscribe = null, [WorkflowExpression] Func<string> newListRequestnotifyOnUnsubscribe = null, [WorkflowExpression] Func<newListRequestvisibilityInput> newListRequestvisibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateNewListResponseModel> __BuildNewlist(WorkflowExpression<string> newListRequestlistName, WorkflowExpression<string> newListRequestcontactcompanyName, WorkflowExpression<string> newListRequestcontactaddressLine1, WorkflowExpression<string> newListRequestcontactcity, WorkflowExpression<string> newListRequestcontactstate, WorkflowExpression<string> newListRequestcontactpostalCode, WorkflowExpression<string> newListRequestcontactcountryCode, WorkflowExpression<string> newListRequestcontactphoneNumber, WorkflowExpression<string> newListRequestpermissionReminder, WorkflowExpression<string> newListRequestcampaignDefaultssenderSName, WorkflowExpression<string> newListRequestcampaignDefaultssenderSEmailAddress, WorkflowExpression<string> newListRequestcampaignDefaultssubject, WorkflowExpression<newListRequestcampaignDefaultslanguageInput> newListRequestcampaignDefaultslanguage, WorkflowExpression<bool> newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, WorkflowExpression<string> newListRequestcontactaddressLine2 = null, WorkflowExpression<bool> newListRequestuseArchiveBar = null, WorkflowExpression<string> newListRequestnotifyOnSubscribe = null, WorkflowExpression<string> newListRequestnotifyOnUnsubscribe = null, WorkflowExpression<newListRequestvisibilityInput> newListRequestvisibility = null)
        {
            WorkflowExpression.Validate(newListRequestlistName, nameof(newListRequestlistName), required: true);
            WorkflowExpression.Validate(newListRequestcontactcompanyName, nameof(newListRequestcontactcompanyName), required: true);
            WorkflowExpression.Validate(newListRequestcontactaddressLine1, nameof(newListRequestcontactaddressLine1), required: true);
            WorkflowExpression.Validate(newListRequestcontactcity, nameof(newListRequestcontactcity), required: true);
            WorkflowExpression.Validate(newListRequestcontactstate, nameof(newListRequestcontactstate), required: true);
            WorkflowExpression.Validate(newListRequestcontactpostalCode, nameof(newListRequestcontactpostalCode), required: true);
            WorkflowExpression.Validate(newListRequestcontactcountryCode, nameof(newListRequestcontactcountryCode), required: true);
            WorkflowExpression.Validate(newListRequestcontactphoneNumber, nameof(newListRequestcontactphoneNumber), required: true);
            WorkflowExpression.Validate(newListRequestpermissionReminder, nameof(newListRequestpermissionReminder), required: true);
            WorkflowExpression.Validate(newListRequestcampaignDefaultssenderSName, nameof(newListRequestcampaignDefaultssenderSName), required: true);
            WorkflowExpression.Validate(newListRequestcampaignDefaultssenderSEmailAddress, nameof(newListRequestcampaignDefaultssenderSEmailAddress), required: true);
            WorkflowExpression.Validate(newListRequestcampaignDefaultssubject, nameof(newListRequestcampaignDefaultssubject), required: true);
            WorkflowExpression.Validate(newListRequestcampaignDefaultslanguage, nameof(newListRequestcampaignDefaultslanguage), required: true);
            WorkflowExpression.Validate(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, nameof(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse), required: true);
            WorkflowExpression.Validate(newListRequestcontactaddressLine2, nameof(newListRequestcontactaddressLine2), required: false);
            WorkflowExpression.Validate(newListRequestuseArchiveBar, nameof(newListRequestuseArchiveBar), required: false);
            WorkflowExpression.Validate(newListRequestnotifyOnSubscribe, nameof(newListRequestnotifyOnSubscribe), required: false);
            WorkflowExpression.Validate(newListRequestnotifyOnUnsubscribe, nameof(newListRequestnotifyOnUnsubscribe), required: false);
            WorkflowExpression.Validate(newListRequestvisibility, nameof(newListRequestvisibility), required: false);
            return new DeferredBodyAction<CreateNewListResponseModel>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newListRequest = new JObject();
                var newListRequestpropCount = 0;
                newListRequestpropCount++;
                newListRequest["name"] = ExpressionConverter.ConvertO(newListRequestlistName);
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                contactObjectpropCount++;
                contactObject["company"] = ExpressionConverter.ConvertO(newListRequestcontactcompanyName);
                contactObjectpropCount++;
                contactObject["address1"] = ExpressionConverter.ConvertO(newListRequestcontactaddressLine1);
                if (newListRequestcontactaddressLine2 != null)
                {
                    contactObject["address2"] = ExpressionConverter.ConvertO(newListRequestcontactaddressLine2);
                    contactObjectpropCount++;
                }

                contactObjectpropCount++;
                contactObject["city"] = ExpressionConverter.ConvertO(newListRequestcontactcity);
                contactObjectpropCount++;
                contactObject["state"] = ExpressionConverter.ConvertO(newListRequestcontactstate);
                contactObjectpropCount++;
                contactObject["zip"] = ExpressionConverter.ConvertO(newListRequestcontactpostalCode);
                contactObjectpropCount++;
                contactObject["country"] = ExpressionConverter.ConvertO(newListRequestcontactcountryCode);
                contactObjectpropCount++;
                contactObject["phone"] = ExpressionConverter.ConvertO(newListRequestcontactphoneNumber);
                if (contactObjectpropCount > 0)
                {
                    newListRequest["contact"] = contactObject;
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["permission_reminder"] = ExpressionConverter.ConvertO(newListRequestpermissionReminder);
                if (newListRequestuseArchiveBar != null)
                {
                    newListRequest["use_archive_bar"] = ExpressionConverter.ConvertO(newListRequestuseArchiveBar);
                    newListRequestpropCount++;
                }

                var campaignDefaultsObject = new JObject();
                var campaignDefaultsObjectpropCount = 0;
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_name"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssenderSName);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_email"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssenderSEmailAddress);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["subject"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssubject);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["language"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultslanguage);
                if (campaignDefaultsObjectpropCount > 0)
                {
                    newListRequest["campaign_defaults"] = campaignDefaultsObject;
                    newListRequestpropCount++;
                }

                if (newListRequestnotifyOnSubscribe != null)
                {
                    newListRequest["notify_on_subscribe"] = ExpressionConverter.ConvertO(newListRequestnotifyOnSubscribe);
                    newListRequestpropCount++;
                }

                if (newListRequestnotifyOnUnsubscribe != null)
                {
                    newListRequest["notify_on_unsubscribe"] = ExpressionConverter.ConvertO(newListRequestnotifyOnUnsubscribe);
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["email_type_option"] = ExpressionConverter.ConvertO(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse);
                if (newListRequestvisibility != null)
                {
                    newListRequest["visibility"] = ExpressionConverter.ConvertO(newListRequestvisibility);
                    newListRequestpropCount++;
                }

                if (newListRequestpropCount > 0)
                {
                    callPayload.Body = newListRequest;
                }

                return new ApiConnectionAction<CreateNewListResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildAddMembers))]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> AddMembers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<NewMemberInListRequest[]> bodymembers, [WorkflowExpression] Func<bool> skipMergeValidation = null, [WorkflowExpression] Func<bool> skipDuplicateCheck = null, [WorkflowExpression] Func<bool> bodyupdateExisting = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> __BuildAddMembers(WorkflowExpression<string> listId, WorkflowExpression<NewMemberInListRequest[]> bodymembers, WorkflowExpression<bool> skipMergeValidation = null, WorkflowExpression<bool> skipDuplicateCheck = null, WorkflowExpression<bool> bodyupdateExisting = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: true);
            WorkflowExpression.Validate(skipMergeValidation, nameof(skipMergeValidation), required: false);
            WorkflowExpression.Validate(skipDuplicateCheck, nameof(skipDuplicateCheck), required: false);
            WorkflowExpression.Validate(bodyupdateExisting, nameof(bodyupdateExisting), required: false);
            return new DeferredBodyAction<GetAddMembersBatchResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (skipMergeValidation != null)
                    callPayload.Queries["skip_merge_validation"] = ExpressionConverter.Convert(skipMergeValidation);
                if (skipDuplicateCheck != null)
                    callPayload.Queries["skip_duplicate_check"] = ExpressionConverter.Convert(skipDuplicateCheck);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                if (bodyupdateExisting != null)
                {
                    body["update_existing"] = ExpressionConverter.ConvertO(bodyupdateExisting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAddMembersBatchResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildGetListMembers))]
        public IBodyWorkflowAction<GetAllMembersResponseModel> GetListMembers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllMembersResponseModel> __BuildGetListMembers(WorkflowExpression<string> listId, WorkflowExpression<int> count = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetAllMembersResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<GetAllMembersResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildAddmember))]
        public IBodyWorkflowAction<MemberResponseModel> Addmember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<newMemberInListstatusInput> newMemberInListstatus, [WorkflowExpression] Func<string> newMemberInListemailAddress, [WorkflowExpression] Func<newMemberInListemailTypeInput> newMemberInListemailType = null, [WorkflowExpression] Func<string> newMemberInListmergeFieldsfirstName = null, [WorkflowExpression] Func<string> newMemberInListmergeFieldslastName = null, [WorkflowExpression] Func<string> newMemberInListlanguage = null, [WorkflowExpression] Func<bool> newMemberInListvIP = null, [WorkflowExpression] Func<double> newMemberInListlocationlatitude = null, [WorkflowExpression] Func<double> newMemberInListlocationlongitude = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MemberResponseModel> __BuildAddmember(WorkflowExpression<string> listId, WorkflowExpression<newMemberInListstatusInput> newMemberInListstatus, WorkflowExpression<string> newMemberInListemailAddress, WorkflowExpression<newMemberInListemailTypeInput> newMemberInListemailType = null, WorkflowExpression<string> newMemberInListmergeFieldsfirstName = null, WorkflowExpression<string> newMemberInListmergeFieldslastName = null, WorkflowExpression<string> newMemberInListlanguage = null, WorkflowExpression<bool> newMemberInListvIP = null, WorkflowExpression<double> newMemberInListlocationlatitude = null, WorkflowExpression<double> newMemberInListlocationlongitude = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(newMemberInListstatus, nameof(newMemberInListstatus), required: true);
            WorkflowExpression.Validate(newMemberInListemailAddress, nameof(newMemberInListemailAddress), required: true);
            WorkflowExpression.Validate(newMemberInListemailType, nameof(newMemberInListemailType), required: false);
            WorkflowExpression.Validate(newMemberInListmergeFieldsfirstName, nameof(newMemberInListmergeFieldsfirstName), required: false);
            WorkflowExpression.Validate(newMemberInListmergeFieldslastName, nameof(newMemberInListmergeFieldslastName), required: false);
            WorkflowExpression.Validate(newMemberInListlanguage, nameof(newMemberInListlanguage), required: false);
            WorkflowExpression.Validate(newMemberInListvIP, nameof(newMemberInListvIP), required: false);
            WorkflowExpression.Validate(newMemberInListlocationlatitude, nameof(newMemberInListlocationlatitude), required: false);
            WorkflowExpression.Validate(newMemberInListlocationlongitude, nameof(newMemberInListlocationlongitude), required: false);
            return new DeferredBodyAction<MemberResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newMemberInList = new JObject();
                var newMemberInListpropCount = 0;
                if (newMemberInListemailType != null)
                {
                    if (newMemberInListemailType != null)
                    {
                        newMemberInList["email_type"] = ExpressionConverter.ConvertO(newMemberInListemailType);
                        newMemberInListpropCount++;
                    }

                    newMemberInListpropCount++;
                }
                else
                {
                    newMemberInList["email_type"] = "html";
                    newMemberInListpropCount++;
                }

                newMemberInListpropCount++;
                newMemberInList["status"] = ExpressionConverter.ConvertO(newMemberInListstatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (newMemberInListmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = ExpressionConverter.ConvertO(newMemberInListmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (newMemberInListmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = ExpressionConverter.ConvertO(newMemberInListmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    newMemberInList["merge_fields"] = mergeFieldsObject;
                    newMemberInListpropCount++;
                }

                if (newMemberInListlanguage != null)
                {
                    newMemberInList["language"] = ExpressionConverter.ConvertO(newMemberInListlanguage);
                    newMemberInListpropCount++;
                }

                if (newMemberInListvIP != null)
                {
                    newMemberInList["vip"] = ExpressionConverter.ConvertO(newMemberInListvIP);
                    newMemberInListpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (newMemberInListlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(newMemberInListlocationlatitude);
                    locationObjectpropCount++;
                }

                if (newMemberInListlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(newMemberInListlocationlongitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    newMemberInList["location"] = locationObject;
                    newMemberInListpropCount++;
                }

                newMemberInListpropCount++;
                newMemberInList["email_address"] = ExpressionConverter.ConvertO(newMemberInListemailAddress);
                if (newMemberInListpropCount > 0)
                {
                    callPayload.Body = newMemberInList;
                }

                return new ApiConnectionAction<MemberResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildNewcampaign))]
        public IBodyWorkflowAction<CampaignResponseModel> Newcampaign([WorkflowExpression] Func<newCampaignRequestcampaignTypeInput> newCampaignRequestcampaignType, [WorkflowExpression] Func<string> newCampaignRequestrecipientslistId, [WorkflowExpression] Func<string> newCampaignRequestsettingscampaignSubjectLine, [WorkflowExpression] Func<string> newCampaignRequestsettingsfromName, [WorkflowExpression] Func<string> newCampaignRequestsettingsreplyToAddress, [WorkflowExpression] Func<int> newCampaignRequestrecipientssegmentOptssavedSegmentID = null, [WorkflowExpression] Func<string> newCampaignRequestrecipientssegmentOptsmatchType = null, [WorkflowExpression] Func<string> newCampaignRequestsettingstitle = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsconversation = null, [WorkflowExpression] Func<string> newCampaignRequestsettingstoName = null, [WorkflowExpression] Func<string> newCampaignRequestsettingsfolderID = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsauthentication = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsautoFooter = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsinlineCSS = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsautoTweet = null, [WorkflowExpression] Func<int[]> newCampaignRequestsettingsautoPostToFacebook = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsfacebookComments = null, [WorkflowExpression] Func<string> newCampaignRequestvariateSettingswinningCriteria = null, [WorkflowExpression] Func<int> newCampaignRequestvariateSettingswaitTime = null, [WorkflowExpression] Func<int> newCampaignRequestvariateSettingstestSize = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingssubjectLines = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingssendTimes = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingsfromNames = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingsreplyToAddresses = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingopens = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghTMLClickTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingplainTextClickTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingmailChimpGoalTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingeCommerce360Tracking = null, [WorkflowExpression] Func<string> newCampaignRequesttrackinggoogleAnalyticsTracking = null, [WorkflowExpression] Func<string> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingsalesforcesalesforceNote = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghighrisehighriseCampaign = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghighrisehighriseNote = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingcapsulecapsuleNote = null, [WorkflowExpression] Func<string> newCampaignRequestrssOptsfeedURL = null, [WorkflowExpression] Func<newCampaignRequestrssOptsfrequencyInput> newCampaignRequestrssOptsfrequency = null, [WorkflowExpression] Func<string> newCampaignRequestrssOptsconstrainRSSImages = null, [WorkflowExpression] Func<int> newCampaignRequestrssOptsschedulesendingHour = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendsunday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendmonday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendtuesday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendwednesday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendthursday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendfriday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendsaturday = null, [WorkflowExpression] Func<newCampaignRequestrssOptsscheduleweeklySendingDayInput> newCampaignRequestrssOptsscheduleweeklySendingDay = null, [WorkflowExpression] Func<double> newCampaignRequestrssOptsschedulemonthlySendingDay = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardimageURL = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardcampaignDescription = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardtitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CampaignResponseModel> __BuildNewcampaign(WorkflowExpression<newCampaignRequestcampaignTypeInput> newCampaignRequestcampaignType, WorkflowExpression<string> newCampaignRequestrecipientslistId, WorkflowExpression<string> newCampaignRequestsettingscampaignSubjectLine, WorkflowExpression<string> newCampaignRequestsettingsfromName, WorkflowExpression<string> newCampaignRequestsettingsreplyToAddress, WorkflowExpression<int> newCampaignRequestrecipientssegmentOptssavedSegmentID = null, WorkflowExpression<string> newCampaignRequestrecipientssegmentOptsmatchType = null, WorkflowExpression<string> newCampaignRequestsettingstitle = null, WorkflowExpression<bool> newCampaignRequestsettingsconversation = null, WorkflowExpression<string> newCampaignRequestsettingstoName = null, WorkflowExpression<string> newCampaignRequestsettingsfolderID = null, WorkflowExpression<bool> newCampaignRequestsettingsauthentication = null, WorkflowExpression<bool> newCampaignRequestsettingsautoFooter = null, WorkflowExpression<bool> newCampaignRequestsettingsinlineCSS = null, WorkflowExpression<bool> newCampaignRequestsettingsautoTweet = null, WorkflowExpression<int[]> newCampaignRequestsettingsautoPostToFacebook = null, WorkflowExpression<bool> newCampaignRequestsettingsfacebookComments = null, WorkflowExpression<string> newCampaignRequestvariateSettingswinningCriteria = null, WorkflowExpression<int> newCampaignRequestvariateSettingswaitTime = null, WorkflowExpression<int> newCampaignRequestvariateSettingstestSize = null, WorkflowExpression<string[]> newCampaignRequestvariateSettingssubjectLines = null, WorkflowExpression<string[]> newCampaignRequestvariateSettingssendTimes = null, WorkflowExpression<string[]> newCampaignRequestvariateSettingsfromNames = null, WorkflowExpression<string[]> newCampaignRequestvariateSettingsreplyToAddresses = null, WorkflowExpression<bool> newCampaignRequesttrackingopens = null, WorkflowExpression<bool> newCampaignRequesttrackinghTMLClickTracking = null, WorkflowExpression<bool> newCampaignRequesttrackingplainTextClickTracking = null, WorkflowExpression<bool> newCampaignRequesttrackingmailChimpGoalTracking = null, WorkflowExpression<bool> newCampaignRequesttrackingeCommerce360Tracking = null, WorkflowExpression<string> newCampaignRequesttrackinggoogleAnalyticsTracking = null, WorkflowExpression<string> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, WorkflowExpression<bool> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, WorkflowExpression<bool> newCampaignRequesttrackingsalesforcesalesforceNote = null, WorkflowExpression<bool> newCampaignRequesttrackinghighrisehighriseCampaign = null, WorkflowExpression<bool> newCampaignRequesttrackinghighrisehighriseNote = null, WorkflowExpression<bool> newCampaignRequesttrackingcapsulecapsuleNote = null, WorkflowExpression<string> newCampaignRequestrssOptsfeedURL = null, WorkflowExpression<newCampaignRequestrssOptsfrequencyInput> newCampaignRequestrssOptsfrequency = null, WorkflowExpression<string> newCampaignRequestrssOptsconstrainRSSImages = null, WorkflowExpression<int> newCampaignRequestrssOptsschedulesendingHour = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendsunday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendmonday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendtuesday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendwednesday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendthursday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendfriday = null, WorkflowExpression<bool> newCampaignRequestrssOptsscheduledailySendsaturday = null, WorkflowExpression<newCampaignRequestrssOptsscheduleweeklySendingDayInput> newCampaignRequestrssOptsscheduleweeklySendingDay = null, WorkflowExpression<double> newCampaignRequestrssOptsschedulemonthlySendingDay = null, WorkflowExpression<string> newCampaignRequestsocialCardimageURL = null, WorkflowExpression<string> newCampaignRequestsocialCardcampaignDescription = null, WorkflowExpression<string> newCampaignRequestsocialCardtitle = null)
        {
            WorkflowExpression.Validate(newCampaignRequestcampaignType, nameof(newCampaignRequestcampaignType), required: true);
            WorkflowExpression.Validate(newCampaignRequestrecipientslistId, nameof(newCampaignRequestrecipientslistId), required: true);
            WorkflowExpression.Validate(newCampaignRequestsettingscampaignSubjectLine, nameof(newCampaignRequestsettingscampaignSubjectLine), required: true);
            WorkflowExpression.Validate(newCampaignRequestsettingsfromName, nameof(newCampaignRequestsettingsfromName), required: true);
            WorkflowExpression.Validate(newCampaignRequestsettingsreplyToAddress, nameof(newCampaignRequestsettingsreplyToAddress), required: true);
            WorkflowExpression.Validate(newCampaignRequestrecipientssegmentOptssavedSegmentID, nameof(newCampaignRequestrecipientssegmentOptssavedSegmentID), required: false);
            WorkflowExpression.Validate(newCampaignRequestrecipientssegmentOptsmatchType, nameof(newCampaignRequestrecipientssegmentOptsmatchType), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingstitle, nameof(newCampaignRequestsettingstitle), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsconversation, nameof(newCampaignRequestsettingsconversation), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingstoName, nameof(newCampaignRequestsettingstoName), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsfolderID, nameof(newCampaignRequestsettingsfolderID), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsauthentication, nameof(newCampaignRequestsettingsauthentication), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsautoFooter, nameof(newCampaignRequestsettingsautoFooter), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsinlineCSS, nameof(newCampaignRequestsettingsinlineCSS), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsautoTweet, nameof(newCampaignRequestsettingsautoTweet), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsautoPostToFacebook, nameof(newCampaignRequestsettingsautoPostToFacebook), required: false);
            WorkflowExpression.Validate(newCampaignRequestsettingsfacebookComments, nameof(newCampaignRequestsettingsfacebookComments), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingswinningCriteria, nameof(newCampaignRequestvariateSettingswinningCriteria), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingswaitTime, nameof(newCampaignRequestvariateSettingswaitTime), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingstestSize, nameof(newCampaignRequestvariateSettingstestSize), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingssubjectLines, nameof(newCampaignRequestvariateSettingssubjectLines), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingssendTimes, nameof(newCampaignRequestvariateSettingssendTimes), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingsfromNames, nameof(newCampaignRequestvariateSettingsfromNames), required: false);
            WorkflowExpression.Validate(newCampaignRequestvariateSettingsreplyToAddresses, nameof(newCampaignRequestvariateSettingsreplyToAddresses), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingopens, nameof(newCampaignRequesttrackingopens), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackinghTMLClickTracking, nameof(newCampaignRequesttrackinghTMLClickTracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingplainTextClickTracking, nameof(newCampaignRequesttrackingplainTextClickTracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingmailChimpGoalTracking, nameof(newCampaignRequesttrackingmailChimpGoalTracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingeCommerce360Tracking, nameof(newCampaignRequesttrackingeCommerce360Tracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackinggoogleAnalyticsTracking, nameof(newCampaignRequesttrackinggoogleAnalyticsTracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingclickTaleAnalyticsTracking, nameof(newCampaignRequesttrackingclickTaleAnalyticsTracking), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingsalesforcesalesforceCampaign, nameof(newCampaignRequesttrackingsalesforcesalesforceCampaign), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingsalesforcesalesforceNote, nameof(newCampaignRequesttrackingsalesforcesalesforceNote), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackinghighrisehighriseCampaign, nameof(newCampaignRequesttrackinghighrisehighriseCampaign), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackinghighrisehighriseNote, nameof(newCampaignRequesttrackinghighrisehighriseNote), required: false);
            WorkflowExpression.Validate(newCampaignRequesttrackingcapsulecapsuleNote, nameof(newCampaignRequesttrackingcapsulecapsuleNote), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsfeedURL, nameof(newCampaignRequestrssOptsfeedURL), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsfrequency, nameof(newCampaignRequestrssOptsfrequency), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsconstrainRSSImages, nameof(newCampaignRequestrssOptsconstrainRSSImages), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsschedulesendingHour, nameof(newCampaignRequestrssOptsschedulesendingHour), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendsunday, nameof(newCampaignRequestrssOptsscheduledailySendsunday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendmonday, nameof(newCampaignRequestrssOptsscheduledailySendmonday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendtuesday, nameof(newCampaignRequestrssOptsscheduledailySendtuesday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendwednesday, nameof(newCampaignRequestrssOptsscheduledailySendwednesday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendthursday, nameof(newCampaignRequestrssOptsscheduledailySendthursday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendfriday, nameof(newCampaignRequestrssOptsscheduledailySendfriday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduledailySendsaturday, nameof(newCampaignRequestrssOptsscheduledailySendsaturday), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsscheduleweeklySendingDay, nameof(newCampaignRequestrssOptsscheduleweeklySendingDay), required: false);
            WorkflowExpression.Validate(newCampaignRequestrssOptsschedulemonthlySendingDay, nameof(newCampaignRequestrssOptsschedulemonthlySendingDay), required: false);
            WorkflowExpression.Validate(newCampaignRequestsocialCardimageURL, nameof(newCampaignRequestsocialCardimageURL), required: false);
            WorkflowExpression.Validate(newCampaignRequestsocialCardcampaignDescription, nameof(newCampaignRequestsocialCardcampaignDescription), required: false);
            WorkflowExpression.Validate(newCampaignRequestsocialCardtitle, nameof(newCampaignRequestsocialCardtitle), required: false);
            return new DeferredBodyAction<CampaignResponseModel>(() =>
            {
                var apiCallPath = "/v2/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newCampaignRequest = new JObject();
                var newCampaignRequestpropCount = 0;
                newCampaignRequestpropCount++;
                newCampaignRequest["type"] = ExpressionConverter.ConvertO(newCampaignRequestcampaignType);
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                recipientsObjectpropCount++;
                recipientsObject["list_id"] = ExpressionConverter.ConvertO(newCampaignRequestrecipientslistId);
                var segmentOptsObject = new JObject();
                var segmentOptsObjectpropCount = 0;
                if (newCampaignRequestrecipientssegmentOptssavedSegmentID != null)
                {
                    segmentOptsObject["saved_segment_id"] = ExpressionConverter.ConvertO(newCampaignRequestrecipientssegmentOptssavedSegmentID);
                    segmentOptsObjectpropCount++;
                }

                if (newCampaignRequestrecipientssegmentOptsmatchType != null)
                {
                    segmentOptsObject["match"] = ExpressionConverter.ConvertO(newCampaignRequestrecipientssegmentOptsmatchType);
                    segmentOptsObjectpropCount++;
                }

                if (segmentOptsObjectpropCount > 0)
                {
                    recipientsObject["segment_opts"] = segmentOptsObject;
                    recipientsObjectpropCount++;
                }

                if (recipientsObjectpropCount > 0)
                {
                    newCampaignRequest["recipients"] = recipientsObject;
                    newCampaignRequestpropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                settingsObjectpropCount++;
                settingsObject["subject_line"] = ExpressionConverter.ConvertO(newCampaignRequestsettingscampaignSubjectLine);
                if (newCampaignRequestsettingstitle != null)
                {
                    settingsObject["title"] = ExpressionConverter.ConvertO(newCampaignRequestsettingstitle);
                    settingsObjectpropCount++;
                }

                settingsObjectpropCount++;
                settingsObject["from_name"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsfromName);
                settingsObjectpropCount++;
                settingsObject["reply_to"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsreplyToAddress);
                if (newCampaignRequestsettingsconversation != null)
                {
                    settingsObject["use_conversation"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsconversation);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingstoName != null)
                {
                    settingsObject["to_name"] = ExpressionConverter.ConvertO(newCampaignRequestsettingstoName);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsfolderID != null)
                {
                    settingsObject["folder_id"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsfolderID);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsauthentication != null)
                {
                    settingsObject["authenticate"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsauthentication);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoFooter != null)
                {
                    settingsObject["auto_footer"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsautoFooter);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsinlineCSS != null)
                {
                    settingsObject["inline_css"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsinlineCSS);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoTweet != null)
                {
                    settingsObject["auto_tweet"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsautoTweet);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoPostToFacebook != null)
                {
                    settingsObject["auto_fb_post"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsautoPostToFacebook);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsfacebookComments != null)
                {
                    settingsObject["fb_comments"] = ExpressionConverter.ConvertO(newCampaignRequestsettingsfacebookComments);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    newCampaignRequest["settings"] = settingsObject;
                    newCampaignRequestpropCount++;
                }

                var variateSettingsObject = new JObject();
                var variateSettingsObjectpropCount = 0;
                if (newCampaignRequestvariateSettingswinningCriteria != null)
                {
                    variateSettingsObject["winner_criteria"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingswinningCriteria);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingswaitTime != null)
                {
                    variateSettingsObject["wait_time"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingswaitTime);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingstestSize != null)
                {
                    variateSettingsObject["test_size"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingstestSize);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingssubjectLines != null)
                {
                    variateSettingsObject["subject_lines"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingssubjectLines);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingssendTimes != null)
                {
                    variateSettingsObject["send_times"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingssendTimes);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingsfromNames != null)
                {
                    variateSettingsObject["from_names"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingsfromNames);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingsreplyToAddresses != null)
                {
                    variateSettingsObject["reply_to_addresses"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingsreplyToAddresses);
                    variateSettingsObjectpropCount++;
                }

                if (variateSettingsObjectpropCount > 0)
                {
                    newCampaignRequest["variate_settings"] = variateSettingsObject;
                    newCampaignRequestpropCount++;
                }

                var trackingObject = new JObject();
                var trackingObjectpropCount = 0;
                if (newCampaignRequesttrackingopens != null)
                {
                    trackingObject["opens"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingopens);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackinghTMLClickTracking != null)
                {
                    trackingObject["html_clicks"] = ExpressionConverter.ConvertO(newCampaignRequesttrackinghTMLClickTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingplainTextClickTracking != null)
                {
                    trackingObject["text_clicks"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingplainTextClickTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingmailChimpGoalTracking != null)
                {
                    trackingObject["goal_tracking"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingmailChimpGoalTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingeCommerce360Tracking != null)
                {
                    trackingObject["ecomm360"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingeCommerce360Tracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackinggoogleAnalyticsTracking != null)
                {
                    trackingObject["google_analytics"] = ExpressionConverter.ConvertO(newCampaignRequesttrackinggoogleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingclickTaleAnalyticsTracking != null)
                {
                    trackingObject["clicktale"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingclickTaleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                var salesforceObject = new JObject();
                var salesforceObjectpropCount = 0;
                if (newCampaignRequesttrackingsalesforcesalesforceCampaign != null)
                {
                    salesforceObject["campaign"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingsalesforcesalesforceCampaign);
                    salesforceObjectpropCount++;
                }

                if (newCampaignRequesttrackingsalesforcesalesforceNote != null)
                {
                    salesforceObject["notes"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingsalesforcesalesforceNote);
                    salesforceObjectpropCount++;
                }

                if (salesforceObjectpropCount > 0)
                {
                    trackingObject["salesforce"] = salesforceObject;
                    trackingObjectpropCount++;
                }

                var highriseObject = new JObject();
                var highriseObjectpropCount = 0;
                if (newCampaignRequesttrackinghighrisehighriseCampaign != null)
                {
                    highriseObject["campaign"] = ExpressionConverter.ConvertO(newCampaignRequesttrackinghighrisehighriseCampaign);
                    highriseObjectpropCount++;
                }

                if (newCampaignRequesttrackinghighrisehighriseNote != null)
                {
                    highriseObject["notes"] = ExpressionConverter.ConvertO(newCampaignRequesttrackinghighrisehighriseNote);
                    highriseObjectpropCount++;
                }

                if (highriseObjectpropCount > 0)
                {
                    trackingObject["highrise"] = highriseObject;
                    trackingObjectpropCount++;
                }

                var capsuleObject = new JObject();
                var capsuleObjectpropCount = 0;
                if (newCampaignRequesttrackingcapsulecapsuleNote != null)
                {
                    capsuleObject["notes"] = ExpressionConverter.ConvertO(newCampaignRequesttrackingcapsulecapsuleNote);
                    capsuleObjectpropCount++;
                }

                if (capsuleObjectpropCount > 0)
                {
                    trackingObject["capsule"] = capsuleObject;
                    trackingObjectpropCount++;
                }

                if (trackingObjectpropCount > 0)
                {
                    newCampaignRequest["tracking"] = trackingObject;
                    newCampaignRequestpropCount++;
                }

                var rssOptsObject = new JObject();
                var rssOptsObjectpropCount = 0;
                if (newCampaignRequestrssOptsfeedURL != null)
                {
                    rssOptsObject["feed_url"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsfeedURL);
                    rssOptsObjectpropCount++;
                }

                if (newCampaignRequestrssOptsfrequency != null)
                {
                    rssOptsObject["frequency"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsfrequency);
                    rssOptsObjectpropCount++;
                }

                if (newCampaignRequestrssOptsconstrainRSSImages != null)
                {
                    rssOptsObject["constrain_rss_img"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsconstrainRSSImages);
                    rssOptsObjectpropCount++;
                }

                var scheduleObject = new JObject();
                var scheduleObjectpropCount = 0;
                if (newCampaignRequestrssOptsschedulesendingHour != null)
                {
                    scheduleObject["hour"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsschedulesendingHour);
                    scheduleObjectpropCount++;
                }

                var dailySendObject = new JObject();
                var dailySendObjectpropCount = 0;
                if (newCampaignRequestrssOptsscheduledailySendsunday != null)
                {
                    dailySendObject["sunday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendsunday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendmonday != null)
                {
                    dailySendObject["monday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendmonday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendtuesday != null)
                {
                    dailySendObject["tuesday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendtuesday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendwednesday != null)
                {
                    dailySendObject["wednesday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendwednesday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendthursday != null)
                {
                    dailySendObject["thursday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendthursday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendfriday != null)
                {
                    dailySendObject["friday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendfriday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendsaturday != null)
                {
                    dailySendObject["saturday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendsaturday);
                    dailySendObjectpropCount++;
                }

                if (dailySendObjectpropCount > 0)
                {
                    scheduleObject["daily_send"] = dailySendObject;
                    scheduleObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduleweeklySendingDay != null)
                {
                    scheduleObject["weekly_send_day"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduleweeklySendingDay);
                    scheduleObjectpropCount++;
                }

                if (newCampaignRequestrssOptsschedulemonthlySendingDay != null)
                {
                    scheduleObject["monthly_send_date"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsschedulemonthlySendingDay);
                    scheduleObjectpropCount++;
                }

                if (scheduleObjectpropCount > 0)
                {
                    rssOptsObject["schedule"] = scheduleObject;
                    rssOptsObjectpropCount++;
                }

                if (rssOptsObjectpropCount > 0)
                {
                    newCampaignRequest["rss_opts"] = rssOptsObject;
                    newCampaignRequestpropCount++;
                }

                var socialCardObject = new JObject();
                var socialCardObjectpropCount = 0;
                if (newCampaignRequestsocialCardimageURL != null)
                {
                    socialCardObject["image_url"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardimageURL);
                    socialCardObjectpropCount++;
                }

                if (newCampaignRequestsocialCardcampaignDescription != null)
                {
                    socialCardObject["description"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardcampaignDescription);
                    socialCardObjectpropCount++;
                }

                if (newCampaignRequestsocialCardtitle != null)
                {
                    socialCardObject["title"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardtitle);
                    socialCardObjectpropCount++;
                }

                if (socialCardObjectpropCount > 0)
                {
                    newCampaignRequest["social_card"] = socialCardObject;
                    newCampaignRequestpropCount++;
                }

                if (newCampaignRequestpropCount > 0)
                {
                    callPayload.Body = newCampaignRequest;
                }

                return new ApiConnectionAction<CampaignResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildRemovemember))]
        public IWorkflowAction Removemember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> memberEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemovemember(WorkflowExpression<string> listId, WorkflowExpression<string> memberEmail)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(memberEmail, nameof(memberEmail), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(memberEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatemember))]
        public IBodyWorkflowAction<MemberResponseModel> Updatemember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> memberEmail, [WorkflowExpression] Func<updateMemberInListRequeststatusInput> updateMemberInListRequeststatus, [WorkflowExpression] Func<updateMemberInListRequestemailTypeInput> updateMemberInListRequestemailType = null, [WorkflowExpression] Func<string> updateMemberInListRequestmergeFieldsfirstName = null, [WorkflowExpression] Func<string> updateMemberInListRequestmergeFieldslastName = null, [WorkflowExpression] Func<string> updateMemberInListRequestlanguage = null, [WorkflowExpression] Func<bool> updateMemberInListRequestvIP = null, [WorkflowExpression] Func<double> updateMemberInListRequestlocationlatitude = null, [WorkflowExpression] Func<double> updateMemberInListRequestlocationlongitude = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MemberResponseModel> __BuildUpdatemember(WorkflowExpression<string> listId, WorkflowExpression<string> memberEmail, WorkflowExpression<updateMemberInListRequeststatusInput> updateMemberInListRequeststatus, WorkflowExpression<updateMemberInListRequestemailTypeInput> updateMemberInListRequestemailType = null, WorkflowExpression<string> updateMemberInListRequestmergeFieldsfirstName = null, WorkflowExpression<string> updateMemberInListRequestmergeFieldslastName = null, WorkflowExpression<string> updateMemberInListRequestlanguage = null, WorkflowExpression<bool> updateMemberInListRequestvIP = null, WorkflowExpression<double> updateMemberInListRequestlocationlatitude = null, WorkflowExpression<double> updateMemberInListRequestlocationlongitude = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(memberEmail, nameof(memberEmail), required: true);
            WorkflowExpression.Validate(updateMemberInListRequeststatus, nameof(updateMemberInListRequeststatus), required: true);
            WorkflowExpression.Validate(updateMemberInListRequestemailType, nameof(updateMemberInListRequestemailType), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestmergeFieldsfirstName, nameof(updateMemberInListRequestmergeFieldsfirstName), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestmergeFieldslastName, nameof(updateMemberInListRequestmergeFieldslastName), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestlanguage, nameof(updateMemberInListRequestlanguage), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestvIP, nameof(updateMemberInListRequestvIP), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestlocationlatitude, nameof(updateMemberInListRequestlocationlatitude), required: false);
            WorkflowExpression.Validate(updateMemberInListRequestlocationlongitude, nameof(updateMemberInListRequestlocationlongitude), required: false);
            return new DeferredBodyAction<MemberResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(memberEmail);
                var updateMemberInListRequest = new JObject();
                var updateMemberInListRequestpropCount = 0;
                if (updateMemberInListRequestemailType != null)
                {
                    if (updateMemberInListRequestemailType != null)
                    {
                        updateMemberInListRequest["email_type"] = ExpressionConverter.ConvertO(updateMemberInListRequestemailType);
                        updateMemberInListRequestpropCount++;
                    }

                    updateMemberInListRequestpropCount++;
                }
                else
                {
                    updateMemberInListRequest["email_type"] = "html";
                    updateMemberInListRequestpropCount++;
                }

                updateMemberInListRequestpropCount++;
                updateMemberInListRequest["status"] = ExpressionConverter.ConvertO(updateMemberInListRequeststatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (updateMemberInListRequestmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = ExpressionConverter.ConvertO(updateMemberInListRequestmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (updateMemberInListRequestmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = ExpressionConverter.ConvertO(updateMemberInListRequestmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    updateMemberInListRequest["merge_fields"] = mergeFieldsObject;
                    updateMemberInListRequestpropCount++;
                }

                if (updateMemberInListRequestlanguage != null)
                {
                    updateMemberInListRequest["language"] = ExpressionConverter.ConvertO(updateMemberInListRequestlanguage);
                    updateMemberInListRequestpropCount++;
                }

                if (updateMemberInListRequestvIP != null)
                {
                    updateMemberInListRequest["vip"] = ExpressionConverter.ConvertO(updateMemberInListRequestvIP);
                    updateMemberInListRequestpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (updateMemberInListRequestlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(updateMemberInListRequestlocationlatitude);
                    locationObjectpropCount++;
                }

                if (updateMemberInListRequestlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(updateMemberInListRequestlocationlongitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    updateMemberInListRequest["location"] = locationObject;
                    updateMemberInListRequestpropCount++;
                }

                if (updateMemberInListRequestpropCount > 0)
                {
                    callPayload.Body = updateMemberInListRequest;
                }

                return new ApiConnectionAction<MemberResponseModel>(callPayload);
            });
        }
    }

    public class MailchimpTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnMemberSubscribed))]
        public IBodyWorkflowTrigger<GetMembersResponseModel> OnMemberSubscribed([WorkflowExpression] Func<string> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetMembersResponseModel> __BuildOnMemberSubscribed(WorkflowExpression<string> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<GetMembersResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetMembersResponseModel>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<GetListsResponseModel> OnCreateList(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetListsResponseModel>(callPayload, triggerName, recurrence);
        }
    }

    public class GetCampaignsResponse
    {
        [JsonProperty("campaigns")]
        public CampaignResponseModel[] Campaigns { get; set; }
    }

    public class CampaignResponseModel
    {
        [JsonProperty("id")]
        public string CampaignID { get; set; }

        [JsonProperty("type")]
        public CampaignResponseModelCampaignTypeType CampaignType { get; set; }

        [JsonProperty("create_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveURL { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("recipient")]
        public Recipient[] List { get; set; }

        [JsonProperty("settings")]
        public SettingsV2 Settings { get; set; }

        [JsonProperty("variate_settings")]
        public VariateSettings VariateSettings { get; set; }

        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        [JsonProperty("rss_opts")]
        public RSSOpts RssOpts { get; set; }

        [JsonProperty("ab_split_opts")]
        public ABSplitOpts AbSplitOpts { get; set; }

        [JsonProperty("social_card")]
        public SocialCard SocialCard { get; set; }

        [JsonProperty("report_summary")]
        public ReportSummary ReportSummary { get; set; }

        [JsonProperty("delivery_status")]
        public DeliveryStatus DeliveryStatus { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public enum CampaignResponseModelCampaignTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "plaintext")]
        Plaintext,
        [EnumMember(Value = "absplit")]
        Absplit,
        [EnumMember(Value = "rss")]
        Rss,
        [EnumMember(Value = "variate")]
        Variate
    }

    public class Recipient
    {
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("segment_opts")]
        public SegmentOpts SegmentOpts { get; set; }
    }

    public class SegmentOpts
    {
        [JsonProperty("saved_segment_id")]
        public int SavedSegmentID { get; set; }

        [JsonProperty("match")]
        public string MatchType { get; set; }
    }

    public class SettingsV2
    {
        [JsonProperty("subject_line")]
        public string CampaignSubjectLine { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyToAddress { get; set; }

        [JsonProperty("use_conversation")]
        public bool Conversation { get; set; }

        [JsonProperty("to_name")]
        public string ToName { get; set; }

        [JsonProperty("folder_id")]
        public string FolderID { get; set; }

        [JsonProperty("authenticate")]
        public bool Authentication { get; set; }

        [JsonProperty("auto_footer")]
        public bool AutoFooter { get; set; }

        [JsonProperty("inline_css")]
        public bool InlineCSS { get; set; }

        [JsonProperty("auto_tweet")]
        public bool AutoTweet { get; set; }

        [JsonProperty("auto_fb_post")]
        public int[] AutoPostToFacebook { get; set; }

        [JsonProperty("fb_comments")]
        public bool FacebookComments { get; set; }
    }

    public class VariateSettings
    {
        [JsonProperty("winner_criteria")]
        public string WinningCriteria { get; set; }

        [JsonProperty("wait_time")]
        public int WaitTime { get; set; }

        [JsonProperty("test_size")]
        public int TestSize { get; set; }

        [JsonProperty("subject_lines")]
        public string[] SubjectLines { get; set; }

        [JsonProperty("send_times")]
        public string[] SendTimes { get; set; }

        [JsonProperty("from_names")]
        public string[] FromNames { get; set; }

        [JsonProperty("reply_to_addresses")]
        public string[] ReplyToAddresses { get; set; }
    }

    public class Tracking
    {
        [JsonProperty("opens")]
        public bool Opens { get; set; }

        [JsonProperty("html_clicks")]
        public bool HTMLClickTracking { get; set; }

        [JsonProperty("text_clicks")]
        public bool PlainTextClickTracking { get; set; }

        [JsonProperty("goal_tracking")]
        public bool MailChimpGoalTracking { get; set; }

        [JsonProperty("ecomm360")]
        public bool ECommerce360Tracking { get; set; }

        [JsonProperty("google_analytics")]
        public string GoogleAnalyticsTracking { get; set; }

        [JsonProperty("clicktale")]
        public string ClickTaleAnalyticsTracking { get; set; }

        [JsonProperty("salesforce")]
        public Salesforce Salesforce { get; set; }

        [JsonProperty("highrise")]
        public Highrise Highrise { get; set; }

        [JsonProperty("capsule")]
        public Capsule Capsule { get; set; }
    }

    public class Salesforce
    {
        [JsonProperty("campaign")]
        public bool SalesforceCampaign { get; set; }

        [JsonProperty("notes")]
        public bool SalesforceNote { get; set; }
    }

    public class Highrise
    {
        [JsonProperty("campaign")]
        public bool HighriseCampaign { get; set; }

        [JsonProperty("notes")]
        public bool HighriseNote { get; set; }
    }

    public class Capsule
    {
        [JsonProperty("notes")]
        public bool CapsuleNote { get; set; }
    }

    public class RSSOpts
    {
        [JsonProperty("feed_url")]
        public string FeedURL { get; set; }

        [JsonProperty("frequency")]
        public RSSOptsFrequencyType Frequency { get; set; }

        [JsonProperty("constrain_rss_img")]
        public string ConstrainRSSImages { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }
    }

    public enum RSSOptsFrequencyType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly
    }

    public class Schedule
    {
        [JsonProperty("hour")]
        public int SendingHour { get; set; }

        [JsonProperty("daily_send")]
        public DailySend DailySend { get; set; }

        [JsonProperty("weekly_send_day")]
        public ScheduleWeeklySendingDayType WeeklySendingDay { get; set; }

        [JsonProperty("monthly_send_date")]
        public double MonthlySendingDay { get; set; }
    }

    public class DailySend
    {
        [JsonProperty("sunday")]
        public bool Sunday { get; set; }

        [JsonProperty("monday")]
        public bool Monday { get; set; }

        [JsonProperty("tuesday")]
        public bool Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public bool Wednesday { get; set; }

        [JsonProperty("thursday")]
        public bool Thursday { get; set; }

        [JsonProperty("friday")]
        public bool Friday { get; set; }

        [JsonProperty("saturday")]
        public bool Saturday { get; set; }
    }

    public enum ScheduleWeeklySendingDayType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "sunday")]
        Sunday,
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "tuesday")]
        Tuesday,
        [EnumMember(Value = "wednesday")]
        Wednesday,
        [EnumMember(Value = "thursday")]
        Thursday,
        [EnumMember(Value = "friday")]
        Friday,
        [EnumMember(Value = "saturday")]
        Saturday
    }

    public class ABSplitOpts
    {
        [JsonProperty("split_test")]
        public string SplitTest { get; set; }

        [JsonProperty("pick_winner")]
        public string PickWinner { get; set; }

        [JsonProperty("wait_time")]
        public int WaitTime { get; set; }

        [JsonProperty("split_size")]
        public int SplitSize { get; set; }

        [JsonProperty("from_name_a")]
        public string FromNameGroupA { get; set; }

        [JsonProperty("from_name_b")]
        public string FromNameGroupB { get; set; }

        [JsonProperty("reply_email_a")]
        public string ReplyEmailGroupA { get; set; }

        [JsonProperty("reply_email_b")]
        public string ReplyEmailGroupB { get; set; }

        [JsonProperty("subject_a")]
        public string SubjectLineGroupA { get; set; }

        [JsonProperty("subject_b")]
        public string SubjectLineGroupB { get; set; }

        [JsonProperty("send_time_a")]
        public string SendTimeGroupA { get; set; }

        [JsonProperty("send_time_b")]
        public string SendTimeGroupB { get; set; }

        [JsonProperty("send_time_winner")]
        public string SendTimeWinner { get; set; }
    }

    public class SocialCard
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("description")]
        public string CampaignDescription { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ReportSummary
    {
        [JsonProperty("opens")]
        public int AutomationOpens { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("clicks")]
        public int TotalClicks { get; set; }

        [JsonProperty("subscriber_clicks")]
        public double UniqueSubscriberClicks { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }
    }

    public class DeliveryStatus
    {
        [JsonProperty("enabled")]
        public bool DeliveryStautEnabled { get; set; }

        [JsonProperty("can_cancel")]
        public bool CampaignCancelable { get; set; }

        [JsonProperty("status")]
        public string CampaignDeliveryStatus { get; set; }

        [JsonProperty("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonProperty("emails_canceled")]
        public int EmailsCanceled { get; set; }
    }

    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("targetSchema")]
        public string TargetSchema { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class GetListsResponseModel
    {
        [JsonProperty("lists")]
        public CreateNewListResponseModel[] Lists { get; set; }

        [JsonProperty("total_items")]
        public int ItemCount { get; set; }
    }

    public class CreateNewListResponseModel
    {
        [JsonProperty("id")]
        public string ListID { get; set; }

        [JsonProperty("name")]
        public string ListName { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("permission_reminder")]
        public string PermissionReminder { get; set; }

        [JsonProperty("use_archive_bar")]
        public bool UseArchiveBar { get; set; }

        [JsonProperty("campaign_defaults")]
        public CampaignDefaults CampaignDefaults { get; set; }

        [JsonProperty("notify_on_subscribe")]
        public string NotifyOnSubscribe { get; set; }

        [JsonProperty("notify_on_unsubscribe")]
        public string NotifyOnUnsubscribe { get; set; }

        [JsonProperty("date_created")]
        public string CreationDate { get; set; }

        [JsonProperty("list_rating")]
        public int ListRating { get; set; }

        [JsonProperty("email_type_option")]
        public bool EmailTypeOption { get; set; }

        [JsonProperty("subscribe_url_short")]
        public string SubscribeURLShort { get; set; }

        [JsonProperty("subscribe_url_long")]
        public string SubscribeURLLong { get; set; }

        [JsonProperty("beamer_address")]
        public string BeamerAddress { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("modules")]
        public string[] Modules { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public class Contact
    {
        [JsonProperty("company")]
        public string CompanyName { get; set; }

        [JsonProperty("address1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }
    }

    public class CampaignDefaults
    {
        [JsonProperty("from_name")]
        public string SenderSName { get; set; }

        [JsonProperty("from_email")]
        public string SenderSEmailAddress { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("language")]
        public CampaignDefaultsLanguageType Language { get; set; }
    }

    public enum CampaignDefaultsLanguageType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "af")]
        Af,
        [EnumMember(Value = "be")]
        Be,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh")]
        Zh,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fa")]
        Fa,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "fr_CA")]
        FrCA,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "ga")]
        Ga,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "km")]
        Km,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "mk")]
        Mk,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "pt_PT")]
        PtPT,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "es_ES")]
        EsES,
        [EnumMember(Value = "sw")]
        Sw,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    public class Stats
    {
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [JsonProperty("cleaned_count")]
        public int CleanedCount { get; set; }

        [JsonProperty("member_count_since_send")]
        public int MemberCountSinceSend { get; set; }

        [JsonProperty("unsubscribe_count_since_send")]
        public int UnsubscribeCountSinceSend { get; set; }

        [JsonProperty("cleaned_count_since_send")]
        public int CleanedCountSinceSend { get; set; }

        [JsonProperty("campaign_count")]
        public int CampaignCount { get; set; }

        [JsonProperty("campaign_last_sent")]
        public string CampaignLastSent { get; set; }

        [JsonProperty("merge_field_count")]
        public int MergeVarCount { get; set; }

        [JsonProperty("avg_sub_rate")]
        public double AverageSubscriptionRate { get; set; }

        [JsonProperty("avg_unsub_rate")]
        public double AverageUnsubscriptionRate { get; set; }

        [JsonProperty("target_sub_rate")]
        public double TargetSubscriptionRate { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        [JsonProperty("last_sub_date")]
        public string DateOfLastListSubscribe { get; set; }

        [JsonProperty("last_unsub_date")]
        public string DateOfLastListUnsubscribe { get; set; }
    }

    public enum newListRequestcampaignDefaultslanguageInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "af")]
        Af,
        [EnumMember(Value = "be")]
        Be,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh")]
        Zh,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fa")]
        Fa,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "fr_CA")]
        FrCA,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "ga")]
        Ga,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "km")]
        Km,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "mk")]
        Mk,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "pt_PT")]
        PtPT,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "es_ES")]
        EsES,
        [EnumMember(Value = "sw")]
        Sw,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    public enum newListRequestvisibilityInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "pub")]
        Pub,
        [EnumMember(Value = "prv")]
        Prv
    }

    public class GetAddMembersBatchResponseModel
    {
        [JsonProperty("total_created")]
        public int TotalCreated { get; set; }

        [JsonProperty("total_updated")]
        public int TotalUpdated { get; set; }

        [JsonProperty("error_count")]
        public int ErrorCount { get; set; }
    }

    public class NewMemberInListRequest
    {
        [JsonProperty("email_type")]
        public NewMemberInListRequestEmailTypeType EmailType { get; set; }

        [JsonProperty("status")]
        public NewMemberInListRequestStatusType Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public enum NewMemberInListRequestEmailTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    public enum NewMemberInListRequestStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public class FirstAndLastName
    {
        [JsonProperty("FNAME")]
        public string FirstName { get; set; }

        [JsonProperty("LNAME")]
        public string LastName { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class GetAllMembersResponseModel
    {
        [JsonProperty("members")]
        public MemberResponseModel[] Members { get; set; }

        [JsonProperty("list_id")]
        public string ListId { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class MemberResponseModel
    {
        [JsonProperty("id")]
        public string EmailID { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id")]
        public string UniqueEmailID { get; set; }

        [JsonProperty("email_type")]
        public string EmailType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup")]
        public string SignupIP { get; set; }

        [JsonProperty("timestamp_signup")]
        public string SignupTimestamp { get; set; }

        [JsonProperty("ip_opt")]
        public string OptInIP { get; set; }

        [JsonProperty("timestamp_opt")]
        public string OptInTimestamp { get; set; }

        [JsonProperty("member_rating")]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed")]
        public string LastChangedDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("email_client")]
        public string EmailClient { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("last_note")]
        public LastNote LastNote { get; set; }

        [JsonProperty("list_id")]
        public string ListID { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }

    public class LastNote
    {
        [JsonProperty("note_id")]
        public int NoteID { get; set; }

        [JsonProperty("created_at")]
        public string CreatedTime { get; set; }

        [JsonProperty("created_by")]
        public string Author { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public enum newMemberInListstatusInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public enum newMemberInListemailTypeInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    public enum newCampaignRequestcampaignTypeInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "plaintext")]
        Plaintext,
        [EnumMember(Value = "absplit")]
        Absplit,
        [EnumMember(Value = "rss")]
        Rss,
        [EnumMember(Value = "variate")]
        Variate
    }

    public enum newCampaignRequestrssOptsfrequencyInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "monthly")]
        Monthly
    }

    public enum newCampaignRequestrssOptsscheduleweeklySendingDayInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "sunday")]
        Sunday,
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "tuesday")]
        Tuesday,
        [EnumMember(Value = "wednesday")]
        Wednesday,
        [EnumMember(Value = "thursday")]
        Thursday,
        [EnumMember(Value = "friday")]
        Friday,
        [EnumMember(Value = "saturday")]
        Saturday
    }

    public enum updateMemberInListRequeststatusInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "subscribed")]
        Subscribed,
        [EnumMember(Value = "unsubscribed")]
        Unsubscribed,
        [EnumMember(Value = "cleaned")]
        Cleaned,
        [EnumMember(Value = "pending")]
        Pending
    }

    public enum updateMemberInListRequestemailTypeInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    public class GetMembersResponseModel
    {
        [JsonProperty("members")]
        public AddUserResponseModel[] Members { get; set; }

        [JsonProperty("list_id")]
        public string ListID { get; set; }

        [JsonProperty("total_items")]
        public int ItemCount { get; set; }
    }

    public class AddUserResponseModel
    {
        [JsonProperty("id")]
        public string EmailID { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("unique_email_id")]
        public string UniqueEmailID { get; set; }

        [JsonProperty("email_type")]
        public string EmailType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("merge_fields")]
        public FirstAndLastName MergeFields { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("ip_signup")]
        public string SignupIP { get; set; }

        [JsonProperty("timestamp_signup")]
        public string SignupTimestamp { get; set; }

        [JsonProperty("ip_opt")]
        public string OptInIP { get; set; }

        [JsonProperty("timestamp_opt")]
        public string OptInTimestamp { get; set; }

        [JsonProperty("member_rating")]
        public int MemberRating { get; set; }

        [JsonProperty("last_changed")]
        public string LastChangedDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("vip")]
        public bool VIP { get; set; }

        [JsonProperty("email_client")]
        public string EmailClient { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("last_note")]
        public LastNote LastNote { get; set; }

        [JsonProperty("list_id")]
        public string ListID { get; set; }

        [JsonProperty("_links")]
        public Link[] Links { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp;

    public partial class WorkflowManagedActions
    {
        public MailchimpActions Mailchimp(string connectionId) => new MailchimpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailchimpTriggers Mailchimp(string connectionId) => new MailchimpTriggers(connectionId);
    }
}