using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public int WIDTH;
    public int HEIGHT;

    GameObject[,] grid;

    private void Start()
    {
        grid = new GameObject[WIDTH,HEIGHT];
        for (int x = 0; x < WIDTH; x++)
        {
            for (int y = 0; y < HEIGHT; y++)
            {

                Collider2D collider = Physics2D.OverlapBox(new Vector2(x, y), new Vector2(0.5f, 0.5f), 0);
                if (collider != null && !collider.CompareTag("Player"))
                {
                    grid[x, y] = collider.gameObject;
                    Debug.Log(x);
                    Debug.Log(y);
                }
            }
        }
    }

    public GameObject GetContents(int x, int y)
    {
        return grid[x, y];
    }
}
