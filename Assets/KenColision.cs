using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenColision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("ENTER: " + collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        print("STAY: " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        print("EXIT: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("TRIGGER ENTER: " + collision.gameObject.name);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("TRIGGER STAY: " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("TRIGGER EXIT: " + collision.gameObject.name);

    }

    
}
