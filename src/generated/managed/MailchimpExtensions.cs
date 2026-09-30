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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCampaignsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction Sendcampaign([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/actions/send", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetListsResponseModel> GetLists([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(count, nameof(count), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<GetListsResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CreateNewListResponseModel> Newlist([WorkflowExpression] Func<string> newListRequestlistName, [WorkflowExpression] Func<string> newListRequestcontactcompanyName, [WorkflowExpression] Func<string> newListRequestcontactaddressLine1, [WorkflowExpression] Func<string> newListRequestcontactcity, [WorkflowExpression] Func<string> newListRequestcontactstate, [WorkflowExpression] Func<string> newListRequestcontactpostalCode, [WorkflowExpression] Func<string> newListRequestcontactcountryCode, [WorkflowExpression] Func<string> newListRequestcontactphoneNumber, [WorkflowExpression] Func<string> newListRequestpermissionReminder, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssenderSName, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssenderSEmailAddress, [WorkflowExpression] Func<string> newListRequestcampaignDefaultssubject, [WorkflowExpression] Func<newListRequestcampaignDefaultslanguageInput> newListRequestcampaignDefaultslanguage, [WorkflowExpression] Func<bool> newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, [WorkflowExpression] Func<string> newListRequestcontactaddressLine2 = null, [WorkflowExpression] Func<bool> newListRequestuseArchiveBar = null, [WorkflowExpression] Func<string> newListRequestnotifyOnSubscribe = null, [WorkflowExpression] Func<string> newListRequestnotifyOnUnsubscribe = null, [WorkflowExpression] Func<newListRequestvisibilityInput> newListRequestvisibility = null)
        {
            SourceExpression.Validate(newListRequestlistName, nameof(newListRequestlistName), required: true);
            SourceExpression.Validate(newListRequestcontactcompanyName, nameof(newListRequestcontactcompanyName), required: true);
            SourceExpression.Validate(newListRequestcontactaddressLine1, nameof(newListRequestcontactaddressLine1), required: true);
            SourceExpression.Validate(newListRequestcontactcity, nameof(newListRequestcontactcity), required: true);
            SourceExpression.Validate(newListRequestcontactstate, nameof(newListRequestcontactstate), required: true);
            SourceExpression.Validate(newListRequestcontactpostalCode, nameof(newListRequestcontactpostalCode), required: true);
            SourceExpression.Validate(newListRequestcontactcountryCode, nameof(newListRequestcontactcountryCode), required: true);
            SourceExpression.Validate(newListRequestcontactphoneNumber, nameof(newListRequestcontactphoneNumber), required: true);
            SourceExpression.Validate(newListRequestpermissionReminder, nameof(newListRequestpermissionReminder), required: true);
            SourceExpression.Validate(newListRequestcampaignDefaultssenderSName, nameof(newListRequestcampaignDefaultssenderSName), required: true);
            SourceExpression.Validate(newListRequestcampaignDefaultssenderSEmailAddress, nameof(newListRequestcampaignDefaultssenderSEmailAddress), required: true);
            SourceExpression.Validate(newListRequestcampaignDefaultssubject, nameof(newListRequestcampaignDefaultssubject), required: true);
            SourceExpression.Validate(newListRequestcampaignDefaultslanguage, nameof(newListRequestcampaignDefaultslanguage), required: true);
            SourceExpression.Validate(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse, nameof(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse), required: true);
            SourceExpression.Validate(newListRequestcontactaddressLine2, nameof(newListRequestcontactaddressLine2), required: false);
            SourceExpression.Validate(newListRequestuseArchiveBar, nameof(newListRequestuseArchiveBar), required: false);
            SourceExpression.Validate(newListRequestnotifyOnSubscribe, nameof(newListRequestnotifyOnSubscribe), required: false);
            SourceExpression.Validate(newListRequestnotifyOnUnsubscribe, nameof(newListRequestnotifyOnUnsubscribe), required: false);
            SourceExpression.Validate(newListRequestvisibility, nameof(newListRequestvisibility), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newListRequest = new JObject();
                var newListRequestpropCount = 0;
                newListRequestpropCount++;
                newListRequest["name"] = SourceExpressionConverter.ConvertToken(newListRequestlistName);
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                contactObjectpropCount++;
                contactObject["company"] = SourceExpressionConverter.ConvertToken(newListRequestcontactcompanyName);
                contactObjectpropCount++;
                contactObject["address1"] = SourceExpressionConverter.ConvertToken(newListRequestcontactaddressLine1);
                if (newListRequestcontactaddressLine2 != null)
                {
                    contactObject["address2"] = SourceExpressionConverter.ConvertToken(newListRequestcontactaddressLine2);
                    contactObjectpropCount++;
                }

                contactObjectpropCount++;
                contactObject["city"] = SourceExpressionConverter.ConvertToken(newListRequestcontactcity);
                contactObjectpropCount++;
                contactObject["state"] = SourceExpressionConverter.ConvertToken(newListRequestcontactstate);
                contactObjectpropCount++;
                contactObject["zip"] = SourceExpressionConverter.ConvertToken(newListRequestcontactpostalCode);
                contactObjectpropCount++;
                contactObject["country"] = SourceExpressionConverter.ConvertToken(newListRequestcontactcountryCode);
                contactObjectpropCount++;
                contactObject["phone"] = SourceExpressionConverter.ConvertToken(newListRequestcontactphoneNumber);
                if (contactObjectpropCount > 0)
                {
                    newListRequest["contact"] = contactObject;
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["permission_reminder"] = SourceExpressionConverter.ConvertToken(newListRequestpermissionReminder);
                if (newListRequestuseArchiveBar != null)
                {
                    newListRequest["use_archive_bar"] = SourceExpressionConverter.ConvertToken(newListRequestuseArchiveBar);
                    newListRequestpropCount++;
                }

                var campaignDefaultsObject = new JObject();
                var campaignDefaultsObjectpropCount = 0;
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_name"] = SourceExpressionConverter.ConvertToken(newListRequestcampaignDefaultssenderSName);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["from_email"] = SourceExpressionConverter.ConvertToken(newListRequestcampaignDefaultssenderSEmailAddress);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["subject"] = SourceExpressionConverter.ConvertToken(newListRequestcampaignDefaultssubject);
                campaignDefaultsObjectpropCount++;
                campaignDefaultsObject["language"] = SourceExpressionConverter.Convert(newListRequestcampaignDefaultslanguage);
                if (campaignDefaultsObjectpropCount > 0)
                {
                    newListRequest["campaign_defaults"] = campaignDefaultsObject;
                    newListRequestpropCount++;
                }

                if (newListRequestnotifyOnSubscribe != null)
                {
                    newListRequest["notify_on_subscribe"] = SourceExpressionConverter.ConvertToken(newListRequestnotifyOnSubscribe);
                    newListRequestpropCount++;
                }

                if (newListRequestnotifyOnUnsubscribe != null)
                {
                    newListRequest["notify_on_unsubscribe"] = SourceExpressionConverter.ConvertToken(newListRequestnotifyOnUnsubscribe);
                    newListRequestpropCount++;
                }

                newListRequestpropCount++;
                newListRequest["email_type_option"] = SourceExpressionConverter.ConvertToken(newListRequestallowUsersToChooseBetweenHTMLAndPlainTextTrueFalse);
                if (newListRequestvisibility != null)
                {
                    newListRequest["visibility"] = SourceExpressionConverter.Convert(newListRequestvisibility);
                    newListRequestpropCount++;
                }

                if (newListRequestpropCount > 0)
                {
                    callPayload.Body = newListRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateNewListResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAddMembersBatchResponseModel> AddMembers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<NewMemberInListRequest[]> bodymembers, [WorkflowExpression] Func<bool> skipMergeValidation = null, [WorkflowExpression] Func<bool> skipDuplicateCheck = null, [WorkflowExpression] Func<bool> bodyupdateExisting = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodymembers, nameof(bodymembers), required: true);
            SourceExpression.Validate(skipMergeValidation, nameof(skipMergeValidation), required: false);
            SourceExpression.Validate(skipDuplicateCheck, nameof(skipDuplicateCheck), required: false);
            SourceExpression.Validate(bodyupdateExisting, nameof(bodyupdateExisting), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (skipMergeValidation != null)
                    callPayload.Queries["skip_merge_validation"] = SourceExpressionConverter.ConvertO(skipMergeValidation);
                if (skipDuplicateCheck != null)
                    callPayload.Queries["skip_duplicate_check"] = SourceExpressionConverter.ConvertO(skipDuplicateCheck);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                if (bodyupdateExisting != null)
                {
                    body["update_existing"] = SourceExpressionConverter.ConvertToken(bodyupdateExisting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAddMembersBatchResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<GetAllMembersResponseModel> GetListMembers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(count, nameof(count), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(10);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllMembersResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Addmember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<newMemberInListstatusInput> newMemberInListstatus, [WorkflowExpression] Func<string> newMemberInListemailAddress, [WorkflowExpression] Func<newMemberInListemailTypeInput> newMemberInListemailType = null, [WorkflowExpression] Func<string> newMemberInListmergeFieldsfirstName = null, [WorkflowExpression] Func<string> newMemberInListmergeFieldslastName = null, [WorkflowExpression] Func<string> newMemberInListlanguage = null, [WorkflowExpression] Func<bool> newMemberInListvIP = null, [WorkflowExpression] Func<double> newMemberInListlocationlatitude = null, [WorkflowExpression] Func<double> newMemberInListlocationlongitude = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(newMemberInListstatus, nameof(newMemberInListstatus), required: true);
            SourceExpression.Validate(newMemberInListemailAddress, nameof(newMemberInListemailAddress), required: true);
            SourceExpression.Validate(newMemberInListemailType, nameof(newMemberInListemailType), required: false);
            SourceExpression.Validate(newMemberInListmergeFieldsfirstName, nameof(newMemberInListmergeFieldsfirstName), required: false);
            SourceExpression.Validate(newMemberInListmergeFieldslastName, nameof(newMemberInListmergeFieldslastName), required: false);
            SourceExpression.Validate(newMemberInListlanguage, nameof(newMemberInListlanguage), required: false);
            SourceExpression.Validate(newMemberInListvIP, nameof(newMemberInListvIP), required: false);
            SourceExpression.Validate(newMemberInListlocationlatitude, nameof(newMemberInListlocationlatitude), required: false);
            SourceExpression.Validate(newMemberInListlocationlongitude, nameof(newMemberInListlocationlongitude), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newMemberInList = new JObject();
                var newMemberInListpropCount = 0;
                if (newMemberInListemailType != null)
                {
                    if (newMemberInListemailType != null)
                    {
                        newMemberInList["email_type"] = SourceExpressionConverter.Convert(newMemberInListemailType);
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
                newMemberInList["status"] = SourceExpressionConverter.Convert(newMemberInListstatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (newMemberInListmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = SourceExpressionConverter.ConvertToken(newMemberInListmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (newMemberInListmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = SourceExpressionConverter.ConvertToken(newMemberInListmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    newMemberInList["merge_fields"] = mergeFieldsObject;
                    newMemberInListpropCount++;
                }

                if (newMemberInListlanguage != null)
                {
                    newMemberInList["language"] = SourceExpressionConverter.ConvertToken(newMemberInListlanguage);
                    newMemberInListpropCount++;
                }

                if (newMemberInListvIP != null)
                {
                    newMemberInList["vip"] = SourceExpressionConverter.ConvertToken(newMemberInListvIP);
                    newMemberInListpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (newMemberInListlocationlatitude != null)
                {
                    locationObject["latitude"] = SourceExpressionConverter.ConvertToken(newMemberInListlocationlatitude);
                    locationObjectpropCount++;
                }

                if (newMemberInListlocationlongitude != null)
                {
                    locationObject["longitude"] = SourceExpressionConverter.ConvertToken(newMemberInListlocationlongitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    newMemberInList["location"] = locationObject;
                    newMemberInListpropCount++;
                }

                newMemberInListpropCount++;
                newMemberInList["email_address"] = SourceExpressionConverter.ConvertToken(newMemberInListemailAddress);
                if (newMemberInListpropCount > 0)
                {
                    callPayload.Body = newMemberInList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MemberResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<CampaignResponseModel> Newcampaign([WorkflowExpression] Func<newCampaignRequestcampaignTypeInput> newCampaignRequestcampaignType, [WorkflowExpression] Func<string> newCampaignRequestrecipientslistId, [WorkflowExpression] Func<string> newCampaignRequestsettingscampaignSubjectLine, [WorkflowExpression] Func<string> newCampaignRequestsettingsfromName, [WorkflowExpression] Func<string> newCampaignRequestsettingsreplyToAddress, [WorkflowExpression] Func<int> newCampaignRequestrecipientssegmentOptssavedSegmentId = null, [WorkflowExpression] Func<string> newCampaignRequestrecipientssegmentOptsmatchType = null, [WorkflowExpression] Func<string> newCampaignRequestsettingstitle = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsconversation = null, [WorkflowExpression] Func<string> newCampaignRequestsettingstoName = null, [WorkflowExpression] Func<string> newCampaignRequestsettingsfolderId = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsauthentication = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsautoFooter = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsinlineCSS = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsautoTweet = null, [WorkflowExpression] Func<int[]> newCampaignRequestsettingsautoPostToFacebook = null, [WorkflowExpression] Func<bool> newCampaignRequestsettingsfacebookComments = null, [WorkflowExpression] Func<string> newCampaignRequestvariateSettingswinningCriteria = null, [WorkflowExpression] Func<int> newCampaignRequestvariateSettingswaitTime = null, [WorkflowExpression] Func<int> newCampaignRequestvariateSettingstestSize = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingssubjectLines = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingssendTimes = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingsfromNames = null, [WorkflowExpression] Func<string[]> newCampaignRequestvariateSettingsreplyToAddresses = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingopens = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghTMLClickTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingplainTextClickTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingmailChimpGoalTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingeCommerce360Tracking = null, [WorkflowExpression] Func<string> newCampaignRequesttrackinggoogleAnalyticsTracking = null, [WorkflowExpression] Func<string> newCampaignRequesttrackingclickTaleAnalyticsTracking = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingsalesforcesalesforceCampaign = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingsalesforcesalesforceNote = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghighrisehighriseCampaign = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackinghighrisehighriseNote = null, [WorkflowExpression] Func<bool> newCampaignRequesttrackingcapsulecapsuleNote = null, [WorkflowExpression] Func<string> newCampaignRequestrssOptsfeedURL = null, [WorkflowExpression] Func<newCampaignRequestrssOptsfrequencyInput> newCampaignRequestrssOptsfrequency = null, [WorkflowExpression] Func<string> newCampaignRequestrssOptsconstrainRSSImages = null, [WorkflowExpression] Func<int> newCampaignRequestrssOptsschedulesendingHour = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendsunday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendmonday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendtuesday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendwednesday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendthursday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendfriday = null, [WorkflowExpression] Func<bool> newCampaignRequestrssOptsscheduledailySendsaturday = null, [WorkflowExpression] Func<newCampaignRequestrssOptsscheduleweeklySendingDayInput> newCampaignRequestrssOptsscheduleweeklySendingDay = null, [WorkflowExpression] Func<double> newCampaignRequestrssOptsschedulemonthlySendingDay = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardimageURL = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardcampaignDescription = null, [WorkflowExpression] Func<string> newCampaignRequestsocialCardtitle = null)
        {
            SourceExpression.Validate(newCampaignRequestcampaignType, nameof(newCampaignRequestcampaignType), required: true);
            SourceExpression.Validate(newCampaignRequestrecipientslistId, nameof(newCampaignRequestrecipientslistId), required: true);
            SourceExpression.Validate(newCampaignRequestsettingscampaignSubjectLine, nameof(newCampaignRequestsettingscampaignSubjectLine), required: true);
            SourceExpression.Validate(newCampaignRequestsettingsfromName, nameof(newCampaignRequestsettingsfromName), required: true);
            SourceExpression.Validate(newCampaignRequestsettingsreplyToAddress, nameof(newCampaignRequestsettingsreplyToAddress), required: true);
            SourceExpression.Validate(newCampaignRequestrecipientssegmentOptssavedSegmentId, nameof(newCampaignRequestrecipientssegmentOptssavedSegmentId), required: false);
            SourceExpression.Validate(newCampaignRequestrecipientssegmentOptsmatchType, nameof(newCampaignRequestrecipientssegmentOptsmatchType), required: false);
            SourceExpression.Validate(newCampaignRequestsettingstitle, nameof(newCampaignRequestsettingstitle), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsconversation, nameof(newCampaignRequestsettingsconversation), required: false);
            SourceExpression.Validate(newCampaignRequestsettingstoName, nameof(newCampaignRequestsettingstoName), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsfolderId, nameof(newCampaignRequestsettingsfolderId), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsauthentication, nameof(newCampaignRequestsettingsauthentication), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsautoFooter, nameof(newCampaignRequestsettingsautoFooter), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsinlineCSS, nameof(newCampaignRequestsettingsinlineCSS), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsautoTweet, nameof(newCampaignRequestsettingsautoTweet), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsautoPostToFacebook, nameof(newCampaignRequestsettingsautoPostToFacebook), required: false);
            SourceExpression.Validate(newCampaignRequestsettingsfacebookComments, nameof(newCampaignRequestsettingsfacebookComments), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingswinningCriteria, nameof(newCampaignRequestvariateSettingswinningCriteria), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingswaitTime, nameof(newCampaignRequestvariateSettingswaitTime), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingstestSize, nameof(newCampaignRequestvariateSettingstestSize), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingssubjectLines, nameof(newCampaignRequestvariateSettingssubjectLines), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingssendTimes, nameof(newCampaignRequestvariateSettingssendTimes), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingsfromNames, nameof(newCampaignRequestvariateSettingsfromNames), required: false);
            SourceExpression.Validate(newCampaignRequestvariateSettingsreplyToAddresses, nameof(newCampaignRequestvariateSettingsreplyToAddresses), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingopens, nameof(newCampaignRequesttrackingopens), required: false);
            SourceExpression.Validate(newCampaignRequesttrackinghTMLClickTracking, nameof(newCampaignRequesttrackinghTMLClickTracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingplainTextClickTracking, nameof(newCampaignRequesttrackingplainTextClickTracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingmailChimpGoalTracking, nameof(newCampaignRequesttrackingmailChimpGoalTracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingeCommerce360Tracking, nameof(newCampaignRequesttrackingeCommerce360Tracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackinggoogleAnalyticsTracking, nameof(newCampaignRequesttrackinggoogleAnalyticsTracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingclickTaleAnalyticsTracking, nameof(newCampaignRequesttrackingclickTaleAnalyticsTracking), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingsalesforcesalesforceCampaign, nameof(newCampaignRequesttrackingsalesforcesalesforceCampaign), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingsalesforcesalesforceNote, nameof(newCampaignRequesttrackingsalesforcesalesforceNote), required: false);
            SourceExpression.Validate(newCampaignRequesttrackinghighrisehighriseCampaign, nameof(newCampaignRequesttrackinghighrisehighriseCampaign), required: false);
            SourceExpression.Validate(newCampaignRequesttrackinghighrisehighriseNote, nameof(newCampaignRequesttrackinghighrisehighriseNote), required: false);
            SourceExpression.Validate(newCampaignRequesttrackingcapsulecapsuleNote, nameof(newCampaignRequesttrackingcapsulecapsuleNote), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsfeedURL, nameof(newCampaignRequestrssOptsfeedURL), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsfrequency, nameof(newCampaignRequestrssOptsfrequency), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsconstrainRSSImages, nameof(newCampaignRequestrssOptsconstrainRSSImages), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsschedulesendingHour, nameof(newCampaignRequestrssOptsschedulesendingHour), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendsunday, nameof(newCampaignRequestrssOptsscheduledailySendsunday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendmonday, nameof(newCampaignRequestrssOptsscheduledailySendmonday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendtuesday, nameof(newCampaignRequestrssOptsscheduledailySendtuesday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendwednesday, nameof(newCampaignRequestrssOptsscheduledailySendwednesday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendthursday, nameof(newCampaignRequestrssOptsscheduledailySendthursday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendfriday, nameof(newCampaignRequestrssOptsscheduledailySendfriday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduledailySendsaturday, nameof(newCampaignRequestrssOptsscheduledailySendsaturday), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsscheduleweeklySendingDay, nameof(newCampaignRequestrssOptsscheduleweeklySendingDay), required: false);
            SourceExpression.Validate(newCampaignRequestrssOptsschedulemonthlySendingDay, nameof(newCampaignRequestrssOptsschedulemonthlySendingDay), required: false);
            SourceExpression.Validate(newCampaignRequestsocialCardimageURL, nameof(newCampaignRequestsocialCardimageURL), required: false);
            SourceExpression.Validate(newCampaignRequestsocialCardcampaignDescription, nameof(newCampaignRequestsocialCardcampaignDescription), required: false);
            SourceExpression.Validate(newCampaignRequestsocialCardtitle, nameof(newCampaignRequestsocialCardtitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/campaigns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var newCampaignRequest = new JObject();
                var newCampaignRequestpropCount = 0;
                newCampaignRequestpropCount++;
                newCampaignRequest["type"] = SourceExpressionConverter.Convert(newCampaignRequestcampaignType);
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                recipientsObjectpropCount++;
                recipientsObject["list_id"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrecipientslistId);
                var segmentOptsObject = new JObject();
                var segmentOptsObjectpropCount = 0;
                if (newCampaignRequestrecipientssegmentOptssavedSegmentId != null)
                {
                    segmentOptsObject["saved_segment_id"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrecipientssegmentOptssavedSegmentId);
                    segmentOptsObjectpropCount++;
                }

                if (newCampaignRequestrecipientssegmentOptsmatchType != null)
                {
                    segmentOptsObject["match"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrecipientssegmentOptsmatchType);
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
                settingsObject["subject_line"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingscampaignSubjectLine);
                if (newCampaignRequestsettingstitle != null)
                {
                    settingsObject["title"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingstitle);
                    settingsObjectpropCount++;
                }

                settingsObjectpropCount++;
                settingsObject["from_name"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsfromName);
                settingsObjectpropCount++;
                settingsObject["reply_to"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsreplyToAddress);
                if (newCampaignRequestsettingsconversation != null)
                {
                    settingsObject["use_conversation"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsconversation);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingstoName != null)
                {
                    settingsObject["to_name"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingstoName);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsfolderId != null)
                {
                    settingsObject["folder_id"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsfolderId);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsauthentication != null)
                {
                    settingsObject["authenticate"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsauthentication);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoFooter != null)
                {
                    settingsObject["auto_footer"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsautoFooter);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsinlineCSS != null)
                {
                    settingsObject["inline_css"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsinlineCSS);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoTweet != null)
                {
                    settingsObject["auto_tweet"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsautoTweet);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsautoPostToFacebook != null)
                {
                    settingsObject["auto_fb_post"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsautoPostToFacebook);
                    settingsObjectpropCount++;
                }

                if (newCampaignRequestsettingsfacebookComments != null)
                {
                    settingsObject["fb_comments"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsettingsfacebookComments);
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
                    variateSettingsObject["winner_criteria"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingswinningCriteria);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingswaitTime != null)
                {
                    variateSettingsObject["wait_time"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingswaitTime);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingstestSize != null)
                {
                    variateSettingsObject["test_size"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingstestSize);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingssubjectLines != null)
                {
                    variateSettingsObject["subject_lines"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingssubjectLines);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingssendTimes != null)
                {
                    variateSettingsObject["send_times"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingssendTimes);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingsfromNames != null)
                {
                    variateSettingsObject["from_names"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingsfromNames);
                    variateSettingsObjectpropCount++;
                }

                if (newCampaignRequestvariateSettingsreplyToAddresses != null)
                {
                    variateSettingsObject["reply_to_addresses"] = SourceExpressionConverter.ConvertToken(newCampaignRequestvariateSettingsreplyToAddresses);
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
                    trackingObject["opens"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingopens);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackinghTMLClickTracking != null)
                {
                    trackingObject["html_clicks"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackinghTMLClickTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingplainTextClickTracking != null)
                {
                    trackingObject["text_clicks"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingplainTextClickTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingmailChimpGoalTracking != null)
                {
                    trackingObject["goal_tracking"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingmailChimpGoalTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingeCommerce360Tracking != null)
                {
                    trackingObject["ecomm360"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingeCommerce360Tracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackinggoogleAnalyticsTracking != null)
                {
                    trackingObject["google_analytics"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackinggoogleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                if (newCampaignRequesttrackingclickTaleAnalyticsTracking != null)
                {
                    trackingObject["clicktale"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingclickTaleAnalyticsTracking);
                    trackingObjectpropCount++;
                }

                var salesforceObject = new JObject();
                var salesforceObjectpropCount = 0;
                if (newCampaignRequesttrackingsalesforcesalesforceCampaign != null)
                {
                    salesforceObject["campaign"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingsalesforcesalesforceCampaign);
                    salesforceObjectpropCount++;
                }

                if (newCampaignRequesttrackingsalesforcesalesforceNote != null)
                {
                    salesforceObject["notes"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingsalesforcesalesforceNote);
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
                    highriseObject["campaign"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackinghighrisehighriseCampaign);
                    highriseObjectpropCount++;
                }

                if (newCampaignRequesttrackinghighrisehighriseNote != null)
                {
                    highriseObject["notes"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackinghighrisehighriseNote);
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
                    capsuleObject["notes"] = SourceExpressionConverter.ConvertToken(newCampaignRequesttrackingcapsulecapsuleNote);
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
                    rssOptsObject["feed_url"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsfeedURL);
                    rssOptsObjectpropCount++;
                }

                if (newCampaignRequestrssOptsfrequency != null)
                {
                    rssOptsObject["frequency"] = SourceExpressionConverter.Convert(newCampaignRequestrssOptsfrequency);
                    rssOptsObjectpropCount++;
                }

                if (newCampaignRequestrssOptsconstrainRSSImages != null)
                {
                    rssOptsObject["constrain_rss_img"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsconstrainRSSImages);
                    rssOptsObjectpropCount++;
                }

                var scheduleObject = new JObject();
                var scheduleObjectpropCount = 0;
                if (newCampaignRequestrssOptsschedulesendingHour != null)
                {
                    scheduleObject["hour"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsschedulesendingHour);
                    scheduleObjectpropCount++;
                }

                var dailySendObject = new JObject();
                var dailySendObjectpropCount = 0;
                if (newCampaignRequestrssOptsscheduledailySendsunday != null)
                {
                    dailySendObject["sunday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendsunday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendmonday != null)
                {
                    dailySendObject["monday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendmonday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendtuesday != null)
                {
                    dailySendObject["tuesday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendtuesday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendwednesday != null)
                {
                    dailySendObject["wednesday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendwednesday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendthursday != null)
                {
                    dailySendObject["thursday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendthursday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendfriday != null)
                {
                    dailySendObject["friday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendfriday);
                    dailySendObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduledailySendsaturday != null)
                {
                    dailySendObject["saturday"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsscheduledailySendsaturday);
                    dailySendObjectpropCount++;
                }

                if (dailySendObjectpropCount > 0)
                {
                    scheduleObject["daily_send"] = dailySendObject;
                    scheduleObjectpropCount++;
                }

                if (newCampaignRequestrssOptsscheduleweeklySendingDay != null)
                {
                    scheduleObject["weekly_send_day"] = SourceExpressionConverter.Convert(newCampaignRequestrssOptsscheduleweeklySendingDay);
                    scheduleObjectpropCount++;
                }

                if (newCampaignRequestrssOptsschedulemonthlySendingDay != null)
                {
                    scheduleObject["monthly_send_date"] = SourceExpressionConverter.ConvertToken(newCampaignRequestrssOptsschedulemonthlySendingDay);
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
                    socialCardObject["image_url"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsocialCardimageURL);
                    socialCardObjectpropCount++;
                }

                if (newCampaignRequestsocialCardcampaignDescription != null)
                {
                    socialCardObject["description"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsocialCardcampaignDescription);
                    socialCardObjectpropCount++;
                }

                if (newCampaignRequestsocialCardtitle != null)
                {
                    socialCardObject["title"] = SourceExpressionConverter.ConvertToken(newCampaignRequestsocialCardtitle);
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
                return callPayload;
            }

            return new ApiConnectionAction<CampaignResponseModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IWorkflowAction Removemember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> memberEmail)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(memberEmail, nameof(memberEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = SourceExpressionConverter.ConvertO(memberEmail);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailchimp")]
        public IBodyWorkflowAction<MemberResponseModel> Updatemember([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> memberEmail, [WorkflowExpression] Func<updateMemberInListRequeststatusInput> updateMemberInListRequeststatus, [WorkflowExpression] Func<updateMemberInListRequestemailTypeInput> updateMemberInListRequestemailType = null, [WorkflowExpression] Func<string> updateMemberInListRequestmergeFieldsfirstName = null, [WorkflowExpression] Func<string> updateMemberInListRequestmergeFieldslastName = null, [WorkflowExpression] Func<string> updateMemberInListRequestlanguage = null, [WorkflowExpression] Func<bool> updateMemberInListRequestvIP = null, [WorkflowExpression] Func<double> updateMemberInListRequestlocationlatitude = null, [WorkflowExpression] Func<double> updateMemberInListRequestlocationlongitude = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(memberEmail, nameof(memberEmail), required: true);
            SourceExpression.Validate(updateMemberInListRequeststatus, nameof(updateMemberInListRequeststatus), required: true);
            SourceExpression.Validate(updateMemberInListRequestemailType, nameof(updateMemberInListRequestemailType), required: false);
            SourceExpression.Validate(updateMemberInListRequestmergeFieldsfirstName, nameof(updateMemberInListRequestmergeFieldsfirstName), required: false);
            SourceExpression.Validate(updateMemberInListRequestmergeFieldslastName, nameof(updateMemberInListRequestmergeFieldslastName), required: false);
            SourceExpression.Validate(updateMemberInListRequestlanguage, nameof(updateMemberInListRequestlanguage), required: false);
            SourceExpression.Validate(updateMemberInListRequestvIP, nameof(updateMemberInListRequestvIP), required: false);
            SourceExpression.Validate(updateMemberInListRequestlocationlatitude, nameof(updateMemberInListRequestlocationlatitude), required: false);
            SourceExpression.Validate(updateMemberInListRequestlocationlongitude, nameof(updateMemberInListRequestlocationlongitude), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/replacemailwithhash/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["member_email"] = SourceExpressionConverter.ConvertO(memberEmail);
                var updateMemberInListRequest = new JObject();
                var updateMemberInListRequestpropCount = 0;
                if (updateMemberInListRequestemailType != null)
                {
                    if (updateMemberInListRequestemailType != null)
                    {
                        updateMemberInListRequest["email_type"] = SourceExpressionConverter.Convert(updateMemberInListRequestemailType);
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
                updateMemberInListRequest["status"] = SourceExpressionConverter.Convert(updateMemberInListRequeststatus);
                var mergeFieldsObject = new JObject();
                var mergeFieldsObjectpropCount = 0;
                if (updateMemberInListRequestmergeFieldsfirstName != null)
                {
                    mergeFieldsObject["FNAME"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestmergeFieldsfirstName);
                    mergeFieldsObjectpropCount++;
                }

                if (updateMemberInListRequestmergeFieldslastName != null)
                {
                    mergeFieldsObject["LNAME"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestmergeFieldslastName);
                    mergeFieldsObjectpropCount++;
                }

                if (mergeFieldsObjectpropCount > 0)
                {
                    updateMemberInListRequest["merge_fields"] = mergeFieldsObject;
                    updateMemberInListRequestpropCount++;
                }

                if (updateMemberInListRequestlanguage != null)
                {
                    updateMemberInListRequest["language"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestlanguage);
                    updateMemberInListRequestpropCount++;
                }

                if (updateMemberInListRequestvIP != null)
                {
                    updateMemberInListRequest["vip"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestvIP);
                    updateMemberInListRequestpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (updateMemberInListRequestlocationlatitude != null)
                {
                    locationObject["latitude"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestlocationlatitude);
                    locationObjectpropCount++;
                }

                if (updateMemberInListRequestlocationlongitude != null)
                {
                    locationObject["longitude"] = SourceExpressionConverter.ConvertToken(updateMemberInListRequestlocationlongitude);
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
                return callPayload;
            }

            return new ApiConnectionAction<MemberResponseModel>(BuildSourceInput);
        }
    }

    public class MailchimpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetMembersResponseModel> OnMemberSubscribed([WorkflowExpression] Func<string> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/lists/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetMembersResponseModel>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetListsResponseModel> OnCreateList(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetListsResponseModel>(BuildSourceInput, triggerName, recurrence);
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