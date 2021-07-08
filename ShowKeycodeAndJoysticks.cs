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
                A鍵:Joystick1Button0
                B鍵:Joystick1Button1
                X鍵:Joystick1Button2
                Y鍵:Joystick1Button3
                LB鍵:Joystick1Button4
                RB鍵:Joystick1Button5
                back鍵:Joystick1Button6
                start鍵:Joystick1Button7
                LS鍵:Joystick1Button8
                RS鍵:Joystick1Button9
                 */
            }
        }
        for (int i = 1; i < 29; i++)
        {
            string Description = "";
            if (i == 1) Description = "A" + i + "(X軸 -1~1):";//左搖桿上下[X axis]
            else if (i == 2) Description = "A" + i + "(Y軸 -1~1):";//左搖桿左右[Y axis]
            else if (i == 3) Description = "A" + i + "(Z軸 -1~1):";//LT、RT[3rd axis(Joysticks and Scrollwheel)]
            else if (i == 4) Description = "A" + i + "(X旋轉 -1~1):";//右搖桿上下[4th axis(Joysticks and Scrollwheel)]
            else if (i == 5) Description = "A" + i + "(Y旋轉 -1~1):";//右搖桿左右[5th axis(Joysticks and Scrollwheel)]
            else if (i == 6) Description = "A" + i + "(Pad左右 -1、1):";//十字左右[6th axis(Joysticks and Scrollwheel)]
            else if (i == 7) Description = "A" + i + "(Pad下上 -1、1):";//十字上下[7th axis(Joysticks and Scrollwheel)]
            else if (i == 9) Description = "A" + i + "(Z軸 |0~-1|):";//LT[9th axis(Joysticks and Scrollwheel)]
            else if (i == 10) Description = "A" + i + "(Z軸 0~1):";//RT[10th axis(Joysticks and Scrollwheel)]
            else Description = "A" + i + ":";//其他參數顯示[8、11~28th axis(Joysticks and Scrollwheel)]
            transform.GetChild(i).GetComponent<Text>().text = Description + Input.GetAxis("A" + i);
        }
    }
}
