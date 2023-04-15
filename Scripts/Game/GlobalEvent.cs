using UnityEngine;

public class GlobalEvent : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)) {
            Application.Quit();
        }
    }
}
