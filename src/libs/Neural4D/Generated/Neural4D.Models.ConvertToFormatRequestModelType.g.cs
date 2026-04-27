
#nullable enable

namespace Neural4D
{
    /// <summary>
    /// Target model format.<br/>
    /// Default Value: glb
    /// </summary>
    public enum ConvertToFormatRequestModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Blend,
        /// <summary>
        /// 
        /// </summary>
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Stl,
        /// <summary>
        /// 
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvertToFormatRequestModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvertToFormatRequestModelType value)
        {
            return value switch
            {
                ConvertToFormatRequestModelType.Blend => "blend",
                ConvertToFormatRequestModelType.Fbx => "fbx",
                ConvertToFormatRequestModelType.Glb => "glb",
                ConvertToFormatRequestModelType.Obj => "obj",
                ConvertToFormatRequestModelType.Stl => "stl",
                ConvertToFormatRequestModelType.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvertToFormatRequestModelType? ToEnum(string value)
        {
            return value switch
            {
                "blend" => ConvertToFormatRequestModelType.Blend,
                "fbx" => ConvertToFormatRequestModelType.Fbx,
                "glb" => ConvertToFormatRequestModelType.Glb,
                "obj" => ConvertToFormatRequestModelType.Obj,
                "stl" => ConvertToFormatRequestModelType.Stl,
                "usdz" => ConvertToFormatRequestModelType.Usdz,
                _ => null,
            };
        }
    }
}