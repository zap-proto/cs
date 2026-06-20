namespace Zap.Rpc
{
    /// <summary>
    /// A uni-directional endpoint, used in conjunction with the <see cref="RpcEngine"/>.
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        /// Transmit the given ZAP message over this endpoint.
        /// </summary>
        void Forward(WireFrame frame);

        /// <summary>
        /// Indicates that the endpoint should flush any buffered frames.
        /// </summary>
        void Flush();

        /// <summary>
        /// Close this endpoint.
        /// </summary>
        void Dismiss();
    }
}