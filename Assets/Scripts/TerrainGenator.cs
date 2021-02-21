using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
[RequireComponent(typeof(MeshFilter))]
public class TerrainGenator : MonoBehaviour
{
    float[] mapAreaNArray;
    Mesh terrainMesh;
    MeshCollider meshCollider;
    Vector3[] newVertices;
    int[] newIndices;
    int mapSize = 256; //Play around with size
    int mapAreaColumn = 1;
    int mapAreaRow = 1;
    private void Start()
    {

        terrainMesh = new Mesh();
        terrainMesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
        mapAreaNArray = new float[mapSize * mapSize];
        newVertices = new Vector3[mapSize * mapSize];
        newIndices = new int[(mapSize + 1) * (mapSize + 1) * 4];
    
        GetComponent<MeshFilter>().mesh = terrainMesh;
        LoadMapData();
        CreateTerrainMesh();
        UpdateTerrainMesh();
        GetComponent<MeshCollider>().sharedMesh = terrainMesh;


    }

    private void Update()
    {
    }

    public float[] LoadMapData()
    {
        //add reload whe mapareas Column/Row change
       

        var LoadMapHeightImage = Resources.Load<Texture2D>("pewter2rightHeightMap");
        Color[] CurrentHeightMapArea = LoadMapHeightImage.GetPixels(mapAreaColumn * mapSize, mapAreaRow * mapSize, mapSize, mapSize);

        for (int i = 0, y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                mapAreaNArray[i] = Mathf.Floor((CurrentHeightMapArea[i].grayscale *0));
               
                i++;
            }
        }
        return mapAreaNArray;
    }

    public void CreateTerrainMesh()
    {
        //need even number of vectors to use map height value twice.

        for (int i = 0, y = 0; y < mapSize; y++)
        {
            
            for (int x = 0; x < mapSize / 2; x++)
            {
                newVertices[i] = new Vector3((2 * x), mapAreaNArray[i / 2], y);
                newVertices[i + 1] = new Vector3((2 * x) + 1, mapAreaNArray[(i / 2)+1], y);
                i += 2;
            }
        }
        //groups of 4 verts clockwise every odd row is the terrain, and evey even is the terain slope
        int nthQuad = 0;
        int quad = 0;

        for (int z = 0; z < mapSize - 1; z++)
        {
            for (int x = 0; x < mapSize - 1; x++)
            {
                newIndices[quad + 0] = nthQuad + 0;
                newIndices[quad + 1] = nthQuad + mapSize;
                newIndices[quad + 2] = nthQuad + mapSize + 1;
                newIndices[quad + 3] = nthQuad + 1;
               
                nthQuad++;
                quad += 4;
            }
            nthQuad++;
        }

    }

    public void UpdateTerrainMesh()
    {
        terrainMesh.Clear();
        terrainMesh.vertices = newVertices;
        terrainMesh.SetIndices(newIndices, MeshTopology.Quads, 0);
        terrainMesh.RecalculateNormals();
        // terrainMesh.RecalculateBounds();
    }

}

// public enum MapAreaValue
// {
//     MapArea0 , MapArea1, MapArea2, MapArea3,
//     MapArea4, MapArea5, MapArea6, MapArea7,
//     MapArea8, MapArea9, MapArea10, MapArea11,
//     MapArea12, MapArea13, MapArea14, MapArea15,

// }