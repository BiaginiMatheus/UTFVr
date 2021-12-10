using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player){
            uiObject.SetActive(true);
        if(player.gameObject.tag == "Player"){
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    // Update is called once per frame
    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
