using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuInicial : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public void start()
    {
        SceneManager.LoadScene("C1");
    }
    public void settings()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
    }
}
