using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator playerAnimation;
    public GameObject Bandit;
    void Start()
    {
        playerAnimation = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnimation.SetBool("MovingLeft",true);
            Bandit.transform.position = Vector3.left;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnimation.SetBool("MovingLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerAnimation.SetBool("MovingRight", true);
            Bandit.transform.position = Vector3.right;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnimation.SetBool("MovingRight", false);
        }
    }
}
