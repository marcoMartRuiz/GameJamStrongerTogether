using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
public class TerrainGenator : MonoBehaviour
{
    int[] MapAreaNArray;
    Mesh terrainMesh;
    Vector3[] newVertices;
    int[] newIndices;
    int mapSize;
    private void Start()
    {
        terrainMesh = new Mesh();
        GetComponent<MeshFilter>().mesh = terrainMesh;
        LoadMapData();
        CreateTerrainMesh();
        UpdateTerrainMesh();

    }

    private void Update()
    {
    }

    public void LoadMapData()
    {
        mapSize = 256;

        int mapAreaColumn = 1;
        int mapAreaRow = 1;

        var LoadMapHeightImage = Resources.Load<Texture2D>("palletHeightMap");

        int[] MapAreaNArray = new int[mapSize * mapSize];
        Color[] CurrentHeightMapArea = LoadMapHeightImage.GetPixels(mapAreaColumn * mapSize, mapAreaRow * mapSize, mapSize, mapSize);

        for (int i = 0, y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                MapAreaNArray[i] = Mathf.FloorToInt(CurrentHeightMapArea[i].grayscale * 100);

            }
        }
    }

    public void CreateTerrainMesh()
    {
        newVertices = new Vector3[(mapSize + 1) * (mapSize + 1)];

        for (int i = 0, z = 0; z < mapSize; z++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                newVertices[i] = new Vector3(x, 0, z);
                i++;
            }
        }

        int vert = 0;
        int quad = 0;
        newIndices = new int[mapSize * mapSize * 4];
        for (int z = 0; z < mapSize; z++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                newIndices[quad + 0] = vert + 0;
                newIndices[quad + 1] = vert + mapSize;
                newIndices[quad + 2] = vert + mapSize + 1;
                newIndices[quad + 3] = vert + 1;

                vert++;
                quad += 4;

            }
            // vert++;
        }

    }

    public void UpdateTerrainMesh()
    {

        terrainMesh.Clear();
        terrainMesh.vertices = newVertices;
        terrainMesh.SetIndices(newIndices, MeshTopology.Quads, 0);
        terrainMesh.RecalculateNormals();

    }

}

// public enum MapAreaValue
// {
//     MapArea0 , MapArea1, MapArea2, MapArea3,
//     MapArea4, MapArea5, MapArea6, MapArea7,
//     MapArea8, MapArea9, MapArea10, MapArea11,
//     MapArea12, MapArea13, MapArea14, MapArea15,

// }