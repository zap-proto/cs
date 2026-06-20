using Zap;
using Zap.Rpc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ZapGen
{
    [TypeId(0xb09c1336dc3ea94eUL), Proxy(typeof(Issue25A_Proxy)), Skeleton(typeof(Issue25A_Skeleton))]
    public interface IIssue25A : IDisposable
    {
        Task<long> MethodA(CancellationToken cancellationToken_ = default);
    }

    public class Issue25A_Proxy : Proxy, IIssue25A
    {
        public async Task<long> MethodA(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.Issue25A.Params_methodA.WRITER>();
            var arg_ = new ZapGen.Issue25A.Params_methodA()
            { };
            arg_.serialize(in_);
            var d_ = await Call(12726067773386434894UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_).WhenReturned;
            var r_ = ZapSerializable.Create<ZapGen.Issue25A.Result_methodA>(d_);
            return (r_.Result);
        }
    }

    public class Issue25A_Skeleton : Skeleton<IIssue25A>
    {
        public Issue25A_Skeleton()
        {
            SetMethodTable(MethodA);
        }

        public override ulong InterfaceId => 12726067773386434894UL;
        Task<AnswerOrCounterquestion> MethodA(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.MethodA(cancellationToken_), result =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.Issue25A.Result_methodA.WRITER>();
                var r_ = new ZapGen.Issue25A.Result_methodA { Result = result };
                r_.serialize(s_);
                return s_;
            }

            );
        }
    }

    public static class Issue25A
    {
        [TypeId(0x994fd8d48f77e57cUL)]
        public class Params_methodA : IZapSerializable
        {
            public const UInt64 typeId = 0x994fd8d48f77e57cUL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0xf504d63e26c4db14UL)]
        public class Result_methodA : IZapSerializable
        {
            public const UInt64 typeId = 0xf504d63e26c4db14UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Result = reader.Result;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Result = Result;
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public long Result
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
                public long Result => ctx.ReadDataLong(0UL, 0L);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(1, 0);
                }

                public long Result
                {
                    get => this.ReadDataLong(0UL, 0L);
                    set => this.WriteData(0UL, value, 0L);
                }
            }
        }
    }

    [TypeId(0x9a5c2572c0400979UL), Proxy(typeof(CapHolder_Proxy<>)), Skeleton(typeof(CapHolder_Skeleton<>))]
    public interface ICapHolder<TCapType> : IDisposable where TCapType : class
    {
        Task<TCapType> Cap(CancellationToken cancellationToken_ = default);
    }

    public class CapHolder_Proxy<TCapType> : Proxy, ICapHolder<TCapType> where TCapType : class
    {
        public Task<TCapType> Cap(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.CapHolder<TCapType>.Params_cap.WRITER>();
            var arg_ = new ZapGen.CapHolder<TCapType>.Params_cap()
            { };
            arg_.serialize(in_);
            return Impatient.MakePipelineAware(Call(11122806354480204153UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                var r_ = ZapSerializable.Create<ZapGen.CapHolder<TCapType>.Result_cap>(d_);
                return (r_.Cap);
            }

            );
        }
    }

    public class CapHolder_Skeleton<TCapType> : Skeleton<ICapHolder<TCapType>> where TCapType : class
    {
        public CapHolder_Skeleton()
        {
            SetMethodTable(Cap);
        }

        public override ulong InterfaceId => 11122806354480204153UL;
        Task<AnswerOrCounterquestion> Cap(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.Cap(cancellationToken_), cap =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.CapHolder<TCapType>.Result_cap.WRITER>();
                var r_ = new ZapGen.CapHolder<TCapType>.Result_cap { Cap = cap };
                r_.serialize(s_);
                return s_;
            }

            );
        }
    }

    public static class CapHolder<TCapType>
        where TCapType : class
    {
        [TypeId(0x9fb50287386a4515UL)]
        public class Params_cap : IZapSerializable
        {
            public const UInt64 typeId = 0x9fb50287386a4515UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0x9b3a7a5298aae998UL)]
        public class Result_cap : IZapSerializable
        {
            public const UInt64 typeId = 0x9b3a7a5298aae998UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Cap = ZapSerializable.Create<TCapType>(reader.Cap);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Cap.SetObject(Cap);
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public TCapType Cap
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
                public DeserializerState Cap => ctx.StructReadPointer(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public DynamicSerializerState Cap
                {
                    get => BuildPointer<DynamicSerializerState>(0);
                    set => Link(0, value);
                }
            }
        }
    }

    [TypeId(0xc210c6a49d79653cUL), Proxy(typeof(CapHolderA_Proxy)), Skeleton(typeof(CapHolderA_Skeleton))]
    public interface ICapHolderA : IDisposable
    {
        Task<ZapGen.IIssue25A> Cap(CancellationToken cancellationToken_ = default);
    }

    public class CapHolderA_Proxy : Proxy, ICapHolderA
    {
        public Task<ZapGen.IIssue25A> Cap(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.CapHolderA.Params_cap.WRITER>();
            var arg_ = new ZapGen.CapHolderA.Params_cap()
            { };
            arg_.serialize(in_);
            return Impatient.MakePipelineAware(Call(13983895253304304956UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                var r_ = ZapSerializable.Create<ZapGen.CapHolderA.Result_cap>(d_);
                return (r_.Cap);
            }

            );
        }
    }

    public class CapHolderA_Skeleton : Skeleton<ICapHolderA>
    {
        public CapHolderA_Skeleton()
        {
            SetMethodTable(Cap);
        }

        public override ulong InterfaceId => 13983895253304304956UL;
        Task<AnswerOrCounterquestion> Cap(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.Cap(cancellationToken_), cap =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.CapHolderA.Result_cap.WRITER>();
                var r_ = new ZapGen.CapHolderA.Result_cap { Cap = cap };
                r_.serialize(s_);
                return s_;
            }

            );
        }
    }

    public static class CapHolderA
    {
        [TypeId(0xfa15f780f3b1df22UL)]
        public class Params_cap : IZapSerializable
        {
            public const UInt64 typeId = 0xfa15f780f3b1df22UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0xc2166ff01687f001UL)]
        public class Result_cap : IZapSerializable
        {
            public const UInt64 typeId = 0xc2166ff01687f001UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                Cap = reader.Cap;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.Cap = Cap;
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ZapGen.IIssue25A Cap
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
                public ZapGen.IIssue25A Cap => ctx.ReadCap<ZapGen.IIssue25A>(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ZapGen.IIssue25A Cap
                {
                    get => ReadCap<ZapGen.IIssue25A>(0);
                    set => LinkObject(0, value);
                }
            }
        }
    }

    [TypeId(0xf567e74a1a5cbd2dUL), Proxy(typeof(Issue25B_Proxy)), Skeleton(typeof(Issue25B_Skeleton))]
    public interface IIssue25B : IDisposable
    {
        Task<ZapGen.ICapHolder<object>> GetAinCapHolderAnyPointer(CancellationToken cancellationToken_ = default);
        Task<ZapGen.ICapHolder<ZapGen.IIssue25A>> GetAinCapHolderGenericA(CancellationToken cancellationToken_ = default);
        Task<ZapGen.ICapHolderA> GetAinCapHolderNonGenericA(CancellationToken cancellationToken_ = default);
    }

    public class Issue25B_Proxy : Proxy, IIssue25B
    {
        public Task<ZapGen.ICapHolder<object>> GetAinCapHolderAnyPointer(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Params_getAinCapHolderAnyPointer.WRITER>();
            var arg_ = new ZapGen.Issue25B.Params_getAinCapHolderAnyPointer()
            { };
            arg_.serialize(in_);
            return Impatient.MakePipelineAware(Call(17683356767349423405UL, 0, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                var r_ = ZapSerializable.Create<ZapGen.Issue25B.Result_getAinCapHolderAnyPointer>(d_);
                return (r_.AInCapHolder);
            }

            );
        }

        public Task<ZapGen.ICapHolder<ZapGen.IIssue25A>> GetAinCapHolderGenericA(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Params_getAinCapHolderGenericA.WRITER>();
            var arg_ = new ZapGen.Issue25B.Params_getAinCapHolderGenericA()
            { };
            arg_.serialize(in_);
            return Impatient.MakePipelineAware(Call(17683356767349423405UL, 1, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                var r_ = ZapSerializable.Create<ZapGen.Issue25B.Result_getAinCapHolderGenericA>(d_);
                return (r_.AInCapHolder);
            }

            );
        }

        public Task<ZapGen.ICapHolderA> GetAinCapHolderNonGenericA(CancellationToken cancellationToken_ = default)
        {
            var in_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Params_getAinCapHolderNonGenericA.WRITER>();
            var arg_ = new ZapGen.Issue25B.Params_getAinCapHolderNonGenericA()
            { };
            arg_.serialize(in_);
            return Impatient.MakePipelineAware(Call(17683356767349423405UL, 2, in_.Rewrap<DynamicSerializerState>(), false, cancellationToken_), d_ =>
            {
                var r_ = ZapSerializable.Create<ZapGen.Issue25B.Result_getAinCapHolderNonGenericA>(d_);
                return (r_.AInCapHolder);
            }

            );
        }
    }

    public class Issue25B_Skeleton : Skeleton<IIssue25B>
    {
        public Issue25B_Skeleton()
        {
            SetMethodTable(GetAinCapHolderAnyPointer, GetAinCapHolderGenericA, GetAinCapHolderNonGenericA);
        }

        public override ulong InterfaceId => 17683356767349423405UL;
        Task<AnswerOrCounterquestion> GetAinCapHolderAnyPointer(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.GetAinCapHolderAnyPointer(cancellationToken_), aInCapHolder =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Result_getAinCapHolderAnyPointer.WRITER>();
                var r_ = new ZapGen.Issue25B.Result_getAinCapHolderAnyPointer { AInCapHolder = aInCapHolder };
                r_.serialize(s_);
                return s_;
            }

            );
        }

        Task<AnswerOrCounterquestion> GetAinCapHolderGenericA(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.GetAinCapHolderGenericA(cancellationToken_), aInCapHolder =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Result_getAinCapHolderGenericA.WRITER>();
                var r_ = new ZapGen.Issue25B.Result_getAinCapHolderGenericA { AInCapHolder = aInCapHolder };
                r_.serialize(s_);
                return s_;
            }

            );
        }

        Task<AnswerOrCounterquestion> GetAinCapHolderNonGenericA(DeserializerState d_, CancellationToken cancellationToken_)
        {
            return Impatient.MaybeTailCall(Impl.GetAinCapHolderNonGenericA(cancellationToken_), aInCapHolder =>
            {
                var s_ = SerializerState.CreateForRpc<ZapGen.Issue25B.Result_getAinCapHolderNonGenericA.WRITER>();
                var r_ = new ZapGen.Issue25B.Result_getAinCapHolderNonGenericA { AInCapHolder = aInCapHolder };
                r_.serialize(s_);
                return s_;
            }

            );
        }
    }

    public static class Issue25B
    {
        [TypeId(0xe8d098fdc4452255UL)]
        public class Params_getAinCapHolderAnyPointer : IZapSerializable
        {
            public const UInt64 typeId = 0xe8d098fdc4452255UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0xf3e141366136b72aUL)]
        public class Result_getAinCapHolderAnyPointer : IZapSerializable
        {
            public const UInt64 typeId = 0xf3e141366136b72aUL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                AInCapHolder = reader.AInCapHolder;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.AInCapHolder = AInCapHolder;
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ZapGen.ICapHolder<object> AInCapHolder
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
                public ZapGen.ICapHolder<object> AInCapHolder => ctx.ReadCap<ZapGen.ICapHolder<object>>(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ZapGen.ICapHolder<object> AInCapHolder
                {
                    get => ReadCap<ZapGen.ICapHolder<object>>(0);
                    set => LinkObject(0, value);
                }
            }
        }

        [TypeId(0x97b7893bbafbac9cUL)]
        public class Params_getAinCapHolderGenericA : IZapSerializable
        {
            public const UInt64 typeId = 0x97b7893bbafbac9cUL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0xca0d4d05609cf941UL)]
        public class Result_getAinCapHolderGenericA : IZapSerializable
        {
            public const UInt64 typeId = 0xca0d4d05609cf941UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                AInCapHolder = reader.AInCapHolder;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.AInCapHolder = AInCapHolder;
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ZapGen.ICapHolder<ZapGen.IIssue25A> AInCapHolder
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
                public ZapGen.ICapHolder<ZapGen.IIssue25A> AInCapHolder => ctx.ReadCap<ZapGen.ICapHolder<ZapGen.IIssue25A>>(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ZapGen.ICapHolder<ZapGen.IIssue25A> AInCapHolder
                {
                    get => ReadCap<ZapGen.ICapHolder<ZapGen.IIssue25A>>(0);
                    set => LinkObject(0, value);
                }
            }
        }

        [TypeId(0xda5cc8f4689eb99fUL)]
        public class Params_getAinCapHolderNonGenericA : IZapSerializable
        {
            public const UInt64 typeId = 0xda5cc8f4689eb99fUL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
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
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 0);
                }
            }
        }

        [TypeId(0x81a8e7a60710b811UL)]
        public class Result_getAinCapHolderNonGenericA : IZapSerializable
        {
            public const UInt64 typeId = 0x81a8e7a60710b811UL;
            void IZapSerializable.Deserialize(DeserializerState arg_)
            {
                var reader = READER.create(arg_);
                AInCapHolder = reader.AInCapHolder;
                applyDefaults();
            }

            public void serialize(WRITER writer)
            {
                writer.AInCapHolder = AInCapHolder;
            }

            void IZapSerializable.Serialize(SerializerState arg_)
            {
                serialize(arg_.Rewrap<WRITER>());
            }

            public void applyDefaults()
            {
            }

            public ZapGen.ICapHolderA AInCapHolder
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
                public ZapGen.ICapHolderA AInCapHolder => ctx.ReadCap<ZapGen.ICapHolderA>(0);
            }

            public class WRITER : SerializerState
            {
                public WRITER()
                {
                    this.SetStruct(0, 1);
                }

                public ZapGen.ICapHolderA AInCapHolder
                {
                    get => ReadCap<ZapGen.ICapHolderA>(0);
                    set => LinkObject(0, value);
                }
            }
        }
    }
}