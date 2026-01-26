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
        public IBodyWorkflowAction<CampaignResponseModel> NewcampaignV2(Expression<Func<newCampaignRequestcampaignTypeInput>> newCampaignRequestcampaignType, Expression<Func<string>> newCampaignRequestrecipientslistId, Expression<Func<string>> newCampaignRequestsettingscampaignSubjectLine, Expression<Func<string>> newCampaignRequestsettingsfromName, Expression<Func<string>> newCampaignRequestsettingsreplyToAddress, Expression<Func<int>> newCampaignRequestrecipientssegmentOptssavedSegmentID = null, Expression<Func<string>> newCampaignRequestrecipientssegmentOptsmatchType = null, Expression<Func<string>> newCampaignRequestsettingstitle = null, Expression<Func<bool>> newCampaignRequestsettingsconversation = null, Expression<Func<string>> newCampaignRequestsettingstoName = null, Expression<Func<string>> newCampaignRequestsettingsfolderID = null, Expression<Func<bool>> newCampaignRequestsettingsauthentication = null, Expression<Func<bool>> newCampaignRequestsettingsautoFooter = null, Expression<Func<bool>> newCampaignRequestsettingsinlineCSS = null, Expression<Func<bool>> newCampaignRequestsettingsautoTweet = null, Expression<Func<int[]>> newCampaignRequestsettingsautoPostToFacebook = null, Expression<Func<bool>> newCampaignRequestsettingsfacebookComments = null, Expression<Func<string>> newCampaignRequestvariateSettingswinningCriteria = null, Expression<Func<int>> newCampaignRequestvariateSettingswaitTime = null, Expression<Func<int>> newCampaignRequestvariateSettingstestSize = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssubjectLines = null, Expression<Func<string[]>> newCampaignRequestvariateSettingssendTimes = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsfromNames = null, Expression<Func<string[]>> newCampaignRequestvariateSettingsreplyToAddresses = null, Expression<Func<bool>> newCampaignRequesttrackingopens = null, Expression<Func<bool>> newCampaignRequesttrackinghTMLClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingplainTextClickTracking = null, Expression<Func<bool>> newCampaignRequesttrackingmailChimpGoalTracking = null, Expression<Func<bool>> newCampaignRequesttrackingeCommerce360Tracking = null, Expression<Func<string>> newCampaignRequesttrackinggoogleAnalyticsTracking = null, Expression<Func<string>> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, Expression<Func<bool>> newCampaignRequesttrackingsalesforcesalesforceNote = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseCampaign = null, Expression<Func<bool>> newCampaignRequesttrackinghighrisehighriseNote = null, Expression<Func<bool>> newCampaignRequesttrackingcapsulecapsuleNote = null, Expression<Func<string>> newCampaignRequestrssOptsfeedURL = null, Expression<Func<newCampaignRequestrssOptsfrequencyInput>> newCampaignRequestrssOptsfrequency = null, Expression<Func<string>> newCampaignRequestrssOptsconstrainRSSImages = null, Expression<Func<int>> newCampaignRequestrssOptsschedulesendingHour = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsunday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendmonday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendtuesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendwednesday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendthursday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendfriday = null, Expression<Func<bool>> newCampaignRequestrssOptsscheduledailySendsaturday = null, Expression<Func<newCampaignRequestrssOptsscheduleweeklySendingDayInput>> newCampaignRequestrssOptsscheduleweeklySendingDay = null, Expression<Func<double>> newCampaignRequestrssOptsschedulemonthlySendingDay = null, Expression<Func<string>> newCampaignRequestsocialCardimageURL = null, Expression<Func<string>> newCampaignRequestsocialCardcampaignDescription = null, Expression<Func<string>> newCampaignRequestsocialCardtitle = null)
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
            var segment_optsObject = new JObject();
            var segment_optsObjectpropCount = 0;
            if (newCampaignRequestrecipientssegmentOptssavedSegmentID != null)
            {
                segment_optsObject["saved_segment_id"] = ExpressionConverter.ConvertO(newCampaignRequestrecipientssegmentOptssavedSegmentID);
                segment_optsObjectpropCount++;
            }

            if (newCampaignRequestrecipientssegmentOptsmatchType != null)
            {
                segment_optsObject["match"] = ExpressionConverter.ConvertO(newCampaignRequestrecipientssegmentOptsmatchType);
                segment_optsObjectpropCount++;
            }

            if (segment_optsObjectpropCount > 0)
            {
                recipientsObject["segment_opts"] = segment_optsObject;
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

            var variate_settingsObject = new JObject();
            var variate_settingsObjectpropCount = 0;
            if (newCampaignRequestvariateSettingswinningCriteria != null)
            {
                variate_settingsObject["winner_criteria"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingswinningCriteria);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingswaitTime != null)
            {
                variate_settingsObject["wait_time"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingswaitTime);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingstestSize != null)
            {
                variate_settingsObject["test_size"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingstestSize);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingssubjectLines != null)
            {
                variate_settingsObject["subject_lines"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingssubjectLines);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingssendTimes != null)
            {
                variate_settingsObject["send_times"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingssendTimes);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingsfromNames != null)
            {
                variate_settingsObject["from_names"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingsfromNames);
                variate_settingsObjectpropCount++;
            }

            if (newCampaignRequestvariateSettingsreplyToAddresses != null)
            {
                variate_settingsObject["reply_to_addresses"] = ExpressionConverter.ConvertO(newCampaignRequestvariateSettingsreplyToAddresses);
                variate_settingsObjectpropCount++;
            }

            if (variate_settingsObjectpropCount > 0)
            {
                newCampaignRequest["variate_settings"] = variate_settingsObject;
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

            var rss_optsObject = new JObject();
            var rss_optsObjectpropCount = 0;
            if (newCampaignRequestrssOptsfeedURL != null)
            {
                rss_optsObject["feed_url"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsfeedURL);
                rss_optsObjectpropCount++;
            }

            if (newCampaignRequestrssOptsfrequency != null)
            {
                rss_optsObject["frequency"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsfrequency);
                rss_optsObjectpropCount++;
            }

            if (newCampaignRequestrssOptsconstrainRSSImages != null)
            {
                rss_optsObject["constrain_rss_img"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsconstrainRSSImages);
                rss_optsObjectpropCount++;
            }

            var scheduleObject = new JObject();
            var scheduleObjectpropCount = 0;
            if (newCampaignRequestrssOptsschedulesendingHour != null)
            {
                scheduleObject["hour"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsschedulesendingHour);
                scheduleObjectpropCount++;
            }

            var daily_sendObject = new JObject();
            var daily_sendObjectpropCount = 0;
            if (newCampaignRequestrssOptsscheduledailySendsunday != null)
            {
                daily_sendObject["sunday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendsunday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendmonday != null)
            {
                daily_sendObject["monday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendmonday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendtuesday != null)
            {
                daily_sendObject["tuesday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendtuesday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendwednesday != null)
            {
                daily_sendObject["wednesday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendwednesday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendthursday != null)
            {
                daily_sendObject["thursday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendthursday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendfriday != null)
            {
                daily_sendObject["friday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendfriday);
                daily_sendObjectpropCount++;
            }

            if (newCampaignRequestrssOptsscheduledailySendsaturday != null)
            {
                daily_sendObject["saturday"] = ExpressionConverter.ConvertO(newCampaignRequestrssOptsscheduledailySendsaturday);
                daily_sendObjectpropCount++;
            }

            if (daily_sendObjectpropCount > 0)
            {
                scheduleObject["daily_send"] = daily_sendObject;
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
                rss_optsObject["schedule"] = scheduleObject;
                rss_optsObjectpropCount++;
            }

            if (rss_optsObjectpropCount > 0)
            {
                newCampaignRequest["rss_opts"] = rss_optsObject;
                newCampaignRequestpropCount++;
            }

            var social_cardObject = new JObject();
            var social_cardObjectpropCount = 0;
            if (newCampaignRequestsocialCardimageURL != null)
            {
                social_cardObject["image_url"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardimageURL);
                social_cardObjectpropCount++;
            }

            if (newCampaignRequestsocialCardcampaignDescription != null)
            {
                social_cardObject["description"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardcampaignDescription);
                social_cardObjectpropCount++;
            }

            if (newCampaignRequestsocialCardtitle != null)
            {
                social_cardObject["title"] = ExpressionConverter.ConvertO(newCampaignRequestsocialCardtitle);
                social_cardObjectpropCount++;
            }

            if (social_cardObjectpropCount > 0)
            {
                newCampaignRequest["social_card"] = social_cardObject;
                newCampaignRequestpropCount++;
            }

            if (newCampaignRequestpropCount > 0)
            {
                callPayload.Body = newCampaignRequest;
            }

            return new ApiConnectionAction<CampaignResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction Sendcampaign(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/campaigns/{0}/actions/send", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
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
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
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

            var campaign_defaultsObject = new JObject();
            var campaign_defaultsObjectpropCount = 0;
            campaign_defaultsObjectpropCount++;
            campaign_defaultsObject["from_name"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssenderSName);
            campaign_defaultsObjectpropCount++;
            campaign_defaultsObject["from_email"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssenderSEmailAddress);
            campaign_defaultsObjectpropCount++;
            campaign_defaultsObject["subject"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultssubject);
            campaign_defaultsObjectpropCount++;
            campaign_defaultsObject["language"] = ExpressionConverter.ConvertO(newListRequestcampaignDefaultslanguage);
            if (campaign_defaultsObjectpropCount > 0)
            {
                newListRequest["campaign_defaults"] = campaign_defaultsObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> AddMembers(Expression<Func<string>> listId, Expression<Func<NewMemberInListRequest[]>> bodymembers, Expression<Func<bool>> skipMergeValidation = null, Expression<Func<bool>> skipDuplicateCheck = null, Expression<Func<bool>> bodyupdateExisting = null)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAllMembersResponseModel> GetListMembers(Expression<Func<string>> listId, Expression<Func<int>> count = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["count"] = Convert.ToString(10);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<GetAllMembersResponseModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Addmember(Expression<Func<string>> listId, Expression<Func<newMemberInListstatusInput>> newMemberInListstatus, Expression<Func<string>> newMemberInListemailAddress, Expression<Func<newMemberInListemailTypeInput>> newMemberInListemailType = null, Expression<Func<string>> newMemberInListmergeFieldsfirstName = null, Expression<Func<string>> newMemberInListmergeFieldslastName = null, Expression<Func<string>> newMemberInListlanguage = null, Expression<Func<bool>> newMemberInListvIP = null, Expression<Func<double>> newMemberInListlocationlatitude = null, Expression<Func<double>> newMemberInListlocationlongitude = null)
        {
            var apiCallPath = String.Format("/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var newMemberInList = new JObject();
            var newMemberInListpropCount = 0;
            if (newMemberInListemailType != null)
            {
                newMemberInList["email_type"] = ExpressionConverter.ConvertO(newMemberInListemailType);
                newMemberInListpropCount++;
            }

            newMemberInListpropCount++;
            newMemberInList["status"] = ExpressionConverter.ConvertO(newMemberInListstatus);
            var merge_fieldsObject = new JObject();
            var merge_fieldsObjectpropCount = 0;
            if (newMemberInListmergeFieldsfirstName != null)
            {
                merge_fieldsObject["FNAME"] = ExpressionConverter.ConvertO(newMemberInListmergeFieldsfirstName);
                merge_fieldsObjectpropCount++;
            }

            if (newMemberInListmergeFieldslastName != null)
            {
                merge_fieldsObject["LNAME"] = ExpressionConverter.ConvertO(newMemberInListmergeFieldslastName);
                merge_fieldsObjectpropCount++;
            }

            if (merge_fieldsObjectpropCount > 0)
            {
                newMemberInList["merge_fields"] = merge_fieldsObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction RemovememberV2(Expression<Func<string>> listId, Expression<Func<string>> memberEmail)
        {
            var apiCallPath = String.Format("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["member_email"] = ExpressionConverter.Convert(memberEmail);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> UpdatememberV2(Expression<Func<string>> listId, Expression<Func<string>> memberEmail, Expression<Func<updateMemberInListRequeststatusInput>> updateMemberInListRequeststatus, Expression<Func<updateMemberInListRequestemailTypeInput>> updateMemberInListRequestemailType = null, Expression<Func<string>> updateMemberInListRequestmergeFieldsfirstName = null, Expression<Func<string>> updateMemberInListRequestmergeFieldslastName = null, Expression<Func<string>> updateMemberInListRequestlanguage = null, Expression<Func<bool>> updateMemberInListRequestvIP = null, Expression<Func<double>> updateMemberInListRequestlocationlatitude = null, Expression<Func<double>> updateMemberInListRequestlocationlongitude = null)
        {
            var apiCallPath = String.Format("/lists/replacemailwithhash/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["member_email"] = ExpressionConverter.Convert(memberEmail);
            var updateMemberInListRequest = new JObject();
            var updateMemberInListRequestpropCount = 0;
            if (updateMemberInListRequestemailType != null)
            {
                updateMemberInListRequest["email_type"] = ExpressionConverter.ConvertO(updateMemberInListRequestemailType);
                updateMemberInListRequestpropCount++;
            }

            updateMemberInListRequestpropCount++;
            updateMemberInListRequest["status"] = ExpressionConverter.ConvertO(updateMemberInListRequeststatus);
            var merge_fieldsObject = new JObject();
            var merge_fieldsObjectpropCount = 0;
            if (updateMemberInListRequestmergeFieldsfirstName != null)
            {
                merge_fieldsObject["FNAME"] = ExpressionConverter.ConvertO(updateMemberInListRequestmergeFieldsfirstName);
                merge_fieldsObjectpropCount++;
            }

            if (updateMemberInListRequestmergeFieldslastName != null)
            {
                merge_fieldsObject["LNAME"] = ExpressionConverter.ConvertO(updateMemberInListRequestmergeFieldslastName);
                merge_fieldsObjectpropCount++;
            }

            if (merge_fieldsObjectpropCount > 0)
            {
                updateMemberInListRequest["merge_fields"] = merge_fieldsObject;
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
        }
    }

    public class MailchimpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetMembersResponseModel> OnMemberSubscribed(Expression<Func<string>> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/lists/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
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