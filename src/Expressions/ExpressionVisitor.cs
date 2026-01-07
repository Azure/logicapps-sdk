//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;

    internal interface IExpressionVisitor<TReturn, TParam>
    {
        TReturn Visit(BinaryExpression e, TParam p);
        TReturn Visit(UnaryExpression e, TParam p);
        TReturn Visit(ConstantExpression e, TParam p);
        TReturn Visit(ParameterExpression e, TParam p);
        TReturn Visit(MethodCallExpression e, TParam p);
        TReturn Visit(ConditionalExpression e, TParam p);
        TReturn Visit(InvocationExpression e, TParam p);
        TReturn Visit(LambdaExpression e, TParam p);
        TReturn Visit(ListInitExpression e, TParam p);
        TReturn Visit(MemberExpression e, TParam p);
        TReturn Visit(MemberInitExpression e, TParam p);
        TReturn Visit(NewExpression e, TParam p);
        TReturn Visit(NewArrayExpression e, TParam p);
        TReturn Visit(TypeBinaryExpression e, TParam p);
        TReturn Visit(BlockExpression e, TParam p);
        TReturn Visit(DebugInfoExpression e, TParam p);
        TReturn Visit(DefaultExpression e, TParam p);
        TReturn Visit(DynamicExpression e, TParam p);
        TReturn Visit(GotoExpression e, TParam p);
        TReturn Visit(IndexExpression e, TParam p);
        TReturn Visit(LabelExpression e, TParam p);
        TReturn Visit(RuntimeVariablesExpression e, TParam p);
        TReturn Visit(SwitchExpression e, TParam p);
        TReturn Visit(TryExpression e, TParam p);
        // Other visit methods for different expression types...
    }

    internal abstract class VisitorBase<R, T> : IExpressionVisitor<R, T>
    {
        public virtual R Visit(BinaryExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(UnaryExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(ConstantExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(ParameterExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(MethodCallExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(ConditionalExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(InvocationExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(LambdaExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(ListInitExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(MemberExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(MemberInitExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(NewExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(NewArrayExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(TypeBinaryExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(BlockExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(DebugInfoExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(DefaultExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(DynamicExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(GotoExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(IndexExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(LabelExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(RuntimeVariablesExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(SwitchExpression e, T p) => Visit((Expression)e, p);
        public virtual R Visit(TryExpression e, T p) => Visit((Expression)e, p);

        public abstract R Visit(Expression e, T p);
    }
}