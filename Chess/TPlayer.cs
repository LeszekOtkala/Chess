using System.Collections.Generic;

namespace Chess
{
    
    public class TPlayer
    {
        public List<TPiece> Pieces = new List<TPiece>();
        public TBoard Board;
        public TPlayer Enemy {
            get
            {
                if (this == Board.WhitePlayer)
                    return Board.BlackPlayer;
                else
                    return Board.WhitePlayer;
            }
        }
       public TPiece PieceAtCell(TCell cell)
        {
            foreach (var piece in Pieces)
            {
                if (piece.Cell == cell)
                    return piece;
                
            }
            return null;
        }
    }
}