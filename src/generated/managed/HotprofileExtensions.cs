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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> ActionGetBusinessCards(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<bool>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchClientName = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<int>> searchRoleId = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchDirectNote = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<string>> searchRequestKey = null, Expression<Func<int>> searchLatitude = null, Expression<Func<int>> searchLongitude = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> ActionUpdateBusinessCard(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<int>> status = null, Expression<Func<int>> openStatus = null, Expression<Func<int>> ownerUserId = null, Expression<Func<string>> ownerUser = null, Expression<Func<string>> tradeOn = null, Expression<Func<string>> note = null, Expression<Func<string>> directNote = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateClientResponse> ActionCreateClient(Expression<Func<string>> name, Expression<Func<string>> nameDisp, Expression<Func<string>> nameKana = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetClientsResponse> ActionGetClients(Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchNameKana = null, Expression<Func<string>> searchNameDisp = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<string>> searchCorporateNumber = null, Expression<Func<string>> searchMainTel = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchMailDomain = null, Expression<Func<string>> searchNote = null, Expression<Func<int>> searchUserIds = null, Expression<Func<string>> searchNameSub = null, Expression<Func<string>> searchNameKanaSub = null, Expression<Func<string>> searchZipSub = null, Expression<Func<string>> searchAddressSub = null, Expression<Func<string>> searchPrefSub = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateClientResponse> ActionUpdateClient(Expression<Func<int>> id, Expression<Func<string>> name = null, Expression<Func<string>> nameKana = null, Expression<Func<string>> nameDisp = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> businessCategoryKbn = null, Expression<Func<int>> workerNumberKbn = null, Expression<Func<int>> capitalKbn = null, Expression<Func<int>> ipoKbn = null, Expression<Func<string>> salesLastYear = null, Expression<Func<string>> mainTel = null, Expression<Func<string>> url = null, Expression<Func<string>> mailDomain = null, Expression<Func<int>> userId = null, Expression<Func<string>> note = null, Expression<Func<string>> nameSub = null, Expression<Func<string>> nameKanaSub = null, Expression<Func<string>> zipSub = null, Expression<Func<string>> addressSub = null, Expression<Func<string>> prefSub = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateLeadResponse> ActionCreateLead(Expression<Func<int>> clientId, Expression<Func<string>> familyName, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetLeadsResponse> ActionGetLeads(Expression<Func<string>> searchFamilyName = null, Expression<Func<string>> searchFirstName = null, Expression<Func<string>> searchClientName = null, Expression<Func<int>> searchFromId = null, Expression<Func<int>> searchToId = null, Expression<Func<string>> orderKey = null, Expression<Func<string>> orderType = null, Expression<Func<int>> pageDisplayNumber = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageDateFormatOption = null, Expression<Func<int>> searchClientId = null, Expression<Func<string>> searchClientNameKana = null, Expression<Func<string>> searchClientNameDisp = null, Expression<Func<int>> searchOwnerUserId = null, Expression<Func<int>> searchRoleId = null, Expression<Func<int>> searchOrganizationId = null, Expression<Func<string>> searchOrganizationName = null, Expression<Func<string>> searchOrganizationAncestryAllName = null, Expression<Func<string>> searchPost = null, Expression<Func<string>> searchFamilyNameKana = null, Expression<Func<string>> searchFirstNameKana = null, Expression<Func<string>> searchEmail = null, Expression<Func<string>> searchMobileEmail = null, Expression<Func<string>> searchTel = null, Expression<Func<string>> searchExtension = null, Expression<Func<string>> searchFax = null, Expression<Func<string>> searchMobileTel = null, Expression<Func<string>> searchZip = null, Expression<Func<string>> searchPref = null, Expression<Func<string>> searchAddress = null, Expression<Func<string>> searchUrl = null, Expression<Func<string>> searchFromCreatedOn = null, Expression<Func<string>> searchToCreatedOn = null, Expression<Func<string>> searchFromUpdatedOn = null, Expression<Func<string>> searchToUpdatedOn = null, Expression<Func<string>> searchFromDatetimeUpdatedOn = null, Expression<Func<string>> searchToDatetimeUpdatedOn = null, Expression<Func<string>> searchFromTradeOn = null, Expression<Func<string>> searchToTradeOn = null, Expression<Func<int>> searchFromLatitude = null, Expression<Func<int>> searchToLatitude = null, Expression<Func<int>> searchFromLongitude = null, Expression<Func<int>> searchToLongitude = null, Expression<Func<string>> searchLatitude = null, Expression<Func<string>> searchLongitude = null, Expression<Func<int>> searchLeadStatus = null, Expression<Func<int>> searchLeadSourceKbnIds = null, Expression<Func<string>> searchLeadSource = null, Expression<Func<int>> searchImportantCustomerFlg = null, Expression<Func<int>> searchEndUserFlg = null, Expression<Func<int>> searchStoreFlg = null, Expression<Func<int>> searchCompetitorFlg = null, Expression<Func<int>> searchErrorMailFlg = null, Expression<Func<int>> searchErrorTelFlg = null, Expression<Func<int>> searchErrorFaxFlg = null, Expression<Func<int>> searchErrorAddressFlg = null, Expression<Func<int>> searchNotMailFlg = null, Expression<Func<int>> searchNotTelFlg = null, Expression<Func<int>> searchNotFaxFlg = null, Expression<Func<int>> searchNotDmFlg = null, Expression<Func<string>> searchNote = null, Expression<Func<string>> searchCustomerId = null, Expression<Func<string>> searchName = null, Expression<Func<string>> searchIds = null, Expression<Func<string>> searchUserIds = null, Expression<Func<string>> searchMultiple = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> ActionUpdateLead(Expression<Func<int>> id, Expression<Func<int>> clientId, Expression<Func<int>> organizationId = null, Expression<Func<string>> post = null, Expression<Func<string>> familyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> familyNameKana = null, Expression<Func<string>> firstNameKana = null, Expression<Func<string>> tel = null, Expression<Func<int>> extension = null, Expression<Func<string>> fax = null, Expression<Func<string>> email = null, Expression<Func<string>> mobileTel = null, Expression<Func<string>> mobileEmail = null, Expression<Func<string>> zip = null, Expression<Func<int>> prefId = null, Expression<Func<string>> address = null, Expression<Func<string>> url = null, Expression<Func<int>> leadStatus = null, Expression<Func<int>> latitude = null, Expression<Func<int>> longitude = null, Expression<Func<int>> leadSourceKbnId = null, Expression<Func<string>> leadSource = null, Expression<Func<string>> note = null, Expression<Func<bool>> errorMailFlg = null, Expression<Func<bool>> errorTelFlg = null, Expression<Func<bool>> errorFaxFlg = null, Expression<Func<bool>> errorAddressFlg = null, Expression<Func<bool>> notMailFlg = null, Expression<Func<bool>> notTelFlg = null, Expression<Func<bool>> notFaxFlg = null, Expression<Func<bool>> notDmFlg = null, Expression<Func<bool>> competitorFlg = null, Expression<Func<bool>> importantCustomerFlg = null, Expression<Func<bool>> endUserFlg = null, Expression<Func<bool>> storeFlg = null, Expression<Func<string>> customerId = null, Expression<Func<string>> ownerUserId = null)
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