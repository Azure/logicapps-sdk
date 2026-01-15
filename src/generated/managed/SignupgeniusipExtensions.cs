//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Signupgeniusip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignupgeniusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ProfileResponse> Profile()
        {
            var apiCallPath = "/user/profile/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProfileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupListResponse> GroupList()
        {
            var apiCallPath = "/groups/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupMemberResponse> GroupMember(Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/groups/{0}/members/", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupMemberDetailResponse> GroupMemberDetail(Expression<Func<string>> groupID, Expression<Func<string>> memberID)
        {
            var apiCallPath = String.Format("/groups/{0}/members/{1}/details/", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1), ExpressionConverter.ConvertWithUrlEncoding(memberID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupMemberDetailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupUserAddResponse> GroupUserAdd(Expression<Func<string>> groupID, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyfirstname, Expression<Func<string>> bodylastname)
        {
            var apiCallPath = String.Format("/groups/{0}/members/create/", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["emailaddress"] = ExpressionConverter.ConvertO(bodyemailaddress);
            bodypropCount++;
            body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
            bodypropCount++;
            body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupUserAddResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpActiveResponse> SignUpActive()
        {
            var apiCallPath = "/signups/created/active/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignUpActiveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpAllResponse> SignUpAll()
        {
            var apiCallPath = "/signups/created/all/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignUpAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpExpiredResponse> SignUpExpired()
        {
            var apiCallPath = "/signups/created/expired/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignUpExpiredResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpInvitedResponse> SignUpInvited()
        {
            var apiCallPath = "/signups/invited/active";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignUpInvitedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpForResponse> SignUpFor()
        {
            var apiCallPath = "/signups/signedupfor/active";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignUpForResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignUpResponse> ReportSignUp(Expression<Func<string>> signUpID)
        {
            var apiCallPath = String.Format("/signups/report/all/{0}", ExpressionConverter.ConvertWithUrlEncoding(signUpID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReportSignUpResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignUpSlotResponse> ReportSignUpSlot(Expression<Func<string>> signUpID)
        {
            var apiCallPath = String.Format("/signups/report/available/{0}", ExpressionConverter.ConvertWithUrlEncoding(signUpID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReportSignUpSlotResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignupFilledResponse> ReportSignupFilled(Expression<Func<string>> signUpID)
        {
            var apiCallPath = String.Format("/signups/report/filled/{0}", ExpressionConverter.ConvertWithUrlEncoding(signUpID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReportSignupFilledResponse>(callPayload);
        }
    }

    public class SignupgeniusipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProfileResponse
    {
        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ProfileResponseDataType Data { get; set; }
    }

    public class ProfileResponseDataType
    {
        [JsonProperty("mobilephone")]
        public string Mobilephone { get; set; }

        [JsonProperty("preferredphone")]
        public string Preferredphone { get; set; }

        [JsonProperty("memberid")]
        public int Memberid { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("subscription")]
        public ProfileResponseDataTypeSubscriptionType Subscription { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("homephone")]
        public string Homephone { get; set; }

        [JsonProperty("issubadmin")]
        public bool Issubadmin { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("adminfor")]
        public string Adminfor { get; set; }

        [JsonProperty("companyname")]
        public string Companyname { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("workphone")]
        public string Workphone { get; set; }
    }

    public class ProfileResponseDataTypeSubscriptionType
    {
        [JsonProperty("ispro")]
        public bool Ispro { get; set; }

        [JsonProperty("prolevel")]
        public string Prolevel { get; set; }
    }

    public class GroupListResponse
    {
        [JsonProperty("data")]
        public GroupListResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public GroupListResponseLinksType Links { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GroupListResponseDataTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("groupid")]
        public int Groupid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GroupListResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class GroupMemberResponse
    {
        [JsonProperty("data")]
        public GroupMemberResponseDataType Data { get; set; }

        [JsonProperty("links")]
        public GroupMemberResponseLinksType Links { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GroupMemberResponseDataType
    {
        [JsonProperty("groupid")]
        public int Groupid { get; set; }

        [JsonProperty("members")]
        public GroupMemberResponseDataTypeMembersTypeItem[] Members { get; set; }
    }

    public class GroupMemberResponseDataTypeMembersTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("memberid")]
        public int Memberid { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }
    }

    public class GroupMemberResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class GroupMemberDetailResponse
    {
        [JsonProperty("data")]
        public GroupMemberDetailResponseDataType Data { get; set; }

        [JsonProperty("links")]
        public GroupMemberDetailResponseLinksType Links { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GroupMemberDetailResponseDataType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("memberid")]
        public int Memberid { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class GroupMemberDetailResponseLinksType
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class GroupUserAddResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpActiveResponse
    {
        [JsonProperty("data")]
        public SignUpActiveResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpActiveResponseDataTypeItem
    {
        [JsonProperty("contactname")]
        public string Contactname { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public string Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("groupid")]
        public int Groupid { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("mainimage")]
        public string Mainimage { get; set; }

        [JsonProperty("signupurl")]
        public string Signupurl { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public string Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SignUpAllResponse
    {
        [JsonProperty("data")]
        public SignUpAllResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpAllResponseDataTypeItem
    {
        [JsonProperty("contactname")]
        public string Contactname { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public string Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("groupid")]
        public int Groupid { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("mainimage")]
        public string Mainimage { get; set; }

        [JsonProperty("signupurl")]
        public string Signupurl { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public string Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SignUpExpiredResponse
    {
        [JsonProperty("data")]
        public SignUpExpiredResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpExpiredResponseDataTypeItem
    {
        [JsonProperty("contactname")]
        public string Contactname { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public string Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("groupid")]
        public int Groupid { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("mainimage")]
        public string Mainimage { get; set; }

        [JsonProperty("signupurl")]
        public string Signupurl { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public string Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SignUpInvitedResponse
    {
        [JsonProperty("data")]
        public SignUpInvitedResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpInvitedResponseDataTypeItem
    {
        [JsonProperty("contactname")]
        public string Contactname { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public string Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("mainimage")]
        public string Mainimage { get; set; }

        [JsonProperty("signupurl")]
        public string Signupurl { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public string Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SignUpForResponse
    {
        [JsonProperty("data")]
        public SignUpForResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SignUpForResponseDataTypeItem
    {
        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public string Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("items")]
        public SignUpForResponseDataTypeItemItemsTypeItem[] Items { get; set; }

        [JsonProperty("rsvp")]
        public string Rsvp { get; set; }

        [JsonProperty("rsvpid")]
        public int Rsvpid { get; set; }

        [JsonProperty("signupurl")]
        public string Signupurl { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public string Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SignUpForResponseDataTypeItemItemsTypeItem
    {
        [JsonProperty("itemmemberid")]
        public int Itemmemberid { get; set; }

        [JsonProperty("mycomment")]
        public string Mycomment { get; set; }

        [JsonProperty("myqty")]
        public int Myqty { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ReportSignUpResponse
    {
        [JsonProperty("data")]
        public ReportSignUpResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ReportSignUpResponseDataType
    {
        [JsonProperty("customquestions")]
        public ReportSignUpResponseDataTypeCustomquestionsTypeItem[] Customquestions { get; set; }

        [JsonProperty("signups")]
        public ReportSignUpResponseDataTypeSignupsTypeItem[] Signups { get; set; }
    }

    public class ReportSignUpResponseDataTypeCustomquestionsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ReportSignUpResponseDataTypeSignupsTypeItem
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("amountpaid")]
        public string Amountpaid { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customfields")]
        public ReportSignUpResponseDataTypeSignupsTypeItemCustomfieldsTypeItem[] Customfields { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public int Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("myqty")]
        public int Myqty { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phonetype")]
        public string Phonetype { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public int Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("itemmemberid")]
        public int Itemmemberid { get; set; }

        [JsonProperty("slotitemid")]
        public int Slotitemid { get; set; }
    }

    public class ReportSignUpResponseDataTypeSignupsTypeItemCustomfieldsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReportSignUpSlotResponse
    {
        [JsonProperty("data")]
        public ReportSignUpSlotResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ReportSignUpSlotResponseDataType
    {
        [JsonProperty("customquestions")]
        public ReportSignUpSlotResponseDataTypeCustomquestionsTypeItem[] Customquestions { get; set; }

        [JsonProperty("signups")]
        public ReportSignUpSlotResponseDataTypeSignupsTypeItem[] Signups { get; set; }
    }

    public class ReportSignUpSlotResponseDataTypeCustomquestionsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ReportSignUpSlotResponseDataTypeSignupsTypeItem
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("amountpaid")]
        public string Amountpaid { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customfields")]
        public ReportSignUpSlotResponseDataTypeSignupsTypeItemCustomfieldsTypeItem[] Customfields { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public int Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("myqty")]
        public int Myqty { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phonetype")]
        public string Phonetype { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public int Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("itemmemberid")]
        public int Itemmemberid { get; set; }

        [JsonProperty("slotitemid")]
        public int Slotitemid { get; set; }
    }

    public class ReportSignUpSlotResponseDataTypeSignupsTypeItemCustomfieldsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReportSignupFilledResponse
    {
        [JsonProperty("data")]
        public ReportSignupFilledResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ReportSignupFilledResponseDataType
    {
        [JsonProperty("customquestions")]
        public ReportSignupFilledResponseDataTypeCustomquestionsTypeItem[] Customquestions { get; set; }

        [JsonProperty("signups")]
        public ReportSignupFilledResponseDataTypeSignupsTypeItem[] Signups { get; set; }
    }

    public class ReportSignupFilledResponseDataTypeCustomquestionsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ReportSignupFilledResponseDataTypeSignupsTypeItem
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("amountpaid")]
        public string Amountpaid { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customfields")]
        public ReportSignupFilledResponseDataTypeSignupsTypeItemCustomfieldsTypeItem[] Customfields { get; set; }

        [JsonProperty("enddate")]
        public int Enddate { get; set; }

        [JsonProperty("enddatestring")]
        public int Enddatestring { get; set; }

        [JsonProperty("endtime")]
        public int Endtime { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("signupid")]
        public int Signupid { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("myqty")]
        public int Myqty { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phonetype")]
        public string Phonetype { get; set; }

        [JsonProperty("startdate")]
        public int Startdate { get; set; }

        [JsonProperty("startdatestring")]
        public int Startdatestring { get; set; }

        [JsonProperty("starttime")]
        public int Starttime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("itemmemberid")]
        public int Itemmemberid { get; set; }

        [JsonProperty("slotitemid")]
        public int Slotitemid { get; set; }
    }

    public class ReportSignupFilledResponseDataTypeSignupsTypeItemCustomfieldsTypeItem
    {
        [JsonProperty("customfieldid")]
        public int Customfieldid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Signupgeniusip;

    public partial class WorkflowManagedActions
    {
        public SignupgeniusipActions Signupgeniusip(string connectionId) => new SignupgeniusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignupgeniusipTriggers Signupgeniusip(string connectionId) => new SignupgeniusipTriggers(connectionId);
    }
}