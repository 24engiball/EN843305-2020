using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public int gameTime ;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public GameObject fruit;
    
    float height ;
    float width ;
    // Start is called before the first frame update
    void Start()
    {

    InvokeRepeating("DecreaseTime", 1.0f, 1.0f);

     height = Camera.main.orthographicSize * 2.0f;
     width = height * Screen.width / Screen.height;

    InvokeRepeating("SpawnFruit", 1.0f, 2.0f);


    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = score + "";
        timeText.text = gameTime + "";
        
    }

     void DecreaseTime()
 {
     gameTime --;
     if(gameTime<=0){
         CancelInvoke("DecreaseTime");
     }
 }


void SpawnFruit(){
    Vector2 position = new Vector2(Random.Range(-width/2, width/2),height/2);
    Instantiate(fruit, position, Quaternion.identity);
}


}
