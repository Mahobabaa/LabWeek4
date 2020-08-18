using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rent;
    private int i, randValue;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        randValue = Random.Range(200, 250);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if (gameObject.CompareTag("Red")&i == 100)
            gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue")&i == randValue)
            rent.enabled = false;

    }
}
