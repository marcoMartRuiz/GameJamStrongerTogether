using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// [ExecuteInEditMode]
public class OverrideUI : MonoBehaviour
{
  public UIData uiData;
  protected virtual void OnUIData()
  {

  }
  public virtual void Awake()
  {
      OnUIData();
  }
}
