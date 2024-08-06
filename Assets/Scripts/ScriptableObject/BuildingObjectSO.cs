using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class BuildingObjectSO : ScriptableObject
{
    public Transform prefab;
    public Transform constructionPrefab;
    public Sprite sprite;
}
