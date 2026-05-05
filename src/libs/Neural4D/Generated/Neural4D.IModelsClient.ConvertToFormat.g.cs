#nullable enable

namespace Neural4D
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Convert a generated model to another format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neural4D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.ConvertToFormatResponse> ConvertToFormatAsync(

            global::Neural4D.ConvertToFormatRequest request,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a generated model to another format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neural4D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.AutoSDKHttpResponse<global::Neural4D.ConvertToFormatResponse>> ConvertToFormatAsResponseAsync(

            global::Neural4D.ConvertToFormatRequest request,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a generated model to another format
        /// </summary>
        /// <param name="uuid">
        /// Generated model UUID.
        /// </param>
        /// <param name="modelType">
        /// Target model format.<br/>
        /// Default Value: glb
        /// </param>
        /// <param name="modelSize">
        /// Target model size preset.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.ConvertToFormatResponse> ConvertToFormatAsync(
            string uuid,
            global::Neural4D.ConvertToFormatRequestModelType? modelType = default,
            int? modelSize = default,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}