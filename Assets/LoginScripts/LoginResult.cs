using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginResult : MonoBehaviour
{

    public Text LoginResultText;
    void Start()
    {
        var user = PlayerPrefs.GetString("LoginUser", "Unknown");
        LoginResultText.text = "Successfully signed in as " + user;
        Debug.LogFormat("Successfully signed in as {0}", user);
        StartCoroutine(LoadAfterDelay("mainUOMwithPlane"));
    }


    
        
    

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(02); // wait 1 seconds
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(levelName);
#pragma warning restore CS0618 // Type or member is obsolete

    }
}