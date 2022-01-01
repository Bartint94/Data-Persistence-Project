using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Play : MonoBehaviour
{
    public TextMeshProUGUI uName;
    
    public void StartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PName()
    {
        MenuMang.Instance.pname = uName.text;
    }
    

    void Update()
    {
        PName();
    }
}
