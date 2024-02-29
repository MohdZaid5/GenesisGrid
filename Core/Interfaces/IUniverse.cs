namespace Core.Interfaces
{
    /// <summary>
    /// Represents an <c>Universe</c> where the next <c>Generation</c> of cells can be computed.
    /// </summary>
    public interface IUniverse
    {
        /// <summary>
        /// Computes the next <c>Generation</c> of cells in the universe.
        /// </summary>
        void NextGeneration();
    }
}
