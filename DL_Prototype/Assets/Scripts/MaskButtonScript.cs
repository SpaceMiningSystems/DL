using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskButtonScript : MonoBehaviour {

    public int maskID;
    public GameObject altSpriteManager;
    public bool allowDoubleJump;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (allowDoubleJump)
        {
            GameObject.Find("Player").GetComponent<PlayerDeathless>().canDoubleJump = true;
        }
        else
        {
            GameObject.Find("Player").GetComponent<PlayerDeathless>().canDoubleJump = false;
        }
        altSpriteManager.GetComponent<AltSpriteManagerScript>().ChangeAllSprites(maskID);
    }

}
