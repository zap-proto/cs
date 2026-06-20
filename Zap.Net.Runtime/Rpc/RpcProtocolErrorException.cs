namespace Zap.Rpc
{
    class RpcProtocolErrorException : System.Exception
    {
        public RpcProtocolErrorException(string reason): base(reason)
        {
        }
    }
}