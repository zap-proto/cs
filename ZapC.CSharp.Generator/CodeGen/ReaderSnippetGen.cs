using System;
using System.Collections.Generic;
using System.Linq;
using ZapC.CSharp.Generator.Model;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static ZapC.CSharp.Generator.CodeGen.SyntaxHelpers;

namespace ZapC.CSharp.Generator.CodeGen
{
    class ReaderSnippetGen
    {
        readonly GenNames _names;

        public ReaderSnippetGen(GenNames names)
        {
            _names = names;
        }

        MemberDeclarationSyntax MakeReaderImplicitConversionOperator1()
        {
            return ConversionOperatorDeclaration(
                    Token(SyntaxKind.ImplicitKeyword),
                    IdentifierName(nameof(Zap.DeserializerState)))
                .WithModifiers(
                    TokenList(
                        new[]{
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.StaticKeyword)}))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList<ParameterSyntax>(
                            Parameter(_names.ReaderParameter.Identifier)
                            .WithType(_names.ReaderStruct.IdentifierName))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            _names.ReaderParameter.IdentifierName,
                            _names.ReaderContextField.IdentifierName)))
                .WithSemicolonToken(
                    Token(SyntaxKind.SemicolonToken));
        }

        MemberDeclarationSyntax MakeReaderImplicitConversionOperator2()
        {
            return ConversionOperatorDeclaration(
                Token(SyntaxKind.ImplicitKeyword),
                _names.ReaderStruct.IdentifierName)
                .WithModifiers(
                    TokenList(
                        new[] {
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.StaticKeyword) }))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList<ParameterSyntax>(
                            Parameter(_names.ReaderContextField.Identifier)
                            .WithType(_names.Type<Zap.DeserializerState>(Nullability.NonNullable)))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        ObjectCreationExpression(_names.ReaderStruct.IdentifierName)
                        .WithArgumentList(
                            ArgumentList(
                                SingletonSeparatedList<ArgumentSyntax>(
                                    Argument(_names.ReaderContextField.IdentifierName))))))
                .WithSemicolonToken(
                    Token(SyntaxKind.SemicolonToken));
        }

        MemberDeclarationSyntax MakeReaderCreateMethod()
        {
            return MethodDeclaration(_names.ReaderStruct.IdentifierName, _names.ReaderCreateMethod.Identifier)
                .AddModifiers(Public, Static)
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(_names.ContextParameter.Identifier)
                            .WithType(
                                _names.Type<Zap.DeserializerState>(Nullability.NonNullable)))))
                .WithExpressionBody(
                    ArrowExpressionClause(
                        ObjectCreationExpression(_names.ReaderStruct.IdentifierName)
                        .AddArgumentListArguments(Argument(_names.ContextParameter.IdentifierName))))
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        IEnumerable<MemberDeclarationSyntax> MakeReaderStructMembers()
        {
            yield return FieldDeclaration(
                VariableDeclaration(
                    _names.Type<Zap.DeserializerState>(Nullability.NonNullable))
                .AddVariables(_names.ReaderContextField.VariableDeclarator))
                .AddModifiers(Readonly);

            yield return ConstructorDeclaration(_names.ReaderStruct.Identifier)
                .AddModifiers(Public)
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(_names.ContextParameter.Identifier)
                            .WithType(_names.Type<Zap.DeserializerState>(Nullability.NonNullable)))))
                .WithBody(
                    Block(
                        SingletonList<StatementSyntax>(
                            ExpressionStatement(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        ThisExpression(),
                                        _names.ReaderContextField.IdentifierName),
                                    _names.ContextParameter.IdentifierName)))));

            yield return MakeReaderCreateMethod();
            yield return MakeReaderImplicitConversionOperator1();
            yield return MakeReaderImplicitConversionOperator2();
        }

        IEnumerable<MemberDeclarationSyntax> MakeGroupReaderStructMembers()
        {
            yield return FieldDeclaration(
                VariableDeclaration(
                    _names.Type<Zap.DeserializerState>(Nullability.NonNullable))
                .AddVariables(_names.ReaderContextField.VariableDeclarator))
                .AddModifiers(Readonly);

            yield return ConstructorDeclaration(_names.ReaderStruct.Identifier)
                .AddModifiers(Public)
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(Parameter(_names.GroupReaderContextArg.Identifier)
                            .WithType(_names.Type<Zap.DeserializerState>(Nullability.NonNullable)))))
                .WithBody(
                    Block(
                        SingletonList<StatementSyntax>(
                            ExpressionStatement(
                                AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        ThisExpression(),
                                        _names.ReaderContextField.IdentifierName),
                                    _names.GroupReaderContextArg.IdentifierName)))));

            yield return MakeReaderCreateMethod();
            yield return MakeReaderImplicitConversionOperator1();
            yield return MakeReaderImplicitConversionOperator2();
        }

        PropertyDeclarationSyntax MakeReaderProperty(TypeSyntax type, string name, ExpressionSyntax right, bool cond)
        {
            if (cond)
            {
                right = ConditionalExpression(
                    BinaryExpression(
                        SyntaxKind.EqualsExpression,
                        _names.UnionDiscriminatorProp.IdentifierName,
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            _names.UnionDiscriminatorEnum.IdentifierName,
                            IdentifierName(name))),
                    right,
                    LiteralExpression(
                        SyntaxKind.DefaultLiteralExpression,
                        Token(SyntaxKind.DefaultKeyword)));
            }

            return PropertyDeclaration(type, name)
                .AddModifiers(Public)
                .WithExpressionBody(ArrowExpressionClause(right))
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        static Func<ExpressionSyntax, ExpressionSyntax> MakeCastFunc(TypeSyntax type) => x => CastExpression(type, x);

        PropertyDeclarationSyntax MakeReadProperty(TypeSyntax type, string name, SimpleNameSyntax readName, 
            object indexOrBitOffset, ExpressionSyntax secondArg,
            Func<ExpressionSyntax, ExpressionSyntax> cast, bool cond)
        {
            var right = InvocationExpression(
                MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    _names.ReaderContextField.IdentifierName,
                    readName))
                    .AddArgumentListArguments(
                        Argument(ValueOf(indexOrBitOffset)));

            if (secondArg != null)
            {
                right = right.AddArgumentListArguments(Argument(secondArg));
            }

            ExpressionSyntax expr = right;

            if (cast != null)
            {
                expr = cast(expr);
            }

            return MakeReaderProperty(type, name, expr, cond);
        }

        PropertyDeclarationSyntax MakeReadProperty(TypeSyntax type, string name, string readName,
            object indexOrBitOffset, ExpressionSyntax secondArg,
            Func<ExpressionSyntax, ExpressionSyntax> cast, bool cond)
        {
            return MakeReadProperty(type, name, IdentifierName(readName), indexOrBitOffset, secondArg, cast, cond);
        }

        PropertyDeclarationSyntax MakeReadPrimitiveProperty<T>(Field field, string readName)
        {
            return MakeReadProperty(
                _names.Type<T>(Nullability.NonNullable), 
                _names.GetCodeIdentifier(field).ToString(), 
                readName, 
                field.BitOffset.Value,
                ValueOf(field.DefaultValue.ScalarValue), 
                null, 
                field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadEnumProperty(Field field)
        {
            var typeSyntax = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NonNullable);
            return MakeReadProperty(typeSyntax, 
                _names.GetCodeIdentifier(field).ToString(), 
                nameof(Zap.SerializerExtensions.ReadDataUShort), field.BitOffset.Value,
                ValueOf(field.DefaultValue.ScalarValue),
                x => CastExpression(typeSyntax, x), 
                field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadTextProperty(Field field)
        {
            bool cantBeNull = !field.DiscValue.HasValue && field.DefaultValue.ScalarValue != null;

            return MakeReadProperty(
                _names.Type<string>(cantBeNull ? Nullability.NonNullable : Nullability.NullableRef), 
                _names.GetCodeIdentifier(field).ToString(),
                nameof(Zap.DeserializerState.ReadText), 
                (int)field.Offset,
                ValueOf(field.DefaultValue.ScalarValue), 
                null, 
                field.DiscValue.HasValue);
        }

        MemberAccessExpressionSyntax MakeReaderCreator(TypeSyntax qtype)
        {
            return MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                qtype,
                _names.ReaderCreateMethod.IdentifierName);
        }

        PropertyDeclarationSyntax MakeReadStructProperty(Field field)
        {
            var qtype = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NonNullable);
            var creator = MakeReaderCreator(qtype);

            return MakeReadProperty(qtype, _names.GetCodeIdentifier(field).ToString(),
                nameof(Zap.DeserializerState.ReadStruct), (int)field.Offset,
                creator, null, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeHasStructProperty(Field field)
        {
            var propertyType = _names.Type<bool>(Nullability.NonNullable);
            var propertyName = "Has" + _names.GetCodeIdentifier(field).ToString();

            return MakeReadProperty(
                propertyType,
                propertyName,
                nameof(Zap.DeserializerState.IsStructFieldNonNull),
                (int)field.Offset,
                null,
                null,
                false);
        }

        PropertyDeclarationSyntax MakeReadGroupProperty(Field field)
        {
            var type = QualifiedName(
                _names.MakeTypeName(field.Type.Definition).IdentifierName,
                _names.ReaderStruct.IdentifierName);

            var right = ObjectCreationExpression(type)
                    .WithArgumentList(
                        ArgumentList(
                            SingletonSeparatedList(
                                Argument(_names.ReaderContextField.IdentifierName))));

            return MakeReaderProperty(type, _names.GetCodeIdentifier(field).ToString(), right, field.DiscValue.HasValue);
        }

        ExpressionSyntax MakeReadListPropertyImpl(Model.Type elementType, TypeDefinition scope, ExpressionSyntax context, int depth)
        {
            var elementTypeSyntax = _names.MakeTypeSyntax(elementType, scope, TypeUsage.Reader, Nullability.NonNullable);

            if (elementType.Tag == TypeTag.Interface ||
                elementType.Tag == TypeTag.CapabilityPointer)
            {
                if (depth == 0)
                {
                    return InvocationExpression(MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            _names.ReaderContextField.IdentifierName,
                            GenericName(nameof(Zap.DeserializerState.ReadCapList))
                                .AddTypeArgumentListArguments(elementTypeSyntax)
                            )).AddArgumentListArguments(Argument(context));
                }
                else
                {
                    return InvocationExpression(
                        MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            GenericName(nameof(Zap.DeserializerState.RequireCapList))
                                .AddTypeArgumentListArguments(elementTypeSyntax)
                            ));
                }
            }

            if (depth == 0)
            {
                context = InvocationExpression(MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    _names.ReaderContextField.IdentifierName,
                    IdentifierName(nameof(Zap.DeserializerState.ReadList))))
                    .AddArgumentListArguments(Argument(context));
            }
            else
            {
                context = InvocationExpression(
                    MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                        context,
                        IdentifierName(nameof(Zap.DeserializerState.RequireList))
                        ));
            }

            string lambdaParamName = "_" + depth;
            var lambdaParam = Parameter(Identifier(lambdaParamName));
            var lambdaArg = IdentifierName(lambdaParamName);
            string castFuncName;

            switch (elementType.Tag)
            {
                case TypeTag.List:
                    {

                        var innerImpl = MakeReadListPropertyImpl(
                            elementType.ElementType,
                            scope,
                            lambdaArg,
                            depth + 1);

                        return InvocationExpression(
                            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.ListDeserializer.Cast))))
                                .AddArgumentListArguments(
                                    Argument(SimpleLambdaExpression(lambdaParam, innerImpl)));
                    }

                case TypeTag.ListPointer:
                    {
                        context = InvocationExpression(MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.DeserializerState.RequireList))
                            )).AddArgumentListArguments(Argument(lambdaArg));

                        return InvocationExpression(
                            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.ReadOnlyListExtensions.LazyListSelect))))
                                .AddArgumentListArguments(
                                    Argument(SimpleLambdaExpression(lambdaParam, context)));
                    }

                case TypeTag.Struct:
                    {
                        return InvocationExpression(
                            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.ListDeserializer.Cast))))
                                .AddArgumentListArguments(
                                    Argument(MakeReaderCreator(elementTypeSyntax)));
                    }

                case TypeTag.Enum:
                    {
                        var cons = SimpleLambdaExpression(
                            lambdaParam,
                            CastExpression(elementTypeSyntax, lambdaArg));

                        return InvocationExpression(
                            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.ListDeserializer.CastEnums))))
                                .AddArgumentListArguments(
                                    Argument(cons));
                    }

                case TypeTag.AnyPointer:
                case TypeTag.StructPointer:
                    {
                        return context;
                    }

                case TypeTag.Void:
                    {
                        return MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            context,
                            IdentifierName(nameof(Zap.ListDeserializer.Count)));
                    }

                case TypeTag.Data:
                    castFuncName = nameof(Zap.ListDeserializer.CastData);
                    break;

                case TypeTag.Text:
                    castFuncName = nameof(Zap.ListDeserializer.CastText2);
                    break;

                case TypeTag.Bool:
                    castFuncName = nameof(Zap.ListDeserializer.CastBool);
                    break;

                case TypeTag.F32:
                    castFuncName = nameof(Zap.ListDeserializer.CastFloat);
                    break;

                case TypeTag.F64:
                    castFuncName = nameof(Zap.ListDeserializer.CastDouble);
                    break;

                case TypeTag.S8:
                    castFuncName = nameof(Zap.ListDeserializer.CastSByte);
                    break;

                case TypeTag.U8:
                    castFuncName = nameof(Zap.ListDeserializer.CastByte);
                    break;

                case TypeTag.S16:
                    castFuncName = nameof(Zap.ListDeserializer.CastShort);
                    break;

                case TypeTag.U16:
                case TypeTag.AnyEnum:
                    castFuncName = nameof(Zap.ListDeserializer.CastUShort);
                    break;

                case TypeTag.S32:
                    castFuncName = nameof(Zap.ListDeserializer.CastInt);
                    break;

                case TypeTag.U32:
                    castFuncName = nameof(Zap.ListDeserializer.CastUInt);
                    break;

                case TypeTag.S64:
                    castFuncName = nameof(Zap.ListDeserializer.CastLong);
                    break;

                case TypeTag.U64:
                    castFuncName = nameof(Zap.ListDeserializer.CastULong);
                    break;

                default:
                    throw new NotImplementedException("Unexpected type tag, don't know how to deal with this");
            }

            return InvocationExpression(MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                context,
                IdentifierName(castFuncName)));
        }

        PropertyDeclarationSyntax MakeReadListProperty(Field field)
        {
            var elementType = field.Type.ElementType;
            var context = ValueOf((int)field.Offset);
            var impl = MakeReadListPropertyImpl(elementType, field.DeclaringType, context, 0);
            var listType = _names.MakeTypeSyntax(
                field.Type,
                field.DeclaringType,
                TypeUsage.Reader,
                field.DiscValue.HasValue ? Nullability.NullableRef : Nullability.NonNullable);
            return MakeReaderProperty(listType, _names.GetCodeIdentifier(field).ToString(), impl, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadAnyListProperty(Field field)
        {
            var type = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NonNullable);

            return MakeReadProperty(type, _names.GetCodeIdentifier(field).ToString(),
                nameof(Zap.DeserializerState.ReadList),
                (int)field.Offset, null, x => CastExpression(type, x), field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadCapProperty(Field field)
        {
            var nullableType = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NullableRef);
            var nonNullableType = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NonNullable);
            var readName = GenericName(nameof(Zap.DeserializerState.ReadCap))
                .AddTypeArgumentListArguments(nonNullableType);

            return MakeReadProperty(nullableType, _names.GetCodeIdentifier(field).ToString(),
                readName,
                (int)field.Offset, null, null, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadAnyCapProperty(Field field)
        {
            var type = _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, Nullability.NonNullable);

            return MakeReadProperty(type, _names.GetCodeIdentifier(field).ToString(),
                nameof(Zap.DeserializerState.ReadCap),
                (int)field.Offset, null, null, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadDataProperty(Field field)
        {
            var context = InvocationExpression(MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                _names.ReaderContextField.IdentifierName,
                IdentifierName(nameof(Zap.DeserializerState.ReadList))))
                .AddArgumentListArguments(Argument(ValueOf((int)field.Offset)));
            var impl = InvocationExpression(MemberAccessExpression(
                SyntaxKind.SimpleMemberAccessExpression,
                context,
                IdentifierName(nameof(Zap.ListDeserializer.CastByte))));

            return MakeReaderProperty(
                _names.MakeTypeSyntax(field.Type, field.DeclaringType, TypeUsage.Reader, 
                field.DiscValue.HasValue ? Nullability.NullableRefAndValue : Nullability.NonNullable), 
                _names.GetCodeIdentifier(field).ToString(), impl, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReadAnyPointerProperty(Field field)
        {
            var type = IdentifierName(nameof(Zap.DeserializerState));

            return MakeReadProperty(type, _names.GetCodeIdentifier(field).ToString(),
                nameof(Zap.DeserializerState.StructReadPointer), 
                (int)field.Offset, null, null, field.DiscValue.HasValue);
        }

        PropertyDeclarationSyntax MakeReaderUnionSelector(TypeDefinition def)
        {
            var type = _names.UnionDiscriminatorEnum.IdentifierName;
            return MakeReadProperty(
                type,
                _names.UnionDiscriminatorProp.ToString(),
                nameof(Zap.SerializerExtensions.ReadDataUShort),
                def.UnionInfo.TagOffset,
                ValueOf(default(ushort)),
                MakeCastFunc(type), false);
        }

        PropertyDeclarationSyntax MakeReaderFieldProperty(Field field)
        {
            switch (field.Type.Tag)
            {
                case TypeTag.Bool:
                    return MakeReadPrimitiveProperty<bool>(field,
                        nameof(Zap.SerializerExtensions.ReadDataBool));

                case TypeTag.S8:
                    return MakeReadPrimitiveProperty<sbyte>(field,
                        nameof(Zap.SerializerExtensions.ReadDataSByte));

                case TypeTag.U8:
                    return MakeReadPrimitiveProperty<byte>(field,
                        nameof(Zap.SerializerExtensions.ReadDataByte));

                case TypeTag.S16:
                    return MakeReadPrimitiveProperty<short>(field,
                        nameof(Zap.SerializerExtensions.ReadDataShort));

                case TypeTag.U16:
                    return MakeReadPrimitiveProperty<ushort>(field,
                        nameof(Zap.SerializerExtensions.ReadDataUShort));

                case TypeTag.S32:
                    return MakeReadPrimitiveProperty<int>(field,
                        nameof(Zap.SerializerExtensions.ReadDataInt));

                case TypeTag.U32:
                    return MakeReadPrimitiveProperty<uint>(field,
                        nameof(Zap.SerializerExtensions.ReadDataUInt));

                case TypeTag.S64:
                    return MakeReadPrimitiveProperty<long>(field,
                        nameof(Zap.SerializerExtensions.ReadDataLong));

                case TypeTag.U64:
                    return MakeReadPrimitiveProperty<ulong>(field,
                        nameof(Zap.SerializerExtensions.ReadDataULong));

                case TypeTag.F32:
                    return MakeReadPrimitiveProperty<float>(field,
                        nameof(Zap.SerializerExtensions.ReadDataFloat));

                case TypeTag.F64:
                    return MakeReadPrimitiveProperty<double>(field,
                        nameof(Zap.SerializerExtensions.ReadDataDouble));

                case TypeTag.Enum:
                    return MakeReadEnumProperty(field);

                case TypeTag.Text:
                    return MakeReadTextProperty(field);

                case TypeTag.Struct:
                    return MakeReadStructProperty(field);

                case TypeTag.Group:
                    return MakeReadGroupProperty(field);

                case TypeTag.List:
                    return MakeReadListProperty(field);

                case TypeTag.Interface:
                    return MakeReadCapProperty(field);

                case TypeTag.CapabilityPointer:
                    return MakeReadAnyCapProperty(field);

                case TypeTag.ListPointer:
                    return MakeReadAnyListProperty(field);

                case TypeTag.AnyPointer:
                case TypeTag.StructPointer:
                    return MakeReadAnyPointerProperty(field);

                case TypeTag.Data:
                    return MakeReadDataProperty(field);

                default:
                    return null;
            }
        }

        PropertyDeclarationSyntax MakeHasValueFieldProperty(Field field)
        {
            switch (field.Type.Tag)
            {
                case TypeTag.Struct:
                case TypeTag.List:
                    return MakeHasStructProperty(field);
                default:
                    return null;
            }
        }

        public StructDeclarationSyntax MakeReaderStruct(TypeDefinition def)
        {
            var readerDecl = StructDeclaration(_names.ReaderStruct.ToString()).AddModifiers(Public);

            var members = def.Tag == TypeTag.Group ? 
                MakeGroupReaderStructMembers() :
                MakeReaderStructMembers();

            readerDecl = readerDecl.AddMembers(members.ToArray());

            if (def.UnionInfo != null)
            {
                readerDecl = readerDecl.AddMembers(MakeReaderUnionSelector(def));
            }

            foreach (var field in def.Fields)
            {
                var propDecl = MakeReaderFieldProperty(field);

                if (propDecl != null)
                {
                    readerDecl = readerDecl.AddMembers(propDecl);
                }

                var hasValueDecl = MakeHasValueFieldProperty(field);
                if (hasValueDecl != null)
                {
                    readerDecl = readerDecl.AddMembers(hasValueDecl);
                }
            }

            return readerDecl;
        }
    }
}
