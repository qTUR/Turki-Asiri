using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed;
    public GameObject Enemy; 

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (Enemy != null)
        {
            Vector3 direction = Enemy.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);
   
            float distance = direction.magnitude; 

            if (distance <= 7f) 
            {
                Attack(); 
            }
        }
    }

    void Attack()
    {
       
        Debug.Log("Attacking Enemy!");
        Destroy(Enemy);
       
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Enmy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("Enmy is Dead");
          
        }
        {
            if (collision.gameObject.tag !="Player")
            {
                Debug.Log("ur dead !!");

            }
        }

        if (collision.gameObject.CompareTag("Destroyable"))
        {
            DisableExplosionComponents(collision.gameObject);
        }
    }
    private void DisableExplosionComponents(GameObject targetObject)
    {

    }

}