using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	Node<int> tree;
	void Start () {
		tree = new Node<int>(1);
		tree.Add (2);
		tree.Add (3);
		tree.Add (4);
		tree.AddToChildren (5, 2);
		tree.AddToChildren (6, 2);
		tree.AddToChildren (7, 3);
		tree.AddToChildren (8, 4);
		tree.AddToChildren (9, 4);
		tree.DFS (tree);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
