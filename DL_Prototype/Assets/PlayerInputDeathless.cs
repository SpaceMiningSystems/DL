using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerDeathless))]
public class PlayerInputDeathless : MonoBehaviour
{
    private PlayerDeathless player;
    public GameObject playerSprite;

    public GameObject[] maskButtons;

    private void Start()
    {
        player = GetComponent<PlayerDeathless>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (directionalInput.x < 0)
        {
            GetComponent<Animator>().SetBool("Walking", true);
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
        if (directionalInput.x > 0)
        {
            GetComponent<Animator>().SetBool("Walking", true);
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        if(directionalInput.x == 0)
        {
            GetComponent<Animator>().SetBool("Walking", false);
        }


        if (Input.GetButtonDown("Jump"))
        {
            player.OnJumpInputDown();
        }

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }

        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < maskButtons.Length; i++)
            {
                maskButtons[i].SetActive(false);
            }

            GetComponent<Animator>().SetBool("Whipping", true);

        }

        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < maskButtons.Length; i++)
            {
                maskButtons[i].SetActive(true);
            }
        }

        if (Input.GetMouseButtonUp(1))
        {
            for (int i = 0; i < maskButtons.Length; i++)
            {
                maskButtons[i].SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


    public void WhippingAnimationEnded()
    { 

        GetComponent<Animator>().SetBool("Whipping", false);
    }

}