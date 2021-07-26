using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private GameObject flowManager;

    void Start()
    {
        flowManager = GameObject.Find("FlowManager");
        StartCoroutine(AsyncLoad());
    }

    void Update()
    {
        Debug.Log("loading..." + flowManager.GetComponent<GameManager>().counter);
    }

    public IEnumerator AsyncLoad()
    {
        yield return new WaitForSeconds(3);
        flowManager.GetComponent<GameManager>().LoadScreen();
    }
}
