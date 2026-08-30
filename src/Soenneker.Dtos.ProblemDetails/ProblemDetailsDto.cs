using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.ProblemDetails;

/// <summary>
/// Describes a machine-readable API error without requiring a dependency on ASP.NET Core MVC's problem-details type.
/// </summary>
[PublicOpenApiObject]
public record ProblemDetailsDto
{
    /// <summary>
    /// URI reference that identifies the problem category and may resolve to human-readable documentation. When omitted, clients may treat it as <c>about:blank</c>.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
    public string? Type { get; set; }

    /// <summary>
    /// Short, human-readable summary of the problem category. It should remain consistent across occurrences except when localized.
    /// </summary>
    [JsonPropertyName("title")]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title")]
    public string? Title { get; set; }

    /// <summary>
    /// HTTP status code generated for this occurrence of the problem.
    /// </summary>
    [JsonPropertyName("status")]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// A human-readable explanation specific to this occurrence of the problem.
    /// </summary>
    [JsonPropertyName("detail")]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detail")]
    public string? Detail { get; set; }

    /// <summary>
    /// URI reference that identifies this specific occurrence of the problem and may resolve to additional information.
    /// </summary>
    [JsonPropertyName("instance")]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// Additional problem-specific members serialized alongside the standard fields rather than under an <c>extensions</c> property.
    /// <para>
    /// Problem type definitions MAY extend the problem details object with additional members. Extension members appear in the same namespace as
    /// other members of a problem type.
    /// </para>
    /// </summary>
    /// <remarks>
    /// The runtime types produced while deserializing extension values depend on the selected serializer.
    /// </remarks>
    [System.Text.Json.Serialization.JsonExtensionData]
    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> Extensions { get; } = new Dictionary<string, object>(StringComparer.Ordinal);
}
