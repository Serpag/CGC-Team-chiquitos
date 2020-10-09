using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Projectile : MonoBehaviour {
     
     private Vector2 target;
     public float speed;

     Vector3 moveDirection;
 
     void Start()
     {
         target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 
         StartCoroutine(destroyAfterTime());
         
         moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
          moveDirection.z = 0;       
          moveDirection.Normalize();
        
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