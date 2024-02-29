using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me : MonoBehaviour
{
    public GameObject pre;
    public GameObject pre2;
    public GameObject pre3;
    public GameObject pre4;


    public static GameObject Enemy;
    public static GameObject Enemy2;
    public static GameObject Enemy3;
    public static GameObject Enemy4;




    // Start is called before the first frame update
    void Start()
    {
        Enemy = Instantiate(pre, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
        Enemy2 = Instantiate(pre2, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
        Enemy3 = Instantiate(pre3, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
        Enemy4 = Instantiate(pre4, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, transform.position, 0.001f);
        Enemy2.transform.position = Vector3.MoveTowards(Enemy2.transform.position, transform.position, 0.001f);
        Enemy3.transform.position = Vector3.MoveTowards(Enemy3.transform.position, transform.position, 0.001f);
        Enemy4.transform.position = Vector3.MoveTowards(Enemy4.transform.position, transform.position, 0.001f);


    }
    private void Die()
    {
        DIE.instance.gameOverText.SetActive(true);               
        Invoke("Hide", 1.25f);                                      
    }
    private void Hide()
    {
       DIE.instance.gameOverText.SetActive(false);                   

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("충돌 체력 감소");
            HP.hp -= 5;
        }
        if (HP.hp <= 1)                                
        {
            Debug.Log("게임오버");
            Die();                                                             
            transform.position = new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f));

            HP.hp = 30;
        }
    }
}
