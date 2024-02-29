using Core.Interfaces;

namespace Services.Elementary
{
    public class Cell(bool isAlive) : ICell
    {
		private bool _isAlive = isAlive;

        public bool IsAlive
		{
			get { return _isAlive; }
			set { _isAlive = value; }
		}
	}
}
