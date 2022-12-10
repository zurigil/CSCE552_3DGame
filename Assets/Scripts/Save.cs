using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        LoadPosition();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SavePosition()
    {
        float xPos = player.transform.position.x;
        float zPos = player.transform.position.z;
        PlayerPrefs.SetFloat("X", xPos);
        PlayerPrefs.SetFloat("Z", zPos);
        PlayerPrefs.Save();
    }

    public void LoadPosition()
    {
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("X"), 6, PlayerPrefs.GetFloat("Z"));
    }
}
