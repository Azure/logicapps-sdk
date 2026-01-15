//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Badgrip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BadgripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerGetResponse> IssuerGet()
        {
            var apiCallPath = "/v2/issuers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IssuerGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerCreateResponse> IssuerCreate(Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyurl = null, Expression<Func<bodystaffInputItem[]>> bodystaff = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgrDomain = null)
        {
            var apiCallPath = "/v2/issuers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycreatedBy != null)
            {
                body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodystaff != null)
            {
                body["staff"] = ExpressionConverter.ConvertO(bodystaff);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgrDomain != null)
            {
                body["badgrDomain"] = ExpressionConverter.ConvertO(bodybadgrDomain);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IssuerCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerGetAResponse> IssuerGetA(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IssuerGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction IssuerDelete(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerUpdateResponse> IssuerUpdate(Expression<Func<string>> entityId, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyurl = null, Expression<Func<bodystaffInputItem[]>> bodystaff = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgrDomain = null)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycreatedBy != null)
            {
                body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodystaff != null)
            {
                body["staff"] = ExpressionConverter.ConvertO(bodystaff);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgrDomain != null)
            {
                body["badgrDomain"] = ExpressionConverter.ConvertO(bodybadgrDomain);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IssuerUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionGetResponse> AssertionGet(Expression<Func<string>> entityId, Expression<Func<string>> recipient = null, Expression<Func<string>> num = null, Expression<Func<bool>> includeExpired = null, Expression<Func<bool>> includeRevoked = null)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}/assertions", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipient != null)
                callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
            if (num != null)
                callPayload.Queries["num"] = ExpressionConverter.Convert(num);
            if (includeExpired != null)
                callPayload.Queries["include_expired"] = ExpressionConverter.Convert(includeExpired);
            if (includeRevoked != null)
                callPayload.Queries["include_revoked"] = ExpressionConverter.Convert(includeRevoked);
            return new ApiConnectionAction<AssertionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionIssueResponse> AssertionIssue(Expression<Func<string>> entityId, Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}/assertions", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AssertionIssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetIssuerResponse> ClassGetIssuer(Expression<Func<string>> entityId, Expression<Func<string>> num = null)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}/badgeclasses", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (num != null)
                callPayload.Queries["num"] = ExpressionConverter.Convert(num);
            return new ApiConnectionAction<ClassGetIssuerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassCreateIssuerResponse> ClassCreateIssuer(Expression<Func<string>> entityId, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyachievementType = null, Expression<Func<string>> bodycriteriaUrl = null, Expression<Func<string>> bodycriteriaNarrative = null, Expression<Func<bodyalignmentsInputItem[]>> bodyalignments = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodyexpiresamount = null, Expression<Func<string>> bodyexpiresduration = null, Expression<Func<string>> bodyextensions = null)
        {
            var apiCallPath = String.Format("/v2/issuers/{0}/badgeclasses", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyachievementType != null)
            {
                body["achievementType"] = ExpressionConverter.ConvertO(bodyachievementType);
                bodypropCount++;
            }

            if (bodycriteriaUrl != null)
            {
                body["criteriaUrl"] = ExpressionConverter.ConvertO(bodycriteriaUrl);
                bodypropCount++;
            }

            if (bodycriteriaNarrative != null)
            {
                body["criteriaNarrative"] = ExpressionConverter.ConvertO(bodycriteriaNarrative);
                bodypropCount++;
            }

            if (bodyalignments != null)
            {
                body["alignments"] = ExpressionConverter.ConvertO(bodyalignments);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            var expiresObject = new JObject();
            var expiresObjectpropCount = 0;
            if (bodyexpiresamount != null)
            {
                expiresObject["amount"] = ExpressionConverter.ConvertO(bodyexpiresamount);
                expiresObjectpropCount++;
            }

            if (bodyexpiresduration != null)
            {
                expiresObject["duration"] = ExpressionConverter.ConvertO(bodyexpiresduration);
                expiresObjectpropCount++;
            }

            if (expiresObjectpropCount > 0)
            {
                body["expires"] = expiresObject;
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassCreateIssuerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetUserResponse> ClassGetUser()
        {
            var apiCallPath = "/v2/badgeclasses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ClassGetUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassCreateResponse> ClassCreate(Expression<Func<int>> num = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyachievementType = null, Expression<Func<string>> bodycriteriaUrl = null, Expression<Func<string>> bodycriteriaNarrative = null, Expression<Func<bodyalignmentsInputItem[]>> bodyalignments = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodyexpiresamount = null, Expression<Func<string>> bodyexpiresduration = null, Expression<Func<string>> bodyextensions = null)
        {
            var apiCallPath = "/v2/badgeclasses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (num != null)
                callPayload.Queries["num"] = ExpressionConverter.Convert(num);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyachievementType != null)
            {
                body["achievementType"] = ExpressionConverter.ConvertO(bodyachievementType);
                bodypropCount++;
            }

            if (bodycriteriaUrl != null)
            {
                body["criteriaUrl"] = ExpressionConverter.ConvertO(bodycriteriaUrl);
                bodypropCount++;
            }

            if (bodycriteriaNarrative != null)
            {
                body["criteriaNarrative"] = ExpressionConverter.ConvertO(bodycriteriaNarrative);
                bodypropCount++;
            }

            if (bodyalignments != null)
            {
                body["alignments"] = ExpressionConverter.ConvertO(bodyalignments);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            var expiresObject = new JObject();
            var expiresObjectpropCount = 0;
            if (bodyexpiresamount != null)
            {
                expiresObject["amount"] = ExpressionConverter.ConvertO(bodyexpiresamount);
                expiresObjectpropCount++;
            }

            if (bodyexpiresduration != null)
            {
                expiresObject["duration"] = ExpressionConverter.ConvertO(bodyexpiresduration);
                expiresObjectpropCount++;
            }

            if (expiresObjectpropCount > 0)
            {
                body["expires"] = expiresObject;
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetResponse> ClassGet(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ClassGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction ClassDelete(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassUpdateResponse> ClassUpdate(Expression<Func<string>> entityId, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyachievementType = null, Expression<Func<string>> bodycriteriaUrl = null, Expression<Func<string>> bodycriteriaNarrative = null, Expression<Func<bodyalignmentsInputItem[]>> bodyalignments = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodyexpiresamount = null, Expression<Func<string>> bodyexpiresduration = null, Expression<Func<string>> bodyextensions = null)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyachievementType != null)
            {
                body["achievementType"] = ExpressionConverter.ConvertO(bodyachievementType);
                bodypropCount++;
            }

            if (bodycriteriaUrl != null)
            {
                body["criteriaUrl"] = ExpressionConverter.ConvertO(bodycriteriaUrl);
                bodypropCount++;
            }

            if (bodycriteriaNarrative != null)
            {
                body["criteriaNarrative"] = ExpressionConverter.ConvertO(bodycriteriaNarrative);
                bodypropCount++;
            }

            if (bodyalignments != null)
            {
                body["alignments"] = ExpressionConverter.ConvertO(bodyalignments);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            var expiresObject = new JObject();
            var expiresObjectpropCount = 0;
            if (bodyexpiresamount != null)
            {
                expiresObject["amount"] = ExpressionConverter.ConvertO(bodyexpiresamount);
                expiresObjectpropCount++;
            }

            if (bodyexpiresduration != null)
            {
                expiresObject["duration"] = ExpressionConverter.ConvertO(bodyexpiresduration);
                expiresObjectpropCount++;
            }

            if (expiresObjectpropCount > 0)
            {
                body["expires"] = expiresObject;
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetAssertionResponse> ClassGetAssertion(Expression<Func<string>> entityId, Expression<Func<string>> recipient = null, Expression<Func<string>> num = null, Expression<Func<bool>> includeExpired = null, Expression<Func<bool>> includeRevoked = null)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}/assertions", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipient != null)
                callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
            if (num != null)
                callPayload.Queries["num"] = ExpressionConverter.Convert(num);
            if (includeExpired != null)
                callPayload.Queries["include_expired"] = ExpressionConverter.Convert(includeExpired);
            if (includeRevoked != null)
                callPayload.Queries["include_revoked"] = ExpressionConverter.Convert(includeRevoked);
            return new ApiConnectionAction<ClassGetAssertionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassIssueAssertionResponse> ClassIssueAssertion(Expression<Func<string>> entityId, Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}/assertions", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassIssueAssertionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionGetAResponse> AssertionGetA(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AssertionGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction AssertionRevoke(Expression<Func<string>> entityId, Expression<Func<string>> bodyrevocationReason = null)
        {
            var apiCallPath = String.Format("/v2/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrevocationReason != null)
            {
                body["revocation_reason"] = ExpressionConverter.ConvertO(bodyrevocationReason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionUpdateResponse> AssertionUpdate(Expression<Func<string>> entityId, Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = String.Format("/v2/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AssertionUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<TokenGetResponse> TokenGet()
        {
            var apiCallPath = "/v2/auth/tokens";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TokenGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<TokenGetAResponse> TokenGetA(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/auth/tokens/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TokenGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction TokenRevoke(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/auth/tokens/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserGetProfileResponse> UserGetProfile(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserGetProfileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserCreateResponse> UserCreate(Expression<Func<string>> entityId, Expression<Func<string>> bodyentityType = null, Expression<Func<string>> bodyentityId = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodyagreedTermsVersion = null, Expression<Func<string>> bodyhasAgreedToLatestTermsVersion = null, Expression<Func<string>> bodymarketingOptIn = null, Expression<Func<string>> bodybadgrDomain = null, Expression<Func<string>> bodyhasPasswordSet = null, Expression<Func<string>> bodyrecipient = null)
        {
            var apiCallPath = String.Format("/v2/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityType != null)
            {
                body["entityType"] = ExpressionConverter.ConvertO(bodyentityType);
                bodypropCount++;
            }

            if (bodyentityId != null)
            {
                body["entityId"] = ExpressionConverter.ConvertO(bodyentityId);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodyemails != null)
            {
                body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodytelephone != null)
            {
                body["telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                bodypropCount++;
            }

            if (bodyagreedTermsVersion != null)
            {
                body["agreedTermsVersion"] = ExpressionConverter.ConvertO(bodyagreedTermsVersion);
                bodypropCount++;
            }

            if (bodyhasAgreedToLatestTermsVersion != null)
            {
                body["hasAgreedToLatestTermsVersion"] = ExpressionConverter.ConvertO(bodyhasAgreedToLatestTermsVersion);
                bodypropCount++;
            }

            if (bodymarketingOptIn != null)
            {
                body["marketingOptIn"] = ExpressionConverter.ConvertO(bodymarketingOptIn);
                bodypropCount++;
            }

            if (bodybadgrDomain != null)
            {
                body["badgrDomain"] = ExpressionConverter.ConvertO(bodybadgrDomain);
                bodypropCount++;
            }

            if (bodyhasPasswordSet != null)
            {
                body["hasPasswordSet"] = ExpressionConverter.ConvertO(bodyhasPasswordSet);
                bodypropCount++;
            }

            if (bodyrecipient != null)
            {
                body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserUpdateResponse> UserUpdate(Expression<Func<string>> entityId, Expression<Func<string>> bodyentityType = null, Expression<Func<string>> bodyentityId = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodyagreedTermsVersion = null, Expression<Func<string>> bodyhasAgreedToLatestTermsVersion = null, Expression<Func<string>> bodymarketingOptIn = null, Expression<Func<string>> bodybadgrDomain = null, Expression<Func<string>> bodyhasPasswordSet = null, Expression<Func<string>> bodyrecipient = null)
        {
            var apiCallPath = String.Format("/v2/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityType != null)
            {
                body["entityType"] = ExpressionConverter.ConvertO(bodyentityType);
                bodypropCount++;
            }

            if (bodyentityId != null)
            {
                body["entityId"] = ExpressionConverter.ConvertO(bodyentityId);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodyemails != null)
            {
                body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodytelephone != null)
            {
                body["telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                bodypropCount++;
            }

            if (bodyagreedTermsVersion != null)
            {
                body["agreedTermsVersion"] = ExpressionConverter.ConvertO(bodyagreedTermsVersion);
                bodypropCount++;
            }

            if (bodyhasAgreedToLatestTermsVersion != null)
            {
                body["hasAgreedToLatestTermsVersion"] = ExpressionConverter.ConvertO(bodyhasAgreedToLatestTermsVersion);
                bodypropCount++;
            }

            if (bodymarketingOptIn != null)
            {
                body["marketingOptIn"] = ExpressionConverter.ConvertO(bodymarketingOptIn);
                bodypropCount++;
            }

            if (bodybadgrDomain != null)
            {
                body["badgrDomain"] = ExpressionConverter.ConvertO(bodybadgrDomain);
                bodypropCount++;
            }

            if (bodyhasPasswordSet != null)
            {
                body["hasPasswordSet"] = ExpressionConverter.ConvertO(bodyhasPasswordSet);
                bodypropCount++;
            }

            if (bodyrecipient != null)
            {
                body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackGetAssertionResponse> BackpackGetAssertion()
        {
            var apiCallPath = "/v2/backpack/assertions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BackpackGetAssertionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackUploadAssertionResponse> BackpackUploadAssertion(Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = "/v2/backpack/assertions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BackpackUploadAssertionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackGetAssertionDetailsResponse> BackpackGetAssertionDetails(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/backpack/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BackpackGetAssertionDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction BackpackRemoteAssertion(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/backpack/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackUpdateAcceptanceResponse> BackpackUpdateAcceptance(Expression<Func<string>> entityId, Expression<Func<string>> bodyacceptance = null, Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodypending = null)
        {
            var apiCallPath = String.Format("/v2/backpack/assertions/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyacceptance != null)
            {
                body["acceptance"] = ExpressionConverter.ConvertO(bodyacceptance);
                bodypropCount++;
            }

            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodypending != null)
            {
                body["pending"] = ExpressionConverter.ConvertO(bodypending);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BackpackUpdateAcceptanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionGetResponse> CollectionGet()
        {
            var apiCallPath = "/v2/backpack/collections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CollectionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionCreateResponse> CollectionCreate(Expression<Func<string>> bodyentityType = null, Expression<Func<string>> bodyentityId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyshareUrl = null, Expression<Func<string>> bodyshareHash = null, Expression<Func<bool>> bodypublished = null, Expression<Func<bodyassertionsInputItem[]>> bodyassertions = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodycreatedBy = null)
        {
            var apiCallPath = "/v2/backpack/collections";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityType != null)
            {
                body["entityType"] = ExpressionConverter.ConvertO(bodyentityType);
                bodypropCount++;
            }

            if (bodyentityId != null)
            {
                body["entityId"] = ExpressionConverter.ConvertO(bodyentityId);
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

            if (bodyowner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodyshareUrl != null)
            {
                body["share_url"] = ExpressionConverter.ConvertO(bodyshareUrl);
                bodypropCount++;
            }

            if (bodyshareHash != null)
            {
                body["shareHash"] = ExpressionConverter.ConvertO(bodyshareHash);
                bodypropCount++;
            }

            if (bodypublished != null)
            {
                body["published"] = ExpressionConverter.ConvertO(bodypublished);
                bodypropCount++;
            }

            if (bodyassertions != null)
            {
                body["assertions"] = ExpressionConverter.ConvertO(bodyassertions);
                bodypropCount++;
            }

            if (bodycreatedAt != null)
            {
                body["createdAt"] = ExpressionConverter.ConvertO(bodycreatedAt);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CollectionCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionGetAResponse> CollectionGetA(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/backpack/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CollectionGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction CollectionDelete(Expression<Func<string>> entityId)
        {
            var apiCallPath = String.Format("/v2/backpack/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionUpdateResponse> CollectionUpdate(Expression<Func<string>> entityId, Expression<Func<string>> bodyentityType = null, Expression<Func<string>> bodyentityId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyshareUrl = null, Expression<Func<string>> bodyshareHash = null, Expression<Func<bool>> bodypublished = null, Expression<Func<bodyassertionsInputItem[]>> bodyassertions = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<string>> bodycreatedBy = null)
        {
            var apiCallPath = String.Format("/v2/backpack/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentityType != null)
            {
                body["entityType"] = ExpressionConverter.ConvertO(bodyentityType);
                bodypropCount++;
            }

            if (bodyentityId != null)
            {
                body["entityId"] = ExpressionConverter.ConvertO(bodyentityId);
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

            if (bodyowner != null)
            {
                body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodyshareUrl != null)
            {
                body["share_url"] = ExpressionConverter.ConvertO(bodyshareUrl);
                bodypropCount++;
            }

            if (bodyshareHash != null)
            {
                body["shareHash"] = ExpressionConverter.ConvertO(bodyshareHash);
                bodypropCount++;
            }

            if (bodypublished != null)
            {
                body["published"] = ExpressionConverter.ConvertO(bodypublished);
                bodypropCount++;
            }

            if (bodyassertions != null)
            {
                body["assertions"] = ExpressionConverter.ConvertO(bodyassertions);
                bodypropCount++;
            }

            if (bodycreatedAt != null)
            {
                body["createdAt"] = ExpressionConverter.ConvertO(bodycreatedAt);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CollectionUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassIssueBulkResponse> ClassIssueBulk(Expression<Func<string>> entityId, Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = String.Format("/v2/badgeclasses/{0}/issue", ExpressionConverter.ConvertWithUrlEncoding(entityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ClassIssueBulkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionRevokeBulkResponse> AssertionRevokeBulk(Expression<Func<string>> bodybadgeclass = null, Expression<Func<string>> bodybadgeclassOpenBadgeId = null, Expression<Func<string>> bodyissuer = null, Expression<Func<string>> bodyissuerOpenBadgeId = null, Expression<Func<string>> bodyrecipientidentity = null, Expression<Func<bool>> bodyrecipienthashed = null, Expression<Func<string>> bodyrecipienttype = null, Expression<Func<string>> bodyrecipientplaintextIdentity = null, Expression<Func<string>> bodyrecipientsalt = null, Expression<Func<string>> bodyissuedOn = null, Expression<Func<string>> bodynarrative = null, Expression<Func<bodyevidenceInputItem[]>> bodyevidence = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyextensions = null, Expression<Func<string>> bodybadgeclassName = null)
        {
            var apiCallPath = "/v2/assertions/revoke";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybadgeclass != null)
            {
                body["badgeclass"] = ExpressionConverter.ConvertO(bodybadgeclass);
                bodypropCount++;
            }

            if (bodybadgeclassOpenBadgeId != null)
            {
                body["badgeclassOpenBadgeId"] = ExpressionConverter.ConvertO(bodybadgeclassOpenBadgeId);
                bodypropCount++;
            }

            if (bodyissuer != null)
            {
                body["issuer"] = ExpressionConverter.ConvertO(bodyissuer);
                bodypropCount++;
            }

            if (bodyissuerOpenBadgeId != null)
            {
                body["issuerOpenBadgeId"] = ExpressionConverter.ConvertO(bodyissuerOpenBadgeId);
                bodypropCount++;
            }

            var recipientObject = new JObject();
            var recipientObjectpropCount = 0;
            if (bodyrecipientidentity != null)
            {
                recipientObject["identity"] = ExpressionConverter.ConvertO(bodyrecipientidentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipienthashed != null)
            {
                recipientObject["hashed"] = ExpressionConverter.ConvertO(bodyrecipienthashed);
                recipientObjectpropCount++;
            }

            if (bodyrecipienttype != null)
            {
                recipientObject["type"] = ExpressionConverter.ConvertO(bodyrecipienttype);
                recipientObjectpropCount++;
            }

            if (bodyrecipientplaintextIdentity != null)
            {
                recipientObject["plaintextIdentity"] = ExpressionConverter.ConvertO(bodyrecipientplaintextIdentity);
                recipientObjectpropCount++;
            }

            if (bodyrecipientsalt != null)
            {
                recipientObject["salt"] = ExpressionConverter.ConvertO(bodyrecipientsalt);
                recipientObjectpropCount++;
            }

            if (recipientObjectpropCount > 0)
            {
                body["recipient"] = recipientObject;
                bodypropCount++;
            }

            if (bodyissuedOn != null)
            {
                body["issuedOn"] = ExpressionConverter.ConvertO(bodyissuedOn);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyevidence != null)
            {
                body["evidence"] = ExpressionConverter.ConvertO(bodyevidence);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyextensions != null)
            {
                body["extensions"] = ExpressionConverter.ConvertO(bodyextensions);
                bodypropCount++;
            }

            if (bodybadgeclassName != null)
            {
                body["badgeclassName"] = ExpressionConverter.ConvertO(bodybadgeclassName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AssertionRevokeBulkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction AccountRequestRecovery(Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/v2/auth/forgot-password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AccountRecoverResponse> AccountRecover(Expression<Func<string>> bodytoken = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/v2/auth/forgot-password";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytoken != null)
            {
                body["token"] = ExpressionConverter.ConvertO(bodytoken);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AccountRecoverResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction BackpackImportAssertion(Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyimage = null)
        {
            var apiCallPath = "/v2/backpack/import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            var assertionObject = new JObject();
            var assertionObjectpropCount = 0;
            if (assertionObjectpropCount > 0)
            {
                body["assertion"] = assertionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BadgripTriggers([ConnectionName] string connectionId)
    {
    }

    public class IssuerGetResponse
    {
        [JsonProperty("status")]
        public IssuerGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerGetResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerGetResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public IssuerGetResponseResultTypeItemStaffTypeItemUserProfileType UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItemUserProfileType
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public IssuerGetResponseResultTypeItemStaffTypeItemUserProfileTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string[] Url { get; set; }

        [JsonProperty("telephone")]
        public string[] Telephone { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItemUserProfileTypeEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string[] CaseVariants { get; set; }
    }

    public class IssuerCreateResponse
    {
        [JsonProperty("status")]
        public IssuerCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerCreateResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerCreateResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class bodystaffInputItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerGetAResponse
    {
        [JsonProperty("status")]
        public IssuerGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerGetAResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetAResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerUpdateResponse
    {
        [JsonProperty("status")]
        public IssuerUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerUpdateResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerUpdateResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class AssertionGetResponse
    {
        [JsonProperty("status")]
        public AssertionGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionGetResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionGetResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionGetResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionGetResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionGetResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionIssueResponse
    {
        [JsonProperty("status")]
        public AssertionIssueResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionIssueResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionIssueResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionIssueResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionIssueResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionIssueResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionIssueResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionIssueResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class bodyevidenceInputItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassGetIssuerResponse
    {
        [JsonProperty("status")]
        public ClassGetIssuerResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetIssuerResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetIssuerResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetIssuerResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetIssuerResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateIssuerResponse
    {
        [JsonProperty("status")]
        public ClassCreateIssuerResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassCreateIssuerResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassCreateIssuerResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateIssuerResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateIssuerResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class bodyalignmentsInputItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetUserResponse
    {
        [JsonProperty("status")]
        public ClassGetUserResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetUserResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetUserResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetUserResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetUserResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetUserResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetUserResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetUserResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateResponse
    {
        [JsonProperty("status")]
        public ClassCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassGetResponse
    {
        [JsonProperty("status")]
        public ClassGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassUpdateResponse
    {
        [JsonProperty("status")]
        public ClassUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassUpdateResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassUpdateResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassUpdateResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassUpdateResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassGetAssertionResponse
    {
        [JsonProperty("status")]
        public ClassGetAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassGetAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassGetAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueAssertionResponse
    {
        [JsonProperty("status")]
        public ClassIssueAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassIssueAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassIssueAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionGetAResponse
    {
        [JsonProperty("status")]
        public AssertionGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionGetAResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionGetAResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionGetAResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionGetAResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionUpdateResponse
    {
        [JsonProperty("status")]
        public AssertionUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionUpdateResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionUpdateResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class TokenGetResponse
    {
        [JsonProperty("status")]
        public TokenGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken[] Result { get; set; }
    }

    public class TokenGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class TokenGetAResponse
    {
        [JsonProperty("status")]
        public TokenGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class TokenGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserGetProfileResponse
    {
        [JsonProperty("status")]
        public UserGetProfileResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserGetProfileResponseResultTypeItem[] Result { get; set; }
    }

    public class UserGetProfileResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserGetProfileResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserGetProfileResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserGetProfileResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserCreateResponse
    {
        [JsonProperty("status")]
        public UserCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class UserCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserCreateResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserCreateResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class bodyemailsInputItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserUpdateResponse
    {
        [JsonProperty("status")]
        public UserUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class UserUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserUpdateResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserUpdateResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class BackpackGetAssertionResponse
    {
        [JsonProperty("status")]
        public BackpackGetAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackGetAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackGetAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackGetAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackGetAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUploadAssertionResponse
    {
        [JsonProperty("status")]
        public BackpackUploadAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackUploadAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackUploadAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackUploadAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUploadAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackGetAssertionDetailsResponse
    {
        [JsonProperty("status")]
        public BackpackGetAssertionDetailsResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackGetAssertionDetailsResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackGetAssertionDetailsResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackGetAssertionDetailsResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("pending")]
        public string Pending { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUpdateAcceptanceResponse
    {
        [JsonProperty("status")]
        public BackpackUpdateAcceptanceResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackUpdateAcceptanceResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackUpdateAcceptanceResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUpdateAcceptanceResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("pending")]
        public string Pending { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionGetResponse
    {
        [JsonProperty("status")]
        public CollectionGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionGetResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionCreateResponse
    {
        [JsonProperty("status")]
        public CollectionCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class bodyassertionsInputItem
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public bodyassertionsInputItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public bodyassertionsInputItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class bodyassertionsInputItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class bodyassertionsInputItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionGetAResponse
    {
        [JsonProperty("status")]
        public CollectionGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionUpdateResponse
    {
        [JsonProperty("status")]
        public CollectionUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueBulkResponse
    {
        [JsonProperty("status")]
        public ClassIssueBulkResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassIssueBulkResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassIssueBulkResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueBulkResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueBulkResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionRevokeBulkResponse
    {
        [JsonProperty("status")]
        public AssertionRevokeBulkResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionRevokeBulkResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionRevokeBulkResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionRevokeBulkResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionRevokeBulkResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AccountRecoverResponse
    {
        [JsonProperty("status")]
        public AccountRecoverResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class AccountRecoverResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Badgrip;

    public partial class WorkflowManagedActions
    {
        public BadgripActions Badgrip(string connectionId) => new BadgripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BadgripTriggers Badgrip(string connectionId) => new BadgripTriggers(connectionId);
    }
}