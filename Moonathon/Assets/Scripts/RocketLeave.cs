using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketLeave : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (rocket.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1.0f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
