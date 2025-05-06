using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] GameObject FadeOut;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(StartButton());
    }

    IEnumerator StartButton()
    {
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
    public void Easy()
    {
        StartCoroutine(EasyButton());
    }

    IEnumerator EasyButton()
    {
        FadeOut.SetActive(true);
        MasterInfo.level = 0;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
    public void Medium()
    {
        StartCoroutine(MediumButton());
    }

    IEnumerator MediumButton()
    {
        FadeOut.SetActive(true);
        MasterInfo.level = 1;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    public void Hard()
    {
        StartCoroutine(HardButton());
    }

    IEnumerator HardButton()
    {
        FadeOut.SetActive(true);
        MasterInfo.level = 2;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(4);
    }
}
