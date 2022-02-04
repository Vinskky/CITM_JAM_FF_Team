using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public List<GameObject> states = new List<GameObject>();
    
    GameObject currentState = null;
    gridCell cell           = null;
    GameGrid grid           = null;
    
    enum TILE_STATE
    {
        UP,
        LEFT,
        UP_LEFT,
        DOWN,
        V_ACROSS,
        DOWN_LEFT,
        T_LEFT,
        RIGHT,
        UP_RIGHT,
        H_ACROSS,
        T_UP,
        DOWN_RIGHT,
        T_RIGHT,
        T_DOWN,
        CROSS
    }

    // Start is called before the first frame update
    void Start()
    {
        ApplyNewState();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplyNewState()
    {
        currentState.SetActive(false);

        // Check Neighbours and get id
        Vector2 cellPos = cell.GetPosition();
        int id          = 0;
        //if (grid.GetCell(cellPos.x, cellPos.y + 1).IsRoad()) { id += 1; }
        //if (grid.GetCell(cellPos.x - 1, cellPos.y).IsRoad()) { id += 2; }
        //if (grid.GetCell(cellPos.x, cellPos.y - 1).IsRoad()) { id += 4; }
        //if (grid.GetCell(cellPos.x + 1, cellPos.y).IsRoad()) { id += 8; }


        currentState = states[id];
        currentState.SetActive(true);
    }
}
