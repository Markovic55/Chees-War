using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    //public override bool PossibleMove(int x, int y)
    //{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[7, 7];

        ChessPiece c;

        //RedTeam
        if (isRed)
        {

            //Diagonal left top
            if (CurrentX != 0 && CurrentY != 6)
            {

                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY + 1];

                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY + 1] = true;
            }
            //Diagonal right top
            if (CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY + 1] = true;
            }

            //Middle top
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }
            //Diagonal left bottom
            if (CurrentX != 0 && CurrentY != 6)
            {

                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY - 1];

                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY - 1] = true;
            }
            //Diagonal right bottom
            if (CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //Middle bottom
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX, CurrentY - 1] = true;
            }
            //LEFT
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY];
                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY] = true;

                if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }
            //RIGHT
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY] = true;
            }
        }
        else
        {
            //BlueTeam

            //Diagonal left top
            if (CurrentX != 0 && CurrentY != 0)
            {

                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX - 1, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX - 1, CurrentY - 1] = true;
            }
            //Diagonal right top
            if (CurrentX != 6 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX + 1, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //Middle top
            if (CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY - 1];
                if (c != null && c.isRed)
                    r[CurrentX, CurrentY - 1] = true;
                else if (c == null)
                    r[CurrentX, CurrentY - 1] = true;
            }
            //Diagonal left bottom
            if (CurrentX != 0 && CurrentY != 6)
            {

                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 1];

                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }
            //Diagonal right bottom
            if (CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY - 1] = true;
            }

            //Middle bottom
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX, CurrentY + 1] = true;
            }
            //LEFT
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY];
                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY] = true;
            }
            //RIGHT
            if (CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY] = true;
            }
        }


        return r;
    }
    //}
}
