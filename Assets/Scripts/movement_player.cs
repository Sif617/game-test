using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player : MonoBehaviour
{

    public float speed;
    public bool ismove;
    Vector3 position;
    public float rotatespeed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        ismove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ismove)
        {   
            transform.Translate(new Vector3 (1,0,0)*speed*Time.deltaTime);
          
        }



        if (Input.GetMouseButtonDown(0))
        {
            position = Input.mousePosition;   

        }

        if (Input.GetMouseButton(0))
        {
            Vector3 position2  = position - Input.mousePosition;

            float rotation = position2.x*rotatespeed*Time.deltaTime;

            transform.Rotate(Vector3.up, rotation);
        }
    }


    public void charactermove()
    {
        ismove =true;
        animator.SetBool("iswalk", true);
        animator.SetBool("isdead", false);
    }

    public void characterfalse()
    {
        ismove =false;
        animator.SetBool("isdead", true);

    }


    


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "house")
        {
            canvasscriot sannn = FindObjectOfType<canvasscriot>();

            sannn.damagee();
            sannn.finishplayer();

        }
    }
}
