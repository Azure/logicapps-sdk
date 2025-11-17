//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using Newtonsoft.Json.Linq;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal class ComplexObjectConverter : VisitorBase<JToken, object>
    {
        public static bool IsAnonymousType(Type type)
        {
            if (type == null) return false;

            var hasCompilerGeneratedAttribute = Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false);
            var nameContainsAnonymousType = type.Name.Contains("AnonymousType");
            var isSealed = type.IsSealed;
            var isClass = type.IsClass;
            var isNotPublic = !type.IsPublic;

            return isClass && isSealed && isNotPublic && hasCompilerGeneratedAttribute && nameContainsAnonymousType;
        }

        public override JToken Visit(ListInitExpression e, object p)
        {

            e.NewExpression.Visit(this, p);
            foreach (var init in e.Initializers)
            {
                Console.WriteLine(init.AddMethod);
            }
            Console.WriteLine("watermelon");
            return base.Visit(e, p);
        }

        public override JToken Visit(BinaryExpression e, object p)
        {
            var concat2 = typeof(string).GetMethod("Concat", [typeof(string), typeof(string)]);
            Console.WriteLine(concat2);

            if (e.Method == concat2)
            {
                var conv = new LogicConverter();
                var node = e.Visit(conv, null);
                Console.WriteLine("CONCAT2" + node.Render());
                return new JValue(node.Render());
            }

            Console.WriteLine($"BINARY {e.NodeType} METHOD {e.Method} EXPR {e}");
            throw new NotImplementedException();
        }

        public override JToken Visit(ConstantExpression e, object p)
        {
            if (e.Type == typeof(string))
            {
                return new JValue((string)e.Value);
            }
            throw new NotImplementedException($"ConstantExpression {e.Type} / {e.Value}");
        }

        public override JToken Visit(NewExpression e, object p)
        {
            if (IsAnonymousType(e.Type))
            {
                var props = e.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                if (e.Arguments.Count != props.Length)
                {
                    throw new FormatException();
                }

                var result = new JObject();

                for (var i = 0; i < props.Length; i++)
                {
                    var arg = e.Arguments[i];
                    var prop = props[i];

                    result[prop.Name] = arg.Visit(this, p);
                }
                Console.WriteLine("Anonymous type detected!");
                return result;
            }

            Console.WriteLine($"NewExpression({e.Arguments.Count}) -> " + e.ToString());
            throw new NotImplementedException();
        }

        public override JToken Visit(MemberExpression e, object p)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);
            Console.WriteLine("PROP ACESS" + node.Render());
            return new JValue(node.Render());
        }

        public override JToken Visit(MethodCallExpression e, object p)
        {
            var method = e.Method;
            if (method.DeclaringType == typeof(string) && method.Name == "Format")
            {
                var conv = new LogicConverter();
                var node = e.Visit(conv, null);
                Console.WriteLine("STRFORMAT" + node.Render());
                return new JValue(node.Render());
            }
            throw new NotImplementedException();
        }

        public override JToken Visit(Expression e, object _)
        {
            Console.WriteLine("Can't visit " + e.NodeType + "/" + e.GetType() + " => " + e.ToString());
            throw new NotImplementedException();
        }
    }
}