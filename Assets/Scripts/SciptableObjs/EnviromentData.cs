using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
[CreateAssetMenu(fileName = "new EnviroData" , menuName = "EnviroData")]
public class EnviromentData : ScriptableObject
{
    public string EnviromentAreaName;
    public int2 mapSize;
    
    public Texture2D RBRSpawnLocationMap;

    // public int numOfTreeTypes;
    // public int numOfBushTypes;
    // public int numOfRockTypes;

    // public int numOfTreesToSpawn;
    // public int numOfBushToSpawn;
    // public int numOfRockToSpawn;

    public GameObject[] treeType;
    public Material[] treeMaterial;
    // public Vector3[] treeWolrdLocation;
    public float2 treeSizeRange;
 
    public GameObject[] bushType;
    public Material[] bushMaterial;
    // public Vector3[] bushWorldLocation; 
    public float2 bushSizeRange;
     
    public GameObject[] rockType;
    public Material[] rockMaterial;
    // public Vector3[] rockWorldLocation; 
    public float2 rockSizeRange;

}
