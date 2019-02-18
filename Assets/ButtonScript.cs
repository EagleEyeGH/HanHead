using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, m_exit;

    public int ammunitionpoints = 40;
    public int zombiepoints;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(Item01Click);
        m_YourSecondButton.onClick.AddListener(Item02Click);
        m_YourThirdButton.onClick.AddListener(Item03Click);
        m_exit.onClick.AddListener(exit);
    }

    void Item01Click()

    {
        if (zombiepoints >= ammunitionpoints)
        {
            Debug.Log("currentpoints = Zombiepoints - ammunitionpoints ?? updating the current zombie points adding ammunution");

        }
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button ammunition!");
    }

    void Item02Click()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button! damage ");
    }

    void Item03Click()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button! life ");
    }

    void exit()
    {
        Debug.Log("make this return to scene main_menu");
        
       // CanvasObject.GetComponent<Canvas>().enabled = false;
    }


    
}