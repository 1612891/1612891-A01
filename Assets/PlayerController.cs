using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 pos;
    public float speed = 0.1f;
    //Rigidbody2D rigid2d;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pos.x += speed;
                //rigid2d.AddForce(new Vector2(speed, 0));
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                pos.x -= speed;
                //rigid2d.AddForce(new Vector2(-speed, 0));
                GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.position = pos;
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        else
            GetComponent<Animator>().SetBool("isRunning", false);
    }
}
