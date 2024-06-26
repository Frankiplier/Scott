using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Dances")]

public class DanceBattled : ScriptableObject
{
    public List<bool> danceBattled = new List<bool>();

    public void ResetList()
    {
        for (int i = 0; i < danceBattled.Count; i++)
            danceBattled[i] = false;
    }
}
