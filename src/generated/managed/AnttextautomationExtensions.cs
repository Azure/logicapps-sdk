//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string> PostAntTextEmail(Expression<Func<string>> postBodyParameteremailForAntTextBusiness, Expression<Func<string>> postBodyParameterantTextBusinessLicenseKey, Expression<Func<string>> postBodyParameterkeyPhraseConfirmation, Expression<Func<string>> postBodyParametertemplateID, Expression<Func<string>> postBodyParameterto, Expression<Func<postBodyParametersaveCopyToSentItemsInput>> postBodyParametersaveCopyToSentItems = null, Expression<Func<postBodyParameterimportanceInput>> postBodyParameterimportance = null, Expression<Func<string>> postBodyParameterflowField1 = null, Expression<Func<string>> postBodyParameterflowField2 = null, Expression<Func<string>> postBodyParameterflowField3 = null, Expression<Func<string>> postBodyParameterflowField4 = null, Expression<Func<string>> postBodyParameterflowField5 = null, Expression<Func<string>> postBodyParameterflowField6 = null, Expression<Func<string>> postBodyParameterflowField7 = null, Expression<Func<string>> postBodyParameterflowField8 = null, Expression<Func<string>> postBodyParameterflowField9 = null, Expression<Func<string>> postBodyParameterflowField10 = null, Expression<Func<string>> postBodyParameterflowField11 = null, Expression<Func<string>> postBodyParameterflowField12 = null, Expression<Func<string>> postBodyParameterflowField13 = null, Expression<Func<string>> postBodyParameterflowField14 = null, Expression<Func<string>> postBodyParameterflowField15 = null, Expression<Func<string>> postBodyParameterflowField16 = null, Expression<Func<string>> postBodyParameterflowField17 = null, Expression<Func<string>> postBodyParameterflowField18 = null, Expression<Func<string>> postBodyParameterflowField19 = null, Expression<Func<string>> postBodyParameterflowField20 = null, Expression<Func<postBodyParameterincludeAntTextSignatureInput>> postBodyParameterincludeAntTextSignature = null)
        {
            var apiCallPath = "/templates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postBodyParameter = new JObject();
            var postBodyParameterpropCount = 0;
            postBodyParameterpropCount++;
            postBodyParameter["AntTextOwner"] = CSharpExpressionConverter.ConvertToken(postBodyParameteremailForAntTextBusiness);
            postBodyParameterpropCount++;
            postBodyParameter["AntTextLicenseKey"] = CSharpExpressionConverter.ConvertToken(postBodyParameterantTextBusinessLicenseKey);
            postBodyParameterpropCount++;
            postBodyParameter["CalledFrom"] = CSharpExpressionConverter.ConvertToken(postBodyParameterkeyPhraseConfirmation);
            postBodyParameterpropCount++;
            postBodyParameter["TemplateID"] = CSharpExpressionConverter.ConvertToken(postBodyParametertemplateID);
            postBodyParameterpropCount++;
            postBodyParameter["To"] = CSharpExpressionConverter.ConvertToken(postBodyParameterto);
            if (postBodyParametersaveCopyToSentItems != null)
            {
                if (postBodyParametersaveCopyToSentItems != null)
                {
                    postBodyParameter["SaveCopyToSentItems"] = CSharpExpressionConverter.Convert(postBodyParametersaveCopyToSentItems);
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
                    postBodyParameter["Importance"] = CSharpExpressionConverter.Convert(postBodyParameterimportance);
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
                postBodyParameter["FlowField1"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField1);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField2 != null)
            {
                postBodyParameter["FlowField2"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField2);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField3 != null)
            {
                postBodyParameter["FlowField3"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField3);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField4 != null)
            {
                postBodyParameter["FlowField4"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField4);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField5 != null)
            {
                postBodyParameter["FlowField5"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField5);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField6 != null)
            {
                postBodyParameter["FlowField6"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField6);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField7 != null)
            {
                postBodyParameter["FlowField7"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField7);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField8 != null)
            {
                postBodyParameter["FlowField8"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField8);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField9 != null)
            {
                postBodyParameter["FlowField9"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField9);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField10 != null)
            {
                postBodyParameter["FlowField10"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField10);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField11 != null)
            {
                postBodyParameter["FlowField11"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField11);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField12 != null)
            {
                postBodyParameter["FlowField12"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField12);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField13 != null)
            {
                postBodyParameter["FlowField13"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField13);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField14 != null)
            {
                postBodyParameter["FlowField14"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField14);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField15 != null)
            {
                postBodyParameter["FlowField15"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField15);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField16 != null)
            {
                postBodyParameter["FlowField16"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField16);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField17 != null)
            {
                postBodyParameter["FlowField17"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField17);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField18 != null)
            {
                postBodyParameter["FlowField18"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField18);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField19 != null)
            {
                postBodyParameter["FlowField19"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField19);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterflowField20 != null)
            {
                postBodyParameter["FlowField20"] = CSharpExpressionConverter.ConvertToken(postBodyParameterflowField20);
                postBodyParameterpropCount++;
            }

            if (postBodyParameterincludeAntTextSignature != null)
            {
                if (postBodyParameterincludeAntTextSignature != null)
                {
                    postBodyParameter["IncludeAntTextSignature"] = CSharpExpressionConverter.Convert(postBodyParameterincludeAntTextSignature);
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