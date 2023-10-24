using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public static string playerNickname;

    public Text nickname;

    void Start()
    {
        nickname.text = playerNickname;
    }
}
