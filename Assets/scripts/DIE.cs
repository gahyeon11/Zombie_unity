using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIE : MonoBehaviour
{
    public static DIE instance;
    public GameObject startText;
    public GameObject gameOverText;
    // Start is called before the first frame update
    public void Awake()
    {
         if(DIE.instance == null)
        {
            DIE.instance = this;
        }
    }
    void Start()
    {
        startText.SetActive(false);
        gameOverText.SetActive(false);
        StartCoroutine(ShowReady());
    }

    IEnumerator ShowReady()
    {
        int count = 0;
        while (count < 3)
        {
            startText.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            startText.SetActive(false);

            yield return new WaitForSeconds(0.5f);
            count++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
