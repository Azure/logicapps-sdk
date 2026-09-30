//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signupgeniusip
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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/profile/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupListResponse> GroupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/groups/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GroupListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupMemberResponse> GroupMember([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/members/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GroupMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupMemberDetailResponse> GroupMemberDetail([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> memberId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/members/{1}/details/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GroupMemberDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<GroupUserAddResponse> GroupUserAdd([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodyemailaddress, [WorkflowExpression] Func<string> bodyfirstname, [WorkflowExpression] Func<string> bodylastname)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodyemailaddress, nameof(bodyemailaddress), required: true);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: true);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/members/create/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["emailaddress"] = SourceExpressionConverter.ConvertToken(bodyemailaddress);
                bodypropCount++;
                body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
                body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GroupUserAddResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpActiveResponse> SignUpActive()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signups/created/active/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignUpActiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpAllResponse> SignUpAll()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signups/created/all/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignUpAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpExpiredResponse> SignUpExpired()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signups/created/expired/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignUpExpiredResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpInvitedResponse> SignUpInvited()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signups/invited/active";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignUpInvitedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<SignUpForResponse> SignUpFor()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signups/signedupfor/active";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignUpForResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignUpResponse> ReportSignUp([WorkflowExpression] Func<string> signUpId)
        {
            SourceExpression.Validate(signUpId, nameof(signUpId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signups/report/all/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signUpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportSignUpResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignUpSlotResponse> ReportSignUpSlot([WorkflowExpression] Func<string> signUpId)
        {
            SourceExpression.Validate(signUpId, nameof(signUpId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signups/report/available/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signUpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportSignUpSlotResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signupgeniusip")]
        public IBodyWorkflowAction<ReportSignupFilledResponse> ReportSignupFilled([WorkflowExpression] Func<string> signUpId)
        {
            SourceExpression.Validate(signUpId, nameof(signUpId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signups/report/filled/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signUpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReportSignupFilledResponse>(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signupgeniusip;

    public partial class WorkflowManagedActions
    {
        public SignupgeniusipActions Signupgeniusip(string connectionId) => new SignupgeniusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignupgeniusipTriggers Signupgeniusip(string connectionId) => new SignupgeniusipTriggers(connectionId);
    }
}