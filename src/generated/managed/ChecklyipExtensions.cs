//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Checklyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ChecklyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "checklyip")]
        public IBodyWorkflowAction<string> GetV1BadgesChecksCheckid(Expression<Func<string>> checkId, Expression<Func<styleInput>> style = null, Expression<Func<themeInput>> theme = null, Expression<Func<bool>> responseTime = null)
        {
            var apiCallPath = String.Format("/v1/badges/checks/{0}", ExpressionConverter.ConvertWithUrlEncoding(checkId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["style"] = Convert.ToString("flat");
            if (style != null)
                callPayload.Queries["style"] = ExpressionConverter.Convert(style);
            callPayload.Queries["theme"] = Convert.ToString("default");
            if (theme != null)
                callPayload.Queries["theme"] = ExpressionConverter.Convert(theme);
            callPayload.Queries["responseTime"] = Convert.ToString(false);
            if (responseTime != null)
                callPayload.Queries["responseTime"] = ExpressionConverter.Convert(responseTime);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "checklyip")]
        public IBodyWorkflowAction<string> GetV1BadgesGroupsGroupid(Expression<Func<int>> groupId, Expression<Func<styleInput>> style = null, Expression<Func<themeInput>> theme = null, Expression<Func<bool>> responseTime = null)
        {
            var apiCallPath = String.Format("/v1/badges/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["style"] = Convert.ToString("flat");
            if (style != null)
                callPayload.Queries["style"] = ExpressionConverter.Convert(style);
            callPayload.Queries["theme"] = Convert.ToString("default");
            if (theme != null)
                callPayload.Queries["theme"] = ExpressionConverter.Convert(theme);
            callPayload.Queries["responseTime"] = Convert.ToString(false);
            if (responseTime != null)
                callPayload.Queries["responseTime"] = ExpressionConverter.Convert(responseTime);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ChecklyipTriggers([ConnectionName] string connectionId)
    {
    }

    public enum styleInput
    {
        [EnumMember(Value = "flat")]
        Flat,
        [EnumMember(Value = "plastic")]
        Plastic,
        [EnumMember(Value = "flat-square")]
        FlatSquare,
        [EnumMember(Value = "for-the-badge")]
        ForTheBadge,
        [EnumMember(Value = "social")]
        Social
    }

    public enum themeInput
    {
        [EnumMember(Value = "light")]
        Light,
        [EnumMember(Value = "dark")]
        Dark,
        [EnumMember(Value = "default")]
        Default
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Checklyip;

    public partial class WorkflowManagedActions
    {
        public ChecklyipActions Checklyip(string connectionId) => new ChecklyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ChecklyipTriggers Checklyip(string connectionId) => new ChecklyipTriggers(connectionId);
    }
}