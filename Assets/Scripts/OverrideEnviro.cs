using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class OverrideEnviro : MonoBehaviour
{

    public EnviromentData enviromentData;
    protected virtual void OnEnviromentData()
    {

    }
    public virtual void Awake()
    {
        OnEnviromentData();
    }

}
