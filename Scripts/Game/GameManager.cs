using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum gameStatus
{
    start,
    play,
    playCard,
    end
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private gameStatus status = gameStatus.start;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        // 设置游戏状态为play
        GameManager.instance.SetStatus(gameStatus.play);
    }

    public gameStatus GetStatus()
    {
        return status;
    }

    public void SetStatus(gameStatus status)
    {
        this.status = status;
    }

    public void ResetStatus()
    {
        status = gameStatus.start;
    }

}
