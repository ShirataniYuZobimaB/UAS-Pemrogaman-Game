using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMulai(string Scenename)
    {
        SceneManager.LoadScene(Scenename);  
    }

    public void ButtonInfo()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
    }
    
    public void ButtonBack()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }
    public void ButtonQuit()
    {
        Application.Quit();
        Debug.Log("Keluar dari Game..");
    }
}
