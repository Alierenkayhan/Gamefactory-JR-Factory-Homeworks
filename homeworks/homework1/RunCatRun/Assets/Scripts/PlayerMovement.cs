using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigi;
    bool sol;
    bool sag;

    float hiz = 5.0f;
    float ziplama = 5.0f;

     
    void Start()
    {
        rigi = GetComponent<Rigidbody>();    
    }
    void Update()
    {

        if (this.GetComponent<PlayerManager>().attack == true)
        {
            var enemyDirection = new Vector3(this.GetComponent<PlayerManager>().enemy.position.x, this.transform.position.y, this.GetComponent<PlayerManager>().enemy.position.z) - this.transform.position;
         }
        else
        {
            Move();
        }
    }
    public void Move()
    {

        transform.Translate(0, 0, hiz * Time.deltaTime);
        Vector3 sag_git = new Vector3(49.82f, transform.position.y, transform.position.z);
        Vector3 sol_git = new Vector3(42.32f, transform.position.y, transform.position.z);
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            if (parmak.deltaPosition.x > 0.02f)
            {
                sag = true;
                sol = false;
            }
            if (parmak.deltaPosition.x < -0.02f)
            {
                sag = false;
                sol = true;
            }

            if (sag == true)
            {
                transform.position = Vector3.Lerp(transform.position, sag_git, 4 * Time.deltaTime);
            }
            if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, sol_git, 4 * Time.deltaTime);
            }
        }
    }
}

 