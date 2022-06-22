using UnityEngine;

public class collisonscript : MonoBehaviour
{
    public playerscript movement;
    public scorescripts score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audiosource2;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "purplecube")
        {
            audioSource.Play();
            score.Addscore(10);
            Destroy(collisionInfo.gameObject);

        }
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "purplecube")
        {
            movement.enabled = true;

        }
        else if (collisionInfo.gameObject.name == "ground")
        {
            movement.enabled = true;

        }
        else 
        {
            audiosource2.Play();
            gameController.GameOver();
            movement.enabled = false;
        }

        }
  
}
