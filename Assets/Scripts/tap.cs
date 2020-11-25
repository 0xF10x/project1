using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tap : MonoBehaviour, IPointerClickHandler 
{
	public bool k = false;
	
	[SerializeField] private List<Item> _Items;

	public void OnPointerClick(PointerEventData eventData){
    	
    	if (k == false) 
    	{
    	Instantiate(_Items[Random.Range(0, _Items.Count)], transform.position, Quaternion.identity);
    	k = true;
    	}
    }
}
