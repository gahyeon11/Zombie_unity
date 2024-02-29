using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            print("hit4");
            Destroy(gameObject);
            me.Enemy4 = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
            me.Enemy4 = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
            me.Enemy4 = Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);

            score.sscore += 20;
        }

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
