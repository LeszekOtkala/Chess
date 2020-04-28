using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class TKing : TPiece
    {
        public TKing(TPlayer player): base (player)
        {
            ImageId = 2;
            Value = 1000;

        }

        public override List<TCell> GetFreeCells()
        {
            var cells = new List<TCell>();
            cells.Add(Cell.GetNeighbour(-1, 0));
            cells.Add(Cell.GetNeighbour(-1,-1));
            cells.Add(Cell.GetNeighbour(0,-1));
            cells.Add(Cell.GetNeighbour(1, -1));
            cells.Add(Cell.GetNeighbour(1, 0));
            cells.Add(Cell.GetNeighbour(1, 1));
            cells.Add(Cell.GetNeighbour(0, 1));
            cells.Add(Cell.GetNeighbour(-1, 1));
            if (MoveCount == 0)
            {
                var rook = Cell.GetNeighbour(-4, 0).Piece;
                if (rook != null && rook.MoveCount == 0)
                {
                    for(int i = 0; i < 4; i++)
                    {
                        var cell = Cell.GetNeighbour(-i, 0);
                    }
                }
            }
            return cells;
        }
    }
}
