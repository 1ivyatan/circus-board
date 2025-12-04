using System.Collections;
using UnityEngine;

public class SetActiveButtonScript : MonoBehaviour
{
    public GameObject[] targetObjects;

    public void ToggleActiveAfterDelay(int index)
    {
        StartCoroutine(ToggleActiveCoroutine(0.15f, index));
    }

    private IEnumerator ToggleActiveCoroutine(float delay, int index)
    {
        yield return new WaitForSeconds(delay);

        int j = 0;
        foreach (GameObject obj in targetObjects)
        {
            if (index == j)
            {
                obj.SetActive(true);
            } else
            {
                obj.SetActive(false);
            }
            j++;
        }
    }
}
