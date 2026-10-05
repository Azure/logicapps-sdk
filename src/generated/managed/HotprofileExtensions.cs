//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hotprofile
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HotprofileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionCreateBusinessCard))]
        public IBodyWorkflowAction<ActionCreateBusinessCardResponse> ActionCreateBusinessCard([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<string> familyName, [WorkflowExpression] Func<int> status, [WorkflowExpression] Func<int> openStatus, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<int> ownerUserId = null, [WorkflowExpression] Func<string> ownerUser = null, [WorkflowExpression] Func<string> tradeOn = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> directNote = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionCreateBusinessCardResponse> __BuildActionCreateBusinessCard(WorkflowValue<int> clientId, WorkflowValue<string> familyName, WorkflowValue<int> status, WorkflowValue<int> openStatus, WorkflowValue<int> organizationId = null, WorkflowValue<string> firstName = null, WorkflowValue<string> familyNameKana = null, WorkflowValue<string> firstNameKana = null, WorkflowValue<string> tel = null, WorkflowValue<int> extension = null, WorkflowValue<string> fax = null, WorkflowValue<string> email = null, WorkflowValue<string> mobileTel = null, WorkflowValue<string> mobileEmail = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<string> url = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> leadSourceKbnId = null, WorkflowValue<string> leadSource = null, WorkflowValue<int> ownerUserId = null, WorkflowValue<string> ownerUser = null, WorkflowValue<string> tradeOn = null, WorkflowValue<string> note = null, WorkflowValue<string> directNote = null)
        {
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(familyName, nameof(familyName), required: true);
            WorkflowValue.Validate(status, nameof(status), required: true);
            WorkflowValue.Validate(openStatus, nameof(openStatus), required: true);
            WorkflowValue.Validate(organizationId, nameof(organizationId), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(familyNameKana, nameof(familyNameKana), required: false);
            WorkflowValue.Validate(firstNameKana, nameof(firstNameKana), required: false);
            WorkflowValue.Validate(tel, nameof(tel), required: false);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(fax, nameof(fax), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(mobileTel, nameof(mobileTel), required: false);
            WorkflowValue.Validate(mobileEmail, nameof(mobileEmail), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            WorkflowValue.Validate(leadSource, nameof(leadSource), required: false);
            WorkflowValue.Validate(ownerUserId, nameof(ownerUserId), required: false);
            WorkflowValue.Validate(ownerUser, nameof(ownerUser), required: false);
            WorkflowValue.Validate(tradeOn, nameof(tradeOn), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(directNote, nameof(directNote), required: false);
            return new DeferredBodyAction<ActionCreateBusinessCardResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
                callPayload.Queries["family_name"] = ExpressionConverter.Convert(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(fax);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(leadSource);
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                callPayload.Queries["open_status"] = ExpressionConverter.Convert(openStatus);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(ownerUserId);
                if (ownerUser != null)
                    callPayload.Queries["owner_user"] = ExpressionConverter.Convert(ownerUser);
                if (tradeOn != null)
                    callPayload.Queries["trade_on"] = ExpressionConverter.Convert(tradeOn);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (directNote != null)
                    callPayload.Queries["direct_note"] = ExpressionConverter.Convert(directNote);
                return new ApiConnectionAction<ActionCreateBusinessCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionGetBusinessCards))]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> ActionGetBusinessCards([WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<bool> pageDateFormatOption = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<string> searchFamilyName = null, [WorkflowExpression] Func<string> searchFirstName = null, [WorkflowExpression] Func<string> searchFamilyNameKana = null, [WorkflowExpression] Func<string> searchFirstNameKana = null, [WorkflowExpression] Func<string> searchClientName = null, [WorkflowExpression] Func<string> searchFromTradeOn = null, [WorkflowExpression] Func<string> searchToTradeOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchOrganizationAncestryAllName = null, [WorkflowExpression] Func<string> searchPost = null, [WorkflowExpression] Func<string> searchTel = null, [WorkflowExpression] Func<string> searchFax = null, [WorkflowExpression] Func<string> searchMobileTel = null, [WorkflowExpression] Func<string> searchEmail = null, [WorkflowExpression] Func<string> searchMobileEmail = null, [WorkflowExpression] Func<int> searchRoleId = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<string> searchDirectNote = null, [WorkflowExpression] Func<string> searchLeadSource = null, [WorkflowExpression] Func<string> searchRequestKey = null, [WorkflowExpression] Func<int> searchLatitude = null, [WorkflowExpression] Func<int> searchLongitude = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> __BuildActionGetBusinessCards(WorkflowValue<int> pageNumber = null, WorkflowValue<int> pageDisplayNumber = null, WorkflowValue<bool> pageDateFormatOption = null, WorkflowValue<string> orderKey = null, WorkflowValue<string> orderType = null, WorkflowValue<string> searchFamilyName = null, WorkflowValue<string> searchFirstName = null, WorkflowValue<string> searchFamilyNameKana = null, WorkflowValue<string> searchFirstNameKana = null, WorkflowValue<string> searchClientName = null, WorkflowValue<string> searchFromTradeOn = null, WorkflowValue<string> searchToTradeOn = null, WorkflowValue<string> searchFromUpdatedOn = null, WorkflowValue<string> searchToUpdatedOn = null, WorkflowValue<string> searchFromCreatedOn = null, WorkflowValue<string> searchToCreatedOn = null, WorkflowValue<string> searchOrganizationAncestryAllName = null, WorkflowValue<string> searchPost = null, WorkflowValue<string> searchTel = null, WorkflowValue<string> searchFax = null, WorkflowValue<string> searchMobileTel = null, WorkflowValue<string> searchEmail = null, WorkflowValue<string> searchMobileEmail = null, WorkflowValue<int> searchRoleId = null, WorkflowValue<string> searchZip = null, WorkflowValue<string> searchAddress = null, WorkflowValue<string> searchUrl = null, WorkflowValue<string> searchNote = null, WorkflowValue<string> searchDirectNote = null, WorkflowValue<string> searchLeadSource = null, WorkflowValue<string> searchRequestKey = null, WorkflowValue<int> searchLatitude = null, WorkflowValue<int> searchLongitude = null)
        {
            WorkflowValue.Validate(pageNumber, nameof(pageNumber), required: false);
            WorkflowValue.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            WorkflowValue.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            WorkflowValue.Validate(orderKey, nameof(orderKey), required: false);
            WorkflowValue.Validate(orderType, nameof(orderType), required: false);
            WorkflowValue.Validate(searchFamilyName, nameof(searchFamilyName), required: false);
            WorkflowValue.Validate(searchFirstName, nameof(searchFirstName), required: false);
            WorkflowValue.Validate(searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            WorkflowValue.Validate(searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            WorkflowValue.Validate(searchClientName, nameof(searchClientName), required: false);
            WorkflowValue.Validate(searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            WorkflowValue.Validate(searchToTradeOn, nameof(searchToTradeOn), required: false);
            WorkflowValue.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            WorkflowValue.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            WorkflowValue.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            WorkflowValue.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            WorkflowValue.Validate(searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            WorkflowValue.Validate(searchPost, nameof(searchPost), required: false);
            WorkflowValue.Validate(searchTel, nameof(searchTel), required: false);
            WorkflowValue.Validate(searchFax, nameof(searchFax), required: false);
            WorkflowValue.Validate(searchMobileTel, nameof(searchMobileTel), required: false);
            WorkflowValue.Validate(searchEmail, nameof(searchEmail), required: false);
            WorkflowValue.Validate(searchMobileEmail, nameof(searchMobileEmail), required: false);
            WorkflowValue.Validate(searchRoleId, nameof(searchRoleId), required: false);
            WorkflowValue.Validate(searchZip, nameof(searchZip), required: false);
            WorkflowValue.Validate(searchAddress, nameof(searchAddress), required: false);
            WorkflowValue.Validate(searchUrl, nameof(searchUrl), required: false);
            WorkflowValue.Validate(searchNote, nameof(searchNote), required: false);
            WorkflowValue.Validate(searchDirectNote, nameof(searchDirectNote), required: false);
            WorkflowValue.Validate(searchLeadSource, nameof(searchLeadSource), required: false);
            WorkflowValue.Validate(searchRequestKey, nameof(searchRequestKey), required: false);
            WorkflowValue.Validate(searchLatitude, nameof(searchLatitude), required: false);
            WorkflowValue.Validate(searchLongitude, nameof(searchLongitude), required: false);
            return new DeferredBodyAction<ActionGetBusinessCardsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/get_entry_list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(pageNumber);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(pageDisplayNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(pageDateFormatOption);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(orderType);
                if (searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = ExpressionConverter.Convert(searchFamilyName);
                if (searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = ExpressionConverter.Convert(searchFirstName);
                if (searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = ExpressionConverter.Convert(searchFamilyNameKana);
                if (searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = ExpressionConverter.Convert(searchFirstNameKana);
                if (searchClientName != null)
                    callPayload.Queries["search[client_name]"] = ExpressionConverter.Convert(searchClientName);
                if (searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = ExpressionConverter.Convert(searchFromTradeOn);
                if (searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = ExpressionConverter.Convert(searchToTradeOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(searchToUpdatedOn);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(searchToCreatedOn);
                if (searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = ExpressionConverter.Convert(searchOrganizationAncestryAllName);
                if (searchPost != null)
                    callPayload.Queries["search[post]"] = ExpressionConverter.Convert(searchPost);
                if (searchTel != null)
                    callPayload.Queries["search[tel]"] = ExpressionConverter.Convert(searchTel);
                if (searchFax != null)
                    callPayload.Queries["search[fax]"] = ExpressionConverter.Convert(searchFax);
                if (searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = ExpressionConverter.Convert(searchMobileTel);
                if (searchEmail != null)
                    callPayload.Queries["search[email]"] = ExpressionConverter.Convert(searchEmail);
                if (searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = ExpressionConverter.Convert(searchMobileEmail);
                if (searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = ExpressionConverter.Convert(searchRoleId);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(searchZip);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(searchAddress);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(searchUrl);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(searchNote);
                if (searchDirectNote != null)
                    callPayload.Queries["search[direct_note]"] = ExpressionConverter.Convert(searchDirectNote);
                if (searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = ExpressionConverter.Convert(searchLeadSource);
                if (searchRequestKey != null)
                    callPayload.Queries["search[request_key]"] = ExpressionConverter.Convert(searchRequestKey);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(searchLongitude);
                return new ApiConnectionAction<ActionGetBusinessCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionUpdateBusinessCard))]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> ActionUpdateBusinessCard([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> familyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<int> openStatus = null, [WorkflowExpression] Func<int> ownerUserId = null, [WorkflowExpression] Func<string> ownerUser = null, [WorkflowExpression] Func<string> tradeOn = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> directNote = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> __BuildActionUpdateBusinessCard(WorkflowValue<int> id, WorkflowValue<int> clientId, WorkflowValue<int> organizationId = null, WorkflowValue<string> familyName = null, WorkflowValue<string> firstName = null, WorkflowValue<string> familyNameKana = null, WorkflowValue<string> firstNameKana = null, WorkflowValue<string> tel = null, WorkflowValue<int> extension = null, WorkflowValue<string> fax = null, WorkflowValue<string> email = null, WorkflowValue<string> mobileTel = null, WorkflowValue<string> mobileEmail = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<string> url = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> leadSourceKbnId = null, WorkflowValue<string> leadSource = null, WorkflowValue<int> status = null, WorkflowValue<int> openStatus = null, WorkflowValue<int> ownerUserId = null, WorkflowValue<string> ownerUser = null, WorkflowValue<string> tradeOn = null, WorkflowValue<string> note = null, WorkflowValue<string> directNote = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(organizationId, nameof(organizationId), required: false);
            WorkflowValue.Validate(familyName, nameof(familyName), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(familyNameKana, nameof(familyNameKana), required: false);
            WorkflowValue.Validate(firstNameKana, nameof(firstNameKana), required: false);
            WorkflowValue.Validate(tel, nameof(tel), required: false);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(fax, nameof(fax), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(mobileTel, nameof(mobileTel), required: false);
            WorkflowValue.Validate(mobileEmail, nameof(mobileEmail), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            WorkflowValue.Validate(leadSource, nameof(leadSource), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(openStatus, nameof(openStatus), required: false);
            WorkflowValue.Validate(ownerUserId, nameof(ownerUserId), required: false);
            WorkflowValue.Validate(ownerUser, nameof(ownerUser), required: false);
            WorkflowValue.Validate(tradeOn, nameof(tradeOn), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(directNote, nameof(directNote), required: false);
            return new DeferredBodyAction<ActionUpdateBusinessCardResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
                if (familyName != null)
                    callPayload.Queries["family_name"] = ExpressionConverter.Convert(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(fax);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(leadSource);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (openStatus != null)
                    callPayload.Queries["open_status"] = ExpressionConverter.Convert(openStatus);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(ownerUserId);
                if (ownerUser != null)
                    callPayload.Queries["owner_user"] = ExpressionConverter.Convert(ownerUser);
                if (tradeOn != null)
                    callPayload.Queries["trade_on"] = ExpressionConverter.Convert(tradeOn);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (directNote != null)
                    callPayload.Queries["direct_note"] = ExpressionConverter.Convert(directNote);
                return new ApiConnectionAction<ActionUpdateBusinessCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionCreateClient))]
        public IBodyWorkflowAction<ActionCreateClientResponse> ActionCreateClient([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> nameDisp, [WorkflowExpression] Func<string> nameKana = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> businessCategoryKbn = null, [WorkflowExpression] Func<int> workerNumberKbn = null, [WorkflowExpression] Func<int> capitalKbn = null, [WorkflowExpression] Func<int> ipoKbn = null, [WorkflowExpression] Func<string> salesLastYear = null, [WorkflowExpression] Func<string> mainTel = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> mailDomain = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> nameSub = null, [WorkflowExpression] Func<string> nameKanaSub = null, [WorkflowExpression] Func<string> zipSub = null, [WorkflowExpression] Func<string> addressSub = null, [WorkflowExpression] Func<string> prefSub = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionCreateClientResponse> __BuildActionCreateClient(WorkflowValue<string> name, WorkflowValue<string> nameDisp, WorkflowValue<string> nameKana = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> businessCategoryKbn = null, WorkflowValue<int> workerNumberKbn = null, WorkflowValue<int> capitalKbn = null, WorkflowValue<int> ipoKbn = null, WorkflowValue<string> salesLastYear = null, WorkflowValue<string> mainTel = null, WorkflowValue<string> url = null, WorkflowValue<string> mailDomain = null, WorkflowValue<int> userId = null, WorkflowValue<string> note = null, WorkflowValue<string> nameSub = null, WorkflowValue<string> nameKanaSub = null, WorkflowValue<string> zipSub = null, WorkflowValue<string> addressSub = null, WorkflowValue<string> prefSub = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(nameDisp, nameof(nameDisp), required: true);
            WorkflowValue.Validate(nameKana, nameof(nameKana), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            WorkflowValue.Validate(workerNumberKbn, nameof(workerNumberKbn), required: false);
            WorkflowValue.Validate(capitalKbn, nameof(capitalKbn), required: false);
            WorkflowValue.Validate(ipoKbn, nameof(ipoKbn), required: false);
            WorkflowValue.Validate(salesLastYear, nameof(salesLastYear), required: false);
            WorkflowValue.Validate(mainTel, nameof(mainTel), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(mailDomain, nameof(mailDomain), required: false);
            WorkflowValue.Validate(userId, nameof(userId), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(nameSub, nameof(nameSub), required: false);
            WorkflowValue.Validate(nameKanaSub, nameof(nameKanaSub), required: false);
            WorkflowValue.Validate(zipSub, nameof(zipSub), required: false);
            WorkflowValue.Validate(addressSub, nameof(addressSub), required: false);
            WorkflowValue.Validate(prefSub, nameof(prefSub), required: false);
            return new DeferredBodyAction<ActionCreateClientResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (nameKana != null)
                    callPayload.Queries["name_kana"] = ExpressionConverter.Convert(nameKana);
                callPayload.Queries["name_disp"] = ExpressionConverter.Convert(nameDisp);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = ExpressionConverter.Convert(businessCategoryKbn);
                if (workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = ExpressionConverter.Convert(workerNumberKbn);
                if (capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = ExpressionConverter.Convert(capitalKbn);
                if (ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = ExpressionConverter.Convert(ipoKbn);
                if (salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = ExpressionConverter.Convert(salesLastYear);
                if (mainTel != null)
                    callPayload.Queries["main_tel"] = ExpressionConverter.Convert(mainTel);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (mailDomain != null)
                    callPayload.Queries["mail_domain"] = ExpressionConverter.Convert(mailDomain);
                if (userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(userId);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (nameSub != null)
                    callPayload.Queries["name_sub"] = ExpressionConverter.Convert(nameSub);
                if (nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = ExpressionConverter.Convert(nameKanaSub);
                if (zipSub != null)
                    callPayload.Queries["zip_sub"] = ExpressionConverter.Convert(zipSub);
                if (addressSub != null)
                    callPayload.Queries["address_sub"] = ExpressionConverter.Convert(addressSub);
                if (prefSub != null)
                    callPayload.Queries["pref_sub"] = ExpressionConverter.Convert(prefSub);
                return new ApiConnectionAction<ActionCreateClientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionGetClients))]
        public IBodyWorkflowAction<ActionGetClientsResponse> ActionGetClients([WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<int> pageDateFormatOption = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<int> searchFromId = null, [WorkflowExpression] Func<int> searchToId = null, [WorkflowExpression] Func<string> searchName = null, [WorkflowExpression] Func<string> searchNameKana = null, [WorkflowExpression] Func<string> searchNameDisp = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchLatitude = null, [WorkflowExpression] Func<string> searchLongitude = null, [WorkflowExpression] Func<string> searchCorporateNumber = null, [WorkflowExpression] Func<string> searchMainTel = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchMailDomain = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<int> searchUserIds = null, [WorkflowExpression] Func<string> searchNameSub = null, [WorkflowExpression] Func<string> searchNameKanaSub = null, [WorkflowExpression] Func<string> searchZipSub = null, [WorkflowExpression] Func<string> searchAddressSub = null, [WorkflowExpression] Func<string> searchPrefSub = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchToDatetimeUpdatedOn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionGetClientsResponse> __BuildActionGetClients(WorkflowValue<int> pageNumber = null, WorkflowValue<int> pageDisplayNumber = null, WorkflowValue<int> pageDateFormatOption = null, WorkflowValue<string> orderKey = null, WorkflowValue<string> orderType = null, WorkflowValue<int> searchFromId = null, WorkflowValue<int> searchToId = null, WorkflowValue<string> searchName = null, WorkflowValue<string> searchNameKana = null, WorkflowValue<string> searchNameDisp = null, WorkflowValue<string> searchZip = null, WorkflowValue<string> searchAddress = null, WorkflowValue<string> searchLatitude = null, WorkflowValue<string> searchLongitude = null, WorkflowValue<string> searchCorporateNumber = null, WorkflowValue<string> searchMainTel = null, WorkflowValue<string> searchUrl = null, WorkflowValue<string> searchMailDomain = null, WorkflowValue<string> searchNote = null, WorkflowValue<int> searchUserIds = null, WorkflowValue<string> searchNameSub = null, WorkflowValue<string> searchNameKanaSub = null, WorkflowValue<string> searchZipSub = null, WorkflowValue<string> searchAddressSub = null, WorkflowValue<string> searchPrefSub = null, WorkflowValue<string> searchFromCreatedOn = null, WorkflowValue<string> searchToCreatedOn = null, WorkflowValue<string> searchFromUpdatedOn = null, WorkflowValue<string> searchToUpdatedOn = null, WorkflowValue<string> searchFromDatetimeUpdatedOn = null, WorkflowValue<string> searchToDatetimeUpdatedOn = null)
        {
            WorkflowValue.Validate(pageNumber, nameof(pageNumber), required: false);
            WorkflowValue.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            WorkflowValue.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            WorkflowValue.Validate(orderKey, nameof(orderKey), required: false);
            WorkflowValue.Validate(orderType, nameof(orderType), required: false);
            WorkflowValue.Validate(searchFromId, nameof(searchFromId), required: false);
            WorkflowValue.Validate(searchToId, nameof(searchToId), required: false);
            WorkflowValue.Validate(searchName, nameof(searchName), required: false);
            WorkflowValue.Validate(searchNameKana, nameof(searchNameKana), required: false);
            WorkflowValue.Validate(searchNameDisp, nameof(searchNameDisp), required: false);
            WorkflowValue.Validate(searchZip, nameof(searchZip), required: false);
            WorkflowValue.Validate(searchAddress, nameof(searchAddress), required: false);
            WorkflowValue.Validate(searchLatitude, nameof(searchLatitude), required: false);
            WorkflowValue.Validate(searchLongitude, nameof(searchLongitude), required: false);
            WorkflowValue.Validate(searchCorporateNumber, nameof(searchCorporateNumber), required: false);
            WorkflowValue.Validate(searchMainTel, nameof(searchMainTel), required: false);
            WorkflowValue.Validate(searchUrl, nameof(searchUrl), required: false);
            WorkflowValue.Validate(searchMailDomain, nameof(searchMailDomain), required: false);
            WorkflowValue.Validate(searchNote, nameof(searchNote), required: false);
            WorkflowValue.Validate(searchUserIds, nameof(searchUserIds), required: false);
            WorkflowValue.Validate(searchNameSub, nameof(searchNameSub), required: false);
            WorkflowValue.Validate(searchNameKanaSub, nameof(searchNameKanaSub), required: false);
            WorkflowValue.Validate(searchZipSub, nameof(searchZipSub), required: false);
            WorkflowValue.Validate(searchAddressSub, nameof(searchAddressSub), required: false);
            WorkflowValue.Validate(searchPrefSub, nameof(searchPrefSub), required: false);
            WorkflowValue.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            WorkflowValue.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            WorkflowValue.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            WorkflowValue.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            WorkflowValue.Validate(searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            WorkflowValue.Validate(searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            return new DeferredBodyAction<ActionGetClientsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(pageNumber);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(pageDisplayNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(pageDateFormatOption);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(orderType);
                if (searchFromId != null)
                    callPayload.Queries["search[from_id]"] = ExpressionConverter.Convert(searchFromId);
                if (searchToId != null)
                    callPayload.Queries["search[to_id]"] = ExpressionConverter.Convert(searchToId);
                if (searchName != null)
                    callPayload.Queries["search[name]"] = ExpressionConverter.Convert(searchName);
                if (searchNameKana != null)
                    callPayload.Queries["search[name_kana]"] = ExpressionConverter.Convert(searchNameKana);
                if (searchNameDisp != null)
                    callPayload.Queries["search[name_disp]"] = ExpressionConverter.Convert(searchNameDisp);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(searchZip);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(searchAddress);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(searchLongitude);
                if (searchCorporateNumber != null)
                    callPayload.Queries["search[corporate_number]"] = ExpressionConverter.Convert(searchCorporateNumber);
                if (searchMainTel != null)
                    callPayload.Queries["search[main_tel]"] = ExpressionConverter.Convert(searchMainTel);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(searchUrl);
                if (searchMailDomain != null)
                    callPayload.Queries["search[mail_domain]"] = ExpressionConverter.Convert(searchMailDomain);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(searchNote);
                if (searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = ExpressionConverter.Convert(searchUserIds);
                if (searchNameSub != null)
                    callPayload.Queries["search[name_sub]"] = ExpressionConverter.Convert(searchNameSub);
                if (searchNameKanaSub != null)
                    callPayload.Queries["search[name_kana_sub]"] = ExpressionConverter.Convert(searchNameKanaSub);
                if (searchZipSub != null)
                    callPayload.Queries["search[zip_sub]"] = ExpressionConverter.Convert(searchZipSub);
                if (searchAddressSub != null)
                    callPayload.Queries["search[address_sub]"] = ExpressionConverter.Convert(searchAddressSub);
                if (searchPrefSub != null)
                    callPayload.Queries["search[pref_sub]"] = ExpressionConverter.Convert(searchPrefSub);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(searchToCreatedOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(searchToUpdatedOn);
                if (searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = ExpressionConverter.Convert(searchFromDatetimeUpdatedOn);
                if (searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = ExpressionConverter.Convert(searchToDatetimeUpdatedOn);
                return new ApiConnectionAction<ActionGetClientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionUpdateClient))]
        public IBodyWorkflowAction<ActionUpdateClientResponse> ActionUpdateClient([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> nameKana = null, [WorkflowExpression] Func<string> nameDisp = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> businessCategoryKbn = null, [WorkflowExpression] Func<int> workerNumberKbn = null, [WorkflowExpression] Func<int> capitalKbn = null, [WorkflowExpression] Func<int> ipoKbn = null, [WorkflowExpression] Func<string> salesLastYear = null, [WorkflowExpression] Func<string> mainTel = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> mailDomain = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> nameSub = null, [WorkflowExpression] Func<string> nameKanaSub = null, [WorkflowExpression] Func<string> zipSub = null, [WorkflowExpression] Func<string> addressSub = null, [WorkflowExpression] Func<string> prefSub = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionUpdateClientResponse> __BuildActionUpdateClient(WorkflowValue<int> id, WorkflowValue<string> name = null, WorkflowValue<string> nameKana = null, WorkflowValue<string> nameDisp = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> businessCategoryKbn = null, WorkflowValue<int> workerNumberKbn = null, WorkflowValue<int> capitalKbn = null, WorkflowValue<int> ipoKbn = null, WorkflowValue<string> salesLastYear = null, WorkflowValue<string> mainTel = null, WorkflowValue<string> url = null, WorkflowValue<string> mailDomain = null, WorkflowValue<int> userId = null, WorkflowValue<string> note = null, WorkflowValue<string> nameSub = null, WorkflowValue<string> nameKanaSub = null, WorkflowValue<string> zipSub = null, WorkflowValue<string> addressSub = null, WorkflowValue<string> prefSub = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(name, nameof(name), required: false);
            WorkflowValue.Validate(nameKana, nameof(nameKana), required: false);
            WorkflowValue.Validate(nameDisp, nameof(nameDisp), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            WorkflowValue.Validate(workerNumberKbn, nameof(workerNumberKbn), required: false);
            WorkflowValue.Validate(capitalKbn, nameof(capitalKbn), required: false);
            WorkflowValue.Validate(ipoKbn, nameof(ipoKbn), required: false);
            WorkflowValue.Validate(salesLastYear, nameof(salesLastYear), required: false);
            WorkflowValue.Validate(mainTel, nameof(mainTel), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(mailDomain, nameof(mailDomain), required: false);
            WorkflowValue.Validate(userId, nameof(userId), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(nameSub, nameof(nameSub), required: false);
            WorkflowValue.Validate(nameKanaSub, nameof(nameKanaSub), required: false);
            WorkflowValue.Validate(zipSub, nameof(zipSub), required: false);
            WorkflowValue.Validate(addressSub, nameof(addressSub), required: false);
            WorkflowValue.Validate(prefSub, nameof(prefSub), required: false);
            return new DeferredBodyAction<ActionUpdateClientResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (nameKana != null)
                    callPayload.Queries["name_kana"] = ExpressionConverter.Convert(nameKana);
                if (nameDisp != null)
                    callPayload.Queries["name_disp"] = ExpressionConverter.Convert(nameDisp);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = ExpressionConverter.Convert(businessCategoryKbn);
                if (workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = ExpressionConverter.Convert(workerNumberKbn);
                if (capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = ExpressionConverter.Convert(capitalKbn);
                if (ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = ExpressionConverter.Convert(ipoKbn);
                if (salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = ExpressionConverter.Convert(salesLastYear);
                if (mainTel != null)
                    callPayload.Queries["main_tel"] = ExpressionConverter.Convert(mainTel);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (mailDomain != null)
                    callPayload.Queries["mail_domain"] = ExpressionConverter.Convert(mailDomain);
                if (userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(userId);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (nameSub != null)
                    callPayload.Queries["name_sub"] = ExpressionConverter.Convert(nameSub);
                if (nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = ExpressionConverter.Convert(nameKanaSub);
                if (zipSub != null)
                    callPayload.Queries["zip_sub"] = ExpressionConverter.Convert(zipSub);
                if (addressSub != null)
                    callPayload.Queries["address_sub"] = ExpressionConverter.Convert(addressSub);
                if (prefSub != null)
                    callPayload.Queries["pref_sub"] = ExpressionConverter.Convert(prefSub);
                return new ApiConnectionAction<ActionUpdateClientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionCreateLead))]
        public IBodyWorkflowAction<ActionCreateLeadResponse> ActionCreateLead([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<string> familyName, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> post = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> leadStatus = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<bool> errorMailFlg = null, [WorkflowExpression] Func<bool> errorTelFlg = null, [WorkflowExpression] Func<bool> errorFaxFlg = null, [WorkflowExpression] Func<bool> errorAddressFlg = null, [WorkflowExpression] Func<bool> notMailFlg = null, [WorkflowExpression] Func<bool> notTelFlg = null, [WorkflowExpression] Func<bool> notFaxFlg = null, [WorkflowExpression] Func<bool> notDmFlg = null, [WorkflowExpression] Func<bool> competitorFlg = null, [WorkflowExpression] Func<bool> importantCustomerFlg = null, [WorkflowExpression] Func<bool> endUserFlg = null, [WorkflowExpression] Func<bool> storeFlg = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> ownerUserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionCreateLeadResponse> __BuildActionCreateLead(WorkflowValue<int> clientId, WorkflowValue<string> familyName, WorkflowValue<string> firstName = null, WorkflowValue<string> familyNameKana = null, WorkflowValue<string> firstNameKana = null, WorkflowValue<int> organizationId = null, WorkflowValue<string> post = null, WorkflowValue<string> tel = null, WorkflowValue<int> extension = null, WorkflowValue<string> fax = null, WorkflowValue<string> email = null, WorkflowValue<string> mobileTel = null, WorkflowValue<string> mobileEmail = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<string> url = null, WorkflowValue<int> leadStatus = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> leadSourceKbnId = null, WorkflowValue<string> leadSource = null, WorkflowValue<string> note = null, WorkflowValue<bool> errorMailFlg = null, WorkflowValue<bool> errorTelFlg = null, WorkflowValue<bool> errorFaxFlg = null, WorkflowValue<bool> errorAddressFlg = null, WorkflowValue<bool> notMailFlg = null, WorkflowValue<bool> notTelFlg = null, WorkflowValue<bool> notFaxFlg = null, WorkflowValue<bool> notDmFlg = null, WorkflowValue<bool> competitorFlg = null, WorkflowValue<bool> importantCustomerFlg = null, WorkflowValue<bool> endUserFlg = null, WorkflowValue<bool> storeFlg = null, WorkflowValue<string> customerId = null, WorkflowValue<string> ownerUserId = null)
        {
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(familyName, nameof(familyName), required: true);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(familyNameKana, nameof(familyNameKana), required: false);
            WorkflowValue.Validate(firstNameKana, nameof(firstNameKana), required: false);
            WorkflowValue.Validate(organizationId, nameof(organizationId), required: false);
            WorkflowValue.Validate(post, nameof(post), required: false);
            WorkflowValue.Validate(tel, nameof(tel), required: false);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(fax, nameof(fax), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(mobileTel, nameof(mobileTel), required: false);
            WorkflowValue.Validate(mobileEmail, nameof(mobileEmail), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(leadStatus, nameof(leadStatus), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            WorkflowValue.Validate(leadSource, nameof(leadSource), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(errorMailFlg, nameof(errorMailFlg), required: false);
            WorkflowValue.Validate(errorTelFlg, nameof(errorTelFlg), required: false);
            WorkflowValue.Validate(errorFaxFlg, nameof(errorFaxFlg), required: false);
            WorkflowValue.Validate(errorAddressFlg, nameof(errorAddressFlg), required: false);
            WorkflowValue.Validate(notMailFlg, nameof(notMailFlg), required: false);
            WorkflowValue.Validate(notTelFlg, nameof(notTelFlg), required: false);
            WorkflowValue.Validate(notFaxFlg, nameof(notFaxFlg), required: false);
            WorkflowValue.Validate(notDmFlg, nameof(notDmFlg), required: false);
            WorkflowValue.Validate(competitorFlg, nameof(competitorFlg), required: false);
            WorkflowValue.Validate(importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            WorkflowValue.Validate(endUserFlg, nameof(endUserFlg), required: false);
            WorkflowValue.Validate(storeFlg, nameof(storeFlg), required: false);
            WorkflowValue.Validate(customerId, nameof(customerId), required: false);
            WorkflowValue.Validate(ownerUserId, nameof(ownerUserId), required: false);
            return new DeferredBodyAction<ActionCreateLeadResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
                callPayload.Queries["family_name"] = ExpressionConverter.Convert(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(firstNameKana);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
                if (post != null)
                    callPayload.Queries["post"] = ExpressionConverter.Convert(post);
                if (tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(fax);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (leadStatus != null)
                    callPayload.Queries["lead_status"] = ExpressionConverter.Convert(leadStatus);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(leadSource);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = ExpressionConverter.Convert(errorMailFlg);
                if (errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = ExpressionConverter.Convert(errorTelFlg);
                if (errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = ExpressionConverter.Convert(errorFaxFlg);
                if (errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = ExpressionConverter.Convert(errorAddressFlg);
                if (notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = ExpressionConverter.Convert(notMailFlg);
                if (notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = ExpressionConverter.Convert(notTelFlg);
                if (notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = ExpressionConverter.Convert(notFaxFlg);
                if (notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = ExpressionConverter.Convert(notDmFlg);
                if (competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = ExpressionConverter.Convert(competitorFlg);
                if (importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = ExpressionConverter.Convert(importantCustomerFlg);
                if (endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = ExpressionConverter.Convert(endUserFlg);
                if (storeFlg != null)
                    callPayload.Queries["store_flg"] = ExpressionConverter.Convert(storeFlg);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(customerId);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(ownerUserId);
                return new ApiConnectionAction<ActionCreateLeadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionGetLeads))]
        public IBodyWorkflowAction<ActionGetLeadsResponse> ActionGetLeads([WorkflowExpression] Func<string> searchFamilyName = null, [WorkflowExpression] Func<string> searchFirstName = null, [WorkflowExpression] Func<string> searchClientName = null, [WorkflowExpression] Func<int> searchFromId = null, [WorkflowExpression] Func<int> searchToId = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDateFormatOption = null, [WorkflowExpression] Func<int> searchClientId = null, [WorkflowExpression] Func<string> searchClientNameKana = null, [WorkflowExpression] Func<string> searchClientNameDisp = null, [WorkflowExpression] Func<int> searchOwnerUserId = null, [WorkflowExpression] Func<int> searchRoleId = null, [WorkflowExpression] Func<int> searchOrganizationId = null, [WorkflowExpression] Func<string> searchOrganizationName = null, [WorkflowExpression] Func<string> searchOrganizationAncestryAllName = null, [WorkflowExpression] Func<string> searchPost = null, [WorkflowExpression] Func<string> searchFamilyNameKana = null, [WorkflowExpression] Func<string> searchFirstNameKana = null, [WorkflowExpression] Func<string> searchEmail = null, [WorkflowExpression] Func<string> searchMobileEmail = null, [WorkflowExpression] Func<string> searchTel = null, [WorkflowExpression] Func<string> searchExtension = null, [WorkflowExpression] Func<string> searchFax = null, [WorkflowExpression] Func<string> searchMobileTel = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchPref = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchToDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchFromTradeOn = null, [WorkflowExpression] Func<string> searchToTradeOn = null, [WorkflowExpression] Func<int> searchFromLatitude = null, [WorkflowExpression] Func<int> searchToLatitude = null, [WorkflowExpression] Func<int> searchFromLongitude = null, [WorkflowExpression] Func<int> searchToLongitude = null, [WorkflowExpression] Func<string> searchLatitude = null, [WorkflowExpression] Func<string> searchLongitude = null, [WorkflowExpression] Func<int> searchLeadStatus = null, [WorkflowExpression] Func<int> searchLeadSourceKbnIds = null, [WorkflowExpression] Func<string> searchLeadSource = null, [WorkflowExpression] Func<int> searchImportantCustomerFlg = null, [WorkflowExpression] Func<int> searchEndUserFlg = null, [WorkflowExpression] Func<int> searchStoreFlg = null, [WorkflowExpression] Func<int> searchCompetitorFlg = null, [WorkflowExpression] Func<int> searchErrorMailFlg = null, [WorkflowExpression] Func<int> searchErrorTelFlg = null, [WorkflowExpression] Func<int> searchErrorFaxFlg = null, [WorkflowExpression] Func<int> searchErrorAddressFlg = null, [WorkflowExpression] Func<int> searchNotMailFlg = null, [WorkflowExpression] Func<int> searchNotTelFlg = null, [WorkflowExpression] Func<int> searchNotFaxFlg = null, [WorkflowExpression] Func<int> searchNotDmFlg = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<string> searchCustomerId = null, [WorkflowExpression] Func<string> searchName = null, [WorkflowExpression] Func<string> searchIds = null, [WorkflowExpression] Func<string> searchUserIds = null, [WorkflowExpression] Func<string> searchMultiple = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionGetLeadsResponse> __BuildActionGetLeads(WorkflowValue<string> searchFamilyName = null, WorkflowValue<string> searchFirstName = null, WorkflowValue<string> searchClientName = null, WorkflowValue<int> searchFromId = null, WorkflowValue<int> searchToId = null, WorkflowValue<string> orderKey = null, WorkflowValue<string> orderType = null, WorkflowValue<int> pageDisplayNumber = null, WorkflowValue<int> pageNumber = null, WorkflowValue<int> pageDateFormatOption = null, WorkflowValue<int> searchClientId = null, WorkflowValue<string> searchClientNameKana = null, WorkflowValue<string> searchClientNameDisp = null, WorkflowValue<int> searchOwnerUserId = null, WorkflowValue<int> searchRoleId = null, WorkflowValue<int> searchOrganizationId = null, WorkflowValue<string> searchOrganizationName = null, WorkflowValue<string> searchOrganizationAncestryAllName = null, WorkflowValue<string> searchPost = null, WorkflowValue<string> searchFamilyNameKana = null, WorkflowValue<string> searchFirstNameKana = null, WorkflowValue<string> searchEmail = null, WorkflowValue<string> searchMobileEmail = null, WorkflowValue<string> searchTel = null, WorkflowValue<string> searchExtension = null, WorkflowValue<string> searchFax = null, WorkflowValue<string> searchMobileTel = null, WorkflowValue<string> searchZip = null, WorkflowValue<string> searchPref = null, WorkflowValue<string> searchAddress = null, WorkflowValue<string> searchUrl = null, WorkflowValue<string> searchFromCreatedOn = null, WorkflowValue<string> searchToCreatedOn = null, WorkflowValue<string> searchFromUpdatedOn = null, WorkflowValue<string> searchToUpdatedOn = null, WorkflowValue<string> searchFromDatetimeUpdatedOn = null, WorkflowValue<string> searchToDatetimeUpdatedOn = null, WorkflowValue<string> searchFromTradeOn = null, WorkflowValue<string> searchToTradeOn = null, WorkflowValue<int> searchFromLatitude = null, WorkflowValue<int> searchToLatitude = null, WorkflowValue<int> searchFromLongitude = null, WorkflowValue<int> searchToLongitude = null, WorkflowValue<string> searchLatitude = null, WorkflowValue<string> searchLongitude = null, WorkflowValue<int> searchLeadStatus = null, WorkflowValue<int> searchLeadSourceKbnIds = null, WorkflowValue<string> searchLeadSource = null, WorkflowValue<int> searchImportantCustomerFlg = null, WorkflowValue<int> searchEndUserFlg = null, WorkflowValue<int> searchStoreFlg = null, WorkflowValue<int> searchCompetitorFlg = null, WorkflowValue<int> searchErrorMailFlg = null, WorkflowValue<int> searchErrorTelFlg = null, WorkflowValue<int> searchErrorFaxFlg = null, WorkflowValue<int> searchErrorAddressFlg = null, WorkflowValue<int> searchNotMailFlg = null, WorkflowValue<int> searchNotTelFlg = null, WorkflowValue<int> searchNotFaxFlg = null, WorkflowValue<int> searchNotDmFlg = null, WorkflowValue<string> searchNote = null, WorkflowValue<string> searchCustomerId = null, WorkflowValue<string> searchName = null, WorkflowValue<string> searchIds = null, WorkflowValue<string> searchUserIds = null, WorkflowValue<string> searchMultiple = null)
        {
            WorkflowValue.Validate(searchFamilyName, nameof(searchFamilyName), required: false);
            WorkflowValue.Validate(searchFirstName, nameof(searchFirstName), required: false);
            WorkflowValue.Validate(searchClientName, nameof(searchClientName), required: false);
            WorkflowValue.Validate(searchFromId, nameof(searchFromId), required: false);
            WorkflowValue.Validate(searchToId, nameof(searchToId), required: false);
            WorkflowValue.Validate(orderKey, nameof(orderKey), required: false);
            WorkflowValue.Validate(orderType, nameof(orderType), required: false);
            WorkflowValue.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            WorkflowValue.Validate(pageNumber, nameof(pageNumber), required: false);
            WorkflowValue.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            WorkflowValue.Validate(searchClientId, nameof(searchClientId), required: false);
            WorkflowValue.Validate(searchClientNameKana, nameof(searchClientNameKana), required: false);
            WorkflowValue.Validate(searchClientNameDisp, nameof(searchClientNameDisp), required: false);
            WorkflowValue.Validate(searchOwnerUserId, nameof(searchOwnerUserId), required: false);
            WorkflowValue.Validate(searchRoleId, nameof(searchRoleId), required: false);
            WorkflowValue.Validate(searchOrganizationId, nameof(searchOrganizationId), required: false);
            WorkflowValue.Validate(searchOrganizationName, nameof(searchOrganizationName), required: false);
            WorkflowValue.Validate(searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            WorkflowValue.Validate(searchPost, nameof(searchPost), required: false);
            WorkflowValue.Validate(searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            WorkflowValue.Validate(searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            WorkflowValue.Validate(searchEmail, nameof(searchEmail), required: false);
            WorkflowValue.Validate(searchMobileEmail, nameof(searchMobileEmail), required: false);
            WorkflowValue.Validate(searchTel, nameof(searchTel), required: false);
            WorkflowValue.Validate(searchExtension, nameof(searchExtension), required: false);
            WorkflowValue.Validate(searchFax, nameof(searchFax), required: false);
            WorkflowValue.Validate(searchMobileTel, nameof(searchMobileTel), required: false);
            WorkflowValue.Validate(searchZip, nameof(searchZip), required: false);
            WorkflowValue.Validate(searchPref, nameof(searchPref), required: false);
            WorkflowValue.Validate(searchAddress, nameof(searchAddress), required: false);
            WorkflowValue.Validate(searchUrl, nameof(searchUrl), required: false);
            WorkflowValue.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            WorkflowValue.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            WorkflowValue.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            WorkflowValue.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            WorkflowValue.Validate(searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            WorkflowValue.Validate(searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            WorkflowValue.Validate(searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            WorkflowValue.Validate(searchToTradeOn, nameof(searchToTradeOn), required: false);
            WorkflowValue.Validate(searchFromLatitude, nameof(searchFromLatitude), required: false);
            WorkflowValue.Validate(searchToLatitude, nameof(searchToLatitude), required: false);
            WorkflowValue.Validate(searchFromLongitude, nameof(searchFromLongitude), required: false);
            WorkflowValue.Validate(searchToLongitude, nameof(searchToLongitude), required: false);
            WorkflowValue.Validate(searchLatitude, nameof(searchLatitude), required: false);
            WorkflowValue.Validate(searchLongitude, nameof(searchLongitude), required: false);
            WorkflowValue.Validate(searchLeadStatus, nameof(searchLeadStatus), required: false);
            WorkflowValue.Validate(searchLeadSourceKbnIds, nameof(searchLeadSourceKbnIds), required: false);
            WorkflowValue.Validate(searchLeadSource, nameof(searchLeadSource), required: false);
            WorkflowValue.Validate(searchImportantCustomerFlg, nameof(searchImportantCustomerFlg), required: false);
            WorkflowValue.Validate(searchEndUserFlg, nameof(searchEndUserFlg), required: false);
            WorkflowValue.Validate(searchStoreFlg, nameof(searchStoreFlg), required: false);
            WorkflowValue.Validate(searchCompetitorFlg, nameof(searchCompetitorFlg), required: false);
            WorkflowValue.Validate(searchErrorMailFlg, nameof(searchErrorMailFlg), required: false);
            WorkflowValue.Validate(searchErrorTelFlg, nameof(searchErrorTelFlg), required: false);
            WorkflowValue.Validate(searchErrorFaxFlg, nameof(searchErrorFaxFlg), required: false);
            WorkflowValue.Validate(searchErrorAddressFlg, nameof(searchErrorAddressFlg), required: false);
            WorkflowValue.Validate(searchNotMailFlg, nameof(searchNotMailFlg), required: false);
            WorkflowValue.Validate(searchNotTelFlg, nameof(searchNotTelFlg), required: false);
            WorkflowValue.Validate(searchNotFaxFlg, nameof(searchNotFaxFlg), required: false);
            WorkflowValue.Validate(searchNotDmFlg, nameof(searchNotDmFlg), required: false);
            WorkflowValue.Validate(searchNote, nameof(searchNote), required: false);
            WorkflowValue.Validate(searchCustomerId, nameof(searchCustomerId), required: false);
            WorkflowValue.Validate(searchName, nameof(searchName), required: false);
            WorkflowValue.Validate(searchIds, nameof(searchIds), required: false);
            WorkflowValue.Validate(searchUserIds, nameof(searchUserIds), required: false);
            WorkflowValue.Validate(searchMultiple, nameof(searchMultiple), required: false);
            return new DeferredBodyAction<ActionGetLeadsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = ExpressionConverter.Convert(searchFamilyName);
                if (searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = ExpressionConverter.Convert(searchFirstName);
                if (searchClientName != null)
                    callPayload.Queries["search[client_name]"] = ExpressionConverter.Convert(searchClientName);
                if (searchFromId != null)
                    callPayload.Queries["search[from_id]"] = ExpressionConverter.Convert(searchFromId);
                if (searchToId != null)
                    callPayload.Queries["search[to_id]"] = ExpressionConverter.Convert(searchToId);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(orderType);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(pageDisplayNumber);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(pageNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(pageDateFormatOption);
                if (searchClientId != null)
                    callPayload.Queries["search[client_id]"] = ExpressionConverter.Convert(searchClientId);
                if (searchClientNameKana != null)
                    callPayload.Queries["search[client][name_kana]"] = ExpressionConverter.Convert(searchClientNameKana);
                if (searchClientNameDisp != null)
                    callPayload.Queries["search[client][name_disp]"] = ExpressionConverter.Convert(searchClientNameDisp);
                if (searchOwnerUserId != null)
                    callPayload.Queries["search[owner_user_id]"] = ExpressionConverter.Convert(searchOwnerUserId);
                if (searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = ExpressionConverter.Convert(searchRoleId);
                if (searchOrganizationId != null)
                    callPayload.Queries["search[organization_id]"] = ExpressionConverter.Convert(searchOrganizationId);
                if (searchOrganizationName != null)
                    callPayload.Queries["search[organization_name]"] = ExpressionConverter.Convert(searchOrganizationName);
                if (searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = ExpressionConverter.Convert(searchOrganizationAncestryAllName);
                if (searchPost != null)
                    callPayload.Queries["search[post]"] = ExpressionConverter.Convert(searchPost);
                if (searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = ExpressionConverter.Convert(searchFamilyNameKana);
                if (searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = ExpressionConverter.Convert(searchFirstNameKana);
                if (searchEmail != null)
                    callPayload.Queries["search[email]"] = ExpressionConverter.Convert(searchEmail);
                if (searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = ExpressionConverter.Convert(searchMobileEmail);
                if (searchTel != null)
                    callPayload.Queries["search[tel]"] = ExpressionConverter.Convert(searchTel);
                if (searchExtension != null)
                    callPayload.Queries["search[extension]"] = ExpressionConverter.Convert(searchExtension);
                if (searchFax != null)
                    callPayload.Queries["search[fax]"] = ExpressionConverter.Convert(searchFax);
                if (searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = ExpressionConverter.Convert(searchMobileTel);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(searchZip);
                if (searchPref != null)
                    callPayload.Queries["search[pref]"] = ExpressionConverter.Convert(searchPref);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(searchAddress);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(searchUrl);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(searchToCreatedOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(searchToUpdatedOn);
                if (searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = ExpressionConverter.Convert(searchFromDatetimeUpdatedOn);
                if (searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = ExpressionConverter.Convert(searchToDatetimeUpdatedOn);
                if (searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = ExpressionConverter.Convert(searchFromTradeOn);
                if (searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = ExpressionConverter.Convert(searchToTradeOn);
                if (searchFromLatitude != null)
                    callPayload.Queries["search[from_latitude]"] = ExpressionConverter.Convert(searchFromLatitude);
                if (searchToLatitude != null)
                    callPayload.Queries["search[to_latitude]"] = ExpressionConverter.Convert(searchToLatitude);
                if (searchFromLongitude != null)
                    callPayload.Queries["search[from_longitude]"] = ExpressionConverter.Convert(searchFromLongitude);
                if (searchToLongitude != null)
                    callPayload.Queries["search[to_longitude]"] = ExpressionConverter.Convert(searchToLongitude);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(searchLongitude);
                if (searchLeadStatus != null)
                    callPayload.Queries["search[lead_status]"] = ExpressionConverter.Convert(searchLeadStatus);
                if (searchLeadSourceKbnIds != null)
                    callPayload.Queries["search[lead_source_kbn_ids]"] = ExpressionConverter.Convert(searchLeadSourceKbnIds);
                if (searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = ExpressionConverter.Convert(searchLeadSource);
                if (searchImportantCustomerFlg != null)
                    callPayload.Queries["search[important_customer_flg]"] = ExpressionConverter.Convert(searchImportantCustomerFlg);
                if (searchEndUserFlg != null)
                    callPayload.Queries["search[end_user_flg]"] = ExpressionConverter.Convert(searchEndUserFlg);
                if (searchStoreFlg != null)
                    callPayload.Queries["search[store_flg]"] = ExpressionConverter.Convert(searchStoreFlg);
                if (searchCompetitorFlg != null)
                    callPayload.Queries["search[competitor_flg]"] = ExpressionConverter.Convert(searchCompetitorFlg);
                if (searchErrorMailFlg != null)
                    callPayload.Queries["search[error_mail_flg]"] = ExpressionConverter.Convert(searchErrorMailFlg);
                if (searchErrorTelFlg != null)
                    callPayload.Queries["search[error_tel_flg]"] = ExpressionConverter.Convert(searchErrorTelFlg);
                if (searchErrorFaxFlg != null)
                    callPayload.Queries["search[error_fax_flg]"] = ExpressionConverter.Convert(searchErrorFaxFlg);
                if (searchErrorAddressFlg != null)
                    callPayload.Queries["search[error_address_flg]"] = ExpressionConverter.Convert(searchErrorAddressFlg);
                if (searchNotMailFlg != null)
                    callPayload.Queries["search[not_mail_flg]"] = ExpressionConverter.Convert(searchNotMailFlg);
                if (searchNotTelFlg != null)
                    callPayload.Queries["search[not_tel_flg]"] = ExpressionConverter.Convert(searchNotTelFlg);
                if (searchNotFaxFlg != null)
                    callPayload.Queries["search[not_fax_flg]"] = ExpressionConverter.Convert(searchNotFaxFlg);
                if (searchNotDmFlg != null)
                    callPayload.Queries["search[not_dm_flg]"] = ExpressionConverter.Convert(searchNotDmFlg);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(searchNote);
                if (searchCustomerId != null)
                    callPayload.Queries["search[customer_id]"] = ExpressionConverter.Convert(searchCustomerId);
                if (searchName != null)
                    callPayload.Queries["search[name]"] = ExpressionConverter.Convert(searchName);
                if (searchIds != null)
                    callPayload.Queries["search[ids]"] = ExpressionConverter.Convert(searchIds);
                if (searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = ExpressionConverter.Convert(searchUserIds);
                if (searchMultiple != null)
                    callPayload.Queries["search[multiple]"] = ExpressionConverter.Convert(searchMultiple);
                return new ApiConnectionAction<ActionGetLeadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        [WorkflowExpressionFactory(nameof(__BuildActionUpdateLead))]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> ActionUpdateLead([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> post = null, [WorkflowExpression] Func<string> familyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> leadStatus = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<bool> errorMailFlg = null, [WorkflowExpression] Func<bool> errorTelFlg = null, [WorkflowExpression] Func<bool> errorFaxFlg = null, [WorkflowExpression] Func<bool> errorAddressFlg = null, [WorkflowExpression] Func<bool> notMailFlg = null, [WorkflowExpression] Func<bool> notTelFlg = null, [WorkflowExpression] Func<bool> notFaxFlg = null, [WorkflowExpression] Func<bool> notDmFlg = null, [WorkflowExpression] Func<bool> competitorFlg = null, [WorkflowExpression] Func<bool> importantCustomerFlg = null, [WorkflowExpression] Func<bool> endUserFlg = null, [WorkflowExpression] Func<bool> storeFlg = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> ownerUserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> __BuildActionUpdateLead(WorkflowValue<int> id, WorkflowValue<int> clientId, WorkflowValue<int> organizationId = null, WorkflowValue<string> post = null, WorkflowValue<string> familyName = null, WorkflowValue<string> firstName = null, WorkflowValue<string> familyNameKana = null, WorkflowValue<string> firstNameKana = null, WorkflowValue<string> tel = null, WorkflowValue<int> extension = null, WorkflowValue<string> fax = null, WorkflowValue<string> email = null, WorkflowValue<string> mobileTel = null, WorkflowValue<string> mobileEmail = null, WorkflowValue<string> zip = null, WorkflowValue<int> prefId = null, WorkflowValue<string> address = null, WorkflowValue<string> url = null, WorkflowValue<int> leadStatus = null, WorkflowValue<int> latitude = null, WorkflowValue<int> longitude = null, WorkflowValue<int> leadSourceKbnId = null, WorkflowValue<string> leadSource = null, WorkflowValue<string> note = null, WorkflowValue<bool> errorMailFlg = null, WorkflowValue<bool> errorTelFlg = null, WorkflowValue<bool> errorFaxFlg = null, WorkflowValue<bool> errorAddressFlg = null, WorkflowValue<bool> notMailFlg = null, WorkflowValue<bool> notTelFlg = null, WorkflowValue<bool> notFaxFlg = null, WorkflowValue<bool> notDmFlg = null, WorkflowValue<bool> competitorFlg = null, WorkflowValue<bool> importantCustomerFlg = null, WorkflowValue<bool> endUserFlg = null, WorkflowValue<bool> storeFlg = null, WorkflowValue<string> customerId = null, WorkflowValue<string> ownerUserId = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(organizationId, nameof(organizationId), required: false);
            WorkflowValue.Validate(post, nameof(post), required: false);
            WorkflowValue.Validate(familyName, nameof(familyName), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(familyNameKana, nameof(familyNameKana), required: false);
            WorkflowValue.Validate(firstNameKana, nameof(firstNameKana), required: false);
            WorkflowValue.Validate(tel, nameof(tel), required: false);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(fax, nameof(fax), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(mobileTel, nameof(mobileTel), required: false);
            WorkflowValue.Validate(mobileEmail, nameof(mobileEmail), required: false);
            WorkflowValue.Validate(zip, nameof(zip), required: false);
            WorkflowValue.Validate(prefId, nameof(prefId), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(leadStatus, nameof(leadStatus), required: false);
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            WorkflowValue.Validate(leadSource, nameof(leadSource), required: false);
            WorkflowValue.Validate(note, nameof(note), required: false);
            WorkflowValue.Validate(errorMailFlg, nameof(errorMailFlg), required: false);
            WorkflowValue.Validate(errorTelFlg, nameof(errorTelFlg), required: false);
            WorkflowValue.Validate(errorFaxFlg, nameof(errorFaxFlg), required: false);
            WorkflowValue.Validate(errorAddressFlg, nameof(errorAddressFlg), required: false);
            WorkflowValue.Validate(notMailFlg, nameof(notMailFlg), required: false);
            WorkflowValue.Validate(notTelFlg, nameof(notTelFlg), required: false);
            WorkflowValue.Validate(notFaxFlg, nameof(notFaxFlg), required: false);
            WorkflowValue.Validate(notDmFlg, nameof(notDmFlg), required: false);
            WorkflowValue.Validate(competitorFlg, nameof(competitorFlg), required: false);
            WorkflowValue.Validate(importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            WorkflowValue.Validate(endUserFlg, nameof(endUserFlg), required: false);
            WorkflowValue.Validate(storeFlg, nameof(storeFlg), required: false);
            WorkflowValue.Validate(customerId, nameof(customerId), required: false);
            WorkflowValue.Validate(ownerUserId, nameof(ownerUserId), required: false);
            return new DeferredBodyAction<ActionUpdateLeadResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
                if (post != null)
                    callPayload.Queries["post"] = ExpressionConverter.Convert(post);
                if (familyName != null)
                    callPayload.Queries["family_name"] = ExpressionConverter.Convert(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(fax);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(prefId);
                if (address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(address);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (leadStatus != null)
                    callPayload.Queries["lead_status"] = ExpressionConverter.Convert(leadStatus);
                if (latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(leadSource);
                if (note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(note);
                if (errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = ExpressionConverter.Convert(errorMailFlg);
                if (errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = ExpressionConverter.Convert(errorTelFlg);
                if (errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = ExpressionConverter.Convert(errorFaxFlg);
                if (errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = ExpressionConverter.Convert(errorAddressFlg);
                if (notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = ExpressionConverter.Convert(notMailFlg);
                if (notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = ExpressionConverter.Convert(notTelFlg);
                if (notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = ExpressionConverter.Convert(notFaxFlg);
                if (notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = ExpressionConverter.Convert(notDmFlg);
                if (competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = ExpressionConverter.Convert(competitorFlg);
                if (importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = ExpressionConverter.Convert(importantCustomerFlg);
                if (endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = ExpressionConverter.Convert(endUserFlg);
                if (storeFlg != null)
                    callPayload.Queries["store_flg"] = ExpressionConverter.Convert(storeFlg);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(customerId);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(ownerUserId);
                return new ApiConnectionAction<ActionUpdateLeadResponse>(callPayload);
            });
        }
    }

    public class HotprofileTriggers([ConnectionName] string connectionId)
    {
    }

    public class ActionCreateBusinessCardResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActionGetBusinessCardsResponse
    {
        [JsonProperty("business_cards")]
        public ActionGetBusinessCardsResponseBusinessCardsTypeItem[] BusinessCards { get; set; }

        [JsonProperty("pages")]
        public ActionGetBusinessCardsResponsePagesType Pages { get; set; }
    }

    public class ActionGetBusinessCardsResponseBusinessCardsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("direct_note")]
        public string DirectNote { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("lead_source")]
        public string LeadSource { get; set; }

        [JsonProperty("lead_source_kbn_id")]
        public int LeadSourceKbnId { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("mobile_email")]
        public string MobileEmail { get; set; }

        [JsonProperty("mobile_tel")]
        public string MobileTel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("pref_id")]
        public int PrefId { get; set; }

        [JsonProperty("request_key")]
        public string RequestKey { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("tag_ids")]
        public int[] TagIds { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("trade_on")]
        public string TradeOn { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ActionGetBusinessCardsResponsePagesType
    {
        [JsonProperty("current_number")]
        public int CurrentNumber { get; set; }

        [JsonProperty("display_number")]
        public int DisplayNumber { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_number")]
        public int TotalNumber { get; set; }
    }

    public class ActionUpdateBusinessCardResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActionCreateClientResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActionGetClientsResponse
    {
        [JsonProperty("clients")]
        public ActionGetClientsResponseClientsTypeItem[] Clients { get; set; }

        [JsonProperty("pages")]
        public ActionGetClientsResponsePagesType Pages { get; set; }
    }

    public class ActionGetClientsResponseClientsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("name_disp")]
        public string NameDisp { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("pref")]
        public string Pref { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("business_category_kbn")]
        public string BusinessCategoryKbn { get; set; }

        [JsonProperty("worker_number_kbn")]
        public string WorkerNumberKbn { get; set; }

        [JsonProperty("capital_kbn")]
        public string CapitalKbn { get; set; }

        [JsonProperty("ipo_kbn")]
        public string IpoKbn { get; set; }

        [JsonProperty("sales_last_year")]
        public string SalesLastYear { get; set; }

        [JsonProperty("main_tel")]
        public string MainTel { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mail_domain")]
        public string MailDomain { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_code")]
        public string UserCode { get; set; }

        [JsonProperty("corporate_number")]
        public int CorporateNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }

        [JsonProperty("itemslabel")]
        public string Itemslabel { get; set; }

        [JsonProperty("itemsvalue")]
        public string Itemsvalue { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_number")]
        public int TotalNumber { get; set; }

        [JsonProperty("current_number")]
        public int CurrentNumber { get; set; }

        [JsonProperty("display_number")]
        public int DisplayNumber { get; set; }
    }

    public class ActionGetClientsResponsePagesType
    {
        [JsonProperty("current_number")]
        public int CurrentNumber { get; set; }

        [JsonProperty("display_number")]
        public int DisplayNumber { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_number")]
        public int TotalNumber { get; set; }
    }

    public class ActionUpdateClientResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActionCreateLeadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActionGetLeadsResponse
    {
        [JsonProperty("leads")]
        public ActionGetLeadsResponseLeadsTypeItem[] Leads { get; set; }

        [JsonProperty("pages")]
        public ActionGetLeadsResponsePagesType Pages { get; set; }
    }

    public class ActionGetLeadsResponseLeadsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        [JsonProperty("competitor_flg")]
        public string CompetitorFlg { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("current_number")]
        public int CurrentNumber { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("display_number")]
        public int DisplayNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("end_user_flg")]
        public string EndUserFlg { get; set; }

        [JsonProperty("error_address_flg")]
        public string ErrorAddressFlg { get; set; }

        [JsonProperty("error_fax_flg")]
        public string ErrorFaxFlg { get; set; }

        [JsonProperty("error_mail_flg")]
        public string ErrorMailFlg { get; set; }

        [JsonProperty("error_tel_flg")]
        public string ErrorTelFlg { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("family_name_kana")]
        public string FamilyNameKana { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("important_customer_flg")]
        public string ImportantCustomerFlg { get; set; }

        [JsonProperty("interest_product_type_ids")]
        public int[] InterestProductTypeIds { get; set; }

        [JsonProperty("interest_product_type_names")]
        public string[] InterestProductTypeNames { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }

        [JsonProperty("itemslabel")]
        public string Itemslabel { get; set; }

        [JsonProperty("itemsvalue")]
        public string Itemsvalue { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("lead_source")]
        public string LeadSource { get; set; }

        [JsonProperty("lead_source_kbn_id")]
        public int LeadSourceKbnId { get; set; }

        [JsonProperty("lead_source_kbn_name")]
        public string LeadSourceKbnName { get; set; }

        [JsonProperty("lead_status")]
        public int LeadStatus { get; set; }

        [JsonProperty("lead_status_name")]
        public string LeadStatusName { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("mobile_email")]
        public string MobileEmail { get; set; }

        [JsonProperty("mobile_tel")]
        public string MobileTel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("not_dm_flg")]
        public string NotDmFlg { get; set; }

        [JsonProperty("not_fax_flg")]
        public string NotFaxFlg { get; set; }

        [JsonProperty("not_mail_flg")]
        public string NotMailFlg { get; set; }

        [JsonProperty("not_tel_flg")]
        public string NotTelFlg { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("organization_hierarchy")]
        public string[] OrganizationHierarchy { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationId { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("owner_user_code")]
        public string OwnerUserCode { get; set; }

        [JsonProperty("owner_user_id")]
        public int OwnerUserId { get; set; }

        [JsonProperty("owner_user_name")]
        public string OwnerUserName { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("pref")]
        public string Pref { get; set; }

        [JsonProperty("pref_id")]
        public int PrefId { get; set; }

        [JsonProperty("store_flg")]
        public string StoreFlg { get; set; }

        [JsonProperty("tag_ids")]
        public int[] TagIds { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_number")]
        public int TotalNumber { get; set; }

        [JsonProperty("trade_on")]
        public string TradeOn { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("user_names")]
        public string[] UserNames { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ActionGetLeadsResponsePagesType
    {
        [JsonProperty("current_number")]
        public int CurrentNumber { get; set; }

        [JsonProperty("display_number")]
        public int DisplayNumber { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("total_number")]
        public int TotalNumber { get; set; }
    }

    public class ActionUpdateLeadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hotprofile;

    public partial class WorkflowManagedActions
    {
        public HotprofileActions Hotprofile(string connectionId) => new HotprofileActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HotprofileTriggers Hotprofile(string connectionId) => new HotprofileTriggers(connectionId);
    }
}
