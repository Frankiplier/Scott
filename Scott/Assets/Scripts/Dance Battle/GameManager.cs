using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller beatScroller;
    public static GameManager instance;
    public GameObject word;

    void Start()
    {
         instance = this;
         word.SetActive(true);
    }

    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape) && !Input.GetKeyUp(KeyCode.Mouse0))
            {
                word.SetActive(false);

                startPlaying = true;
                beatScroller.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit");
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
