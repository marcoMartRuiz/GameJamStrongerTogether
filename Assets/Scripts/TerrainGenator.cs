using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenator : MonoBehaviour
{
    int[] MapAreaNArray;
    private void Start()
    {
        LoadMapData();
        CreateTerrainMesh();       

    }

    public void LoadMapData()
    {
        int mapSize = 256;
        int mapAreaColumn = 1;
        int mapAreaRow = 1;

        var LoadMapHeightImage = Resources.Load<Texture2D>("palletHeightMap");
    
        int[] MapAreaNArray = new int[mapSize * mapSize ];
        Color[] CurrentHeightMapArea = LoadMapHeightImage.GetPixels(mapAreaColumn * mapSize , mapAreaRow* mapSize, mapSize, mapSize);

        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                MapAreaNArray[x + (y * mapSize)] = Mathf.FloorToInt(CurrentHeightMapArea[x + (y * mapSize)].grayscale * 100);
            }
        }
    }

    public void CreateTerrainMesh()
    {
        
    }

}

// public enum MapAreaValue
// {
//     MapArea0 , MapArea1, MapArea2, MapArea3,
//     MapArea4, MapArea5, MapArea6, MapArea7,
//     MapArea8, MapArea9, MapArea10, MapArea11,
//     MapArea12, MapArea13, MapArea14, MapArea15,

// }