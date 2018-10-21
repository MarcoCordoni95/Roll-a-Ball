using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public Text countText;
    public Text winText;

    public float speed;
    private int count;

    private void Start(){
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other){ // Riferimento al collider che tocca il player

        // Destroy(other.gameObject); // quell'oggetto viene distrutto, noi non useremo questo, disattiveremo quell'oggetto senza distruggerlo

        if (other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText(){
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
            winText.text = "You Win!";
    }
}
