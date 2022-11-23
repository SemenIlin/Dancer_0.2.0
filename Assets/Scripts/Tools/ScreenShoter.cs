using UnityEngine;

public class ScreenShoter : MonoBehaviour
{
    private int screenCount = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScreenCapture.CaptureScreenshot("screen_"+screenCount.ToString()+".png");
            screenCount++;
        }
    }
}
