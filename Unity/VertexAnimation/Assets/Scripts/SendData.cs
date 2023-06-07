using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendData : MonoBehaviour
{
    public int FrameRange;    

    private bool isplay = false;
    private float playtime;
        
    // Start is called before the first frame update
    void Start()
    {
        playtime = FrameRange - 1.0f;
        Shader.SetGlobalFloat("PlayTime", playtime);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isplay)
        {
            Shader.SetGlobalFloat("PlayTime", playtime);
            playtime -= Time.deltaTime * 30.0f;
            if (playtime < 0)
            {
                playtime = 0;
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isplay)
        {
            if (other.name == "Switch")
            {
                isplay = true;
            }
        }
    }
}
