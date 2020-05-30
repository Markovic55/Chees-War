using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[7, 7];

        ChessPiece c;

        //RedTeam
        if (isRed)
        {

            //Г горе лево
            if (CurrentX != 0 && CurrentY != 5 && CurrentY != 6)
            {

                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY + 3];

                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY + 3] = true;
            }
            //Г горе десно
            if (CurrentX != 6 && CurrentY != 5 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY + 3] = true;
            }

            //Г доле лево
            if (CurrentX != 0 && CurrentY != 0 && CurrentY != 1)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY - 3];
                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY - 3] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY - 3] = true;
            }

            //Г доле десно
            if (CurrentX != 6 && CurrentY != 0 && CurrentY != 1)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY - 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY - 3] = true;
            }

            //Г горе лево краће
            if (CurrentX != 0 && CurrentX != 1 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 3, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX - 3, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX - 3, CurrentY + 1] = true;
            }
            //Г горе десно краће
            if (CurrentX != 5 && CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY + 3] = true;
            }
            //Г доле лево краће
            if (CurrentX != 0 && CurrentX != 1 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 3, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX - 3, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX - 3, CurrentY - 1] = true;
            }
            //Г доле десно краће
            if (CurrentX != 5 && CurrentX != 6 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 3, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 3, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX + 3, CurrentY - 1] = true;
            }

        }
        else
        {
            //BlueTeam

            //Г горе лево
            if (CurrentX != 0 && CurrentY != 5 && CurrentY != 6)
            {

                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY + 3];

                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY + 3] = true;
            }
            //Г горе десно
            if (CurrentX != 6 && CurrentY != 5 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY + 3] = true;
            }

            //Г доле лево
            if (CurrentX != 0 && CurrentY != 0 && CurrentY != 1)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 1, CurrentY - 3];
                if (c != null && !c.isRed)
                    r[CurrentX - 1, CurrentY - 3] = true;

                if (c == null)
                    r[CurrentX - 1, CurrentY - 3] = true;
            }

            //Г доле десно
            if (CurrentX != 6 && CurrentY != 0 && CurrentY != 1)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY - 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY - 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY - 3] = true;
            }

            //Г горе лево краће
            if (CurrentX != 0 && CurrentX != 1 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 3, CurrentY + 1];
                if (c != null && !c.isRed)
                    r[CurrentX - 3, CurrentY + 1] = true;

                if (c == null)
                    r[CurrentX - 3, CurrentY + 1] = true;
            }
            //Г горе десно краће
            if (CurrentX != 5 && CurrentX != 6 && CurrentY != 6)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 1, CurrentY + 3];
                if (c != null && !c.isRed)
                    r[CurrentX + 1, CurrentY + 3] = true;

                if (c == null)
                    r[CurrentX + 1, CurrentY + 3] = true;
            }
            //Г доле лево краће
            if (CurrentX != 0 && CurrentX != 1 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX - 3, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX - 3, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX - 3, CurrentY - 1] = true;
            }
            //Г доле десно краће
            if (CurrentX != 5 && CurrentX != 6 && CurrentY != 0)
            {
                c = BoardManager.Instance.chessPieces[CurrentX + 3, CurrentY - 1];
                if (c != null && !c.isRed)
                    r[CurrentX + 3, CurrentY - 1] = true;

                if (c == null)
                    r[CurrentX + 3, CurrentY - 1] = true;
            }
        }


        return r;
    }
}
