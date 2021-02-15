using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenator : MonoBehaviour
{
    private void Start()
    {
        byte mapAreaValue = 0; // 16 areas
        LoadMapData(mapAreaValue);
    }

    public void LoadMapData(byte mapAreaValue)
    {
        var LoadMapHeightImage = Resources.Load<Texture2D>("palletHeightMap");


        Color[] LoadMapHeightImageArrayNum = LoadMapHeightImage.GetPixels(0, 0, 256, 256);






        // Color[] LoadMapHeightImageArray0 = LoadMapHeightImage.GetPixels(0, 0, 256, 256);
        // Color[] LoadMapHeightImageArray1 = LoadMapHeightImage.GetPixels(0, 256, 256, 256);
        // Color[] LoadMapHeightImageArray2 = LoadMapHeightImage.GetPixels(0, 512, 256, 256);
        // Color[] LoadMapHeightImageArray3 = LoadMapHeightImage.GetPixels(0, 768, 256, 256);

        // Color[] LoadMapHeightImageArray4 = LoadMapHeightImage.GetPixels(256, 0, 256, 256);
        // Color[] LoadMapHeightImageArray5 = LoadMapHeightImage.GetPixels(256, 256, 256, 256);
        // Color[] LoadMapHeightImageArray6 = LoadMapHeightImage.GetPixels(256, 512, 256, 256);
        // Color[] LoadMapHeightImageArray7 = LoadMapHeightImage.GetPixels(256, 768, 256, 256);

        // Color[] LoadMapHeightImageArray8 = LoadMapHeightImage.GetPixels(512, 0, 256, 256);
        // Color[] LoadMapHeightImageArray9 = LoadMapHeightImage.GetPixels(512, 256, 256, 256);
        // Color[] LoadMapHeightImageArray10 = LoadMapHeightImage.GetPixels(512, 512, 256, 256);
        // Color[] LoadMapHeightImageArray11 = LoadMapHeightImage.GetPixels(512, 768, 256, 256);

        // Color[] LoadMapHeightImageArray12 = LoadMapHeightImage.GetPixels(768, 0, 256, 256);
        // Color[] LoadMapHeightImageArray13 = LoadMapHeightImage.GetPixels(768, 256, 256, 256);
        // Color[] LoadMapHeightImageArray14 = LoadMapHeightImage.GetPixels(768, 512, 256, 256);
        // Color[] LoadMapHeightImageArray15 = LoadMapHeightImage.GetPixels(768, 768, 256, 256);

        // float CurrentMapArea = LoadMapHeightImageArray0[0].grayscale;


    }


}

public enum MapAreaValue
{
    MapArea0, MapArea1, MapArea2, MapArea3,
    MapArea4, MapArea5, MapArea6, MapArea7,
    MapArea8, MapArea9, MapArea10, MapArea11,
    MapArea12, MapArea13, MapArea14, MapArea15,

}

// int[] MapHeightGreyScaleArea0 = new int[65536]; // 0-255
//         // int[] MapHeightGreyScaleArea1 = new int[65536]; // 
//         // int[] MapHeightGreyScaleArea2 = new int[65536];  
//         // int[] MapHeightGreyScaleArea3 = new int[65536];  
//         // int[] MapHeightGreyScaleArea4 = new int[65536];  
//         // int[] MapHeightGreyScaleArea5 = new int[65536];  
//         // int[] MapHeightGreyScaleArea6 = new int[65536];  
//         // int[] MapHeightGreyScaleArea7 = new int[65536];  

//         for (int y = 0; y < 256; y++)
//         {
//             for (int x = 0; x < 256; x++)
//             {
//                 // int MapHeightGreyScaleValue = Mathf.FloorToInt((LoadMapHeightImageArray[x].b + LoadMapHeightImageArray[x].g + LoadMapHeightImageArray[x].r) / 3);
//                 MapHeightGreyScaleArray[i] = MapHeightGreyScaleValue;
//                 Debug.Log(x + " , " + y + " , " + MapHeightGreyScaleArray[i]);
//             }
//         }