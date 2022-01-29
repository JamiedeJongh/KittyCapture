using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class MouseScript : MonoBehaviour
{
 
    private Touch theTouch;
    private Collider2D mouseCollider;

    public GameObject Muis;

    private Rigidbody2D body;
    public float speed;
    private Vector2 MouseDir;

    private float targetTime = 5f;

    private float BwFw;

    public TouchReaction m_someOtherScriptOnAnotherGameObject;

    // Start is called before the first frame update
    void Awake()
    {
        m_someOtherScriptOnAnotherGameObject = GameObject.FindObjectOfType(typeof(TouchReaction)) as TouchReaction;
        

        BwFw = 1f;
        speed = Random.Range(25f, 30f);
        body = GetComponent<Rigidbody2D>();
        mouseCollider = this.GetComponent<Collider2D>();
        MouseDir = new Vector2(Random.Range(-20, 20), Random.Range(-20,20));

        
        //   transform.Rotate(0, 0, Random.Range(0, 360));

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        targetTime -= Time.deltaTime;


        if (targetTime == 0.0f) {
            speed = Random.Range(25f, 30f);
            MouseDir = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20));
            targetTime = 3f;

        }

        if (MouseDir != Vector2.zero)
        {
            body.velocity = MouseDir * Time.deltaTime * speed;
        }
        else
        {
            MouseDir = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
        }


        /////////////////mouse look direction//////////////////////
        if (MouseDir != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, MouseDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 700f * Time.deltaTime);
        }


        ////////////////touch////////////////////////////
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (mouseCollider == Physics2D.OverlapPoint(touchPos))
            {
                m_someOtherScriptOnAnotherGameObject.score += 1;
                if (this.tag != "Muis")
                {
                    Instantiate(Muis, new Vector3(Random.Range(-11, 11), Random.Range(-3.5f, 3), 0), Quaternion.identity);
                }
                Destroy(this.gameObject);
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed = Random.Range(25f, 30f);
        MouseDir = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));

        


    }


   private void OnCollisionStay2D(Collision2D collision)
    {
        speed = Random.Range(25f, 30f);
        MouseDir = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));

    }
}
