using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
  public  class TMove
    {
        public TPiece Piece;
        public TCell StartCell;
        public TCell StopCell;
        public TPiece Capture;

        public void Make()
        {
            Piece.Cell = StopCell;
            if (Capture != null)
            {
                Piece.Player.Enemy.Pieces.Remove(Capture);
            }
            Piece.MoveCount++;
            Piece.Player.Board.Moves.Add(this);
            Piece.Player.Board.ActivePlayer = Piece.Player.Board.ActivePlayer.Enemy;
        }

        public void UnMake()
        {
            Piece.MoveCount--;
            if (Capture != null)
                Piece.Player.Enemy.Pieces.Add(Capture);
            Piece.Cell = StartCell;
            Piece.Player.Board.Moves.Remove(this);
            Piece.Player.Board.ActivePlayer = Piece.Player.Board.ActivePlayer.Enemy;
        }
    }


}
