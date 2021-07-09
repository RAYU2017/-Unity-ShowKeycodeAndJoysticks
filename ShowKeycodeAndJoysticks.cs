using UnityEngine;
using UnityEngine.UI;

public class ShowKeycodeAndJoysticks : MonoBehaviour
{
    void Update()//此類說明為xbox搖桿對照
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i <= 509; i++)//Find all Keycode
            {
                if (Input.GetKeyDown((KeyCode)i))
                    transform.GetChild(0).GetComponent<Text>().text = "KeyCode:" + ((KeyCode)i).ToString();
                /*
                A Button:Joystick1Button0
                B Button:Joystick1Button1
                X Button:Joystick1Button2
                Y Button:Joystick1Button3
                Left Bumper:Joystick1Button4
                Right Bumper:Joystick1Button5
                Back Button:Joystick1Button6
                Start Button:Joystick1Button7
                Left Stick Button:Joystick1Button8
                Right Stick Button:Joystick1Button9
                 */
            }
        }
        for (int i = 1; i < 29; i++)
        {
            string Description = "";
            if (i == 1) Description = "A" + i + "(X軸 -1~1):";//Left Stick(Top、Bottom)[X axis]
            else if (i == 2) Description = "A" + i + "(Y軸 -1~1):";//Left Stick(Left、Right)[Y axis]
            else if (i == 3) Description = "A" + i + "(Z軸 -1~1):";//Left Trigger、Right Trigger[3rd axis(Joysticks and Scrollwheel)]
            else if (i == 4) Description = "A" + i + "(X旋轉 -1~1):";//Right Stick(Top、Bottom)[4th axis(Joysticks and Scrollwheel)]
            else if (i == 5) Description = "A" + i + "(Y旋轉 -1~1):";//Right Stick(Left、Right)[5th axis(Joysticks and Scrollwheel)]
            else if (i == 6) Description = "A" + i + "(Pad左右 -1、1):";//D-Pad(Left、Right)[6th axis(Joysticks and Scrollwheel)]
            else if (i == 7) Description = "A" + i + "(Pad下上 -1、1):";//D-Pad(Top、Bottom)[7th axis(Joysticks and Scrollwheel)]
            else if (i == 9) Description = "A" + i + "(Z軸 |0~-1|):";//Left Trigger[9th axis(Joysticks and Scrollwheel)]
            else if (i == 10) Description = "A" + i + "(Z軸 0~1):";//Right Trigger[10th axis(Joysticks and Scrollwheel)]
            else Description = "A" + i + ":";//Other parameters[8、11~28th axis(Joysticks and Scrollwheel)]
            transform.GetChild(i).GetComponent<Text>().text = Description + Input.GetAxis("A" + i);
        }
    }
}
