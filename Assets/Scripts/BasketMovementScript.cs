using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;
    public int score;
    public Text scoreTxt, loserTxt;
    public Image img;

   
    // Start is called before the first frame update
    void Start()
    {
        img.enabled = false;
        loserTxt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        
       if(score == 100)
            loserTxt.text = "GAme Win";

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Healthy"))
        {
            score += 10 ;
            scoreTxt.text = "Score: " + score;
            loserTxt.text = "GAme Win";
            Destroy(other.gameObject);
        }
        else
        {
            img.enabled = true ;
            loserTxt.enabled = true;
            loserTxt.text = "lose game";
        }
    }





}
