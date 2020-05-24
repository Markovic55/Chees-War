using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[7, 7];

        ChessPiece c;

        //RedTeam
        if (isRed)
        {

            //Diagonal left
            if (CurrentX != 0 && CurrentY != 6)
            {
                Debug.Log(CurrentX + " " + CurrentY);
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY + 1] = true;
                if(c == null)
                    r[CurrentX - 1, CurrentY + 1] = true;
            }
            //Diagonal right
            if (CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 1] = true;
                else if (c == null)
                    r[CurrentX + 1, CurrentY + 1] = true;
            }

            //Middle
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX, CurrentY + 1] = true;
                else if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }
        }
        else
        {
            //BlueTeam

            //Diagonal left
            if (CurrentX != 0 && CurrentY != 0)
            {
                
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX - 1, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX - 1, CurrentY - 1] = true;
            }
            //Diagonal right
            if (CurrentX != 6 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX + 1, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //Middle
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX, CurrentY - 1] = true;
            }
        }


        return r;
    }
}
