using System;

namespace PolySharp.SourceGenerators.Models;

/// <summary>
/// An enum indicating a type of syntax fixup to apply to a generated source.
/// </summary>
[Flags]
internal enum SyntaxFixupType
{
    /// <summary>
    /// No syntax fixup is needed
    /// </summary>
    None = 0,

    /// <summary>
    /// Remove all <c>[MethodImpl]</c> attributes.
    /// </summary>
    RemoveMethodImplAttributes = 1 << 0,

    /// <summary>
    /// Generates the <c>[UnmanagedCallersOnly]</c> type in a different namespace and adds a <c>global using</c> type alias for it with the same name.
    /// </summary>
    /// <remarks>This is needed when methods annotated with the attribute have to be assigned to delegates, which Roslyn will otherwise block.</remarks>
    AliasUnmanagedCallersOnlyAttributeType = 1 << 1
}
