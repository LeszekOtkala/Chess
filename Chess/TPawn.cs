using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chess { 

public class TPawn : TPiece

{

    public TPawn(TPlayer player) : base(player)
    {
        ImageId = 6;
        Value = 1;
    }
        public override List<TCell> GetFreeCells()
        {

            
            var cells = new List<TCell>();
            var dir = Player == Player.Board.WhitePlayer ? -1 : 1;
            var cell = Cell.GetNeighbour(1, dir);
                      
            if (cell!=null&&cell.Piece != null)
                cells.Add(cell);
            cell = Cell.GetNeighbour(-1, dir);
            if (cell!=null&&cell.Piece != null)
                cells.Add(cell);
            cell = Cell.GetNeighbour(0, dir);
            if (cell.Piece == null)
            {
                cells.Add(cell);
                if (MoveCount == 0)
                {
                    cell = cell.GetNeighbour(0, dir);
                    if (cell.Piece == null)
                        cells.Add(cell);
                }

            }
            if (MoveCount > 0)
            {
                var lastMove = Player.Board.Moves.Last();
                if (dir == -1 && Cell.Y == 3 && lastMove.Piece is TPawn && lastMove.Piece.MoveCount == 1)
                {
                    if (lastMove.StopCell == Cell.GetNeighbour(-1, 0))
                        cells.Add(Cell.GetNeighbour(-1, -1));
                    if (lastMove.StopCell == Cell.GetNeighbour(1, 0))
                        cells.Add(Cell.GetNeighbour(1, -1));
                }
                if (dir == 1 && Cell.Y == 4 && lastMove.Piece is TPawn && lastMove.Piece.MoveCount == 1)
                {
                    if (lastMove.StopCell == Cell.GetNeighbour(-1, 0))
                        cells.Add(Cell.GetNeighbour(-1, 1));
                    if (lastMove.StopCell == Cell.GetNeighbour(1, 0))
                        cells.Add(Cell.GetNeighbour(1, 1));
                }
            }


            return cells;
    }
}
}
