//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datamuseip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatamuseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "datamuseip")]
        [WorkflowExpressionFactory(nameof(__BuildWords))]
        public IBodyWorkflowAction<WordsResponseItem[]> Words([WorkflowExpression] Func<string> ml = null, [WorkflowExpression] Func<string> sl = null, [WorkflowExpression] Func<string> sp = null, [WorkflowExpression] Func<string> relJja = null, [WorkflowExpression] Func<string> relJjb = null, [WorkflowExpression] Func<string> relSyn = null, [WorkflowExpression] Func<string> relTrg = null, [WorkflowExpression] Func<string> relAnt = null, [WorkflowExpression] Func<string> relSpc = null, [WorkflowExpression] Func<string> relGen = null, [WorkflowExpression] Func<string> relCom = null, [WorkflowExpression] Func<string> relPar = null, [WorkflowExpression] Func<string> relBga = null, [WorkflowExpression] Func<string> relBgb = null, [WorkflowExpression] Func<string> relRhy = null, [WorkflowExpression] Func<string> relNry = null, [WorkflowExpression] Func<string> relHom = null, [WorkflowExpression] Func<string> relCns = null, [WorkflowExpression] Func<string> v = null, [WorkflowExpression] Func<string> topics = null, [WorkflowExpression] Func<string> lc = null, [WorkflowExpression] Func<string> rc = null, [WorkflowExpression] Func<int> max = null, [WorkflowExpression] Func<string> md = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WordsResponseItem[]> __BuildWords(WorkflowValue<string> ml = null, WorkflowValue<string> sl = null, WorkflowValue<string> sp = null, WorkflowValue<string> relJja = null, WorkflowValue<string> relJjb = null, WorkflowValue<string> relSyn = null, WorkflowValue<string> relTrg = null, WorkflowValue<string> relAnt = null, WorkflowValue<string> relSpc = null, WorkflowValue<string> relGen = null, WorkflowValue<string> relCom = null, WorkflowValue<string> relPar = null, WorkflowValue<string> relBga = null, WorkflowValue<string> relBgb = null, WorkflowValue<string> relRhy = null, WorkflowValue<string> relNry = null, WorkflowValue<string> relHom = null, WorkflowValue<string> relCns = null, WorkflowValue<string> v = null, WorkflowValue<string> topics = null, WorkflowValue<string> lc = null, WorkflowValue<string> rc = null, WorkflowValue<int> max = null, WorkflowValue<string> md = null)
        {
            WorkflowValue.Validate(ml, nameof(ml), required: false);
            WorkflowValue.Validate(sl, nameof(sl), required: false);
            WorkflowValue.Validate(sp, nameof(sp), required: false);
            WorkflowValue.Validate(relJja, nameof(relJja), required: false);
            WorkflowValue.Validate(relJjb, nameof(relJjb), required: false);
            WorkflowValue.Validate(relSyn, nameof(relSyn), required: false);
            WorkflowValue.Validate(relTrg, nameof(relTrg), required: false);
            WorkflowValue.Validate(relAnt, nameof(relAnt), required: false);
            WorkflowValue.Validate(relSpc, nameof(relSpc), required: false);
            WorkflowValue.Validate(relGen, nameof(relGen), required: false);
            WorkflowValue.Validate(relCom, nameof(relCom), required: false);
            WorkflowValue.Validate(relPar, nameof(relPar), required: false);
            WorkflowValue.Validate(relBga, nameof(relBga), required: false);
            WorkflowValue.Validate(relBgb, nameof(relBgb), required: false);
            WorkflowValue.Validate(relRhy, nameof(relRhy), required: false);
            WorkflowValue.Validate(relNry, nameof(relNry), required: false);
            WorkflowValue.Validate(relHom, nameof(relHom), required: false);
            WorkflowValue.Validate(relCns, nameof(relCns), required: false);
            WorkflowValue.Validate(v, nameof(v), required: false);
            WorkflowValue.Validate(topics, nameof(topics), required: false);
            WorkflowValue.Validate(lc, nameof(lc), required: false);
            WorkflowValue.Validate(rc, nameof(rc), required: false);
            WorkflowValue.Validate(max, nameof(max), required: false);
            WorkflowValue.Validate(md, nameof(md), required: false);
            return new DeferredBodyAction<WordsResponseItem[]>(() =>
            {
                var apiCallPath = "/words";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ml != null)
                    callPayload.Queries["ml"] = ExpressionConverter.Convert(ml);
                if (sl != null)
                    callPayload.Queries["sl"] = ExpressionConverter.Convert(sl);
                if (sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(sp);
                if (relJja != null)
                    callPayload.Queries["rel_jja"] = ExpressionConverter.Convert(relJja);
                if (relJjb != null)
                    callPayload.Queries["rel_jjb"] = ExpressionConverter.Convert(relJjb);
                if (relSyn != null)
                    callPayload.Queries["rel_syn"] = ExpressionConverter.Convert(relSyn);
                if (relTrg != null)
                    callPayload.Queries["rel_trg"] = ExpressionConverter.Convert(relTrg);
                if (relAnt != null)
                    callPayload.Queries["rel_ant"] = ExpressionConverter.Convert(relAnt);
                if (relSpc != null)
                    callPayload.Queries["rel_spc"] = ExpressionConverter.Convert(relSpc);
                if (relGen != null)
                    callPayload.Queries["rel_gen"] = ExpressionConverter.Convert(relGen);
                if (relCom != null)
                    callPayload.Queries["rel_com"] = ExpressionConverter.Convert(relCom);
                if (relPar != null)
                    callPayload.Queries["rel_par"] = ExpressionConverter.Convert(relPar);
                if (relBga != null)
                    callPayload.Queries["rel_bga"] = ExpressionConverter.Convert(relBga);
                if (relBgb != null)
                    callPayload.Queries["rel_bgb"] = ExpressionConverter.Convert(relBgb);
                if (relRhy != null)
                    callPayload.Queries["rel_rhy"] = ExpressionConverter.Convert(relRhy);
                if (relNry != null)
                    callPayload.Queries["rel_nry"] = ExpressionConverter.Convert(relNry);
                if (relHom != null)
                    callPayload.Queries["rel_hom"] = ExpressionConverter.Convert(relHom);
                if (relCns != null)
                    callPayload.Queries["rel_cns"] = ExpressionConverter.Convert(relCns);
                if (v != null)
                    callPayload.Queries["v"] = ExpressionConverter.Convert(v);
                if (topics != null)
                    callPayload.Queries["topics"] = ExpressionConverter.Convert(topics);
                if (lc != null)
                    callPayload.Queries["lc"] = ExpressionConverter.Convert(lc);
                if (rc != null)
                    callPayload.Queries["rc"] = ExpressionConverter.Convert(rc);
                callPayload.Queries["max"] = Convert.ToString(100);
                if (max != null)
                    callPayload.Queries["max"] = ExpressionConverter.Convert(max);
                if (md != null)
                    callPayload.Queries["md"] = ExpressionConverter.Convert(md);
                return new ApiConnectionAction<WordsResponseItem[]>(callPayload);
            });
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
