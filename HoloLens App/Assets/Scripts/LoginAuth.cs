﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginAuth : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField PIN = null;
    [SerializeField]
    private TextMeshProUGUI WarningInfo = null;
    [SerializeField]
    private GameObject PINPad = null;

    private void Start()
    {
        TMP_InputField PIN = GetComponent<TMP_InputField>();
    }

    public void Auth()
    {
        if (PIN.text == "3825")
        {
            Destroy(PINPad);
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
        else
        {
            WarningInfo.text = "The PIN is wrong!";
            PIN.Select();
            PIN.text = "";
        }
    }

    public void Clear()
    {
        WarningInfo.text = "";
        PIN.Select();
        PIN.text = "";  
    }
}
