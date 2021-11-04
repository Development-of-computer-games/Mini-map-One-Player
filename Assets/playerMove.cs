using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    //float x, y;
    //Rigidbody2D rb;
    float stepSize = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // x = Input.GetAxis("Horizontal");
        // y = Input.GetAxis("Vertical");
        //rb.velocity = new Vector2(x * 2, y * 2);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, stepSize * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -stepSize * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-stepSize * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(stepSize * Time.deltaTime, 0, 0);
        }
    }
}
