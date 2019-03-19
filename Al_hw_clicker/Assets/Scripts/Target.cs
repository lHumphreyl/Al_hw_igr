using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int scoreValue = 1;
    public Material redMaterial;

    public Material[] mat;

    private MeshRenderer rend;

    private bool isRed = false;

    private void Start()
    {
        rend = GetComponent<MeshRenderer>();

        rend.material = mat[Random.Range(0, 5)];

        Destroy(gameObject, 3);
    }

    private void Update()
    {
        gameObject.transform.localScale += new Vector3(-0.01f, 0f, -0.01f);

        if (gameObject.transform.localScale.x <= 0.40f)
        {
                rend.material = redMaterial;
                isRed = true;
        }
    }

    void OnMouseDown()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if(isRed)
                GameManager.Instance.AddScore(scoreValue * 10);
            else
                GameManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
