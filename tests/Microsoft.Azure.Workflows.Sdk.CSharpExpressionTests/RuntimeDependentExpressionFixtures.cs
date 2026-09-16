// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.RuntimeFixtures
{
    using System.Runtime.Serialization;

    // Public fixtures are referenced by emitted C# without importing this namespace.
    public static class RuntimeValues
    {
        public const string ConstantText = "constant";
        public static string Text = "before";
        public static int GetterCalls;
        public static int EnumCalls;
        public static WireChoice Choice = WireChoice.First;

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

        public static void Reset()
        {
            Text = "before";
            GetterCalls = 0;
            EnumCalls = 0;
            Choice = WireChoice.First;
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

    public sealed class CapturedCustomGetter
    {
        public int GetterCalls;
        public int ToStringCalls;

        public string Text
        {
            get
            {
                this.GetterCalls++;
                return "value";
            }
        }

        public override string ToString()
        {
            this.ToStringCalls++;
            return nameof(CapturedCustomGetter);
        }
    }
}
