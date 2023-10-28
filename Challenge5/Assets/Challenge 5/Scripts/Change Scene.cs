using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public string URL = "https://github.com/B00156478/Challenge05";


    public void loadUrl()
    {

        Application.OpenURL(URL);
    }

}