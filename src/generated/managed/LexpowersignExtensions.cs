//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lexpowersign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LexpowersignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<ConsentPage> RetrieveConsentPage(Expression<Func<string>> cpId, Expression<Func<string>> contentType)
        {
            var apiCallPath = String.Format("/api/consentPages/{0}", ExpressionConverter.ConvertWithUrlEncoding(cpId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<ConsentPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<ConsentPages> SearchConsentPages(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDefault = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsStepType = null, Expression<Func<string>> itemsClientId = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var apiCallPath = "/api/consentPages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsIsDefault != null)
                callPayload.Queries["items.isDefault"] = ExpressionConverter.Convert(itemsIsDefault);
            if (itemsIsDisabled != null)
                callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(itemsIsDisabled);
            if (itemsName != null)
                callPayload.Queries["items.name"] = ExpressionConverter.Convert(itemsName);
            if (itemsStepType != null)
                callPayload.Queries["items.stepType"] = ExpressionConverter.Convert(itemsStepType);
            if (itemsClientId != null)
                callPayload.Queries["items.clientId"] = ExpressionConverter.Convert(itemsClientId);
            if (itemsCreated != null)
                callPayload.Queries["items.created"] = ExpressionConverter.Convert(itemsCreated);
            if (itemsUpdated != null)
                callPayload.Queries["items.updated"] = ExpressionConverter.Convert(itemsUpdated);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortOrder != null)
                callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            return new ApiConnectionAction<ConsentPages>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact> CreateContact(Expression<Func<string>> userId, Expression<Func<string>> contentType, Expression<Func<string>> bodycontactEmail, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodycontactLastName, Expression<Func<string>> bodycontatctPhoneNumber = null, Expression<Func<string>> bodycontactCountry = null)
        {
            var apiCallPath = String.Format("/api/users/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodycontactEmail);
            if (bodycontatctPhoneNumber != null)
            {
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodycontatctPhoneNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["firstName"] = ExpressionConverter.ConvertO(bodycontactFirstName);
            bodypropCount++;
            body["lastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
            if (bodycontactCountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycontactCountry);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact> RetrieveContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType)
        {
            var apiCallPath = String.Format("/api/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact> DeleteContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType)
        {
            var apiCallPath = String.Format("/api/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contact> UpdateContact(Expression<Func<string>> contactId, Expression<Func<string>> contentType, Expression<Func<string>> bodyemailOfTheContact = null, Expression<Func<string>> bodyphoneNumberOfTheContact = null, Expression<Func<string>> bodyfirstNameOfTheContact = null, Expression<Func<string>> bodylastNameOfTheContact = null, Expression<Func<string>> bodycountryOfTheContact = null)
        {
            var apiCallPath = String.Format("/api/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemailOfTheContact != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemailOfTheContact);
                bodypropCount++;
            }

            if (bodyphoneNumberOfTheContact != null)
            {
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumberOfTheContact);
                bodypropCount++;
            }

            if (bodyfirstNameOfTheContact != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstNameOfTheContact);
                bodypropCount++;
            }

            if (bodylastNameOfTheContact != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastNameOfTheContact);
                bodypropCount++;
            }

            if (bodycountryOfTheContact != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountryOfTheContact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Contact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Contacts> SearchContacts(Expression<Func<string>> text = null, Expression<Func<string>> itemsEmail = null, Expression<Func<string>> itemsPhoneNumber = null, Expression<Func<string>> itemsFisrtName = null, Expression<Func<string>> itemsLastName = null, Expression<Func<string>> itemsCountry = null, Expression<Func<double>> itemsPerPage = null, Expression<Func<double>> pageIndex = null)
        {
            var apiCallPath = "/api/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsEmail != null)
                callPayload.Queries["items.email"] = ExpressionConverter.Convert(itemsEmail);
            if (itemsPhoneNumber != null)
                callPayload.Queries["items.phoneNumber"] = ExpressionConverter.Convert(itemsPhoneNumber);
            if (itemsFisrtName != null)
                callPayload.Queries["items.fisrtName"] = ExpressionConverter.Convert(itemsFisrtName);
            if (itemsLastName != null)
                callPayload.Queries["items.lastName"] = ExpressionConverter.Convert(itemsLastName);
            if (itemsCountry != null)
                callPayload.Queries["items.country"] = ExpressionConverter.Convert(itemsCountry);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            return new ApiConnectionAction<Contacts>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<DataMapping> GetDataMapping(Expression<Func<string>> tenantId)
        {
            var apiCallPath = String.Format("/api/tenants/{0}/dataMapping", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataMapping>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile> CreateSignatureProfile(Expression<Func<string>> tenantId, Expression<Func<string>> contentType, Expression<Func<string>> bodyisDefault, Expression<Func<string>> bodyname, Expression<Func<string>> bodydocumentType, Expression<Func<string>> bodysignatureType, Expression<Func<bool>> bodyforceToScrollToTheBottomOfTheDocument, Expression<Func<string>> bodyisDisabled = null, Expression<Func<string>> bodyvisibleSignatureMode = null, Expression<Func<string>> bodysignatureText = null, Expression<Func<string>> bodysignatureTextColor = null, Expression<Func<double>> bodysignatureTextSize = null)
        {
            var apiCallPath = String.Format("/api/tenants/{0}/signatureProfiles", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["isDefault"] = ExpressionConverter.ConvertO(bodyisDefault);
            if (bodyisDisabled != null)
            {
                body["isDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["documentType"] = ExpressionConverter.ConvertO(bodydocumentType);
            bodypropCount++;
            body["signatureType"] = ExpressionConverter.ConvertO(bodysignatureType);
            bodypropCount++;
            body["forceScrollDocument"] = ExpressionConverter.ConvertO(bodyforceToScrollToTheBottomOfTheDocument);
            if (bodyvisibleSignatureMode != null)
            {
                body["pdfVisibleSignatureMode"] = ExpressionConverter.ConvertO(bodyvisibleSignatureMode);
                bodypropCount++;
            }

            if (bodysignatureText != null)
            {
                body["pdfSignatureImageText"] = ExpressionConverter.ConvertO(bodysignatureText);
                bodypropCount++;
            }

            if (bodysignatureTextColor != null)
            {
                body["pdfSignatureImageTextColor"] = ExpressionConverter.ConvertO(bodysignatureTextColor);
                bodypropCount++;
            }

            if (bodysignatureTextSize != null)
            {
                body["pdfSignatureImageTextSize"] = ExpressionConverter.ConvertO(bodysignatureTextSize);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignatureProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile> RetrieveSignatureProfile(Expression<Func<string>> spId)
        {
            var apiCallPath = String.Format("/api/signatureProfiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(spId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignatureProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfile> UpdateSignatureProfile(Expression<Func<string>> spId, Expression<Func<string>> contentType, Expression<Func<string>> bodyisDefault = null, Expression<Func<string>> bodyisDisabled = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysignatureType = null, Expression<Func<bool>> bodyforceToScrollToTheBottomOfTheDocument = null, Expression<Func<string>> bodyvisibleSignatureMode = null, Expression<Func<string>> bodysignatureText = null, Expression<Func<string>> bodysignatureTextColor = null, Expression<Func<double>> bodysignatureTextSize = null)
        {
            var apiCallPath = String.Format("/api/signatureProfiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(spId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyisDefault != null)
            {
                body["isDefault"] = ExpressionConverter.ConvertO(bodyisDefault);
                bodypropCount++;
            }

            if (bodyisDisabled != null)
            {
                body["isDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodysignatureType != null)
            {
                body["signatureType"] = ExpressionConverter.ConvertO(bodysignatureType);
                bodypropCount++;
            }

            if (bodyforceToScrollToTheBottomOfTheDocument != null)
            {
                body["forceScrollDocument"] = ExpressionConverter.ConvertO(bodyforceToScrollToTheBottomOfTheDocument);
                bodypropCount++;
            }

            if (bodyvisibleSignatureMode != null)
            {
                body["pdfVisibleSignatureMode"] = ExpressionConverter.ConvertO(bodyvisibleSignatureMode);
                bodypropCount++;
            }

            if (bodysignatureText != null)
            {
                body["pdfSignatureImageText"] = ExpressionConverter.ConvertO(bodysignatureText);
                bodypropCount++;
            }

            if (bodysignatureTextColor != null)
            {
                body["pdfSignatureImageTextColor"] = ExpressionConverter.ConvertO(bodysignatureTextColor);
                bodypropCount++;
            }

            if (bodysignatureTextSize != null)
            {
                body["pdfSignatureImageTextSize"] = ExpressionConverter.ConvertO(bodysignatureTextSize);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignatureProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SignatureProfiles> SearchSignatureProfiles(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDefault = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsDocumentType = null, Expression<Func<string>> itemsSignatureType = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var apiCallPath = "/api/signatureProfiles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsIsDefault != null)
                callPayload.Queries["items.isDefault"] = ExpressionConverter.Convert(itemsIsDefault);
            if (itemsIsDisabled != null)
                callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(itemsIsDisabled);
            if (itemsName != null)
                callPayload.Queries["items.name"] = ExpressionConverter.Convert(itemsName);
            if (itemsDocumentType != null)
                callPayload.Queries["items.documentType"] = ExpressionConverter.Convert(itemsDocumentType);
            if (itemsSignatureType != null)
                callPayload.Queries["items.signatureType"] = ExpressionConverter.Convert(itemsSignatureType);
            if (itemsCreated != null)
                callPayload.Queries["items.created"] = ExpressionConverter.Convert(itemsCreated);
            if (itemsUpdated != null)
                callPayload.Queries["items.updated"] = ExpressionConverter.Convert(itemsUpdated);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortOrder != null)
                callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            return new ApiConnectionAction<SignatureProfiles>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<User> RetrieveMe()
        {
            var apiCallPath = "/api/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow> CreateWorkflow(Expression<Func<string>> userId, Expression<Func<string>> bodyname, Expression<Func<string>> contentType = null, Expression<Func<string>> bodydescription = null, Expression<Func<Step[]>> bodysteps = null, Expression<Func<string[]>> bodynotifiedEvents = null, Expression<Func<bodywatchersInputItem[]>> bodywatchers = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodylayoutId = null, Expression<Func<string>> bodydata1 = null, Expression<Func<string>> bodydata2 = null, Expression<Func<string>> bodydata3 = null, Expression<Func<string>> bodydata4 = null, Expression<Func<string>> bodydata5 = null, Expression<Func<string>> bodydata6 = null, Expression<Func<string>> bodydata7 = null, Expression<Func<string>> bodydata8 = null)
        {
            var apiCallPath = String.Format("/api/users/{0}/workflows", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodynotifiedEvents != null)
            {
                body["notifiedEvents"] = ExpressionConverter.ConvertO(bodynotifiedEvents);
                bodypropCount++;
            }

            if (bodywatchers != null)
            {
                body["watchers"] = ExpressionConverter.ConvertO(bodywatchers);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodylayoutId != null)
            {
                body["layoutId"] = ExpressionConverter.ConvertO(bodylayoutId);
                bodypropCount++;
            }

            if (bodydata1 != null)
            {
                body["data1"] = ExpressionConverter.ConvertO(bodydata1);
                bodypropCount++;
            }

            if (bodydata2 != null)
            {
                body["data2"] = ExpressionConverter.ConvertO(bodydata2);
                bodypropCount++;
            }

            if (bodydata3 != null)
            {
                body["data3"] = ExpressionConverter.ConvertO(bodydata3);
                bodypropCount++;
            }

            if (bodydata4 != null)
            {
                body["data4"] = ExpressionConverter.ConvertO(bodydata4);
                bodypropCount++;
            }

            if (bodydata5 != null)
            {
                body["data5"] = ExpressionConverter.ConvertO(bodydata5);
                bodypropCount++;
            }

            if (bodydata6 != null)
            {
                body["data6"] = ExpressionConverter.ConvertO(bodydata6);
                bodypropCount++;
            }

            if (bodydata7 != null)
            {
                body["data7"] = ExpressionConverter.ConvertO(bodydata7);
                bodypropCount++;
            }

            if (bodydata8 != null)
            {
                body["data8"] = ExpressionConverter.ConvertO(bodydata8);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Workflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow> RetrieveWorkflow(Expression<Func<string>> workflowId)
        {
            var apiCallPath = String.Format("/api/workflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Workflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow> DeleteWorkflow(Expression<Func<string>> workflowId)
        {
            var apiCallPath = String.Format("/api/workflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Workflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflow> UpdateWorkflow(Expression<Func<string>> workflowId, Expression<Func<string>> contentType = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<Step[]>> bodysteps = null, Expression<Func<string[]>> bodynotifiedEvents = null, Expression<Func<bodywatchersInputItem[]>> bodywatchers = null, Expression<Func<string>> bodyworkflowStatus = null, Expression<Func<string>> bodydata1 = null, Expression<Func<string>> bodydata2 = null, Expression<Func<string>> bodydata3 = null, Expression<Func<string>> bodydata4 = null, Expression<Func<string>> bodydata5 = null, Expression<Func<string>> bodydata6 = null, Expression<Func<string>> bodydata7 = null, Expression<Func<string>> bodydata8 = null)
        {
            var apiCallPath = String.Format("/api/workflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodynotifiedEvents != null)
            {
                body["notifiedEvents"] = ExpressionConverter.ConvertO(bodynotifiedEvents);
                bodypropCount++;
            }

            if (bodywatchers != null)
            {
                body["watchers"] = ExpressionConverter.ConvertO(bodywatchers);
                bodypropCount++;
            }

            if (bodyworkflowStatus != null)
            {
                body["workflowStatus"] = ExpressionConverter.ConvertO(bodyworkflowStatus);
                bodypropCount++;
            }

            if (bodydata1 != null)
            {
                body["data1"] = ExpressionConverter.ConvertO(bodydata1);
                bodypropCount++;
            }

            if (bodydata2 != null)
            {
                body["data2"] = ExpressionConverter.ConvertO(bodydata2);
                bodypropCount++;
            }

            if (bodydata3 != null)
            {
                body["data3"] = ExpressionConverter.ConvertO(bodydata3);
                bodypropCount++;
            }

            if (bodydata4 != null)
            {
                body["data4"] = ExpressionConverter.ConvertO(bodydata4);
                bodypropCount++;
            }

            if (bodydata5 != null)
            {
                body["data5"] = ExpressionConverter.ConvertO(bodydata5);
                bodypropCount++;
            }

            if (bodydata6 != null)
            {
                body["data6"] = ExpressionConverter.ConvertO(bodydata6);
                bodypropCount++;
            }

            if (bodydata7 != null)
            {
                body["data7"] = ExpressionConverter.ConvertO(bodydata7);
                bodypropCount++;
            }

            if (bodydata8 != null)
            {
                body["data8"] = ExpressionConverter.ConvertO(bodydata8);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Workflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Workflows> SearchWorkflows(Expression<Func<string>> accept = null, Expression<Func<string>> text = null, Expression<Func<string>> itemsLayoutId = null, Expression<Func<string>> itemsTemplateId = null, Expression<Func<string>> itemsGroupId = null, Expression<Func<string>> itemsUserId = null, Expression<Func<string>> itemsEmail = null, Expression<Func<string>> itemsFirstname = null, Expression<Func<string>> itemsLastname = null, Expression<Func<string>> itemsWorkflowStatus = null, Expression<Func<string>> itemsData1 = null, Expression<Func<string>> itemsData2 = null, Expression<Func<string>> itemsData3 = null, Expression<Func<string>> itemsData4 = null, Expression<Func<string>> itemsData5 = null, Expression<Func<string>> itemsData6 = null, Expression<Func<string>> itemsData7 = null, Expression<Func<string>> itemsData8 = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> itemsStarted = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var apiCallPath = "/api/workflows";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsLayoutId != null)
                callPayload.Queries["items.layoutId"] = ExpressionConverter.Convert(itemsLayoutId);
            if (itemsTemplateId != null)
                callPayload.Queries["items.templateId"] = ExpressionConverter.Convert(itemsTemplateId);
            if (itemsGroupId != null)
                callPayload.Queries["items.groupId"] = ExpressionConverter.Convert(itemsGroupId);
            if (itemsUserId != null)
                callPayload.Queries["items.userId"] = ExpressionConverter.Convert(itemsUserId);
            if (itemsEmail != null)
                callPayload.Queries["items.email"] = ExpressionConverter.Convert(itemsEmail);
            if (itemsFirstname != null)
                callPayload.Queries["items.firstname"] = ExpressionConverter.Convert(itemsFirstname);
            if (itemsLastname != null)
                callPayload.Queries["items.lastname"] = ExpressionConverter.Convert(itemsLastname);
            if (itemsWorkflowStatus != null)
                callPayload.Queries["items.workflowStatus"] = ExpressionConverter.Convert(itemsWorkflowStatus);
            if (itemsData1 != null)
                callPayload.Queries["items.data1"] = ExpressionConverter.Convert(itemsData1);
            if (itemsData2 != null)
                callPayload.Queries["items.data2"] = ExpressionConverter.Convert(itemsData2);
            if (itemsData3 != null)
                callPayload.Queries["items.data3"] = ExpressionConverter.Convert(itemsData3);
            if (itemsData4 != null)
                callPayload.Queries["items.data4"] = ExpressionConverter.Convert(itemsData4);
            if (itemsData5 != null)
                callPayload.Queries["items.data5"] = ExpressionConverter.Convert(itemsData5);
            if (itemsData6 != null)
                callPayload.Queries["items.data6"] = ExpressionConverter.Convert(itemsData6);
            if (itemsData7 != null)
                callPayload.Queries["items.data7"] = ExpressionConverter.Convert(itemsData7);
            if (itemsData8 != null)
                callPayload.Queries["items.data8"] = ExpressionConverter.Convert(itemsData8);
            if (itemsCreated != null)
                callPayload.Queries["items.created"] = ExpressionConverter.Convert(itemsCreated);
            if (itemsUpdated != null)
                callPayload.Queries["items.updated"] = ExpressionConverter.Convert(itemsUpdated);
            if (itemsStarted != null)
                callPayload.Queries["items.started"] = ExpressionConverter.Convert(itemsStarted);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortOrder != null)
                callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<Workflows>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<WorkflowInviteResponse> WorkflowInvite(Expression<Func<string>> workflowId, Expression<Func<string>> bodyrecipientEmail = null)
        {
            var apiCallPath = String.Format("/api/workflows/{0}/invite", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrecipientEmail != null)
            {
                body["recipientEmail"] = ExpressionConverter.ConvertO(bodyrecipientEmail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkflowInviteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<string> WorkflowEvidences(Expression<Func<string>> workflowId, Expression<Func<string>> accept)
        {
            var apiCallPath = String.Format("/api/workflows/{0}/downloadEvidences", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<CreatePartResponse> CreatePart(Expression<Func<string>> workflowId, Expression<Func<string>> contentType, Expression<Func<string>> contentDisposition, Expression<Func<string>> createDocuments = null, Expression<Func<string>> ignoreAttachments = null, Expression<Func<string>> signatureProfileId = null, Expression<Func<string>> unzip = null, Expression<Func<string>> pdf2pdfa = null, Expression<Func<string>> document = null)
        {
            var apiCallPath = String.Format("/api/workflows/{0}/parts", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["createDocuments"] = Convert.ToString("true");
            if (createDocuments != null)
                callPayload.Queries["createDocuments"] = ExpressionConverter.Convert(createDocuments);
            callPayload.Queries["ignoreAttachments"] = Convert.ToString("true");
            if (ignoreAttachments != null)
                callPayload.Queries["ignoreAttachments"] = ExpressionConverter.Convert(ignoreAttachments);
            if (signatureProfileId != null)
                callPayload.Queries["signatureProfileId"] = ExpressionConverter.Convert(signatureProfileId);
            callPayload.Queries["unzip"] = Convert.ToString("false");
            if (unzip != null)
                callPayload.Queries["unzip"] = ExpressionConverter.Convert(unzip);
            callPayload.Queries["pdf2pdfa"] = Convert.ToString("auto");
            if (pdf2pdfa != null)
                callPayload.Queries["pdf2pdfa"] = ExpressionConverter.Convert(pdf2pdfa);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Content-Disposition"] = ExpressionConverter.Convert(contentDisposition);
            callPayload.Body = ExpressionConverter.ConvertO(document);
            return new ApiConnectionAction<CreatePartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document> CreateDocument(Expression<Func<string>> workflowId, Expression<Func<string>> contentType, Expression<Func<Part[]>> bodyparts = null, Expression<Func<string>> bodysignatureProfileId = null)
        {
            var apiCallPath = String.Format("/api/workflows/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyparts != null)
            {
                body["parts"] = ExpressionConverter.ConvertO(bodyparts);
                bodypropCount++;
            }

            if (bodysignatureProfileId != null)
            {
                body["signatureProfileId"] = ExpressionConverter.ConvertO(bodysignatureProfileId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document> RetrieveDocument(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document> DeleteDocument(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Document> UpdateDocument(Expression<Func<string>> documentId, Expression<Func<string>> contentType, Expression<Func<string>> bodysignatureProfileId = null, Expression<Func<PdfSigField[]>> bodypdfSignatureFields = null)
        {
            var apiCallPath = String.Format("/api/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysignatureProfileId != null)
            {
                body["signatureProfileId"] = ExpressionConverter.ConvertO(bodysignatureProfileId);
                bodypropCount++;
            }

            if (bodypdfSignatureFields != null)
            {
                body["pdfSignatureFields"] = ExpressionConverter.ConvertO(bodypdfSignatureFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SearchDocumentsResponse> SearchDocuments(Expression<Func<string>> text = null, Expression<Func<string>> itemsLayoutId = null, Expression<Func<string>> itemsGroupId = null, Expression<Func<string>> itemsUserId = null, Expression<Func<string>> itemsWorkflowId = null, Expression<Func<string>> itemsWorkflowName = null, Expression<Func<string>> itemsData1 = null, Expression<Func<string>> itemsData2 = null, Expression<Func<string>> itemsData3 = null, Expression<Func<string>> itemsData4 = null, Expression<Func<string>> itemsData5 = null, Expression<Func<string>> itemsData6 = null, Expression<Func<string>> itemsData7 = null, Expression<Func<string>> itemsData8 = null, Expression<Func<string>> itemsSignatureProfileId = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var apiCallPath = "/api/documents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsLayoutId != null)
                callPayload.Queries["items.layoutId"] = ExpressionConverter.Convert(itemsLayoutId);
            if (itemsGroupId != null)
                callPayload.Queries["items.groupId"] = ExpressionConverter.Convert(itemsGroupId);
            if (itemsUserId != null)
                callPayload.Queries["items.userId"] = ExpressionConverter.Convert(itemsUserId);
            if (itemsWorkflowId != null)
                callPayload.Queries["items.workflowId"] = ExpressionConverter.Convert(itemsWorkflowId);
            if (itemsWorkflowName != null)
                callPayload.Queries["items.workflowName"] = ExpressionConverter.Convert(itemsWorkflowName);
            if (itemsData1 != null)
                callPayload.Queries["items.data1"] = ExpressionConverter.Convert(itemsData1);
            if (itemsData2 != null)
                callPayload.Queries["items.data2"] = ExpressionConverter.Convert(itemsData2);
            if (itemsData3 != null)
                callPayload.Queries["items.data3"] = ExpressionConverter.Convert(itemsData3);
            if (itemsData4 != null)
                callPayload.Queries["items.data4"] = ExpressionConverter.Convert(itemsData4);
            if (itemsData5 != null)
                callPayload.Queries["items.data5"] = ExpressionConverter.Convert(itemsData5);
            if (itemsData6 != null)
                callPayload.Queries["items.data6"] = ExpressionConverter.Convert(itemsData6);
            if (itemsData7 != null)
                callPayload.Queries["items.data7"] = ExpressionConverter.Convert(itemsData7);
            if (itemsData8 != null)
                callPayload.Queries["items.data8"] = ExpressionConverter.Convert(itemsData8);
            if (itemsSignatureProfileId != null)
                callPayload.Queries["items.signatureProfileId"] = ExpressionConverter.Convert(itemsSignatureProfileId);
            if (itemsCreated != null)
                callPayload.Queries["items.created"] = ExpressionConverter.Convert(itemsCreated);
            if (itemsUpdated != null)
                callPayload.Queries["items.updated"] = ExpressionConverter.Convert(itemsUpdated);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortOrder != null)
                callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            return new ApiConnectionAction<SearchDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<string> DownloadDocuments(Expression<Func<string>> workflowId)
        {
            var apiCallPath = String.Format("/api/workflows/{0}/downloadDocuments", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout> CreateLayout(Expression<Func<string>> tenantId, Expression<Func<string>> contentType, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyisDisabled = null, Expression<Func<bodydataConfigurationsInputItem[]>> bodydataConfigurations = null)
        {
            var apiCallPath = String.Format("/api/tenants/{0}/layouts", ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyisDisabled != null)
            {
                body["isDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                bodypropCount++;
            }

            if (bodydataConfigurations != null)
            {
                body["dataConfigurations"] = ExpressionConverter.ConvertO(bodydataConfigurations);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Layout>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout> RetrieveLayout(Expression<Func<string>> layoutId)
        {
            var apiCallPath = String.Format("/api/layouts/{0}", ExpressionConverter.ConvertWithUrlEncoding(layoutId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Layout>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<Layout> UpdateLayout(Expression<Func<string>> layoutId, Expression<Func<string>> contentType, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyisDisabled = null, Expression<Func<bodydataConfigurationsInputItem[]>> bodydataConfigurations = null)
        {
            var apiCallPath = String.Format("/api/layouts/{0}", ExpressionConverter.ConvertWithUrlEncoding(layoutId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyisDisabled != null)
            {
                body["isDisabled"] = ExpressionConverter.ConvertO(bodyisDisabled);
                bodypropCount++;
            }

            if (bodydataConfigurations != null)
            {
                body["dataConfigurations"] = ExpressionConverter.ConvertO(bodydataConfigurations);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Layout>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexpowersign")]
        public IBodyWorkflowAction<SearchLayoutsResponse> SearchLayouts(Expression<Func<string>> text = null, Expression<Func<string>> itemsIsDisabled = null, Expression<Func<string>> itemsName = null, Expression<Func<string>> itemsDataConfigurationsSlot = null, Expression<Func<string>> itemsCreated = null, Expression<Func<string>> itemsUpdated = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> itemsPerPage = null, Expression<Func<string>> pageIndex = null)
        {
            var apiCallPath = "/api/layouts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (itemsIsDisabled != null)
                callPayload.Queries["items.isDisabled"] = ExpressionConverter.Convert(itemsIsDisabled);
            if (itemsName != null)
                callPayload.Queries["items.name"] = ExpressionConverter.Convert(itemsName);
            if (itemsDataConfigurationsSlot != null)
                callPayload.Queries["items.dataConfigurations.slot"] = ExpressionConverter.Convert(itemsDataConfigurationsSlot);
            if (itemsCreated != null)
                callPayload.Queries["items.created"] = ExpressionConverter.Convert(itemsCreated);
            if (itemsUpdated != null)
                callPayload.Queries["items.updated"] = ExpressionConverter.Convert(itemsUpdated);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (sortOrder != null)
                callPayload.Queries["sortOrder"] = ExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["itemsPerPage"] = ExpressionConverter.Convert(itemsPerPage);
            if (pageIndex != null)
                callPayload.Queries["pageIndex"] = ExpressionConverter.Convert(pageIndex);
            return new ApiConnectionAction<SearchLayoutsResponse>(callPayload);
        }
    }

    public class LexpowersignTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConsentPage
    {
        [JsonProperty("allowOrganization")]
        public bool AllowOrganization { get; set; }

        [JsonProperty("authenticateUser")]
        public bool AuthenticateUser { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("emUrl")]
        public string EmUrl { get; set; }

        [JsonProperty("hideDownloads")]
        public bool HideDownloads { get; set; }

        [JsonProperty("hideMobileQrCode")]
        public bool HideMobileQrCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCountryRequired")]
        public bool IsCountryRequired { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("logoResourceId")]
        public string LogoResourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryColor")]
        public string PrimaryColor { get; set; }

        [JsonProperty("secondaryColor")]
        public string SecondaryColor { get; set; }

        [JsonProperty("sharedPassphrase")]
        public string SharedPassphrase { get; set; }

        [JsonProperty("signing mode")]
        public string SigningMode { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("tsaUrl")]
        public string TsaUrl { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }

        [JsonProperty("verifyEmail")]
        public bool VerifyEmail { get; set; }

        [JsonProperty("verifyPhoneNumber")]
        public bool VerifyPhoneNumber { get; set; }
    }

    public class ConsentPages
    {
        [JsonProperty("items")]
        public ConsentPage[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class Contact
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class Contacts
    {
        [JsonProperty("items")]
        public Contact[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class DataMapping
    {
        [JsonProperty("data1")]
        public DataMappingData1Type Data1 { get; set; }

        [JsonProperty("data2")]
        public DataMappingData2Type Data2 { get; set; }

        [JsonProperty("data3")]
        public DataMappingData3Type Data3 { get; set; }

        [JsonProperty("data4")]
        public DataMappingData4Type Data4 { get; set; }

        [JsonProperty("data5")]
        public DataMappingData5Type Data5 { get; set; }

        [JsonProperty("data6")]
        public DataMappingData6Type Data6 { get; set; }

        [JsonProperty("data7")]
        public DataMappingData7Type Data7 { get; set; }

        [JsonProperty("data8")]
        public DataMappingData8Type Data8 { get; set; }
    }

    public class DataMappingData1Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData1TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData1TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData2Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData2TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData2TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData3Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData3TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData3TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData4Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData4TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData4TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData5Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData5TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData5TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData6Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData6TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData6TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData7Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData7TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData7TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataMappingData8Type
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("options")]
        public DataMappingData8TypeOptionsTypeItem[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DataMappingData8TypeOptionsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SignatureProfile
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("forceScrollDocument")]
        public bool ForceScrollDocument { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdfSignatureImageText")]
        public string PdfSignatureImageText { get; set; }

        [JsonProperty("pdfSignatureImageTextColor")]
        public string PdfSignatureImageTextColor { get; set; }

        [JsonProperty("pdfSignatureImageTextSize")]
        public double PdfSignatureImageTextSize { get; set; }

        [JsonProperty("pdfVisibleSignatureMode")]
        public string PdfVisibleSignatureMode { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }
    }

    public class SignatureProfiles
    {
        [JsonProperty("items")]
        public SignatureProfile[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public double ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public double PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public double TotalItems { get; set; }
    }

    public class User
    {
        [JsonProperty("approveAllowed")]
        public bool ApproveAllowed { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("lastLogin")]
        public int LastLogin { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationTitles")]
        public JToken[] OrganizationTitles { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("signAllowed")]
        public bool SignAllowed { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }
    }

    public class Workflow
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("currentRecipientEmails")]
        public JToken[] CurrentRecipientEmails { get; set; }

        [JsonProperty("currentRecipientUsers")]
        public JToken[] CurrentRecipientUsers { get; set; }

        [JsonProperty("data1")]
        public string Data1 { get; set; }

        [JsonProperty("data2")]
        public string Data2 { get; set; }

        [JsonProperty("data3")]
        public string Data3 { get; set; }

        [JsonProperty("data4")]
        public string Data4 { get; set; }

        [JsonProperty("data5")]
        public string Data5 { get; set; }

        [JsonProperty("data6")]
        public string Data6 { get; set; }

        [JsonProperty("data7")]
        public string Data7 { get; set; }

        [JsonProperty("data8")]
        public string Data8 { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("layoutId")]
        public string LayoutId { get; set; }

        [JsonProperty("logs")]
        public JToken[] Logs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("steps")]
        public WorkflowStepsTypeItem[] Steps { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }

        [JsonProperty("viewAuthorizedUsers")]
        public string[] ViewAuthorizedUsers { get; set; }

        [JsonProperty("watchers")]
        public WorkflowWatchersTypeItem[] Watchers { get; set; }

        [JsonProperty("workflowStatus")]
        public string WorkflowStatus { get; set; }
    }

    public class WorkflowStepsTypeItem
    {
        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("hideAttachments")]
        public bool HideAttachments { get; set; }

        [JsonProperty("hideWorkflowRecipients")]
        public bool HideWorkflowRecipients { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("invitePeriod")]
        public int InvitePeriod { get; set; }

        [JsonProperty("isFinished")]
        public bool IsFinished { get; set; }

        [JsonProperty("isStarted")]
        public bool IsStarted { get; set; }

        [JsonProperty("logs")]
        public JToken[] Logs { get; set; }

        [JsonProperty("maxInvites")]
        public int MaxInvites { get; set; }

        [JsonProperty("recipients")]
        public WorkflowStepsTypeItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("requiredRecipients")]
        public int RequiredRecipients { get; set; }

        [JsonProperty("sendDownloadLink")]
        public bool SendDownloadLink { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("validityPeriod")]
        public int ValidityPeriod { get; set; }
    }

    public class WorkflowStepsTypeItemRecipientsTypeItem
    {
        [JsonProperty("consentPageId")]
        public string ConsentPageId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class WorkflowWatchersTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class Step
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("requiredRecipients")]
        public double RequiredRecipients { get; set; }

        [JsonProperty("validityPeriod")]
        public double ValidityPeriod { get; set; }

        [JsonProperty("inviteperiod")]
        public double Inviteperiod { get; set; }

        [JsonProperty("maxInvites")]
        public double MaxInvites { get; set; }

        [JsonProperty("sendDownloadLink")]
        public bool SendDownloadLink { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("hideAttachments")]
        public bool HideAttachments { get; set; }

        [JsonProperty("hideWorkflowRecipients")]
        public bool HideWorkflowRecipients { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("consentPageId")]
        public string ConsentPageId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("preferredLocale")]
        public string PreferredLocale { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }
    }

    public class bodywatchersInputItem
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("notifiedEvents")]
        public string[] NotifiedEvents { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Workflows
    {
        [JsonProperty("items")]
        public Workflow[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class WorkflowInviteResponse
    {
        [JsonProperty("inviteUrl")]
        public string TheConsentPageUrlForTheConcernedRecipient { get; set; }
    }

    public class CreatePartResponse
    {
        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("ignoredAttachments")]
        public int IgnoredAttachments { get; set; }

        [JsonProperty("parts")]
        public Part[] Parts { get; set; }
    }

    public class Document
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parts")]
        public Part[] Parts { get; set; }

        [JsonProperty("pdfSignatureFields")]
        public PdfSigField[] PdfSignatureFields { get; set; }

        [JsonProperty("signatureProfileId")]
        public string SignatureProfileId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("viewAuthorizedGroups")]
        public string[] ViewAuthorizedGroups { get; set; }

        [JsonProperty("viewAuthorizedUsers")]
        public string[] ViewAuthorizedUsers { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }
    }

    public class Part
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class PdfSigField
    {
        [JsonProperty("imageHeight")]
        public double ImageHeight { get; set; }

        [JsonProperty("imagePage")]
        public double ImagePage { get; set; }

        [JsonProperty("imageWidth")]
        public double ImageWidth { get; set; }

        [JsonProperty("imageX")]
        public double ImageX { get; set; }

        [JsonProperty("imageY")]
        public double ImageY { get; set; }
    }

    public class SearchDocumentsResponse
    {
        [JsonProperty("items")]
        public Documents Items { get; set; }
    }

    public class Documents
    {
        [JsonProperty("items")]
        public Document[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }
    }

    public class Layout
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("updated")]
        public double Updated { get; set; }

        [JsonProperty("dataConfigurations")]
        public LayoutDataConfigurationsTypeItem[] DataConfigurations { get; set; }
    }

    public class LayoutDataConfigurationsTypeItem
    {
        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("rememberLastValue")]
        public bool RememberLastValue { get; set; }
    }

    public class bodydataConfigurationsInputItem
    {
        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("rememberLastValue")]
        public bool RememberLastValue { get; set; }
    }

    public class SearchLayoutsResponse
    {
        [JsonProperty("items")]
        public Layouts Items { get; set; }
    }

    public class Layouts
    {
        [JsonProperty("items")]
        public LayoutsItemsTypeItem[] Items { get; set; }

        [JsonProperty("itemsPerPage")]
        public double ItemsPerPage { get; set; }

        [JsonProperty("pageIndex")]
        public double PageIndex { get; set; }

        [JsonProperty("totalItems")]
        public double TotalItems { get; set; }
    }

    public class LayoutsItemsTypeItem
    {
        [JsonProperty("created")]
        public double Created { get; set; }

        [JsonProperty("dataConfigurations")]
        public Layout[] DataConfigurations { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lexpowersign;

    public partial class WorkflowManagedActions
    {
        public LexpowersignActions Lexpowersign(string connectionId) => new LexpowersignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LexpowersignTriggers Lexpowersign(string connectionId) => new LexpowersignTriggers(connectionId);
    }
}