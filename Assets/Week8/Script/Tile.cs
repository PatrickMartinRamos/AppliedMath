using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool current; //store player current location on tile
    public bool target; //player target location
    public bool selectable; //check if player can move to a tile
    public bool walkable;

    //Needed for DFS
    public bool visited = false;
    public Tile Parent = null;  
    public int Distance = 0;

    public List<Tile> adjencyList = new List<Tile>();

    private void Update()
    {
        if(current)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if(target)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (selectable)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
    public void ResetValue()
    {
        adjencyList.Clear();// clear adjencyList
        current = false;
        target = false;
        selectable = false;

        visited = false;
        Distance = 0;
    }
    public void FindNeigbhors(float JumpHeight)
    {
        ResetValue();
        Checktiles(Vector3.forward, JumpHeight);
        Checktiles(Vector3.back, JumpHeight);
        Checktiles(Vector3.right, JumpHeight);
        Checktiles(Vector3.left, JumpHeight);
    }
    public void Checktiles(Vector3 Direction, float JumpHeight)
    {
        Vector3 halfExtents = new(0.25f,(1 + JumpHeight)/2, 0.25f);
        Collider[] collider = Physics.OverlapBox(transform.position + Direction, halfExtents);

        foreach (Collider items in collider)
        {
            Tile tile = items.GetComponent<Tile>();
            // if tile is not null and walkable add it to the list
            if (tile != null && tile.walkable)
            {
                RaycastHit hit;
                if(Physics.Raycast(tile.transform.position, Vector3.up, out hit,1))
                {
                    adjencyList.Add(tile);
                }
               
            }
        }
    }
}
