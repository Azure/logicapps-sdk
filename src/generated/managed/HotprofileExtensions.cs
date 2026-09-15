//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hotprofile
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HotprofileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateBusinessCardResponse> ActionCreateBusinessCard(Expression<Func<int>> clientId, Expression<Func<string>> familyName, Expression<Func<int>> status, Expression<Func<int>> openStatus, Expression<Func<int>> organizationId = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<int>> ownerUserId = null, Expression<Func<string>> ownerUser = null, Expression<Func<string>> tradeOn = null, Expression<Func<string>> note = null, Expression<Func<string>> directNote = null)
        {
            var apiCallPath = "/rest_api/v1/business_cards/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["client_id"] = CSharpExpressionConverter.ConvertO(clientId);
            if (organizationId != null)
                callPayload.Queries["organization_id"] = CSharpExpressionConverter.ConvertO(organizationId);
            callPayload.Queries["family_name"] = CSharpExpressionConverter.ConvertO(familyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (familyNameKana != null)
                callPayload.Queries["family_name_kana"] = CSharpExpressionConverter.ConvertO(familyNameKana);
            if (firstNameKana != null)
                callPayload.Queries["first_name_kana"] = CSharpExpressionConverter.ConvertO(firstNameKana);
            if (tel != null)
                callPayload.Queries["tel"] = CSharpExpressionConverter.ConvertO(tel);
            if (extension != null)
                callPayload.Queries["extension"] = CSharpExpressionConverter.ConvertO(extension);
            if (fax != null)
                callPayload.Queries["fax"] = CSharpExpressionConverter.ConvertO(fax);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (mobileTel != null)
                callPayload.Queries["mobile_tel"] = CSharpExpressionConverter.ConvertO(mobileTel);
            if (mobileEmail != null)
                callPayload.Queries["mobile_email"] = CSharpExpressionConverter.ConvertO(mobileEmail);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (leadSourceKbnId != null)
                callPayload.Queries["lead_source_kbn_id"] = CSharpExpressionConverter.ConvertO(leadSourceKbnId);
            if (leadSource != null)
                callPayload.Queries["lead_source"] = CSharpExpressionConverter.ConvertO(leadSource);
            callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            callPayload.Queries["open_status"] = CSharpExpressionConverter.ConvertO(openStatus);
            if (ownerUserId != null)
                callPayload.Queries["owner_user_id"] = CSharpExpressionConverter.ConvertO(ownerUserId);
            if (ownerUser != null)
                callPayload.Queries["owner_user"] = CSharpExpressionConverter.ConvertO(ownerUser);
            if (tradeOn != null)
                callPayload.Queries["trade_on"] = CSharpExpressionConverter.ConvertO(tradeOn);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (directNote != null)
                callPayload.Queries["direct_note"] = CSharpExpressionConverter.ConvertO(directNote);
            return new ApiConnectionAction<ActionCreateBusinessCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> ActionGetBusinessCards(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<bool>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchClientName = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<int>> searchRoleId = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchDirectNote = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<string>> searchRequestKey = null, Expression<Func<int>> searchLatitude = null, Expression<Func<int>> searchLongitude = null)
        {
            var apiCallPath = "/rest_api/v1/business_cards/get_entry_list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageNumber != null)
                callPayload.Queries["page[number]"] = CSharpExpressionConverter.ConvertO(pageNumber);
            if (pageDisplayNumber != null)
                callPayload.Queries["page[display_number]"] = CSharpExpressionConverter.ConvertO(pageDisplayNumber);
            if (pageDateFormatOption != null)
                callPayload.Queries["page[date_format_option]"] = CSharpExpressionConverter.ConvertO(pageDateFormatOption);
            if (orderKey != null)
                callPayload.Queries["order[key]"] = CSharpExpressionConverter.ConvertO(orderKey);
            if (orderType != null)
                callPayload.Queries["order[type]"] = CSharpExpressionConverter.ConvertO(orderType);
            if (searchFamilyName != null)
                callPayload.Queries["search[family_name]"] = CSharpExpressionConverter.ConvertO(searchFamilyName);
            if (searchFirstName != null)
                callPayload.Queries["search[first_name]"] = CSharpExpressionConverter.ConvertO(searchFirstName);
            if (searchFamilyNameKana != null)
                callPayload.Queries["search[family_name_kana]"] = CSharpExpressionConverter.ConvertO(searchFamilyNameKana);
            if (searchFirstNameKana != null)
                callPayload.Queries["search[first_name_kana]"] = CSharpExpressionConverter.ConvertO(searchFirstNameKana);
            if (searchClientName != null)
                callPayload.Queries["search[client_name]"] = CSharpExpressionConverter.ConvertO(searchClientName);
            if (searchFromTradeOn != null)
                callPayload.Queries["search[from_trade_on]"] = CSharpExpressionConverter.ConvertO(searchFromTradeOn);
            if (searchToTradeOn != null)
                callPayload.Queries["search[to_trade_on]"] = CSharpExpressionConverter.ConvertO(searchToTradeOn);
            if (searchFromUpdatedOn != null)
                callPayload.Queries["search[from_updated_on]"] = CSharpExpressionConverter.ConvertO(searchFromUpdatedOn);
            if (searchToUpdatedOn != null)
                callPayload.Queries["search[to_updated_on]"] = CSharpExpressionConverter.ConvertO(searchToUpdatedOn);
            if (searchFromCreatedOn != null)
                callPayload.Queries["search[from_created_on]"] = CSharpExpressionConverter.ConvertO(searchFromCreatedOn);
            if (searchToCreatedOn != null)
                callPayload.Queries["search[to_created_on]"] = CSharpExpressionConverter.ConvertO(searchToCreatedOn);
            if (searchOrganizationAncestryAllName != null)
                callPayload.Queries["search[organization_ancestry_all_name]"] = CSharpExpressionConverter.ConvertO(searchOrganizationAncestryAllName);
            if (searchPost != null)
                callPayload.Queries["search[post]"] = CSharpExpressionConverter.ConvertO(searchPost);
            if (searchTel != null)
                callPayload.Queries["search[tel]"] = CSharpExpressionConverter.ConvertO(searchTel);
            if (searchFax != null)
                callPayload.Queries["search[fax]"] = CSharpExpressionConverter.ConvertO(searchFax);
            if (searchMobileTel != null)
                callPayload.Queries["search[mobile_tel]"] = CSharpExpressionConverter.ConvertO(searchMobileTel);
            if (searchEmail != null)
                callPayload.Queries["search[email]"] = CSharpExpressionConverter.ConvertO(searchEmail);
            if (searchMobileEmail != null)
                callPayload.Queries["search[mobile_email]"] = CSharpExpressionConverter.ConvertO(searchMobileEmail);
            if (searchRoleId != null)
                callPayload.Queries["search[role_id]"] = CSharpExpressionConverter.ConvertO(searchRoleId);
            if (searchZip != null)
                callPayload.Queries["search[zip]"] = CSharpExpressionConverter.ConvertO(searchZip);
            if (searchAddress != null)
                callPayload.Queries["search[address]"] = CSharpExpressionConverter.ConvertO(searchAddress);
            if (searchUrl != null)
                callPayload.Queries["search[url]"] = CSharpExpressionConverter.ConvertO(searchUrl);
            if (searchNote != null)
                callPayload.Queries["search[note]"] = CSharpExpressionConverter.ConvertO(searchNote);
            if (searchDirectNote != null)
                callPayload.Queries["search[direct_note]"] = CSharpExpressionConverter.ConvertO(searchDirectNote);
            if (searchLeadSource != null)
                callPayload.Queries["search[lead_source]"] = CSharpExpressionConverter.ConvertO(searchLeadSource);
            if (searchRequestKey != null)
                callPayload.Queries["search[request_key]"] = CSharpExpressionConverter.ConvertO(searchRequestKey);
            if (searchLatitude != null)
                callPayload.Queries["search[latitude]"] = CSharpExpressionConverter.ConvertO(searchLatitude);
            if (searchLongitude != null)
                callPayload.Queries["search[longitude]"] = CSharpExpressionConverter.ConvertO(searchLongitude);
            return new ApiConnectionAction<ActionGetBusinessCardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> ActionUpdateBusinessCard(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<int>> status = null, Expression<Func<int>> openStatus = null, Expression<Func<int>> ownerUserId = null, Expression<Func<string>> ownerUser = null, Expression<Func<string>> tradeOn = null, Expression<Func<string>> note = null, Expression<Func<string>> directNote = null)
        {
            var apiCallPath = "/rest_api/v1/business_cards/update";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["client_id"] = CSharpExpressionConverter.ConvertO(clientId);
            if (organizationId != null)
                callPayload.Queries["organization_id"] = CSharpExpressionConverter.ConvertO(organizationId);
            if (familyName != null)
                callPayload.Queries["family_name"] = CSharpExpressionConverter.ConvertO(familyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (familyNameKana != null)
                callPayload.Queries["family_name_kana"] = CSharpExpressionConverter.ConvertO(familyNameKana);
            if (firstNameKana != null)
                callPayload.Queries["first_name_kana"] = CSharpExpressionConverter.ConvertO(firstNameKana);
            if (tel != null)
                callPayload.Queries["tel"] = CSharpExpressionConverter.ConvertO(tel);
            if (extension != null)
                callPayload.Queries["extension"] = CSharpExpressionConverter.ConvertO(extension);
            if (fax != null)
                callPayload.Queries["fax"] = CSharpExpressionConverter.ConvertO(fax);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (mobileTel != null)
                callPayload.Queries["mobile_tel"] = CSharpExpressionConverter.ConvertO(mobileTel);
            if (mobileEmail != null)
                callPayload.Queries["mobile_email"] = CSharpExpressionConverter.ConvertO(mobileEmail);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (leadSourceKbnId != null)
                callPayload.Queries["lead_source_kbn_id"] = CSharpExpressionConverter.ConvertO(leadSourceKbnId);
            if (leadSource != null)
                callPayload.Queries["lead_source"] = CSharpExpressionConverter.ConvertO(leadSource);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            if (openStatus != null)
                callPayload.Queries["open_status"] = CSharpExpressionConverter.ConvertO(openStatus);
            if (ownerUserId != null)
                callPayload.Queries["owner_user_id"] = CSharpExpressionConverter.ConvertO(ownerUserId);
            if (ownerUser != null)
                callPayload.Queries["owner_user"] = CSharpExpressionConverter.ConvertO(ownerUser);
            if (tradeOn != null)
                callPayload.Queries["trade_on"] = CSharpExpressionConverter.ConvertO(tradeOn);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (directNote != null)
                callPayload.Queries["direct_note"] = CSharpExpressionConverter.ConvertO(directNote);
            return new ApiConnectionAction<ActionUpdateBusinessCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateClientResponse> ActionCreateClient(Expression<Func<string>> name, Expression<Func<string>> nameDisp, Expression<Func<string>> nameKana = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
        {
            var apiCallPath = "/rest_api/v1/clients/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (nameKana != null)
                callPayload.Queries["name_kana"] = CSharpExpressionConverter.ConvertO(nameKana);
            callPayload.Queries["name_disp"] = CSharpExpressionConverter.ConvertO(nameDisp);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (businessCategoryKbn != null)
                callPayload.Queries["business_category_kbn"] = CSharpExpressionConverter.ConvertO(businessCategoryKbn);
            if (workerNumberKbn != null)
                callPayload.Queries["worker_number_kbn"] = CSharpExpressionConverter.ConvertO(workerNumberKbn);
            if (capitalKbn != null)
                callPayload.Queries["capital_kbn"] = CSharpExpressionConverter.ConvertO(capitalKbn);
            if (ipoKbn != null)
                callPayload.Queries["ipo_kbn"] = CSharpExpressionConverter.ConvertO(ipoKbn);
            if (salesLastYear != null)
                callPayload.Queries["sales_last_year"] = CSharpExpressionConverter.ConvertO(salesLastYear);
            if (mainTel != null)
                callPayload.Queries["main_tel"] = CSharpExpressionConverter.ConvertO(mainTel);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (mailDomain != null)
                callPayload.Queries["mail_domain"] = CSharpExpressionConverter.ConvertO(mailDomain);
            if (userId != null)
                callPayload.Queries["user_id"] = CSharpExpressionConverter.ConvertO(userId);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (nameSub != null)
                callPayload.Queries["name_sub"] = CSharpExpressionConverter.ConvertO(nameSub);
            if (nameKanaSub != null)
                callPayload.Queries["name_kana_sub"] = CSharpExpressionConverter.ConvertO(nameKanaSub);
            if (zipSub != null)
                callPayload.Queries["zip_sub"] = CSharpExpressionConverter.ConvertO(zipSub);
            if (addressSub != null)
                callPayload.Queries["address_sub"] = CSharpExpressionConverter.ConvertO(addressSub);
            if (prefSub != null)
                callPayload.Queries["pref_sub"] = CSharpExpressionConverter.ConvertO(prefSub);
            return new ApiConnectionAction<ActionCreateClientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetClientsResponse> ActionGetClients(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchNameKana = null, Expression<Func<string>> searchNameDisp = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<string>> searchCorporateNumber = null, Expression<Func<string>> searchMainTel = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchMailDomain = null, Expression<Func<string>> searchNote = null, Expression<Func<int>> searchUserIds = null, Expression<Func<string>> searchNameSub = null, Expression<Func<string>> searchNameKanaSub = null, Expression<Func<string>> searchZipSub = null, Expression<Func<string>> searchAddressSub = null, Expression<Func<string>> searchPrefSub = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null)
        {
            var apiCallPath = "/rest_api/v1/clients/get_entry_list_flow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageNumber != null)
                callPayload.Queries["page[number]"] = CSharpExpressionConverter.ConvertO(pageNumber);
            if (pageDisplayNumber != null)
                callPayload.Queries["page[display_number]"] = CSharpExpressionConverter.ConvertO(pageDisplayNumber);
            if (pageDateFormatOption != null)
                callPayload.Queries["page[date_format_option]"] = CSharpExpressionConverter.ConvertO(pageDateFormatOption);
            if (orderKey != null)
                callPayload.Queries["order[key]"] = CSharpExpressionConverter.ConvertO(orderKey);
            if (orderType != null)
                callPayload.Queries["order[type]"] = CSharpExpressionConverter.ConvertO(orderType);
            if (searchFromId != null)
                callPayload.Queries["search[from_id]"] = CSharpExpressionConverter.ConvertO(searchFromId);
            if (searchToId != null)
                callPayload.Queries["search[to_id]"] = CSharpExpressionConverter.ConvertO(searchToId);
            if (searchName != null)
                callPayload.Queries["search[name]"] = CSharpExpressionConverter.ConvertO(searchName);
            if (searchNameKana != null)
                callPayload.Queries["search[name_kana]"] = CSharpExpressionConverter.ConvertO(searchNameKana);
            if (searchNameDisp != null)
                callPayload.Queries["search[name_disp]"] = CSharpExpressionConverter.ConvertO(searchNameDisp);
            if (searchZip != null)
                callPayload.Queries["search[zip]"] = CSharpExpressionConverter.ConvertO(searchZip);
            if (searchAddress != null)
                callPayload.Queries["search[address]"] = CSharpExpressionConverter.ConvertO(searchAddress);
            if (searchLatitude != null)
                callPayload.Queries["search[latitude]"] = CSharpExpressionConverter.ConvertO(searchLatitude);
            if (searchLongitude != null)
                callPayload.Queries["search[longitude]"] = CSharpExpressionConverter.ConvertO(searchLongitude);
            if (searchCorporateNumber != null)
                callPayload.Queries["search[corporate_number]"] = CSharpExpressionConverter.ConvertO(searchCorporateNumber);
            if (searchMainTel != null)
                callPayload.Queries["search[main_tel]"] = CSharpExpressionConverter.ConvertO(searchMainTel);
            if (searchUrl != null)
                callPayload.Queries["search[url]"] = CSharpExpressionConverter.ConvertO(searchUrl);
            if (searchMailDomain != null)
                callPayload.Queries["search[mail_domain]"] = CSharpExpressionConverter.ConvertO(searchMailDomain);
            if (searchNote != null)
                callPayload.Queries["search[note]"] = CSharpExpressionConverter.ConvertO(searchNote);
            if (searchUserIds != null)
                callPayload.Queries["search[user_ids]"] = CSharpExpressionConverter.ConvertO(searchUserIds);
            if (searchNameSub != null)
                callPayload.Queries["search[name_sub]"] = CSharpExpressionConverter.ConvertO(searchNameSub);
            if (searchNameKanaSub != null)
                callPayload.Queries["search[name_kana_sub]"] = CSharpExpressionConverter.ConvertO(searchNameKanaSub);
            if (searchZipSub != null)
                callPayload.Queries["search[zip_sub]"] = CSharpExpressionConverter.ConvertO(searchZipSub);
            if (searchAddressSub != null)
                callPayload.Queries["search[address_sub]"] = CSharpExpressionConverter.ConvertO(searchAddressSub);
            if (searchPrefSub != null)
                callPayload.Queries["search[pref_sub]"] = CSharpExpressionConverter.ConvertO(searchPrefSub);
            if (searchFromCreatedOn != null)
                callPayload.Queries["search[from_created_on]"] = CSharpExpressionConverter.ConvertO(searchFromCreatedOn);
            if (searchToCreatedOn != null)
                callPayload.Queries["search[to_created_on]"] = CSharpExpressionConverter.ConvertO(searchToCreatedOn);
            if (searchFromUpdatedOn != null)
                callPayload.Queries["search[from_updated_on]"] = CSharpExpressionConverter.ConvertO(searchFromUpdatedOn);
            if (searchToUpdatedOn != null)
                callPayload.Queries["search[to_updated_on]"] = CSharpExpressionConverter.ConvertO(searchToUpdatedOn);
            if (searchFromDatetimeUpdatedOn != null)
                callPayload.Queries["search[from_datetime_updated_on]"] = CSharpExpressionConverter.ConvertO(searchFromDatetimeUpdatedOn);
            if (searchToDatetimeUpdatedOn != null)
                callPayload.Queries["search[to_datetime_updated_on]"] = CSharpExpressionConverter.ConvertO(searchToDatetimeUpdatedOn);
            return new ApiConnectionAction<ActionGetClientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateClientResponse> ActionUpdateClient(Expression<Func<int>> id, Expression<Func<string>> name = null, Expression<Func<string>> nameKana = null, Expression<Func<string>> nameDisp = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
        {
            var apiCallPath = "/rest_api/v1/clients/update";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (nameKana != null)
                callPayload.Queries["name_kana"] = CSharpExpressionConverter.ConvertO(nameKana);
            if (nameDisp != null)
                callPayload.Queries["name_disp"] = CSharpExpressionConverter.ConvertO(nameDisp);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (businessCategoryKbn != null)
                callPayload.Queries["business_category_kbn"] = CSharpExpressionConverter.ConvertO(businessCategoryKbn);
            if (workerNumberKbn != null)
                callPayload.Queries["worker_number_kbn"] = CSharpExpressionConverter.ConvertO(workerNumberKbn);
            if (capitalKbn != null)
                callPayload.Queries["capital_kbn"] = CSharpExpressionConverter.ConvertO(capitalKbn);
            if (ipoKbn != null)
                callPayload.Queries["ipo_kbn"] = CSharpExpressionConverter.ConvertO(ipoKbn);
            if (salesLastYear != null)
                callPayload.Queries["sales_last_year"] = CSharpExpressionConverter.ConvertO(salesLastYear);
            if (mainTel != null)
                callPayload.Queries["main_tel"] = CSharpExpressionConverter.ConvertO(mainTel);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (mailDomain != null)
                callPayload.Queries["mail_domain"] = CSharpExpressionConverter.ConvertO(mailDomain);
            if (userId != null)
                callPayload.Queries["user_id"] = CSharpExpressionConverter.ConvertO(userId);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (nameSub != null)
                callPayload.Queries["name_sub"] = CSharpExpressionConverter.ConvertO(nameSub);
            if (nameKanaSub != null)
                callPayload.Queries["name_kana_sub"] = CSharpExpressionConverter.ConvertO(nameKanaSub);
            if (zipSub != null)
                callPayload.Queries["zip_sub"] = CSharpExpressionConverter.ConvertO(zipSub);
            if (addressSub != null)
                callPayload.Queries["address_sub"] = CSharpExpressionConverter.ConvertO(addressSub);
            if (prefSub != null)
                callPayload.Queries["pref_sub"] = CSharpExpressionConverter.ConvertO(prefSub);
            return new ApiConnectionAction<ActionUpdateClientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateLeadResponse> ActionCreateLead(Expression<Func<int>> clientId, Expression<Func<string>> familyName, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
        {
            var apiCallPath = "/rest_api/v1/leads/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["client_id"] = CSharpExpressionConverter.ConvertO(clientId);
            callPayload.Queries["family_name"] = CSharpExpressionConverter.ConvertO(familyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (familyNameKana != null)
                callPayload.Queries["family_name_kana"] = CSharpExpressionConverter.ConvertO(familyNameKana);
            if (firstNameKana != null)
                callPayload.Queries["first_name_kana"] = CSharpExpressionConverter.ConvertO(firstNameKana);
            if (organizationId != null)
                callPayload.Queries["organization_id"] = CSharpExpressionConverter.ConvertO(organizationId);
            if (post != null)
                callPayload.Queries["post"] = CSharpExpressionConverter.ConvertO(post);
            if (tel != null)
                callPayload.Queries["tel"] = CSharpExpressionConverter.ConvertO(tel);
            if (extension != null)
                callPayload.Queries["extension"] = CSharpExpressionConverter.ConvertO(extension);
            if (fax != null)
                callPayload.Queries["fax"] = CSharpExpressionConverter.ConvertO(fax);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (mobileTel != null)
                callPayload.Queries["mobile_tel"] = CSharpExpressionConverter.ConvertO(mobileTel);
            if (mobileEmail != null)
                callPayload.Queries["mobile_email"] = CSharpExpressionConverter.ConvertO(mobileEmail);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (leadStatus != null)
                callPayload.Queries["lead_status"] = CSharpExpressionConverter.ConvertO(leadStatus);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (leadSourceKbnId != null)
                callPayload.Queries["lead_source_kbn_id"] = CSharpExpressionConverter.ConvertO(leadSourceKbnId);
            if (leadSource != null)
                callPayload.Queries["lead_source"] = CSharpExpressionConverter.ConvertO(leadSource);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (errorMailFlg != null)
                callPayload.Queries["error_mail_flg"] = CSharpExpressionConverter.ConvertO(errorMailFlg);
            if (errorTelFlg != null)
                callPayload.Queries["error_tel_flg"] = CSharpExpressionConverter.ConvertO(errorTelFlg);
            if (errorFaxFlg != null)
                callPayload.Queries["error_fax_flg"] = CSharpExpressionConverter.ConvertO(errorFaxFlg);
            if (errorAddressFlg != null)
                callPayload.Queries["error_address_flg"] = CSharpExpressionConverter.ConvertO(errorAddressFlg);
            if (notMailFlg != null)
                callPayload.Queries["not_mail_flg"] = CSharpExpressionConverter.ConvertO(notMailFlg);
            if (notTelFlg != null)
                callPayload.Queries["not_tel_flg"] = CSharpExpressionConverter.ConvertO(notTelFlg);
            if (notFaxFlg != null)
                callPayload.Queries["not_fax_flg"] = CSharpExpressionConverter.ConvertO(notFaxFlg);
            if (notDmFlg != null)
                callPayload.Queries["not_dm_flg"] = CSharpExpressionConverter.ConvertO(notDmFlg);
            if (competitorFlg != null)
                callPayload.Queries["competitor_flg"] = CSharpExpressionConverter.ConvertO(competitorFlg);
            if (importantCustomerFlg != null)
                callPayload.Queries["important_customer_flg"] = CSharpExpressionConverter.ConvertO(importantCustomerFlg);
            if (endUserFlg != null)
                callPayload.Queries["end_user_flg"] = CSharpExpressionConverter.ConvertO(endUserFlg);
            if (storeFlg != null)
                callPayload.Queries["store_flg"] = CSharpExpressionConverter.ConvertO(storeFlg);
            if (customerId != null)
                callPayload.Queries["customer_id"] = CSharpExpressionConverter.ConvertO(customerId);
            if (ownerUserId != null)
                callPayload.Queries["owner_user_id"] = CSharpExpressionConverter.ConvertO(ownerUserId);
            return new ApiConnectionAction<ActionCreateLeadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetLeadsResponse> ActionGetLeads(Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchClientName = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<int>> searchClientId = null, Expression<Func<string>> searchClientNameKana = null, Expression<Func<string>> searchClientNameDisp = null, Expression<Func<int>> searchOwnerUserId = null, Expression<Func<int>> searchRoleId = null, Expression<Func<int>> searchOrganizationId = null, Expression<Func<string>> searchOrganizationName = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchExtension = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchPref = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<int>> searchFromLatitude = null, Expression<Func<int>> searchToLatitude = null, Expression<Func<int>> searchFromLongitude = null, Expression<Func<int>> searchToLongitude = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<int>> searchLeadStatus = null, Expression<Func<int>> searchLeadSourceKbnIds = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<int>> searchImportantCustomerFlg = null, Expression<Func<int>> searchEndUserFlg = null, Expression<Func<int>> searchStoreFlg = null, Expression<Func<int>> searchCompetitorFlg = null, Expression<Func<int>> searchErrorMailFlg = null, Expression<Func<int>> searchErrorTelFlg = null, Expression<Func<int>> searchErrorFaxFlg = null, Expression<Func<int>> searchErrorAddressFlg = null, Expression<Func<int>> searchNotMailFlg = null, Expression<Func<int>> searchNotTelFlg = null, Expression<Func<int>> searchNotFaxFlg = null, Expression<Func<int>> searchNotDmFlg = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchCustomerId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchIds = null, Expression<Func<string>> searchUserIds = null, Expression<Func<string>> searchMultiple = null)
        {
            var apiCallPath = "/rest_api/v1/leads/get_entry_list_flow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (searchFamilyName != null)
                callPayload.Queries["search[family_name]"] = CSharpExpressionConverter.ConvertO(searchFamilyName);
            if (searchFirstName != null)
                callPayload.Queries["search[first_name]"] = CSharpExpressionConverter.ConvertO(searchFirstName);
            if (searchClientName != null)
                callPayload.Queries["search[client_name]"] = CSharpExpressionConverter.ConvertO(searchClientName);
            if (searchFromId != null)
                callPayload.Queries["search[from_id]"] = CSharpExpressionConverter.ConvertO(searchFromId);
            if (searchToId != null)
                callPayload.Queries["search[to_id]"] = CSharpExpressionConverter.ConvertO(searchToId);
            if (orderKey != null)
                callPayload.Queries["order[key]"] = CSharpExpressionConverter.ConvertO(orderKey);
            if (orderType != null)
                callPayload.Queries["order[type]"] = CSharpExpressionConverter.ConvertO(orderType);
            if (pageDisplayNumber != null)
                callPayload.Queries["page[display_number]"] = CSharpExpressionConverter.ConvertO(pageDisplayNumber);
            if (pageNumber != null)
                callPayload.Queries["page[number]"] = CSharpExpressionConverter.ConvertO(pageNumber);
            if (pageDateFormatOption != null)
                callPayload.Queries["page[date_format_option]"] = CSharpExpressionConverter.ConvertO(pageDateFormatOption);
            if (searchClientId != null)
                callPayload.Queries["search[client_id]"] = CSharpExpressionConverter.ConvertO(searchClientId);
            if (searchClientNameKana != null)
                callPayload.Queries["search[client][name_kana]"] = CSharpExpressionConverter.ConvertO(searchClientNameKana);
            if (searchClientNameDisp != null)
                callPayload.Queries["search[client][name_disp]"] = CSharpExpressionConverter.ConvertO(searchClientNameDisp);
            if (searchOwnerUserId != null)
                callPayload.Queries["search[owner_user_id]"] = CSharpExpressionConverter.ConvertO(searchOwnerUserId);
            if (searchRoleId != null)
                callPayload.Queries["search[role_id]"] = CSharpExpressionConverter.ConvertO(searchRoleId);
            if (searchOrganizationId != null)
                callPayload.Queries["search[organization_id]"] = CSharpExpressionConverter.ConvertO(searchOrganizationId);
            if (searchOrganizationName != null)
                callPayload.Queries["search[organization_name]"] = CSharpExpressionConverter.ConvertO(searchOrganizationName);
            if (searchOrganizationAncestryAllName != null)
                callPayload.Queries["search[organization_ancestry_all_name]"] = CSharpExpressionConverter.ConvertO(searchOrganizationAncestryAllName);
            if (searchPost != null)
                callPayload.Queries["search[post]"] = CSharpExpressionConverter.ConvertO(searchPost);
            if (searchFamilyNameKana != null)
                callPayload.Queries["search[family_name_kana]"] = CSharpExpressionConverter.ConvertO(searchFamilyNameKana);
            if (searchFirstNameKana != null)
                callPayload.Queries["search[first_name_kana]"] = CSharpExpressionConverter.ConvertO(searchFirstNameKana);
            if (searchEmail != null)
                callPayload.Queries["search[email]"] = CSharpExpressionConverter.ConvertO(searchEmail);
            if (searchMobileEmail != null)
                callPayload.Queries["search[mobile_email]"] = CSharpExpressionConverter.ConvertO(searchMobileEmail);
            if (searchTel != null)
                callPayload.Queries["search[tel]"] = CSharpExpressionConverter.ConvertO(searchTel);
            if (searchExtension != null)
                callPayload.Queries["search[extension]"] = CSharpExpressionConverter.ConvertO(searchExtension);
            if (searchFax != null)
                callPayload.Queries["search[fax]"] = CSharpExpressionConverter.ConvertO(searchFax);
            if (searchMobileTel != null)
                callPayload.Queries["search[mobile_tel]"] = CSharpExpressionConverter.ConvertO(searchMobileTel);
            if (searchZip != null)
                callPayload.Queries["search[zip]"] = CSharpExpressionConverter.ConvertO(searchZip);
            if (searchPref != null)
                callPayload.Queries["search[pref]"] = CSharpExpressionConverter.ConvertO(searchPref);
            if (searchAddress != null)
                callPayload.Queries["search[address]"] = CSharpExpressionConverter.ConvertO(searchAddress);
            if (searchUrl != null)
                callPayload.Queries["search[url]"] = CSharpExpressionConverter.ConvertO(searchUrl);
            if (searchFromCreatedOn != null)
                callPayload.Queries["search[from_created_on]"] = CSharpExpressionConverter.ConvertO(searchFromCreatedOn);
            if (searchToCreatedOn != null)
                callPayload.Queries["search[to_created_on]"] = CSharpExpressionConverter.ConvertO(searchToCreatedOn);
            if (searchFromUpdatedOn != null)
                callPayload.Queries["search[from_updated_on]"] = CSharpExpressionConverter.ConvertO(searchFromUpdatedOn);
            if (searchToUpdatedOn != null)
                callPayload.Queries["search[to_updated_on]"] = CSharpExpressionConverter.ConvertO(searchToUpdatedOn);
            if (searchFromDatetimeUpdatedOn != null)
                callPayload.Queries["search[from_datetime_updated_on]"] = CSharpExpressionConverter.ConvertO(searchFromDatetimeUpdatedOn);
            if (searchToDatetimeUpdatedOn != null)
                callPayload.Queries["search[to_datetime_updated_on]"] = CSharpExpressionConverter.ConvertO(searchToDatetimeUpdatedOn);
            if (searchFromTradeOn != null)
                callPayload.Queries["search[from_trade_on]"] = CSharpExpressionConverter.ConvertO(searchFromTradeOn);
            if (searchToTradeOn != null)
                callPayload.Queries["search[to_trade_on]"] = CSharpExpressionConverter.ConvertO(searchToTradeOn);
            if (searchFromLatitude != null)
                callPayload.Queries["search[from_latitude]"] = CSharpExpressionConverter.ConvertO(searchFromLatitude);
            if (searchToLatitude != null)
                callPayload.Queries["search[to_latitude]"] = CSharpExpressionConverter.ConvertO(searchToLatitude);
            if (searchFromLongitude != null)
                callPayload.Queries["search[from_longitude]"] = CSharpExpressionConverter.ConvertO(searchFromLongitude);
            if (searchToLongitude != null)
                callPayload.Queries["search[to_longitude]"] = CSharpExpressionConverter.ConvertO(searchToLongitude);
            if (searchLatitude != null)
                callPayload.Queries["search[latitude]"] = CSharpExpressionConverter.ConvertO(searchLatitude);
            if (searchLongitude != null)
                callPayload.Queries["search[longitude]"] = CSharpExpressionConverter.ConvertO(searchLongitude);
            if (searchLeadStatus != null)
                callPayload.Queries["search[lead_status]"] = CSharpExpressionConverter.ConvertO(searchLeadStatus);
            if (searchLeadSourceKbnIds != null)
                callPayload.Queries["search[lead_source_kbn_ids]"] = CSharpExpressionConverter.ConvertO(searchLeadSourceKbnIds);
            if (searchLeadSource != null)
                callPayload.Queries["search[lead_source]"] = CSharpExpressionConverter.ConvertO(searchLeadSource);
            if (searchImportantCustomerFlg != null)
                callPayload.Queries["search[important_customer_flg]"] = CSharpExpressionConverter.ConvertO(searchImportantCustomerFlg);
            if (searchEndUserFlg != null)
                callPayload.Queries["search[end_user_flg]"] = CSharpExpressionConverter.ConvertO(searchEndUserFlg);
            if (searchStoreFlg != null)
                callPayload.Queries["search[store_flg]"] = CSharpExpressionConverter.ConvertO(searchStoreFlg);
            if (searchCompetitorFlg != null)
                callPayload.Queries["search[competitor_flg]"] = CSharpExpressionConverter.ConvertO(searchCompetitorFlg);
            if (searchErrorMailFlg != null)
                callPayload.Queries["search[error_mail_flg]"] = CSharpExpressionConverter.ConvertO(searchErrorMailFlg);
            if (searchErrorTelFlg != null)
                callPayload.Queries["search[error_tel_flg]"] = CSharpExpressionConverter.ConvertO(searchErrorTelFlg);
            if (searchErrorFaxFlg != null)
                callPayload.Queries["search[error_fax_flg]"] = CSharpExpressionConverter.ConvertO(searchErrorFaxFlg);
            if (searchErrorAddressFlg != null)
                callPayload.Queries["search[error_address_flg]"] = CSharpExpressionConverter.ConvertO(searchErrorAddressFlg);
            if (searchNotMailFlg != null)
                callPayload.Queries["search[not_mail_flg]"] = CSharpExpressionConverter.ConvertO(searchNotMailFlg);
            if (searchNotTelFlg != null)
                callPayload.Queries["search[not_tel_flg]"] = CSharpExpressionConverter.ConvertO(searchNotTelFlg);
            if (searchNotFaxFlg != null)
                callPayload.Queries["search[not_fax_flg]"] = CSharpExpressionConverter.ConvertO(searchNotFaxFlg);
            if (searchNotDmFlg != null)
                callPayload.Queries["search[not_dm_flg]"] = CSharpExpressionConverter.ConvertO(searchNotDmFlg);
            if (searchNote != null)
                callPayload.Queries["search[note]"] = CSharpExpressionConverter.ConvertO(searchNote);
            if (searchCustomerId != null)
                callPayload.Queries["search[customer_id]"] = CSharpExpressionConverter.ConvertO(searchCustomerId);
            if (searchName != null)
                callPayload.Queries["search[name]"] = CSharpExpressionConverter.ConvertO(searchName);
            if (searchIds != null)
                callPayload.Queries["search[ids]"] = CSharpExpressionConverter.ConvertO(searchIds);
            if (searchUserIds != null)
                callPayload.Queries["search[user_ids]"] = CSharpExpressionConverter.ConvertO(searchUserIds);
            if (searchMultiple != null)
                callPayload.Queries["search[multiple]"] = CSharpExpressionConverter.ConvertO(searchMultiple);
            return new ApiConnectionAction<ActionGetLeadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> ActionUpdateLead(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
        {
            var apiCallPath = "/rest_api/v1/leads/update";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["client_id"] = CSharpExpressionConverter.ConvertO(clientId);
            if (organizationId != null)
                callPayload.Queries["organization_id"] = CSharpExpressionConverter.ConvertO(organizationId);
            if (post != null)
                callPayload.Queries["post"] = CSharpExpressionConverter.ConvertO(post);
            if (familyName != null)
                callPayload.Queries["family_name"] = CSharpExpressionConverter.ConvertO(familyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (familyNameKana != null)
                callPayload.Queries["family_name_kana"] = CSharpExpressionConverter.ConvertO(familyNameKana);
            if (firstNameKana != null)
                callPayload.Queries["first_name_kana"] = CSharpExpressionConverter.ConvertO(firstNameKana);
            if (tel != null)
                callPayload.Queries["tel"] = CSharpExpressionConverter.ConvertO(tel);
            if (extension != null)
                callPayload.Queries["extension"] = CSharpExpressionConverter.ConvertO(extension);
            if (fax != null)
                callPayload.Queries["fax"] = CSharpExpressionConverter.ConvertO(fax);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (mobileTel != null)
                callPayload.Queries["mobile_tel"] = CSharpExpressionConverter.ConvertO(mobileTel);
            if (mobileEmail != null)
                callPayload.Queries["mobile_email"] = CSharpExpressionConverter.ConvertO(mobileEmail);
            if (zip != null)
                callPayload.Queries["zip"] = CSharpExpressionConverter.ConvertO(zip);
            if (prefId != null)
                callPayload.Queries["pref_id"] = CSharpExpressionConverter.ConvertO(prefId);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (url != null)
                callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            if (leadStatus != null)
                callPayload.Queries["lead_status"] = CSharpExpressionConverter.ConvertO(leadStatus);
            if (latitude != null)
                callPayload.Queries["latitude"] = CSharpExpressionConverter.ConvertO(latitude);
            if (longitude != null)
                callPayload.Queries["longitude"] = CSharpExpressionConverter.ConvertO(longitude);
            if (leadSourceKbnId != null)
                callPayload.Queries["lead_source_kbn_id"] = CSharpExpressionConverter.ConvertO(leadSourceKbnId);
            if (leadSource != null)
                callPayload.Queries["lead_source"] = CSharpExpressionConverter.ConvertO(leadSource);
            if (note != null)
                callPayload.Queries["note"] = CSharpExpressionConverter.ConvertO(note);
            if (errorMailFlg != null)
                callPayload.Queries["error_mail_flg"] = CSharpExpressionConverter.ConvertO(errorMailFlg);
            if (errorTelFlg != null)
                callPayload.Queries["error_tel_flg"] = CSharpExpressionConverter.ConvertO(errorTelFlg);
            if (errorFaxFlg != null)
                callPayload.Queries["error_fax_flg"] = CSharpExpressionConverter.ConvertO(errorFaxFlg);
            if (errorAddressFlg != null)
                callPayload.Queries["error_address_flg"] = CSharpExpressionConverter.ConvertO(errorAddressFlg);
            if (notMailFlg != null)
                callPayload.Queries["not_mail_flg"] = CSharpExpressionConverter.ConvertO(notMailFlg);
            if (notTelFlg != null)
                callPayload.Queries["not_tel_flg"] = CSharpExpressionConverter.ConvertO(notTelFlg);
            if (notFaxFlg != null)
                callPayload.Queries["not_fax_flg"] = CSharpExpressionConverter.ConvertO(notFaxFlg);
            if (notDmFlg != null)
                callPayload.Queries["not_dm_flg"] = CSharpExpressionConverter.ConvertO(notDmFlg);
            if (competitorFlg != null)
                callPayload.Queries["competitor_flg"] = CSharpExpressionConverter.ConvertO(competitorFlg);
            if (importantCustomerFlg != null)
                callPayload.Queries["important_customer_flg"] = CSharpExpressionConverter.ConvertO(importantCustomerFlg);
            if (endUserFlg != null)
                callPayload.Queries["end_user_flg"] = CSharpExpressionConverter.ConvertO(endUserFlg);
            if (storeFlg != null)
                callPayload.Queries["store_flg"] = CSharpExpressionConverter.ConvertO(storeFlg);
            if (customerId != null)
                callPayload.Queries["customer_id"] = CSharpExpressionConverter.ConvertO(customerId);
            if (ownerUserId != null)
                callPayload.Queries["owner_user_id"] = CSharpExpressionConverter.ConvertO(ownerUserId);
            return new ApiConnectionAction<ActionUpdateLeadResponse>(callPayload);
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