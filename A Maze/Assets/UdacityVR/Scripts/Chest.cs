using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {


    public GameObject chestTop;
    Animator m_Animator;


    // Use this for initialization
    void Start () {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = chestTop.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void openChestNow()
    {
        m_Animator.SetTrigger("openChest");
    }

}
