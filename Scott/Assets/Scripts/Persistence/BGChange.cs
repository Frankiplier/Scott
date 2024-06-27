using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGChange : MonoBehaviour
{
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;
    [SerializeField] JelousContainer jelous;

    public Sprite day, night;
    
    void Start()
    {
        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            GetComponent<SpriteRenderer>().sprite = night;
        }
    }
}
