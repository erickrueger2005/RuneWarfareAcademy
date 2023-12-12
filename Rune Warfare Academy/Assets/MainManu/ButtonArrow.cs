using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonArrow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject arrowPrefab; // Drag your arrow GameObject here in the Unity Editor

    private GameObject arrowInstance;

    [SerializeField] private float offset = 130f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Maus schwebt über dem Button
        //arrowInstance = Instantiate(arrowPrefab, transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
        arrowInstance = Instantiate(arrowPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        arrowInstance.transform.SetParent(transform, false);
        arrowInstance.transform.position += Vector3.right * offset;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Maus hat den Button verlassen
        Destroy(arrowInstance);
    }
    private void OnDisable()
    {
        Destroy(arrowInstance);
    }
}