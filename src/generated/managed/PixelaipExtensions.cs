//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete()
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<string> bodytoken = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<bodyagreeTermsOfServiceInput> bodyagreeTermsOfService = null, [WorkflowExpression] Func<bodynotMinorInput> bodynotMinor = null, [WorkflowExpression] Func<string> bodythanksCode = null)
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytoken != null)
            {
                body["token"] = ExpressionConverter.ConvertO(bodytoken);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodyagreeTermsOfService != null)
            {
                if (bodyagreeTermsOfService != null)
                {
                    body["agreeTermsOfService"] = ExpressionConverter.ConvertO(bodyagreeTermsOfService);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["agreeTermsOfService"] = "yes";
                bodypropCount++;
            }

            if (bodynotMinor != null)
            {
                if (bodynotMinor != null)
                {
                    body["notMinor"] = ExpressionConverter.ConvertO(bodynotMinor);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["notMinor"] = "yes";
                bodypropCount++;
            }

            if (bodythanksCode != null)
            {
                body["thanksCode"] = ExpressionConverter.ConvertO(bodythanksCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<TokenPutResponse> TokenPut([WorkflowExpression] Func<string> bodynewToken, [WorkflowExpression] Func<string> bodythanksCode = null)
        {
            var apiCallPath = "/v1/users/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["newToken"] = ExpressionConverter.ConvertO(bodynewToken);
            if (bodythanksCode != null)
            {
                body["thanksCode"] = ExpressionConverter.ConvertO(bodythanksCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TokenPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<ProfilePutResponse> ProfilePut([WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodygravatarIconEmail = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyaboutURL = null, [WorkflowExpression] Func<string[]> bodycontributeURLs = null, [WorkflowExpression] Func<string> bodypinnedGraphID = null)
        {
            var apiCallPath = "/@";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodygravatarIconEmail != null)
            {
                body["gravatarIconEmail"] = ExpressionConverter.ConvertO(bodygravatarIconEmail);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyaboutURL != null)
            {
                body["aboutURL"] = ExpressionConverter.ConvertO(bodyaboutURL);
                bodypropCount++;
            }

            if (bodycontributeURLs != null)
            {
                body["contributeURLs"] = ExpressionConverter.ConvertO(bodycontributeURLs);
                bodypropCount++;
            }

            if (bodypinnedGraphID != null)
            {
                body["pinnedGraphID"] = ExpressionConverter.ConvertO(bodypinnedGraphID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProfilePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphsGetResponse> GraphsGet()
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GraphsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse> GraphDelete([WorkflowExpression] Func<string> graphID)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<GraphDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse> Graph([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyunit, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bodycolorInput> bodycolor, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyselfSufficient = null, [WorkflowExpression] Func<bool> bodyisSecret = null, [WorkflowExpression] Func<bool> bodypublishOptionalData = null)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["unit"] = ExpressionConverter.ConvertO(bodyunit);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["color"] = ExpressionConverter.ConvertO(bodycolor);
            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyselfSufficient != null)
            {
                body["selfSufficient"] = ExpressionConverter.ConvertO(bodyselfSufficient);
                bodypropCount++;
            }

            if (bodyisSecret != null)
            {
                body["isSecret"] = ExpressionConverter.ConvertO(bodyisSecret);
                bodypropCount++;
            }

            if (bodypublishOptionalData != null)
            {
                body["publishOptionalData"] = ExpressionConverter.ConvertO(bodypublishOptionalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GraphPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPutResponse> GraphPut([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyunit = null, [WorkflowExpression] Func<bodycolorInput> bodycolor = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodyselfSufficient = null, [WorkflowExpression] Func<bool> bodyisSecret = null, [WorkflowExpression] Func<bool> bodypublishOptionalData = null)
        {
            var apiCallPath = "/v1/users/graphs";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyunit != null)
            {
                if (bodyunit != null)
                {
                    body["unit"] = ExpressionConverter.ConvertO(bodyunit);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["unit"] = "commit";
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                if (bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(bodycolor);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["color"] = "shibafu";
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyselfSufficient != null)
            {
                body["selfSufficient"] = ExpressionConverter.ConvertO(bodyselfSufficient);
                bodypropCount++;
            }

            if (bodyisSecret != null)
            {
                body["isSecret"] = ExpressionConverter.ConvertO(bodyisSecret);
                bodypropCount++;
            }

            if (bodypublishOptionalData != null)
            {
                body["publishOptionalData"] = ExpressionConverter.ConvertO(bodypublishOptionalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GraphPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphGetResponse> GraphGet([WorkflowExpression] Func<string> graphID)
        {
            var apiCallPath = "/v1/users/graphs/graph-def";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<GraphGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse> GraphSVGGet([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<modeInput> mode = null, [WorkflowExpression] Func<appearanceInput> appearance = null)
        {
            var apiCallPath = "/v1/users/graphs/graphSVG";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            if (mode != null)
                callPayload.Queries["mode"] = ExpressionConverter.Convert(mode);
            if (appearance != null)
                callPayload.Queries["appearance"] = ExpressionConverter.Convert(appearance);
            return new ApiConnectionAction<GraphSVGGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelsGetResponse> PixelsGet([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<bool> withBody = null)
        {
            var apiCallPath = "/v1/users/graphs/pixels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            if (withBody != null)
                callPayload.Queries["withBody"] = ExpressionConverter.Convert(withBody);
            return new ApiConnectionAction<PixelsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<StatsGetResponse> StatsGet([WorkflowExpression] Func<string> graphID)
        {
            var apiCallPath = "/v1/users/graphs/stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            return new ApiConnectionAction<StatsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse> Pixel([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodyquantity)
        {
            var apiCallPath = "/v1/users/graphs/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            bodypropCount++;
            body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
            var optionalDataObject = new JObject();
            var optionalDataObjectpropCount = 0;
            if (optionalDataObjectpropCount > 0)
            {
                body["optionalData"] = optionalDataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse> PixelRetinaGet([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<string> yyyyMMdd)
        {
            var apiCallPath = "/v1/users/graphs/pixel/retina";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(yyyyMMdd);
            return new ApiConnectionAction<PixelRetinaGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse> PixelIncrementPut([WorkflowExpression] Func<string> graphID = null)
        {
            var apiCallPath = "/v1/users/graphs/increment";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (graphID != null)
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Headers["Content-Length"] = Convert.ToString(0);
            return new ApiConnectionAction<PixelIncrementPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse> PixelDecrementPut([WorkflowExpression] Func<string> graphID = null)
        {
            var apiCallPath = "/v1/users/graphs/decrement";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (graphID != null)
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            callPayload.Headers["Content-Length"] = Convert.ToString(0);
            return new ApiConnectionAction<PixelDecrementPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse> PixelAddPut([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            var apiCallPath = "/v1/users/graphs/add";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelAddPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelSubtractPutResponse> PixelSubtractPut([WorkflowExpression] Func<string> graphID, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            var apiCallPath = "/v1/users/graphs/subtract";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["graphID"] = ExpressionConverter.Convert(graphID);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelSubtractPutResponse>(callPayload);
        }
    }

    public class PixelaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class UserPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public enum bodyagreeTermsOfServiceInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public enum bodynotMinorInput
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class TokenPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class ProfilePutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphsGetResponse
    {
        [JsonProperty("graphs")]
        public GraphsGetResponseGraphsTypeItem[] Graphs { get; set; }
    }

    public class GraphsGetResponseGraphsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "float")]
        Float
    }

    public enum bodycolorInput
    {
        [EnumMember(Value = "shibafu")]
        Shibafu,
        [EnumMember(Value = "momiji")]
        Momiji,
        [EnumMember(Value = "sora")]
        Sora,
        [EnumMember(Value = "ichou")]
        Ichou,
        [EnumMember(Value = "ajisai")]
        Ajisai,
        [EnumMember(Value = "kuro")]
        Kuro
    }

    public class GraphPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphSVGGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public enum modeInput
    {
        [EnumMember(Value = "short")]
        Short,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "line")]
        Line
    }

    public enum appearanceInput
    {
        [EnumMember(Value = "dark")]
        Dark
    }

    public class PixelsGetResponse
    {
        [JsonProperty("pixels")]
        public PixelsGetResponsePixelsTypeItem[] Pixels { get; set; }
    }

    public class PixelsGetResponsePixelsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("optionalData")]
        public JToken OptionalData { get; set; }
    }

    public class StatsGetResponse
    {
        [JsonProperty("totalPixelsCount")]
        public int TotalPixelsCount { get; set; }

        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }

        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("avgQuantity")]
        public double AvgQuantity { get; set; }

        [JsonProperty("todaysQuantity")]
        public int TodaysQuantity { get; set; }
    }

    public class PixelPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelGetResponse
    {
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class PixelDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelRetinaGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class PixelIncrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelDecrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelAddPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelSubtractPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip;

    public partial class WorkflowManagedActions
    {
        public PixelaipActions Pixelaip(string connectionId) => new PixelaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelaipTriggers Pixelaip(string connectionId) => new PixelaipTriggers(connectionId);
    }
}