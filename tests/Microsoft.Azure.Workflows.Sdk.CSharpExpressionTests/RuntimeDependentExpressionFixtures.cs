// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures
{
    using System.Runtime.Serialization;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abortionpolicyapiip;

    // Public fixtures are referenced by emitted C# without importing this namespace.
    public static class RuntimeValues
    {
        public const string ConstantText = "constant";
        public static string Text = "before";
        public static int GetterCalls;
        public static int EnumCalls;
        public static int HeadersCalls;
        public static int NumberCalls;
        public static WireChoice Choice = WireChoice.First;
        public static stateInput State = stateInput.Alabama;

        public static string CurrentText
        {
            get
            {
                GetterCalls++;
                return Text;
            }
        }

        public static WireChoice NextChoice()
        {
            EnumCalls++;
            return Choice;
        }

        public static stateInput NextState()
        {
            EnumCalls++;
            return State;
        }

        public static int NextNumber() => ++NumberCalls;

        public static Dictionary<string, string> CreateHeaders()
        {
            HeadersCalls++;
            return new Dictionary<string, string>();
        }

        public static void Reset()
        {
            Text = "before";
            GetterCalls = 0;
            EnumCalls = 0;
            HeadersCalls = 0;
            NumberCalls = 0;
            Choice = WireChoice.First;
            State = stateInput.Alabama;
        }
    }

    public enum WireChoice
    {
        [EnumMember(Value = "first /+")]
        First,
        [EnumMember(Value = "second")]
        Second,
        Unannotated,
    }

    public sealed class CapturedAutoModel
    {
        public CapturedAutoLeaf TriggerOutput { get; set; }
    }

    public sealed class CapturedAutoLeaf
    {
        public string Body { get; set; }
    }

    public sealed class CapturedFieldModel
    {
        public CapturedFieldLeaf Child;
    }

    public sealed class CapturedFieldLeaf
    {
        public string Text;
    }

}
