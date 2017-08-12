using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonCode : MonoBehaviour {

    public KeyCode key;
    bool button;
    GameObject paused;

	// Use this for initialization
	void Start () {
        button = false;
        paused = GameObject.Find("ButtonField");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.L))

        {
            button = !button;
        }

        if (button)

        {
            paused.SetActive(true);
            Time.timeScale = 0;
        }

        else if (!button)

        {
            paused.SetActive(false);
            Time.timeScale = 1.0f;
        }
	}
}
