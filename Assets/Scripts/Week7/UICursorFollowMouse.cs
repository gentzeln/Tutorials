using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICursorFollowMouse : MonoBehaviour
{
    public RectTransform customCursor; //Assign your UI cursor Image in the inspector

    private void Update()
    {
        //Get the mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;

        //Set the position of the custom cursor to the mouseposition
        customCursor.position = mousePosition;
    }
}
