//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IWorkflowAction Sendcampaign(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = campaignId == null ? null : WorkflowExpression.Compile(campaignId);
            WorkflowExpression.Validate(__workflow_campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/actions/send", ExpressionConverter.ConvertWithUrlEncoding(__workflow_campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetListsResponseModel> GetLists(Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetListsResponseModel>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<GetListsResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CreateNewListResponseModel> Newlist(Expression<Func<string>> newListRequestlistName, Expression<Func<string>> newListRequestcontactcompanyName, Expression<Func<string>> newListRequestcontactaddressLine1, Expression<Func<string>> newListRequestcontactcity, Expression<Func<string>> newListRequestcontactstate, Expression<Func<string>> newListRequestcontactpostalCode, Expression<Func<string>> newListRequestcontactcountryCode, Expression<Func<string>> newListRequestcontactphoneNumber, Expression<Func<string>> newListRequestpermissionReminder, Expression<Func<string>> newListRequestcampaignDefaultssenderSName, Expression<Func<string>> newListRequestcampaignDefaultssenderSEmailAddress, Expression<Func<string>> newListRequestcampaignDefaultssubject, Expression<Func<newListRequestcampaignDefaultslanguageInput>> newListRequestcampaignDefaultslanguage, Expression<Func<bool>> newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, Expression<Func<string>> newListRequestcontactaddressLine2 = null, Expression<Func<bool>> newListRequestuseArchiveBar = null, Expression<Func<string>> newListRequestnotifyOnSubscribe = null, Expression<Func<string>> newListRequestnotifyOnUnsubscribe = null, Expression<Func<newListRequestvisibilityInput>> newListRequestvisibility = null)
        {
            var __workflow_newListRequestlistName = newListRequestlistName == null ? null : WorkflowExpression.Compile(newListRequestlistName);
            WorkflowExpression.Validate(__workflow_newListRequestlistName, nameof(newListRequestlistName), required: true);
            var __workflow_newListRequestcontactcompanyName = newListRequestcontactcompanyName == null ? null : WorkflowExpression.Compile(newListRequestcontactcompanyName);
            WorkflowExpression.Validate(__workflow_newListRequestcontactcompanyName, nameof(newListRequestcontactcompanyName), required: true);
            var __workflow_newListRequestcontactaddressLine1 = newListRequestcontactaddressLine1 == null ? null : WorkflowExpression.Compile(newListRequestcontactaddressLine1);
            WorkflowExpression.Validate(__workflow_newListRequestcontactaddressLine1, nameof(newListRequestcontactaddressLine1), required: true);
            var __workflow_newListRequestcontactcity = newListRequestcontactcity == null ? null : WorkflowExpression.Compile(newListRequestcontactcity);
            WorkflowExpression.Validate(__workflow_newListRequestcontactcity, nameof(newListRequestcontactcity), required: true);
            var __workflow_newListRequestcontactstate = newListRequestcontactstate == null ? null : WorkflowExpression.Compile(newListRequestcontactstate);
            WorkflowExpression.Validate(__workflow_newListRequestcontactstate, nameof(newListRequestcontactstate), required: true);
            var __workflow_newListRequestcontactpostalCode = newListRequestcontactpostalCode == null ? null : WorkflowExpression.Compile(newListRequestcontactpostalCode);
            WorkflowExpression.Validate(__workflow_newListRequestcontactpostalCode, nameof(newListRequestcontactpostalCode), required: true);
            var __workflow_newListRequestcontactcountryCode = newListRequestcontactcountryCode == null ? null : WorkflowExpression.Compile(newListRequestcontactcountryCode);
            WorkflowExpression.Validate(__workflow_newListRequestcontactcountryCode, nameof(newListRequestcontactcountryCode), required: true);
            var __workflow_newListRequestcontactphoneNumber = newListRequestcontactphoneNumber == null ? null : WorkflowExpression.Compile(newListRequestcontactphoneNumber);
            WorkflowExpression.Validate(__workflow_newListRequestcontactphoneNumber, nameof(newListRequestcontactphoneNumber), required: true);
            var __workflow_newListRequestpermissionReminder = newListRequestpermissionReminder == null ? null : WorkflowExpression.Compile(newListRequestpermissionReminder);
            WorkflowExpression.Validate(__workflow_newListRequestpermissionReminder, nameof(newListRequestpermissionReminder), required: true);
            var __workflow_newListRequestcampaignDefaultssenderSName = newListRequestcampaignDefaultssenderSName == null ? null : WorkflowExpression.Compile(newListRequestcampaignDefaultssenderSName);
            WorkflowExpression.Validate(__workflow_newListRequestcampaignDefaultssenderSName, nameof(newListRequestcampaignDefaultssenderSName), required: true);
            var __workflow_newListRequestcampaignDefaultssenderSEmailAddress = newListRequestcampaignDefaultssenderSEmailAddress == null ? null : WorkflowExpression.Compile(newListRequestcampaignDefaultssenderSEmailAddress);
            WorkflowExpression.Validate(__workflow_newListRequestcampaignDefaultssenderSEmailAddress, nameof(newListRequestcampaignDefaultssenderSEmailAddress), required: true);
            var __workflow_newListRequestcampaignDefaultssubject = newListRequestcampaignDefaultssubject == null ? null : WorkflowExpression.Compile(newListRequestcampaignDefaultssubject);
            WorkflowExpression.Validate(__workflow_newListRequestcampaignDefaultssubject, nameof(newListRequestcampaignDefaultssubject), required: true);
            var __workflow_newListRequestcampaignDefaultslanguage = newListRequestcampaignDefaultslanguage == null ? null : WorkflowExpression.Compile(newListRequestcampaignDefaultslanguage);
            WorkflowExpression.Validate(__workflow_newListRequestcampaignDefaultslanguage, nameof(newListRequestcampaignDefaultslanguage), required: true);
            var __workflow_newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse = newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse == null ? null : WorkflowExpression.Compile(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse);
            WorkflowExpression.Validate(__workflow_newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, nameof(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse), required: true);
            var __workflow_newListRequestcontactaddressLine2 = newListRequestcontactaddressLine2 == null ? null : WorkflowExpression.Compile(newListRequestcontactaddressLine2);
            WorkflowExpression.Validate(__workflow_newListRequestcontactaddressLine2, nameof(newListRequestcontactaddressLine2), required: false);
            var __workflow_newListRequestuseArchiveBar = newListRequestuseArchiveBar == null ? null : WorkflowExpression.Compile(newListRequestuseArchiveBar);
            WorkflowExpression.Validate(__workflow_newListRequestuseArchiveBar, nameof(newListRequestuseArchiveBar), required: false);
            var __workflow_newListRequestnotifyOnSubscribe = newListRequestnotifyOnSubscribe == null ? null : WorkflowExpression.Compile(newListRequestnotifyOnSubscribe);
            WorkflowExpression.Validate(__workflow_newListRequestnotifyOnSubscribe, nameof(newListRequestnotifyOnSubscribe), required: false);
            var __workflow_newListRequestnotifyOnUnsubscribe = newListRequestnotifyOnUnsubscribe == null ? null : WorkflowExpression.Compile(newListRequestnotifyOnUnsubscribe);
            WorkflowExpression.Validate(__workflow_newListRequestnotifyOnUnsubscribe, nameof(newListRequestnotifyOnUnsubscribe), required: false);
            var __workflow_newListRequestvisibility = newListRequestvisibility == null ? null : WorkflowExpression.Compile(newListRequestvisibility);
            WorkflowExpression.Validate(__workflow_newListRequestvisibility, nameof(newListRequestvisibility), required: false);
            return new DeferredBodyAction<CreateNewListResponseModel>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newListRequest = new JObject();
                var newListRequestpropCount = 0;
                newListRequestpropCount++;
                newListRequest["name"] = ExpressionConverter.ConvertO(__workflow_newListRequestlistName);
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                contactObjectpropCount++;
                contactObject["company"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactcompanyName);
                contactObjectpropCount++;
                contactObject["address1"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactaddressLine1);
                if (__workflow_newListRequestcontactaddressLine2 != null)
                {
                    contactObject["address2"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactaddressLine2);
                    contactObjectpropCount++;
                }

                contactObjectpropCount++;
                contactObject["city"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactcity);
                contactObjectpropCount++;
                contactObject["state"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactstate);
                contactObjectpropCount++;
                contactObject["zip"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactpostalCode);
                contactObjectpropCount++;
                contactObject["country"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactcountryCode);
                contactObjectpropCount++;
                contactObject["phone"] = ExpressionConverter.ConvertO(__workflow_newListRequestcontactphoneNumber);
                if (contactObjectpropCount > 0)
                {
                    newListRequest["contact"] = contactObject;
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["permission_reminder"] = ExpressionConverter.ConvertO(__workflow_newListRequestpermissionReminder);
                if (__workflow_newListRequestuseArchiveBar != null)
                {
                    newListRequest["use_archive_bar"] = ExpressionConverter.ConvertO(__workflow_newListRequestuseArchiveBar);
                    newListRequestpropCount++;
                }

                var campaignDefaultsObject = new JObject();
                var campaignDefaultsObjectpropCount = 0;
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_name"] = ExpressionConverter.ConvertO(__workflow_newListRequestcampaignDefaultssenderSName);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_email"] = ExpressionConverter.ConvertO(__workflow_newListRequestcampaignDefaultssenderSEmailAddress);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["subject"] = ExpressionConverter.ConvertO(__workflow_newListRequestcampaignDefaultssubject);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["language"] = ExpressionConverter.ConvertO(__workflow_newListRequestcampaignDefaultslanguage);
                if (campaignDefaultsObjectpropCount > 0)
                {
                    newListRequest["campaign_defaults"] = campaignDefaultsObject;
                    newListRequestpropCount++;
                }

                if (__workflow_newListRequestnotifyOnSubscribe != null)
                {
                    newListRequest["notify_on_subscribe"] = ExpressionConverter.ConvertO(__workflow_newListRequestnotifyOnSubscribe);
                    newListRequestpropCount++;
                }

                if (__workflow_newListRequestnotifyOnUnsubscribe != null)
                {
                    newListRequest["notify_on_unsubscribe"] = ExpressionConverter.ConvertO(__workflow_newListRequestnotifyOnUnsubscribe);
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["email_type_option"] = ExpressionConverter.ConvertO(__workflow_newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse);
                if (__workflow_newListRequestvisibility != null)
                {
                    newListRequest["visibility"] = ExpressionConverter.ConvertO(__workflow_newListRequestvisibility);
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
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> AddMembers(Expression<Func<string>> listId, Expression<Func<NewMemberInListRequest[]>> bodymembers, Expression<Func<bool>> skipMergeValidation = null, Expression<Func<bool>> skipDuplicateCheck = null, Expression<Func<bool>> bodyupdateExisting = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: true);
            var __workflow_skipMergeValidation = skipMergeValidation == null ? null : WorkflowExpression.Compile(skipMergeValidation);
            WorkflowExpression.Validate(__workflow_skipMergeValidation, nameof(skipMergeValidation), required: false);
            var __workflow_skipDuplicateCheck = skipDuplicateCheck == null ? null : WorkflowExpression.Compile(skipDuplicateCheck);
            WorkflowExpression.Validate(__workflow_skipDuplicateCheck, nameof(skipDuplicateCheck), required: false);
            var __workflow_bodyupdateExisting = bodyupdateExisting == null ? null : WorkflowExpression.Compile(bodyupdateExisting);
            WorkflowExpression.Validate(__workflow_bodyupdateExisting, nameof(bodyupdateExisting), required: false);
            return new DeferredBodyAction<GetAddMembersBatchResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_skipMergeValidation != null)
                    callPayload.Queries["skip_merge_validation"] = ExpressionConverter.Convert(__workflow_skipMergeValidation);
                if (__workflow_skipDuplicateCheck != null)
                    callPayload.Queries["skip_duplicate_check"] = ExpressionConverter.Convert(__workflow_skipDuplicateCheck);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                if (__workflow_bodyupdateExisting != null)
                {
                    body["update_existing"] = ExpressionConverter.ConvertO(__workflow_bodyupdateExisting);
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
        public IBodyWorkflowAction<GetAllMembersResponseModel> GetListMembers(Expression<Func<string>> listId, Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<GetAllMembersResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<GetAllMembersResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Addmember(Expression<Func<string>> listId, Expression<Func<newMemberInListstatusInput>> newMemberInListstatus, Expression<Func<string>> newMemberInListemailAddress, Expression<Func<newMemberInListemailTypeInput>> newMemberInListemailType = null, Expression<Func<string>> newMemberInListmergeFieldsfirstName = null, Expression<Func<string>> newMemberInListmergeFieldslastName = null, Expression<Func<string>> newMemberInListlanguage = null, Expression<Func<bool>> newMemberInListvIP = null, Expression<Func<double>> newMemberInListlocationlatitude = null, Expression<Func<double>> newMemberInListlocationlongitude = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_newMemberInListstatus = newMemberInListstatus == null ? null : WorkflowExpression.Compile(newMemberInListstatus);
            WorkflowExpression.Validate(__workflow_newMemberInListstatus, nameof(newMemberInListstatus), required: true);
            var __workflow_newMemberInListemailAddress = newMemberInListemailAddress == null ? null : WorkflowExpression.Compile(newMemberInListemailAddress);
            WorkflowExpression.Validate(__workflow_newMemberInListemailAddress, nameof(newMemberInListemailAddress), required: true);
            var __workflow_newMemberInListemailType = newMemberInListemailType == null ? null : WorkflowExpression.Compile(newMemberInListemailType);
            WorkflowExpression.Validate(__workflow_newMemberInListemailType, nameof(newMemberInListemailType), required: false);
            var __workflow_newMemberInListmergeFieldsfirstName = newMemberInListmergeFieldsfirstName == null ? null : WorkflowExpression.Compile(newMemberInListmergeFieldsfirstName);
            WorkflowExpression.Validate(__workflow_newMemberInListmergeFieldsfirstName, nameof(newMemberInListmergeFieldsfirstName), required: false);
            var __workflow_newMemberInListmergeFieldslastName = newMemberInListmergeFieldslastName == null ? null : WorkflowExpression.Compile(newMemberInListmergeFieldslastName);
            WorkflowExpression.Validate(__workflow_newMemberInListmergeFieldslastName, nameof(newMemberInListmergeFieldslastName), required: false);
            var __workflow_newMemberInListlanguage = newMemberInListlanguage == null ? null : WorkflowExpression.Compile(newMemberInListlanguage);
            WorkflowExpression.Validate(__workflow_newMemberInListlanguage, nameof(newMemberInListlanguage), required: false);
            var __workflow_newMemberInListvIP = newMemberInListvIP == null ? null : WorkflowExpression.Compile(newMemberInListvIP);
            WorkflowExpression.Validate(__workflow_newMemberInListvIP, nameof(newMemberInListvIP), required: false);
            var __workflow_newMemberInListlocationlatitude = newMemberInListlocationlatitude == null ? null : WorkflowExpression.Compile(newMemberInListlocationlatitude);
            WorkflowExpression.Validate(__workflow_newMemberInListlocationlatitude, nameof(newMemberInListlocationlatitude), required: false);
            var __workflow_newMemberInListlocationlongitude = newMemberInListlocationlongitude == null ? null : WorkflowExpression.Compile(newMemberInListlocationlongitude);
            WorkflowExpression.Validate(__workflow_newMemberInListlocationlongitude, nameof(newMemberInListlocationlongitude), required: false);
            return new DeferredBodyAction<MemberResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newMemberInList = new JObject();
                var newMemberInListpropCount = 0;
                if (__workflow_newMemberInListemailType != null)
                {
                    if (__workflow_newMemberInListemailType != null)
                    {
                        newMemberInList["email_type"] = ExpressionConverter.ConvertO(__workflow_newMemberInListemailType);
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
                newMemberInList["status"] = ExpressionConverter.ConvertO(__workflow_newMemberInListstatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (__workflow_newMemberInListmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = ExpressionConverter.ConvertO(__workflow_newMemberInListmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (__workflow_newMemberInListmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = ExpressionConverter.ConvertO(__workflow_newMemberInListmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    newMemberInList["merge_fields"] = mergeFieldsObject;
                    newMemberInListpropCount++;
                }

                if (__workflow_newMemberInListlanguage != null)
                {
                    newMemberInList["language"] = ExpressionConverter.ConvertO(__workflow_newMemberInListlanguage);
                    newMemberInListpropCount++;
                }

                if (__workflow_newMemberInListvIP != null)
                {
                    newMemberInList["vip"] = ExpressionConverter.ConvertO(__workflow_newMemberInListvIP);
                    newMemberInListpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_newMemberInListlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(__workflow_newMemberInListlocationlatitude);
                    locationObjectpropCount++;
                }

                if (__workflow_newMemberInListlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(__workflow_newMemberInListlocationlongitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    newMemberInList["location"] = locationObject;
                    newMemberInListpropCount++;
                }

                newMemberInListpropCount++;
                newMemberInList["email_address"] = ExpressionConverter.ConvertO(__workflow_newMemberInListemailAddress);
                if (newMemberInListpropCount > 0)
                {
                    callPayload.Body = newMemberInList;
                }

                return new ApiConnectionAction<MemberResponseModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CampaignResponseModel> Newcampaign(Expression<Func<newCampaignRequestcampaignTypeInput>> newCampaignRequestcampaignType, Expression<Func<string>> newCampaignRequestrecipientslistId, Expression<Func<string>> newCampaignRequestsettingscampaignSubjectLine, Expression<Func<string>> newCampaignRequestsettingsfromName, Expression<Func<string>> newCampaignRequestsettingsreplyToAddress, Expression<Func<int>> newCampaignRequestrecipientssegmentOptssavedSegmentID = null, Expression<Func<string>> newCampaignRequestrecipientssegmentOptsmatchType = null, Expression<Func<string>> newCampaignRequestsettingstitle = null, Expression<Func<bool>> newCampaignRequestsettingsconversation = null, Expression<Func<string>> newCampaignRequestsettingstoName = null, Expression<Func<string>> newCampaignRequestsettingsfolderID = null, Expression<Func<bool>> newCampaignRequestsettingsauthentication = null, Expression<Func<bool>> newCampaignRequestsettingsautoFooter = null, Expression<Func<bool>> newCampaignRequestsettingsinlineCSS = null, Expression<Func<bool>> newCampaignRequestsettingsautoTweet = null, Expression<Func<int[]>> newCampaignRequestsettingsautoPostToFacebook = null, Expression<Func<bool>> newCampaignRequestsettingsfacebookComments = null, Expression<Func<string>> newCampaignRequestvariateSettingswinningCriteria = null, Expression<Func<int>> newCampaignRequestvariateSettingswaitTime = null, Expression<Func<int>> newCampaignRequestvariateSettingstestSize = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssubjectLines = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssendTimes = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsfromNames = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsreplyToAddresses = null, Expression<Func<bool>> newCampaignRequesttrackingopens = null, Expression<Func<bool>> newCampaignRequesttrackinghTMLClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingplainTextClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingmailChimpGoalTracking = null, Expression<Func<bool>> newCampaignRequesttrackingeCommerce360Tracking = null, Expression<Func<string>> newCampaignRequesttrackinggoogleAnalyticsTracking = null, Expression<Func<string>> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceNote = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseCampaign = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseNote = null, Expression<Func<bool>> newCampaignRequesttrackingcapsulecapsuleNote = null, Expression<Func<string>> newCampaignRequestrssOptsfeedURL = null, Expression<Func<newCampaignRequestrssOptsfrequencyInput>> newCampaignRequestrssOptsfrequency = null, Expression<Func<string>> newCampaignRequestrssOptsconstrainRSSImages = null, Expression<Func<int>> newCampaignRequestrssOptsschedulesendingHour = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsunday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendmonday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendtuesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendwednesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendthursday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendfriday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsaturday = null, Expression<Func<newCampaignRequestrssOptsscheduleweeklySendingDayInput>> newCampaignRequestrssOptsscheduleweeklySendingDay = null, Expression<Func<double>> newCampaignRequestrssOptsschedulemonthlySendingDay = null, Expression<Func<string>> newCampaignRequestsocialCardimageURL = null, Expression<Func<string>> newCampaignRequestsocialCardcampaignDescription = null, Expression<Func<string>> newCampaignRequestsocialCardtitle = null)
        {
            var __workflow_newCampaignRequestcampaignType = newCampaignRequestcampaignType == null ? null : WorkflowExpression.Compile(newCampaignRequestcampaignType);
            WorkflowExpression.Validate(__workflow_newCampaignRequestcampaignType, nameof(newCampaignRequestcampaignType), required: true);
            var __workflow_newCampaignRequestrecipientslistId = newCampaignRequestrecipientslistId == null ? null : WorkflowExpression.Compile(newCampaignRequestrecipientslistId);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrecipientslistId, nameof(newCampaignRequestrecipientslistId), required: true);
            var __workflow_newCampaignRequestsettingscampaignSubjectLine = newCampaignRequestsettingscampaignSubjectLine == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingscampaignSubjectLine);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingscampaignSubjectLine, nameof(newCampaignRequestsettingscampaignSubjectLine), required: true);
            var __workflow_newCampaignRequestsettingsfromName = newCampaignRequestsettingsfromName == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsfromName);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsfromName, nameof(newCampaignRequestsettingsfromName), required: true);
            var __workflow_newCampaignRequestsettingsreplyToAddress = newCampaignRequestsettingsreplyToAddress == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsreplyToAddress);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsreplyToAddress, nameof(newCampaignRequestsettingsreplyToAddress), required: true);
            var __workflow_newCampaignRequestrecipientssegmentOptssavedSegmentID = newCampaignRequestrecipientssegmentOptssavedSegmentID == null ? null : WorkflowExpression.Compile(newCampaignRequestrecipientssegmentOptssavedSegmentID);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrecipientssegmentOptssavedSegmentID, nameof(newCampaignRequestrecipientssegmentOptssavedSegmentID), required: false);
            var __workflow_newCampaignRequestrecipientssegmentOptsmatchType = newCampaignRequestrecipientssegmentOptsmatchType == null ? null : WorkflowExpression.Compile(newCampaignRequestrecipientssegmentOptsmatchType);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrecipientssegmentOptsmatchType, nameof(newCampaignRequestrecipientssegmentOptsmatchType), required: false);
            var __workflow_newCampaignRequestsettingstitle = newCampaignRequestsettingstitle == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingstitle);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingstitle, nameof(newCampaignRequestsettingstitle), required: false);
            var __workflow_newCampaignRequestsettingsconversation = newCampaignRequestsettingsconversation == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsconversation);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsconversation, nameof(newCampaignRequestsettingsconversation), required: false);
            var __workflow_newCampaignRequestsettingstoName = newCampaignRequestsettingstoName == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingstoName);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingstoName, nameof(newCampaignRequestsettingstoName), required: false);
            var __workflow_newCampaignRequestsettingsfolderID = newCampaignRequestsettingsfolderID == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsfolderID);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsfolderID, nameof(newCampaignRequestsettingsfolderID), required: false);
            var __workflow_newCampaignRequestsettingsauthentication = newCampaignRequestsettingsauthentication == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsauthentication);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsauthentication, nameof(newCampaignRequestsettingsauthentication), required: false);
            var __workflow_newCampaignRequestsettingsautoFooter = newCampaignRequestsettingsautoFooter == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsautoFooter);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsautoFooter, nameof(newCampaignRequestsettingsautoFooter), required: false);
            var __workflow_newCampaignRequestsettingsinlineCSS = newCampaignRequestsettingsinlineCSS == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsinlineCSS);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsinlineCSS, nameof(newCampaignRequestsettingsinlineCSS), required: false);
            var __workflow_newCampaignRequestsettingsautoTweet = newCampaignRequestsettingsautoTweet == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsautoTweet);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsautoTweet, nameof(newCampaignRequestsettingsautoTweet), required: false);
            var __workflow_newCampaignRequestsettingsautoPostToFacebook = newCampaignRequestsettingsautoPostToFacebook == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsautoPostToFacebook);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsautoPostToFacebook, nameof(newCampaignRequestsettingsautoPostToFacebook), required: false);
            var __workflow_newCampaignRequestsettingsfacebookComments = newCampaignRequestsettingsfacebookComments == null ? null : WorkflowExpression.Compile(newCampaignRequestsettingsfacebookComments);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsettingsfacebookComments, nameof(newCampaignRequestsettingsfacebookComments), required: false);
            var __workflow_newCampaignRequestvariateSettingswinningCriteria = newCampaignRequestvariateSettingswinningCriteria == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingswinningCriteria);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingswinningCriteria, nameof(newCampaignRequestvariateSettingswinningCriteria), required: false);
            var __workflow_newCampaignRequestvariateSettingswaitTime = newCampaignRequestvariateSettingswaitTime == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingswaitTime);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingswaitTime, nameof(newCampaignRequestvariateSettingswaitTime), required: false);
            var __workflow_newCampaignRequestvariateSettingstestSize = newCampaignRequestvariateSettingstestSize == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingstestSize);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingstestSize, nameof(newCampaignRequestvariateSettingstestSize), required: false);
            var __workflow_newCampaignRequestvariateSettingssubjectLines = newCampaignRequestvariateSettingssubjectLines == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingssubjectLines);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingssubjectLines, nameof(newCampaignRequestvariateSettingssubjectLines), required: false);
            var __workflow_newCampaignRequestvariateSettingssendTimes = newCampaignRequestvariateSettingssendTimes == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingssendTimes);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingssendTimes, nameof(newCampaignRequestvariateSettingssendTimes), required: false);
            var __workflow_newCampaignRequestvariateSettingsfromNames = newCampaignRequestvariateSettingsfromNames == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingsfromNames);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingsfromNames, nameof(newCampaignRequestvariateSettingsfromNames), required: false);
            var __workflow_newCampaignRequestvariateSettingsreplyToAddresses = newCampaignRequestvariateSettingsreplyToAddresses == null ? null : WorkflowExpression.Compile(newCampaignRequestvariateSettingsreplyToAddresses);
            WorkflowExpression.Validate(__workflow_newCampaignRequestvariateSettingsreplyToAddresses, nameof(newCampaignRequestvariateSettingsreplyToAddresses), required: false);
            var __workflow_newCampaignRequesttrackingopens = newCampaignRequesttrackingopens == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingopens);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingopens, nameof(newCampaignRequesttrackingopens), required: false);
            var __workflow_newCampaignRequesttrackinghTMLClickTracking = newCampaignRequesttrackinghTMLClickTracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackinghTMLClickTracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackinghTMLClickTracking, nameof(newCampaignRequesttrackinghTMLClickTracking), required: false);
            var __workflow_newCampaignRequesttrackingplainTextClickTracking = newCampaignRequesttrackingplainTextClickTracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingplainTextClickTracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingplainTextClickTracking, nameof(newCampaignRequesttrackingplainTextClickTracking), required: false);
            var __workflow_newCampaignRequesttrackingmailChimpGoalTracking = newCampaignRequesttrackingmailChimpGoalTracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingmailChimpGoalTracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingmailChimpGoalTracking, nameof(newCampaignRequesttrackingmailChimpGoalTracking), required: false);
            var __workflow_newCampaignRequesttrackingeCommerce360Tracking = newCampaignRequesttrackingeCommerce360Tracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingeCommerce360Tracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingeCommerce360Tracking, nameof(newCampaignRequesttrackingeCommerce360Tracking), required: false);
            var __workflow_newCampaignRequesttrackinggoogleAnalyticsTracking = newCampaignRequesttrackinggoogleAnalyticsTracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackinggoogleAnalyticsTracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackinggoogleAnalyticsTracking, nameof(newCampaignRequesttrackinggoogleAnalyticsTracking), required: false);
            var __workflow_newCampaignRequesttrackingclickTaleAnalyticsTracking = newCampaignRequesttrackingclickTaleAnalyticsTracking == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingclickTaleAnalyticsTracking);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingclickTaleAnalyticsTracking, nameof(newCampaignRequesttrackingclickTaleAnalyticsTracking), required: false);
            var __workflow_newCampaignRequesttrackingsalesforcesalesforceCampaign = newCampaignRequesttrackingsalesforcesalesforceCampaign == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingsalesforcesalesforceCampaign);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingsalesforcesalesforceCampaign, nameof(newCampaignRequesttrackingsalesforcesalesforceCampaign), required: false);
            var __workflow_newCampaignRequesttrackingsalesforcesalesforceNote = newCampaignRequesttrackingsalesforcesalesforceNote == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingsalesforcesalesforceNote);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingsalesforcesalesforceNote, nameof(newCampaignRequesttrackingsalesforcesalesforceNote), required: false);
            var __workflow_newCampaignRequesttrackinghighrisehighriseCampaign = newCampaignRequesttrackinghighrisehighriseCampaign == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackinghighrisehighriseCampaign);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackinghighrisehighriseCampaign, nameof(newCampaignRequesttrackinghighrisehighriseCampaign), required: false);
            var __workflow_newCampaignRequesttrackinghighrisehighriseNote = newCampaignRequesttrackinghighrisehighriseNote == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackinghighrisehighriseNote);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackinghighrisehighriseNote, nameof(newCampaignRequesttrackinghighrisehighriseNote), required: false);
            var __workflow_newCampaignRequesttrackingcapsulecapsuleNote = newCampaignRequesttrackingcapsulecapsuleNote == null ? null : WorkflowExpression.Compile(newCampaignRequesttrackingcapsulecapsuleNote);
            WorkflowExpression.Validate(__workflow_newCampaignRequesttrackingcapsulecapsuleNote, nameof(newCampaignRequesttrackingcapsulecapsuleNote), required: false);
            var __workflow_newCampaignRequestrssOptsfeedURL = newCampaignRequestrssOptsfeedURL == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsfeedURL);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsfeedURL, nameof(newCampaignRequestrssOptsfeedURL), required: false);
            var __workflow_newCampaignRequestrssOptsfrequency = newCampaignRequestrssOptsfrequency == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsfrequency);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsfrequency, nameof(newCampaignRequestrssOptsfrequency), required: false);
            var __workflow_newCampaignRequestrssOptsconstrainRSSImages = newCampaignRequestrssOptsconstrainRSSImages == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsconstrainRSSImages);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsconstrainRSSImages, nameof(newCampaignRequestrssOptsconstrainRSSImages), required: false);
            var __workflow_newCampaignRequestrssOptsschedulesendingHour = newCampaignRequestrssOptsschedulesendingHour == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsschedulesendingHour);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsschedulesendingHour, nameof(newCampaignRequestrssOptsschedulesendingHour), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendsunday = newCampaignRequestrssOptsscheduledailySendsunday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendsunday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendsunday, nameof(newCampaignRequestrssOptsscheduledailySendsunday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendmonday = newCampaignRequestrssOptsscheduledailySendmonday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendmonday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendmonday, nameof(newCampaignRequestrssOptsscheduledailySendmonday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendtuesday = newCampaignRequestrssOptsscheduledailySendtuesday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendtuesday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendtuesday, nameof(newCampaignRequestrssOptsscheduledailySendtuesday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendwednesday = newCampaignRequestrssOptsscheduledailySendwednesday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendwednesday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendwednesday, nameof(newCampaignRequestrssOptsscheduledailySendwednesday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendthursday = newCampaignRequestrssOptsscheduledailySendthursday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendthursday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendthursday, nameof(newCampaignRequestrssOptsscheduledailySendthursday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendfriday = newCampaignRequestrssOptsscheduledailySendfriday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendfriday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendfriday, nameof(newCampaignRequestrssOptsscheduledailySendfriday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduledailySendsaturday = newCampaignRequestrssOptsscheduledailySendsaturday == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduledailySendsaturday);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduledailySendsaturday, nameof(newCampaignRequestrssOptsscheduledailySendsaturday), required: false);
            var __workflow_newCampaignRequestrssOptsscheduleweeklySendingDay = newCampaignRequestrssOptsscheduleweeklySendingDay == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsscheduleweeklySendingDay);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsscheduleweeklySendingDay, nameof(newCampaignRequestrssOptsscheduleweeklySendingDay), required: false);
            var __workflow_newCampaignRequestrssOptsschedulemonthlySendingDay = newCampaignRequestrssOptsschedulemonthlySendingDay == null ? null : WorkflowExpression.Compile(newCampaignRequestrssOptsschedulemonthlySendingDay);
            WorkflowExpression.Validate(__workflow_newCampaignRequestrssOptsschedulemonthlySendingDay, nameof(newCampaignRequestrssOptsschedulemonthlySendingDay), required: false);
            var __workflow_newCampaignRequestsocialCardimageURL = newCampaignRequestsocialCardimageURL == null ? null : WorkflowExpression.Compile(newCampaignRequestsocialCardimageURL);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsocialCardimageURL, nameof(newCampaignRequestsocialCardimageURL), required: false);
            var __workflow_newCampaignRequestsocialCardcampaignDescription = newCampaignRequestsocialCardcampaignDescription == null ? null : WorkflowExpression.Compile(newCampaignRequestsocialCardcampaignDescription);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsocialCardcampaignDescription, nameof(newCampaignRequestsocialCardcampaignDescription), required: false);
            var __workflow_newCampaignRequestsocialCardtitle = newCampaignRequestsocialCardtitle == null ? null : WorkflowExpression.Compile(newCampaignRequestsocialCardtitle);
            WorkflowExpression.Validate(__workflow_newCampaignRequestsocialCardtitle, nameof(newCampaignRequestsocialCardtitle), required: false);
            return new DeferredBodyAction<CampaignResponseModel>(() =>
            {
                var apiCallPath = "/v2/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newCampaignRequest = new JObject();
                var newCampaignRequestpropCount = 0;
                newCampaignRequestpropCount++;
                newCampaignRequest["type"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestcampaignType);
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                recipientsObjectpropCount++;
                recipientsObject["list_id"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrecipientslistId);
                var segmentOptsObject = new JObject();
                var segmentOptsObjectpropCount = 0;
                if (__workflow_newCampaignRequestrecipientssegmentOptssavedSegmentID != null)
                {
                    segmentOptsObject["saved_segment_id"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrecipientssegmentOptssavedSegmentID);
                    segmentOptsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrecipientssegmentOptsmatchType != null)
                {
                    segmentOptsObject["match"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrecipientssegmentOptsmatchType);
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
                settingsObject["subject_line"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingscampaignSubjectLine);
                if (__workflow_newCampaignRequestsettingstitle != null)
                {
                    settingsObject["title"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingstitle);
                    settingsObjectpropCount++;
                }

                settingsObjectpropCount++;
                settingsObject["from_name"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsfromName);
                settingsObjectpropCount++;
                settingsObject["reply_to"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsreplyToAddress);
                if (__workflow_newCampaignRequestsettingsconversation != null)
                {
                    settingsObject["use_conversation"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsconversation);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingstoName != null)
                {
                    settingsObject["to_name"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingstoName);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsfolderID != null)
                {
                    settingsObject["folder_id"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsfolderID);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsauthentication != null)
                {
                    settingsObject["authenticate"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsauthentication);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsautoFooter != null)
                {
                    settingsObject["auto_footer"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsautoFooter);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsinlineCSS != null)
                {
                    settingsObject["inline_css"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsinlineCSS);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsautoTweet != null)
                {
                    settingsObject["auto_tweet"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsautoTweet);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsautoPostToFacebook != null)
                {
                    settingsObject["auto_fb_post"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsautoPostToFacebook);
                    settingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsettingsfacebookComments != null)
                {
                    settingsObject["fb_comments"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsettingsfacebookComments);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    newCampaignRequest["settings"] = settingsObject;
                    newCampaignRequestpropCount++;
                }

                var variateSettingsObject = new JObject();
                var variateSettingsObjectpropCount = 0;
                if (__workflow_newCampaignRequestvariateSettingswinningCriteria != null)
                {
                    variateSettingsObject["winner_criteria"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingswinningCriteria);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingswaitTime != null)
                {
                    variateSettingsObject["wait_time"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingswaitTime);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingstestSize != null)
                {
                    variateSettingsObject["test_size"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingstestSize);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingssubjectLines != null)
                {
                    variateSettingsObject["subject_lines"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingssubjectLines);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingssendTimes != null)
                {
                    variateSettingsObject["send_times"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingssendTimes);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingsfromNames != null)
                {
                    variateSettingsObject["from_names"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingsfromNames);
                    variateSettingsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestvariateSettingsreplyToAddresses != null)
                {
                    variateSettingsObject["reply_to_addresses"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestvariateSettingsreplyToAddresses);
                    variateSettingsObjectpropCount++;
                }

                if (variateSettingsObjectpropCount > 0)
                {
                    newCampaignRequest["variate_settings"] = variateSettingsObject;
                    newCampaignRequestpropCount++;
                }

                var trackingObject = new JObject();
                var trackingObjectpropCount = 0;
                if (__workflow_newCampaignRequesttrackingopens != null)
                {
                    trackingObject["opens"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingopens);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackinghTMLClickTracking != null)
                {
                    trackingObject["html_clicks"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackinghTMLClickTracking);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackingplainTextClickTracking != null)
                {
                    trackingObject["text_clicks"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingplainTextClickTracking);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackingmailChimpGoalTracking != null)
                {
                    trackingObject["goal_tracking"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingmailChimpGoalTracking);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackingeCommerce360Tracking != null)
                {
                    trackingObject["ecomm360"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingeCommerce360Tracking);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackinggoogleAnalyticsTracking != null)
                {
                    trackingObject["google_analytics"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackinggoogleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackingclickTaleAnalyticsTracking != null)
                {
                    trackingObject["clicktale"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingclickTaleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                var salesforceObject = new JObject();
                var salesforceObjectpropCount = 0;
                if (__workflow_newCampaignRequesttrackingsalesforcesalesforceCampaign != null)
                {
                    salesforceObject["campaign"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingsalesforcesalesforceCampaign);
                    salesforceObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackingsalesforcesalesforceNote != null)
                {
                    salesforceObject["notes"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingsalesforcesalesforceNote);
                    salesforceObjectpropCount++;
                }

                if (salesforceObjectpropCount > 0)
                {
                    trackingObject["salesforce"] = salesforceObject;
                    trackingObjectpropCount++;
                }

                var highriseObject = new JObject();
                var highriseObjectpropCount = 0;
                if (__workflow_newCampaignRequesttrackinghighrisehighriseCampaign != null)
                {
                    highriseObject["campaign"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackinghighrisehighriseCampaign);
                    highriseObjectpropCount++;
                }

                if (__workflow_newCampaignRequesttrackinghighrisehighriseNote != null)
                {
                    highriseObject["notes"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackinghighrisehighriseNote);
                    highriseObjectpropCount++;
                }

                if (highriseObjectpropCount > 0)
                {
                    trackingObject["highrise"] = highriseObject;
                    trackingObjectpropCount++;
                }

                var capsuleObject = new JObject();
                var capsuleObjectpropCount = 0;
                if (__workflow_newCampaignRequesttrackingcapsulecapsuleNote != null)
                {
                    capsuleObject["notes"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequesttrackingcapsulecapsuleNote);
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
                if (__workflow_newCampaignRequestrssOptsfeedURL != null)
                {
                    rssOptsObject["feed_url"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsfeedURL);
                    rssOptsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsfrequency != null)
                {
                    rssOptsObject["frequency"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsfrequency);
                    rssOptsObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsconstrainRSSImages != null)
                {
                    rssOptsObject["constrain_rss_img"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsconstrainRSSImages);
                    rssOptsObjectpropCount++;
                }

                var scheduleObject = new JObject();
                var scheduleObjectpropCount = 0;
                if (__workflow_newCampaignRequestrssOptsschedulesendingHour != null)
                {
                    scheduleObject["hour"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsschedulesendingHour);
                    scheduleObjectpropCount++;
                }

                var dailySendObject = new JObject();
                var dailySendObjectpropCount = 0;
                if (__workflow_newCampaignRequestrssOptsscheduledailySendsunday != null)
                {
                    dailySendObject["sunday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendsunday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendmonday != null)
                {
                    dailySendObject["monday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendmonday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendtuesday != null)
                {
                    dailySendObject["tuesday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendtuesday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendwednesday != null)
                {
                    dailySendObject["wednesday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendwednesday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendthursday != null)
                {
                    dailySendObject["thursday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendthursday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendfriday != null)
                {
                    dailySendObject["friday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendfriday);
                    dailySendObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduledailySendsaturday != null)
                {
                    dailySendObject["saturday"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduledailySendsaturday);
                    dailySendObjectpropCount++;
                }

                if (dailySendObjectpropCount > 0)
                {
                    scheduleObject["daily_send"] = dailySendObject;
                    scheduleObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsscheduleweeklySendingDay != null)
                {
                    scheduleObject["weekly_send_day"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsscheduleweeklySendingDay);
                    scheduleObjectpropCount++;
                }

                if (__workflow_newCampaignRequestrssOptsschedulemonthlySendingDay != null)
                {
                    scheduleObject["monthly_send_date"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestrssOptsschedulemonthlySendingDay);
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
                if (__workflow_newCampaignRequestsocialCardimageURL != null)
                {
                    socialCardObject["image_url"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsocialCardimageURL);
                    socialCardObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsocialCardcampaignDescription != null)
                {
                    socialCardObject["description"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsocialCardcampaignDescription);
                    socialCardObjectpropCount++;
                }

                if (__workflow_newCampaignRequestsocialCardtitle != null)
                {
                    socialCardObject["title"] = ExpressionConverter.ConvertO(__workflow_newCampaignRequestsocialCardtitle);
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
        public IWorkflowAction Removemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_memberEmail = memberEmail == null ? null : WorkflowExpression.Compile(memberEmail);
            WorkflowExpression.Validate(__workflow_memberEmail, nameof(memberEmail), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(__workflow_memberEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Updatemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail, Expression<Func<updateMemberInListRequeststatusInput>> updateMemberInListRequeststatus, Expression<Func<updateMemberInListRequestemailTypeInput>> updateMemberInListRequestemailType = null, Expression<Func<string>> updateMemberInListRequestmergeFieldsfirstName = null, Expression<Func<string>> updateMemberInListRequestmergeFieldslastName = null, Expression<Func<string>> updateMemberInListRequestlanguage = null, Expression<Func<bool>> updateMemberInListRequestvIP = null, Expression<Func<double>> updateMemberInListRequestlocationlatitude = null, Expression<Func<double>> updateMemberInListRequestlocationlongitude = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_memberEmail = memberEmail == null ? null : WorkflowExpression.Compile(memberEmail);
            WorkflowExpression.Validate(__workflow_memberEmail, nameof(memberEmail), required: true);
            var __workflow_updateMemberInListRequeststatus = updateMemberInListRequeststatus == null ? null : WorkflowExpression.Compile(updateMemberInListRequeststatus);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequeststatus, nameof(updateMemberInListRequeststatus), required: true);
            var __workflow_updateMemberInListRequestemailType = updateMemberInListRequestemailType == null ? null : WorkflowExpression.Compile(updateMemberInListRequestemailType);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestemailType, nameof(updateMemberInListRequestemailType), required: false);
            var __workflow_updateMemberInListRequestmergeFieldsfirstName = updateMemberInListRequestmergeFieldsfirstName == null ? null : WorkflowExpression.Compile(updateMemberInListRequestmergeFieldsfirstName);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestmergeFieldsfirstName, nameof(updateMemberInListRequestmergeFieldsfirstName), required: false);
            var __workflow_updateMemberInListRequestmergeFieldslastName = updateMemberInListRequestmergeFieldslastName == null ? null : WorkflowExpression.Compile(updateMemberInListRequestmergeFieldslastName);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestmergeFieldslastName, nameof(updateMemberInListRequestmergeFieldslastName), required: false);
            var __workflow_updateMemberInListRequestlanguage = updateMemberInListRequestlanguage == null ? null : WorkflowExpression.Compile(updateMemberInListRequestlanguage);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestlanguage, nameof(updateMemberInListRequestlanguage), required: false);
            var __workflow_updateMemberInListRequestvIP = updateMemberInListRequestvIP == null ? null : WorkflowExpression.Compile(updateMemberInListRequestvIP);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestvIP, nameof(updateMemberInListRequestvIP), required: false);
            var __workflow_updateMemberInListRequestlocationlatitude = updateMemberInListRequestlocationlatitude == null ? null : WorkflowExpression.Compile(updateMemberInListRequestlocationlatitude);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestlocationlatitude, nameof(updateMemberInListRequestlocationlatitude), required: false);
            var __workflow_updateMemberInListRequestlocationlongitude = updateMemberInListRequestlocationlongitude == null ? null : WorkflowExpression.Compile(updateMemberInListRequestlocationlongitude);
            WorkflowExpression.Validate(__workflow_updateMemberInListRequestlocationlongitude, nameof(updateMemberInListRequestlocationlongitude), required: false);
            return new DeferredBodyAction<MemberResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = ExpressionConverter.Convert(__workflow_memberEmail);
                var updateMemberInListRequest = new JObject();
                var updateMemberInListRequestpropCount = 0;
                if (__workflow_updateMemberInListRequestemailType != null)
                {
                    if (__workflow_updateMemberInListRequestemailType != null)
                    {
                        updateMemberInListRequest["email_type"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestemailType);
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
                updateMemberInListRequest["status"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequeststatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (__workflow_updateMemberInListRequestmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (__workflow_updateMemberInListRequestmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    updateMemberInListRequest["merge_fields"] = mergeFieldsObject;
                    updateMemberInListRequestpropCount++;
                }

                if (__workflow_updateMemberInListRequestlanguage != null)
                {
                    updateMemberInListRequest["language"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestlanguage);
                    updateMemberInListRequestpropCount++;
                }

                if (__workflow_updateMemberInListRequestvIP != null)
                {
                    updateMemberInListRequest["vip"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestvIP);
                    updateMemberInListRequestpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_updateMemberInListRequestlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestlocationlatitude);
                    locationObjectpropCount++;
                }

                if (__workflow_updateMemberInListRequestlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(__workflow_updateMemberInListRequestlocationlongitude);
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
        public IBodyWorkflowTrigger<GetMembersResponseModel> OnMemberSubscribed(Expression<Func<string>> listId, FlowRecurrence recurrence = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<GetMembersResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetMembersResponseModel>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetListsResponseModel> OnCreateList(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetListsResponseModel>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewMemberInListRequestEmailTypeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum newMemberInListemailTypeInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
