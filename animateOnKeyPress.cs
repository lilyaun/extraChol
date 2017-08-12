using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateOnKeyPress : MonoBehaviour {
    public KeyCode MyKey;
    public string MyTrigger;
    private new Animation animation;

	// Use this for initialization
	void Start () {
        animation = GetComponent<Animation>();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(MyKey))
        {
            NewMethod();
        }
    }

    private void NewMethod()
    {
        gameObject.GetComponent<Animator>().Rebind();
        //GetComponent<Animator>().SetTrigger("stop");
    }
}
