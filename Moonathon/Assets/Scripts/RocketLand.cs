using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketLand : MonoBehaviour
{
    [SerializeField] GameObject rocket;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject fire;
    [SerializeField] GameObject BGM;
    [SerializeField] GameObject rocketFX;
    [SerializeField] GameObject crashFX;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CollisionEnd());

    }

    IEnumerator CollisionEnd()
    {
        if (rocket.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1.0f)
        {
            fire.SetActive(true);
            rocketFX.SetActive(false);
            crashFX.SetActive(true);
            yield return new WaitForSeconds(1);
            canvas.SetActive(true);
            BGM.SetActive(true);
        }
    }
}
