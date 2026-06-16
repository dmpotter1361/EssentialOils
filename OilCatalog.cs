using System.Text.Json;
using System.Text.Json.Serialization;

namespace EssentialOils;

/// <summary>The three essential-oil note tiers, in evaporation order.</summary>
public enum NoteTier { Top, Middle, Base }

/// <summary>An essential oil and everything we know about it (single source of truth, loaded from oils.json).</summary>
public sealed record Oil(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("families")] IReadOnlyList<string> Families,
    [property: JsonPropertyName("effects")] IReadOnlyList<string> Effects,
    [property: JsonPropertyName("description")] string Description);

/// <summary>A carrier (base) oil. Carriers have a description but no fragrance family or effect.</summary>
public sealed record Carrier(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("description")] string Description);

/// <summary>The display order of each list box, as curated in the original UI.</summary>
public sealed record Columns(
    [property: JsonPropertyName("top")] IReadOnlyList<string> Top,
    [property: JsonPropertyName("middle")] IReadOnlyList<string> Middle,
    [property: JsonPropertyName("base")] IReadOnlyList<string> Base,
    [property: JsonPropertyName("carrier")] IReadOnlyList<string> Carrier);

public sealed record OilCatalog(
    [property: JsonPropertyName("columns")] Columns Columns,
    [property: JsonPropertyName("oils")] IReadOnlyList<Oil> Oils,
    [property: JsonPropertyName("carriers")] IReadOnlyList<Carrier> Carriers)
{
    // The fragrance families and effects the UI shows, in the order the original app listed them.
    public static readonly IReadOnlyList<string> Families = ["Citrus", "Floral", "Herbal", "Spicy", "Woody"];
    public static readonly IReadOnlyList<string> Effects = ["Energizing", "Relaxing", "Cleansing", "Grounding"];

    public IReadOnlyList<string> TierNames(NoteTier tier) => tier switch
    {
        NoteTier.Top => Columns.Top,
        NoteTier.Middle => Columns.Middle,
        NoteTier.Base => Columns.Base,
        _ => throw new ArgumentOutOfRangeException(nameof(tier)),
    };

    public Oil? FindOil(string name) => Oils.FirstOrDefault(o => o.Name == name);
    public Carrier? FindCarrier(string name) => Carriers.FirstOrDefault(c => c.Name == name);

    private static readonly JsonSerializerOptions Options = new() { PropertyNameCaseInsensitive = true };

    /// <summary>Loads oils.json from the application directory.</summary>
    public static OilCatalog Load()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "oils.json");
        using FileStream stream = File.OpenRead(path);
        return JsonSerializer.Deserialize<OilCatalog>(stream, Options)
               ?? throw new InvalidDataException($"Could not parse {path}.");
    }
}
