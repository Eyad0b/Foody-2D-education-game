//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ContextOff : MonoBehaviour
//{
//    public Transform left;
//    public Transform right;

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (Physics2D.Raycast(left.position, Vector2.down, 2) == false)
//            Door.SignalOff.Raise();
//        if (Physics2D.Raycast(right.position, Vector2.down, 2) == false)
//            Door.SignalOff.Raise();
//    }
//}
