using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WhenClicked : MonoBehaviour {
    public bool isImgOn;
    public Image img;
    public bool visible;
    public bool monsterShowing;

    // Use this for initialization
    void Start ()
    {
        img.enabled = true;
        isImgOn = true;
        monsterShowing = true;
    }

 

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown("j"))
        {
            if (monsterShowing == true)
            {
                monsterShowing = false;
            }
            else
            {
                monsterShowing = true;
            }

            if (isImgOn == true)
            {

                img.enabled = false;
                isImgOn = false;
            }

            else
            {

                img.enabled = true;
                isImgOn = true;

             
            }
        }
    }
}
