using UnityEngine;

public class GlobalEvent : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
