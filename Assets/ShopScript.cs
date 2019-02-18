using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public static string Item01;
    public static string Item02;
    public static string Item03;

    public static int shopNumber;

    // Update is called once per frame
    void Update()
    {
        if (shopNumber == 1)
        {
            Item01 = "Ammuniton upgrade ";
            Item02 = "Damage Upgrade ";
            Item03 = "More lifes ";

        }

    }
}
