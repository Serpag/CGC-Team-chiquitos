using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Projectile : MonoBehaviour {
     
     private Vector3 target;
     public float speed;

     Vector3 moveDirection;
 
     void Start()
     {
         Vector3 mousePos = Input.mousePosition;
         target = Camera.main.ScreenToWorldPoint(mousePos);
 
         StartCoroutine(destroyAfterTime());
         moveDirection = (target - transform.position);
          moveDirection.z = 0;       
          moveDirection.Normalize();
          
          mousePos.z = 10f; //The distance between the camera and object
          var objectPos = Camera.main.WorldToScreenPoint(transform.position);
          mousePos.x = mousePos.x - objectPos.x;
          mousePos.y = mousePos.y - objectPos.y;
          var angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
          transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
     }
 
     private void Update()
     {
         transform.position = transform.position + moveDirection * speed* Time.deltaTime;
 
     }
 
     
 
     private void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.tag == "Floor" )
         {
            Destroy(gameObject);
         }
     }
 
 
     IEnumerator destroyAfterTime()
     {
         yield return new WaitForSeconds(2f);
         Destroy(gameObject);
     }
 
 }