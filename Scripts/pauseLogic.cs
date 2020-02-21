using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseLogic : MonoBehaviour {
    private bool pause = false;
    public Canvas pausedScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pause)
                pause = false;
            else
            {
                pause = true;
            }
        }

        if(pause)
        {
            Time.timeScale = 0;
            pausedScreen.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausedScreen.gameObject.SetActive(false);
        }
        

	}
}
