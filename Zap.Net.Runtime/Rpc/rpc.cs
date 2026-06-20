#pragma warning disable CS1591
using Zap;
using Zap.Rpc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Zap.Rpc
{
    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x91b79f1f808db032UL)]
    public class Message : IZapSerializable
    {
        public const UInt64 typeId = 0x91b79f1f808db032UL;
        public enum WHICH : ushort
        {
            Unimplemented = 0,
            Abort = 1,
            Call = 2,
            Return = 3,
            Finish = 4,
            Resolve = 5,
            Release = 6,
            ObsoleteSave = 7,
            Bootstrap = 8,
            ObsoleteDelete = 9,
            Provide = 10,
            Accept = 11,
            Join = 12,
            Disembargo = 13,
            undefined = 65535
        }

        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.Unimplemented:
                    Unimplemented = ZapSerializable.Create<Zap.Rpc.Message>(reader.Unimplemented);
                    break;
                case WHICH.Abort:
                    Abort = ZapSerializable.Create<Zap.Rpc.Exception>(reader.Abort);
                    break;
                case WHICH.Call:
                    Call = ZapSerializable.Create<Zap.Rpc.Call>(reader.Call);
                    break;
                case WHICH.Return:
                    Return = ZapSerializable.Create<Zap.Rpc.Return>(reader.Return);
                    break;
                case WHICH.Finish:
                    Finish = ZapSerializable.Create<Zap.Rpc.Finish>(reader.Finish);
                    break;
                case WHICH.Resolve:
                    Resolve = ZapSerializable.Create<Zap.Rpc.Resolve>(reader.Resolve);
                    break;
                case WHICH.Release:
                    Release = ZapSerializable.Create<Zap.Rpc.Release>(reader.Release);
                    break;
                case WHICH.ObsoleteSave:
                    ObsoleteSave = ZapSerializable.Create<object>(reader.ObsoleteSave);
                    break;
                case WHICH.Bootstrap:
                    Bootstrap = ZapSerializable.Create<Zap.Rpc.Bootstrap>(reader.Bootstrap);
                    break;
                case WHICH.ObsoleteDelete:
                    ObsoleteDelete = ZapSerializable.Create<object>(reader.ObsoleteDelete);
                    break;
                case WHICH.Provide:
                    Provide = ZapSerializable.Create<Zap.Rpc.Provide>(reader.Provide);
                    break;
                case WHICH.Accept:
                    Accept = ZapSerializable.Create<Zap.Rpc.Accept>(reader.Accept);
                    break;
                case WHICH.Join:
                    Join = ZapSerializable.Create<Zap.Rpc.Join>(reader.Join);
                    break;
                case WHICH.Disembargo:
                    Disembargo = ZapSerializable.Create<Zap.Rpc.Disembargo>(reader.Disembargo);
                    break;
            }

            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object? _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.Unimplemented:
                        _content = null;
                        break;
                    case WHICH.Abort:
                        _content = null;
                        break;
                    case WHICH.Call:
                        _content = null;
                        break;
                    case WHICH.Return:
                        _content = null;
                        break;
                    case WHICH.Finish:
                        _content = null;
                        break;
                    case WHICH.Resolve:
                        _content = null;
                        break;
                    case WHICH.Release:
                        _content = null;
                        break;
                    case WHICH.ObsoleteSave:
                        _content = null;
                        break;
                    case WHICH.Bootstrap:
                        _content = null;
                        break;
                    case WHICH.ObsoleteDelete:
                        _content = null;
                        break;
                    case WHICH.Provide:
                        _content = null;
                        break;
                    case WHICH.Accept:
                        _content = null;
                        break;
                    case WHICH.Join:
                        _content = null;
                        break;
                    case WHICH.Disembargo:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.Unimplemented:
                    Unimplemented?.serialize(writer.Unimplemented!);
                    break;
                case WHICH.Abort:
                    Abort?.serialize(writer.Abort!);
                    break;
                case WHICH.Call:
                    Call?.serialize(writer.Call!);
                    break;
                case WHICH.Return:
                    Return?.serialize(writer.Return!);
                    break;
                case WHICH.Finish:
                    Finish?.serialize(writer.Finish!);
                    break;
                case WHICH.Resolve:
                    Resolve?.serialize(writer.Resolve!);
                    break;
                case WHICH.Release:
                    Release?.serialize(writer.Release!);
                    break;
                case WHICH.ObsoleteSave:
                    writer.ObsoleteSave!.SetObject(ObsoleteSave);
                    break;
                case WHICH.Bootstrap:
                    Bootstrap?.serialize(writer.Bootstrap!);
                    break;
                case WHICH.ObsoleteDelete:
                    writer.ObsoleteDelete!.SetObject(ObsoleteDelete);
                    break;
                case WHICH.Provide:
                    Provide?.serialize(writer.Provide!);
                    break;
                case WHICH.Accept:
                    Accept?.serialize(writer.Accept!);
                    break;
                case WHICH.Join:
                    Join?.serialize(writer.Join!);
                    break;
                case WHICH.Disembargo:
                    Disembargo?.serialize(writer.Disembargo!);
                    break;
            }
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Zap.Rpc.Message? Unimplemented
        {
            get => _which == WHICH.Unimplemented ? (Zap.Rpc.Message?)_content : null;
            set
            {
                _which = WHICH.Unimplemented;
                _content = value;
            }
        }

        public Zap.Rpc.Exception? Abort
        {
            get => _which == WHICH.Abort ? (Zap.Rpc.Exception?)_content : null;
            set
            {
                _which = WHICH.Abort;
                _content = value;
            }
        }

        public Zap.Rpc.Call? Call
        {
            get => _which == WHICH.Call ? (Zap.Rpc.Call?)_content : null;
            set
            {
                _which = WHICH.Call;
                _content = value;
            }
        }

        public Zap.Rpc.Return? Return
        {
            get => _which == WHICH.Return ? (Zap.Rpc.Return?)_content : null;
            set
            {
                _which = WHICH.Return;
                _content = value;
            }
        }

        public Zap.Rpc.Finish? Finish
        {
            get => _which == WHICH.Finish ? (Zap.Rpc.Finish?)_content : null;
            set
            {
                _which = WHICH.Finish;
                _content = value;
            }
        }

        public Zap.Rpc.Resolve? Resolve
        {
            get => _which == WHICH.Resolve ? (Zap.Rpc.Resolve?)_content : null;
            set
            {
                _which = WHICH.Resolve;
                _content = value;
            }
        }

        public Zap.Rpc.Release? Release
        {
            get => _which == WHICH.Release ? (Zap.Rpc.Release?)_content : null;
            set
            {
                _which = WHICH.Release;
                _content = value;
            }
        }

        public object? ObsoleteSave
        {
            get => _which == WHICH.ObsoleteSave ? (object?)_content : null;
            set
            {
                _which = WHICH.ObsoleteSave;
                _content = value;
            }
        }

        public Zap.Rpc.Bootstrap? Bootstrap
        {
            get => _which == WHICH.Bootstrap ? (Zap.Rpc.Bootstrap?)_content : null;
            set
            {
                _which = WHICH.Bootstrap;
                _content = value;
            }
        }

        public object? ObsoleteDelete
        {
            get => _which == WHICH.ObsoleteDelete ? (object?)_content : null;
            set
            {
                _which = WHICH.ObsoleteDelete;
                _content = value;
            }
        }

        public Zap.Rpc.Provide? Provide
        {
            get => _which == WHICH.Provide ? (Zap.Rpc.Provide?)_content : null;
            set
            {
                _which = WHICH.Provide;
                _content = value;
            }
        }

        public Zap.Rpc.Accept? Accept
        {
            get => _which == WHICH.Accept ? (Zap.Rpc.Accept?)_content : null;
            set
            {
                _which = WHICH.Accept;
                _content = value;
            }
        }

        public Zap.Rpc.Join? Join
        {
            get => _which == WHICH.Join ? (Zap.Rpc.Join?)_content : null;
            set
            {
                _which = WHICH.Join;
                _content = value;
            }
        }

        public Zap.Rpc.Disembargo? Disembargo
        {
            get => _which == WHICH.Disembargo ? (Zap.Rpc.Disembargo?)_content : null;
            set
            {
                _which = WHICH.Disembargo;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(0U, (ushort)0);
            public Zap.Rpc.Message.READER Unimplemented => which == WHICH.Unimplemented ? ctx.ReadStruct(0, Zap.Rpc.Message.READER.create) : default;
            public Zap.Rpc.Exception.READER Abort => which == WHICH.Abort ? ctx.ReadStruct(0, Zap.Rpc.Exception.READER.create) : default;
            public Zap.Rpc.Call.READER Call => which == WHICH.Call ? ctx.ReadStruct(0, Zap.Rpc.Call.READER.create) : default;
            public Zap.Rpc.Return.READER Return => which == WHICH.Return ? ctx.ReadStruct(0, Zap.Rpc.Return.READER.create) : default;
            public Zap.Rpc.Finish.READER Finish => which == WHICH.Finish ? ctx.ReadStruct(0, Zap.Rpc.Finish.READER.create) : default;
            public Zap.Rpc.Resolve.READER Resolve => which == WHICH.Resolve ? ctx.ReadStruct(0, Zap.Rpc.Resolve.READER.create) : default;
            public Zap.Rpc.Release.READER Release => which == WHICH.Release ? ctx.ReadStruct(0, Zap.Rpc.Release.READER.create) : default;
            public DeserializerState ObsoleteSave => which == WHICH.ObsoleteSave ? ctx.StructReadPointer(0) : default;
            public Zap.Rpc.Bootstrap.READER Bootstrap => which == WHICH.Bootstrap ? ctx.ReadStruct(0, Zap.Rpc.Bootstrap.READER.create) : default;
            public DeserializerState ObsoleteDelete => which == WHICH.ObsoleteDelete ? ctx.StructReadPointer(0) : default;
            public Zap.Rpc.Provide.READER Provide => which == WHICH.Provide ? ctx.ReadStruct(0, Zap.Rpc.Provide.READER.create) : default;
            public Zap.Rpc.Accept.READER Accept => which == WHICH.Accept ? ctx.ReadStruct(0, Zap.Rpc.Accept.READER.create) : default;
            public Zap.Rpc.Join.READER Join => which == WHICH.Join ? ctx.ReadStruct(0, Zap.Rpc.Join.READER.create) : default;
            public Zap.Rpc.Disembargo.READER Disembargo => which == WHICH.Disembargo ? ctx.ReadStruct(0, Zap.Rpc.Disembargo.READER.create) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(0U, (ushort)0);
                set => this.WriteData(0U, (ushort)value, (ushort)0);
            }

            [DisallowNull]
            public Zap.Rpc.Message.WRITER? Unimplemented
            {
                get => which == WHICH.Unimplemented ? BuildPointer<Zap.Rpc.Message.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Exception.WRITER? Abort
            {
                get => which == WHICH.Abort ? BuildPointer<Zap.Rpc.Exception.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Call.WRITER? Call
            {
                get => which == WHICH.Call ? BuildPointer<Zap.Rpc.Call.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Return.WRITER? Return
            {
                get => which == WHICH.Return ? BuildPointer<Zap.Rpc.Return.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Finish.WRITER? Finish
            {
                get => which == WHICH.Finish ? BuildPointer<Zap.Rpc.Finish.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Resolve.WRITER? Resolve
            {
                get => which == WHICH.Resolve ? BuildPointer<Zap.Rpc.Resolve.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Release.WRITER? Release
            {
                get => which == WHICH.Release ? BuildPointer<Zap.Rpc.Release.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public DynamicSerializerState? ObsoleteSave
            {
                get => which == WHICH.ObsoleteSave ? BuildPointer<DynamicSerializerState>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Bootstrap.WRITER? Bootstrap
            {
                get => which == WHICH.Bootstrap ? BuildPointer<Zap.Rpc.Bootstrap.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public DynamicSerializerState? ObsoleteDelete
            {
                get => which == WHICH.ObsoleteDelete ? BuildPointer<DynamicSerializerState>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Provide.WRITER? Provide
            {
                get => which == WHICH.Provide ? BuildPointer<Zap.Rpc.Provide.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Accept.WRITER? Accept
            {
                get => which == WHICH.Accept ? BuildPointer<Zap.Rpc.Accept.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Join.WRITER? Join
            {
                get => which == WHICH.Join ? BuildPointer<Zap.Rpc.Join.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Disembargo.WRITER? Disembargo
            {
                get => which == WHICH.Disembargo ? BuildPointer<Zap.Rpc.Disembargo.WRITER>(0) : default;
                set => Link(0, value!);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xe94ccf8031176ec4UL)]
    public class Bootstrap : IZapSerializable
    {
        public const UInt64 typeId = 0xe94ccf8031176ec4UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            DeprecatedObjectId = ZapSerializable.Create<object>(reader.DeprecatedObjectId);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            writer.DeprecatedObjectId.SetObject(DeprecatedObjectId);
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public object? DeprecatedObjectId
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public DeserializerState DeprecatedObjectId => ctx.StructReadPointer(0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public DynamicSerializerState DeprecatedObjectId
            {
                get => BuildPointer<DynamicSerializerState>(0);
                set => Link(0, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x836a53ce789d4cd4UL)]
    public class Call : IZapSerializable
    {
        public const UInt64 typeId = 0x836a53ce789d4cd4UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            Target = ZapSerializable.Create<Zap.Rpc.MessageTarget>(reader.Target);
            InterfaceId = reader.InterfaceId;
            MethodId = reader.MethodId;
            Params = ZapSerializable.Create<Zap.Rpc.Payload>(reader.Params);
            SendResultsTo = ZapSerializable.Create<Zap.Rpc.Call.sendResultsTo>(reader.SendResultsTo);
            AllowThirdPartyTailCall = reader.AllowThirdPartyTailCall;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            Target?.serialize(writer.Target);
            writer.InterfaceId = InterfaceId;
            writer.MethodId = MethodId;
            Params?.serialize(writer.Params);
            SendResultsTo?.serialize(writer.SendResultsTo);
            writer.AllowThirdPartyTailCall = AllowThirdPartyTailCall;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public Zap.Rpc.MessageTarget? Target
        {
            get;
            set;
        }

        public ulong InterfaceId
        {
            get;
            set;
        }

        public ushort MethodId
        {
            get;
            set;
        }

        public Zap.Rpc.Payload? Params
        {
            get;
            set;
        }

        public Zap.Rpc.Call.sendResultsTo? SendResultsTo
        {
            get;
            set;
        }

        public bool AllowThirdPartyTailCall
        {
            get;
            set;
        }

        = false;
        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public Zap.Rpc.MessageTarget.READER Target => ctx.ReadStruct(0, Zap.Rpc.MessageTarget.READER.create);
            public ulong InterfaceId => ctx.ReadDataULong(64UL, 0UL);
            public ushort MethodId => ctx.ReadDataUShort(32UL, (ushort)0);
            public Zap.Rpc.Payload.READER Params => ctx.ReadStruct(1, Zap.Rpc.Payload.READER.create);
            public sendResultsTo.READER SendResultsTo => new sendResultsTo.READER(ctx);
            public bool AllowThirdPartyTailCall => ctx.ReadDataBool(128UL, false);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(3, 3);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public Zap.Rpc.MessageTarget.WRITER Target
            {
                get => BuildPointer<Zap.Rpc.MessageTarget.WRITER>(0);
                set => Link(0, value);
            }

            public ulong InterfaceId
            {
                get => this.ReadDataULong(64UL, 0UL);
                set => this.WriteData(64UL, value, 0UL);
            }

            public ushort MethodId
            {
                get => this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, value, (ushort)0);
            }

            public Zap.Rpc.Payload.WRITER Params
            {
                get => BuildPointer<Zap.Rpc.Payload.WRITER>(1);
                set => Link(1, value);
            }

            public sendResultsTo.WRITER SendResultsTo
            {
                get => Rewrap<sendResultsTo.WRITER>();
            }

            public bool AllowThirdPartyTailCall
            {
                get => this.ReadDataBool(128UL, false);
                set => this.WriteData(128UL, value, false);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xdae8b0f61aab5f99UL)]
        public class sendResultsTo : IZapSerializable
        {
            public const UInt64 typeId = 0xdae8b0f61aab5f99UL;
            public enum WHICH : ushort
            {
                Caller = 0,
                Yourself = 1,
                ThirdParty = 2,
                undefined = 65535
            }

            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                switch (reader.which)
                {
                    case WHICH.Caller:
                        which = reader.which;
                        break;
                    case WHICH.Yourself:
                        which = reader.which;
                        break;
                    case WHICH.ThirdParty:
                        ThirdParty = ZapSerializable.Create<object>(reader.ThirdParty);
                        break;
                }

                applyDefaults();
            }

            private WHICH _which = WHICH.undefined;
            private object? _content;
            public WHICH which
            {
                get => _which;
                set
                {
                    if (value == _which)
                        return;
                    _which = value;
                    switch (value)
                    {
                        case WHICH.Caller:
                            break;
                        case WHICH.Yourself:
                            break;
                        case WHICH.ThirdParty:
                            _content = null;
                            break;
                    }
                }
            }

            public void serialize(WRITER writer)
            {
                writer.which = which;
                switch (which)
                {
                    case WHICH.Caller:
                        break;
                    case WHICH.Yourself:
                        break;
                    case WHICH.ThirdParty:
                        writer.ThirdParty!.SetObject(ThirdParty);
                        break;
                }
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public object? ThirdParty
            {
                get => _which == WHICH.ThirdParty ? (object?)_content : null;
                set
                {
                    _which = WHICH.ThirdParty;
                    _content = value;
                }
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WHICH which => (WHICH)ctx.ReadDataUShort(48U, (ushort)0);
                public DeserializerState ThirdParty => which == WHICH.ThirdParty ? ctx.StructReadPointer(2) : default;
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                }

                public WHICH which
                {
                    get => (WHICH)this.ReadDataUShort(48U, (ushort)0);
                    set => this.WriteData(48U, (ushort)value, (ushort)0);
                }

                [DisallowNull]
                public DynamicSerializerState? ThirdParty
                {
                    get => which == WHICH.ThirdParty ? BuildPointer<DynamicSerializerState>(2) : default;
                    set => Link(2, value!);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x9e19b28d3db3573aUL)]
    public class Return : IZapSerializable
    {
        public const UInt64 typeId = 0x9e19b28d3db3573aUL;
        public enum WHICH : ushort
        {
            Results = 0,
            Exception = 1,
            Canceled = 2,
            ResultsSentElsewhere = 3,
            TakeFromOtherQuestion = 4,
            AcceptFromThirdParty = 5,
            undefined = 65535
        }

        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.Results:
                    Results = ZapSerializable.Create<Zap.Rpc.Payload>(reader.Results);
                    break;
                case WHICH.Exception:
                    Exception = ZapSerializable.Create<Zap.Rpc.Exception>(reader.Exception);
                    break;
                case WHICH.Canceled:
                    which = reader.which;
                    break;
                case WHICH.ResultsSentElsewhere:
                    which = reader.which;
                    break;
                case WHICH.TakeFromOtherQuestion:
                    TakeFromOtherQuestion = reader.TakeFromOtherQuestion;
                    break;
                case WHICH.AcceptFromThirdParty:
                    AcceptFromThirdParty = ZapSerializable.Create<object>(reader.AcceptFromThirdParty);
                    break;
            }

            AnswerId = reader.AnswerId;
            ReleaseParamCaps = reader.ReleaseParamCaps;
            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object? _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.Results:
                        _content = null;
                        break;
                    case WHICH.Exception:
                        _content = null;
                        break;
                    case WHICH.Canceled:
                        break;
                    case WHICH.ResultsSentElsewhere:
                        break;
                    case WHICH.TakeFromOtherQuestion:
                        _content = 0;
                        break;
                    case WHICH.AcceptFromThirdParty:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.Results:
                    Results?.serialize(writer.Results!);
                    break;
                case WHICH.Exception:
                    Exception?.serialize(writer.Exception!);
                    break;
                case WHICH.Canceled:
                    break;
                case WHICH.ResultsSentElsewhere:
                    break;
                case WHICH.TakeFromOtherQuestion:
                    writer.TakeFromOtherQuestion = TakeFromOtherQuestion!.Value;
                    break;
                case WHICH.AcceptFromThirdParty:
                    writer.AcceptFromThirdParty!.SetObject(AcceptFromThirdParty);
                    break;
            }

            writer.AnswerId = AnswerId;
            writer.ReleaseParamCaps = ReleaseParamCaps;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint AnswerId
        {
            get;
            set;
        }

        public bool ReleaseParamCaps
        {
            get;
            set;
        }

        = true;
        public Zap.Rpc.Payload? Results
        {
            get => _which == WHICH.Results ? (Zap.Rpc.Payload?)_content : null;
            set
            {
                _which = WHICH.Results;
                _content = value;
            }
        }

        public Zap.Rpc.Exception? Exception
        {
            get => _which == WHICH.Exception ? (Zap.Rpc.Exception?)_content : null;
            set
            {
                _which = WHICH.Exception;
                _content = value;
            }
        }

        public uint? TakeFromOtherQuestion
        {
            get => _which == WHICH.TakeFromOtherQuestion ? (uint?)_content : null;
            set
            {
                _which = WHICH.TakeFromOtherQuestion;
                _content = value;
            }
        }

        public object? AcceptFromThirdParty
        {
            get => _which == WHICH.AcceptFromThirdParty ? (object?)_content : null;
            set
            {
                _which = WHICH.AcceptFromThirdParty;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(48U, (ushort)0);
            public uint AnswerId => ctx.ReadDataUInt(0UL, 0U);
            public bool ReleaseParamCaps => ctx.ReadDataBool(32UL, true);
            public Zap.Rpc.Payload.READER Results => which == WHICH.Results ? ctx.ReadStruct(0, Zap.Rpc.Payload.READER.create) : default;
            public Zap.Rpc.Exception.READER Exception => which == WHICH.Exception ? ctx.ReadStruct(0, Zap.Rpc.Exception.READER.create) : default;
            public uint TakeFromOtherQuestion => which == WHICH.TakeFromOtherQuestion ? ctx.ReadDataUInt(64UL, 0U) : default;
            public DeserializerState AcceptFromThirdParty => which == WHICH.AcceptFromThirdParty ? ctx.StructReadPointer(0) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(2, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(48U, (ushort)0);
                set => this.WriteData(48U, (ushort)value, (ushort)0);
            }

            public uint AnswerId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public bool ReleaseParamCaps
            {
                get => this.ReadDataBool(32UL, true);
                set => this.WriteData(32UL, value, true);
            }

            [DisallowNull]
            public Zap.Rpc.Payload.WRITER? Results
            {
                get => which == WHICH.Results ? BuildPointer<Zap.Rpc.Payload.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Exception.WRITER? Exception
            {
                get => which == WHICH.Exception ? BuildPointer<Zap.Rpc.Exception.WRITER>(0) : default;
                set => Link(0, value!);
            }

            public uint TakeFromOtherQuestion
            {
                get => which == WHICH.TakeFromOtherQuestion ? this.ReadDataUInt(64UL, 0U) : default;
                set => this.WriteData(64UL, value, 0U);
            }

            [DisallowNull]
            public DynamicSerializerState? AcceptFromThirdParty
            {
                get => which == WHICH.AcceptFromThirdParty ? BuildPointer<DynamicSerializerState>(0) : default;
                set => Link(0, value!);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd37d2eb2c2f80e63UL)]
    public class Finish : IZapSerializable
    {
        public const UInt64 typeId = 0xd37d2eb2c2f80e63UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            ReleaseResultCaps = reader.ReleaseResultCaps;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            writer.ReleaseResultCaps = ReleaseResultCaps;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public bool ReleaseResultCaps
        {
            get;
            set;
        }

        = true;
        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public bool ReleaseResultCaps => ctx.ReadDataBool(32UL, true);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public bool ReleaseResultCaps
            {
                get => this.ReadDataBool(32UL, true);
                set => this.WriteData(32UL, value, true);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xbbc29655fa89086eUL)]
    public class Resolve : IZapSerializable
    {
        public const UInt64 typeId = 0xbbc29655fa89086eUL;
        public enum WHICH : ushort
        {
            Cap = 0,
            Exception = 1,
            undefined = 65535
        }

        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.Cap:
                    Cap = ZapSerializable.Create<Zap.Rpc.CapDescriptor>(reader.Cap);
                    break;
                case WHICH.Exception:
                    Exception = ZapSerializable.Create<Zap.Rpc.Exception>(reader.Exception);
                    break;
            }

            PromiseId = reader.PromiseId;
            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object? _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.Cap:
                        _content = null;
                        break;
                    case WHICH.Exception:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.Cap:
                    Cap?.serialize(writer.Cap!);
                    break;
                case WHICH.Exception:
                    Exception?.serialize(writer.Exception!);
                    break;
            }

            writer.PromiseId = PromiseId;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint PromiseId
        {
            get;
            set;
        }

        public Zap.Rpc.CapDescriptor? Cap
        {
            get => _which == WHICH.Cap ? (Zap.Rpc.CapDescriptor?)_content : null;
            set
            {
                _which = WHICH.Cap;
                _content = value;
            }
        }

        public Zap.Rpc.Exception? Exception
        {
            get => _which == WHICH.Exception ? (Zap.Rpc.Exception?)_content : null;
            set
            {
                _which = WHICH.Exception;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(32U, (ushort)0);
            public uint PromiseId => ctx.ReadDataUInt(0UL, 0U);
            public Zap.Rpc.CapDescriptor.READER Cap => which == WHICH.Cap ? ctx.ReadStruct(0, Zap.Rpc.CapDescriptor.READER.create) : default;
            public Zap.Rpc.Exception.READER Exception => which == WHICH.Exception ? ctx.ReadStruct(0, Zap.Rpc.Exception.READER.create) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(32U, (ushort)0);
                set => this.WriteData(32U, (ushort)value, (ushort)0);
            }

            public uint PromiseId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            [DisallowNull]
            public Zap.Rpc.CapDescriptor.WRITER? Cap
            {
                get => which == WHICH.Cap ? BuildPointer<Zap.Rpc.CapDescriptor.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.Exception.WRITER? Exception
            {
                get => which == WHICH.Exception ? BuildPointer<Zap.Rpc.Exception.WRITER>(0) : default;
                set => Link(0, value!);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xad1a6c0d7dd07497UL)]
    public class Release : IZapSerializable
    {
        public const UInt64 typeId = 0xad1a6c0d7dd07497UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Id = reader.Id;
            ReferenceCount = reader.ReferenceCount;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Id = Id;
            writer.ReferenceCount = ReferenceCount;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint Id
        {
            get;
            set;
        }

        public uint ReferenceCount
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint Id => ctx.ReadDataUInt(0UL, 0U);
            public uint ReferenceCount => ctx.ReadDataUInt(32UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 0);
            }

            public uint Id
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public uint ReferenceCount
            {
                get => this.ReadDataUInt(32UL, 0U);
                set => this.WriteData(32UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xf964368b0fbd3711UL)]
    public class Disembargo : IZapSerializable
    {
        public const UInt64 typeId = 0xf964368b0fbd3711UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Target = ZapSerializable.Create<Zap.Rpc.MessageTarget>(reader.Target);
            Context = ZapSerializable.Create<Zap.Rpc.Disembargo.context>(reader.Context);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            Target?.serialize(writer.Target);
            Context?.serialize(writer.Context);
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public Zap.Rpc.MessageTarget? Target
        {
            get;
            set;
        }

        public Zap.Rpc.Disembargo.context? Context
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public Zap.Rpc.MessageTarget.READER Target => ctx.ReadStruct(0, Zap.Rpc.MessageTarget.READER.create);
            public context.READER Context => new context.READER(ctx);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public Zap.Rpc.MessageTarget.WRITER Target
            {
                get => BuildPointer<Zap.Rpc.MessageTarget.WRITER>(0);
                set => Link(0, value);
            }

            public context.WRITER Context
            {
                get => Rewrap<context.WRITER>();
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd562b4df655bdd4dUL)]
        public class context : IZapSerializable
        {
            public const UInt64 typeId = 0xd562b4df655bdd4dUL;
            public enum WHICH : ushort
            {
                SenderLoopback = 0,
                ReceiverLoopback = 1,
                Accept = 2,
                Provide = 3,
                undefined = 65535
            }

            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                switch (reader.which)
                {
                    case WHICH.SenderLoopback:
                        SenderLoopback = reader.SenderLoopback;
                        break;
                    case WHICH.ReceiverLoopback:
                        ReceiverLoopback = reader.ReceiverLoopback;
                        break;
                    case WHICH.Accept:
                        which = reader.which;
                        break;
                    case WHICH.Provide:
                        Provide = reader.Provide;
                        break;
                }

                applyDefaults();
            }

            private WHICH _which = WHICH.undefined;
            private object? _content;
            public WHICH which
            {
                get => _which;
                set
                {
                    if (value == _which)
                        return;
                    _which = value;
                    switch (value)
                    {
                        case WHICH.SenderLoopback:
                            _content = 0;
                            break;
                        case WHICH.ReceiverLoopback:
                            _content = 0;
                            break;
                        case WHICH.Accept:
                            break;
                        case WHICH.Provide:
                            _content = 0;
                            break;
                    }
                }
            }

            public void serialize(WRITER writer)
            {
                writer.which = which;
                switch (which)
                {
                    case WHICH.SenderLoopback:
                        writer.SenderLoopback = SenderLoopback!.Value;
                        break;
                    case WHICH.ReceiverLoopback:
                        writer.ReceiverLoopback = ReceiverLoopback!.Value;
                        break;
                    case WHICH.Accept:
                        break;
                    case WHICH.Provide:
                        writer.Provide = Provide!.Value;
                        break;
                }
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public uint? SenderLoopback
            {
                get => _which == WHICH.SenderLoopback ? (uint?)_content : null;
                set
                {
                    _which = WHICH.SenderLoopback;
                    _content = value;
                }
            }

            public uint? ReceiverLoopback
            {
                get => _which == WHICH.ReceiverLoopback ? (uint?)_content : null;
                set
                {
                    _which = WHICH.ReceiverLoopback;
                    _content = value;
                }
            }

            public uint? Provide
            {
                get => _which == WHICH.Provide ? (uint?)_content : null;
                set
                {
                    _which = WHICH.Provide;
                    _content = value;
                }
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WHICH which => (WHICH)ctx.ReadDataUShort(32U, (ushort)0);
                public uint SenderLoopback => which == WHICH.SenderLoopback ? ctx.ReadDataUInt(0UL, 0U) : default;
                public uint ReceiverLoopback => which == WHICH.ReceiverLoopback ? ctx.ReadDataUInt(0UL, 0U) : default;
                public uint Provide => which == WHICH.Provide ? ctx.ReadDataUInt(0UL, 0U) : default;
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                }

                public WHICH which
                {
                    get => (WHICH)this.ReadDataUShort(32U, (ushort)0);
                    set => this.WriteData(32U, (ushort)value, (ushort)0);
                }

                public uint SenderLoopback
                {
                    get => which == WHICH.SenderLoopback ? this.ReadDataUInt(0UL, 0U) : default;
                    set => this.WriteData(0UL, value, 0U);
                }

                public uint ReceiverLoopback
                {
                    get => which == WHICH.ReceiverLoopback ? this.ReadDataUInt(0UL, 0U) : default;
                    set => this.WriteData(0UL, value, 0U);
                }

                public uint Provide
                {
                    get => which == WHICH.Provide ? this.ReadDataUInt(0UL, 0U) : default;
                    set => this.WriteData(0UL, value, 0U);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x9c6a046bfbc1ac5aUL)]
    public class Provide : IZapSerializable
    {
        public const UInt64 typeId = 0x9c6a046bfbc1ac5aUL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            Target = ZapSerializable.Create<Zap.Rpc.MessageTarget>(reader.Target);
            Recipient = ZapSerializable.Create<object>(reader.Recipient);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            Target?.serialize(writer.Target);
            writer.Recipient.SetObject(Recipient);
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public Zap.Rpc.MessageTarget? Target
        {
            get;
            set;
        }

        public object? Recipient
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public Zap.Rpc.MessageTarget.READER Target => ctx.ReadStruct(0, Zap.Rpc.MessageTarget.READER.create);
            public DeserializerState Recipient => ctx.StructReadPointer(1);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 2);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public Zap.Rpc.MessageTarget.WRITER Target
            {
                get => BuildPointer<Zap.Rpc.MessageTarget.WRITER>(0);
                set => Link(0, value);
            }

            public DynamicSerializerState Recipient
            {
                get => BuildPointer<DynamicSerializerState>(1);
                set => Link(1, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd4c9b56290554016UL)]
    public class Accept : IZapSerializable
    {
        public const UInt64 typeId = 0xd4c9b56290554016UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            Provision = ZapSerializable.Create<object>(reader.Provision);
            Embargo = reader.Embargo;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            writer.Provision.SetObject(Provision);
            writer.Embargo = Embargo;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public object? Provision
        {
            get;
            set;
        }

        public bool Embargo
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public DeserializerState Provision => ctx.StructReadPointer(0);
            public bool Embargo => ctx.ReadDataBool(32UL, false);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public DynamicSerializerState Provision
            {
                get => BuildPointer<DynamicSerializerState>(0);
                set => Link(0, value);
            }

            public bool Embargo
            {
                get => this.ReadDataBool(32UL, false);
                set => this.WriteData(32UL, value, false);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xfbe1980490e001afUL)]
    public class Join : IZapSerializable
    {
        public const UInt64 typeId = 0xfbe1980490e001afUL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            Target = ZapSerializable.Create<Zap.Rpc.MessageTarget>(reader.Target);
            KeyPart = ZapSerializable.Create<object>(reader.KeyPart);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            Target?.serialize(writer.Target);
            writer.KeyPart.SetObject(KeyPart);
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public Zap.Rpc.MessageTarget? Target
        {
            get;
            set;
        }

        public object? KeyPart
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public Zap.Rpc.MessageTarget.READER Target => ctx.ReadStruct(0, Zap.Rpc.MessageTarget.READER.create);
            public DeserializerState KeyPart => ctx.StructReadPointer(1);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 2);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public Zap.Rpc.MessageTarget.WRITER Target
            {
                get => BuildPointer<Zap.Rpc.MessageTarget.WRITER>(0);
                set => Link(0, value);
            }

            public DynamicSerializerState KeyPart
            {
                get => BuildPointer<DynamicSerializerState>(1);
                set => Link(1, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x95bc14545813fbc1UL)]
    public class MessageTarget : IZapSerializable
    {
        public const UInt64 typeId = 0x95bc14545813fbc1UL;
        public enum WHICH : ushort
        {
            ImportedCap = 0,
            PromisedAnswer = 1,
            undefined = 65535
        }

        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.ImportedCap:
                    ImportedCap = reader.ImportedCap;
                    break;
                case WHICH.PromisedAnswer:
                    PromisedAnswer = ZapSerializable.Create<Zap.Rpc.PromisedAnswer>(reader.PromisedAnswer);
                    break;
            }

            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object? _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.ImportedCap:
                        _content = 0;
                        break;
                    case WHICH.PromisedAnswer:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.ImportedCap:
                    writer.ImportedCap = ImportedCap!.Value;
                    break;
                case WHICH.PromisedAnswer:
                    PromisedAnswer?.serialize(writer.PromisedAnswer!);
                    break;
            }
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint? ImportedCap
        {
            get => _which == WHICH.ImportedCap ? (uint?)_content : null;
            set
            {
                _which = WHICH.ImportedCap;
                _content = value;
            }
        }

        public Zap.Rpc.PromisedAnswer? PromisedAnswer
        {
            get => _which == WHICH.PromisedAnswer ? (Zap.Rpc.PromisedAnswer?)_content : null;
            set
            {
                _which = WHICH.PromisedAnswer;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(32U, (ushort)0);
            public uint ImportedCap => which == WHICH.ImportedCap ? ctx.ReadDataUInt(0UL, 0U) : default;
            public Zap.Rpc.PromisedAnswer.READER PromisedAnswer => which == WHICH.PromisedAnswer ? ctx.ReadStruct(0, Zap.Rpc.PromisedAnswer.READER.create) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(32U, (ushort)0);
                set => this.WriteData(32U, (ushort)value, (ushort)0);
            }

            public uint ImportedCap
            {
                get => which == WHICH.ImportedCap ? this.ReadDataUInt(0UL, 0U) : default;
                set => this.WriteData(0UL, value, 0U);
            }

            [DisallowNull]
            public Zap.Rpc.PromisedAnswer.WRITER? PromisedAnswer
            {
                get => which == WHICH.PromisedAnswer ? BuildPointer<Zap.Rpc.PromisedAnswer.WRITER>(0) : default;
                set => Link(0, value!);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x9a0e61223d96743bUL)]
    public class Payload : IZapSerializable
    {
        public const UInt64 typeId = 0x9a0e61223d96743bUL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Content = ZapSerializable.Create<object>(reader.Content);
            CapTable = reader.CapTable?.ToReadOnlyList(_ => ZapSerializable.Create<Zap.Rpc.CapDescriptor>(_)!);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Content.SetObject(Content);
            writer.CapTable.Init(CapTable, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public object? Content
        {
            get;
            set;
        }

        public IReadOnlyList<Zap.Rpc.CapDescriptor>? CapTable
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public DeserializerState Content => ctx.StructReadPointer(0);
            public IReadOnlyList<Zap.Rpc.CapDescriptor.READER> CapTable => ctx.ReadList(1).Cast(Zap.Rpc.CapDescriptor.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(0, 2);
            }

            public DynamicSerializerState Content
            {
                get => BuildPointer<DynamicSerializerState>(0);
                set => Link(0, value);
            }

            public ListOfStructsSerializer<Zap.Rpc.CapDescriptor.WRITER> CapTable
            {
                get => BuildPointer<ListOfStructsSerializer<Zap.Rpc.CapDescriptor.WRITER>>(1);
                set => Link(1, value);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0x8523ddc40b86b8b0UL)]
    public class CapDescriptor : IZapSerializable
    {
        public const UInt64 typeId = 0x8523ddc40b86b8b0UL;
        public enum WHICH : ushort
        {
            None = 0,
            SenderHosted = 1,
            SenderPromise = 2,
            ReceiverHosted = 3,
            ReceiverAnswer = 4,
            ThirdPartyHosted = 5,
            undefined = 65535
        }

        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            switch (reader.which)
            {
                case WHICH.None:
                    which = reader.which;
                    break;
                case WHICH.SenderHosted:
                    SenderHosted = reader.SenderHosted;
                    break;
                case WHICH.SenderPromise:
                    SenderPromise = reader.SenderPromise;
                    break;
                case WHICH.ReceiverHosted:
                    ReceiverHosted = reader.ReceiverHosted;
                    break;
                case WHICH.ReceiverAnswer:
                    ReceiverAnswer = ZapSerializable.Create<Zap.Rpc.PromisedAnswer>(reader.ReceiverAnswer);
                    break;
                case WHICH.ThirdPartyHosted:
                    ThirdPartyHosted = ZapSerializable.Create<Zap.Rpc.ThirdPartyCapDescriptor>(reader.ThirdPartyHosted);
                    break;
            }

            applyDefaults();
        }

        private WHICH _which = WHICH.undefined;
        private object? _content;
        public WHICH which
        {
            get => _which;
            set
            {
                if (value == _which)
                    return;
                _which = value;
                switch (value)
                {
                    case WHICH.None:
                        break;
                    case WHICH.SenderHosted:
                        _content = 0;
                        break;
                    case WHICH.SenderPromise:
                        _content = 0;
                        break;
                    case WHICH.ReceiverHosted:
                        _content = 0;
                        break;
                    case WHICH.ReceiverAnswer:
                        _content = null;
                        break;
                    case WHICH.ThirdPartyHosted:
                        _content = null;
                        break;
                }
            }
        }

        public void serialize(WRITER writer)
        {
            writer.which = which;
            switch (which)
            {
                case WHICH.None:
                    break;
                case WHICH.SenderHosted:
                    writer.SenderHosted = SenderHosted!.Value;
                    break;
                case WHICH.SenderPromise:
                    writer.SenderPromise = SenderPromise!.Value;
                    break;
                case WHICH.ReceiverHosted:
                    writer.ReceiverHosted = ReceiverHosted!.Value;
                    break;
                case WHICH.ReceiverAnswer:
                    ReceiverAnswer?.serialize(writer.ReceiverAnswer!);
                    break;
                case WHICH.ThirdPartyHosted:
                    ThirdPartyHosted?.serialize(writer.ThirdPartyHosted!);
                    break;
            }
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint? SenderHosted
        {
            get => _which == WHICH.SenderHosted ? (uint?)_content : null;
            set
            {
                _which = WHICH.SenderHosted;
                _content = value;
            }
        }

        public uint? SenderPromise
        {
            get => _which == WHICH.SenderPromise ? (uint?)_content : null;
            set
            {
                _which = WHICH.SenderPromise;
                _content = value;
            }
        }

        public uint? ReceiverHosted
        {
            get => _which == WHICH.ReceiverHosted ? (uint?)_content : null;
            set
            {
                _which = WHICH.ReceiverHosted;
                _content = value;
            }
        }

        public Zap.Rpc.PromisedAnswer? ReceiverAnswer
        {
            get => _which == WHICH.ReceiverAnswer ? (Zap.Rpc.PromisedAnswer?)_content : null;
            set
            {
                _which = WHICH.ReceiverAnswer;
                _content = value;
            }
        }

        public Zap.Rpc.ThirdPartyCapDescriptor? ThirdPartyHosted
        {
            get => _which == WHICH.ThirdPartyHosted ? (Zap.Rpc.ThirdPartyCapDescriptor?)_content : null;
            set
            {
                _which = WHICH.ThirdPartyHosted;
                _content = value;
            }
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public WHICH which => (WHICH)ctx.ReadDataUShort(0U, (ushort)0);
            public uint SenderHosted => which == WHICH.SenderHosted ? ctx.ReadDataUInt(32UL, 0U) : default;
            public uint SenderPromise => which == WHICH.SenderPromise ? ctx.ReadDataUInt(32UL, 0U) : default;
            public uint ReceiverHosted => which == WHICH.ReceiverHosted ? ctx.ReadDataUInt(32UL, 0U) : default;
            public Zap.Rpc.PromisedAnswer.READER ReceiverAnswer => which == WHICH.ReceiverAnswer ? ctx.ReadStruct(0, Zap.Rpc.PromisedAnswer.READER.create) : default;
            public Zap.Rpc.ThirdPartyCapDescriptor.READER ThirdPartyHosted => which == WHICH.ThirdPartyHosted ? ctx.ReadStruct(0, Zap.Rpc.ThirdPartyCapDescriptor.READER.create) : default;
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public WHICH which
            {
                get => (WHICH)this.ReadDataUShort(0U, (ushort)0);
                set => this.WriteData(0U, (ushort)value, (ushort)0);
            }

            public uint SenderHosted
            {
                get => which == WHICH.SenderHosted ? this.ReadDataUInt(32UL, 0U) : default;
                set => this.WriteData(32UL, value, 0U);
            }

            public uint SenderPromise
            {
                get => which == WHICH.SenderPromise ? this.ReadDataUInt(32UL, 0U) : default;
                set => this.WriteData(32UL, value, 0U);
            }

            public uint ReceiverHosted
            {
                get => which == WHICH.ReceiverHosted ? this.ReadDataUInt(32UL, 0U) : default;
                set => this.WriteData(32UL, value, 0U);
            }

            [DisallowNull]
            public Zap.Rpc.PromisedAnswer.WRITER? ReceiverAnswer
            {
                get => which == WHICH.ReceiverAnswer ? BuildPointer<Zap.Rpc.PromisedAnswer.WRITER>(0) : default;
                set => Link(0, value!);
            }

            [DisallowNull]
            public Zap.Rpc.ThirdPartyCapDescriptor.WRITER? ThirdPartyHosted
            {
                get => which == WHICH.ThirdPartyHosted ? BuildPointer<Zap.Rpc.ThirdPartyCapDescriptor.WRITER>(0) : default;
                set => Link(0, value!);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd800b1d6cd6f1ca0UL)]
    public class PromisedAnswer : IZapSerializable
    {
        public const UInt64 typeId = 0xd800b1d6cd6f1ca0UL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            QuestionId = reader.QuestionId;
            Transform = reader.Transform?.ToReadOnlyList(_ => ZapSerializable.Create<Zap.Rpc.PromisedAnswer.Op>(_)!);
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.QuestionId = QuestionId;
            writer.Transform.Init(Transform, (_s1, _v1) => _v1?.serialize(_s1));
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public uint QuestionId
        {
            get;
            set;
        }

        public IReadOnlyList<Zap.Rpc.PromisedAnswer.Op>? Transform
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public uint QuestionId => ctx.ReadDataUInt(0UL, 0U);
            public IReadOnlyList<Zap.Rpc.PromisedAnswer.Op.READER> Transform => ctx.ReadList(0).Cast(Zap.Rpc.PromisedAnswer.Op.READER.create);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public uint QuestionId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }

            public ListOfStructsSerializer<Zap.Rpc.PromisedAnswer.Op.WRITER> Transform
            {
                get => BuildPointer<ListOfStructsSerializer<Zap.Rpc.PromisedAnswer.Op.WRITER>>(0);
                set => Link(0, value);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xf316944415569081UL)]
        public class Op : IZapSerializable
        {
            public const UInt64 typeId = 0xf316944415569081UL;
            public enum WHICH : ushort
            {
                Noop = 0,
                GetPointerField = 1,
                undefined = 65535
            }

            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                switch (reader.which)
                {
                    case WHICH.Noop:
                        which = reader.which;
                        break;
                    case WHICH.GetPointerField:
                        GetPointerField = reader.GetPointerField;
                        break;
                }

                applyDefaults();
            }

            private WHICH _which = WHICH.undefined;
            private object? _content;
            public WHICH which
            {
                get => _which;
                set
                {
                    if (value == _which)
                        return;
                    _which = value;
                    switch (value)
                    {
                        case WHICH.Noop:
                            break;
                        case WHICH.GetPointerField:
                            _content = 0;
                            break;
                    }
                }
            }

            public void serialize(WRITER writer)
            {
                writer.which = which;
                switch (which)
                {
                    case WHICH.Noop:
                        break;
                    case WHICH.GetPointerField:
                        writer.GetPointerField = GetPointerField!.Value;
                        break;
                }
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ushort? GetPointerField
            {
                get => _which == WHICH.GetPointerField ? (ushort?)_content : null;
                set
                {
                    _which = WHICH.GetPointerField;
                    _content = value;
                }
            }

            public struct READER
            {
                readonly DeserializerState ctx;
                public READER(DeserializerState ctx)
                {
                    this.ctx = ctx;
                }

                public static READER create(DeserializerState ctx) => new READER(ctx);
                public static implicit operator DeserializerState(READER reader) => reader.ctx;
                public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
                public WHICH which => (WHICH)ctx.ReadDataUShort(0U, (ushort)0);
                public ushort GetPointerField => which == WHICH.GetPointerField ? ctx.ReadDataUShort(16UL, (ushort)0) : default;
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public WHICH which
                {
                    get => (WHICH)this.ReadDataUShort(0U, (ushort)0);
                    set => this.WriteData(0U, (ushort)value, (ushort)0);
                }

                public ushort GetPointerField
                {
                    get => which == WHICH.GetPointerField ? this.ReadDataUShort(16UL, (ushort)0) : default;
                    set => this.WriteData(16UL, value, (ushort)0);
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd37007fde1f0027dUL)]
    public class ThirdPartyCapDescriptor : IZapSerializable
    {
        public const UInt64 typeId = 0xd37007fde1f0027dUL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Id = ZapSerializable.Create<object>(reader.Id);
            VineId = reader.VineId;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Id.SetObject(Id);
            writer.VineId = VineId;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public object? Id
        {
            get;
            set;
        }

        public uint VineId
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public DeserializerState Id => ctx.StructReadPointer(0);
            public uint VineId => ctx.ReadDataUInt(0UL, 0U);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public DynamicSerializerState Id
            {
                get => BuildPointer<DynamicSerializerState>(0);
                set => Link(0, value);
            }

            public uint VineId
            {
                get => this.ReadDataUInt(0UL, 0U);
                set => this.WriteData(0UL, value, 0U);
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xd625b7063acf691aUL)]
    public class Exception : IZapSerializable
    {
        public const UInt64 typeId = 0xd625b7063acf691aUL;
        void IZapSerializable.Deserialize(DeserializerState arg_)
        {
            var reader = READER.create(arg_);
            Reason = reader.Reason;
            ObsoleteIsCallersFault = reader.ObsoleteIsCallersFault;
            ObsoleteDurability = reader.ObsoleteDurability;
            TheType = reader.TheType;
            applyDefaults();
        }

        public void serialize(WRITER writer)
        {
            writer.Reason = Reason;
            writer.ObsoleteIsCallersFault = ObsoleteIsCallersFault;
            writer.ObsoleteDurability = ObsoleteDurability;
            writer.TheType = TheType;
        }

        void IZapSerializable.Serialize(SerializerState arg_)
        {
            serialize(arg_.Rewrap<WRITER>());
        }

        public void applyDefaults()
        {
        }

        public string? Reason
        {
            get;
            set;
        }

        public bool ObsoleteIsCallersFault
        {
            get;
            set;
        }

        public ushort ObsoleteDurability
        {
            get;
            set;
        }

        public Zap.Rpc.Exception.Type TheType
        {
            get;
            set;
        }

        public struct READER
        {
            readonly DeserializerState ctx;
            public READER(DeserializerState ctx)
            {
                this.ctx = ctx;
            }

            public static READER create(DeserializerState ctx) => new READER(ctx);
            public static implicit operator DeserializerState(READER reader) => reader.ctx;
            public static implicit operator READER(DeserializerState ctx) => new READER(ctx);
            public string? Reason => ctx.ReadText(0, null);
            public bool ObsoleteIsCallersFault => ctx.ReadDataBool(0UL, false);
            public ushort ObsoleteDurability => ctx.ReadDataUShort(16UL, (ushort)0);
            public Zap.Rpc.Exception.Type TheType => (Zap.Rpc.Exception.Type)ctx.ReadDataUShort(32UL, (ushort)0);
        }

        public class WRITER : SerializerState
        {
            public WRITER()
            {
                this.SetStruct(1, 1);
            }

            public string? Reason
            {
                get => this.ReadText(0, null);
                set => this.WriteText(0, value, null);
            }

            public bool ObsoleteIsCallersFault
            {
                get => this.ReadDataBool(0UL, false);
                set => this.WriteData(0UL, value, false);
            }

            public ushort ObsoleteDurability
            {
                get => this.ReadDataUShort(16UL, (ushort)0);
                set => this.WriteData(16UL, value, (ushort)0);
            }

            public Zap.Rpc.Exception.Type TheType
            {
                get => (Zap.Rpc.Exception.Type)this.ReadDataUShort(32UL, (ushort)0);
                set => this.WriteData(32UL, (ushort)value, (ushort)0);
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("zapc-csharp", "1.3.0.0"), TypeId(0xb28c96e23f4cbd58UL)]
        public enum Type : ushort
        {
            failed,
            overloaded,
            disconnected,
            unimplemented
        }
    }
}