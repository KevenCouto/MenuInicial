using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settinsg : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public void settings()
    {
       panel1.SetActive(true);
        panel2.SetActive(false);
    }
}
