using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void CloseGame()
    {
        StartCoroutine(Quit());
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(.8f);
        Application.Quit();
    }
}
