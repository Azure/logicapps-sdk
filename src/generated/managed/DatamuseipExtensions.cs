//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatamuseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datamuseip")]
        public IBodyWorkflowAction<WordsResponseItem[]> Words([WorkflowExpression] Func<string> ml = null, [WorkflowExpression] Func<string> sl = null, [WorkflowExpression] Func<string> sp = null, [WorkflowExpression] Func<string> relJja = null, [WorkflowExpression] Func<string> relJjb = null, [WorkflowExpression] Func<string> relSyn = null, [WorkflowExpression] Func<string> relTrg = null, [WorkflowExpression] Func<string> relAnt = null, [WorkflowExpression] Func<string> relSpc = null, [WorkflowExpression] Func<string> relGen = null, [WorkflowExpression] Func<string> relCom = null, [WorkflowExpression] Func<string> relPar = null, [WorkflowExpression] Func<string> relBga = null, [WorkflowExpression] Func<string> relBgb = null, [WorkflowExpression] Func<string> relRhy = null, [WorkflowExpression] Func<string> relNry = null, [WorkflowExpression] Func<string> relHom = null, [WorkflowExpression] Func<string> relCns = null, [WorkflowExpression] Func<string> v = null, [WorkflowExpression] Func<string> topics = null, [WorkflowExpression] Func<string> lc = null, [WorkflowExpression] Func<string> rc = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<string> md = null)
        {
            SourceExpression.Validate(ml, nameof(ml), required: false);
            SourceExpression.Validate(sl, nameof(sl), required: false);
            SourceExpression.Validate(sp, nameof(sp), required: false);
            SourceExpression.Validate(relJja, nameof(relJja), required: false);
            SourceExpression.Validate(relJjb, nameof(relJjb), required: false);
            SourceExpression.Validate(relSyn, nameof(relSyn), required: false);
            SourceExpression.Validate(relTrg, nameof(relTrg), required: false);
            SourceExpression.Validate(relAnt, nameof(relAnt), required: false);
            SourceExpression.Validate(relSpc, nameof(relSpc), required: false);
            SourceExpression.Validate(relGen, nameof(relGen), required: false);
            SourceExpression.Validate(relCom, nameof(relCom), required: false);
            SourceExpression.Validate(relPar, nameof(relPar), required: false);
            SourceExpression.Validate(relBga, nameof(relBga), required: false);
            SourceExpression.Validate(relBgb, nameof(relBgb), required: false);
            SourceExpression.Validate(relRhy, nameof(relRhy), required: false);
            SourceExpression.Validate(relNry, nameof(relNry), required: false);
            SourceExpression.Validate(relHom, nameof(relHom), required: false);
            SourceExpression.Validate(relCns, nameof(relCns), required: false);
            SourceExpression.Validate(v, nameof(v), required: false);
            SourceExpression.Validate(topics, nameof(topics), required: false);
            SourceExpression.Validate(lc, nameof(lc), required: false);
            SourceExpression.Validate(rc, nameof(rc), required: false);
            SourceExpression.Validate(max, nameof(max), required: false);
            SourceExpression.Validate(md, nameof(md), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/words";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ml != null)
                    callPayload.Queries["ml"] = SourceExpressionConverter.ConvertO(ml);
                if (sl != null)
                    callPayload.Queries["sl"] = SourceExpressionConverter.ConvertO(sl);
                if (sp != null)
                    callPayload.Queries["sp"] = SourceExpressionConverter.ConvertO(sp);
                if (relJja != null)
                    callPayload.Queries["rel_jja"] = SourceExpressionConverter.ConvertO(relJja);
                if (relJjb != null)
                    callPayload.Queries["rel_jjb"] = SourceExpressionConverter.ConvertO(relJjb);
                if (relSyn != null)
                    callPayload.Queries["rel_syn"] = SourceExpressionConverter.ConvertO(relSyn);
                if (relTrg != null)
                    callPayload.Queries["rel_trg"] = SourceExpressionConverter.ConvertO(relTrg);
                if (relAnt != null)
                    callPayload.Queries["rel_ant"] = SourceExpressionConverter.ConvertO(relAnt);
                if (relSpc != null)
                    callPayload.Queries["rel_spc"] = SourceExpressionConverter.ConvertO(relSpc);
                if (relGen != null)
                    callPayload.Queries["rel_gen"] = SourceExpressionConverter.ConvertO(relGen);
                if (relCom != null)
                    callPayload.Queries["rel_com"] = SourceExpressionConverter.ConvertO(relCom);
                if (relPar != null)
                    callPayload.Queries["rel_par"] = SourceExpressionConverter.ConvertO(relPar);
                if (relBga != null)
                    callPayload.Queries["rel_bga"] = SourceExpressionConverter.ConvertO(relBga);
                if (relBgb != null)
                    callPayload.Queries["rel_bgb"] = SourceExpressionConverter.ConvertO(relBgb);
                if (relRhy != null)
                    callPayload.Queries["rel_rhy"] = SourceExpressionConverter.ConvertO(relRhy);
                if (relNry != null)
                    callPayload.Queries["rel_nry"] = SourceExpressionConverter.ConvertO(relNry);
                if (relHom != null)
                    callPayload.Queries["rel_hom"] = SourceExpressionConverter.ConvertO(relHom);
                if (relCns != null)
                    callPayload.Queries["rel_cns"] = SourceExpressionConverter.ConvertO(relCns);
                if (v != null)
                    callPayload.Queries["v"] = SourceExpressionConverter.ConvertO(v);
                if (topics != null)
                    callPayload.Queries["topics"] = SourceExpressionConverter.ConvertO(topics);
                if (lc != null)
                    callPayload.Queries["lc"] = SourceExpressionConverter.ConvertO(lc);
                if (rc != null)
                    callPayload.Queries["rc"] = SourceExpressionConverter.ConvertO(rc);
                callPayload.Queries["max"] = Convert.ToString(100);
                if (max != null)
                    callPayload.Queries["max"] = SourceExpressionConverter.ConvertO(max);
                if (md != null)
                    callPayload.Queries["md"] = SourceExpressionConverter.ConvertO(md);
                return callPayload;
            }

            return new ApiConnectionAction<WordsResponseItem[]>(BuildSourceInput);
        }
    }

    public class DatamuseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class WordsResponseItem
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("numSyllables")]
        public int NumSyllables { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip;

    public partial class WorkflowManagedActions
    {
        public DatamuseipActions Datamuseip(string connectionId) => new DatamuseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatamuseipTriggers Datamuseip(string connectionId) => new DatamuseipTriggers(connectionId);
    }
}