using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{

    public void onPlayClicked() {
        SceneManager.LoadScene("HanHead");
    }

    public void onUpgradeClicked()
    {
        SceneManager.LoadScene("Upgrade");
    }

    public void onExitClicked()
    {
        Application.Quit();
    }
}
