using UnityEngine;
using System.Collections;

[System.Serializable]
public class GridCell
{
    public int x = 0;
    public int z = 0;
    public Transform gridTransform;
    public Vector3 gridPos;
    public bool isWalkable = false;
}

public class Grid : MonoBehaviour {

    public static Grid Instance;

    public int xSize;
    public int zSize;
    public float cellSize = 1f;
    public bool spawnDebugCubes = false;
    public GridCell[,] grid;

    public GameObject gridObject;

    void Awake()
    {
        Instance = this;
    }

	// Use this for initialization
	public void GenerateGrid () {
        GameObject go;
        Vector3 cellPosition;
        grid = new GridCell[xSize, zSize];
        Vector3 gridObjectScale = Vector3.one;
        for (int x = 0; x < xSize; x++)
        {
            for (int z = 0; z < zSize; z++)
            {
                cellPosition = transform.position + Vector3.right * cellSize * x + Vector3.forward * cellSize * z;
                
                grid[x, z] = new GridCell();
                grid[x, z].x = x;
                grid[x, z].z = z;
                if (Physics.Raycast(cellPosition + Vector3.up * 20f, Vector3.down, 18f) 
                    || Physics.Raycast(cellPosition+Vector3.right*0.45f*cellSize + Vector3.up * 20f, Vector3.down, 18f)
                    || Physics.Raycast(cellPosition - Vector3.right * 0.45f * cellSize + Vector3.up * 20f, Vector3.down, 18f)
                    || Physics.Raycast(cellPosition - Vector3.forward * 0.45f * cellSize + Vector3.up * 20f, Vector3.down, 18f)
                     || Physics.Raycast(cellPosition + Vector3.forward * 0.45f * cellSize + Vector3.up * 20f, Vector3.down, 18f))
                    
                    //if (Physics.Raycast(cellPosition + Vector3.up * 20f, Vector3.down, 18f))
                    {
                    grid[x, z].isWalkable = false;
                }
                else
                {
                    grid[x, z].isWalkable = true;
                    //if()
                    go = (GameObject)GameObject.Instantiate(gridObject, cellPosition, Quaternion.identity, transform);
                    gridObjectScale = Vector3.one * cellSize;
                    gridObjectScale.y = 1f;
                    go.transform.localScale = gridObjectScale;
      
                    grid[x, z].gridTransform = go.transform;
                }
              
            }
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
