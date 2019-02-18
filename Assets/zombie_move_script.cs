using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_move_script : MonoBehaviour
{
    public int move_speed = 1;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()   
    {
        
    }
}
