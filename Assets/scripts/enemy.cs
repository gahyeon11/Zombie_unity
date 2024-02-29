using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour
{
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //target2.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.01f);
       

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bullet")) 
        {
            
            Destroy(gameObject);
            print("hit");
            me.Enemy = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f,5f)), Quaternion.identity);
            me.Enemy = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
            me.Enemy = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
  
            score.sscore += 5;

        }

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
