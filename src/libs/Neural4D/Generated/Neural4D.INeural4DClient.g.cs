
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// API for Neural4D text-to-3D, image-to-3D, background matting, model conversion,<br/>
    /// point balance, and job progress operations.<br/>
    /// This OpenAPI document is manually maintained from Neural4D's public API PDF<br/>
    /// because Neural4D does not publish a downloadable OpenAPI document.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface INeural4DClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Neural4D.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Neural4D.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationClient Generation { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

    }
}