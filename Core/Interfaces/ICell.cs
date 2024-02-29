namespace Core
{
    /// <summary>
    /// Represents a <c>Cell</c> in <b>Conway's Game Of Life</b>.
    /// </summary>
    /// <remarks>
    /// It holds the <c>state</c> of a <c>Cell</c>.
    /// </remarks>
    public interface ICell
    {
        /// <summary>
        /// Gets or sets the current <c>state</c> of the <c>Cell</c>.
        /// </summary>
        /// <remarks>
        /// It represents the state of the cell, whether it is alive or dead.
        /// </remarks>
        bool IsAlive { get; set; }
    }
}
