using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isLeft;
    public bool isRight;
    public bool isJump;
    Rigidbody2D rb;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        KeybordControl();
        
        if (isLeft)
        {
            rb.AddForce(Vector2.left * 10);

        }
        else if (isRight)
        {
            rb.AddForce(Vector2.right * 10);
        }

        if (isJump)
        {

            rb.AddForce(Vector2.up * 200);
            isJump = false;
        }
    }

    void KeybordControl()
    {
        if (Input.GetKeyDown("a"))
        {
            SetLeft(true);
        }

        if (Input.GetKeyUp("a"))
        {
            SetLeft(false);
        }
        if (Input.GetKeyDown("d"))
        {
            SetRight(true);
        }

        if (Input.GetKeyUp("d"))
        {
            SetRight(false);
        }

        if (Input.GetKeyUp("space"))
        {
            SetJump(true);
        }

    }

    public void SetLeft(bool b)
    {
        isLeft = b;
    }

    public void SetRight(bool b)
    {
        isRight = b;
    }

    public void SetJump(bool b)
    {
        isJump = b;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Fruit")
        {
            Destroy(other.gameObject);
        }else if(other.gameObject.tag == "Ground"){

        }
    }

}
