using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Top3 : MonoBehaviour
{
    MusicSettings settings;
    //public GameObject sphere;
    //public GameObject cube;
    public string bestGame = "";
    public string bestMovie = "";
    // Start is called before the first frame update
    void Start()
    {
        settings = GetComponent<MusicSettings>();

        // if (settings.bestSongEver != "NULL" && != )
        Debug.Log(settings.bestSongEver + ", " + bestGame + ", " + bestMovie);
        



    }
    



    // Update is called once per frame
    void Update()
    {
        
    }
}
