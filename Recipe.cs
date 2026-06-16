using System.Text;

namespace EssentialOils;

/// <summary>The computed recipe text plus which fragrance families / effects should be highlighted.</summary>
public sealed record RecipeResult(string Text, IReadOnlySet<string> Families, IReadOnlySet<string> Effects);

/// <summary>
/// Pure dilution maths and scent-profile aggregation — no UI. Mirrors the original calculator:
/// 3% essential-oil dilution and a 30/50/20 top/middle/base split that redistributes a tier's
/// share evenly across the others when that tier is empty.
/// </summary>
public static class Recipe
{
    public const double EssentialRate = 0.03;
    public const double TopRule = 0.30;
    public const double MidRule = 0.50;
    public const double BaseRule = 0.20;

    private static readonly string NL = Environment.NewLine;

    // The original UI listed families/effects in these (slightly different) orders within the summary.
    private static readonly string[] BriefFamilyOrder = ["Citrus", "Floral", "Spicy", "Herbal", "Woody"];
    private static readonly string[] BriefEffectOrder = ["Cleansing", "Energizing", "Relaxing", "Grounding"];

    public static RecipeResult Build(
        int bottleMl,
        IReadOnlyList<string> carriers,
        IReadOnlyList<Oil> top,
        IReadOnlyList<Oil> middle,
        IReadOnlyList<Oil> baseOils)
    {
        var sb = new StringBuilder();

        if (carriers.Count > 0)
        {
            double perCarrier = Math.Round(bottleMl * (1 - EssentialRate) / carriers.Count, 0);
            sb.Append("Carrier Oils:");
            foreach (string name in carriers)
                sb.Append($"{NL}• {name} - {perCarrier}ml");
        }

        var (topRule, midRule, basRule) = DistributeRules(top.Count, middle.Count, baseOils.Count);
        AppendScents(sb, "Top Scents:", top, bottleMl, topRule);
        AppendScents(sb, "Middle Scents:", middle, bottleMl, midRule);
        AppendScents(sb, "Base Scents:", baseOils, bottleMl, basRule);

        sb.Append($"{NL}{NL}Top Notes: {FamilyBrief(top)}");
        sb.Append($"{NL}Middle Notes: {FamilyBrief(middle)}");
        sb.Append($"{NL}Base Notes: {FamilyBrief(baseOils)}");
        sb.Append($"{NL}{NL}Top Effect: {EffectBrief(top)}");
        sb.Append($"{NL}Middle Effects: {EffectBrief(middle)}");
        sb.Append($"{NL}Base Effects: {EffectBrief(baseOils)}");

        return new RecipeResult(sb.ToString(), HighlightFamilies(top, middle, baseOils), HighlightEffects(top, middle, baseOils));
    }

    /// <summary>Families to highlight: any selected oil in any tier belonging to the family.</summary>
    public static IReadOnlySet<string> HighlightFamilies(params IEnumerable<Oil>[] tiers) =>
        OrderedMatches(OilCatalog.Families, tiers.SelectMany(t => t), o => o.Families).ToHashSet();

    public static IReadOnlySet<string> HighlightEffects(params IEnumerable<Oil>[] tiers) =>
        OrderedMatches(OilCatalog.Effects, tiers.SelectMany(t => t), o => o.Effects).ToHashSet();

    private static void AppendScents(StringBuilder sb, string header, IReadOnlyList<Oil> oils, int bottleMl, double rule)
    {
        if (oils.Count == 0) return;
        double per = Math.Round(bottleMl * EssentialRate * rule / oils.Count, 1);
        sb.Append($"{NL}{NL}{header}");
        foreach (Oil o in oils)
            sb.Append($"{NL}• {o.Name} - {per}ml");
    }

    private static (double top, double mid, double bas) DistributeRules(int top, int mid, int bas)
    {
        double t = TopRule, m = MidRule, b = BaseRule;
        bool ht = top > 0, hm = mid > 0, hb = bas > 0;

        if (!ht && hm && hb) { double x = t / 2; m += x; b += x; t = 0; }
        else if (ht && !hm && hb) { double x = m / 2; m = 0; t += x; b += x; }
        else if (ht && hm && !hb) { double x = b / 2; b = 0; t += x; m += x; }
        else if (ht && !hm && !hb) { t += m + b; m = 0; b = 0; }
        else if (!ht && hm && !hb) { m += t + b; t = 0; b = 0; }
        else if (!ht && !hm && hb) { b += t + m; t = 0; m = 0; }

        return (t, m, b);
    }

    private static string FamilyBrief(IEnumerable<Oil> oils) =>
        string.Join(",", OrderedMatches(BriefFamilyOrder, oils, o => o.Families));

    private static string EffectBrief(IEnumerable<Oil> oils) =>
        string.Join(",", OrderedMatches(BriefEffectOrder, oils, o => o.Effects));

    /// <summary>Keys (in the given order) for which at least one oil carries that key.</summary>
    private static IEnumerable<string> OrderedMatches(
        IEnumerable<string> order, IEnumerable<Oil> oils, Func<Oil, IReadOnlyList<string>> selector)
    {
        var present = oils.SelectMany(selector).ToHashSet();
        return order.Where(present.Contains);
    }
}
