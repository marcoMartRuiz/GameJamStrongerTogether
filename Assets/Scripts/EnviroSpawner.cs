using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Unity.Mathematics;

public class EnviroSpawner : MonoBehaviour
{
    public EnviromentData enviromentData;

    public void Awake()
    {

        OnEviroData();
    }

    public void OnEviroData()
    {
        Color[] tbrSpawnerMap = enviromentData.TBRSpawnMap.GetPixels();
        GameObject[] treeList = new GameObject[2851];
        
        for (int j = 0; j < enviromentData.mapSize.y; j++)
        {
            for (int i = 0; i < enviromentData.mapSize.x; i++)
            {
                //    var averagev = Mathf.Floor(tbrSpawnerMap[i].r +tbrSpawnerMap[i].b+ tbrSpawnerMap[i].g)/3;
                var mapValuePositon = tbrSpawnerMap[i + (j * 256)];
                if (Mathf.Floor(mapValuePositon.r * 10) == 0f && Mathf.Floor(mapValuePositon.g * 10) == 5 && Mathf.Floor(mapValuePositon.b * 10) == 5)
                {
                    var treeType = enviromentData.treeType[Random.Range(0,3)];
                    var newObj = GameObject.Instantiate(treeType);
                    newObj.transform.parent = GameObject.Find(newObj.name).transform;
                    newObj.transform.position = new Vector3(i, 0, j );

                }
            }
        }





    }
}
