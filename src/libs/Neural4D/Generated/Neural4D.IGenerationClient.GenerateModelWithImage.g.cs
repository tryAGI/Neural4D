#nullable enable

namespace Neural4D
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Generate 3D models from a matted image file key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Neural4D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.GenerationResponse> GenerateModelWithImageAsync(

            global::Neural4D.GenerateModelWithImageRequest request,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate 3D models from a matted image file key
        /// </summary>
        /// <param name="fileKey">
        /// File key returned by the matting result endpoint.
        /// </param>
        /// <param name="modelCount">
        /// Number of model candidates to generate.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="disablePbr">
        /// Set to 1 to disable PBR material generation.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Neural4D.GenerationResponse> GenerateModelWithImageAsync(
            string fileKey,
            int? modelCount = default,
            int? disablePbr = default,
            global::Neural4D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}