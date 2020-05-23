using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHighlights : MonoBehaviour
{
    public static BoardHighlights Instance { get; set; }

    [SerializeField] GameObject highlightPrefab;
    private List <GameObject> highlights;

    private void Start()
    {
        Instance = this;
        highlights = new List<GameObject>();
    }

    private GameObject GetHiglightObject()
    {
        GameObject go = highlights.Find(g => !g.activeSelf);

        if(go == null)
        {
            go = Instantiate(highlightPrefab);
            highlights.Add(go);
        }

        return go;
    }

    public void HiglightAllowedMoves(bool[,] moves)
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if(moves[i, j])
                {
                    GameObject go = GetHiglightObject();
                    go.SetActive(true);
                    go.transform.position = new Vector2(i+0.5f, j+0.5f);
                }
            }
        }
    }

    public void HideHiglight()
    {
        foreach (GameObject go in highlights)
            go.SetActive(false);
    }
}
