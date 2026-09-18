//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string> PostAntTextEmail([WorkflowExpression] Func<string> postBodyParameteremailForAntTextBusiness, [WorkflowExpression] Func<string> postBodyParameterantTextBusinessLicenseKey, [WorkflowExpression] Func<string> postBodyParameterkeyPhraseConfirmation, [WorkflowExpression] Func<string> postBodyParametertemplateID, [WorkflowExpression] Func<string> postBodyParameterto, [WorkflowExpression] Func<postBodyParametersaveCopyToSentItemsInput> postBodyParametersaveCopyToSentItems = null, [WorkflowExpression] Func<postBodyParameterimportanceInput> postBodyParameterimportance = null, [WorkflowExpression] Func<string> postBodyParameterflowField1 = null, [WorkflowExpression] Func<string> postBodyParameterflowField2 = null, [WorkflowExpression] Func<string> postBodyParameterflowField3 = null, [WorkflowExpression] Func<string> postBodyParameterflowField4 = null, [WorkflowExpression] Func<string> postBodyParameterflowField5 = null, [WorkflowExpression] Func<string> postBodyParameterflowField6 = null, [WorkflowExpression] Func<string> postBodyParameterflowField7 = null, [WorkflowExpression] Func<string> postBodyParameterflowField8 = null, [WorkflowExpression] Func<string> postBodyParameterflowField9 = null, [WorkflowExpression] Func<string> postBodyParameterflowField10 = null, [WorkflowExpression] Func<string> postBodyParameterflowField11 = null, [WorkflowExpression] Func<string> postBodyParameterflowField12 = null, [WorkflowExpression] Func<string> postBodyParameterflowField13 = null, [WorkflowExpression] Func<string> postBodyParameterflowField14 = null, [WorkflowExpression] Func<string> postBodyParameterflowField15 = null, [WorkflowExpression] Func<string> postBodyParameterflowField16 = null, [WorkflowExpression] Func<string> postBodyParameterflowField17 = null, [WorkflowExpression] Func<string> postBodyParameterflowField18 = null, [WorkflowExpression] Func<string> postBodyParameterflowField19 = null, [WorkflowExpression] Func<string> postBodyParameterflowField20 = null, [WorkflowExpression] Func<postBodyParameterincludeAntTextSignatureInput> postBodyParameterincludeAntTextSignature = null)
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
            postBodyParameter["TemplateID"] = ExpressionConverter.ConvertO(postBodyParametertemplateID);
            postBodyParameterpropCount++;
            postBodyParameter["To"] = ExpressionConverter.ConvertO(postBodyParameterto);
            if (postBodyParametersaveCopyToSentItems != null)
            {
                if (postBodyParametersaveCopyToSentItems != null)
                {
                    postBodyParameter["SaveCopyToSentItems"] = ExpressionConverter.ConvertO(postBodyParametersaveCopyToSentItems);
                    postBodyParameterpropCount++;
                }

                postBodyParameterpropCount++;
            }
            else
            {
                postBodyParameter["SaveCopyToSentItems"] = "Yes";
                postBodyParameterpropCount++;
            }

            if (postBodyParameterimportance != null)
            {
                if (postBodyParameterimportance != null)
                {
                    postBodyParameter["Importance"] = ExpressionConverter.ConvertO(postBodyParameterimportance);
                    postBodyParameterpropCount++;
                }

                postBodyParameterpropCount++;
            }
            else
            {
                postBodyParameter["Importance"] = "Normal";
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField1 != null)
            {
                postBodyParameter["FlowField1"] = ExpressionConverter.ConvertO(postBodyParameterflowField1);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField2 != null)
            {
                postBodyParameter["FlowField2"] = ExpressionConverter.ConvertO(postBodyParameterflowField2);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField3 != null)
            {
                postBodyParameter["FlowField3"] = ExpressionConverter.ConvertO(postBodyParameterflowField3);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField4 != null)
            {
                postBodyParameter["FlowField4"] = ExpressionConverter.ConvertO(postBodyParameterflowField4);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField5 != null)
            {
                postBodyParameter["FlowField5"] = ExpressionConverter.ConvertO(postBodyParameterflowField5);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField6 != null)
            {
                postBodyParameter["FlowField6"] = ExpressionConverter.ConvertO(postBodyParameterflowField6);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField7 != null)
            {
                postBodyParameter["FlowField7"] = ExpressionConverter.ConvertO(postBodyParameterflowField7);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField8 != null)
            {
                postBodyParameter["FlowField8"] = ExpressionConverter.ConvertO(postBodyParameterflowField8);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField9 != null)
            {
                postBodyParameter["FlowField9"] = ExpressionConverter.ConvertO(postBodyParameterflowField9);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField10 != null)
            {
                postBodyParameter["FlowField10"] = ExpressionConverter.ConvertO(postBodyParameterflowField10);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField11 != null)
            {
                postBodyParameter["FlowField11"] = ExpressionConverter.ConvertO(postBodyParameterflowField11);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField12 != null)
            {
                postBodyParameter["FlowField12"] = ExpressionConverter.ConvertO(postBodyParameterflowField12);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField13 != null)
            {
                postBodyParameter["FlowField13"] = ExpressionConverter.ConvertO(postBodyParameterflowField13);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField14 != null)
            {
                postBodyParameter["FlowField14"] = ExpressionConverter.ConvertO(postBodyParameterflowField14);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField15 != null)
            {
                postBodyParameter["FlowField15"] = ExpressionConverter.ConvertO(postBodyParameterflowField15);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField16 != null)
            {
                postBodyParameter["FlowField16"] = ExpressionConverter.ConvertO(postBodyParameterflowField16);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField17 != null)
            {
                postBodyParameter["FlowField17"] = ExpressionConverter.ConvertO(postBodyParameterflowField17);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField18 != null)
            {
                postBodyParameter["FlowField18"] = ExpressionConverter.ConvertO(postBodyParameterflowField18);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField19 != null)
            {
                postBodyParameter["FlowField19"] = ExpressionConverter.ConvertO(postBodyParameterflowField19);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField20 != null)
            {
                postBodyParameter["FlowField20"] = ExpressionConverter.ConvertO(postBodyParameterflowField20);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterincludeAntTextSignature != null)
            {
                if (postBodyParameterincludeAntTextSignature != null)
                {
                    postBodyParameter["IncludeAntTextSignature"] = ExpressionConverter.ConvertO(postBodyParameterincludeAntTextSignature);
                    postBodyParameterpropCount++;
                }

                postBodyParameterpropCount++;
            }
            else
            {
                postBodyParameter["IncludeAntTextSignature"] = "Yes";
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

    public enum postBodyParametersaveCopyToSentItemsInput
    {
        Yes,
        No
    }

    public enum postBodyParameterimportanceInput
    {
        High,
        Normal,
        Low
    }

    public enum postBodyParameterincludeAntTextSignatureInput
    {
        Yes,
        No
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation;

    public partial class WorkflowManagedActions
    {
        public AnttextautomationActions Anttextautomation(string connectionId) => new AnttextautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnttextautomationTriggers Anttextautomation(string connectionId) => new AnttextautomationTriggers(connectionId);
    }
}