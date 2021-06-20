using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : MonoBehaviour
{
    public float speed_character = 5.0f;
    public float speed_rotate = 200.0f;

    private Animator anim;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * speed_rotate, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speed_character);

        anim.SetFloat("Speed_X", x);
        anim.SetFloat("Speed_Y", y);
    }
}
