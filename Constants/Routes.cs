using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace HeatStone.Constants;


/// <summary>
/// Centralized storage for page routes, with extension method for strings which allow to format blazor route placeholders with values
/// </summary>
/// <example>
/// You can use routes in components by adding one or multiple <see cref="RouteAttribute"/> to partial class with code of page
/// <code>
/// [Route(Routes.Deposit)]
/// [Route(Routes.DepositCoin)]
/// public partial class Deposit
/// </code>
/// 
/// Or by adding attribute to markup file using @attribute directive
/// <code>
/// @attribute [Route(Routes.Deposit)]
/// @attribute [Route(Routes.DepositCoin)]
/// </code>
///
/// Also you can use routes in anchor tags or NavLink components by directly specifying constant in href attribute
/// <c>&lt;a href="@Routes.Market"&gt;Market&lt;/a&gt;</c>
/// or by filling it with arguments
/// <c>&lt;a href="@Routes.MakerInfo.Args(1_000_000_000)"&gt;Maker Info&lt;/a&gt;</c>
/// or by calling it in navigation manager
/// <c>Routes.EditAd.Args(item.Id)</c>
/// </example>

public static class Routes
{
    public const string Landing = "/";

    public const string Catalog = "/catalog";
    public const string About = "/about";
    public const string OurAddresses = "/our-addresses";
    public const string Promo = "/promo";
    
    #region Extension method
    private static readonly Regex PlaceholderPattern = new("{[a-zA-Z0-9:?_]+}", RegexOptions.Singleline | RegexOptions.Compiled);
    
    /// <summary>
    /// Extension method for <see cref="string"/>
    /// </summary>
    /// <example>
    /// <c>&lt;a href="@Routes.MakerInfo.Args(1_000_000_000)"&gt;</c>
    /// </example>
    /// <param name="route"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Throws if count of placeholder doesn't match count of supplied arguments</exception>
    public static string Args(this string route, params object[] args)
    {
        var matches = PlaceholderPattern.Matches(route);
        if (matches.Count != args.Length) throw new ArgumentException($@"Invalid arguments count, expected {matches.Count} arguments", nameof(args));
        for (var index = 0; index < matches.Count; index++)
        {
            route = route.Replace(matches[index].Value, $"{args[index]}");
        }

        return route;
    }
    #endregion
}