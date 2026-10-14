//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hotprofile
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HotprofileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateBusinessCardResponse> ActionCreateBusinessCard(Expression<Func<int>> clientId, Expression<Func<string>> familyName, Expression<Func<int>> status, Expression<Func<int>> openStatus, Expression<Func<int>> organizationId = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<int>> ownerUserId = null, Expression<Func<string>> ownerUser = null, Expression<Func<string>> tradeOn = null, Expression<Func<string>> note = null, Expression<Func<string>> directNote = null)
        {
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_familyName = familyName == null ? null : WorkflowExpression.Compile(familyName);
            WorkflowExpression.Validate(__workflow_familyName, nameof(familyName), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: true);
            var __workflow_openStatus = openStatus == null ? null : WorkflowExpression.Compile(openStatus);
            WorkflowExpression.Validate(__workflow_openStatus, nameof(openStatus), required: true);
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_familyNameKana = familyNameKana == null ? null : WorkflowExpression.Compile(familyNameKana);
            WorkflowExpression.Validate(__workflow_familyNameKana, nameof(familyNameKana), required: false);
            var __workflow_firstNameKana = firstNameKana == null ? null : WorkflowExpression.Compile(firstNameKana);
            WorkflowExpression.Validate(__workflow_firstNameKana, nameof(firstNameKana), required: false);
            var __workflow_tel = tel == null ? null : WorkflowExpression.Compile(tel);
            WorkflowExpression.Validate(__workflow_tel, nameof(tel), required: false);
            var __workflow_extension = extension == null ? null : WorkflowExpression.Compile(extension);
            WorkflowExpression.Validate(__workflow_extension, nameof(extension), required: false);
            var __workflow_fax = fax == null ? null : WorkflowExpression.Compile(fax);
            WorkflowExpression.Validate(__workflow_fax, nameof(fax), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_mobileTel = mobileTel == null ? null : WorkflowExpression.Compile(mobileTel);
            WorkflowExpression.Validate(__workflow_mobileTel, nameof(mobileTel), required: false);
            var __workflow_mobileEmail = mobileEmail == null ? null : WorkflowExpression.Compile(mobileEmail);
            WorkflowExpression.Validate(__workflow_mobileEmail, nameof(mobileEmail), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_leadSourceKbnId = leadSourceKbnId == null ? null : WorkflowExpression.Compile(leadSourceKbnId);
            WorkflowExpression.Validate(__workflow_leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            var __workflow_leadSource = leadSource == null ? null : WorkflowExpression.Compile(leadSource);
            WorkflowExpression.Validate(__workflow_leadSource, nameof(leadSource), required: false);
            var __workflow_ownerUserId = ownerUserId == null ? null : WorkflowExpression.Compile(ownerUserId);
            WorkflowExpression.Validate(__workflow_ownerUserId, nameof(ownerUserId), required: false);
            var __workflow_ownerUser = ownerUser == null ? null : WorkflowExpression.Compile(ownerUser);
            WorkflowExpression.Validate(__workflow_ownerUser, nameof(ownerUser), required: false);
            var __workflow_tradeOn = tradeOn == null ? null : WorkflowExpression.Compile(tradeOn);
            WorkflowExpression.Validate(__workflow_tradeOn, nameof(tradeOn), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_directNote = directNote == null ? null : WorkflowExpression.Compile(directNote);
            WorkflowExpression.Validate(__workflow_directNote, nameof(directNote), required: false);
            return new DeferredBodyAction<ActionCreateBusinessCardResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                callPayload.Queries["family_name"] = ExpressionConverter.Convert(__workflow_familyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(__workflow_familyNameKana);
                if (__workflow_firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(__workflow_firstNameKana);
                if (__workflow_tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(__workflow_tel);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                if (__workflow_fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(__workflow_fax);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(__workflow_mobileTel);
                if (__workflow_mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(__workflow_mobileEmail);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(__workflow_leadSourceKbnId);
                if (__workflow_leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(__workflow_leadSource);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["open_status"] = ExpressionConverter.Convert(__workflow_openStatus);
                if (__workflow_ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(__workflow_ownerUserId);
                if (__workflow_ownerUser != null)
                    callPayload.Queries["owner_user"] = ExpressionConverter.Convert(__workflow_ownerUser);
                if (__workflow_tradeOn != null)
                    callPayload.Queries["trade_on"] = ExpressionConverter.Convert(__workflow_tradeOn);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_directNote != null)
                    callPayload.Queries["direct_note"] = ExpressionConverter.Convert(__workflow_directNote);
                return new ApiConnectionAction<ActionCreateBusinessCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> ActionGetBusinessCards(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<bool>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchClientName = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<int>> searchRoleId = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchDirectNote = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<string>> searchRequestKey = null, Expression<Func<int>> searchLatitude = null, Expression<Func<int>> searchLongitude = null)
        {
            var __workflow_pageNumber = pageNumber == null ? null : WorkflowExpression.Compile(pageNumber);
            WorkflowExpression.Validate(__workflow_pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageDisplayNumber = pageDisplayNumber == null ? null : WorkflowExpression.Compile(pageDisplayNumber);
            WorkflowExpression.Validate(__workflow_pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            var __workflow_pageDateFormatOption = pageDateFormatOption == null ? null : WorkflowExpression.Compile(pageDateFormatOption);
            WorkflowExpression.Validate(__workflow_pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            var __workflow_orderKey = orderKey == null ? null : WorkflowExpression.Compile(orderKey);
            WorkflowExpression.Validate(__workflow_orderKey, nameof(orderKey), required: false);
            var __workflow_orderType = orderType == null ? null : WorkflowExpression.Compile(orderType);
            WorkflowExpression.Validate(__workflow_orderType, nameof(orderType), required: false);
            var __workflow_searchFamilyName = searchFamilyName == null ? null : WorkflowExpression.Compile(searchFamilyName);
            WorkflowExpression.Validate(__workflow_searchFamilyName, nameof(searchFamilyName), required: false);
            var __workflow_searchFirstName = searchFirstName == null ? null : WorkflowExpression.Compile(searchFirstName);
            WorkflowExpression.Validate(__workflow_searchFirstName, nameof(searchFirstName), required: false);
            var __workflow_searchFamilyNameKana = searchFamilyNameKana == null ? null : WorkflowExpression.Compile(searchFamilyNameKana);
            WorkflowExpression.Validate(__workflow_searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            var __workflow_searchFirstNameKana = searchFirstNameKana == null ? null : WorkflowExpression.Compile(searchFirstNameKana);
            WorkflowExpression.Validate(__workflow_searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            var __workflow_searchClientName = searchClientName == null ? null : WorkflowExpression.Compile(searchClientName);
            WorkflowExpression.Validate(__workflow_searchClientName, nameof(searchClientName), required: false);
            var __workflow_searchFromTradeOn = searchFromTradeOn == null ? null : WorkflowExpression.Compile(searchFromTradeOn);
            WorkflowExpression.Validate(__workflow_searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            var __workflow_searchToTradeOn = searchToTradeOn == null ? null : WorkflowExpression.Compile(searchToTradeOn);
            WorkflowExpression.Validate(__workflow_searchToTradeOn, nameof(searchToTradeOn), required: false);
            var __workflow_searchFromUpdatedOn = searchFromUpdatedOn == null ? null : WorkflowExpression.Compile(searchFromUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            var __workflow_searchToUpdatedOn = searchToUpdatedOn == null ? null : WorkflowExpression.Compile(searchToUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            var __workflow_searchFromCreatedOn = searchFromCreatedOn == null ? null : WorkflowExpression.Compile(searchFromCreatedOn);
            WorkflowExpression.Validate(__workflow_searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            var __workflow_searchToCreatedOn = searchToCreatedOn == null ? null : WorkflowExpression.Compile(searchToCreatedOn);
            WorkflowExpression.Validate(__workflow_searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            var __workflow_searchOrganizationAncestryAllName = searchOrganizationAncestryAllName == null ? null : WorkflowExpression.Compile(searchOrganizationAncestryAllName);
            WorkflowExpression.Validate(__workflow_searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            var __workflow_searchPost = searchPost == null ? null : WorkflowExpression.Compile(searchPost);
            WorkflowExpression.Validate(__workflow_searchPost, nameof(searchPost), required: false);
            var __workflow_searchTel = searchTel == null ? null : WorkflowExpression.Compile(searchTel);
            WorkflowExpression.Validate(__workflow_searchTel, nameof(searchTel), required: false);
            var __workflow_searchFax = searchFax == null ? null : WorkflowExpression.Compile(searchFax);
            WorkflowExpression.Validate(__workflow_searchFax, nameof(searchFax), required: false);
            var __workflow_searchMobileTel = searchMobileTel == null ? null : WorkflowExpression.Compile(searchMobileTel);
            WorkflowExpression.Validate(__workflow_searchMobileTel, nameof(searchMobileTel), required: false);
            var __workflow_searchEmail = searchEmail == null ? null : WorkflowExpression.Compile(searchEmail);
            WorkflowExpression.Validate(__workflow_searchEmail, nameof(searchEmail), required: false);
            var __workflow_searchMobileEmail = searchMobileEmail == null ? null : WorkflowExpression.Compile(searchMobileEmail);
            WorkflowExpression.Validate(__workflow_searchMobileEmail, nameof(searchMobileEmail), required: false);
            var __workflow_searchRoleId = searchRoleId == null ? null : WorkflowExpression.Compile(searchRoleId);
            WorkflowExpression.Validate(__workflow_searchRoleId, nameof(searchRoleId), required: false);
            var __workflow_searchZip = searchZip == null ? null : WorkflowExpression.Compile(searchZip);
            WorkflowExpression.Validate(__workflow_searchZip, nameof(searchZip), required: false);
            var __workflow_searchAddress = searchAddress == null ? null : WorkflowExpression.Compile(searchAddress);
            WorkflowExpression.Validate(__workflow_searchAddress, nameof(searchAddress), required: false);
            var __workflow_searchUrl = searchUrl == null ? null : WorkflowExpression.Compile(searchUrl);
            WorkflowExpression.Validate(__workflow_searchUrl, nameof(searchUrl), required: false);
            var __workflow_searchNote = searchNote == null ? null : WorkflowExpression.Compile(searchNote);
            WorkflowExpression.Validate(__workflow_searchNote, nameof(searchNote), required: false);
            var __workflow_searchDirectNote = searchDirectNote == null ? null : WorkflowExpression.Compile(searchDirectNote);
            WorkflowExpression.Validate(__workflow_searchDirectNote, nameof(searchDirectNote), required: false);
            var __workflow_searchLeadSource = searchLeadSource == null ? null : WorkflowExpression.Compile(searchLeadSource);
            WorkflowExpression.Validate(__workflow_searchLeadSource, nameof(searchLeadSource), required: false);
            var __workflow_searchRequestKey = searchRequestKey == null ? null : WorkflowExpression.Compile(searchRequestKey);
            WorkflowExpression.Validate(__workflow_searchRequestKey, nameof(searchRequestKey), required: false);
            var __workflow_searchLatitude = searchLatitude == null ? null : WorkflowExpression.Compile(searchLatitude);
            WorkflowExpression.Validate(__workflow_searchLatitude, nameof(searchLatitude), required: false);
            var __workflow_searchLongitude = searchLongitude == null ? null : WorkflowExpression.Compile(searchLongitude);
            WorkflowExpression.Validate(__workflow_searchLongitude, nameof(searchLongitude), required: false);
            return new DeferredBodyAction<ActionGetBusinessCardsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/get_entry_list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(__workflow_pageDisplayNumber);
                if (__workflow_pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(__workflow_pageDateFormatOption);
                if (__workflow_orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(__workflow_orderKey);
                if (__workflow_orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(__workflow_orderType);
                if (__workflow_searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = ExpressionConverter.Convert(__workflow_searchFamilyName);
                if (__workflow_searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = ExpressionConverter.Convert(__workflow_searchFirstName);
                if (__workflow_searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = ExpressionConverter.Convert(__workflow_searchFamilyNameKana);
                if (__workflow_searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = ExpressionConverter.Convert(__workflow_searchFirstNameKana);
                if (__workflow_searchClientName != null)
                    callPayload.Queries["search[client_name]"] = ExpressionConverter.Convert(__workflow_searchClientName);
                if (__workflow_searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = ExpressionConverter.Convert(__workflow_searchFromTradeOn);
                if (__workflow_searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = ExpressionConverter.Convert(__workflow_searchToTradeOn);
                if (__workflow_searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(__workflow_searchFromUpdatedOn);
                if (__workflow_searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(__workflow_searchToUpdatedOn);
                if (__workflow_searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(__workflow_searchFromCreatedOn);
                if (__workflow_searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(__workflow_searchToCreatedOn);
                if (__workflow_searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = ExpressionConverter.Convert(__workflow_searchOrganizationAncestryAllName);
                if (__workflow_searchPost != null)
                    callPayload.Queries["search[post]"] = ExpressionConverter.Convert(__workflow_searchPost);
                if (__workflow_searchTel != null)
                    callPayload.Queries["search[tel]"] = ExpressionConverter.Convert(__workflow_searchTel);
                if (__workflow_searchFax != null)
                    callPayload.Queries["search[fax]"] = ExpressionConverter.Convert(__workflow_searchFax);
                if (__workflow_searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = ExpressionConverter.Convert(__workflow_searchMobileTel);
                if (__workflow_searchEmail != null)
                    callPayload.Queries["search[email]"] = ExpressionConverter.Convert(__workflow_searchEmail);
                if (__workflow_searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = ExpressionConverter.Convert(__workflow_searchMobileEmail);
                if (__workflow_searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = ExpressionConverter.Convert(__workflow_searchRoleId);
                if (__workflow_searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(__workflow_searchZip);
                if (__workflow_searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(__workflow_searchAddress);
                if (__workflow_searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(__workflow_searchUrl);
                if (__workflow_searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(__workflow_searchNote);
                if (__workflow_searchDirectNote != null)
                    callPayload.Queries["search[direct_note]"] = ExpressionConverter.Convert(__workflow_searchDirectNote);
                if (__workflow_searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = ExpressionConverter.Convert(__workflow_searchLeadSource);
                if (__workflow_searchRequestKey != null)
                    callPayload.Queries["search[request_key]"] = ExpressionConverter.Convert(__workflow_searchRequestKey);
                if (__workflow_searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(__workflow_searchLatitude);
                if (__workflow_searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(__workflow_searchLongitude);
                return new ApiConnectionAction<ActionGetBusinessCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> ActionUpdateBusinessCard(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<int>> status = null, Expression<Func<int>> openStatus = null, Expression<Func<int>> ownerUserId = null, Expression<Func<string>> ownerUser = null, Expression<Func<string>> tradeOn = null, Expression<Func<string>> note = null, Expression<Func<string>> directNote = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: false);
            var __workflow_familyName = familyName == null ? null : WorkflowExpression.Compile(familyName);
            WorkflowExpression.Validate(__workflow_familyName, nameof(familyName), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_familyNameKana = familyNameKana == null ? null : WorkflowExpression.Compile(familyNameKana);
            WorkflowExpression.Validate(__workflow_familyNameKana, nameof(familyNameKana), required: false);
            var __workflow_firstNameKana = firstNameKana == null ? null : WorkflowExpression.Compile(firstNameKana);
            WorkflowExpression.Validate(__workflow_firstNameKana, nameof(firstNameKana), required: false);
            var __workflow_tel = tel == null ? null : WorkflowExpression.Compile(tel);
            WorkflowExpression.Validate(__workflow_tel, nameof(tel), required: false);
            var __workflow_extension = extension == null ? null : WorkflowExpression.Compile(extension);
            WorkflowExpression.Validate(__workflow_extension, nameof(extension), required: false);
            var __workflow_fax = fax == null ? null : WorkflowExpression.Compile(fax);
            WorkflowExpression.Validate(__workflow_fax, nameof(fax), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_mobileTel = mobileTel == null ? null : WorkflowExpression.Compile(mobileTel);
            WorkflowExpression.Validate(__workflow_mobileTel, nameof(mobileTel), required: false);
            var __workflow_mobileEmail = mobileEmail == null ? null : WorkflowExpression.Compile(mobileEmail);
            WorkflowExpression.Validate(__workflow_mobileEmail, nameof(mobileEmail), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_leadSourceKbnId = leadSourceKbnId == null ? null : WorkflowExpression.Compile(leadSourceKbnId);
            WorkflowExpression.Validate(__workflow_leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            var __workflow_leadSource = leadSource == null ? null : WorkflowExpression.Compile(leadSource);
            WorkflowExpression.Validate(__workflow_leadSource, nameof(leadSource), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_openStatus = openStatus == null ? null : WorkflowExpression.Compile(openStatus);
            WorkflowExpression.Validate(__workflow_openStatus, nameof(openStatus), required: false);
            var __workflow_ownerUserId = ownerUserId == null ? null : WorkflowExpression.Compile(ownerUserId);
            WorkflowExpression.Validate(__workflow_ownerUserId, nameof(ownerUserId), required: false);
            var __workflow_ownerUser = ownerUser == null ? null : WorkflowExpression.Compile(ownerUser);
            WorkflowExpression.Validate(__workflow_ownerUser, nameof(ownerUser), required: false);
            var __workflow_tradeOn = tradeOn == null ? null : WorkflowExpression.Compile(tradeOn);
            WorkflowExpression.Validate(__workflow_tradeOn, nameof(tradeOn), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_directNote = directNote == null ? null : WorkflowExpression.Compile(directNote);
            WorkflowExpression.Validate(__workflow_directNote, nameof(directNote), required: false);
            return new DeferredBodyAction<ActionUpdateBusinessCardResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/business_cards/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                if (__workflow_familyName != null)
                    callPayload.Queries["family_name"] = ExpressionConverter.Convert(__workflow_familyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(__workflow_familyNameKana);
                if (__workflow_firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(__workflow_firstNameKana);
                if (__workflow_tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(__workflow_tel);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                if (__workflow_fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(__workflow_fax);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(__workflow_mobileTel);
                if (__workflow_mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(__workflow_mobileEmail);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(__workflow_leadSourceKbnId);
                if (__workflow_leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(__workflow_leadSource);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_openStatus != null)
                    callPayload.Queries["open_status"] = ExpressionConverter.Convert(__workflow_openStatus);
                if (__workflow_ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(__workflow_ownerUserId);
                if (__workflow_ownerUser != null)
                    callPayload.Queries["owner_user"] = ExpressionConverter.Convert(__workflow_ownerUser);
                if (__workflow_tradeOn != null)
                    callPayload.Queries["trade_on"] = ExpressionConverter.Convert(__workflow_tradeOn);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_directNote != null)
                    callPayload.Queries["direct_note"] = ExpressionConverter.Convert(__workflow_directNote);
                return new ApiConnectionAction<ActionUpdateBusinessCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateClientResponse> ActionCreateClient(Expression<Func<string>> name, Expression<Func<string>> nameDisp, Expression<Func<string>> nameKana = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            var __workflow_nameDisp = nameDisp == null ? null : WorkflowExpression.Compile(nameDisp);
            WorkflowExpression.Validate(__workflow_nameDisp, nameof(nameDisp), required: true);
            var __workflow_nameKana = nameKana == null ? null : WorkflowExpression.Compile(nameKana);
            WorkflowExpression.Validate(__workflow_nameKana, nameof(nameKana), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_businessCategoryKbn = businessCategoryKbn == null ? null : WorkflowExpression.Compile(businessCategoryKbn);
            WorkflowExpression.Validate(__workflow_businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            var __workflow_workerNumberKbn = workerNumberKbn == null ? null : WorkflowExpression.Compile(workerNumberKbn);
            WorkflowExpression.Validate(__workflow_workerNumberKbn, nameof(workerNumberKbn), required: false);
            var __workflow_capitalKbn = capitalKbn == null ? null : WorkflowExpression.Compile(capitalKbn);
            WorkflowExpression.Validate(__workflow_capitalKbn, nameof(capitalKbn), required: false);
            var __workflow_ipoKbn = ipoKbn == null ? null : WorkflowExpression.Compile(ipoKbn);
            WorkflowExpression.Validate(__workflow_ipoKbn, nameof(ipoKbn), required: false);
            var __workflow_salesLastYear = salesLastYear == null ? null : WorkflowExpression.Compile(salesLastYear);
            WorkflowExpression.Validate(__workflow_salesLastYear, nameof(salesLastYear), required: false);
            var __workflow_mainTel = mainTel == null ? null : WorkflowExpression.Compile(mainTel);
            WorkflowExpression.Validate(__workflow_mainTel, nameof(mainTel), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_mailDomain = mailDomain == null ? null : WorkflowExpression.Compile(mailDomain);
            WorkflowExpression.Validate(__workflow_mailDomain, nameof(mailDomain), required: false);
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_nameSub = nameSub == null ? null : WorkflowExpression.Compile(nameSub);
            WorkflowExpression.Validate(__workflow_nameSub, nameof(nameSub), required: false);
            var __workflow_nameKanaSub = nameKanaSub == null ? null : WorkflowExpression.Compile(nameKanaSub);
            WorkflowExpression.Validate(__workflow_nameKanaSub, nameof(nameKanaSub), required: false);
            var __workflow_zipSub = zipSub == null ? null : WorkflowExpression.Compile(zipSub);
            WorkflowExpression.Validate(__workflow_zipSub, nameof(zipSub), required: false);
            var __workflow_addressSub = addressSub == null ? null : WorkflowExpression.Compile(addressSub);
            WorkflowExpression.Validate(__workflow_addressSub, nameof(addressSub), required: false);
            var __workflow_prefSub = prefSub == null ? null : WorkflowExpression.Compile(prefSub);
            WorkflowExpression.Validate(__workflow_prefSub, nameof(prefSub), required: false);
            return new DeferredBodyAction<ActionCreateClientResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_nameKana != null)
                    callPayload.Queries["name_kana"] = ExpressionConverter.Convert(__workflow_nameKana);
                callPayload.Queries["name_disp"] = ExpressionConverter.Convert(__workflow_nameDisp);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = ExpressionConverter.Convert(__workflow_businessCategoryKbn);
                if (__workflow_workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = ExpressionConverter.Convert(__workflow_workerNumberKbn);
                if (__workflow_capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = ExpressionConverter.Convert(__workflow_capitalKbn);
                if (__workflow_ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = ExpressionConverter.Convert(__workflow_ipoKbn);
                if (__workflow_salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = ExpressionConverter.Convert(__workflow_salesLastYear);
                if (__workflow_mainTel != null)
                    callPayload.Queries["main_tel"] = ExpressionConverter.Convert(__workflow_mainTel);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_mailDomain != null)
                    callPayload.Queries["mail_domain"] = ExpressionConverter.Convert(__workflow_mailDomain);
                if (__workflow_userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_nameSub != null)
                    callPayload.Queries["name_sub"] = ExpressionConverter.Convert(__workflow_nameSub);
                if (__workflow_nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = ExpressionConverter.Convert(__workflow_nameKanaSub);
                if (__workflow_zipSub != null)
                    callPayload.Queries["zip_sub"] = ExpressionConverter.Convert(__workflow_zipSub);
                if (__workflow_addressSub != null)
                    callPayload.Queries["address_sub"] = ExpressionConverter.Convert(__workflow_addressSub);
                if (__workflow_prefSub != null)
                    callPayload.Queries["pref_sub"] = ExpressionConverter.Convert(__workflow_prefSub);
                return new ApiConnectionAction<ActionCreateClientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetClientsResponse> ActionGetClients(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchNameKana = null, Expression<Func<string>> searchNameDisp = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<string>> searchCorporateNumber = null, Expression<Func<string>> searchMainTel = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchMailDomain = null, Expression<Func<string>> searchNote = null, Expression<Func<int>> searchUserIds = null, Expression<Func<string>> searchNameSub = null, Expression<Func<string>> searchNameKanaSub = null, Expression<Func<string>> searchZipSub = null, Expression<Func<string>> searchAddressSub = null, Expression<Func<string>> searchPrefSub = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null)
        {
            var __workflow_pageNumber = pageNumber == null ? null : WorkflowExpression.Compile(pageNumber);
            WorkflowExpression.Validate(__workflow_pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageDisplayNumber = pageDisplayNumber == null ? null : WorkflowExpression.Compile(pageDisplayNumber);
            WorkflowExpression.Validate(__workflow_pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            var __workflow_pageDateFormatOption = pageDateFormatOption == null ? null : WorkflowExpression.Compile(pageDateFormatOption);
            WorkflowExpression.Validate(__workflow_pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            var __workflow_orderKey = orderKey == null ? null : WorkflowExpression.Compile(orderKey);
            WorkflowExpression.Validate(__workflow_orderKey, nameof(orderKey), required: false);
            var __workflow_orderType = orderType == null ? null : WorkflowExpression.Compile(orderType);
            WorkflowExpression.Validate(__workflow_orderType, nameof(orderType), required: false);
            var __workflow_searchFromId = searchFromId == null ? null : WorkflowExpression.Compile(searchFromId);
            WorkflowExpression.Validate(__workflow_searchFromId, nameof(searchFromId), required: false);
            var __workflow_searchToId = searchToId == null ? null : WorkflowExpression.Compile(searchToId);
            WorkflowExpression.Validate(__workflow_searchToId, nameof(searchToId), required: false);
            var __workflow_searchName = searchName == null ? null : WorkflowExpression.Compile(searchName);
            WorkflowExpression.Validate(__workflow_searchName, nameof(searchName), required: false);
            var __workflow_searchNameKana = searchNameKana == null ? null : WorkflowExpression.Compile(searchNameKana);
            WorkflowExpression.Validate(__workflow_searchNameKana, nameof(searchNameKana), required: false);
            var __workflow_searchNameDisp = searchNameDisp == null ? null : WorkflowExpression.Compile(searchNameDisp);
            WorkflowExpression.Validate(__workflow_searchNameDisp, nameof(searchNameDisp), required: false);
            var __workflow_searchZip = searchZip == null ? null : WorkflowExpression.Compile(searchZip);
            WorkflowExpression.Validate(__workflow_searchZip, nameof(searchZip), required: false);
            var __workflow_searchAddress = searchAddress == null ? null : WorkflowExpression.Compile(searchAddress);
            WorkflowExpression.Validate(__workflow_searchAddress, nameof(searchAddress), required: false);
            var __workflow_searchLatitude = searchLatitude == null ? null : WorkflowExpression.Compile(searchLatitude);
            WorkflowExpression.Validate(__workflow_searchLatitude, nameof(searchLatitude), required: false);
            var __workflow_searchLongitude = searchLongitude == null ? null : WorkflowExpression.Compile(searchLongitude);
            WorkflowExpression.Validate(__workflow_searchLongitude, nameof(searchLongitude), required: false);
            var __workflow_searchCorporateNumber = searchCorporateNumber == null ? null : WorkflowExpression.Compile(searchCorporateNumber);
            WorkflowExpression.Validate(__workflow_searchCorporateNumber, nameof(searchCorporateNumber), required: false);
            var __workflow_searchMainTel = searchMainTel == null ? null : WorkflowExpression.Compile(searchMainTel);
            WorkflowExpression.Validate(__workflow_searchMainTel, nameof(searchMainTel), required: false);
            var __workflow_searchUrl = searchUrl == null ? null : WorkflowExpression.Compile(searchUrl);
            WorkflowExpression.Validate(__workflow_searchUrl, nameof(searchUrl), required: false);
            var __workflow_searchMailDomain = searchMailDomain == null ? null : WorkflowExpression.Compile(searchMailDomain);
            WorkflowExpression.Validate(__workflow_searchMailDomain, nameof(searchMailDomain), required: false);
            var __workflow_searchNote = searchNote == null ? null : WorkflowExpression.Compile(searchNote);
            WorkflowExpression.Validate(__workflow_searchNote, nameof(searchNote), required: false);
            var __workflow_searchUserIds = searchUserIds == null ? null : WorkflowExpression.Compile(searchUserIds);
            WorkflowExpression.Validate(__workflow_searchUserIds, nameof(searchUserIds), required: false);
            var __workflow_searchNameSub = searchNameSub == null ? null : WorkflowExpression.Compile(searchNameSub);
            WorkflowExpression.Validate(__workflow_searchNameSub, nameof(searchNameSub), required: false);
            var __workflow_searchNameKanaSub = searchNameKanaSub == null ? null : WorkflowExpression.Compile(searchNameKanaSub);
            WorkflowExpression.Validate(__workflow_searchNameKanaSub, nameof(searchNameKanaSub), required: false);
            var __workflow_searchZipSub = searchZipSub == null ? null : WorkflowExpression.Compile(searchZipSub);
            WorkflowExpression.Validate(__workflow_searchZipSub, nameof(searchZipSub), required: false);
            var __workflow_searchAddressSub = searchAddressSub == null ? null : WorkflowExpression.Compile(searchAddressSub);
            WorkflowExpression.Validate(__workflow_searchAddressSub, nameof(searchAddressSub), required: false);
            var __workflow_searchPrefSub = searchPrefSub == null ? null : WorkflowExpression.Compile(searchPrefSub);
            WorkflowExpression.Validate(__workflow_searchPrefSub, nameof(searchPrefSub), required: false);
            var __workflow_searchFromCreatedOn = searchFromCreatedOn == null ? null : WorkflowExpression.Compile(searchFromCreatedOn);
            WorkflowExpression.Validate(__workflow_searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            var __workflow_searchToCreatedOn = searchToCreatedOn == null ? null : WorkflowExpression.Compile(searchToCreatedOn);
            WorkflowExpression.Validate(__workflow_searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            var __workflow_searchFromUpdatedOn = searchFromUpdatedOn == null ? null : WorkflowExpression.Compile(searchFromUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            var __workflow_searchToUpdatedOn = searchToUpdatedOn == null ? null : WorkflowExpression.Compile(searchToUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            var __workflow_searchFromDatetimeUpdatedOn = searchFromDatetimeUpdatedOn == null ? null : WorkflowExpression.Compile(searchFromDatetimeUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            var __workflow_searchToDatetimeUpdatedOn = searchToDatetimeUpdatedOn == null ? null : WorkflowExpression.Compile(searchToDatetimeUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            return new DeferredBodyAction<ActionGetClientsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(__workflow_pageDisplayNumber);
                if (__workflow_pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(__workflow_pageDateFormatOption);
                if (__workflow_orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(__workflow_orderKey);
                if (__workflow_orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(__workflow_orderType);
                if (__workflow_searchFromId != null)
                    callPayload.Queries["search[from_id]"] = ExpressionConverter.Convert(__workflow_searchFromId);
                if (__workflow_searchToId != null)
                    callPayload.Queries["search[to_id]"] = ExpressionConverter.Convert(__workflow_searchToId);
                if (__workflow_searchName != null)
                    callPayload.Queries["search[name]"] = ExpressionConverter.Convert(__workflow_searchName);
                if (__workflow_searchNameKana != null)
                    callPayload.Queries["search[name_kana]"] = ExpressionConverter.Convert(__workflow_searchNameKana);
                if (__workflow_searchNameDisp != null)
                    callPayload.Queries["search[name_disp]"] = ExpressionConverter.Convert(__workflow_searchNameDisp);
                if (__workflow_searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(__workflow_searchZip);
                if (__workflow_searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(__workflow_searchAddress);
                if (__workflow_searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(__workflow_searchLatitude);
                if (__workflow_searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(__workflow_searchLongitude);
                if (__workflow_searchCorporateNumber != null)
                    callPayload.Queries["search[corporate_number]"] = ExpressionConverter.Convert(__workflow_searchCorporateNumber);
                if (__workflow_searchMainTel != null)
                    callPayload.Queries["search[main_tel]"] = ExpressionConverter.Convert(__workflow_searchMainTel);
                if (__workflow_searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(__workflow_searchUrl);
                if (__workflow_searchMailDomain != null)
                    callPayload.Queries["search[mail_domain]"] = ExpressionConverter.Convert(__workflow_searchMailDomain);
                if (__workflow_searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(__workflow_searchNote);
                if (__workflow_searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = ExpressionConverter.Convert(__workflow_searchUserIds);
                if (__workflow_searchNameSub != null)
                    callPayload.Queries["search[name_sub]"] = ExpressionConverter.Convert(__workflow_searchNameSub);
                if (__workflow_searchNameKanaSub != null)
                    callPayload.Queries["search[name_kana_sub]"] = ExpressionConverter.Convert(__workflow_searchNameKanaSub);
                if (__workflow_searchZipSub != null)
                    callPayload.Queries["search[zip_sub]"] = ExpressionConverter.Convert(__workflow_searchZipSub);
                if (__workflow_searchAddressSub != null)
                    callPayload.Queries["search[address_sub]"] = ExpressionConverter.Convert(__workflow_searchAddressSub);
                if (__workflow_searchPrefSub != null)
                    callPayload.Queries["search[pref_sub]"] = ExpressionConverter.Convert(__workflow_searchPrefSub);
                if (__workflow_searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(__workflow_searchFromCreatedOn);
                if (__workflow_searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(__workflow_searchToCreatedOn);
                if (__workflow_searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(__workflow_searchFromUpdatedOn);
                if (__workflow_searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(__workflow_searchToUpdatedOn);
                if (__workflow_searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = ExpressionConverter.Convert(__workflow_searchFromDatetimeUpdatedOn);
                if (__workflow_searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = ExpressionConverter.Convert(__workflow_searchToDatetimeUpdatedOn);
                return new ApiConnectionAction<ActionGetClientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateClientResponse> ActionUpdateClient(Expression<Func<int>> id, Expression<Func<string>> name = null, Expression<Func<string>> nameKana = null, Expression<Func<string>> nameDisp = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_nameKana = nameKana == null ? null : WorkflowExpression.Compile(nameKana);
            WorkflowExpression.Validate(__workflow_nameKana, nameof(nameKana), required: false);
            var __workflow_nameDisp = nameDisp == null ? null : WorkflowExpression.Compile(nameDisp);
            WorkflowExpression.Validate(__workflow_nameDisp, nameof(nameDisp), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_businessCategoryKbn = businessCategoryKbn == null ? null : WorkflowExpression.Compile(businessCategoryKbn);
            WorkflowExpression.Validate(__workflow_businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            var __workflow_workerNumberKbn = workerNumberKbn == null ? null : WorkflowExpression.Compile(workerNumberKbn);
            WorkflowExpression.Validate(__workflow_workerNumberKbn, nameof(workerNumberKbn), required: false);
            var __workflow_capitalKbn = capitalKbn == null ? null : WorkflowExpression.Compile(capitalKbn);
            WorkflowExpression.Validate(__workflow_capitalKbn, nameof(capitalKbn), required: false);
            var __workflow_ipoKbn = ipoKbn == null ? null : WorkflowExpression.Compile(ipoKbn);
            WorkflowExpression.Validate(__workflow_ipoKbn, nameof(ipoKbn), required: false);
            var __workflow_salesLastYear = salesLastYear == null ? null : WorkflowExpression.Compile(salesLastYear);
            WorkflowExpression.Validate(__workflow_salesLastYear, nameof(salesLastYear), required: false);
            var __workflow_mainTel = mainTel == null ? null : WorkflowExpression.Compile(mainTel);
            WorkflowExpression.Validate(__workflow_mainTel, nameof(mainTel), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_mailDomain = mailDomain == null ? null : WorkflowExpression.Compile(mailDomain);
            WorkflowExpression.Validate(__workflow_mailDomain, nameof(mailDomain), required: false);
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_nameSub = nameSub == null ? null : WorkflowExpression.Compile(nameSub);
            WorkflowExpression.Validate(__workflow_nameSub, nameof(nameSub), required: false);
            var __workflow_nameKanaSub = nameKanaSub == null ? null : WorkflowExpression.Compile(nameKanaSub);
            WorkflowExpression.Validate(__workflow_nameKanaSub, nameof(nameKanaSub), required: false);
            var __workflow_zipSub = zipSub == null ? null : WorkflowExpression.Compile(zipSub);
            WorkflowExpression.Validate(__workflow_zipSub, nameof(zipSub), required: false);
            var __workflow_addressSub = addressSub == null ? null : WorkflowExpression.Compile(addressSub);
            WorkflowExpression.Validate(__workflow_addressSub, nameof(addressSub), required: false);
            var __workflow_prefSub = prefSub == null ? null : WorkflowExpression.Compile(prefSub);
            WorkflowExpression.Validate(__workflow_prefSub, nameof(prefSub), required: false);
            return new DeferredBodyAction<ActionUpdateClientResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/clients/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_nameKana != null)
                    callPayload.Queries["name_kana"] = ExpressionConverter.Convert(__workflow_nameKana);
                if (__workflow_nameDisp != null)
                    callPayload.Queries["name_disp"] = ExpressionConverter.Convert(__workflow_nameDisp);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = ExpressionConverter.Convert(__workflow_businessCategoryKbn);
                if (__workflow_workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = ExpressionConverter.Convert(__workflow_workerNumberKbn);
                if (__workflow_capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = ExpressionConverter.Convert(__workflow_capitalKbn);
                if (__workflow_ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = ExpressionConverter.Convert(__workflow_ipoKbn);
                if (__workflow_salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = ExpressionConverter.Convert(__workflow_salesLastYear);
                if (__workflow_mainTel != null)
                    callPayload.Queries["main_tel"] = ExpressionConverter.Convert(__workflow_mainTel);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_mailDomain != null)
                    callPayload.Queries["mail_domain"] = ExpressionConverter.Convert(__workflow_mailDomain);
                if (__workflow_userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_nameSub != null)
                    callPayload.Queries["name_sub"] = ExpressionConverter.Convert(__workflow_nameSub);
                if (__workflow_nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = ExpressionConverter.Convert(__workflow_nameKanaSub);
                if (__workflow_zipSub != null)
                    callPayload.Queries["zip_sub"] = ExpressionConverter.Convert(__workflow_zipSub);
                if (__workflow_addressSub != null)
                    callPayload.Queries["address_sub"] = ExpressionConverter.Convert(__workflow_addressSub);
                if (__workflow_prefSub != null)
                    callPayload.Queries["pref_sub"] = ExpressionConverter.Convert(__workflow_prefSub);
                return new ApiConnectionAction<ActionUpdateClientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateLeadResponse> ActionCreateLead(Expression<Func<int>> clientId, Expression<Func<string>> familyName, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
        {
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_familyName = familyName == null ? null : WorkflowExpression.Compile(familyName);
            WorkflowExpression.Validate(__workflow_familyName, nameof(familyName), required: true);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_familyNameKana = familyNameKana == null ? null : WorkflowExpression.Compile(familyNameKana);
            WorkflowExpression.Validate(__workflow_familyNameKana, nameof(familyNameKana), required: false);
            var __workflow_firstNameKana = firstNameKana == null ? null : WorkflowExpression.Compile(firstNameKana);
            WorkflowExpression.Validate(__workflow_firstNameKana, nameof(firstNameKana), required: false);
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: false);
            var __workflow_post = post == null ? null : WorkflowExpression.Compile(post);
            WorkflowExpression.Validate(__workflow_post, nameof(post), required: false);
            var __workflow_tel = tel == null ? null : WorkflowExpression.Compile(tel);
            WorkflowExpression.Validate(__workflow_tel, nameof(tel), required: false);
            var __workflow_extension = extension == null ? null : WorkflowExpression.Compile(extension);
            WorkflowExpression.Validate(__workflow_extension, nameof(extension), required: false);
            var __workflow_fax = fax == null ? null : WorkflowExpression.Compile(fax);
            WorkflowExpression.Validate(__workflow_fax, nameof(fax), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_mobileTel = mobileTel == null ? null : WorkflowExpression.Compile(mobileTel);
            WorkflowExpression.Validate(__workflow_mobileTel, nameof(mobileTel), required: false);
            var __workflow_mobileEmail = mobileEmail == null ? null : WorkflowExpression.Compile(mobileEmail);
            WorkflowExpression.Validate(__workflow_mobileEmail, nameof(mobileEmail), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_leadStatus = leadStatus == null ? null : WorkflowExpression.Compile(leadStatus);
            WorkflowExpression.Validate(__workflow_leadStatus, nameof(leadStatus), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_leadSourceKbnId = leadSourceKbnId == null ? null : WorkflowExpression.Compile(leadSourceKbnId);
            WorkflowExpression.Validate(__workflow_leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            var __workflow_leadSource = leadSource == null ? null : WorkflowExpression.Compile(leadSource);
            WorkflowExpression.Validate(__workflow_leadSource, nameof(leadSource), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_errorMailFlg = errorMailFlg == null ? null : WorkflowExpression.Compile(errorMailFlg);
            WorkflowExpression.Validate(__workflow_errorMailFlg, nameof(errorMailFlg), required: false);
            var __workflow_errorTelFlg = errorTelFlg == null ? null : WorkflowExpression.Compile(errorTelFlg);
            WorkflowExpression.Validate(__workflow_errorTelFlg, nameof(errorTelFlg), required: false);
            var __workflow_errorFaxFlg = errorFaxFlg == null ? null : WorkflowExpression.Compile(errorFaxFlg);
            WorkflowExpression.Validate(__workflow_errorFaxFlg, nameof(errorFaxFlg), required: false);
            var __workflow_errorAddressFlg = errorAddressFlg == null ? null : WorkflowExpression.Compile(errorAddressFlg);
            WorkflowExpression.Validate(__workflow_errorAddressFlg, nameof(errorAddressFlg), required: false);
            var __workflow_notMailFlg = notMailFlg == null ? null : WorkflowExpression.Compile(notMailFlg);
            WorkflowExpression.Validate(__workflow_notMailFlg, nameof(notMailFlg), required: false);
            var __workflow_notTelFlg = notTelFlg == null ? null : WorkflowExpression.Compile(notTelFlg);
            WorkflowExpression.Validate(__workflow_notTelFlg, nameof(notTelFlg), required: false);
            var __workflow_notFaxFlg = notFaxFlg == null ? null : WorkflowExpression.Compile(notFaxFlg);
            WorkflowExpression.Validate(__workflow_notFaxFlg, nameof(notFaxFlg), required: false);
            var __workflow_notDmFlg = notDmFlg == null ? null : WorkflowExpression.Compile(notDmFlg);
            WorkflowExpression.Validate(__workflow_notDmFlg, nameof(notDmFlg), required: false);
            var __workflow_competitorFlg = competitorFlg == null ? null : WorkflowExpression.Compile(competitorFlg);
            WorkflowExpression.Validate(__workflow_competitorFlg, nameof(competitorFlg), required: false);
            var __workflow_importantCustomerFlg = importantCustomerFlg == null ? null : WorkflowExpression.Compile(importantCustomerFlg);
            WorkflowExpression.Validate(__workflow_importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            var __workflow_endUserFlg = endUserFlg == null ? null : WorkflowExpression.Compile(endUserFlg);
            WorkflowExpression.Validate(__workflow_endUserFlg, nameof(endUserFlg), required: false);
            var __workflow_storeFlg = storeFlg == null ? null : WorkflowExpression.Compile(storeFlg);
            WorkflowExpression.Validate(__workflow_storeFlg, nameof(storeFlg), required: false);
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: false);
            var __workflow_ownerUserId = ownerUserId == null ? null : WorkflowExpression.Compile(ownerUserId);
            WorkflowExpression.Validate(__workflow_ownerUserId, nameof(ownerUserId), required: false);
            return new DeferredBodyAction<ActionCreateLeadResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(__workflow_clientId);
                callPayload.Queries["family_name"] = ExpressionConverter.Convert(__workflow_familyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(__workflow_familyNameKana);
                if (__workflow_firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(__workflow_firstNameKana);
                if (__workflow_organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                if (__workflow_post != null)
                    callPayload.Queries["post"] = ExpressionConverter.Convert(__workflow_post);
                if (__workflow_tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(__workflow_tel);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                if (__workflow_fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(__workflow_fax);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(__workflow_mobileTel);
                if (__workflow_mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(__workflow_mobileEmail);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_leadStatus != null)
                    callPayload.Queries["lead_status"] = ExpressionConverter.Convert(__workflow_leadStatus);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(__workflow_leadSourceKbnId);
                if (__workflow_leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(__workflow_leadSource);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = ExpressionConverter.Convert(__workflow_errorMailFlg);
                if (__workflow_errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = ExpressionConverter.Convert(__workflow_errorTelFlg);
                if (__workflow_errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = ExpressionConverter.Convert(__workflow_errorFaxFlg);
                if (__workflow_errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = ExpressionConverter.Convert(__workflow_errorAddressFlg);
                if (__workflow_notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = ExpressionConverter.Convert(__workflow_notMailFlg);
                if (__workflow_notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = ExpressionConverter.Convert(__workflow_notTelFlg);
                if (__workflow_notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = ExpressionConverter.Convert(__workflow_notFaxFlg);
                if (__workflow_notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = ExpressionConverter.Convert(__workflow_notDmFlg);
                if (__workflow_competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = ExpressionConverter.Convert(__workflow_competitorFlg);
                if (__workflow_importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = ExpressionConverter.Convert(__workflow_importantCustomerFlg);
                if (__workflow_endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = ExpressionConverter.Convert(__workflow_endUserFlg);
                if (__workflow_storeFlg != null)
                    callPayload.Queries["store_flg"] = ExpressionConverter.Convert(__workflow_storeFlg);
                if (__workflow_customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(__workflow_customerId);
                if (__workflow_ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(__workflow_ownerUserId);
                return new ApiConnectionAction<ActionCreateLeadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetLeadsResponse> ActionGetLeads(Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchClientName = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<int>> searchClientId = null, Expression<Func<string>> searchClientNameKana = null, Expression<Func<string>> searchClientNameDisp = null, Expression<Func<int>> searchOwnerUserId = null, Expression<Func<int>> searchRoleId = null, Expression<Func<int>> searchOrganizationId = null, Expression<Func<string>> searchOrganizationName = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchExtension = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchPref = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<int>> searchFromLatitude = null, Expression<Func<int>> searchToLatitude = null, Expression<Func<int>> searchFromLongitude = null, Expression<Func<int>> searchToLongitude = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<int>> searchLeadStatus = null, Expression<Func<int>> searchLeadSourceKbnIds = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<int>> searchImportantCustomerFlg = null, Expression<Func<int>> searchEndUserFlg = null, Expression<Func<int>> searchStoreFlg = null, Expression<Func<int>> searchCompetitorFlg = null, Expression<Func<int>> searchErrorMailFlg = null, Expression<Func<int>> searchErrorTelFlg = null, Expression<Func<int>> searchErrorFaxFlg = null, Expression<Func<int>> searchErrorAddressFlg = null, Expression<Func<int>> searchNotMailFlg = null, Expression<Func<int>> searchNotTelFlg = null, Expression<Func<int>> searchNotFaxFlg = null, Expression<Func<int>> searchNotDmFlg = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchCustomerId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchIds = null, Expression<Func<string>> searchUserIds = null, Expression<Func<string>> searchMultiple = null)
        {
            var __workflow_searchFamilyName = searchFamilyName == null ? null : WorkflowExpression.Compile(searchFamilyName);
            WorkflowExpression.Validate(__workflow_searchFamilyName, nameof(searchFamilyName), required: false);
            var __workflow_searchFirstName = searchFirstName == null ? null : WorkflowExpression.Compile(searchFirstName);
            WorkflowExpression.Validate(__workflow_searchFirstName, nameof(searchFirstName), required: false);
            var __workflow_searchClientName = searchClientName == null ? null : WorkflowExpression.Compile(searchClientName);
            WorkflowExpression.Validate(__workflow_searchClientName, nameof(searchClientName), required: false);
            var __workflow_searchFromId = searchFromId == null ? null : WorkflowExpression.Compile(searchFromId);
            WorkflowExpression.Validate(__workflow_searchFromId, nameof(searchFromId), required: false);
            var __workflow_searchToId = searchToId == null ? null : WorkflowExpression.Compile(searchToId);
            WorkflowExpression.Validate(__workflow_searchToId, nameof(searchToId), required: false);
            var __workflow_orderKey = orderKey == null ? null : WorkflowExpression.Compile(orderKey);
            WorkflowExpression.Validate(__workflow_orderKey, nameof(orderKey), required: false);
            var __workflow_orderType = orderType == null ? null : WorkflowExpression.Compile(orderType);
            WorkflowExpression.Validate(__workflow_orderType, nameof(orderType), required: false);
            var __workflow_pageDisplayNumber = pageDisplayNumber == null ? null : WorkflowExpression.Compile(pageDisplayNumber);
            WorkflowExpression.Validate(__workflow_pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            var __workflow_pageNumber = pageNumber == null ? null : WorkflowExpression.Compile(pageNumber);
            WorkflowExpression.Validate(__workflow_pageNumber, nameof(pageNumber), required: false);
            var __workflow_pageDateFormatOption = pageDateFormatOption == null ? null : WorkflowExpression.Compile(pageDateFormatOption);
            WorkflowExpression.Validate(__workflow_pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            var __workflow_searchClientId = searchClientId == null ? null : WorkflowExpression.Compile(searchClientId);
            WorkflowExpression.Validate(__workflow_searchClientId, nameof(searchClientId), required: false);
            var __workflow_searchClientNameKana = searchClientNameKana == null ? null : WorkflowExpression.Compile(searchClientNameKana);
            WorkflowExpression.Validate(__workflow_searchClientNameKana, nameof(searchClientNameKana), required: false);
            var __workflow_searchClientNameDisp = searchClientNameDisp == null ? null : WorkflowExpression.Compile(searchClientNameDisp);
            WorkflowExpression.Validate(__workflow_searchClientNameDisp, nameof(searchClientNameDisp), required: false);
            var __workflow_searchOwnerUserId = searchOwnerUserId == null ? null : WorkflowExpression.Compile(searchOwnerUserId);
            WorkflowExpression.Validate(__workflow_searchOwnerUserId, nameof(searchOwnerUserId), required: false);
            var __workflow_searchRoleId = searchRoleId == null ? null : WorkflowExpression.Compile(searchRoleId);
            WorkflowExpression.Validate(__workflow_searchRoleId, nameof(searchRoleId), required: false);
            var __workflow_searchOrganizationId = searchOrganizationId == null ? null : WorkflowExpression.Compile(searchOrganizationId);
            WorkflowExpression.Validate(__workflow_searchOrganizationId, nameof(searchOrganizationId), required: false);
            var __workflow_searchOrganizationName = searchOrganizationName == null ? null : WorkflowExpression.Compile(searchOrganizationName);
            WorkflowExpression.Validate(__workflow_searchOrganizationName, nameof(searchOrganizationName), required: false);
            var __workflow_searchOrganizationAncestryAllName = searchOrganizationAncestryAllName == null ? null : WorkflowExpression.Compile(searchOrganizationAncestryAllName);
            WorkflowExpression.Validate(__workflow_searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            var __workflow_searchPost = searchPost == null ? null : WorkflowExpression.Compile(searchPost);
            WorkflowExpression.Validate(__workflow_searchPost, nameof(searchPost), required: false);
            var __workflow_searchFamilyNameKana = searchFamilyNameKana == null ? null : WorkflowExpression.Compile(searchFamilyNameKana);
            WorkflowExpression.Validate(__workflow_searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            var __workflow_searchFirstNameKana = searchFirstNameKana == null ? null : WorkflowExpression.Compile(searchFirstNameKana);
            WorkflowExpression.Validate(__workflow_searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            var __workflow_searchEmail = searchEmail == null ? null : WorkflowExpression.Compile(searchEmail);
            WorkflowExpression.Validate(__workflow_searchEmail, nameof(searchEmail), required: false);
            var __workflow_searchMobileEmail = searchMobileEmail == null ? null : WorkflowExpression.Compile(searchMobileEmail);
            WorkflowExpression.Validate(__workflow_searchMobileEmail, nameof(searchMobileEmail), required: false);
            var __workflow_searchTel = searchTel == null ? null : WorkflowExpression.Compile(searchTel);
            WorkflowExpression.Validate(__workflow_searchTel, nameof(searchTel), required: false);
            var __workflow_searchExtension = searchExtension == null ? null : WorkflowExpression.Compile(searchExtension);
            WorkflowExpression.Validate(__workflow_searchExtension, nameof(searchExtension), required: false);
            var __workflow_searchFax = searchFax == null ? null : WorkflowExpression.Compile(searchFax);
            WorkflowExpression.Validate(__workflow_searchFax, nameof(searchFax), required: false);
            var __workflow_searchMobileTel = searchMobileTel == null ? null : WorkflowExpression.Compile(searchMobileTel);
            WorkflowExpression.Validate(__workflow_searchMobileTel, nameof(searchMobileTel), required: false);
            var __workflow_searchZip = searchZip == null ? null : WorkflowExpression.Compile(searchZip);
            WorkflowExpression.Validate(__workflow_searchZip, nameof(searchZip), required: false);
            var __workflow_searchPref = searchPref == null ? null : WorkflowExpression.Compile(searchPref);
            WorkflowExpression.Validate(__workflow_searchPref, nameof(searchPref), required: false);
            var __workflow_searchAddress = searchAddress == null ? null : WorkflowExpression.Compile(searchAddress);
            WorkflowExpression.Validate(__workflow_searchAddress, nameof(searchAddress), required: false);
            var __workflow_searchUrl = searchUrl == null ? null : WorkflowExpression.Compile(searchUrl);
            WorkflowExpression.Validate(__workflow_searchUrl, nameof(searchUrl), required: false);
            var __workflow_searchFromCreatedOn = searchFromCreatedOn == null ? null : WorkflowExpression.Compile(searchFromCreatedOn);
            WorkflowExpression.Validate(__workflow_searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            var __workflow_searchToCreatedOn = searchToCreatedOn == null ? null : WorkflowExpression.Compile(searchToCreatedOn);
            WorkflowExpression.Validate(__workflow_searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            var __workflow_searchFromUpdatedOn = searchFromUpdatedOn == null ? null : WorkflowExpression.Compile(searchFromUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            var __workflow_searchToUpdatedOn = searchToUpdatedOn == null ? null : WorkflowExpression.Compile(searchToUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            var __workflow_searchFromDatetimeUpdatedOn = searchFromDatetimeUpdatedOn == null ? null : WorkflowExpression.Compile(searchFromDatetimeUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            var __workflow_searchToDatetimeUpdatedOn = searchToDatetimeUpdatedOn == null ? null : WorkflowExpression.Compile(searchToDatetimeUpdatedOn);
            WorkflowExpression.Validate(__workflow_searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            var __workflow_searchFromTradeOn = searchFromTradeOn == null ? null : WorkflowExpression.Compile(searchFromTradeOn);
            WorkflowExpression.Validate(__workflow_searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            var __workflow_searchToTradeOn = searchToTradeOn == null ? null : WorkflowExpression.Compile(searchToTradeOn);
            WorkflowExpression.Validate(__workflow_searchToTradeOn, nameof(searchToTradeOn), required: false);
            var __workflow_searchFromLatitude = searchFromLatitude == null ? null : WorkflowExpression.Compile(searchFromLatitude);
            WorkflowExpression.Validate(__workflow_searchFromLatitude, nameof(searchFromLatitude), required: false);
            var __workflow_searchToLatitude = searchToLatitude == null ? null : WorkflowExpression.Compile(searchToLatitude);
            WorkflowExpression.Validate(__workflow_searchToLatitude, nameof(searchToLatitude), required: false);
            var __workflow_searchFromLongitude = searchFromLongitude == null ? null : WorkflowExpression.Compile(searchFromLongitude);
            WorkflowExpression.Validate(__workflow_searchFromLongitude, nameof(searchFromLongitude), required: false);
            var __workflow_searchToLongitude = searchToLongitude == null ? null : WorkflowExpression.Compile(searchToLongitude);
            WorkflowExpression.Validate(__workflow_searchToLongitude, nameof(searchToLongitude), required: false);
            var __workflow_searchLatitude = searchLatitude == null ? null : WorkflowExpression.Compile(searchLatitude);
            WorkflowExpression.Validate(__workflow_searchLatitude, nameof(searchLatitude), required: false);
            var __workflow_searchLongitude = searchLongitude == null ? null : WorkflowExpression.Compile(searchLongitude);
            WorkflowExpression.Validate(__workflow_searchLongitude, nameof(searchLongitude), required: false);
            var __workflow_searchLeadStatus = searchLeadStatus == null ? null : WorkflowExpression.Compile(searchLeadStatus);
            WorkflowExpression.Validate(__workflow_searchLeadStatus, nameof(searchLeadStatus), required: false);
            var __workflow_searchLeadSourceKbnIds = searchLeadSourceKbnIds == null ? null : WorkflowExpression.Compile(searchLeadSourceKbnIds);
            WorkflowExpression.Validate(__workflow_searchLeadSourceKbnIds, nameof(searchLeadSourceKbnIds), required: false);
            var __workflow_searchLeadSource = searchLeadSource == null ? null : WorkflowExpression.Compile(searchLeadSource);
            WorkflowExpression.Validate(__workflow_searchLeadSource, nameof(searchLeadSource), required: false);
            var __workflow_searchImportantCustomerFlg = searchImportantCustomerFlg == null ? null : WorkflowExpression.Compile(searchImportantCustomerFlg);
            WorkflowExpression.Validate(__workflow_searchImportantCustomerFlg, nameof(searchImportantCustomerFlg), required: false);
            var __workflow_searchEndUserFlg = searchEndUserFlg == null ? null : WorkflowExpression.Compile(searchEndUserFlg);
            WorkflowExpression.Validate(__workflow_searchEndUserFlg, nameof(searchEndUserFlg), required: false);
            var __workflow_searchStoreFlg = searchStoreFlg == null ? null : WorkflowExpression.Compile(searchStoreFlg);
            WorkflowExpression.Validate(__workflow_searchStoreFlg, nameof(searchStoreFlg), required: false);
            var __workflow_searchCompetitorFlg = searchCompetitorFlg == null ? null : WorkflowExpression.Compile(searchCompetitorFlg);
            WorkflowExpression.Validate(__workflow_searchCompetitorFlg, nameof(searchCompetitorFlg), required: false);
            var __workflow_searchErrorMailFlg = searchErrorMailFlg == null ? null : WorkflowExpression.Compile(searchErrorMailFlg);
            WorkflowExpression.Validate(__workflow_searchErrorMailFlg, nameof(searchErrorMailFlg), required: false);
            var __workflow_searchErrorTelFlg = searchErrorTelFlg == null ? null : WorkflowExpression.Compile(searchErrorTelFlg);
            WorkflowExpression.Validate(__workflow_searchErrorTelFlg, nameof(searchErrorTelFlg), required: false);
            var __workflow_searchErrorFaxFlg = searchErrorFaxFlg == null ? null : WorkflowExpression.Compile(searchErrorFaxFlg);
            WorkflowExpression.Validate(__workflow_searchErrorFaxFlg, nameof(searchErrorFaxFlg), required: false);
            var __workflow_searchErrorAddressFlg = searchErrorAddressFlg == null ? null : WorkflowExpression.Compile(searchErrorAddressFlg);
            WorkflowExpression.Validate(__workflow_searchErrorAddressFlg, nameof(searchErrorAddressFlg), required: false);
            var __workflow_searchNotMailFlg = searchNotMailFlg == null ? null : WorkflowExpression.Compile(searchNotMailFlg);
            WorkflowExpression.Validate(__workflow_searchNotMailFlg, nameof(searchNotMailFlg), required: false);
            var __workflow_searchNotTelFlg = searchNotTelFlg == null ? null : WorkflowExpression.Compile(searchNotTelFlg);
            WorkflowExpression.Validate(__workflow_searchNotTelFlg, nameof(searchNotTelFlg), required: false);
            var __workflow_searchNotFaxFlg = searchNotFaxFlg == null ? null : WorkflowExpression.Compile(searchNotFaxFlg);
            WorkflowExpression.Validate(__workflow_searchNotFaxFlg, nameof(searchNotFaxFlg), required: false);
            var __workflow_searchNotDmFlg = searchNotDmFlg == null ? null : WorkflowExpression.Compile(searchNotDmFlg);
            WorkflowExpression.Validate(__workflow_searchNotDmFlg, nameof(searchNotDmFlg), required: false);
            var __workflow_searchNote = searchNote == null ? null : WorkflowExpression.Compile(searchNote);
            WorkflowExpression.Validate(__workflow_searchNote, nameof(searchNote), required: false);
            var __workflow_searchCustomerId = searchCustomerId == null ? null : WorkflowExpression.Compile(searchCustomerId);
            WorkflowExpression.Validate(__workflow_searchCustomerId, nameof(searchCustomerId), required: false);
            var __workflow_searchName = searchName == null ? null : WorkflowExpression.Compile(searchName);
            WorkflowExpression.Validate(__workflow_searchName, nameof(searchName), required: false);
            var __workflow_searchIds = searchIds == null ? null : WorkflowExpression.Compile(searchIds);
            WorkflowExpression.Validate(__workflow_searchIds, nameof(searchIds), required: false);
            var __workflow_searchUserIds = searchUserIds == null ? null : WorkflowExpression.Compile(searchUserIds);
            WorkflowExpression.Validate(__workflow_searchUserIds, nameof(searchUserIds), required: false);
            var __workflow_searchMultiple = searchMultiple == null ? null : WorkflowExpression.Compile(searchMultiple);
            WorkflowExpression.Validate(__workflow_searchMultiple, nameof(searchMultiple), required: false);
            return new DeferredBodyAction<ActionGetLeadsResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = ExpressionConverter.Convert(__workflow_searchFamilyName);
                if (__workflow_searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = ExpressionConverter.Convert(__workflow_searchFirstName);
                if (__workflow_searchClientName != null)
                    callPayload.Queries["search[client_name]"] = ExpressionConverter.Convert(__workflow_searchClientName);
                if (__workflow_searchFromId != null)
                    callPayload.Queries["search[from_id]"] = ExpressionConverter.Convert(__workflow_searchFromId);
                if (__workflow_searchToId != null)
                    callPayload.Queries["search[to_id]"] = ExpressionConverter.Convert(__workflow_searchToId);
                if (__workflow_orderKey != null)
                    callPayload.Queries["order[key]"] = ExpressionConverter.Convert(__workflow_orderKey);
                if (__workflow_orderType != null)
                    callPayload.Queries["order[type]"] = ExpressionConverter.Convert(__workflow_orderType);
                if (__workflow_pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = ExpressionConverter.Convert(__workflow_pageDisplayNumber);
                if (__workflow_pageNumber != null)
                    callPayload.Queries["page[number]"] = ExpressionConverter.Convert(__workflow_pageNumber);
                if (__workflow_pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = ExpressionConverter.Convert(__workflow_pageDateFormatOption);
                if (__workflow_searchClientId != null)
                    callPayload.Queries["search[client_id]"] = ExpressionConverter.Convert(__workflow_searchClientId);
                if (__workflow_searchClientNameKana != null)
                    callPayload.Queries["search[client][name_kana]"] = ExpressionConverter.Convert(__workflow_searchClientNameKana);
                if (__workflow_searchClientNameDisp != null)
                    callPayload.Queries["search[client][name_disp]"] = ExpressionConverter.Convert(__workflow_searchClientNameDisp);
                if (__workflow_searchOwnerUserId != null)
                    callPayload.Queries["search[owner_user_id]"] = ExpressionConverter.Convert(__workflow_searchOwnerUserId);
                if (__workflow_searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = ExpressionConverter.Convert(__workflow_searchRoleId);
                if (__workflow_searchOrganizationId != null)
                    callPayload.Queries["search[organization_id]"] = ExpressionConverter.Convert(__workflow_searchOrganizationId);
                if (__workflow_searchOrganizationName != null)
                    callPayload.Queries["search[organization_name]"] = ExpressionConverter.Convert(__workflow_searchOrganizationName);
                if (__workflow_searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = ExpressionConverter.Convert(__workflow_searchOrganizationAncestryAllName);
                if (__workflow_searchPost != null)
                    callPayload.Queries["search[post]"] = ExpressionConverter.Convert(__workflow_searchPost);
                if (__workflow_searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = ExpressionConverter.Convert(__workflow_searchFamilyNameKana);
                if (__workflow_searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = ExpressionConverter.Convert(__workflow_searchFirstNameKana);
                if (__workflow_searchEmail != null)
                    callPayload.Queries["search[email]"] = ExpressionConverter.Convert(__workflow_searchEmail);
                if (__workflow_searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = ExpressionConverter.Convert(__workflow_searchMobileEmail);
                if (__workflow_searchTel != null)
                    callPayload.Queries["search[tel]"] = ExpressionConverter.Convert(__workflow_searchTel);
                if (__workflow_searchExtension != null)
                    callPayload.Queries["search[extension]"] = ExpressionConverter.Convert(__workflow_searchExtension);
                if (__workflow_searchFax != null)
                    callPayload.Queries["search[fax]"] = ExpressionConverter.Convert(__workflow_searchFax);
                if (__workflow_searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = ExpressionConverter.Convert(__workflow_searchMobileTel);
                if (__workflow_searchZip != null)
                    callPayload.Queries["search[zip]"] = ExpressionConverter.Convert(__workflow_searchZip);
                if (__workflow_searchPref != null)
                    callPayload.Queries["search[pref]"] = ExpressionConverter.Convert(__workflow_searchPref);
                if (__workflow_searchAddress != null)
                    callPayload.Queries["search[address]"] = ExpressionConverter.Convert(__workflow_searchAddress);
                if (__workflow_searchUrl != null)
                    callPayload.Queries["search[url]"] = ExpressionConverter.Convert(__workflow_searchUrl);
                if (__workflow_searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = ExpressionConverter.Convert(__workflow_searchFromCreatedOn);
                if (__workflow_searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = ExpressionConverter.Convert(__workflow_searchToCreatedOn);
                if (__workflow_searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = ExpressionConverter.Convert(__workflow_searchFromUpdatedOn);
                if (__workflow_searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = ExpressionConverter.Convert(__workflow_searchToUpdatedOn);
                if (__workflow_searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = ExpressionConverter.Convert(__workflow_searchFromDatetimeUpdatedOn);
                if (__workflow_searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = ExpressionConverter.Convert(__workflow_searchToDatetimeUpdatedOn);
                if (__workflow_searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = ExpressionConverter.Convert(__workflow_searchFromTradeOn);
                if (__workflow_searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = ExpressionConverter.Convert(__workflow_searchToTradeOn);
                if (__workflow_searchFromLatitude != null)
                    callPayload.Queries["search[from_latitude]"] = ExpressionConverter.Convert(__workflow_searchFromLatitude);
                if (__workflow_searchToLatitude != null)
                    callPayload.Queries["search[to_latitude]"] = ExpressionConverter.Convert(__workflow_searchToLatitude);
                if (__workflow_searchFromLongitude != null)
                    callPayload.Queries["search[from_longitude]"] = ExpressionConverter.Convert(__workflow_searchFromLongitude);
                if (__workflow_searchToLongitude != null)
                    callPayload.Queries["search[to_longitude]"] = ExpressionConverter.Convert(__workflow_searchToLongitude);
                if (__workflow_searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = ExpressionConverter.Convert(__workflow_searchLatitude);
                if (__workflow_searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = ExpressionConverter.Convert(__workflow_searchLongitude);
                if (__workflow_searchLeadStatus != null)
                    callPayload.Queries["search[lead_status]"] = ExpressionConverter.Convert(__workflow_searchLeadStatus);
                if (__workflow_searchLeadSourceKbnIds != null)
                    callPayload.Queries["search[lead_source_kbn_ids]"] = ExpressionConverter.Convert(__workflow_searchLeadSourceKbnIds);
                if (__workflow_searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = ExpressionConverter.Convert(__workflow_searchLeadSource);
                if (__workflow_searchImportantCustomerFlg != null)
                    callPayload.Queries["search[important_customer_flg]"] = ExpressionConverter.Convert(__workflow_searchImportantCustomerFlg);
                if (__workflow_searchEndUserFlg != null)
                    callPayload.Queries["search[end_user_flg]"] = ExpressionConverter.Convert(__workflow_searchEndUserFlg);
                if (__workflow_searchStoreFlg != null)
                    callPayload.Queries["search[store_flg]"] = ExpressionConverter.Convert(__workflow_searchStoreFlg);
                if (__workflow_searchCompetitorFlg != null)
                    callPayload.Queries["search[competitor_flg]"] = ExpressionConverter.Convert(__workflow_searchCompetitorFlg);
                if (__workflow_searchErrorMailFlg != null)
                    callPayload.Queries["search[error_mail_flg]"] = ExpressionConverter.Convert(__workflow_searchErrorMailFlg);
                if (__workflow_searchErrorTelFlg != null)
                    callPayload.Queries["search[error_tel_flg]"] = ExpressionConverter.Convert(__workflow_searchErrorTelFlg);
                if (__workflow_searchErrorFaxFlg != null)
                    callPayload.Queries["search[error_fax_flg]"] = ExpressionConverter.Convert(__workflow_searchErrorFaxFlg);
                if (__workflow_searchErrorAddressFlg != null)
                    callPayload.Queries["search[error_address_flg]"] = ExpressionConverter.Convert(__workflow_searchErrorAddressFlg);
                if (__workflow_searchNotMailFlg != null)
                    callPayload.Queries["search[not_mail_flg]"] = ExpressionConverter.Convert(__workflow_searchNotMailFlg);
                if (__workflow_searchNotTelFlg != null)
                    callPayload.Queries["search[not_tel_flg]"] = ExpressionConverter.Convert(__workflow_searchNotTelFlg);
                if (__workflow_searchNotFaxFlg != null)
                    callPayload.Queries["search[not_fax_flg]"] = ExpressionConverter.Convert(__workflow_searchNotFaxFlg);
                if (__workflow_searchNotDmFlg != null)
                    callPayload.Queries["search[not_dm_flg]"] = ExpressionConverter.Convert(__workflow_searchNotDmFlg);
                if (__workflow_searchNote != null)
                    callPayload.Queries["search[note]"] = ExpressionConverter.Convert(__workflow_searchNote);
                if (__workflow_searchCustomerId != null)
                    callPayload.Queries["search[customer_id]"] = ExpressionConverter.Convert(__workflow_searchCustomerId);
                if (__workflow_searchName != null)
                    callPayload.Queries["search[name]"] = ExpressionConverter.Convert(__workflow_searchName);
                if (__workflow_searchIds != null)
                    callPayload.Queries["search[ids]"] = ExpressionConverter.Convert(__workflow_searchIds);
                if (__workflow_searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = ExpressionConverter.Convert(__workflow_searchUserIds);
                if (__workflow_searchMultiple != null)
                    callPayload.Queries["search[multiple]"] = ExpressionConverter.Convert(__workflow_searchMultiple);
                return new ApiConnectionAction<ActionGetLeadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> ActionUpdateLead(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_clientId = clientId == null ? null : WorkflowExpression.Compile(clientId);
            WorkflowExpression.Validate(__workflow_clientId, nameof(clientId), required: true);
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: false);
            var __workflow_post = post == null ? null : WorkflowExpression.Compile(post);
            WorkflowExpression.Validate(__workflow_post, nameof(post), required: false);
            var __workflow_familyName = familyName == null ? null : WorkflowExpression.Compile(familyName);
            WorkflowExpression.Validate(__workflow_familyName, nameof(familyName), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_familyNameKana = familyNameKana == null ? null : WorkflowExpression.Compile(familyNameKana);
            WorkflowExpression.Validate(__workflow_familyNameKana, nameof(familyNameKana), required: false);
            var __workflow_firstNameKana = firstNameKana == null ? null : WorkflowExpression.Compile(firstNameKana);
            WorkflowExpression.Validate(__workflow_firstNameKana, nameof(firstNameKana), required: false);
            var __workflow_tel = tel == null ? null : WorkflowExpression.Compile(tel);
            WorkflowExpression.Validate(__workflow_tel, nameof(tel), required: false);
            var __workflow_extension = extension == null ? null : WorkflowExpression.Compile(extension);
            WorkflowExpression.Validate(__workflow_extension, nameof(extension), required: false);
            var __workflow_fax = fax == null ? null : WorkflowExpression.Compile(fax);
            WorkflowExpression.Validate(__workflow_fax, nameof(fax), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_mobileTel = mobileTel == null ? null : WorkflowExpression.Compile(mobileTel);
            WorkflowExpression.Validate(__workflow_mobileTel, nameof(mobileTel), required: false);
            var __workflow_mobileEmail = mobileEmail == null ? null : WorkflowExpression.Compile(mobileEmail);
            WorkflowExpression.Validate(__workflow_mobileEmail, nameof(mobileEmail), required: false);
            var __workflow_zip = zip == null ? null : WorkflowExpression.Compile(zip);
            WorkflowExpression.Validate(__workflow_zip, nameof(zip), required: false);
            var __workflow_prefId = prefId == null ? null : WorkflowExpression.Compile(prefId);
            WorkflowExpression.Validate(__workflow_prefId, nameof(prefId), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_leadStatus = leadStatus == null ? null : WorkflowExpression.Compile(leadStatus);
            WorkflowExpression.Validate(__workflow_leadStatus, nameof(leadStatus), required: false);
            var __workflow_latitude = latitude == null ? null : WorkflowExpression.Compile(latitude);
            WorkflowExpression.Validate(__workflow_latitude, nameof(latitude), required: false);
            var __workflow_longitude = longitude == null ? null : WorkflowExpression.Compile(longitude);
            WorkflowExpression.Validate(__workflow_longitude, nameof(longitude), required: false);
            var __workflow_leadSourceKbnId = leadSourceKbnId == null ? null : WorkflowExpression.Compile(leadSourceKbnId);
            WorkflowExpression.Validate(__workflow_leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            var __workflow_leadSource = leadSource == null ? null : WorkflowExpression.Compile(leadSource);
            WorkflowExpression.Validate(__workflow_leadSource, nameof(leadSource), required: false);
            var __workflow_note = note == null ? null : WorkflowExpression.Compile(note);
            WorkflowExpression.Validate(__workflow_note, nameof(note), required: false);
            var __workflow_errorMailFlg = errorMailFlg == null ? null : WorkflowExpression.Compile(errorMailFlg);
            WorkflowExpression.Validate(__workflow_errorMailFlg, nameof(errorMailFlg), required: false);
            var __workflow_errorTelFlg = errorTelFlg == null ? null : WorkflowExpression.Compile(errorTelFlg);
            WorkflowExpression.Validate(__workflow_errorTelFlg, nameof(errorTelFlg), required: false);
            var __workflow_errorFaxFlg = errorFaxFlg == null ? null : WorkflowExpression.Compile(errorFaxFlg);
            WorkflowExpression.Validate(__workflow_errorFaxFlg, nameof(errorFaxFlg), required: false);
            var __workflow_errorAddressFlg = errorAddressFlg == null ? null : WorkflowExpression.Compile(errorAddressFlg);
            WorkflowExpression.Validate(__workflow_errorAddressFlg, nameof(errorAddressFlg), required: false);
            var __workflow_notMailFlg = notMailFlg == null ? null : WorkflowExpression.Compile(notMailFlg);
            WorkflowExpression.Validate(__workflow_notMailFlg, nameof(notMailFlg), required: false);
            var __workflow_notTelFlg = notTelFlg == null ? null : WorkflowExpression.Compile(notTelFlg);
            WorkflowExpression.Validate(__workflow_notTelFlg, nameof(notTelFlg), required: false);
            var __workflow_notFaxFlg = notFaxFlg == null ? null : WorkflowExpression.Compile(notFaxFlg);
            WorkflowExpression.Validate(__workflow_notFaxFlg, nameof(notFaxFlg), required: false);
            var __workflow_notDmFlg = notDmFlg == null ? null : WorkflowExpression.Compile(notDmFlg);
            WorkflowExpression.Validate(__workflow_notDmFlg, nameof(notDmFlg), required: false);
            var __workflow_competitorFlg = competitorFlg == null ? null : WorkflowExpression.Compile(competitorFlg);
            WorkflowExpression.Validate(__workflow_competitorFlg, nameof(competitorFlg), required: false);
            var __workflow_importantCustomerFlg = importantCustomerFlg == null ? null : WorkflowExpression.Compile(importantCustomerFlg);
            WorkflowExpression.Validate(__workflow_importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            var __workflow_endUserFlg = endUserFlg == null ? null : WorkflowExpression.Compile(endUserFlg);
            WorkflowExpression.Validate(__workflow_endUserFlg, nameof(endUserFlg), required: false);
            var __workflow_storeFlg = storeFlg == null ? null : WorkflowExpression.Compile(storeFlg);
            WorkflowExpression.Validate(__workflow_storeFlg, nameof(storeFlg), required: false);
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: false);
            var __workflow_ownerUserId = ownerUserId == null ? null : WorkflowExpression.Compile(ownerUserId);
            WorkflowExpression.Validate(__workflow_ownerUserId, nameof(ownerUserId), required: false);
            return new DeferredBodyAction<ActionUpdateLeadResponse>(() =>
            {
                var apiCallPath = "/rest_api/v1/leads/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_organizationId != null)
                    callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                if (__workflow_post != null)
                    callPayload.Queries["post"] = ExpressionConverter.Convert(__workflow_post);
                if (__workflow_familyName != null)
                    callPayload.Queries["family_name"] = ExpressionConverter.Convert(__workflow_familyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = ExpressionConverter.Convert(__workflow_familyNameKana);
                if (__workflow_firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = ExpressionConverter.Convert(__workflow_firstNameKana);
                if (__workflow_tel != null)
                    callPayload.Queries["tel"] = ExpressionConverter.Convert(__workflow_tel);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                if (__workflow_fax != null)
                    callPayload.Queries["fax"] = ExpressionConverter.Convert(__workflow_fax);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_mobileTel != null)
                    callPayload.Queries["mobile_tel"] = ExpressionConverter.Convert(__workflow_mobileTel);
                if (__workflow_mobileEmail != null)
                    callPayload.Queries["mobile_email"] = ExpressionConverter.Convert(__workflow_mobileEmail);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_prefId != null)
                    callPayload.Queries["pref_id"] = ExpressionConverter.Convert(__workflow_prefId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_leadStatus != null)
                    callPayload.Queries["lead_status"] = ExpressionConverter.Convert(__workflow_leadStatus);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = ExpressionConverter.Convert(__workflow_leadSourceKbnId);
                if (__workflow_leadSource != null)
                    callPayload.Queries["lead_source"] = ExpressionConverter.Convert(__workflow_leadSource);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = ExpressionConverter.Convert(__workflow_errorMailFlg);
                if (__workflow_errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = ExpressionConverter.Convert(__workflow_errorTelFlg);
                if (__workflow_errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = ExpressionConverter.Convert(__workflow_errorFaxFlg);
                if (__workflow_errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = ExpressionConverter.Convert(__workflow_errorAddressFlg);
                if (__workflow_notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = ExpressionConverter.Convert(__workflow_notMailFlg);
                if (__workflow_notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = ExpressionConverter.Convert(__workflow_notTelFlg);
                if (__workflow_notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = ExpressionConverter.Convert(__workflow_notFaxFlg);
                if (__workflow_notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = ExpressionConverter.Convert(__workflow_notDmFlg);
                if (__workflow_competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = ExpressionConverter.Convert(__workflow_competitorFlg);
                if (__workflow_importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = ExpressionConverter.Convert(__workflow_importantCustomerFlg);
                if (__workflow_endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = ExpressionConverter.Convert(__workflow_endUserFlg);
                if (__workflow_storeFlg != null)
                    callPayload.Queries["store_flg"] = ExpressionConverter.Convert(__workflow_storeFlg);
                if (__workflow_customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(__workflow_customerId);
                if (__workflow_ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = ExpressionConverter.Convert(__workflow_ownerUserId);
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
