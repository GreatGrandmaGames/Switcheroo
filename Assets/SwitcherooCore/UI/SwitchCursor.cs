using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCursor : MonoBehaviour
{
    public float angularSpeed;

    private void Awake()
    {
        StartCoroutine(Rotate());
    }

    void Update()
    {
        var screenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(screenPos.x, screenPos.y, 0f);
    }

    IEnumerator Rotate()
    {
        float angle = 0;

        while (true)
        {
            angle = (angle + (angularSpeed * Time.deltaTime)) % 360f;

            transform.Rotate(new Vector3(0f, 0f, angle));

            yield return null;
        }
    }
}
