using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowKeycodeAndJoysticks : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i <= 509; i++)
            {
                if (Input.GetKeyDown((KeyCode)i))
                    transform.GetChild(0).GetComponent<Text>().text = "KeyCode:" + ((KeyCode)i).ToString();
            }
        }
        for (int i = 1; i < 29; i++)
        {
            print("A" + i + ":" + Input.GetAxis("A" + i));
            string Description = "";
            if (i == 1) Description = "A" + i + "(X軸 -1~1):";
            else if (i == 2) Description = "A" + i + "(Y軸 -1~1):";
            else if (i == 3) Description = "A" + i + "(Z軸 -1~1):";
            else if (i == 4) Description = "A" + i + "(X旋轉 -1~1):";
            else if (i == 5) Description = "A" + i + "(Y旋轉 -1~1):";
            else if (i == 6) Description = "A" + i + "(Pad左右 -1、1):";
            else if (i == 7) Description = "A" + i + "(Pad下上 -1、1):";
            else if (i == 9) Description = "A" + i + "(Z軸 |0~-1|):";
            else if (i == 10) Description = "A" + i + "(Z軸 0~1):";
            else Description = "A" + i + ":";
            transform.GetChild(i).GetComponent<Text>().text = Description + Input.GetAxis("A" + i);
        }
    }
}
