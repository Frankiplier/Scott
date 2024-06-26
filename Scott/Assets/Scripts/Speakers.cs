using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Scriptable Objects/Speakers")]

public class SpeakersList : ScriptableObject
{
    public List<bool> pickedUpSpeakers = new List<bool>();

    public void ResetList()
    {
        for (int i = 0; i < pickedUpSpeakers.Count; i++)
            pickedUpSpeakers[i] = false;
    }
}
