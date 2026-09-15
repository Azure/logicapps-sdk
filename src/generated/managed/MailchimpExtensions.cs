//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailchimp
{
    using System.Linq.Expressions;
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
        public IWorkflowAction Sendcampaign(Expression<Func<string>> campaignId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/actions/send", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetListsResponseModel> GetLists(Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["count"] = Convert.ToString(10);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<GetListsResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CreateNewListResponseModel> Newlist(Expression<Func<string>> newListRequestlistName, Expression<Func<string>> newListRequestcontactcompanyName, Expression<Func<string>> newListRequestcontactaddressLine1, Expression<Func<string>> newListRequestcontactcity, Expression<Func<string>> newListRequestcontactstate, Expression<Func<string>> newListRequestcontactpostalCode, Expression<Func<string>> newListRequestcontactcountryCode, Expression<Func<string>> newListRequestcontactphoneNumber, Expression<Func<string>> newListRequestpermissionReminder, Expression<Func<string>> newListRequestcampaignDefaultssenderSName, Expression<Func<string>> newListRequestcampaignDefaultssenderSEmailAddress, Expression<Func<string>> newListRequestcampaignDefaultssubject, Expression<Func<newListRequestcampaignDefaultslanguageInput>> newListRequestcampaignDefaultslanguage, Expression<Func<bool>> newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, Expression<Func<string>> newListRequestcontactaddressLine2 = null, Expression<Func<bool>> newListRequestuseArchiveBar = null, Expression<Func<string>> newListRequestnotifyOnSubscribe = null, Expression<Func<string>> newListRequestnotifyOnUnsubscribe = null, Expression<Func<newListRequestvisibilityInput>> newListRequestvisibility = null)
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newListRequest = new JObject();
            var newListRequestpropCount = 0;
            newListRequestpropCount++;
            newListRequest["name"] = CSharpExpressionConverter.ConvertToken(newListRequestlistName);
            var contactObject = new JObject();
            var contactObjectpropCount = 0;
            contactObjectpropCount++;
            contactObject["company"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactcompanyName);
            contactObjectpropCount++;
            contactObject["address1"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactaddressLine1);
            if (newListRequestcontactaddressLine2 != null)
            {
                contactObject["address2"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactaddressLine2);
                contactObjectpropCount++;
            }

            contactObjectpropCount++;
            contactObject["city"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactcity);
            contactObjectpropCount++;
            contactObject["state"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactstate);
            contactObjectpropCount++;
            contactObject["zip"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactpostalCode);
            contactObjectpropCount++;
            contactObject["country"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactcountryCode);
            contactObjectpropCount++;
            contactObject["phone"] = CSharpExpressionConverter.ConvertToken(newListRequestcontactphoneNumber);
            if (contactObjectpropCount > 0)
            {
                newListRequest["contact"] = contactObject;
                newListRequestpropCount++;
            }

            newListRequestpropCount++;
            newListRequest["permission_reminder"] = CSharpExpressionConverter.ConvertToken(newListRequestpermissionReminder);
            if (newListRequestuseArchiveBar != null)
            {
                newListRequest["use_archive_bar"] = CSharpExpressionConverter.ConvertToken(newListRequestuseArchiveBar);
                newListRequestpropCount++;
            }

            var campaignDefaultsObject = new JObject();
            var campaignDefaultsObjectpropCount = 0;
            campaignDefaultsObjectpropCount++;
            campaignDefaultsObject["from_name"] = CSharpExpressionConverter.ConvertToken(newListRequestcampaignDefaultssenderSName);
            campaignDefaultsObjectpropCount++;
            campaignDefaultsObject["from_email"] = CSharpExpressionConverter.ConvertToken(newListRequestcampaignDefaultssenderSEmailAddress);
            campaignDefaultsObjectpropCount++;
            campaignDefaultsObject["subject"] = CSharpExpressionConverter.ConvertToken(newListRequestcampaignDefaultssubject);
            campaignDefaultsObjectpropCount++;
            campaignDefaultsObject["language"] = CSharpExpressionConverter.Convert(newListRequestcampaignDefaultslanguage);
            if (campaignDefaultsObjectpropCount > 0)
            {
                newListRequest["campaign_defaults"] = campaignDefaultsObject;
                newListRequestpropCount++;
            }

            if (newListRequestnotifyOnSubscribe != null)
            {
                newListRequest["notify_on_subscribe"] = CSharpExpressionConverter.ConvertToken(newListRequestnotifyOnSubscribe);
                newListRequestpropCount++;
            }

            if (newListRequestnotifyOnUnsubscribe != null)
            {
                newListRequest["notify_on_unsubscribe"] = CSharpExpressionConverter.ConvertToken(newListRequestnotifyOnUnsubscribe);
                newListRequestpropCount++;
            }

            newListRequestpropCount++;
            newListRequest["email_type_option"] = CSharpExpressionConverter.ConvertToken(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse);
            if (newListRequestvisibility != null)
            {
                newListRequest["visibility"] = CSharpExpressionConverter.Convert(newListRequestvisibility);
                newListRequestpropCount++;
            }

            if (newListRequestpropCount > 0)
            {
                callPayload.Body = newListRequest;
            }

            return new ApiConnectionAction<CreateNewListResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> AddMembers(Expression<Func<string>> listId, Expression<Func<NewMemberInListRequest[]>> bodymembers, Expression<Func<bool>> skipMergeValidation = null, Expression<Func<bool>> skipDuplicateCheck = null, Expression<Func<bool>> bodyupdateExisting = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (skipMergeValidation != null)
                callPayload.Queries["skip_merge_validation"] = CSharpExpressionConverter.ConvertO(skipMergeValidation);
            if (skipDuplicateCheck != null)
                callPayload.Queries["skip_duplicate_check"] = CSharpExpressionConverter.ConvertO(skipDuplicateCheck);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["members"] = CSharpExpressionConverter.ConvertToken(bodymembers);
            if (bodyupdateExisting != null)
            {
                body["update_existing"] = CSharpExpressionConverter.ConvertToken(bodyupdateExisting);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAddMembersBatchResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAllMembersResponseModel> GetListMembers(Expression<Func<string>> listId, Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["count"] = Convert.ToString(10);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<GetAllMembersResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Addmember(Expression<Func<string>> listId, Expression<Func<newMemberInListstatusInput>> newMemberInListstatus, Expression<Func<string>> newMemberInListemailAddress, Expression<Func<newMemberInListemailTypeInput>> newMemberInListemailType = null, Expression<Func<string>> newMemberInListmergeFieldsfirstName = null, Expression<Func<string>> newMemberInListmergeFieldslastName = null, Expression<Func<string>> newMemberInListlanguage = null, Expression<Func<bool>> newMemberInListvIP = null, Expression<Func<double>> newMemberInListlocationlatitude = null, Expression<Func<double>> newMemberInListlocationlongitude = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newMemberInList = new JObject();
            var newMemberInListpropCount = 0;
            if (newMemberInListemailType != null)
            {
                if (newMemberInListemailType != null)
                {
                    newMemberInList["email_type"] = CSharpExpressionConverter.Convert(newMemberInListemailType);
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
            newMemberInList["status"] = CSharpExpressionConverter.Convert(newMemberInListstatus);
            var mergeFieldsObject = new JObject();
            var mergeFieldsObjectpropCount = 0;
            if (newMemberInListmergeFieldsfirstName != null)
            {
                mergeFieldsObject["FNAME"] = CSharpExpressionConverter.ConvertToken(newMemberInListmergeFieldsfirstName);
                mergeFieldsObjectpropCount++;
            }

            if (newMemberInListmergeFieldslastName != null)
            {
                mergeFieldsObject["LNAME"] = CSharpExpressionConverter.ConvertToken(newMemberInListmergeFieldslastName);
                mergeFieldsObjectpropCount++;
            }

            if (mergeFieldsObjectpropCount > 0)
            {
                newMemberInList["merge_fields"] = mergeFieldsObject;
                newMemberInListpropCount++;
            }

            if (newMemberInListlanguage != null)
            {
                newMemberInList["language"] = CSharpExpressionConverter.ConvertToken(newMemberInListlanguage);
                newMemberInListpropCount++;
            }

            if (newMemberInListvIP != null)
            {
                newMemberInList["vip"] = CSharpExpressionConverter.ConvertToken(newMemberInListvIP);
                newMemberInListpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (newMemberInListlocationlatitude != null)
            {
                locationObject["latitude"] = CSharpExpressionConverter.ConvertToken(newMemberInListlocationlatitude);
                locationObjectpropCount++;
            }

            if (newMemberInListlocationlongitude != null)
            {
                locationObject["longitude"] = CSharpExpressionConverter.ConvertToken(newMemberInListlocationlongitude);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                newMemberInList["location"] = locationObject;
                newMemberInListpropCount++;
            }

            newMemberInListpropCount++;
            newMemberInList["email_address"] = CSharpExpressionConverter.ConvertToken(newMemberInListemailAddress);
            if (newMemberInListpropCount > 0)
            {
                callPayload.Body = newMemberInList;
            }

            return new ApiConnectionAction<MemberResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CampaignResponseModel> Newcampaign(Expression<Func<newCampaignRequestcampaignTypeInput>> newCampaignRequestcampaignType, Expression<Func<string>> newCampaignRequestrecipientslistId, Expression<Func<string>> newCampaignRequestsettingscampaignSubjectLine, Expression<Func<string>> newCampaignRequestsettingsfromName, Expression<Func<string>> newCampaignRequestsettingsreplyToAddress, Expression<Func<int>> newCampaignRequestrecipientssegmentOptssavedSegmentID = null, Expression<Func<string>> newCampaignRequestrecipientssegmentOptsmatchType = null, Expression<Func<string>> newCampaignRequestsettingstitle = null, Expression<Func<bool>> newCampaignRequestsettingsconversation = null, Expression<Func<string>> newCampaignRequestsettingstoName = null, Expression<Func<string>> newCampaignRequestsettingsfolderID = null, Expression<Func<bool>> newCampaignRequestsettingsauthentication = null, Expression<Func<bool>> newCampaignRequestsettingsautoFooter = null, Expression<Func<bool>> newCampaignRequestsettingsinlineCSS = null, Expression<Func<bool>> newCampaignRequestsettingsautoTweet = null, Expression<Func<int[]>> newCampaignRequestsettingsautoPostToFacebook = null, Expression<Func<bool>> newCampaignRequestsettingsfacebookComments = null, Expression<Func<string>> newCampaignRequestvariateSettingswinningCriteria = null, Expression<Func<int>> newCampaignRequestvariateSettingswaitTime = null, Expression<Func<int>> newCampaignRequestvariateSettingstestSize = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssubjectLines = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssendTimes = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsfromNames = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsreplyToAddresses = null, Expression<Func<bool>> newCampaignRequesttrackingopens = null, Expression<Func<bool>> newCampaignRequesttrackinghTMLClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingplainTextClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingmailChimpGoalTracking = null, Expression<Func<bool>> newCampaignRequesttrackingeCommerce360Tracking = null, Expression<Func<string>> newCampaignRequesttrackinggoogleAnalyticsTracking = null, Expression<Func<string>> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceNote = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseCampaign = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseNote = null, Expression<Func<bool>> newCampaignRequesttrackingcapsulecapsuleNote = null, Expression<Func<string>> newCampaignRequestrssOptsfeedURL = null, Expression<Func<newCampaignRequestrssOptsfrequencyInput>> newCampaignRequestrssOptsfrequency = null, Expression<Func<string>> newCampaignRequestrssOptsconstrainRSSImages = null, Expression<Func<int>> newCampaignRequestrssOptsschedulesendingHour = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsunday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendmonday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendtuesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendwednesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendthursday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendfriday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsaturday = null, Expression<Func<newCampaignRequestrssOptsscheduleweeklySendingDayInput>> newCampaignRequestrssOptsscheduleweeklySendingDay = null, Expression<Func<double>> newCampaignRequestrssOptsschedulemonthlySendingDay = null, Expression<Func<string>> newCampaignRequestsocialCardimageURL = null, Expression<Func<string>> newCampaignRequestsocialCardcampaignDescription = null, Expression<Func<string>> newCampaignRequestsocialCardtitle = null)
        {
            var apiCallPath = "/v2/campaigns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newCampaignRequest = new JObject();
            var newCampaignRequestpropCount = 0;
            newCampaignRequestpropCount++;
            newCampaignRequest["type"] = CSharpExpressionConverter.Convert(newCampaignRequestcampaignType);
            var recipientsObject = new JObject();
            var recipientsObjectpropCount = 0;
            recipientsObjectpropCount++;
            recipientsObject["list_id"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrecipientslistId);
            var segmentOptsObject = new JObject();
            var segmentOptsObjectpropCount = 0;
            if (newCampaignRequestrecipientssegmentOptssavedSegmentID != null)
            {
                segmentOptsObject["saved_segment_id"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrecipientssegmentOptssavedSegmentID);
                segmentOptsObjectpropCount++;
            }

            if (newCampaignRequestrecipientssegmentOptsmatchType != null)
            {
                segmentOptsObject["match"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrecipientssegmentOptsmatchType);
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
            settingsObject["subject_line"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingscampaignSubjectLine);
            if (newCampaignRequestsettingstitle != null)
            {
                settingsObject["title"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingstitle);
                settingsObjectpropCount++;
            }

            settingsObjectpropCount++;
            settingsObject["from_name"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsfromName);
            settingsObjectpropCount++;
            settingsObject["reply_to"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsreplyToAddress);
            if (newCampaignRequestsettingsconversation != null)
            {
                settingsObject["use_conversation"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsconversation);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingstoName != null)
            {
                settingsObject["to_name"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingstoName);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsfolderID != null)
            {
                settingsObject["folder_id"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsfolderID);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsauthentication != null)
            {
                settingsObject["authenticate"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsauthentication);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsautoFooter != null)
            {
                settingsObject["auto_footer"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsautoFooter);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsinlineCSS != null)
            {
                settingsObject["inline_css"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsinlineCSS);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsautoTweet != null)
            {
                settingsObject["auto_tweet"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsautoTweet);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsautoPostToFacebook != null)
            {
                settingsObject["auto_fb_post"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsautoPostToFacebook);
                settingsObjectpropCount++;
            }

            if (newCampaignRequestsettingsfacebookComments != null)
            {
                settingsObject["fb_comments"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsettingsfacebookComments);
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
                variateSettingsObject["winner_criteria"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingswinningCriteria);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingswaitTime != null)
            {
                variateSettingsObject["wait_time"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingswaitTime);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingstestSize != null)
            {
                variateSettingsObject["test_size"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingstestSize);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingssubjectLines != null)
            {
                variateSettingsObject["subject_lines"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingssubjectLines);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingssendTimes != null)
            {
                variateSettingsObject["send_times"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingssendTimes);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingsfromNames != null)
            {
                variateSettingsObject["from_names"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingsfromNames);
                variateSettingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingsreplyToAddresses != null)
            {
                variateSettingsObject["reply_to_addresses"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestvariateSettingsreplyToAddresses);
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
                trackingObject["opens"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingopens);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackinghTMLClickTracking != null)
            {
                trackingObject["html_clicks"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackinghTMLClickTracking);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackingplainTextClickTracking != null)
            {
                trackingObject["text_clicks"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingplainTextClickTracking);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackingmailChimpGoalTracking != null)
            {
                trackingObject["goal_tracking"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingmailChimpGoalTracking);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackingeCommerce360Tracking != null)
            {
                trackingObject["ecomm360"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingeCommerce360Tracking);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackinggoogleAnalyticsTracking != null)
            {
                trackingObject["google_analytics"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackinggoogleAnalyticsTracking);
                trackingObjectpropCount++;
            }

            if (newCampaignRequesttrackingclickTaleAnalyticsTracking != null)
            {
                trackingObject["clicktale"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingclickTaleAnalyticsTracking);
                trackingObjectpropCount++;
            }

            var salesforceObject = new JObject();
            var salesforceObjectpropCount = 0;
            if (newCampaignRequesttrackingsalesforcesalesforceCampaign != null)
            {
                salesforceObject["campaign"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingsalesforcesalesforceCampaign);
                salesforceObjectpropCount++;
            }

            if (newCampaignRequesttrackingsalesforcesalesforceNote != null)
            {
                salesforceObject["notes"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingsalesforcesalesforceNote);
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
                highriseObject["campaign"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackinghighrisehighriseCampaign);
                highriseObjectpropCount++;
            }

            if (newCampaignRequesttrackinghighrisehighriseNote != null)
            {
                highriseObject["notes"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackinghighrisehighriseNote);
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
                capsuleObject["notes"] = CSharpExpressionConverter.ConvertToken(newCampaignRequesttrackingcapsulecapsuleNote);
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
                rssOptsObject["feed_url"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsfeedURL);
                rssOptsObjectpropCount++;
            }

            if (newCampaignRequestrssOptsfrequency != null)
            {
                rssOptsObject["frequency"] = CSharpExpressionConverter.Convert(newCampaignRequestrssOptsfrequency);
                rssOptsObjectpropCount++;
            }

            if (newCampaignRequestrssOptsconstrainRSSImages != null)
            {
                rssOptsObject["constrain_rss_img"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsconstrainRSSImages);
                rssOptsObjectpropCount++;
            }

            var scheduleObject = new JObject();
            var scheduleObjectpropCount = 0;
            if (newCampaignRequestrssOptsschedulesendingHour != null)
            {
                scheduleObject["hour"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsschedulesendingHour);
                scheduleObjectpropCount++;
            }

            var dailySendObject = new JObject();
            var dailySendObjectpropCount = 0;
            if (newCampaignRequestrssOptsscheduledailySendsunday != null)
            {
                dailySendObject["sunday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendsunday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendmonday != null)
            {
                dailySendObject["monday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendmonday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendtuesday != null)
            {
                dailySendObject["tuesday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendtuesday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendwednesday != null)
            {
                dailySendObject["wednesday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendwednesday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendthursday != null)
            {
                dailySendObject["thursday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendthursday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendfriday != null)
            {
                dailySendObject["friday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendfriday);
                dailySendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendsaturday != null)
            {
                dailySendObject["saturday"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendsaturday);
                dailySendObjectpropCount++;
            }

            if (dailySendObjectpropCount > 0)
            {
                scheduleObject["daily_send"] = dailySendObject;
                scheduleObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduleweeklySendingDay != null)
            {
                scheduleObject["weekly_send_day"] = CSharpExpressionConverter.Convert(newCampaignRequestrssOptsscheduleweeklySendingDay);
                scheduleObjectpropCount++;
            }

            if (newCampaignRequestrssOptsschedulemonthlySendingDay != null)
            {
                scheduleObject["monthly_send_date"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestrssOptsschedulemonthlySendingDay);
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
                socialCardObject["image_url"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsocialCardimageURL);
                socialCardObjectpropCount++;
            }

            if (newCampaignRequestsocialCardcampaignDescription != null)
            {
                socialCardObject["description"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsocialCardcampaignDescription);
                socialCardObjectpropCount++;
            }

            if (newCampaignRequestsocialCardtitle != null)
            {
                socialCardObject["title"] = CSharpExpressionConverter.ConvertToken(newCampaignRequestsocialCardtitle);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction Removemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["member_email"] = CSharpExpressionConverter.ConvertO(memberEmail);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Updatemember(Expression<Func<string>> listId, Expression<Func<string>> memberEmail, Expression<Func<updateMemberInListRequeststatusInput>> updateMemberInListRequeststatus, Expression<Func<updateMemberInListRequestemailTypeInput>> updateMemberInListRequestemailType = null, Expression<Func<string>> updateMemberInListRequestmergeFieldsfirstName = null, Expression<Func<string>> updateMemberInListRequestmergeFieldslastName = null, Expression<Func<string>> updateMemberInListRequestlanguage = null, Expression<Func<bool>> updateMemberInListRequestvIP = null, Expression<Func<double>> updateMemberInListRequestlocationlatitude = null, Expression<Func<double>> updateMemberInListRequestlocationlongitude = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["member_email"] = CSharpExpressionConverter.ConvertO(memberEmail);
            var updateMemberInListRequest = new JObject();
            var updateMemberInListRequestpropCount = 0;
            if (updateMemberInListRequestemailType != null)
            {
                if (updateMemberInListRequestemailType != null)
                {
                    updateMemberInListRequest["email_type"] = CSharpExpressionConverter.Convert(updateMemberInListRequestemailType);
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
            updateMemberInListRequest["status"] = CSharpExpressionConverter.Convert(updateMemberInListRequeststatus);
            var mergeFieldsObject = new JObject();
            var mergeFieldsObjectpropCount = 0;
            if (updateMemberInListRequestmergeFieldsfirstName != null)
            {
                mergeFieldsObject["FNAME"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestmergeFieldsfirstName);
                mergeFieldsObjectpropCount++;
            }

            if (updateMemberInListRequestmergeFieldslastName != null)
            {
                mergeFieldsObject["LNAME"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestmergeFieldslastName);
                mergeFieldsObjectpropCount++;
            }

            if (mergeFieldsObjectpropCount > 0)
            {
                updateMemberInListRequest["merge_fields"] = mergeFieldsObject;
                updateMemberInListRequestpropCount++;
            }

            if (updateMemberInListRequestlanguage != null)
            {
                updateMemberInListRequest["language"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestlanguage);
                updateMemberInListRequestpropCount++;
            }

            if (updateMemberInListRequestvIP != null)
            {
                updateMemberInListRequest["vip"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestvIP);
                updateMemberInListRequestpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (updateMemberInListRequestlocationlatitude != null)
            {
                locationObject["latitude"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestlocationlatitude);
                locationObjectpropCount++;
            }

            if (updateMemberInListRequestlocationlongitude != null)
            {
                locationObject["longitude"] = CSharpExpressionConverter.ConvertToken(updateMemberInListRequestlocationlongitude);
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
        }
    }

    public class MailchimpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetMembersResponseModel> OnMemberSubscribed(Expression<Func<string>> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger/lists/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetMembersResponseModel>(callPayload, triggerName, recurrence);
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