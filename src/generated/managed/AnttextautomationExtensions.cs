//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Anttextautomation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string> PostAntTextEmail(Expression<Func<string>> postBodyParameteremailForAntTextBusiness, Expression<Func<string>> postBodyParameterantTextBusinessLicenseKey, Expression<Func<string>> postBodyParameterkeyPhraseConfirmation, Expression<Func<string>> postBodyParameterTemplateID, Expression<Func<string>> postBodyParameterTo, Expression<Func<postBodyParameterSaveCopyToSentItemsInput>> postBodyParameterSaveCopyToSentItems = null, Expression<Func<postBodyParameterImportanceInput>> postBodyParameterImportance = null, Expression<Func<string>> postBodyParameterFlowField1 = null, Expression<Func<string>> postBodyParameterFlowField2 = null, Expression<Func<string>> postBodyParameterFlowField3 = null, Expression<Func<string>> postBodyParameterFlowField4 = null, Expression<Func<string>> postBodyParameterFlowField5 = null, Expression<Func<string>> postBodyParameterFlowField6 = null, Expression<Func<string>> postBodyParameterFlowField7 = null, Expression<Func<string>> postBodyParameterFlowField8 = null, Expression<Func<string>> postBodyParameterFlowField9 = null, Expression<Func<string>> postBodyParameterFlowField10 = null, Expression<Func<string>> postBodyParameterFlowField11 = null, Expression<Func<string>> postBodyParameterFlowField12 = null, Expression<Func<string>> postBodyParameterFlowField13 = null, Expression<Func<string>> postBodyParameterFlowField14 = null, Expression<Func<string>> postBodyParameterFlowField15 = null, Expression<Func<string>> postBodyParameterFlowField16 = null, Expression<Func<string>> postBodyParameterFlowField17 = null, Expression<Func<string>> postBodyParameterFlowField18 = null, Expression<Func<string>> postBodyParameterFlowField19 = null, Expression<Func<string>> postBodyParameterFlowField20 = null, Expression<Func<postBodyParameterIncludeAntTextSignatureInput>> postBodyParameterIncludeAntTextSignature = null)
        {
            var apiCallPath = "/templates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postBodyParameter = new JObject();
            var postBodyParameterpropCount = 0;
            postBodyParameterpropCount++;
            postBodyParameter["AntTextOwner"] = ExpressionConverter.ConvertO(postBodyParameteremailForAntTextBusiness);
            postBodyParameterpropCount++;
            postBodyParameter["AntTextLicenseKey"] = ExpressionConverter.ConvertO(postBodyParameterantTextBusinessLicenseKey);
            postBodyParameterpropCount++;
            postBodyParameter["CalledFrom"] = ExpressionConverter.ConvertO(postBodyParameterkeyPhraseConfirmation);
            postBodyParameterpropCount++;
            postBodyParameter["TemplateID"] = ExpressionConverter.ConvertO(postBodyParameterTemplateID);
            postBodyParameterpropCount++;
            postBodyParameter["To"] = ExpressionConverter.ConvertO(postBodyParameterTo);
            if (postBodyParameterSaveCopyToSentItems != null)
            {
                postBodyParameter["SaveCopyToSentItems"] = ExpressionConverter.ConvertO(postBodyParameterSaveCopyToSentItems);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterImportance != null)
            {
                postBodyParameter["Importance"] = ExpressionConverter.ConvertO(postBodyParameterImportance);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField1 != null)
            {
                postBodyParameter["FlowField1"] = ExpressionConverter.ConvertO(postBodyParameterFlowField1);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField2 != null)
            {
                postBodyParameter["FlowField2"] = ExpressionConverter.ConvertO(postBodyParameterFlowField2);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField3 != null)
            {
                postBodyParameter["FlowField3"] = ExpressionConverter.ConvertO(postBodyParameterFlowField3);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField4 != null)
            {
                postBodyParameter["FlowField4"] = ExpressionConverter.ConvertO(postBodyParameterFlowField4);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField5 != null)
            {
                postBodyParameter["FlowField5"] = ExpressionConverter.ConvertO(postBodyParameterFlowField5);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField6 != null)
            {
                postBodyParameter["FlowField6"] = ExpressionConverter.ConvertO(postBodyParameterFlowField6);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField7 != null)
            {
                postBodyParameter["FlowField7"] = ExpressionConverter.ConvertO(postBodyParameterFlowField7);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField8 != null)
            {
                postBodyParameter["FlowField8"] = ExpressionConverter.ConvertO(postBodyParameterFlowField8);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField9 != null)
            {
                postBodyParameter["FlowField9"] = ExpressionConverter.ConvertO(postBodyParameterFlowField9);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField10 != null)
            {
                postBodyParameter["FlowField10"] = ExpressionConverter.ConvertO(postBodyParameterFlowField10);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField11 != null)
            {
                postBodyParameter["FlowField11"] = ExpressionConverter.ConvertO(postBodyParameterFlowField11);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField12 != null)
            {
                postBodyParameter["FlowField12"] = ExpressionConverter.ConvertO(postBodyParameterFlowField12);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField13 != null)
            {
                postBodyParameter["FlowField13"] = ExpressionConverter.ConvertO(postBodyParameterFlowField13);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField14 != null)
            {
                postBodyParameter["FlowField14"] = ExpressionConverter.ConvertO(postBodyParameterFlowField14);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField15 != null)
            {
                postBodyParameter["FlowField15"] = ExpressionConverter.ConvertO(postBodyParameterFlowField15);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField16 != null)
            {
                postBodyParameter["FlowField16"] = ExpressionConverter.ConvertO(postBodyParameterFlowField16);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField17 != null)
            {
                postBodyParameter["FlowField17"] = ExpressionConverter.ConvertO(postBodyParameterFlowField17);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField18 != null)
            {
                postBodyParameter["FlowField18"] = ExpressionConverter.ConvertO(postBodyParameterFlowField18);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField19 != null)
            {
                postBodyParameter["FlowField19"] = ExpressionConverter.ConvertO(postBodyParameterFlowField19);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterFlowField20 != null)
            {
                postBodyParameter["FlowField20"] = ExpressionConverter.ConvertO(postBodyParameterFlowField20);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterIncludeAntTextSignature != null)
            {
                postBodyParameter["IncludeAntTextSignature"] = ExpressionConverter.ConvertO(postBodyParameterIncludeAntTextSignature);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterpropCount > 0)
            {
                callPayload.Body = postBodyParameter;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class AnttextautomationTriggers([ConnectionName] string connectionId)
    {
    }

    public enum postBodyParameterSaveCopyToSentItemsInput
    {
        Yes,
        No
    }

    public enum postBodyParameterImportanceInput
    {
        High,
        Normal,
        Low
    }

    public enum postBodyParameterIncludeAntTextSignatureInput
    {
        Yes,
        No
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Anttextautomation;

    public partial class WorkflowManagedActions
    {
        public AnttextautomationActions Anttextautomation(string connectionId) => new AnttextautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnttextautomationTriggers Anttextautomation(string connectionId) => new AnttextautomationTriggers(connectionId);
    }
}