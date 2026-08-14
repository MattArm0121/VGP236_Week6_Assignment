using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    [SerializeField] Button shootButton;

    private GameObject currentTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Target target = hit.collider.GetComponent<Target>();

            if (target != null)
            {
                currentTarget = target.gameObject;
                shootButton.gameObject.SetActive(true);
            }
        }
    }

    public void Shoot()
    {
        if (currentTarget != null)
        {
            Destroy(currentTarget);
            currentTarget = null;
            shootButton.gameObject.SetActive(false);
        }
    }
}
