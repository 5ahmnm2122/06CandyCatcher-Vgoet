using UnityEngine;

public class Candy : MonoBehaviour
{

    public int candyScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.instance.IncrementScore(candyScore);
            Destroy(gameObject);

          
        }

        if (collision.gameObject.tag == "Floor")
        {
            
            Destroy(gameObject);


        }
    }
}
