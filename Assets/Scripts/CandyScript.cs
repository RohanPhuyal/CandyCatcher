using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            //Increment Score first

            GameManager.instance.IncrementScore();

            Destroy(gameObject);
        }else if(collision.gameObject.tag== "Boundary")
        {
            //Decrease Lives

            GameManager.instance.DecreaseLive();

            Destroy(gameObject);
        }
    }
}
