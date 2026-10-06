using Newtonsoft.Json.Linq;
using MathAlias = System.Math;
using static Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E.CaseSupport;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

public static class OperatorCases
{
    [WorkflowCase("IntegerOperators", "{\"equal\":true,\"notEqual\":false,\"less\":false,\"lessEqual\":true,\"greater\":false,\"greaterEqual\":true,\"negate\":-5,\"precedence\":21,\"subtractNested\":3,\"and\":1,\"or\":7,\"xor\":6,\"complement\":-6,\"add\":7,\"subtract\":3,\"multiply\":15,\"divide\":2,\"modulo\":1,\"shift\":10}",
        FailureIds = new[] { "F087", "F088", "F089", "F090", "F091", "F092", "F097", "F098", "F099", "F100", "F101", "F102", "F103", "F159", "F160", "F161", "F162", "F163", "F164", "F173" })]
    public static FlowDefinition IntegerOperators()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 5).WithName("Count");
        var quantity = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Quantity");
        var equal = WorkflowActions.BuiltIn.Compose<object>(() => count.Output == 5).WithName("Equal");
        var notEqual = WorkflowActions.BuiltIn.Compose<object>(() => count.Output != 5).WithName("NotEqual");
        var less = WorkflowActions.BuiltIn.Compose<object>(() => count.Output < 5).WithName("Less");
        var lessEqual = WorkflowActions.BuiltIn.Compose<object>(() => count.Output <= 5).WithName("LessEqual");
        var greater = WorkflowActions.BuiltIn.Compose<object>(() => count.Output > 5).WithName("Greater");
        var greaterEqual = WorkflowActions.BuiltIn.Compose<object>(() => count.Output >= 5).WithName("GreaterEqual");
        var negate = WorkflowActions.BuiltIn.Compose<object>(() => -count.Output).WithName("Negate");
        var precedence = WorkflowActions.BuiltIn.Compose<object>(() => (count.Output + 2) * 3).WithName("Precedence");
        var subtractNested = WorkflowActions.BuiltIn.Compose<object>(() => count.Output - (quantity.Output - 1)).WithName("SubtractNested");
        var and = WorkflowActions.BuiltIn.Compose<object>(() => count.Output & 3).WithName("And");
        var or = WorkflowActions.BuiltIn.Compose<object>(() => count.Output | 3).WithName("Or");
        var xor = WorkflowActions.BuiltIn.Compose<object>(() => count.Output ^ 3).WithName("Xor");
        var complement = WorkflowActions.BuiltIn.Compose<object>(() => ~count.Output).WithName("Complement");
        var add = WorkflowActions.BuiltIn.Compose<object>(() => count.Output + 2).WithName("Add");
        var subtract = WorkflowActions.BuiltIn.Compose<object>(() => count.Output - 2).WithName("Subtract");
        var multiply = WorkflowActions.BuiltIn.Compose<object>(() => count.Output * 3).WithName("Multiply");
        var divide = WorkflowActions.BuiltIn.Compose<object>(() => count.Output / 2).WithName("Divide");
        var modulo = WorkflowActions.BuiltIn.Compose<object>(() => count.Output % 2).WithName("Modulo");
        var shift = WorkflowActions.BuiltIn.Compose<object>(() => count.Output << 1).WithName("Shift");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new
        {
            equal = equal.Output, notEqual = notEqual.Output, less = less.Output, lessEqual = lessEqual.Output,
            greater = greater.Output, greaterEqual = greaterEqual.Output, negate = negate.Output,
            precedence = precedence.Output, subtractNested = subtractNested.Output, and = and.Output,
            or = or.Output, xor = xor.Output, complement = complement.Output, add = add.Output,
            subtract = subtract.Output, multiply = multiply.Output, divide = divide.Output, modulo = modulo.Output, shift = shift.Output
        });
        return Finish("IntegerOperators", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count, quantity, equal, notEqual, less, lessEqual,
            greater, greaterEqual, negate, precedence, subtractNested, and, or, xor, complement, add, subtract, multiply, divide, modulo, shift);
    }

    [WorkflowCase("CompositeArithmetic", "20", FailureIds = new[] { "F029" })]
    public static FlowDefinition CompositeArithmetic()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 5).WithName("Count");
        var quantity = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Quantity");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => (count.Output + 2) * 3 - quantity.Output / 2);
        return Finish("CompositeArithmetic", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count, quantity);
    }

    [WorkflowCase("AliasMath", "3", FailureIds = new[] { "F027" })]
    public static FlowDefinition AliasMath()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => -3).WithName("Count");
        var result = WorkflowActions.BuiltIn.Compose<int>(() => MathAlias.Abs(count.Output));
        return Finish("AliasMath", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
    }

    [WorkflowCase("DecimalArithmetic", "{\"cast\":2,\"add\":3.5,\"round\":2.76}", FailureIds = new[] { "F104", "F117", "F190" })]
    public static FlowDefinition DecimalArithmetic()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var amount = WorkflowActions.BuiltIn.Compose<decimal>(() => 2.5m).WithName("Amount");
        var roundAmount = WorkflowActions.BuiltIn.Compose<decimal>(() => 2.755m).WithName("RoundAmount");
        var cast = WorkflowActions.BuiltIn.Compose<object>(() => (int)amount.Output).WithName("Cast");
        var add = WorkflowActions.BuiltIn.Compose<object>(() => amount.Output + 1m).WithName("Add");
        var round = WorkflowActions.BuiltIn.Compose<object>(() => Math.Round(roundAmount.Output, 2)).WithName("Round");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { cast = cast.Output, add = add.Output, round = round.Output });
        return Finish("DecimalArithmetic", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), amount, roundAmount, cast, add, round);
    }

    [WorkflowCase("ConditionalTrue", "{\"not\":false,\"number\":4,\"text\":\"yes\"}", FailureIds = new[] { "F033", "F093", "F095", "F189" })]
    public static FlowDefinition ConditionalTrue()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("Flag");
        var not = WorkflowActions.BuiltIn.Compose<object>(() => !flag.Output).WithName("Not");
        var number = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output ? count.Output + 1 : 0).WithName("Number");
        var text = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output ? "yes" : "no").WithName("Text");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { not = not.Output, number = number.Output, text = text.Output });
        return Finish("ConditionalTrue", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count, flag, not, number, text);
    }

    [WorkflowCase("ConditionalFalse", "{\"number\":0,\"text\":\"no\",\"skip\":\"skip\"}", FailureIds = new[] { "F033", "F095", "F140" },
        Description = "The unselected checked integer branch would overflow; uppercase skip also retains its original conditional.")]
    public static FlowDefinition ConditionalFalse()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => int.MaxValue).WithName("Count");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "").WithName("Source");
        var number = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output ? checked(count.Output + 1) : 0).WithName("Number");
        var text = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output ? "yes" : "no").WithName("Text");
        var skip = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output ? source.Output.ToUpperInvariant() : "skip").WithName("Skip");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { number = number.Output, text = text.Output, skip = skip.Output });
        return Finish("ConditionalFalse", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag, count, source, number, text, skip);
    }

    [WorkflowCase("LogicalOperators", "{\"andFalse\":false,\"andTrue\":true,\"orFalse\":true,\"orTrue\":true,\"eagerAnd\":false,\"eagerOr\":true}",
        FailureIds = new[] { "F106", "F107", "F108", "F109", "F110", "F111" },
        Description = "Preserves six truth-table scenarios; does not claim fixture read-count instrumentation.")]
    public static FlowDefinition LogicalOperators()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var flag = WorkflowActions.BuiltIn.Compose<bool>(() => false).WithName("Flag");
        var otherFlag = WorkflowActions.BuiltIn.Compose<bool>(() => true).WithName("OtherFlag");
        var andFalse = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output && otherFlag.Output).WithName("AndFalse");
        var andTrue = WorkflowActions.BuiltIn.Compose<object>(() => otherFlag.Output && otherFlag.Output).WithName("AndTrue");
        var orFalse = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output || otherFlag.Output).WithName("OrFalse");
        var orTrue = WorkflowActions.BuiltIn.Compose<object>(() => otherFlag.Output || flag.Output).WithName("OrTrue");
        var eagerAnd = WorkflowActions.BuiltIn.Compose<object>(() => flag.Output & otherFlag.Output).WithName("EagerAnd");
        var eagerOr = WorkflowActions.BuiltIn.Compose<object>(() => otherFlag.Output | flag.Output).WithName("EagerOr");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { andFalse = andFalse.Output, andTrue = andTrue.Output,
            orFalse = orFalse.Output, orTrue = orTrue.Output, eagerAnd = eagerAnd.Output, eagerOr = eagerOr.Output });
        return Finish("LogicalOperators", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), flag, otherFlag, andFalse, andTrue, orFalse, orTrue, eagerAnd, eagerOr);
    }

    [WorkflowCase("NullGuard", "false", FailureIds = new[] { "F030" }, InputJson = "{\"text\":null}")]
    public static FlowDefinition NullGuard()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => trigger.TriggerOutput.Body["text"].Value<string>()).WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output != null && source.Output.StartsWith("A"));
        return Finish("NullGuard", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("NullCoalescing", "default", FailureIds = new[] { "F094" }, InputJson = "{\"text\":null}")]
    public static FlowDefinition NullCoalescing()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => trigger.TriggerOutput.Body["text"].Value<string>()).WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output ?? "default");
        return Finish("NullCoalescing", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("EmptyCoalescing", "", FailureIds = new[] { "F094" })]
    public static FlowDefinition EmptyCoalescing()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var source = WorkflowActions.BuiltIn.Compose<string>(() => "").WithName("Source");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => source.Output ?? "default");
        return Finish("EmptyCoalescing", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), source);
    }

    [WorkflowCase("NullableArithmeticNull", "{\"value\":null}", FailureIds = new[] { "F105" }, InputJson = "{\"value\":null}")]
    public static FlowDefinition NullableArithmeticNull()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var nullableCount = WorkflowActions.BuiltIn.Compose<int?>(() => trigger.TriggerOutput.Body["value"].Value<int?>()).WithName("NullableCount");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { value = nullableCount.Output + 2 });
        return Finish("NullableArithmeticNull", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), nullableCount);
    }

    [WorkflowCase("NullableArithmeticValue", "5", FailureIds = new[] { "F105" })]
    public static FlowDefinition NullableArithmeticValue()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var nullableCount = WorkflowActions.BuiltIn.Compose<int?>(() => 3).WithName("NullableCount");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => nullableCount.Output + 2);
        return Finish("NullableArithmeticValue", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), nullableCount);
    }

    [WorkflowCase("IntegerExecutionProbe", "5", FailureIds = new[] { "F191" })]
    public static FlowDefinition IntegerExecutionProbe()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => count.Output + 2);
        return Finish("IntegerExecutionProbe", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
    }

    [WorkflowCase("DivideByZero", "", FailureIds = new[] { "F155" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "Attempted to divide by zero.")]
    public static FlowDefinition DivideByZero()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => 3).WithName("Count");
        var quantity = WorkflowActions.BuiltIn.Compose<int>(() => 0).WithName("Quantity");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => count.Output / quantity.Output);
        return Finish("DivideByZero", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count, quantity);
    }

    [WorkflowCase("CheckedOverflow", "", FailureIds = new[] { "F181" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "Arithmetic operation resulted in an overflow.")]
    public static FlowDefinition CheckedOverflow()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => int.MaxValue).WithName("Count");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => checked(count.Output + 1));
        return Finish("CheckedOverflow", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
    }

    [WorkflowCase("AmbientCheckedOverflow", "", FailureIds = new[] { "F018" }, ExpectedRunStatus = "Failed",
        ExpectedHttpStatus = 502, ExpectedActionError = "Arithmetic operation resulted in an overflow.")]
    public static FlowDefinition AmbientCheckedOverflow()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var count = WorkflowActions.BuiltIn.Compose<int>(() => int.MaxValue).WithName("Count");
        checked
        {
            var result = WorkflowActions.BuiltIn.Compose<int>(() => count.Output + 1);
            return Finish("AmbientCheckedOverflow", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), count);
        }
    }

    [WorkflowCase("AmbientCheckedJson", "", FailureIds = new[] { "F185" }, ExpectedRunStatus = "Failed", InputJson = "2147483647",
        ExpectedHttpStatus = 502, ExpectedActionError = "Arithmetic operation resulted in an overflow.")]
    public static FlowDefinition AmbientCheckedJson()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var token = WorkflowActions.BuiltIn.Compose<JToken>(() => trigger.TriggerOutput.Body).WithName("Token");
        checked
        {
            var result = WorkflowActions.BuiltIn.Compose<int>(() => token.Output.Value<int>() + 1);
            return Finish("AmbientCheckedJson", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), token);
        }
    }

    [WorkflowCase("BoxedLiterals", "{\"integer\":5,\"boolean\":true}", FailureIds = new[] { "F156", "F157" })]
    public static FlowDefinition BoxedLiterals()
    {
        var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger().WithName("manual");
        var integer = WorkflowActions.BuiltIn.Compose<object>(() => (object)5).WithName("Integer");
        var boolean = WorkflowActions.BuiltIn.Compose<object>(() => (object)true).WithName("Boolean");
        var result = WorkflowActions.BuiltIn.Compose<object>(() => new { integer = integer.Output, boolean = boolean.Output });
        return Finish("BoxedLiterals", trigger, result.WithName("Result"), WorkflowActions.BuiltIn.Response(responseBody: () => result.Output).WithName("Response"), integer, boolean);
    }
}
