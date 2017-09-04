using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltSpriteManagerScript : MonoBehaviour {

    // Use this for initialization
    void Start () {


   

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void ChangeAllSprites(int maskNum)
    {
        GameObject[] allObstacles = GameObject.FindGameObjectsWithTag("Obstacle");


        for (int i = 0; i < allObstacles.Length; i++)
        {


            allObstacles[i].GetComponent<MaskSwitcherScript>().ChangeSprite(maskNum);
        }

     

    }


}
