using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Infectathon.Mechanics;

public class TextController : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TC started");
        uiObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered");
        var p = other.gameObject.GetComponent<PlayerController>();
        if (p != null)
        {
            uiObject.SetActive(true);
        }
        /*if (other.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }*/
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var p = other.gameObject.GetComponent<PlayerController>();
        if (p != null)
        {
            uiObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
