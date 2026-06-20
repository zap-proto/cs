using System.Threading;
using System.Threading.Tasks;
using Zap.Rpc;

namespace Zap.Net.Runtime.Tests
{
    class ProvidedCapabilityMock : RefCountingSkeleton
    {
        readonly TaskCompletionSource<(ulong, ushort, DeserializerState, CancellationToken)>
            _call = new TaskCompletionSource<(ulong, ushort, DeserializerState, CancellationToken)>();

        public override Task<AnswerOrCounterquestion> Invoke(ulong interfaceId, ushort methodId, 
            DeserializerState args, CancellationToken cancellationToken = default(CancellationToken))
        {
            _call.SetResult((interfaceId, methodId, args, cancellationToken));
            return Return.Task;
        }

        public Task<(ulong, ushort, DeserializerState, CancellationToken)> WhenCalled =>
            _call.Task;

        public TaskCompletionSource<AnswerOrCounterquestion> Return { get; } = new TaskCompletionSource<AnswerOrCounterquestion>();
    }
}
