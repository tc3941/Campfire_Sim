using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript1 : MonoBehaviour {

    private Animator anim;
    private bool nearBow;
    [HideInInspector] public bool canMove;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        bool punching = Input.GetButton("Fire1");
        bool pushKick = Input.GetAxis("Mouse ScrollWheel") > 0 ? true:false;
        bool kick = Input.GetButton("Fire2");

        if (punching)
        {
            anim.SetBool("Punch",true);
        }

        if (pushKick)
            anim.SetTrigger("PushKick");

        if (kick)
            anim.SetTrigger("Kick");

        if (nearBow)
            anim.SetTrigger("Interact");

	}
    private void LateUpdate()
    {
        anim.SetBool("Punch", false);
        nearBow = false;
    }
    public bool getCanMove()
    {
        print("entered");
        StartCoroutine(new WaitForSecondsRealtime(3));
        print("exited");
        return true;
    }
    public void setBoolean(bool newBool)
    {
        nearBow = newBool;
    }
}
