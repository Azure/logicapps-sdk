//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;

    internal interface IExpressionVisitor<TReturn>
    {
        TReturn Visit(BinaryExpression expression);
        TReturn Visit(UnaryExpression expression);
        TReturn Visit(ConstantExpression expression);
        TReturn Visit(ParameterExpression expression);
        TReturn Visit(MethodCallExpression expression);
        TReturn Visit(ConditionalExpression expression);
        TReturn Visit(InvocationExpression expression);
        TReturn Visit(LambdaExpression expression);
        TReturn Visit(ListInitExpression expression);
        TReturn Visit(MemberExpression expression);
        TReturn Visit(MemberInitExpression expression);
        TReturn Visit(NewExpression expression);
        TReturn Visit(NewArrayExpression expression);
        TReturn Visit(TypeBinaryExpression expression);
        TReturn Visit(BlockExpression expression);
        TReturn Visit(DebugInfoExpression expression);
        TReturn Visit(DefaultExpression expression);
        TReturn Visit(DynamicExpression expression);
        TReturn Visit(GotoExpression expression);
        TReturn Visit(IndexExpression expression);
        TReturn Visit(LabelExpression expression);
        TReturn Visit(RuntimeVariablesExpression expression);
        TReturn Visit(SwitchExpression expression);
        TReturn Visit(TryExpression expression);
    }
}
