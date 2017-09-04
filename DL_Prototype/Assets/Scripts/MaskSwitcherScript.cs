using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskSwitcherScript : MonoBehaviour {

    public Sprite[] spriteArray;


    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSprite(int maskNum)
    {
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[maskNum];
    }

}
