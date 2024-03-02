using Core.Interfaces;

namespace Core.Elementary
{
    public class Universe : IUniverse
    {

        private IRule _followsRule;
        private int _width;
        private Cell[] _grid;

        // Initialise dead universe.
        public Universe(IRule followsRule, int width)
        {
            _followsRule = followsRule;
            _width = width;
            _grid = new Cell[width];
            for (int i = 0; i < width; i++)
            {
                _grid[i] = new Cell(false);
            }
        }

        public Universe(IRule followsRule, int width, Cell[] grid)
        {
            _followsRule = followsRule;
            _width = width;
            _grid = grid;
        }

        public Cell[] Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        public void NextGeneration()
        {
            Cell[] nextGrid = new Cell[_width];
            int l, r;

            // Calculate next state.
            for (int c = 0; c < _width; c++)
            {
                l = c - 1;
                r = c + 1;

                if (l < 0) l = _width - 1;
                if (r > _width - 1) r = 0;

                Cell[] neighbors = [_grid[l], _grid[r]];
                bool isAlive = _followsRule.Apply(_grid[c], neighbors);
                nextGrid[c] = new Cell(isAlive);
            }

            // push to current
            for (int i = 0; i < _width; i++)
            {
                _grid[i] = nextGrid[i];
            }
        }
    }
}
