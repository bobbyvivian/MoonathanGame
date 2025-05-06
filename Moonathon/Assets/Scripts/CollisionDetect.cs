using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnimation;
    [SerializeField] AudioSource collisionFX;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject alien;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
        
    }

    IEnumerator CollisionEnd()
    {

        collisionFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        playerAnimation.GetComponent<Animator>().Play("Stumble Backwards");
        alien.GetComponent<Animator>().enabled = true;
        mainCam.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        MasterInfo.coinCount = 0;
        SceneManager.LoadScene(0);

;

    }

}
