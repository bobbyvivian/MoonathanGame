using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Won : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(CollisionEnd());

    }

    IEnumerator CollisionEnd()
    {
        if (MasterInfo.win)
        {
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(3);
            MasterInfo.coinCount = 0;
            SceneManager.LoadScene(5);
            MasterInfo.win = false;
        }
    }
}
