namespace Core
{
    /// <summary>
    /// Represents a <c>Rule</c> which determines the fate of a <c>Cell</c> in the next <c>Generation</c>.
    /// </summary>
    public interface IRule
    {
        /// <summary>
        /// Applies the rule to determine the state of the specified <paramref name="cell"/> in the next generation
        /// based on the number of alive neighbors <paramref name="nAliveNeighbors"/>.
        /// </summary>
        /// <param name="cell">The <c>Cell</c> for which the rule is being applied.</param>
        /// <param name="nAliveNeighbors">The number of alive neighbors of the <paramref name="cell"/>.</param>
        /// <returns>True if the cell should be alive in the next generation; otherwise, false.</returns>
        bool Apply(ICell cell, int nAliveNeighbors);
    }
}
