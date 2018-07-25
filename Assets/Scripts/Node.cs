using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node<T>{
	List<Node<T>> children = new List<Node<T>>();
	Node<T> dad = null;
	T value;
	bool visited = false;
	public Node(T value){
	}
	public Node(T value,Node<T> dad){
		this.value = value;
		this.dad = dad;
	}
	public void Add(T value){
		Node<T> child = new Node<T> (value, this);
		children.Add (child);
	}
	public void AddToChildren(T value,T valueOfChild){
		foreach (Node<T> node in children) {
			if (node.value.Equals (valueOfChild)) {
				node.Add (value);
			}
		}
	}
	public bool HaveChildren(){
		if (this.children.Count == 0)
			return false;
		else
			return true;
	}
	public Node<T> FindValue(T value){
		foreach (Node<T> node in children) {
			if (node.value.Equals(value)) {
				return node;
			}
		}
		return null;
	}
	public void PrintChildren(){
		foreach (Node<T> node in children) {
			Debug.Log (node.value);
		}
	}
	public void PrintChildrenChildrens(T valueOfChild){
		foreach(Node<T> node in children){
			if (node.value.Equals (valueOfChild)) {
				Debug.Log ("Node with value " + valueOfChild + " have...");
				node.PrintChildren ();
			}
		}
	}
	public void DFS(Node<T> root){
		if (root.HaveChildren ()) {
			foreach (Node<T> node in children) {
				if (!node.visited) {
					node.visited = true;
					Debug.Log ("visiting " + node.value);
					node.DFS (node);
				}
			}
		}
	}
	public void BFS(Node<T> root,int depth){
		int level = 1;
		if (root.HaveChildren ()) {
			foreach (Node<T> node in children) {
				if (depth == level) {
					Debug.Log (node.value);
				} else {
					level++;
					node.BFS (node,level);
				}
			}

		}
	}
}
