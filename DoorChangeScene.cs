using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorChangeScene : MonoBehaviour
{

    public WhenClicked unlock;
    public rotate unlockII;
    public KeyCode pressUp;
    private bool monsterGone = false;

    // Use this for initialization
    void Start()
    {
        unlock = FindObjectOfType<WhenClicked>();
        unlockII = FindObjectOfType<rotate>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!unlock.monsterShowing)
        {
            monsterGone = true;
        }
        if (monsterGone & Input.GetKeyDown(pressUp))
        {
          
                SceneManager.LoadScene("AnotherRoom");
        }

    }
}

