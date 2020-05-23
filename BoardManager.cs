using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance { get; set; }
    private bool[,] allowedMoves { get; set; }

    public  ChessPiece[,] chessPieces { get; set; }
    private ChessPiece selectedChessPiece;

    public List<GameObject> chessPiecePrefab;
    private List<GameObject> activeChessPiece;

    
    public const float TILE_SIZE = 1.0f;

    public const float TILE_OFFSET = 0.5f;

    public bool buttonPressed = false;

    public bool isRedTurn = true;

    private int selectionX = -1;

    private int selectionY = -1;

    public int Times = 0;

    private void Start()
    {
        Instance = this;
        SpawnAllChessPieces();
        
    }
    private void Update()
    {
        DrawBoard();
        UpdateSelection();
       
        if (Input.GetMouseButtonDown(0))
        {
            
            if (selectionX >= 0 && selectionY >= 0)
            {
                if(selectedChessPiece == null)
                {
                   
                    SelectChessPiece(selectionX, selectionY);
                }
                else
                {
                    
                    MoveChessPiece(selectionX, selectionY);
                }
            }
        }

    }

    private void MoveChessPiece(int x, int y)
    {

        if (allowedMoves[x, y])
        {
            if (Times == 0)
            {
                chessPieces[selectedChessPiece.CurrentX, selectedChessPiece.CurrentY] = null;
                selectedChessPiece.transform.position = GetTileCenter(x, y);
                selectedChessPiece.SetPosition(x, y);
                chessPieces[x, y] = selectedChessPiece;
                Times++;
            }
            if (buttonPressed)
            {
                EndTurn();
            }

            isRedTurn = !isRedTurn;


        }
        BoardHighlights.Instance.HideHiglight();
        selectedChessPiece = null;
    }

    private void EndTurn()
    {
        Times = 0;
    }

    private void SelectChessPiece(int x, int y)
    {
        if (chessPieces[x, y] == null)
            return;

        if (chessPieces[x, y].isRed != isRedTurn)
            return;
        
        if (Times == 0)
        {
            Debug.Log(x + " " + y);
            
            allowedMoves = chessPieces[x, y].PossibleMove();
            selectedChessPiece = chessPieces[x, y];
            BoardHighlights.Instance.HiglightAllowedMoves(allowedMoves);
           
        }
        
    }

    private void UpdateSelection()
    {
        if (!Camera.main)
            return;
       

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero,25.0f,LayerMask.GetMask("ChessObject"));
        if (hit.collider != null)
        {
            
            selectionX = (int)hit.point.x;
            selectionY = (int)hit.point.y;
           

        }
        else
        {
            selectionX = -1;
            selectionY = -1;
        }
    }

    private void SpawnChessPiece(int index,int x, int y)
    {
        GameObject go = Instantiate(chessPiecePrefab[index], GetTileCenter(x, y), Quaternion.identity) as GameObject;
        go.transform.SetParent(transform);
        chessPieces[x, y] = go.GetComponent<ChessPiece>();
        chessPieces[x, y].SetPosition(x, y);
        activeChessPiece.Add(go);
    }

    private void SpawnAllChessPieces()
    {
        activeChessPiece = new List<GameObject>();
        chessPieces = new ChessPiece[7, 7];
        //Blue Team

        //King Spawn
        SpawnChessPiece(0, 3, 6);

        //Archer Spawn
        SpawnChessPiece(1, 2, 6);
        SpawnChessPiece(1, 4, 6);

        //Pawn Spawn
        SpawnChessPiece(2, 0, 6);
        SpawnChessPiece(2, 6, 6);
        SpawnChessPiece(2, 1, 6);
        SpawnChessPiece(2, 5, 6);

        //Red Team

        //King Spawn
        SpawnChessPiece(3, 3, 0);

        //Archer Spawn
        SpawnChessPiece(4, 2, 0);
        SpawnChessPiece(4, 4, 0);

        //Pawn Spawn
        SpawnChessPiece(5, 0, 0);
        SpawnChessPiece(5, 6, 0);
        SpawnChessPiece(5, 1, 0);
        SpawnChessPiece(5, 5, 0);

    }

    private Vector2 GetTileCenter(int x, int y)
    {
        Vector2 origin = Vector2.zero;
        origin.x += (x * TILE_SIZE) + TILE_OFFSET;
        origin.y += (y * TILE_SIZE) + TILE_OFFSET;
        return origin;
    }

    private void DrawBoard()
    {
        Vector2 widthLine = Vector2.right * 7;
        Vector2 heightLine = Vector2.up * 7;

        for(int i = 0; i <= 7; i++)
        {
            Vector2 start = Vector2.up * i;
            Debug.DrawLine(start, start + widthLine);
            for (int j = 0; j <= 7; j++)
            {
                start = Vector2.right * j;
                Debug.DrawLine(start, start + heightLine);

            }
        }
        
        if(selectionX >= 0 && selectionY >= 0)
        {
            Debug.DrawLine(Vector2.up * selectionY + Vector2.right * selectionX, Vector2.up * (selectionY + 1) + Vector2.right * (selectionX + 1));
            Debug.DrawLine(Vector2.up * selectionY + Vector2.right * (selectionX + 1), Vector2.up * (selectionY + 1) + Vector2.right * selectionX);
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

}
