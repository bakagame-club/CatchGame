using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushSensing : MonoBehaviour
{
    public bool isPushing;
    private bool isReleasing;

    private void Start() {
        isPushing = false;
        isReleasing = true;
    }

    private void Update() {
        if(IsTouched()){
            if(isReleasing)isPushing = true;
            isReleasing = false;
        }else{
            isReleasing = true;
        }
    }

    private bool IsTouched () {
        GameObject touchedGameObject = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.touchCount > 0){
        Touch touch = Input.GetTouch(0);
        ray = Camera.main.ScreenPointToRay(touch.position);
        }else if(!Input.GetMouseButtonDown(0)){
            return false;
        }
        RaycastHit2D hit2d = Physics2D.Raycast ((Vector2) ray.origin, (Vector2) ray.direction);

        if (hit2d) touchedGameObject = hit2d.transform.gameObject;
        if (touchedGameObject == null) return false;

        return touchedGameObject == this.gameObject;

    }
}
