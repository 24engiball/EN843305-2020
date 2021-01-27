using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    int countDestroy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player"){
            Destroy(gameObject);
        }else if(other.gameObject.name == "ground")
        {
            countDestroy++;
            if(countDestroy>1){
                 Destroy(gameObject);
            }
            
        }
        
    }
}
