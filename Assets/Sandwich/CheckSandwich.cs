using Oculus.Interaction;
using Oculus.Interaction.Collections;
using OVR;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckSandwich : MonoBehaviour
{
    public Transform targetIngredient;
    public bool isSolved;
    private Rigidbody rigidbody;
    private BoxCollider boxCollider;
    public TextController myTextElement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetIngredient.position);
        if (distance < 0.05f && !isSolved)
        {
            IEnumerable<GrabInteractor> setInteractors = transform.GetChild(0).GetComponent<GrabInteractable>().Interactors;
            foreach (GrabInteractor interactor in setInteractors) { interactor.Unselect(); }
            transform.SetPositionAndRotation(targetIngredient.position, targetIngredient.rotation);
            targetIngredient.gameObject.SetActive(false);
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            boxCollider.enabled = false;
            isSolved = true;
            myTextElement.UpdateText();
        }

    }
}
