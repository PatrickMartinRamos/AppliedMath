using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMove : MonoBehaviour
{
    List<Tile> selectableTiles = new();
    GameObject[] Tiles;
    public int move = 3; //range of player can move
    public float jumpHeight; 
    public float moveSpeed;

    Stack<Tile> Path = new();
    Tile CurrentTile;

    Vector3 Velocity = new();
    Vector3 Heading = new();

    float HalfHeight = 0;

    protected void Init()
    {
        Tiles = GameObject.FindGameObjectsWithTag("Tile");

        HalfHeight = GetComponent<Collider>().bounds.extents.y;
    }
    public void getCurrentTile()
    {
        CurrentTile = GetTargetTile(gameObject);
        CurrentTile.current = true;
    }
    public Tile GetTargetTile(GameObject target)
    {
        Tile tile = null;
        return tile;
    }
}
