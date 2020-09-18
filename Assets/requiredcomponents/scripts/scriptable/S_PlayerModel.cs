
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Playermodel",menuName = "Scriptables/Playermodel")]
public class S_PlayerModel : ScriptableObject
{
    public string modelname;
    public float movespeed_horizontal;
    public GameObject playermodel;
}
