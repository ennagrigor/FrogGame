using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //moving the car to the right (using the z axis so it's down)
        transform.Translate(Vector3.down  * _speed * Time.deltaTime);

        //setting boundries for car moving and going back to move again 
        if (transform.position.x >= 10)
        {
            transform.position = new Vector3(-10, transform.position.y, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.GetComponent<Mover>().Damage();
        }
    }
}
