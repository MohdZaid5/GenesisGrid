
namespace Core.Interfaces
{
    /// <summary>
    /// Represents a <c>Rule</c> which determines the fate of a <c>Cell</c> in the next <c>Generation</c>.
    /// </summary>
    public interface IRule
    {
        /// <summary>
        /// Applies the rule to determine the state of the specified <paramref name="cell"/> in the next generation
        /// based on the states of its neighboring cells.
        /// </summary>
        /// <param name="cell">The <c>Cell</c> for which the rule is being applied.</param>
        /// <param name="neighbors">Array representing the states of neighboring cells in the following order:
        ///     [0][1][2]
        ///     [3][C][4]
        ///     [5][6][7]
        ///     where C represents the current cell.</param>
        /// <returns>True if the cell should be alive in the next generation; otherwise, false.</returns>
        bool Apply(ICell cell, ICell[] neighbors);
    }
}
