using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridGenerator : MonoBehaviour
{
    public int width,height;
    public GameObject tilePrefab;

    #region Generate Grid
    public void GenerateGrid()
    {
        if(tilePrefab == null)
        {
            Debug.LogError("No Tile Prefab Assigned");
            return;
        }
        //loop through the grid position x = width
        for(int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                //calculate the position for each tile
                Vector3 position = new Vector3(x, 0, y);
                //instaciate the cube at the calculated position
                GameObject newTile = Instantiate(tilePrefab, position, Quaternion.identity);
                newTile.transform.parent = transform;
                newTile.tag = "Tile";
                newTile.name = "Tiles";
            }
        }
    }
    #endregion

    #region Clear Grid
    public void ClearGrid()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        {
            foreach(GameObject tile in tiles)
            {
                DestroyImmediate(tile);
            }
        }
    }
    #endregion

    #region Assign Material
    public void AssignMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        Material material = Resources.Load<Material>("Tile");

        foreach(GameObject tile in tiles)
        {
            tile.GetComponent<MeshRenderer>().material = material;
        }
    }   
    #endregion

}
