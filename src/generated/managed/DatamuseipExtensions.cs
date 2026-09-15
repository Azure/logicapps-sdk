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
        public IBodyWorkflowAction<WordsResponseItem[]> Words(Expression<Func<string>> ml = null, Expression<Func<string>> sl = null, Expression<Func<string>> sp = null, Expression<Func<string>> relJja = null, Expression<Func<string>> relJjb = null, Expression<Func<string>> relSyn = null, Expression<Func<string>> relTrg = null, Expression<Func<string>> relAnt = null, Expression<Func<string>> relSpc = null, Expression<Func<string>> relGen = null, Expression<Func<string>> relCom = null, Expression<Func<string>> relPar = null, Expression<Func<string>> relBga = null, Expression<Func<string>> relBgb = null, Expression<Func<string>> relRhy = null, Expression<Func<string>> relNry = null, Expression<Func<string>> relHom = null, Expression<Func<string>> relCns = null, Expression<Func<string>> v = null, Expression<Func<string>> topics = null, Expression<Func<string>> lc = null, Expression<Func<string>> rc = null, Expression<Func<int>> max = null, Expression<Func<string>> md = null)
        {
            var apiCallPath = "/words";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ml != null)
                callPayload.Queries["ml"] = CSharpExpressionConverter.ConvertO(ml);
            if (sl != null)
                callPayload.Queries["sl"] = CSharpExpressionConverter.ConvertO(sl);
            if (sp != null)
                callPayload.Queries["sp"] = CSharpExpressionConverter.ConvertO(sp);
            if (relJja != null)
                callPayload.Queries["rel_jja"] = CSharpExpressionConverter.ConvertO(relJja);
            if (relJjb != null)
                callPayload.Queries["rel_jjb"] = CSharpExpressionConverter.ConvertO(relJjb);
            if (relSyn != null)
                callPayload.Queries["rel_syn"] = CSharpExpressionConverter.ConvertO(relSyn);
            if (relTrg != null)
                callPayload.Queries["rel_trg"] = CSharpExpressionConverter.ConvertO(relTrg);
            if (relAnt != null)
                callPayload.Queries["rel_ant"] = CSharpExpressionConverter.ConvertO(relAnt);
            if (relSpc != null)
                callPayload.Queries["rel_spc"] = CSharpExpressionConverter.ConvertO(relSpc);
            if (relGen != null)
                callPayload.Queries["rel_gen"] = CSharpExpressionConverter.ConvertO(relGen);
            if (relCom != null)
                callPayload.Queries["rel_com"] = CSharpExpressionConverter.ConvertO(relCom);
            if (relPar != null)
                callPayload.Queries["rel_par"] = CSharpExpressionConverter.ConvertO(relPar);
            if (relBga != null)
                callPayload.Queries["rel_bga"] = CSharpExpressionConverter.ConvertO(relBga);
            if (relBgb != null)
                callPayload.Queries["rel_bgb"] = CSharpExpressionConverter.ConvertO(relBgb);
            if (relRhy != null)
                callPayload.Queries["rel_rhy"] = CSharpExpressionConverter.ConvertO(relRhy);
            if (relNry != null)
                callPayload.Queries["rel_nry"] = CSharpExpressionConverter.ConvertO(relNry);
            if (relHom != null)
                callPayload.Queries["rel_hom"] = CSharpExpressionConverter.ConvertO(relHom);
            if (relCns != null)
                callPayload.Queries["rel_cns"] = CSharpExpressionConverter.ConvertO(relCns);
            if (v != null)
                callPayload.Queries["v"] = CSharpExpressionConverter.ConvertO(v);
            if (topics != null)
                callPayload.Queries["topics"] = CSharpExpressionConverter.ConvertO(topics);
            if (lc != null)
                callPayload.Queries["lc"] = CSharpExpressionConverter.ConvertO(lc);
            if (rc != null)
                callPayload.Queries["rc"] = CSharpExpressionConverter.ConvertO(rc);
            callPayload.Queries["max"] = Convert.ToString(100);
            if (max != null)
                callPayload.Queries["max"] = CSharpExpressionConverter.ConvertO(max);
            if (md != null)
                callPayload.Queries["md"] = CSharpExpressionConverter.ConvertO(md);
            return new ApiConnectionAction<WordsResponseItem[]>(callPayload);
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