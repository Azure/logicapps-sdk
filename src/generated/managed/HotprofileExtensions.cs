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
        public IBodyWorkflowAction<ActionCreateBusinessCardResponse> ActionCreateBusinessCard([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<string> familyName, [WorkflowExpression] Func<int> status, [WorkflowExpression] Func<int> openStatus, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<int> ownerUserId = null, [WorkflowExpression] Func<string> ownerUser = null, [WorkflowExpression] Func<string> tradeOn = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> directNote = null)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(familyName, nameof(familyName), required: true);
            SourceExpression.Validate(status, nameof(status), required: true);
            SourceExpression.Validate(openStatus, nameof(openStatus), required: true);
            SourceExpression.Validate(organizationId, nameof(organizationId), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(familyNameKana, nameof(familyNameKana), required: false);
            SourceExpression.Validate(firstNameKana, nameof(firstNameKana), required: false);
            SourceExpression.Validate(tel, nameof(tel), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(fax, nameof(fax), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(mobileTel, nameof(mobileTel), required: false);
            SourceExpression.Validate(mobileEmail, nameof(mobileEmail), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            SourceExpression.Validate(leadSource, nameof(leadSource), required: false);
            SourceExpression.Validate(ownerUserId, nameof(ownerUserId), required: false);
            SourceExpression.Validate(ownerUser, nameof(ownerUser), required: false);
            SourceExpression.Validate(tradeOn, nameof(tradeOn), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(directNote, nameof(directNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/business_cards/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = SourceExpressionConverter.ConvertO(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = SourceExpressionConverter.ConvertO(organizationId);
                callPayload.Queries["family_name"] = SourceExpressionConverter.ConvertO(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = SourceExpressionConverter.ConvertO(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = SourceExpressionConverter.ConvertO(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = SourceExpressionConverter.ConvertO(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = SourceExpressionConverter.ConvertO(fax);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = SourceExpressionConverter.ConvertO(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = SourceExpressionConverter.ConvertO(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = SourceExpressionConverter.ConvertO(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = SourceExpressionConverter.ConvertO(leadSource);
                callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                callPayload.Queries["open_status"] = SourceExpressionConverter.ConvertO(openStatus);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = SourceExpressionConverter.ConvertO(ownerUserId);
                if (ownerUser != null)
                    callPayload.Queries["owner_user"] = SourceExpressionConverter.ConvertO(ownerUser);
                if (tradeOn != null)
                    callPayload.Queries["trade_on"] = SourceExpressionConverter.ConvertO(tradeOn);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (directNote != null)
                    callPayload.Queries["direct_note"] = SourceExpressionConverter.ConvertO(directNote);
                return callPayload;
            }

            return new ApiConnectionAction<ActionCreateBusinessCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetBusinessCardsResponse> ActionGetBusinessCards([WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<bool> pageDateFormatOption = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<string> searchFamilyName = null, [WorkflowExpression] Func<string> searchFirstName = null, [WorkflowExpression] Func<string> searchFamilyNameKana = null, [WorkflowExpression] Func<string> searchFirstNameKana = null, [WorkflowExpression] Func<string> searchClientName = null, [WorkflowExpression] Func<string> searchFromTradeOn = null, [WorkflowExpression] Func<string> searchToTradeOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchOrganizationAncestryAllName = null, [WorkflowExpression] Func<string> searchPost = null, [WorkflowExpression] Func<string> searchTel = null, [WorkflowExpression] Func<string> searchFax = null, [WorkflowExpression] Func<string> searchMobileTel = null, [WorkflowExpression] Func<string> searchEmail = null, [WorkflowExpression] Func<string> searchMobileEmail = null, [WorkflowExpression] Func<int> searchRoleId = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<string> searchDirectNote = null, [WorkflowExpression] Func<string> searchLeadSource = null, [WorkflowExpression] Func<string> searchRequestKey = null, [WorkflowExpression] Func<int> searchLatitude = null, [WorkflowExpression] Func<int> searchLongitude = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            SourceExpression.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            SourceExpression.Validate(orderKey, nameof(orderKey), required: false);
            SourceExpression.Validate(orderType, nameof(orderType), required: false);
            SourceExpression.Validate(searchFamilyName, nameof(searchFamilyName), required: false);
            SourceExpression.Validate(searchFirstName, nameof(searchFirstName), required: false);
            SourceExpression.Validate(searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            SourceExpression.Validate(searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            SourceExpression.Validate(searchClientName, nameof(searchClientName), required: false);
            SourceExpression.Validate(searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            SourceExpression.Validate(searchToTradeOn, nameof(searchToTradeOn), required: false);
            SourceExpression.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            SourceExpression.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            SourceExpression.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            SourceExpression.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            SourceExpression.Validate(searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            SourceExpression.Validate(searchPost, nameof(searchPost), required: false);
            SourceExpression.Validate(searchTel, nameof(searchTel), required: false);
            SourceExpression.Validate(searchFax, nameof(searchFax), required: false);
            SourceExpression.Validate(searchMobileTel, nameof(searchMobileTel), required: false);
            SourceExpression.Validate(searchEmail, nameof(searchEmail), required: false);
            SourceExpression.Validate(searchMobileEmail, nameof(searchMobileEmail), required: false);
            SourceExpression.Validate(searchRoleId, nameof(searchRoleId), required: false);
            SourceExpression.Validate(searchZip, nameof(searchZip), required: false);
            SourceExpression.Validate(searchAddress, nameof(searchAddress), required: false);
            SourceExpression.Validate(searchUrl, nameof(searchUrl), required: false);
            SourceExpression.Validate(searchNote, nameof(searchNote), required: false);
            SourceExpression.Validate(searchDirectNote, nameof(searchDirectNote), required: false);
            SourceExpression.Validate(searchLeadSource, nameof(searchLeadSource), required: false);
            SourceExpression.Validate(searchRequestKey, nameof(searchRequestKey), required: false);
            SourceExpression.Validate(searchLatitude, nameof(searchLatitude), required: false);
            SourceExpression.Validate(searchLongitude, nameof(searchLongitude), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/business_cards/get_entry_list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = SourceExpressionConverter.ConvertO(pageNumber);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = SourceExpressionConverter.ConvertO(pageDisplayNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = SourceExpressionConverter.ConvertO(pageDateFormatOption);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = SourceExpressionConverter.ConvertO(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = SourceExpressionConverter.ConvertO(orderType);
                if (searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = SourceExpressionConverter.ConvertO(searchFamilyName);
                if (searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = SourceExpressionConverter.ConvertO(searchFirstName);
                if (searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = SourceExpressionConverter.ConvertO(searchFamilyNameKana);
                if (searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = SourceExpressionConverter.ConvertO(searchFirstNameKana);
                if (searchClientName != null)
                    callPayload.Queries["search[client_name]"] = SourceExpressionConverter.ConvertO(searchClientName);
                if (searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = SourceExpressionConverter.ConvertO(searchFromTradeOn);
                if (searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = SourceExpressionConverter.ConvertO(searchToTradeOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = SourceExpressionConverter.ConvertO(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = SourceExpressionConverter.ConvertO(searchToUpdatedOn);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = SourceExpressionConverter.ConvertO(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = SourceExpressionConverter.ConvertO(searchToCreatedOn);
                if (searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = SourceExpressionConverter.ConvertO(searchOrganizationAncestryAllName);
                if (searchPost != null)
                    callPayload.Queries["search[post]"] = SourceExpressionConverter.ConvertO(searchPost);
                if (searchTel != null)
                    callPayload.Queries["search[tel]"] = SourceExpressionConverter.ConvertO(searchTel);
                if (searchFax != null)
                    callPayload.Queries["search[fax]"] = SourceExpressionConverter.ConvertO(searchFax);
                if (searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = SourceExpressionConverter.ConvertO(searchMobileTel);
                if (searchEmail != null)
                    callPayload.Queries["search[email]"] = SourceExpressionConverter.ConvertO(searchEmail);
                if (searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = SourceExpressionConverter.ConvertO(searchMobileEmail);
                if (searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = SourceExpressionConverter.ConvertO(searchRoleId);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = SourceExpressionConverter.ConvertO(searchZip);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = SourceExpressionConverter.ConvertO(searchAddress);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = SourceExpressionConverter.ConvertO(searchUrl);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = SourceExpressionConverter.ConvertO(searchNote);
                if (searchDirectNote != null)
                    callPayload.Queries["search[direct_note]"] = SourceExpressionConverter.ConvertO(searchDirectNote);
                if (searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = SourceExpressionConverter.ConvertO(searchLeadSource);
                if (searchRequestKey != null)
                    callPayload.Queries["search[request_key]"] = SourceExpressionConverter.ConvertO(searchRequestKey);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = SourceExpressionConverter.ConvertO(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = SourceExpressionConverter.ConvertO(searchLongitude);
                return callPayload;
            }

            return new ApiConnectionAction<ActionGetBusinessCardsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateBusinessCardResponse> ActionUpdateBusinessCard([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> familyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<int> openStatus = null, [WorkflowExpression] Func<int> ownerUserId = null, [WorkflowExpression] Func<string> ownerUser = null, [WorkflowExpression] Func<string> tradeOn = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> directNote = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(organizationId, nameof(organizationId), required: false);
            SourceExpression.Validate(familyName, nameof(familyName), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(familyNameKana, nameof(familyNameKana), required: false);
            SourceExpression.Validate(firstNameKana, nameof(firstNameKana), required: false);
            SourceExpression.Validate(tel, nameof(tel), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(fax, nameof(fax), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(mobileTel, nameof(mobileTel), required: false);
            SourceExpression.Validate(mobileEmail, nameof(mobileEmail), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            SourceExpression.Validate(leadSource, nameof(leadSource), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(openStatus, nameof(openStatus), required: false);
            SourceExpression.Validate(ownerUserId, nameof(ownerUserId), required: false);
            SourceExpression.Validate(ownerUser, nameof(ownerUser), required: false);
            SourceExpression.Validate(tradeOn, nameof(tradeOn), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(directNote, nameof(directNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/business_cards/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["client_id"] = SourceExpressionConverter.ConvertO(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = SourceExpressionConverter.ConvertO(organizationId);
                if (familyName != null)
                    callPayload.Queries["family_name"] = SourceExpressionConverter.ConvertO(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = SourceExpressionConverter.ConvertO(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = SourceExpressionConverter.ConvertO(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = SourceExpressionConverter.ConvertO(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = SourceExpressionConverter.ConvertO(fax);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = SourceExpressionConverter.ConvertO(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = SourceExpressionConverter.ConvertO(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = SourceExpressionConverter.ConvertO(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = SourceExpressionConverter.ConvertO(leadSource);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (openStatus != null)
                    callPayload.Queries["open_status"] = SourceExpressionConverter.ConvertO(openStatus);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = SourceExpressionConverter.ConvertO(ownerUserId);
                if (ownerUser != null)
                    callPayload.Queries["owner_user"] = SourceExpressionConverter.ConvertO(ownerUser);
                if (tradeOn != null)
                    callPayload.Queries["trade_on"] = SourceExpressionConverter.ConvertO(tradeOn);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (directNote != null)
                    callPayload.Queries["direct_note"] = SourceExpressionConverter.ConvertO(directNote);
                return callPayload;
            }

            return new ApiConnectionAction<ActionUpdateBusinessCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateClientResponse> ActionCreateClient([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> nameDisp, [WorkflowExpression] Func<string> nameKana = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> businessCategoryKbn = null, [WorkflowExpression] Func<int> workerNumberKbn = null, [WorkflowExpression] Func<int> capitalKbn = null, [WorkflowExpression] Func<int> ipoKbn = null, [WorkflowExpression] Func<string> salesLastYear = null, [WorkflowExpression] Func<string> mainTel = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> mailDomain = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> nameSub = null, [WorkflowExpression] Func<string> nameKanaSub = null, [WorkflowExpression] Func<string> zipSub = null, [WorkflowExpression] Func<string> addressSub = null, [WorkflowExpression] Func<string> prefSub = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(nameDisp, nameof(nameDisp), required: true);
            SourceExpression.Validate(nameKana, nameof(nameKana), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            SourceExpression.Validate(workerNumberKbn, nameof(workerNumberKbn), required: false);
            SourceExpression.Validate(capitalKbn, nameof(capitalKbn), required: false);
            SourceExpression.Validate(ipoKbn, nameof(ipoKbn), required: false);
            SourceExpression.Validate(salesLastYear, nameof(salesLastYear), required: false);
            SourceExpression.Validate(mainTel, nameof(mainTel), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(mailDomain, nameof(mailDomain), required: false);
            SourceExpression.Validate(userId, nameof(userId), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(nameSub, nameof(nameSub), required: false);
            SourceExpression.Validate(nameKanaSub, nameof(nameKanaSub), required: false);
            SourceExpression.Validate(zipSub, nameof(zipSub), required: false);
            SourceExpression.Validate(addressSub, nameof(addressSub), required: false);
            SourceExpression.Validate(prefSub, nameof(prefSub), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/clients/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (nameKana != null)
                    callPayload.Queries["name_kana"] = SourceExpressionConverter.ConvertO(nameKana);
                callPayload.Queries["name_disp"] = SourceExpressionConverter.ConvertO(nameDisp);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = SourceExpressionConverter.ConvertO(businessCategoryKbn);
                if (workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = SourceExpressionConverter.ConvertO(workerNumberKbn);
                if (capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = SourceExpressionConverter.ConvertO(capitalKbn);
                if (ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = SourceExpressionConverter.ConvertO(ipoKbn);
                if (salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = SourceExpressionConverter.ConvertO(salesLastYear);
                if (mainTel != null)
                    callPayload.Queries["main_tel"] = SourceExpressionConverter.ConvertO(mainTel);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (mailDomain != null)
                    callPayload.Queries["mail_domain"] = SourceExpressionConverter.ConvertO(mailDomain);
                if (userId != null)
                    callPayload.Queries["user_id"] = SourceExpressionConverter.ConvertO(userId);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (nameSub != null)
                    callPayload.Queries["name_sub"] = SourceExpressionConverter.ConvertO(nameSub);
                if (nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = SourceExpressionConverter.ConvertO(nameKanaSub);
                if (zipSub != null)
                    callPayload.Queries["zip_sub"] = SourceExpressionConverter.ConvertO(zipSub);
                if (addressSub != null)
                    callPayload.Queries["address_sub"] = SourceExpressionConverter.ConvertO(addressSub);
                if (prefSub != null)
                    callPayload.Queries["pref_sub"] = SourceExpressionConverter.ConvertO(prefSub);
                return callPayload;
            }

            return new ApiConnectionAction<ActionCreateClientResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetClientsResponse> ActionGetClients([WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<int> pageDateFormatOption = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<int> searchFromId = null, [WorkflowExpression] Func<int> searchToId = null, [WorkflowExpression] Func<string> searchName = null, [WorkflowExpression] Func<string> searchNameKana = null, [WorkflowExpression] Func<string> searchNameDisp = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchLatitude = null, [WorkflowExpression] Func<string> searchLongitude = null, [WorkflowExpression] Func<string> searchCorporateNumber = null, [WorkflowExpression] Func<string> searchMainTel = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchMailDomain = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<int> searchUserIds = null, [WorkflowExpression] Func<string> searchNameSub = null, [WorkflowExpression] Func<string> searchNameKanaSub = null, [WorkflowExpression] Func<string> searchZipSub = null, [WorkflowExpression] Func<string> searchAddressSub = null, [WorkflowExpression] Func<string> searchPrefSub = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchToDatetimeUpdatedOn = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            SourceExpression.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            SourceExpression.Validate(orderKey, nameof(orderKey), required: false);
            SourceExpression.Validate(orderType, nameof(orderType), required: false);
            SourceExpression.Validate(searchFromId, nameof(searchFromId), required: false);
            SourceExpression.Validate(searchToId, nameof(searchToId), required: false);
            SourceExpression.Validate(searchName, nameof(searchName), required: false);
            SourceExpression.Validate(searchNameKana, nameof(searchNameKana), required: false);
            SourceExpression.Validate(searchNameDisp, nameof(searchNameDisp), required: false);
            SourceExpression.Validate(searchZip, nameof(searchZip), required: false);
            SourceExpression.Validate(searchAddress, nameof(searchAddress), required: false);
            SourceExpression.Validate(searchLatitude, nameof(searchLatitude), required: false);
            SourceExpression.Validate(searchLongitude, nameof(searchLongitude), required: false);
            SourceExpression.Validate(searchCorporateNumber, nameof(searchCorporateNumber), required: false);
            SourceExpression.Validate(searchMainTel, nameof(searchMainTel), required: false);
            SourceExpression.Validate(searchUrl, nameof(searchUrl), required: false);
            SourceExpression.Validate(searchMailDomain, nameof(searchMailDomain), required: false);
            SourceExpression.Validate(searchNote, nameof(searchNote), required: false);
            SourceExpression.Validate(searchUserIds, nameof(searchUserIds), required: false);
            SourceExpression.Validate(searchNameSub, nameof(searchNameSub), required: false);
            SourceExpression.Validate(searchNameKanaSub, nameof(searchNameKanaSub), required: false);
            SourceExpression.Validate(searchZipSub, nameof(searchZipSub), required: false);
            SourceExpression.Validate(searchAddressSub, nameof(searchAddressSub), required: false);
            SourceExpression.Validate(searchPrefSub, nameof(searchPrefSub), required: false);
            SourceExpression.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            SourceExpression.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            SourceExpression.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            SourceExpression.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            SourceExpression.Validate(searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            SourceExpression.Validate(searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/clients/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = SourceExpressionConverter.ConvertO(pageNumber);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = SourceExpressionConverter.ConvertO(pageDisplayNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = SourceExpressionConverter.ConvertO(pageDateFormatOption);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = SourceExpressionConverter.ConvertO(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = SourceExpressionConverter.ConvertO(orderType);
                if (searchFromId != null)
                    callPayload.Queries["search[from_id]"] = SourceExpressionConverter.ConvertO(searchFromId);
                if (searchToId != null)
                    callPayload.Queries["search[to_id]"] = SourceExpressionConverter.ConvertO(searchToId);
                if (searchName != null)
                    callPayload.Queries["search[name]"] = SourceExpressionConverter.ConvertO(searchName);
                if (searchNameKana != null)
                    callPayload.Queries["search[name_kana]"] = SourceExpressionConverter.ConvertO(searchNameKana);
                if (searchNameDisp != null)
                    callPayload.Queries["search[name_disp]"] = SourceExpressionConverter.ConvertO(searchNameDisp);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = SourceExpressionConverter.ConvertO(searchZip);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = SourceExpressionConverter.ConvertO(searchAddress);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = SourceExpressionConverter.ConvertO(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = SourceExpressionConverter.ConvertO(searchLongitude);
                if (searchCorporateNumber != null)
                    callPayload.Queries["search[corporate_number]"] = SourceExpressionConverter.ConvertO(searchCorporateNumber);
                if (searchMainTel != null)
                    callPayload.Queries["search[main_tel]"] = SourceExpressionConverter.ConvertO(searchMainTel);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = SourceExpressionConverter.ConvertO(searchUrl);
                if (searchMailDomain != null)
                    callPayload.Queries["search[mail_domain]"] = SourceExpressionConverter.ConvertO(searchMailDomain);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = SourceExpressionConverter.ConvertO(searchNote);
                if (searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = SourceExpressionConverter.ConvertO(searchUserIds);
                if (searchNameSub != null)
                    callPayload.Queries["search[name_sub]"] = SourceExpressionConverter.ConvertO(searchNameSub);
                if (searchNameKanaSub != null)
                    callPayload.Queries["search[name_kana_sub]"] = SourceExpressionConverter.ConvertO(searchNameKanaSub);
                if (searchZipSub != null)
                    callPayload.Queries["search[zip_sub]"] = SourceExpressionConverter.ConvertO(searchZipSub);
                if (searchAddressSub != null)
                    callPayload.Queries["search[address_sub]"] = SourceExpressionConverter.ConvertO(searchAddressSub);
                if (searchPrefSub != null)
                    callPayload.Queries["search[pref_sub]"] = SourceExpressionConverter.ConvertO(searchPrefSub);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = SourceExpressionConverter.ConvertO(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = SourceExpressionConverter.ConvertO(searchToCreatedOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = SourceExpressionConverter.ConvertO(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = SourceExpressionConverter.ConvertO(searchToUpdatedOn);
                if (searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = SourceExpressionConverter.ConvertO(searchFromDatetimeUpdatedOn);
                if (searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = SourceExpressionConverter.ConvertO(searchToDatetimeUpdatedOn);
                return callPayload;
            }

            return new ApiConnectionAction<ActionGetClientsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateClientResponse> ActionUpdateClient([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> nameKana = null, [WorkflowExpression] Func<string> nameDisp = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> businessCategoryKbn = null, [WorkflowExpression] Func<int> workerNumberKbn = null, [WorkflowExpression] Func<int> capitalKbn = null, [WorkflowExpression] Func<int> ipoKbn = null, [WorkflowExpression] Func<string> salesLastYear = null, [WorkflowExpression] Func<string> mainTel = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> mailDomain = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> nameSub = null, [WorkflowExpression] Func<string> nameKanaSub = null, [WorkflowExpression] Func<string> zipSub = null, [WorkflowExpression] Func<string> addressSub = null, [WorkflowExpression] Func<string> prefSub = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(nameKana, nameof(nameKana), required: false);
            SourceExpression.Validate(nameDisp, nameof(nameDisp), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(businessCategoryKbn, nameof(businessCategoryKbn), required: false);
            SourceExpression.Validate(workerNumberKbn, nameof(workerNumberKbn), required: false);
            SourceExpression.Validate(capitalKbn, nameof(capitalKbn), required: false);
            SourceExpression.Validate(ipoKbn, nameof(ipoKbn), required: false);
            SourceExpression.Validate(salesLastYear, nameof(salesLastYear), required: false);
            SourceExpression.Validate(mainTel, nameof(mainTel), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(mailDomain, nameof(mailDomain), required: false);
            SourceExpression.Validate(userId, nameof(userId), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(nameSub, nameof(nameSub), required: false);
            SourceExpression.Validate(nameKanaSub, nameof(nameKanaSub), required: false);
            SourceExpression.Validate(zipSub, nameof(zipSub), required: false);
            SourceExpression.Validate(addressSub, nameof(addressSub), required: false);
            SourceExpression.Validate(prefSub, nameof(prefSub), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/clients/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (nameKana != null)
                    callPayload.Queries["name_kana"] = SourceExpressionConverter.ConvertO(nameKana);
                if (nameDisp != null)
                    callPayload.Queries["name_disp"] = SourceExpressionConverter.ConvertO(nameDisp);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (businessCategoryKbn != null)
                    callPayload.Queries["business_category_kbn"] = SourceExpressionConverter.ConvertO(businessCategoryKbn);
                if (workerNumberKbn != null)
                    callPayload.Queries["worker_number_kbn"] = SourceExpressionConverter.ConvertO(workerNumberKbn);
                if (capitalKbn != null)
                    callPayload.Queries["capital_kbn"] = SourceExpressionConverter.ConvertO(capitalKbn);
                if (ipoKbn != null)
                    callPayload.Queries["ipo_kbn"] = SourceExpressionConverter.ConvertO(ipoKbn);
                if (salesLastYear != null)
                    callPayload.Queries["sales_last_year"] = SourceExpressionConverter.ConvertO(salesLastYear);
                if (mainTel != null)
                    callPayload.Queries["main_tel"] = SourceExpressionConverter.ConvertO(mainTel);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (mailDomain != null)
                    callPayload.Queries["mail_domain"] = SourceExpressionConverter.ConvertO(mailDomain);
                if (userId != null)
                    callPayload.Queries["user_id"] = SourceExpressionConverter.ConvertO(userId);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (nameSub != null)
                    callPayload.Queries["name_sub"] = SourceExpressionConverter.ConvertO(nameSub);
                if (nameKanaSub != null)
                    callPayload.Queries["name_kana_sub"] = SourceExpressionConverter.ConvertO(nameKanaSub);
                if (zipSub != null)
                    callPayload.Queries["zip_sub"] = SourceExpressionConverter.ConvertO(zipSub);
                if (addressSub != null)
                    callPayload.Queries["address_sub"] = SourceExpressionConverter.ConvertO(addressSub);
                if (prefSub != null)
                    callPayload.Queries["pref_sub"] = SourceExpressionConverter.ConvertO(prefSub);
                return callPayload;
            }

            return new ApiConnectionAction<ActionUpdateClientResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionCreateLeadResponse> ActionCreateLead([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<string> familyName, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> post = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> leadStatus = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<bool> errorMailFlg = null, [WorkflowExpression] Func<bool> errorTelFlg = null, [WorkflowExpression] Func<bool> errorFaxFlg = null, [WorkflowExpression] Func<bool> errorAddressFlg = null, [WorkflowExpression] Func<bool> notMailFlg = null, [WorkflowExpression] Func<bool> notTelFlg = null, [WorkflowExpression] Func<bool> notFaxFlg = null, [WorkflowExpression] Func<bool> notDmFlg = null, [WorkflowExpression] Func<bool> competitorFlg = null, [WorkflowExpression] Func<bool> importantCustomerFlg = null, [WorkflowExpression] Func<bool> endUserFlg = null, [WorkflowExpression] Func<bool> storeFlg = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> ownerUserId = null)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(familyName, nameof(familyName), required: true);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(familyNameKana, nameof(familyNameKana), required: false);
            SourceExpression.Validate(firstNameKana, nameof(firstNameKana), required: false);
            SourceExpression.Validate(organizationId, nameof(organizationId), required: false);
            SourceExpression.Validate(post, nameof(post), required: false);
            SourceExpression.Validate(tel, nameof(tel), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(fax, nameof(fax), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(mobileTel, nameof(mobileTel), required: false);
            SourceExpression.Validate(mobileEmail, nameof(mobileEmail), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(leadStatus, nameof(leadStatus), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            SourceExpression.Validate(leadSource, nameof(leadSource), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(errorMailFlg, nameof(errorMailFlg), required: false);
            SourceExpression.Validate(errorTelFlg, nameof(errorTelFlg), required: false);
            SourceExpression.Validate(errorFaxFlg, nameof(errorFaxFlg), required: false);
            SourceExpression.Validate(errorAddressFlg, nameof(errorAddressFlg), required: false);
            SourceExpression.Validate(notMailFlg, nameof(notMailFlg), required: false);
            SourceExpression.Validate(notTelFlg, nameof(notTelFlg), required: false);
            SourceExpression.Validate(notFaxFlg, nameof(notFaxFlg), required: false);
            SourceExpression.Validate(notDmFlg, nameof(notDmFlg), required: false);
            SourceExpression.Validate(competitorFlg, nameof(competitorFlg), required: false);
            SourceExpression.Validate(importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            SourceExpression.Validate(endUserFlg, nameof(endUserFlg), required: false);
            SourceExpression.Validate(storeFlg, nameof(storeFlg), required: false);
            SourceExpression.Validate(customerId, nameof(customerId), required: false);
            SourceExpression.Validate(ownerUserId, nameof(ownerUserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/leads/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["client_id"] = SourceExpressionConverter.ConvertO(clientId);
                callPayload.Queries["family_name"] = SourceExpressionConverter.ConvertO(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = SourceExpressionConverter.ConvertO(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = SourceExpressionConverter.ConvertO(firstNameKana);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = SourceExpressionConverter.ConvertO(organizationId);
                if (post != null)
                    callPayload.Queries["post"] = SourceExpressionConverter.ConvertO(post);
                if (tel != null)
                    callPayload.Queries["tel"] = SourceExpressionConverter.ConvertO(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = SourceExpressionConverter.ConvertO(fax);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = SourceExpressionConverter.ConvertO(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = SourceExpressionConverter.ConvertO(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (leadStatus != null)
                    callPayload.Queries["lead_status"] = SourceExpressionConverter.ConvertO(leadStatus);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = SourceExpressionConverter.ConvertO(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = SourceExpressionConverter.ConvertO(leadSource);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = SourceExpressionConverter.ConvertO(errorMailFlg);
                if (errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = SourceExpressionConverter.ConvertO(errorTelFlg);
                if (errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = SourceExpressionConverter.ConvertO(errorFaxFlg);
                if (errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = SourceExpressionConverter.ConvertO(errorAddressFlg);
                if (notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = SourceExpressionConverter.ConvertO(notMailFlg);
                if (notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = SourceExpressionConverter.ConvertO(notTelFlg);
                if (notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = SourceExpressionConverter.ConvertO(notFaxFlg);
                if (notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = SourceExpressionConverter.ConvertO(notDmFlg);
                if (competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = SourceExpressionConverter.ConvertO(competitorFlg);
                if (importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = SourceExpressionConverter.ConvertO(importantCustomerFlg);
                if (endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = SourceExpressionConverter.ConvertO(endUserFlg);
                if (storeFlg != null)
                    callPayload.Queries["store_flg"] = SourceExpressionConverter.ConvertO(storeFlg);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = SourceExpressionConverter.ConvertO(customerId);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = SourceExpressionConverter.ConvertO(ownerUserId);
                return callPayload;
            }

            return new ApiConnectionAction<ActionCreateLeadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionGetLeadsResponse> ActionGetLeads([WorkflowExpression] Func<string> searchFamilyName = null, [WorkflowExpression] Func<string> searchFirstName = null, [WorkflowExpression] Func<string> searchClientName = null, [WorkflowExpression] Func<int> searchFromId = null, [WorkflowExpression] Func<int> searchToId = null, [WorkflowExpression] Func<string> orderKey = null, [WorkflowExpression] Func<string> orderType = null, [WorkflowExpression] Func<int> pageDisplayNumber = null, [WorkflowExpression] Func<int> pageNumber = null, [WorkflowExpression] Func<int> pageDateFormatOption = null, [WorkflowExpression] Func<int> searchClientId = null, [WorkflowExpression] Func<string> searchClientNameKana = null, [WorkflowExpression] Func<string> searchClientNameDisp = null, [WorkflowExpression] Func<int> searchOwnerUserId = null, [WorkflowExpression] Func<int> searchRoleId = null, [WorkflowExpression] Func<int> searchOrganizationId = null, [WorkflowExpression] Func<string> searchOrganizationName = null, [WorkflowExpression] Func<string> searchOrganizationAncestryAllName = null, [WorkflowExpression] Func<string> searchPost = null, [WorkflowExpression] Func<string> searchFamilyNameKana = null, [WorkflowExpression] Func<string> searchFirstNameKana = null, [WorkflowExpression] Func<string> searchEmail = null, [WorkflowExpression] Func<string> searchMobileEmail = null, [WorkflowExpression] Func<string> searchTel = null, [WorkflowExpression] Func<string> searchExtension = null, [WorkflowExpression] Func<string> searchFax = null, [WorkflowExpression] Func<string> searchMobileTel = null, [WorkflowExpression] Func<string> searchZip = null, [WorkflowExpression] Func<string> searchPref = null, [WorkflowExpression] Func<string> searchAddress = null, [WorkflowExpression] Func<string> searchUrl = null, [WorkflowExpression] Func<string> searchFromCreatedOn = null, [WorkflowExpression] Func<string> searchToCreatedOn = null, [WorkflowExpression] Func<string> searchFromUpdatedOn = null, [WorkflowExpression] Func<string> searchToUpdatedOn = null, [WorkflowExpression] Func<string> searchFromDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchToDatetimeUpdatedOn = null, [WorkflowExpression] Func<string> searchFromTradeOn = null, [WorkflowExpression] Func<string> searchToTradeOn = null, [WorkflowExpression] Func<int> searchFromLatitude = null, [WorkflowExpression] Func<int> searchToLatitude = null, [WorkflowExpression] Func<int> searchFromLongitude = null, [WorkflowExpression] Func<int> searchToLongitude = null, [WorkflowExpression] Func<string> searchLatitude = null, [WorkflowExpression] Func<string> searchLongitude = null, [WorkflowExpression] Func<int> searchLeadStatus = null, [WorkflowExpression] Func<int> searchLeadSourceKbnIds = null, [WorkflowExpression] Func<string> searchLeadSource = null, [WorkflowExpression] Func<int> searchImportantCustomerFlg = null, [WorkflowExpression] Func<int> searchEndUserFlg = null, [WorkflowExpression] Func<int> searchStoreFlg = null, [WorkflowExpression] Func<int> searchCompetitorFlg = null, [WorkflowExpression] Func<int> searchErrorMailFlg = null, [WorkflowExpression] Func<int> searchErrorTelFlg = null, [WorkflowExpression] Func<int> searchErrorFaxFlg = null, [WorkflowExpression] Func<int> searchErrorAddressFlg = null, [WorkflowExpression] Func<int> searchNotMailFlg = null, [WorkflowExpression] Func<int> searchNotTelFlg = null, [WorkflowExpression] Func<int> searchNotFaxFlg = null, [WorkflowExpression] Func<int> searchNotDmFlg = null, [WorkflowExpression] Func<string> searchNote = null, [WorkflowExpression] Func<string> searchCustomerId = null, [WorkflowExpression] Func<string> searchName = null, [WorkflowExpression] Func<string> searchIds = null, [WorkflowExpression] Func<string> searchUserIds = null, [WorkflowExpression] Func<string> searchMultiple = null)
        {
            SourceExpression.Validate(searchFamilyName, nameof(searchFamilyName), required: false);
            SourceExpression.Validate(searchFirstName, nameof(searchFirstName), required: false);
            SourceExpression.Validate(searchClientName, nameof(searchClientName), required: false);
            SourceExpression.Validate(searchFromId, nameof(searchFromId), required: false);
            SourceExpression.Validate(searchToId, nameof(searchToId), required: false);
            SourceExpression.Validate(orderKey, nameof(orderKey), required: false);
            SourceExpression.Validate(orderType, nameof(orderType), required: false);
            SourceExpression.Validate(pageDisplayNumber, nameof(pageDisplayNumber), required: false);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: false);
            SourceExpression.Validate(pageDateFormatOption, nameof(pageDateFormatOption), required: false);
            SourceExpression.Validate(searchClientId, nameof(searchClientId), required: false);
            SourceExpression.Validate(searchClientNameKana, nameof(searchClientNameKana), required: false);
            SourceExpression.Validate(searchClientNameDisp, nameof(searchClientNameDisp), required: false);
            SourceExpression.Validate(searchOwnerUserId, nameof(searchOwnerUserId), required: false);
            SourceExpression.Validate(searchRoleId, nameof(searchRoleId), required: false);
            SourceExpression.Validate(searchOrganizationId, nameof(searchOrganizationId), required: false);
            SourceExpression.Validate(searchOrganizationName, nameof(searchOrganizationName), required: false);
            SourceExpression.Validate(searchOrganizationAncestryAllName, nameof(searchOrganizationAncestryAllName), required: false);
            SourceExpression.Validate(searchPost, nameof(searchPost), required: false);
            SourceExpression.Validate(searchFamilyNameKana, nameof(searchFamilyNameKana), required: false);
            SourceExpression.Validate(searchFirstNameKana, nameof(searchFirstNameKana), required: false);
            SourceExpression.Validate(searchEmail, nameof(searchEmail), required: false);
            SourceExpression.Validate(searchMobileEmail, nameof(searchMobileEmail), required: false);
            SourceExpression.Validate(searchTel, nameof(searchTel), required: false);
            SourceExpression.Validate(searchExtension, nameof(searchExtension), required: false);
            SourceExpression.Validate(searchFax, nameof(searchFax), required: false);
            SourceExpression.Validate(searchMobileTel, nameof(searchMobileTel), required: false);
            SourceExpression.Validate(searchZip, nameof(searchZip), required: false);
            SourceExpression.Validate(searchPref, nameof(searchPref), required: false);
            SourceExpression.Validate(searchAddress, nameof(searchAddress), required: false);
            SourceExpression.Validate(searchUrl, nameof(searchUrl), required: false);
            SourceExpression.Validate(searchFromCreatedOn, nameof(searchFromCreatedOn), required: false);
            SourceExpression.Validate(searchToCreatedOn, nameof(searchToCreatedOn), required: false);
            SourceExpression.Validate(searchFromUpdatedOn, nameof(searchFromUpdatedOn), required: false);
            SourceExpression.Validate(searchToUpdatedOn, nameof(searchToUpdatedOn), required: false);
            SourceExpression.Validate(searchFromDatetimeUpdatedOn, nameof(searchFromDatetimeUpdatedOn), required: false);
            SourceExpression.Validate(searchToDatetimeUpdatedOn, nameof(searchToDatetimeUpdatedOn), required: false);
            SourceExpression.Validate(searchFromTradeOn, nameof(searchFromTradeOn), required: false);
            SourceExpression.Validate(searchToTradeOn, nameof(searchToTradeOn), required: false);
            SourceExpression.Validate(searchFromLatitude, nameof(searchFromLatitude), required: false);
            SourceExpression.Validate(searchToLatitude, nameof(searchToLatitude), required: false);
            SourceExpression.Validate(searchFromLongitude, nameof(searchFromLongitude), required: false);
            SourceExpression.Validate(searchToLongitude, nameof(searchToLongitude), required: false);
            SourceExpression.Validate(searchLatitude, nameof(searchLatitude), required: false);
            SourceExpression.Validate(searchLongitude, nameof(searchLongitude), required: false);
            SourceExpression.Validate(searchLeadStatus, nameof(searchLeadStatus), required: false);
            SourceExpression.Validate(searchLeadSourceKbnIds, nameof(searchLeadSourceKbnIds), required: false);
            SourceExpression.Validate(searchLeadSource, nameof(searchLeadSource), required: false);
            SourceExpression.Validate(searchImportantCustomerFlg, nameof(searchImportantCustomerFlg), required: false);
            SourceExpression.Validate(searchEndUserFlg, nameof(searchEndUserFlg), required: false);
            SourceExpression.Validate(searchStoreFlg, nameof(searchStoreFlg), required: false);
            SourceExpression.Validate(searchCompetitorFlg, nameof(searchCompetitorFlg), required: false);
            SourceExpression.Validate(searchErrorMailFlg, nameof(searchErrorMailFlg), required: false);
            SourceExpression.Validate(searchErrorTelFlg, nameof(searchErrorTelFlg), required: false);
            SourceExpression.Validate(searchErrorFaxFlg, nameof(searchErrorFaxFlg), required: false);
            SourceExpression.Validate(searchErrorAddressFlg, nameof(searchErrorAddressFlg), required: false);
            SourceExpression.Validate(searchNotMailFlg, nameof(searchNotMailFlg), required: false);
            SourceExpression.Validate(searchNotTelFlg, nameof(searchNotTelFlg), required: false);
            SourceExpression.Validate(searchNotFaxFlg, nameof(searchNotFaxFlg), required: false);
            SourceExpression.Validate(searchNotDmFlg, nameof(searchNotDmFlg), required: false);
            SourceExpression.Validate(searchNote, nameof(searchNote), required: false);
            SourceExpression.Validate(searchCustomerId, nameof(searchCustomerId), required: false);
            SourceExpression.Validate(searchName, nameof(searchName), required: false);
            SourceExpression.Validate(searchIds, nameof(searchIds), required: false);
            SourceExpression.Validate(searchUserIds, nameof(searchUserIds), required: false);
            SourceExpression.Validate(searchMultiple, nameof(searchMultiple), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/leads/get_entry_list_flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (searchFamilyName != null)
                    callPayload.Queries["search[family_name]"] = SourceExpressionConverter.ConvertO(searchFamilyName);
                if (searchFirstName != null)
                    callPayload.Queries["search[first_name]"] = SourceExpressionConverter.ConvertO(searchFirstName);
                if (searchClientName != null)
                    callPayload.Queries["search[client_name]"] = SourceExpressionConverter.ConvertO(searchClientName);
                if (searchFromId != null)
                    callPayload.Queries["search[from_id]"] = SourceExpressionConverter.ConvertO(searchFromId);
                if (searchToId != null)
                    callPayload.Queries["search[to_id]"] = SourceExpressionConverter.ConvertO(searchToId);
                if (orderKey != null)
                    callPayload.Queries["order[key]"] = SourceExpressionConverter.ConvertO(orderKey);
                if (orderType != null)
                    callPayload.Queries["order[type]"] = SourceExpressionConverter.ConvertO(orderType);
                if (pageDisplayNumber != null)
                    callPayload.Queries["page[display_number]"] = SourceExpressionConverter.ConvertO(pageDisplayNumber);
                if (pageNumber != null)
                    callPayload.Queries["page[number]"] = SourceExpressionConverter.ConvertO(pageNumber);
                if (pageDateFormatOption != null)
                    callPayload.Queries["page[date_format_option]"] = SourceExpressionConverter.ConvertO(pageDateFormatOption);
                if (searchClientId != null)
                    callPayload.Queries["search[client_id]"] = SourceExpressionConverter.ConvertO(searchClientId);
                if (searchClientNameKana != null)
                    callPayload.Queries["search[client][name_kana]"] = SourceExpressionConverter.ConvertO(searchClientNameKana);
                if (searchClientNameDisp != null)
                    callPayload.Queries["search[client][name_disp]"] = SourceExpressionConverter.ConvertO(searchClientNameDisp);
                if (searchOwnerUserId != null)
                    callPayload.Queries["search[owner_user_id]"] = SourceExpressionConverter.ConvertO(searchOwnerUserId);
                if (searchRoleId != null)
                    callPayload.Queries["search[role_id]"] = SourceExpressionConverter.ConvertO(searchRoleId);
                if (searchOrganizationId != null)
                    callPayload.Queries["search[organization_id]"] = SourceExpressionConverter.ConvertO(searchOrganizationId);
                if (searchOrganizationName != null)
                    callPayload.Queries["search[organization_name]"] = SourceExpressionConverter.ConvertO(searchOrganizationName);
                if (searchOrganizationAncestryAllName != null)
                    callPayload.Queries["search[organization_ancestry_all_name]"] = SourceExpressionConverter.ConvertO(searchOrganizationAncestryAllName);
                if (searchPost != null)
                    callPayload.Queries["search[post]"] = SourceExpressionConverter.ConvertO(searchPost);
                if (searchFamilyNameKana != null)
                    callPayload.Queries["search[family_name_kana]"] = SourceExpressionConverter.ConvertO(searchFamilyNameKana);
                if (searchFirstNameKana != null)
                    callPayload.Queries["search[first_name_kana]"] = SourceExpressionConverter.ConvertO(searchFirstNameKana);
                if (searchEmail != null)
                    callPayload.Queries["search[email]"] = SourceExpressionConverter.ConvertO(searchEmail);
                if (searchMobileEmail != null)
                    callPayload.Queries["search[mobile_email]"] = SourceExpressionConverter.ConvertO(searchMobileEmail);
                if (searchTel != null)
                    callPayload.Queries["search[tel]"] = SourceExpressionConverter.ConvertO(searchTel);
                if (searchExtension != null)
                    callPayload.Queries["search[extension]"] = SourceExpressionConverter.ConvertO(searchExtension);
                if (searchFax != null)
                    callPayload.Queries["search[fax]"] = SourceExpressionConverter.ConvertO(searchFax);
                if (searchMobileTel != null)
                    callPayload.Queries["search[mobile_tel]"] = SourceExpressionConverter.ConvertO(searchMobileTel);
                if (searchZip != null)
                    callPayload.Queries["search[zip]"] = SourceExpressionConverter.ConvertO(searchZip);
                if (searchPref != null)
                    callPayload.Queries["search[pref]"] = SourceExpressionConverter.ConvertO(searchPref);
                if (searchAddress != null)
                    callPayload.Queries["search[address]"] = SourceExpressionConverter.ConvertO(searchAddress);
                if (searchUrl != null)
                    callPayload.Queries["search[url]"] = SourceExpressionConverter.ConvertO(searchUrl);
                if (searchFromCreatedOn != null)
                    callPayload.Queries["search[from_created_on]"] = SourceExpressionConverter.ConvertO(searchFromCreatedOn);
                if (searchToCreatedOn != null)
                    callPayload.Queries["search[to_created_on]"] = SourceExpressionConverter.ConvertO(searchToCreatedOn);
                if (searchFromUpdatedOn != null)
                    callPayload.Queries["search[from_updated_on]"] = SourceExpressionConverter.ConvertO(searchFromUpdatedOn);
                if (searchToUpdatedOn != null)
                    callPayload.Queries["search[to_updated_on]"] = SourceExpressionConverter.ConvertO(searchToUpdatedOn);
                if (searchFromDatetimeUpdatedOn != null)
                    callPayload.Queries["search[from_datetime_updated_on]"] = SourceExpressionConverter.ConvertO(searchFromDatetimeUpdatedOn);
                if (searchToDatetimeUpdatedOn != null)
                    callPayload.Queries["search[to_datetime_updated_on]"] = SourceExpressionConverter.ConvertO(searchToDatetimeUpdatedOn);
                if (searchFromTradeOn != null)
                    callPayload.Queries["search[from_trade_on]"] = SourceExpressionConverter.ConvertO(searchFromTradeOn);
                if (searchToTradeOn != null)
                    callPayload.Queries["search[to_trade_on]"] = SourceExpressionConverter.ConvertO(searchToTradeOn);
                if (searchFromLatitude != null)
                    callPayload.Queries["search[from_latitude]"] = SourceExpressionConverter.ConvertO(searchFromLatitude);
                if (searchToLatitude != null)
                    callPayload.Queries["search[to_latitude]"] = SourceExpressionConverter.ConvertO(searchToLatitude);
                if (searchFromLongitude != null)
                    callPayload.Queries["search[from_longitude]"] = SourceExpressionConverter.ConvertO(searchFromLongitude);
                if (searchToLongitude != null)
                    callPayload.Queries["search[to_longitude]"] = SourceExpressionConverter.ConvertO(searchToLongitude);
                if (searchLatitude != null)
                    callPayload.Queries["search[latitude]"] = SourceExpressionConverter.ConvertO(searchLatitude);
                if (searchLongitude != null)
                    callPayload.Queries["search[longitude]"] = SourceExpressionConverter.ConvertO(searchLongitude);
                if (searchLeadStatus != null)
                    callPayload.Queries["search[lead_status]"] = SourceExpressionConverter.ConvertO(searchLeadStatus);
                if (searchLeadSourceKbnIds != null)
                    callPayload.Queries["search[lead_source_kbn_ids]"] = SourceExpressionConverter.ConvertO(searchLeadSourceKbnIds);
                if (searchLeadSource != null)
                    callPayload.Queries["search[lead_source]"] = SourceExpressionConverter.ConvertO(searchLeadSource);
                if (searchImportantCustomerFlg != null)
                    callPayload.Queries["search[important_customer_flg]"] = SourceExpressionConverter.ConvertO(searchImportantCustomerFlg);
                if (searchEndUserFlg != null)
                    callPayload.Queries["search[end_user_flg]"] = SourceExpressionConverter.ConvertO(searchEndUserFlg);
                if (searchStoreFlg != null)
                    callPayload.Queries["search[store_flg]"] = SourceExpressionConverter.ConvertO(searchStoreFlg);
                if (searchCompetitorFlg != null)
                    callPayload.Queries["search[competitor_flg]"] = SourceExpressionConverter.ConvertO(searchCompetitorFlg);
                if (searchErrorMailFlg != null)
                    callPayload.Queries["search[error_mail_flg]"] = SourceExpressionConverter.ConvertO(searchErrorMailFlg);
                if (searchErrorTelFlg != null)
                    callPayload.Queries["search[error_tel_flg]"] = SourceExpressionConverter.ConvertO(searchErrorTelFlg);
                if (searchErrorFaxFlg != null)
                    callPayload.Queries["search[error_fax_flg]"] = SourceExpressionConverter.ConvertO(searchErrorFaxFlg);
                if (searchErrorAddressFlg != null)
                    callPayload.Queries["search[error_address_flg]"] = SourceExpressionConverter.ConvertO(searchErrorAddressFlg);
                if (searchNotMailFlg != null)
                    callPayload.Queries["search[not_mail_flg]"] = SourceExpressionConverter.ConvertO(searchNotMailFlg);
                if (searchNotTelFlg != null)
                    callPayload.Queries["search[not_tel_flg]"] = SourceExpressionConverter.ConvertO(searchNotTelFlg);
                if (searchNotFaxFlg != null)
                    callPayload.Queries["search[not_fax_flg]"] = SourceExpressionConverter.ConvertO(searchNotFaxFlg);
                if (searchNotDmFlg != null)
                    callPayload.Queries["search[not_dm_flg]"] = SourceExpressionConverter.ConvertO(searchNotDmFlg);
                if (searchNote != null)
                    callPayload.Queries["search[note]"] = SourceExpressionConverter.ConvertO(searchNote);
                if (searchCustomerId != null)
                    callPayload.Queries["search[customer_id]"] = SourceExpressionConverter.ConvertO(searchCustomerId);
                if (searchName != null)
                    callPayload.Queries["search[name]"] = SourceExpressionConverter.ConvertO(searchName);
                if (searchIds != null)
                    callPayload.Queries["search[ids]"] = SourceExpressionConverter.ConvertO(searchIds);
                if (searchUserIds != null)
                    callPayload.Queries["search[user_ids]"] = SourceExpressionConverter.ConvertO(searchUserIds);
                if (searchMultiple != null)
                    callPayload.Queries["search[multiple]"] = SourceExpressionConverter.ConvertO(searchMultiple);
                return callPayload;
            }

            return new ApiConnectionAction<ActionGetLeadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hotprofile")]
        public IBodyWorkflowAction<ActionUpdateLeadResponse> ActionUpdateLead([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<int> organizationId = null, [WorkflowExpression] Func<string> post = null, [WorkflowExpression] Func<string> familyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> familyNameKana = null, [WorkflowExpression] Func<string> firstNameKana = null, [WorkflowExpression] Func<string> tel = null, [WorkflowExpression] Func<int> extension = null, [WorkflowExpression] Func<string> fax = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> mobileTel = null, [WorkflowExpression] Func<string> mobileEmail = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<int> prefId = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<int> leadStatus = null, [WorkflowExpression] Func<int> latitude = null, [WorkflowExpression] Func<int> longitude = null, [WorkflowExpression] Func<int> leadSourceKbnId = null, [WorkflowExpression] Func<string> leadSource = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<bool> errorMailFlg = null, [WorkflowExpression] Func<bool> errorTelFlg = null, [WorkflowExpression] Func<bool> errorFaxFlg = null, [WorkflowExpression] Func<bool> errorAddressFlg = null, [WorkflowExpression] Func<bool> notMailFlg = null, [WorkflowExpression] Func<bool> notTelFlg = null, [WorkflowExpression] Func<bool> notFaxFlg = null, [WorkflowExpression] Func<bool> notDmFlg = null, [WorkflowExpression] Func<bool> competitorFlg = null, [WorkflowExpression] Func<bool> importantCustomerFlg = null, [WorkflowExpression] Func<bool> endUserFlg = null, [WorkflowExpression] Func<bool> storeFlg = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> ownerUserId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(organizationId, nameof(organizationId), required: false);
            SourceExpression.Validate(post, nameof(post), required: false);
            SourceExpression.Validate(familyName, nameof(familyName), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(familyNameKana, nameof(familyNameKana), required: false);
            SourceExpression.Validate(firstNameKana, nameof(firstNameKana), required: false);
            SourceExpression.Validate(tel, nameof(tel), required: false);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(fax, nameof(fax), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(mobileTel, nameof(mobileTel), required: false);
            SourceExpression.Validate(mobileEmail, nameof(mobileEmail), required: false);
            SourceExpression.Validate(zip, nameof(zip), required: false);
            SourceExpression.Validate(prefId, nameof(prefId), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(leadStatus, nameof(leadStatus), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(leadSourceKbnId, nameof(leadSourceKbnId), required: false);
            SourceExpression.Validate(leadSource, nameof(leadSource), required: false);
            SourceExpression.Validate(note, nameof(note), required: false);
            SourceExpression.Validate(errorMailFlg, nameof(errorMailFlg), required: false);
            SourceExpression.Validate(errorTelFlg, nameof(errorTelFlg), required: false);
            SourceExpression.Validate(errorFaxFlg, nameof(errorFaxFlg), required: false);
            SourceExpression.Validate(errorAddressFlg, nameof(errorAddressFlg), required: false);
            SourceExpression.Validate(notMailFlg, nameof(notMailFlg), required: false);
            SourceExpression.Validate(notTelFlg, nameof(notTelFlg), required: false);
            SourceExpression.Validate(notFaxFlg, nameof(notFaxFlg), required: false);
            SourceExpression.Validate(notDmFlg, nameof(notDmFlg), required: false);
            SourceExpression.Validate(competitorFlg, nameof(competitorFlg), required: false);
            SourceExpression.Validate(importantCustomerFlg, nameof(importantCustomerFlg), required: false);
            SourceExpression.Validate(endUserFlg, nameof(endUserFlg), required: false);
            SourceExpression.Validate(storeFlg, nameof(storeFlg), required: false);
            SourceExpression.Validate(customerId, nameof(customerId), required: false);
            SourceExpression.Validate(ownerUserId, nameof(ownerUserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest_api/v1/leads/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["client_id"] = SourceExpressionConverter.ConvertO(clientId);
                if (organizationId != null)
                    callPayload.Queries["organization_id"] = SourceExpressionConverter.ConvertO(organizationId);
                if (post != null)
                    callPayload.Queries["post"] = SourceExpressionConverter.ConvertO(post);
                if (familyName != null)
                    callPayload.Queries["family_name"] = SourceExpressionConverter.ConvertO(familyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (familyNameKana != null)
                    callPayload.Queries["family_name_kana"] = SourceExpressionConverter.ConvertO(familyNameKana);
                if (firstNameKana != null)
                    callPayload.Queries["first_name_kana"] = SourceExpressionConverter.ConvertO(firstNameKana);
                if (tel != null)
                    callPayload.Queries["tel"] = SourceExpressionConverter.ConvertO(tel);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                if (fax != null)
                    callPayload.Queries["fax"] = SourceExpressionConverter.ConvertO(fax);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (mobileTel != null)
                    callPayload.Queries["mobile_tel"] = SourceExpressionConverter.ConvertO(mobileTel);
                if (mobileEmail != null)
                    callPayload.Queries["mobile_email"] = SourceExpressionConverter.ConvertO(mobileEmail);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (prefId != null)
                    callPayload.Queries["pref_id"] = SourceExpressionConverter.ConvertO(prefId);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (leadStatus != null)
                    callPayload.Queries["lead_status"] = SourceExpressionConverter.ConvertO(leadStatus);
                if (latitude != null)
                    callPayload.Queries["latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (leadSourceKbnId != null)
                    callPayload.Queries["lead_source_kbn_id"] = SourceExpressionConverter.ConvertO(leadSourceKbnId);
                if (leadSource != null)
                    callPayload.Queries["lead_source"] = SourceExpressionConverter.ConvertO(leadSource);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (errorMailFlg != null)
                    callPayload.Queries["error_mail_flg"] = SourceExpressionConverter.ConvertO(errorMailFlg);
                if (errorTelFlg != null)
                    callPayload.Queries["error_tel_flg"] = SourceExpressionConverter.ConvertO(errorTelFlg);
                if (errorFaxFlg != null)
                    callPayload.Queries["error_fax_flg"] = SourceExpressionConverter.ConvertO(errorFaxFlg);
                if (errorAddressFlg != null)
                    callPayload.Queries["error_address_flg"] = SourceExpressionConverter.ConvertO(errorAddressFlg);
                if (notMailFlg != null)
                    callPayload.Queries["not_mail_flg"] = SourceExpressionConverter.ConvertO(notMailFlg);
                if (notTelFlg != null)
                    callPayload.Queries["not_tel_flg"] = SourceExpressionConverter.ConvertO(notTelFlg);
                if (notFaxFlg != null)
                    callPayload.Queries["not_fax_flg"] = SourceExpressionConverter.ConvertO(notFaxFlg);
                if (notDmFlg != null)
                    callPayload.Queries["not_dm_flg"] = SourceExpressionConverter.ConvertO(notDmFlg);
                if (competitorFlg != null)
                    callPayload.Queries["competitor_flg"] = SourceExpressionConverter.ConvertO(competitorFlg);
                if (importantCustomerFlg != null)
                    callPayload.Queries["important_customer_flg"] = SourceExpressionConverter.ConvertO(importantCustomerFlg);
                if (endUserFlg != null)
                    callPayload.Queries["end_user_flg"] = SourceExpressionConverter.ConvertO(endUserFlg);
                if (storeFlg != null)
                    callPayload.Queries["store_flg"] = SourceExpressionConverter.ConvertO(storeFlg);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = SourceExpressionConverter.ConvertO(customerId);
                if (ownerUserId != null)
                    callPayload.Queries["owner_user_id"] = SourceExpressionConverter.ConvertO(ownerUserId);
                return callPayload;
            }

            return new ApiConnectionAction<ActionUpdateLeadResponse>(BuildSourceInput);
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