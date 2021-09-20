using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ken : MonoBehaviour
{

    public float speed = 5;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float speedActual = h * Time.deltaTime * speed;
        transform.Translate(speedActual, 0, 0);

        // con esto mandamos valores a los parámetros que definimos en animator controller
        anim.SetFloat("velocidad", speedActual);

        if (Input.GetKeyUp(KeyCode.Space))
            anim.SetTrigger("hadouken");
    }
}
