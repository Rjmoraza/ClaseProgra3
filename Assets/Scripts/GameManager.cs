using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int[,] grid;
    private GridButton[,] buttons;

    public GameObject tilePrefab;
    public GameObject cursor;


    // Start is called before the first frame update
    void Start()
    {
        CreateBoard();
    }

    private void CreateBoard()
    {
        int rows = 10;
        int cols = 10;

        grid = new int[rows, cols];
        buttons = new GridButton[rows, cols];

        for(int r = 0; r < rows; ++r)
        {
            for(int c = 0; c < cols; ++c)
            {
                int row = r;
                int col = c;
                GameObject go = Instantiate(tilePrefab, transform);
                go.GetComponent<GridButton>().SetUp( 
                    () => {
                        cursor.transform.SetParent(buttons[row, col].transform);
                        cursor.transform.localPosition = Vector3.zero;
                    });
                buttons[r, c] = go.GetComponent<GridButton>();
                grid[r, c] = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetGridValue(int col, int row)
    {
        return grid[row, col];
    }
}
